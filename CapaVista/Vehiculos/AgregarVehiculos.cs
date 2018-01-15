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
using CapaControlador;
namespace CapaVista.Vehiculos
{
    public partial class AgregarVehiculos : MetroForm
    {
        private string codSocio;
        public AgregarVehiculos()
        {
            InitializeComponent();
            codSocio = string.Empty;
        }

        public AgregarVehiculos(string p)
        {
            // TODO: Complete member initializatio
            InitializeComponent();
            this.placaMod = p;
        }        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var tmp = new BuscarSocio();
            tmp.ShowDialog();
            if(tmp.socio!= null)
                codSocio = tmp.socio.Personas.Identificacion;
            this.txtCodSocio.Text = codSocio;
        }
        private string placaMod;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(validarControles())
            {
                try
                {
                    int r;
                    //Obteniendo el id de socio
                    Socio idSocio = SociosController.leerI(txtCodSocio.Text);
                    //Verificar si ya existe un vehiculo con la misma placa
                    var vehiculo = VehiculosController.leer(placaMod);
                    if (vehiculo == null)
                    {
                        r = VehiculosController.agregar(idSocio.Personas.Id_persona, txtPlaca.Text, txtMarca.Text, txtModelo.Text);
                    }
                    else
                    {
                        
                        r = VehiculosController.modificar(vehiculo.Id_Vehiculo,vehiculo.Id_socio, txtPlaca.Text, txtMarca.Text, txtModelo.Text);
                    }
                    if (r > 0)
                    {
                        MessageBox.Show("Vehiculo Agregado Correctamente", "Datos guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clean();
                        if (!txtPlaca.Enabled || vehiculo !=  null)
                            this.Close();
                    }
                    else
                        MessageBox.Show("No se ha podido ingresar el registro", "Error Durante la insercion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Durante la insercion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Quedan campos sin llenar", "Falta Información!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clean()
        {
            txtCodSocio.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtPlaca.Clear();
            btnBuscar.Focus();
        }
        private bool validarControles()
        {
            bool band;

         band = string.IsNullOrWhiteSpace(txtCodSocio.Text) ? false :
                string.IsNullOrWhiteSpace(txtMarca.Text) ? false :
                string.IsNullOrWhiteSpace(txtModelo.Text) ? false :
                string.IsNullOrWhiteSpace(txtPlaca.Text) ? false : true;
            return band;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
