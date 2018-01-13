using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using CapaDatos;
using CapaControlador;
using System.Text.RegularExpressions;

namespace CapaVista.Conductores
{
    public partial class AgregarConductor : MetroForm
    {
        public AgregarConductor()
        {
            InitializeComponent();
        }

        public Conductor temp;

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
                   string.IsNullOrEmpty(txtLicencia.Text) ? false : true;
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
                Regex r = new Regex(@"^([0-9]{1,2}[0-9])(-)([0-2][0-9]|3[0-1])(0[1-9]|1[0-2])([0-9]{1,2})(-)([0-9]{1,3}[0-9])([a-zA-Z])");
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
            txtLicencia.Clear();
        }

        /// <summary>
        /// Permite agregar un nuevo Conductor al controlador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool ban = this.Validaciones();
            if (ban)
            {
                int result = -1;
                try
                {
                    result = ConductorController.agregar(txtCedula.Text, txtNombres.Text, txtApellidos.Text, txtDirecion.Text, txtTelefono.Text, txtCorreo.Text, true, txtLicencia.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error durante la insercion de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (result > 0)
                {
                    MessageBox.Show("Conductor Agregado Correctamente!", "Registros Actualizados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarControles();
                }
                else if (result == 0)
                {
                    MessageBox.Show("No se ha podido Registrar Conductor", "Ya existe un conductor con ese numero de identificación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarControles();
                }
                else if(result < 0)
                {
                    MessageBox.Show("No se ha podido Ingresar", "Error durante la insercion",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
