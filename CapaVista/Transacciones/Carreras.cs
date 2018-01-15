using CapaControlador;
using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Windows.Forms;
namespace CapaVista.Transacciones
{
    public partial class Carreras : MetroForm
    {
        public Carreras()
        {
            InitializeComponent();
        }

        private void Carreras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transaccionesDataSet.CarrerasTable' Puede moverla o quitarla según sea necesario.
            transaccionesDataSet.EnforceConstraints = false;
            btnFiltrar_Click(null, null);
            //this.carrerasTableTableAdapter.FillCarreras(this.transaccionesDataSet.CarrerasTable);
            lblRestablecer.Visible = false;
            this.lblUser.Text = MainContainer.sesion.Nickname;
            this.dtFiltroFecha.Value = DateTime.Now;
        }

        private void tbNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            this.lblTrackValue.Text = tbNumeroRegistros.Value.ToString();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            lblRestablecer.Visible = true;
            DateTime fecha = dtFiltroFecha.Value.Date;
            int tope = int.Parse(lblTrackValue.Text);
            this.carrerasTableTableAdapter.FillByFechaTOP(this.transaccionesDataSet.CarrerasTable, tope, fecha);
        }

        private void lblRestablecer_Click(object sender, EventArgs e)
        {
            this.carrerasTableTableAdapter.FillCarreras(this.transaccionesDataSet.CarrerasTable);
            btnFiltrar.Font = lblRestablecer.Font;
            lblRestablecer.Visible = false;

        }

        private void Menu_Opening(object sender, CancelEventArgs e)
        {
            if (dgvCarreras.RowCount == 0)
                this.menu.Enabled = false;
            else
                this.menu.Enabled = true;
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(dgvCarreras.GetClipboardContent());
        }
        /// <summary>
        /// Muestra la informacion complementaria del socio
        /// al cual le pertenece el vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void socioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra informacion de solo lectura del socio involucrado
            try
            {
                //Obtenemos la placa del vehiculo
                string placa = dgvCarreras.SelectedRows[0].Cells[3].Value.ToString();
                // con la placa buscamos el codigo del socio
                int cod_socio = VehiculosController.leer(placa).Id_socio;
                // Obtenemos el socio que se desea mostrar (Solo de lectura)
                var socio = SociosController.leer(cod_socio);
                //nueva instancia del form para mostrar los datos.
                var form = new Socios.ModificarSocio();
                //seteamos los valores
                form.txtCedula.Text = socio.Personas.Identificacion;
                form.txtNombres.Text = socio.Personas.Nombres;
                form.txtApellidos.Text = socio.Personas.Apellidos;
                form.txtCorreo.Text = socio.Personas.Correo;
                form.txtDirecion.Text = socio.Personas.Direccion;
                form.txtTelefono.Text = socio.Personas.Telefono;
                form.dtpF_asociacion.Value = socio.FechaAsociacion;
                if (socio.Personas.Activo)
                    form.rbtnActivo.Checked = true;
                else
                    form.rbtnInactivo.Checked = true;
                //Inhabilitamos todos los controles
                foreach (Control item in form.Controls)
                {
                    item.Enabled = false;
                }
                //Habilitamos el boton de salir
                form.btnCancelar.Enabled = true;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Permite la eliminacion logica de un registro
        /// en la tabla de las carreras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void anularCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Confirmacion de eliminacion
            DialogResult result;
            if (!MainContainer.sesion.TipoUsuario.Descripcion.Equals("Administrador"))
            {
                var admin = new Administracion("Confirme la eliminacion del registro numero: " + dgvCarreras.SelectedRows[0].Cells[0].Value);
                admin.ShowDialog();
                result = admin.resultado;
            }
            else
                result = DialogResult.Yes;
            //Verificando seleccion
            if(DialogResult.Yes.Equals(result))
            {
                try
                {
                    //Obtencion del codigo de la carrera
                    int codigo = (int)dgvCarreras.SelectedRows[0].Cells[0].Value;
                    //Buscamos la carrera 
                    int eliminado = CarreraController.Eliminar(codigo);
                    if (eliminado > 0)
                    {
                        MessageBox.Show("Registro Eliminado Correctamente!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnFiltrar_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error durante la eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mostrarEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Obtenemos el codigo de la carrera
            try
            {
                //Obtencion del codigo de la carrera
                int codigo = (int)dgvCarreras.SelectedRows[0].Cells[0].Value;
                //Instancia de formulario
                var detalle = new DetalleCarrera(codigo);
                detalle.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void conductorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                 var form = new CapaVista.Carrera();
                 form.ShowDialog();
                 this.carrerasTableTableAdapter.FillCarreras(this.transaccionesDataSet.CarrerasTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
    }
}
