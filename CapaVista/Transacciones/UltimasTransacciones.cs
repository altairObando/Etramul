using CapaControlador;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Vehiculos
{
    public partial class UltimasTransacciones : MetroForm
    {
        private List<CapaDatos.Transaccion> datos;

        public UltimasTransacciones(CapaDatos.Vehiculo data)
        {
            try
            {
                InitializeComponent();
                if (data.Transaccion.Count == 0)
                    throw new Exception("NO EXISTEN TRANSACCIONES PARA ESTE BUS");
                this.datos = data.Transaccion.ToList();
                this.lblCodigoPlaca.Text = data.Placa;
                //this.lblSaldo.Text = string.Format("{0:C}", CapaControlador.SaldoController.leer(data.Id_Vehiculo).Total_sado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        
        private void UltimasTransacciones_Load(object sender, EventArgs e)
        {
            try
            {
                if (datos.Count != 0)
                {
                    //Volteando la tortilla
                    llenarGrid(datos);
                    tbTOP.Value = datos.Count;
                    tbTOP.Maximum = datos.Count;
                    lblNumero.Text = tbTOP.Value.ToString();
                }
                else
                {
                    MessageBox.Show("Este vehiculo no posee transacciones", "SIN TRANSACCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void llenarGrid(List<CapaDatos.Transaccion> lista)
        {
            dgDatos.Rows.Clear();
            lista = lista.OrderByDescending(x => x.IdTransaccion).ToList();
            foreach (var item in lista)
            {
                var usuario = CapaControlador.UsuariosController.leer(item.Id_usuario);
                decimal ingreso = item.Egreso.Where(x => x.TipoTransaccion == 0).Sum(y => y.Cantidad);
                decimal egreso = item.Egreso.Where(x => x.TipoTransaccion == 1).Sum(y => y.Cantidad);
                var row = dgDatos.Rows.Add
                    (
            item.IdTransaccion, item.FechaTransaccion, usuario.ToString(), ingreso, egreso
                    );
            }
            dgDatos.Refresh();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbTOP_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                //Obtener el valor
            int valor = tbTOP.Value;
            //lbl -> valor
            lblNumero.Text = valor.ToString();
            //Actualizando lista
            List<CapaDatos.Transaccion> items = new List<CapaDatos.Transaccion>();
            for (int i = 0; i < valor; i++)
            {
                items.Add(datos[i]);
            }
            llenarGrid(items);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public object lista { get; set; }

        private void reset_Click(object sender, EventArgs e)
        {
            this.reset.Visible = false;
            llenarGrid(datos);
        }

        private void dgDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int valor = (int)dgDatos.SelectedRows[0].Cells[0].Value;
                var item = TransaccionController.leer(valor);
                if (item != null)
                {
                    Transacciones.DetalleTransaccion form = new Transacciones.DetalleTransaccion(item);
                    form.ShowDialog();
                }
                else
                    throw new Exception("Factura no encontrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void verDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgDatos_CellContentDoubleClick(sender, null);
        }
    }
}
