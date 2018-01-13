using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Reportes
{
    public partial class Selector : MetroForm
    {
        public Selector()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtener Vehiculo
                       
        }

        private void Selector_Load(object sender, EventArgs e)
        {
            var vehiculos = CapaControlador.VehiculosController.lista().ToArray();
            cbVehiculos.Items.AddRange(vehiculos);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                //verificar seleccion
                if(cbVehiculos.SelectedIndex >= 0)
                {
                    //string id = ((CapaDatos.Vehiculo)cbVehiculos.SelectedItem).Placa;
                    //DateTime fecha = dtFecha.Value.Date;
                    /////instancia de formulario
                    //var carreras = new CarrerasPorDia();
                    //carreras.SetParameterValue("@Placa", id);
                    //carreras.SetParameterValue("@Fecha", fecha);
                    //Conexiones.SetReportConexion(carreras);
                    //var form = new VISOR();
                    //form.VisorReporte.ReportSource = carreras;
                    //form.ShowDialog();
                }
                else
                {
                    throw new Exception("No ha seleccionado una placa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
