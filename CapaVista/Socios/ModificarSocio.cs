using CapaControlador;
using CapaDatos;
using MetroFramework.Forms;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaVista.Socios
{
    public partial class ModificarSocio : MetroForm
    {
        public ModificarSocio()
        {
            InitializeComponent();
        }

      
        /// <summary>
        /// Abre el formulario de busqueda de socio y devuelve la informacion de un socio al formulario actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var buscar = new BuscarSocio();
            buscar.ShowDialog();
            var socioMod = buscar.socio;
            if (socioMod!=null)
            {
                txtNombres.Text = socioMod.Personas.Nombres;
                txtApellidos.Text = socioMod.Personas.Apellidos;
                txtCedula.Text = socioMod.Personas.Identificacion;
                txtTelefono.Text = socioMod.Personas.Identificacion;
                txtDirecion.Text = socioMod.Personas.Direccion;
                txtCorreo.Text = socioMod.Personas.Correo;
                dtpF_asociacion.Value = socioMod.FechaAsociacion;
                //Para?
                //dgvSocio.Rows.Add(socioMod.Identificacion, socioMod.Nombres, socioMod.Apellidos, socioMod.Direccion, socioMod.Telefono, socioMod.Correo, socioMod.FechaAsociacion);
                habilitarEdicion(true);
            }
        }


        /// <summary>
        /// Guarda los nuevos datos de un socio existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
           //Instancia de administracion
           //Si el usuario no es administrador
            var permiso = MainContainer.sesion.Id_tipo;
            DialogResult admin = DialogResult.Yes;
            if(permiso!= 1)
            {
                var adminmodule = new Transacciones.Administracion("Guardar nuevo registro");
                adminmodule.ShowDialog();
                admin = adminmodule.resultado;
            }
            if (admin.Equals(DialogResult.Yes))
            {
                bool ban = Validaciones();
                if (ban)
                {
                    int result = -1;
                    try
                    {
                        result = SociosController.modificar(dtpF_asociacion.Value, txtCedula.Text, txtNombres.Text, txtApellidos.Text, txtDirecion.Text, txtTelefono.Text, txtCorreo.Text, rbtnActivo.Checked);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error durante la insercion de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (result > 0)
                    {
                        //dgvSocio.Rows.Clear();
                        var socioMod = SociosController.leerI(txtCedula.Text.Trim());
                        //dgvSocio.Rows.Add(socioMod.Identificacion, socioMod.Nombres, socioMod.Apellidos, socioMod.Direccion, socioMod.Telefono, socioMod.Correo, socioMod.FechaAsociacion);
                        limpiarControles();
                        MessageBox.Show("Socio Agregado Correctamente!", "Registros Actualizados",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload();
                        habilitarEdicion(false);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido Ingresar", "Error durante la insercion",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void reload()
        {
            var ls = SociosController.lista();
            if(ls!= null)
            {
                dgvSocio.Rows.Clear();
                foreach (Socio socioMod in ls)
                {
                    dgvSocio.Rows.Add(socioMod.Personas.Identificacion, socioMod.Personas.Nombres, socioMod.Personas.Apellidos, socioMod.Personas.Direccion, socioMod.Personas.Telefono, socioMod.Personas.Correo, socioMod.FechaAsociacion);
                }
            }
        }
        /// <summary>
        /// Valida que todos los campos del formulario no esten vacios
        /// </summary>
        /// <returns> Devuelve true si no hay campos vacios, de lo contrario false</returns>
        private bool CamposVacios()
        {
            bool band = true;

            band = string.IsNullOrEmpty(txtCedula.Text) ? false :
                   string.IsNullOrEmpty(txtNombres.Text) ? false :
                   string.IsNullOrEmpty(txtApellidos.Text) ? false :
                   string.IsNullOrEmpty(txtDirecion.Text) ? false :
                   string.IsNullOrEmpty(txtTelefono.Text) ? false :
                   string.IsNullOrEmpty(txtCorreo.Text) ? false :
                   string.IsNullOrEmpty(dtpF_asociacion.Text) ? false : true;
            if (!band)
                MessageBox.Show("Faltan datos por llenar!", "Todos los campos son requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return band;
        }


        /// <summary>
        /// Valida el numero de cedula
        /// </summary>
        /// <returns>Devuelve true si el formato de cedula es correcto, de lo contrario devuelve false</returns>
        private bool CedulaValida()
        {
            bool band = false;
            //Validar longitud de cedula
            if (txtCedula.TextLength == 16)
            {
                Regex r = new Regex(@"^([0-9]{1,2}[1-9])(-)([0-2][0-9]|3[0-1])(0[1-9]|1[0-2])([0-9]{1,2})(-)([0-9]{1,3}[1-9])([a-zA-Z])");
                if (r.IsMatch(txtCedula.Text))
                    band = true;
            }
            if (!band)
                MessageBox.Show("La cedula no Tiene el formato Correcto", "Verificar Cedula", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return band;
        }


        /// <summary>
        /// Ejecuta las validaciones del formulario
        /// </summary>
        /// <returns>Devulve true si todo esta correcto, de lo contrario devuelve false</returns>
        private bool Validaciones()
        {
            if (CamposVacios())
                if (CedulaValida())
                    return true;
                else
                    return false;
            else
                return false;

        }


        /// <summary>
        /// Limpia los controles del formulario
        /// </summary>
        private void limpiarControles()
        {
            txtCedula.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDirecion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ModificarSocio_Load(object sender, EventArgs e)
        {
            reload();
            habilitarEdicion(false);
        }
        private void habilitarEdicion(bool p)
        {
            txtNombres.Enabled = p;
            txtApellidos.Enabled = p;
            txtDirecion.Enabled = p;
            txtTelefono.Enabled = p;
            txtCorreo.Enabled = p;
            dtpF_asociacion.Enabled = p;
            btnGuardar.Enabled = p;
        }

        private void dgvSocio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtener la fila deseada
            string cedula = dgvSocio.SelectedRows[0].Cells[0].Value.ToString();
            var socioMod = SociosController.leerI(cedula);
            if (socioMod != null)
            {
                txtNombres.Text = socioMod.Personas.Nombres;
                txtApellidos.Text = socioMod.Personas.Apellidos;
                txtCedula.Text = socioMod.Personas.Identificacion;
                txtTelefono.Text = socioMod.Personas.Identificacion;
                txtDirecion.Text = socioMod.Personas.Direccion;
                txtCorreo.Text = socioMod.Personas.Correo;
                dtpF_asociacion.Value = socioMod.FechaAsociacion;
                //Para?
                //dgvSocio.Rows.Add(socioMod.Identificacion, socioMod.Nombres, socioMod.Apellidos, socioMod.Direccion, socioMod.Telefono, socioMod.Correo, socioMod.FechaAsociacion);
                habilitarEdicion(true);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var nuevo = new AgregarSocio();
            nuevo.ShowDialog();
            reload();
        }
    }
}
