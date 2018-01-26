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
            listTemp = null;

        }


        private DataTable abonosTable;

        private List<Transaccion> listTemp;

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
                List<CapaDatos.Vehiculo> vehiculos = VehiculosController.lista(new Vehiculo()).OrderBy(x => x.Placa).ToList();
                cboVehiculo.DataSource = vehiculos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "No se Cargo toda la informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = (Vehiculo)cboVehiculo.SelectedItem;
            List<Transaccion> lista = vehiculo.Transaccion.ToList();
            LlenarData(lista);
            
        }

        void LlenarData(List<Transaccion> lista)
        {
            try
            {
                List<Transaccion> nueva = null;
                foreach (var item in lista)
                {
                    foreach (var det in item.Egreso)
                    {
                        if (det.TipoTransaccion == 2 && det.Cancelado == false)
                            nueva.Add(item);
                    }
                }
                if (nueva != null)
                {
                    foreach (var item in nueva)
                    {
                        foreach (var item2 in item.Egreso)
                        {
                            abonosTable.Rows.Add(item.IdTransaccion, item.FechaTransaccion.ToShortDateString(), item2.TipoEgreso.Descripcion, item2.Cantidad, item2.Saldo_detalle.Saldo);
                            //dgvCreditos.Rows.Add(item.IdTransaccion, item.FechaTransaccion.ToShortDateString(), item2.TipoEgreso.Descripcion, item2.Cantidad, item2.Saldo_detalle.Saldo);
                        }
                    }
                    this.listTemp = nueva;
                    dgvCreditos.DataSource = abonosTable;
                }
                else
                    throw new Exception("No hay creditos pendientes para este bus");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cmsAbono_Click(object sender, EventArgs e)
        {
            
        }
    }
}
