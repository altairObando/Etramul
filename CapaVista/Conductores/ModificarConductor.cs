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
    public partial class Conductores : MetroForm
    {
        public Conductores()
        {
            InitializeComponent();
            habilitarEdicion(false);
            reload();
        }
        private int id_edicion;
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
                Regex r = new Regex(@"^([0-9]{1,2}[1-9])(-)([0-2][0-9]|3[0-1])(0[1-9]|1[0-2])([0-9]{1,2})(-)([0-9]{1,4})([a-zA-Z])");
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


        private void habilitarEdicion(bool p)
        {
            txtCedula.Enabled = p;
            txtNombres.Enabled = p;
            txtApellidos.Enabled = p;
            txtDirecion.Enabled = p;
            txtTelefono.Enabled = p;
            txtCorreo.Enabled = p;
            txtLicencia.Enabled = p;
            btnGuardar.Enabled = p;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var buscar = new BuscarConductor();
            buscar.ShowDialog();
            var ConductorMod = buscar.conductor;
            if (ConductorMod!=null)
            {
                txtNombres.Text = ConductorMod.Personas.Nombres;
                txtApellidos.Text = ConductorMod.Personas.Apellidos;
                txtCedula.Text = ConductorMod.Personas.Identificacion;
                txtTelefono.Text = ConductorMod.Personas.Identificacion;
                txtDirecion.Text = ConductorMod.Personas.Direccion;
                txtCorreo.Text = ConductorMod.Personas.Correo;
                txtLicencia.Text = ConductorMod.Licencia;
                habilitarEdicion(true);
            }
        }

        private void reload()
        {
            var ls = ConductorController.lista(null);
            if (ls != null)
            {
                dgvConductor.Rows.Clear();
                foreach (Conductor item in ls)
                {
                    dgvConductor.Rows.Add(item.Personas.Identificacion, item.Personas.Nombres, item.Personas.Apellidos, item.Personas.Direccion, item.Personas.Telefono, item.Personas.Correo, item.Licencia);
                }
            }
        }

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
                        result = ConductorController.modificar(id_edicion,txtCedula.Text, txtNombres.Text, txtApellidos.Text, txtDirecion.Text, txtTelefono.Text, txtCorreo.Text, rbtnActivo.Checked, txtLicencia.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error durante la insercion de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (result > 0)
                    {
                        limpiarControles();
                        MessageBox.Show("Socio Agregado Correctamente!", "Registros Actualizados",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload();
                        habilitarEdicion(false);
                    }
                    else if (result == 0)
                    {
                        MessageBox.Show("No hubo cambios en el registro", "Registro sin Cambios",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (result < 0)
                    {
                        MessageBox.Show("No se ha podido Ingresar", "Error durante la insercion",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var nuevo = new AgregarConductor();
            nuevo.ShowDialog();
            reload();
        }

        private void dgvConductor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string cedula = dgvConductor.SelectedRows[0].Cells[0].Value.ToString();
            var ConductorMod = ConductorController.leerI(cedula);
            if (ConductorMod != null)
            {
                txtNombres.Text = ConductorMod.Personas.Nombres;
                txtApellidos.Text = ConductorMod.Personas.Apellidos;
                txtCedula.Text = ConductorMod.Personas.Identificacion;
                txtTelefono.Text = ConductorMod.Personas.Identificacion;
                txtDirecion.Text = ConductorMod.Personas.Direccion;
                txtCorreo.Text = ConductorMod.Personas.Correo;
                txtLicencia.Text = ConductorMod.Licencia;                
                habilitarEdicion(true);
                id_edicion = ConductorMod.Id_conductor;
            }
            
        }

        private void Conductores_Load(object sender, EventArgs e)
        {

        }

       
    }
}
