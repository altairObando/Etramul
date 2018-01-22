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
using CapaControlador;

namespace CapaVista.Transacciones
{
    public partial class CambiarContraseña : MetroForm
    {
        public CambiarContraseña(CapaDatos.Personas persona)
        {
            InitializeComponent();
            this.user = persona;
            lblNombreC.Text = persona.Nombres + " " + persona.Apellidos;
            lblCedula.Text = persona.Identificacion;
            lblUsuario.Text = persona.Usuarios.Nickname;

        }

        private CapaDatos.Personas user;

     
        //private void txtcontraActual_Leave(object sender, EventArgs e)
        //{
        //    if (sender != null && e != null)
        //    {
        //        string clave = this.decodificar(user.Usuarios.Clave);
        //        if (clave != txtcontraActual.Text)
        //        {
        //            this.actual = false;
        //            MessageBox.Show("La contraseña ingresada es incorrecta, ingresela nuevamente", "Contraseña Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            txtcontraActual.Clear();
        //            txtcontraActual.Focus();
        //        }
        //        else
        //            this.actual = true;
        //    }           
                            
        //}

        private bool ValidarContra()
        {
            bool ban = false;
            string clave = this.decodificar(user.Usuarios.Clave);
            if (clave != txtcontraActual.Text)
            {
                MessageBox.Show("La contraseña ingresada es incorrecta, ingresela nuevamente", "Contraseña Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcontraActual.Clear();
                txtcontraActual.Focus();
                ban= false;
            }
            else
            {
             
                ban= true;
            }
            return ban;                
        }

        bool EjecutarValidaciones()
        {
            if (ValidarContra())
                if (Validar())
                    return true;
                else
                    return false;
            else
                return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (EjecutarValidaciones())
            {
                int result = -1;
                try
                {
                    result = UsuariosController.modificar(user.Identificacion, user.Nombres, user.Apellidos, user.Direccion,
                                                        user.Telefono, user.Correo, true, user.Usuarios.Nickname,
                                                        txtnuevaContra.Text, user.Usuarios.Id_tipo);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                if (result > 0)
                {
                    MessageBox.Show("La contraseña ha sido actualizada", "Contraseña Actualizada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcontraActual.Text = string.Empty;
                    txtnuevaContra.Text = string.Empty;
                    txtRepetirNueva.Text = string.Empty;
                    
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la contraseña", "Error durante el cambio",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la contraseña", "Error durante el cambio",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool Validar()
        {
            bool band = false;
            //Validando contenido de clave
            if (!string.IsNullOrEmpty(txtnuevaContra.Text) && !string.IsNullOrEmpty(txtRepetirNueva.Text))
            {
                //Validando igualdad en claves.
                if (txtnuevaContra.Text.Equals(txtRepetirNueva.Text))
                    band = true;
            }
            if (!band)
            {
                MessageBox.Show("Verifique las claves de acceso", "Claves no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnuevaContra.Text = string.Empty;
                txtRepetirNueva.Text = string.Empty;
            }
                
            return band;
        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {
            txtcontraActual.Focus();
        }

        private string decodificar(string texto)
        {
            byte[] decodificado = System.Convert.FromBase64String(texto);
            return ASCIIEncoding.ASCII.GetString(decodificado);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //txtcontraActual_Leave(null, null);
            this.Dispose();
        }
    }
}
