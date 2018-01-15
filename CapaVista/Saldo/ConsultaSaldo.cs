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

namespace CapaVista.Saldo
{
    public partial class ConsultaSaldo : MetroForm
    {
        public ConsultaSaldo()
        {
            InitializeComponent();
        }

        void loadCombo()
        { 
            try 
	        {	        
		        Vehiculo [] veh = VehiculosController.lista(new Vehiculo()).ToArray();
                cboVehiculo.Items.AddRange(veh);
	        }
	        catch (Exception ex)
	        {
		        MessageBox.Show(ex.Message);
	        }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var veh= (Vehiculo)cboVehiculo.SelectedItem;
                var cuenta = SaldoController.leer(veh.Id_Vehiculo);
                lblSocio.Text = veh.Socio.Personas.Nombres + "" + veh.Socio.Personas.Apellidos;
                lblPlaca.Text = veh.Placa;
                lblCuenta.Text = cuenta.Total_sado.ToString();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
