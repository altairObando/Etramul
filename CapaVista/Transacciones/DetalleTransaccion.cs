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
        public DetalleTransaccion(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            if (MainContainer.sesion.TipoUsuario.Descripcion == "Administrador")
                btnCancelar.Enabled = false;
        }

        
        private int codigo;
        
        private void DetalleTransaccion_Load(object sender, EventArgs e)
        {
            try
            {
                var list = TransaccionController.leer(codigo);
                
                var list2 = DetalleController.listar(codigo);
                lblNumero.Text = list.IdTransaccion.ToString();
                lblfecha.Text = list.FechaTransaccion.Date.ToShortDateString();
                lblCajero.Text = UsuariosController.leer(list.Id_usuario).Personas.Nombres;
                lblPlaca.Text = list.Vehiculo.Placa;
                dgvEgresos.Rows.Clear();
                for (int i = 0; i < list2.Count; i++)
                {
                    string texto = list2[i].TipoTransaccion == 1 ? "INGRESO" : "EGRESO";
                    dgvEgresos.Rows.Add(list2[i].TipoEgreso.IdTipoDetalle, list2[i].TipoEgreso.Descripcion,
                                        list2[i].Descripcion, texto, list2[i].Cantidad);
                }
            }
            catch (Exception ex)
            { 

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            var admin = new Administracion("Confirme la eliminacion del registro numero: " + codigo);
            admin.ShowDialog();
            result = admin.resultado;
            if (DialogResult.Yes.Equals(result))
            {
                try
                {
                    var an = TransaccionController.anular(codigo);
                    if (an < 0)
                        throw new Exception("No se pudo eliminar la transaccion");
                    var list = DetalleController.listar(codigo);
                    for (int i = 0; i < list.Count; i++)
                    {
                        int j = DetalleController.anular(list[i].IdDetalle);
                        if (j < 0)
                            throw new Exception("No se ha podido eliminar");
                    }
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
