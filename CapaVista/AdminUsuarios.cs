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
namespace CapaVista
{
    public partial class AdministrarUsuarios : MetroForm
    {
        public AdministrarUsuarios()
        {
            InitializeComponent();
            loadTipos();
            loadGrid();
            edicion = false;
        }
        private void loadTipos()
        {
            List<TipoUsuario> ls = TipoUsuarioController.listar();
            //TipoUsuario[] ls = TipoUsuarioController.listar().ToArray();
            if (ls != null)
                this.cboTipos.Items.AddRange(ls.ToArray());
            else
                MessageBox.Show("No se pudieron cargar los tipos de Usuarios!", "Errores durante la obtencion de datos.");
        }
        private bool edicion;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validando
            bool band = EjecutarValidaciones();
            if (band)
            {
                TipoUsuario t = (TipoUsuario)cboTipos.SelectedItem;
                int result = -1;
                try
                {
                    if (!edicion)
                    result = UsuariosController.agregar(
                        txtCedula.Text, txtNombres.Text, txtApellidos.Text,
                        txtDirecion.Text, txtTelefono.Text, txtCorreo.Text, true,
                        txtNick.Text, txtclave.Text, t.Id_tipo);
                    else
                    {
                        result = UsuariosController.modificar(
                                txtCedula.Text, txtNombres.Text, txtApellidos.Text,
                                txtDirecion.Text, txtTelefono.Text, txtCorreo.Text, true,
                                txtNick.Text, txtclave.Text, t.Id_tipo);
                        edicion = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error durante la insercion de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (result > 0)
                {
                    MessageBox.Show("Usuario Agregado Correctamente!", "Registros Actualizados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarControles();
                    loadGrid();
                }
                else
                {
                    MessageBox.Show("No se ha podido Ingresar", "Error durante la insercion",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void limpiarControles()
        {
            txtCedula.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDirecion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNick.Clear();
            txtclave.Clear();
            txtClave2.Clear();
            cboTipos.Text = "";
            cboTipos.SelectedItem = -1;
        }
        private void loadGrid()
        {
            dgvUsuarios.Rows.Clear();
            List<Usuarios> ls = null;
            ls = UsuariosController.lista();
            if(ls != null)
            foreach (Usuarios item in ls)
            {
                dgvUsuarios.Rows.Add(
                    item.Personas.Identificacion, item.TipoUsuario, item.Nickname, item.Personas.Nombres, item.Personas.Apellidos, item.Personas.Correo, item.Personas.Telefono
                    );
            }
        }
        private Usuarios getUsuario()
        {
            //Obtener la fila seleccionada
            var fila = dgvUsuarios.SelectedRows[0];
            //Obtener la identificacion del usuario seleccionado.
            string id = fila.Cells[2].Value.ToString();
            //Obtener el usuario por identificacion
            Usuarios tmp = UsuariosController.leer(id);
            return tmp;
        }
        private void editarUsuario_Click(object sender, EventArgs e)
        {
            Usuarios tmp = getUsuario();
            if (tmp != null)
            {
                txtCedula.Text = tmp.Personas.Identificacion;
                txtNombres.Text = tmp.Personas.Nombres;
                txtApellidos.Text = tmp.Personas.Apellidos;
                txtTelefono.Text = tmp.Personas.Telefono;
                txtDirecion.Text = tmp.Personas.Direccion;
                txtCorreo.Text = tmp.Personas.Correo;
                txtNick.Text = tmp.Nickname;
                txtclave.Clear();
                txtClave2.Clear();
                txtCedula.Focus();
                edicion = true;
            }
        }

        private void eliminarMenuItem(object sender, EventArgs e)
        {
            Usuarios tmp = getUsuario();
            try
            {
                var message = MessageBox.Show("Desea eliminar al usuario: "+ tmp.Nickname,"Confirmacion de eliminacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(message.Equals(DialogResult.Yes))
                {
                    var res = new Transacciones.Administracion("Confirmar eliminacion del usuario").ShowDialog();
                    if(res.Equals(DialogResult.Yes))
                    {
                        UsuariosController.eliminar(tmp.Personas.Identificacion);
                        loadGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool EjecutarValidaciones()
        {
            if (Contenidos())
                if (CedulaValida())
                    if (Claves())
                        return true;
                    else
                        return false;
                else
                    return false;
            else
                return false;
              
        }

        private bool CedulaValida()
        {
            bool band = false;
            //Validar longitud de cedula
            if(txtCedula.TextLength == 16)
            {
Regex r = new Regex(@"^([0-9]{1,2}[1-9])(-)([0-2][0-9]|3[0-1])(0[1-9]|1[0-2])([0-9]{1,2})(-)([0-9]{1,3}[0-9])([a-zA-Z])");
                if (r.IsMatch(txtCedula.Text))
                    band = true;
            }
            if (!band)
                MessageBox.Show("La cedula no Tiene el formato Correcto", "Verificar Cedula", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return band;
        }
        private bool Claves()
        {
            bool band = false;
            //Validando contenido de clave
            if(!string.IsNullOrEmpty(txtclave.Text) && !string.IsNullOrEmpty(txtClave2.Text))
            {
                //Validando igualdad en claves.
                if (txtclave.Text.Equals(txtClave2.Text))
                    band = true;
            }
            if(!band)
                MessageBox.Show("Verifique las claves de acceso", "Claves no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return band;
        }
        private bool Contenidos()
        {
            bool band = true;

            band = string.IsNullOrEmpty(txtCedula.Text) ? false :
                   string.IsNullOrEmpty(txtNombres.Text) ? false :
                   string.IsNullOrEmpty(txtApellidos.Text) ? false :
                   string.IsNullOrEmpty(txtDirecion.Text) ? false :
                   string.IsNullOrEmpty(txtTelefono.Text) ? false :
                   string.IsNullOrEmpty(txtCorreo.Text) ? false :
                   string.IsNullOrEmpty(txtNick.Text) ? false :
                   string.IsNullOrEmpty(txtclave.Text) ? false :
                   string.IsNullOrEmpty(txtClave2.Text) ? false :
                   cboTipos.SelectedIndex == -1 ? false : true;
            if(!band)
                MessageBox.Show("Faltan datos por llenar!", "Todos los campos son requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return band;
        }

        private void txtApellidos_Click(object sender, EventArgs e)
        {

        }

        private void AdministrarUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
