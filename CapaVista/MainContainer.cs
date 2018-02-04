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
using CapaVista.Socios;
using CapaVista.Transacciones;
//using CapaVista.Reportes;
//using CapaVista.Vehiculos;
//using CapaVista.Transacciones;
namespace CapaVista
{
    public partial class MainContainer : MetroForm
    {
        public static Usuarios sesion;
        public MainContainer()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //Permite la administracion de usuarios
            AdministrarUsuarios tmp = new AdministrarUsuarios();
            tmp.ShowDialog();
        }

        private void MainContainer_Load(object sender, EventArgs e)
        {
            this.Hide();
            //Habilita el inicio de sesion
            var login = new Login();
            login.ShowDialog();
            sesion = login.sesion;
            if (sesion == null)
                Application.Exit();
            else
            {
                lblchange.Text = sesion.Nickname + " " + sesion.Personas.Apellidos;
                if (sesion.TipoUsuario.Descripcion.Equals("Cajero"))
                {
                    this.Hide();
                    var form = new Transacciones.AgregarTransaccion();
                    form.ShowDialog();
                    this.Show();
                    MainContainer_Load(sender, e);
                }
            }
            this.Show();
                    
        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
            var socios = new ModificarSocio();
            socios.ShowDialog();
        }

        private void btnBuses_Click(object sender, EventArgs e)
        {
            var buses = new CapaVista.Conductores.MenuConductores();
            buses.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConductores_Click(object sender, EventArgs e)
        {
            var conductores = new Conductores.Conductores();
            conductores.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            var MenuReportes = new Reportes.MenuHerramientas();
            MenuReportes.ShowDialog();
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
            var Carreras = new Transacciones.Carreras();
            Carreras.Show();
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Cerrara la sesion actual\nNo podra realizar operaciones a menos que inicie sesion correctamente!\nEn caso afirmativo, y de cancelar la operacion se cerrara la aplicacion!", "Cambiar de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(confirmacion == DialogResult.Yes)
            {
                this.Hide();
                //Instanciar y mostrar el formulario
                var log = new Login();
                log.ShowDialog();
                //Obtener el usuario
                sesion = log.sesion;
                //Comprobar el inicio de sesion correcto
                if (sesion == null)
                    Application.Exit();
                else
                    if (sesion.TipoUsuario.Descripcion.Equals("Cajero"))
                    {
                        this.Hide();
                        var form = new Transacciones.AgregarTransaccion();
                        form.ShowDialog();
                        MainContainer_Load(sender, e);
                    }
                this.Show();
            }
            
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            var menu = new Transacciones.TipoDetalle();
            menu.ShowDialog();
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            var form = new Transacciones.ListaTransacciones();
            form.ShowDialog();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            var ayuda = new Manual_de_ayuda.Help_Form();
            ayuda.Show();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            var form = new Creditos.Creditos_form();
            form.ShowDialog();
        }

        private void lblchange_Click(object sender, EventArgs e)
        {
            Personas persona = MainContainer.sesion.Personas;
            CambiarContraseña form = new CambiarContraseña(persona);
            form.ShowDialog();
        }
    }
}
