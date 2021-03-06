﻿using CapaControlador;
using CapaDatos;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace CapaVista.Transacciones
{
    public partial class AgregarTransaccion : MetroForm
    {
        public AgregarTransaccion()
        {
            InitializeComponent();
            loadTransaccion();
            this.lblUser.Text = MainContainer.sesion.Personas.ToString();
            loadCombos();
            lblTotal.Text = string.Format("{0:C2}", totalFactura);
        }

        void loadTransaccion()
        {
            try
            {
                //lblNombreCajero.Text = MainContainer.sesion.Personas.Nombres;
                ActualizarNoFactura();
                totalFactura = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error del modulo facturacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadCombos()
        {
            try
            {
                List<CapaDatos.Vehiculo>vehiculos = VehiculosController.lista(new Vehiculo()).OrderBy(x => x.Placa).ToList();
                List<CapaDatos.TipoDetalle> egr = TipoDetalleController.listar().OrderBy(x=> x.Descripcion).ToList();

                cboVehiculo.DataSource = vehiculos;
                cboEgresos.DataSource = egr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "No se Cargo toda la informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        void ActualizarNoFactura()
        {
            try
            {
                var ultima = TransaccionController.getUltima();
                if (ultima != null)
                    lblNoFactura.Text = String.Format("{0}", ultima.IdTransaccion + 1);
                else
                    lblNoFactura.Text = "1";
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        private static decimal totalFactura;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string valor;
            try
            {
                if(cboEgresos.SelectedItem == null)
                    throw new NullReferenceException("Para agregar un registro, primero seleccione un elemento de la lista");
                int cod = ((CapaDatos.TipoDetalle)cboEgresos.SelectedItem).IdTipoDetalle;
                string tipo = ((CapaDatos.TipoDetalle)cboEgresos.SelectedItem).Descripcion;
                if (txtDescripcion.Text.Length == 0)
                    throw new ArgumentNullException("Es necesario ingresar la descripcion del egreso");
                string descripcion = txtDescripcion.Text;
                decimal monto = decimal.Parse(QuitarEspacios(txtMonto.Text));
                if (monto <= 0)
                    throw new FormatException("El valor de la transacción no puede ser menor o igual a C$ 0.00 ");
                valor = (rbtnIngreso.Checked) ? "INGRESO" : rbtnEgreso.Checked ? "EGRESO" : "CREDITO";
                dgvEgresos.Rows.Add(cod, tipo, descripcion, valor, monto);
                limpiarEgresos();
                txtDescripcion.Text = "SIN DEFINIR";
                actualizarTotal();
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void limpiarEgresos()
        {
            cboEgresos.ResetText();
            //txtDescripcion.Clear();
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
            if (CombosValidos())
            {
                var confirmacion = MessageBox.Show("Guardar Factura?", "Los Cambios no se pueden deshacer!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );
                if(confirmacion.Equals(DialogResult.Yes))
                {
                    try
                    {
                        //Obtiendo el encabezado de la transaccion
                        int id_cajero = MainContainer.sesion.Personas.Id_persona;
                        int id_vehiculo = ((Vehiculo)cboVehiculo.SelectedItem).Id_Vehiculo;
                        DateTime Fecha = dtFecha.Value.Date;
                        //Insertando la transaccion
                        int i = TransaccionController.agregar(id_cajero, id_vehiculo, Fecha, true);
                        //Si la transaccion tuvo exito
                        if (i > 0)
                        {
                            int t = 0;
                            //Obtiendo el utimo id de la transaccion
                            int idTransaccion = TransaccionController.getUltima().IdTransaccion;
                            decimal ing = 0;
                            decimal eg = 0;
                            for (int j = 0; j < dgvEgresos.Rows.Count; j++)
                            {
                                int TipoDetalle = (int)dgvEgresos.Rows[j].Cells[0].Value;
                                string Descripcion = (string)dgvEgresos.Rows[j].Cells[2].Value;
                                string tipo = dgvEgresos.Rows[j].Cells[3].Value.ToString();
                                int tpTransaccion = 0; //Egreso
                                if (tipo.Equals("INGRESO"))
                                    tpTransaccion = 1;
                                else if (tipo.Equals("CREDITO"))
                                    tpTransaccion = 2;

                                decimal monto = (decimal)dgvEgresos.Rows[j].Cells[4].Value;

                                t = DetalleController.agregar(idTransaccion, TipoDetalle, Descripcion, monto, tpTransaccion, true);
                                float dec = Convert.ToSingle(monto);

                                if (tipo == "INGRESO")
                                    ing += monto;
                                   
                                else if(tipo.Equals("EGRESO"))
                                    eg += monto;
                                totalFactura = 0;
                            }
                            if (t == 0) //Si no se registraron transacciones
                                throw new Exception("No se registraron las transacciones de Entrada/Salida!");
                            else
                            {
                                decimal total = ing - eg;
                                MessageBox.Show("Se ha insertado la transacion", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ImprimirTicket(idTransaccion, MainContainer.sesion.ToString(), ((Vehiculo)cboVehiculo.SelectedItem).Placa, total, ing, eg);
                                LimpiarControles();
                            }

                        }
                        else
                        {
                            throw new Exception("No se pudo insertar la transaccion");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos!", "Faltan campos por completar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool CombosValidos()
        {
            bool valido = cboVehiculo.SelectedIndex == -1 ? false :
                         cboEgresos.SelectedIndex == -1 ? false : true;
            if (!valido)
                MessageBox.Show("Seleccione un elemento de las listas desplegables", "No se han seleccionado elementos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return valido;
        }

        private bool TextoValido()
        {
            bool valido = (!String.IsNullOrWhiteSpace(txtDescripcion.Text) && !String.IsNullOrEmpty(txtDescripcion.Text));
            if(!valido)
                MessageBox.Show("Seleccione un elemento de las listas desplegables", "No se han seleccionado elementos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return valido;
        }

        private void ImprimirTicket(int codTransaccion, string Cajero, string Placa, decimal total, decimal ingreso, decimal egreso)
        {
            //ticket.SetParameterValue("Cajero", Cajero);
            //ticket.SetParameterValue("Placa", Placa);
            //ticket.SetParameterValue("Total", total);
            //ticket.SetParameterValue("Ingresos", ingreso);
            //ticket.SetParameterValue("Egresos", egreso);
            //Conexiones.SetReportConexion(ticket);
            //var visor = new VisorReportes();
            //visor.Visor.ReportSource = ticket;
            //visor.ShowDialog();
            Form ticket = new Reportes.ImprimirFactura(codTransaccion, Cajero, Placa, dtFecha.Value.Date);
            ticket.Show();
        }
       
        void LimpiarControles()
        {
            txtDescripcion.Text = "SIN DEFINIR";
            txtMonto.Text = null;
            dgvEgresos.Rows.Clear();
            loadTransaccion();
        }

        private void AgregarTransaccion_Load(object sender, EventArgs e)
        {
            if (!MainContainer.sesion.TipoUsuario.Descripcion.Equals("Cajero"))
                lblSalir.Visible = false;
            else
                lblSalir.Visible = true;
        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Obtener la fila seleccionada
            int fila = dgvEgresos.SelectedRows[0].Index;
            dgvEgresos.Rows.RemoveAt(fila);
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {

            if (cboVehiculo.SelectedItem == null)
                MessageBox.Show("SELECCIONE UN VEHICULO", "NO HAY VEHICULO SELECCIONADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                CapaDatos.Vehiculo car = ((CapaDatos.Vehiculo)cboVehiculo.SelectedItem); 
                if (car.Transaccion.Where(x => x.FechaTransaccion == DateTime.Now.Date).ToList().Count != 0)
                {
                    Form ticket = new Reportes.ver_hoy_form(car.Id_Vehiculo, dtFecha.Value.Date, car.Placa);
                    ticket.ShowDialog();
                }else
                {
                    MessageBox.Show("No se han registrados movimientos para el vehiculo seleccionado");
                }
            }

        }
        private decimal getTotal(Vehiculo vehiculo)
        {
            decimal ingreso=0;
            decimal egreso=0;
            foreach (var  item in vehiculo.Transaccion)
            {
                if (item.FechaTransaccion == DateTime.Now.Date)
                {
                    foreach (var it in item.Egreso)
                    {
                        if (it.TipoTransaccion == 1)
                            ingreso += it.Cantidad;
                        else if(it.TipoTransaccion == 0)
                            egreso += it.Cantidad;
                    }
                }
            }

            return (ingreso - egreso);
            
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new Creditos.AgregarAbono();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!!");
            }
        }

        private void cambiarTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dgvEgresos.SelectedRows[0].Index;
                bool tpTransaccion = dgvEgresos.Rows[fila].Cells[3].Value.ToString() == "INGRESO" ? true : false;
                if (tpTransaccion)
                {
                    dgvEgresos.Rows[fila].Cells[3].Value = "EGRESO";
                }
                else
                {
                    dgvEgresos.Rows[fila].Cells[3].Value = "INGRESO";
                }
                actualizarTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cambiar los tipos");
            }
        }

        private void actualizarTotal()
        {
            totalFactura = 0;
            for (int i = 0; i < dgvEgresos.Rows.Count; i++)
            {
                if(dgvEgresos.Rows[i].Cells[3].Value.ToString() == "INGRESO")
                    totalFactura += (decimal)dgvEgresos.Rows[i].Cells[4].Value;
                else 
                    if(dgvEgresos.Rows[i].Cells[3].Value.ToString() == "EGRESO")
                        totalFactura -= (decimal)dgvEgresos.Rows[i].Cells[4].Value;
            }
            lblTotal.Text = string.Format("{0:C2}", totalFactura);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFac.Text) && !String.IsNullOrWhiteSpace(txtFac.Text))
            {
                try
                {
                    int num = Convert.ToInt32(txtFac.Text.Trim());
                    var item = TransaccionController.leer(num);
                    if (item != null)
                    {
                        var form =  new DetalleTransaccion(item);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("EL NUMERO DE FACTURA INGRESADO NO EXISTE", "NO EXISTE TRANSACCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ActualizarNoFactura();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("INGRESE EL NUMERO DE LA FACTURA A BUSCAR", "NUMERO DE FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            Personas persona = MainContainer.sesion.Personas;
            CambiarContraseña form = new CambiarContraseña(persona);
            form.ShowDialog();
        }
    }
}
