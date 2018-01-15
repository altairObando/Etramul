using CapaDatos;
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

namespace CapaVista.Vehiculos
{
    public partial class DetallesSocio : MetroForm
    {
        private Vehiculo datos;
        public DetallesSocio(Vehiculo data)
        {
            InitializeComponent();
            datos = data;
        }

        private void DetallesSocio_Load(object sender, EventArgs e)
        {
            lblCedula.Text = datos.Socio.Personas.Identificacion;
            lblNombres.Text = datos.Socio.Personas.ToString();
            lblTelefono.Text = datos.Socio.Personas.Telefono;
            lblVehiculos.Text = datos.Socio.Vehiculo.Count.ToString();
            lblFecha.Text = datos.Socio.FechaAsociacion.ToShortDateString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
