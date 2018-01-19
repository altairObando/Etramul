using CapaControlador;
using CapaDatos;
using CapaVista.Reportes;
using CapaVista.Transacciones;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
namespace CapaVista
{
    public partial class Carrera : MetroForm
    {
        public Carrera()
        {
            InitializeComponent();
            LoadCombos();
        }

        private void Carrera_Load(object sender, EventArgs e)
        {
            this.lblNombreCajero.Text = MainContainer.sesion.Personas.Nombres;
            actualizarNoFactura();
        }

        private void actualizarNoFactura()
        {
            CapaDatos.Carrera ultima = CarreraController.getUltima();
            int numero;
            if (ultima == null)
                numero = 1;
            else
                numero = ultima.Id_carrera + 1;
            lblNoFactura.Text = string.Format("{0}", numero);
        }

        private void LoadCombos()
        {
            try
            {
                //Obteniendo listas
                Conductor[] conductores = ConductorController.lista().Where(x => x.Personas.Activo).OrderBy(x=> x.Personas.Nombres).ToArray();
                Vehiculo[] vehiculos = VehiculosController.lista(new Vehiculo()).Where(x => x.Activo).OrderBy(x=> x.Placa).ToArray();
                CapaDatos.TipoDetalle[] egr = TipoDetalleController.listar().Where(x => x.Activo).OrderBy(x=>x.Descripcion).ToArray();
                //Llenando combos
                cboConductor.Items.AddRange(conductores);
                cboVehiculo.Items.AddRange(vehiculos);
                cboEgresos.Items.AddRange(egr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "No se Cargo toda la informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboEgresos.SelectedItem == null)
                    throw new System.NullReferenceException("Para agregar un registro de egreso, primero seleccione un elemento del comboBox");
                int cod = ((CapaDatos.TipoDetalle)cboEgresos.SelectedItem).IdTipoDetalle;
                string tipo = ((CapaDatos.TipoDetalle)cboEgresos.SelectedItem).Descripcion;
                if (txtDescripcion.Text.Length == 0)
                    throw new ArgumentNullException("Es necesario ingresar la descripcion del egreso");
                string descripcion = txtDescripcion.Text;
                decimal monto = decimal.Parse(QuitarEspacios(txtMonto.Text));
                if (monto <= 0)
                    throw new FormatException("El valor del egreso no puede ser menor o igual a C$ 0.00 ");
                dgvEgresos.Rows.Add(cod, tipo, descripcion, monto);
                limpiarEgresos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limpiarEgresos()
        {
            //cboEgresos.ResetText();
            txtDescripcion.Clear();
            txtMonto.Clear();
            cboEgresos.Focus();
        }

        private string QuitarEspacios(string p)
        {
            string resultado = string.Empty;
            foreach (char item in p)
            {
                if (char.IsDigit(item) || item.Equals('.'))
                    resultado += item;
            }
            if (resultado.StartsWith("."))
                resultado = "0.00";
            if (resultado.EndsWith("."))
                resultado += "00";
            return resultado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validar Selecciones
            bool txts, cbos;
            txts = TextosValidos();
            cbos = CombosValidos();
            //fechas = FechasValidas();
            if(txts && cbos)
            {
                try
                {                    
                    //Obtencion de la informacion para registrar una carrera
                    int id_cajero = MainContainer.sesion.Personas.Id_persona;
                    int id_conductor = ((Conductor)cboConductor.SelectedItem).Id_conductor;
                    int id_vehiculo = ((Vehiculo)cboVehiculo.SelectedItem).Id_Vehiculo;
                    DateTime Fecha = dtFecha.Value.Date;
                    TimeSpan salida = dtSalida.Value.TimeOfDay;
                    TimeSpan llegada = dtLlegada.Value.TimeOfDay;
                    bool vuelta = cbVueltaCompleta.Checked;
                    //Agregando Transaccion
                    int t = TransaccionController.agregar(id_cajero, id_vehiculo, Fecha, true);
                    //Comprobamos que se haya insertado la transaccion
                    if (t > 0)
                    {
                        //Obtenemos el id de la ultima transaccion
                        int idTransaccion = TransaccionController.getUltima().IdTransaccion;
                        t = CarreraController.Agregar(idTransaccion, id_vehiculo, id_conductor, salida, llegada, Fecha, vuelta);
                        //Si se inserto correctamente la carrera, procedemos a ingresar los gastos
                        if (t > 0)
                        {
                            t = 0;
                            decimal ingreso = Decimal.Parse(QuitarEspacios(txtIngreso.Text));
                            //Registrando Ingreso
                            t = DetalleController.agregar(idTransaccion, TipoDetalleController.leer("CICLO").IdTipoDetalle, "CICLO", ingreso, true, true);
                            //Verificando y registrando los egresos
                            decimal totalEgreso = 0;
                            if(dgvEgresos.Rows.Count > 0) // Si hay egresos
                            {
                                for (int j = 0; j < dgvEgresos.RowCount; j++)
                                {
                                    int id_egreso = (int)dgvEgresos.Rows[j].Cells[0].Value;
                                    string descripcion = dgvEgresos.Rows[j].Cells[2].Value.ToString();
                                    decimal monto = (decimal)dgvEgresos.Rows[j].Cells[3].Value;
                                    totalEgreso += monto;
                                    t += DetalleController.agregar(idTransaccion, id_egreso, descripcion, monto, false, true);
                                }
                            }
                            // se actualiza el saldo del vehiculo
                            ActualizarSaldo();
                            if (t == 0) //Si no se registraron transacciones
                                throw new Exception("No se registraron las transacciones de Entrada/Salida!");
                            //Se imprime la factura
                            else
                            {
                                var result = MessageBox.Show("Imprimir factura?", "Confirme Impresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result.Equals(DialogResult.Yes))
                                {
                                    var ultima = CarreraController.getUltima();
                                    //var cond = ConductorController.leer(ultima.Id_conductor);
                                    //Creando instancia de reporte
                                    TicketFisicoForm ticket = new TicketFisicoForm(
                                        CapaControlador.TransaccionController.getUltima().IdTransaccion,
                                        ultima.FechaCarrera.ToShortDateString(),
                                        MainContainer.sesion.ToString(),
                                        ultima.Vehiculo.Placa,
                                        ultima.Vehiculo.Socio.ToString(),
                                        cboConductor.SelectedItem.ToString(),
                                        ingreso,
                                        totalEgreso,
                                        (ingreso - totalEgreso)
                                        );
                                    ticket.ShowDialog();
                                }
                                limpiarControles();
                                actualizarNoFactura();
                            }
                        }
                        else
                            throw new Exception("No se Completo el registro de la carrera");
                    }                    
                    else
                    {
                        throw new Exception("No se Ingreso la carrera");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos!", "Faltan campos por completar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Este metodo permite actualizar el saldo del vehiculo que realizo la ultima carrera
        /// </summary>
        private void ActualizarSaldo()
        {
            //Obtenemos la ultima carrera mediante la ultima transaccion
            var u = TransaccionController.getUltima();
            // Agregamos el monto del ingreso
            foreach (var item in u.Egreso)
            {
                SaldoController.actualizar(item.Transaccion.Id_Vehiculo, (float)item.Cantidad, item.TipoTransaccion, item.IdTransaccion);
            }
        }
        private void limpiarControles()
        {
            txtIngreso.Clear();
            limpiarEgresos();
            dgvEgresos.Rows.Clear();
            
        }
        private bool TextosValidos()
        {
            bool valido = true;
            if (QuitarEspacios(txtIngreso.Text).Equals("0.00"))
                valido = false;
            return valido;
        }
        private bool CombosValidos()
        {
            bool valido = cboConductor.SelectedIndex == -1 ? false :
                cboVehiculo.SelectedIndex == -1 ? false : true;
            if (!valido)
                MessageBox.Show("Seleccione un elemento de las listas desplegables", "No se han seleccionado elementos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return valido;
        }
        private bool FechasValidas()
        {
            bool valido = true;
            if (dtFecha.Value.Date > DateTime.Now.Date)
                valido = false;
            if (dtLlegada.Value.TimeOfDay < dtSalida.Value.TimeOfDay)
                valido = false;
            if(!valido)
                MessageBox.Show("Verifique los campos de Fecha/Hora", "Fecha/Hora no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return valido;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var seleccion = dgvEgresos.SelectedRows[0];

        }
    }
}
