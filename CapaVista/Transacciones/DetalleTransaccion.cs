using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaControlador;
using MetroFramework.Forms;

namespace CapaVista.Transacciones
{
    public partial class DetalleTransaccion : MetroForm
    {
        public DetalleTransaccion(CapaDatos.Transaccion codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            if (MainContainer.sesion.TipoUsuario.Descripcion == "Administrador")
            {
                btnCancelar.Enabled = false;lblAnulacion.Visible = false;
            }
            if (!this.codigo.Activo)
            {
                btnCancelar.Enabled = false;
                lblAnulacion.Visible = true;
                this.lblAnulacion.Text = "ESTA FACTURA HA SIDO ANULADA";
            }
        }        
        private Transaccion codigo;
        
        private void DetalleTransaccion_Load(object sender, EventArgs e)
        {
            try
            {
                lblNumero.Text = codigo.IdTransaccion.ToString();
                lblfecha.Text = codigo.FechaTransaccion.ToShortDateString();
                lblCajero.Text = (UsuariosController.leer(codigo.Id_usuario)).ToString();
                lblPlaca.Text = codigo.Vehiculo.Placa;
                dgvEgresos.Rows.Clear();
                decimal valor1 = 0, valor2 = 0;
                foreach (var item in codigo.Egreso)
                {
                    string texto = item.TipoTransaccion == 1 ? "INGRESO" : item.TipoTransaccion == 0 ? "EGRESO": "CREDITO";
                    dgvEgresos.Rows.Add(item.TipoEgreso.IdTipoDetalle, item.TipoEgreso.Descripcion, item.Descripcion, texto, item.Cantidad);
                    if (item.TipoTransaccion == 1)
                        valor1 += item.Cantidad;
                    else if(item.TipoTransaccion == 0)
                        valor2 += item.Cantidad;
                }
                lblTotal.Text = "C$ " + (valor1 - valor2).ToString();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            var admin = new Administracion("Confirme la eliminacion del registro numero: " + codigo.IdTransaccion);
            admin.ShowDialog();
            result = admin.resultado;
            if (DialogResult.Yes.Equals(result))
            {
                try
                {
                    var an = TransaccionController.anular(codigo.IdTransaccion);
                    if (an < 0)
                        throw new Exception("No se pudo eliminar la transaccion");
                    else
                        MessageBox.Show("Factura #" + codigo.IdTransaccion+"  ha sido anulada correctamente",
                            "Factura Anulada", MessageBoxButtons.OK, MessageBoxIcon.Information
                            );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
