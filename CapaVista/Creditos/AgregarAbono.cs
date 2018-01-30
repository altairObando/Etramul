using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using CapaControlador;
using CapaDatos;
namespace CapaVista.Creditos
{
    public partial class AgregarAbono : MetroFramework.Forms.MetroForm
    {
       
        public AgregarAbono()
        {
            InitializeComponent();
            loadTransaccion();
            loadCombos();
            this.creditosDataset.EnforceConstraints = false;
        }
        void ActualizarNoFactura()
        {
            try
            {
                var ultima = TransaccionController.getUltima();
                if (ultima != null)
                    lblFactura.Text = String.Format("{0}", ultima.IdTransaccion + 1);
                else
                    lblFactura.Text = "1";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener el numero de facturacion actual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadTransaccion()
        {
            try
            {
                //lblNombreCajero.Text = MainContainer.sesion.Personas.Nombres;
                ActualizarNoFactura();
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
                List<Vehiculo> vehiculos = VehiculosController.lista(new Vehiculo()).OrderBy(x => x.Placa).ToList();
                cboVehiculo.DataSource = vehiculos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "No se Cargo toda la informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       private void cmsAbono_Click(object sender, EventArgs e)
        {
            
        }
        private int getVehiculoIndex()
        {
            int index = 0;
            try
            {
                index = ((Vehiculo)cboVehiculo.SelectedItem).Id_Vehiculo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return index;
        }
        private void AgregarAbono_Load(object sender, EventArgs e)
        {
            try
            {
                HabilitarSeleccion(true);
                this.creditosDataset.EnforceConstraints = false;
                cREDITOS_PENDIENTESTableAdapter.Fill(this.creditosDataset.CREDITOS_PENDIENTES, getVehiculoIndex());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgregarAbono_Load(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                var result = MessageBox.Show(
                    @"Confirme la insercion del abono", "Agregar el abono?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result.Equals(DialogResult.Yes))
                {
                    decimal monto = int.Parse(txtMonto.Text);
                    //Obteniendo el codigo de el detalle a abonar
                    int id = (int)dgvCreditos.SelectedRows[0].Cells["Detalle"].Value;
                    //Obteniendo el codigo del vehiculo
                    int id_vehiculo = ((Vehiculo)cboVehiculo.SelectedItem).Id_Vehiculo;
                    //Registramos la transaccion
                    int i = TransaccionController.agregar(MainContainer.sesion.Id_usuario, id_vehiculo, DateTime.Now.Date, true);
                    if (i > 0)
                    {
                        //si se guardo el encabezado de la factura
                        int j = _AbonoController.Agregar(TransaccionController.getUltima().IdTransaccion, id, monto);
                        if (j > 0)
                        {
                            MessageBox.Show("Abono Agregado Correctamente!", "Cambios Guardados");
                            //Mostramos factura
                            var tra = TransaccionController.getUltima();
                            var abono = _AbonoController.getAllAbono().OrderByDescending(x => x.Id_transaccion).FirstOrDefault();
                            var form = new Factura_Abono(
                               tra.Vehiculo.Placa, tra.IdTransaccion, tra.FechaTransaccion,
                               MainContainer.sesion.Nickname, abono.Detalle.IdTransaccion, 
                               abono.Detalle.Transaccion.FechaTransaccion, abono.Detalle.TipoEgreso.ToString(),
                               abono.Detalle.Cantidad, abono.Monto, (abono.Detalle.Cantidad - abono.Monto)
                                );
                            form.ShowDialog();
                            //Recargamos los datos
                            AgregarAbono_Load(sender, e);
                        }
                        else
                            throw new Exception("No se ha logrado la insercion del Abono!!!");
                    }
                    else
                        throw new NullReferenceException("No se ha registrado la transaccion", new Exception("El codigo de la transaccion no se genero correctamente!"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error durante la insercion de la factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registrarAbonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HabilitarSeleccion(false);
        }
        private void HabilitarSeleccion(bool band)
        {
            panelDatos.Enabled = band;
            dgvCreditos.Enabled = band;
            panelOpciones.Enabled = !band;
        }
        private void cmsAbono_Opening(object sender, CancelEventArgs e)
        {
            //Verificando que hayan creditos y se haya seleccionado al menos un credito
            if (dgvCreditos.SelectedRows.Count > 0)
                cmsAbono.Enabled = true;
            else
                cmsAbono.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarSeleccion(true);
            cboVehiculo.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
