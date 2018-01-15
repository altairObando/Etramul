using MetroFramework.Forms;
using System;

namespace CapaVista.Vehiculos
{
    public partial class VerDetalles : MetroForm
    {
        private CapaDatos.Vehiculo datos;
        public VerDetalles(CapaDatos.Vehiculo datos)
        {
            InitializeComponent();
            this.datos = datos;
        }

        private void VerDetalles_Load(object sender, EventArgs e)
        {
            txtSocio.Text = datos.Socio.Personas.ToString();
            txtMarca.Text = datos.Marca;
            txtModelo.Text = datos.Modelo;
            txtPlaca.Text = datos.Placa;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
