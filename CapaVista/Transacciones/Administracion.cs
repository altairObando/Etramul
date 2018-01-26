using CapaControlador;
using MetroFramework.Forms;
using System.Windows.Forms;
namespace CapaVista.Transacciones
{
    public partial class Administracion : MetroForm
    {
        public Administracion()
        {
            InitializeComponent();
        }
        public Administracion(string Mensaje)
        {
            InitializeComponent();
            this.Mensaje = Mensaje;
        }
        public DialogResult resultado;
        /// <summary>
        /// Mensaje de la operacion que se desea realizar
        /// </summary>
        public string Mensaje;
        private void Administracion_Load(object sender, System.EventArgs e)
        {
            //Obtener los usuarios en el sistema
            var users = UsuariosController.getAdministradores();
            cboUsuario.DataSource = users;
        }
        
        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            //Obtencion de la informacion seleccionada
            string nick = ((CapaDatos.Usuarios)cboUsuario.SelectedItem).Nickname;
            string clave = txtClave.Text;
            //validando informacion complementaria
            if (!string.IsNullOrWhiteSpace(clave))
            {
                //verificando que la clave es valida
                var valid = UsuariosController.leer(nick, clave);
                if(valid != null) //Si el usuario es valido
                {
                    //Confirmar la realizacion de la operacion 
                    resultado = MessageBox.Show(Mensaje, "Confirmar Operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    this.Dispose();
                }
                else //Contraseña incorrecta
                {
                    this.lblError.Visible = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            resultado = System.Windows.Forms.DialogResult.Cancel;
            this.Dispose();
        }
    }
}
