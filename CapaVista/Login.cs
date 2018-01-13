using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using MetroFramework.Forms;
using CapaDatos;
namespace CapaVista
{
    public partial class Login : MetroForm
    {
        public Usuarios sesion;
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Arrancamos el spin :v para que parezca que trabajamos con hilos xdxdxd
            spin.Visible = true;
            spin.Spinning = true;
            //Obtenemos las credenciales
            string nick = txtNickname.Text.Trim();
            string clave = txtClave.Text.Trim();
            if (!string.IsNullOrWhiteSpace(nick) && !string.IsNullOrWhiteSpace(clave))
            {
                sesion = UsuariosController.leer(nick, clave);
                if (sesion != null)
                {
                    MessageBox.Show("Bienvenido " + sesion.Personas.Nombres + " " + sesion.Personas.Apellidos,
                           "Acceso al sistema concedido!",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error de usuario/Contraseña",
                                    "Error de autenticacion",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    this.txtClave.Focus();
                    this.txtClave.SelectAll();                    
                }
            }
            else
            {
                MessageBox.Show("Ingrese la informacion de inicio!");
            }
            spin.Spinning = false;
            spin.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error durante la conexion al servidor");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
       
    }
}
