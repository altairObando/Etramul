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

namespace CapaVista.Socios
{
    public partial class BuscarSocio : MetroForm
    {
        public BuscarSocio()
        {
            InitializeComponent();
            cargarSocio();
        }

        public Socio socio;
        void cargarSocio()
        {
            dgvSocio.Rows.Clear();
            var lista = SociosController.lista();
            foreach (Socio item in lista)
            {
                dgvSocio.Rows.Add(item.Personas.Identificacion, item.Personas.Nombres, item.Personas.Apellidos, item.Personas.Direccion, item.Personas.Telefono, item.Personas.Correo, item.FechaAsociacion);
            }
        }

        private void dgvSocio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            socio = getSocio();
            //Socio soc = getSocio();
            //ModificarSocio.LlenarDatos(soc);
            this.Dispose();
        }

        private Socio getSocio()
        {
            var dgv = dgvSocio.CurrentRow;
            string cedula = dgv.Cells[0].Value.ToString();
            return SociosController.leerI(cedula);
        }

        /// <summary>
        /// Permite realizar una busqueda de Socios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Socio> datos = new List<Socio>();
            if (!(String.IsNullOrEmpty(txtNombres.Text) || String.IsNullOrWhiteSpace(txtNombres.Text)))
            {
                datos = SociosController.lista(txtNombres.Text.Trim());
            }
            else
            {
                datos = SociosController.lista();    
            }
            if(datos!=null)
                CargarDatos(datos);
            else
                MessageBox.Show("No existe el socio o el nombre esta mal escrito", "Verificar Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Carga los datos en el Data Grid View
        /// </summary>
        /// <param name="datos">Representa una lista de objetos tipo Socio</param>
        void CargarDatos(List<Socio> datos)
        {
            dgvSocio.Rows.Clear();
            foreach (Socio item in datos)
            {
                dgvSocio.Rows.Add(item.Personas.Identificacion, item.Personas.Nombres, item.Personas.Apellidos, item.Personas.Direccion, item.Personas.Telefono, item.Personas.Correo, item.FechaAsociacion);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
