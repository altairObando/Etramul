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
using System.Text.RegularExpressions;

namespace CapaVista.Conductores
{
    public partial class BuscarConductor : MetroForm
    {
        public BuscarConductor()
        {
            InitializeComponent();
            cargarSocio();
        }

        /// <summary>
        /// Objeto tipo Conductor
        /// </summary>
        public Conductor conductor;

        /// <summary>
        /// Carga los datos de todos los socios activos en el DataGridView
        /// </summary>
        void cargarSocio()
        {
            dgvConductor.Rows.Clear();
            var lista = ConductorController.lista(null);
            foreach (Conductor item in lista)
            {
                dgvConductor.Rows.Add(item.Personas.Identificacion, item.Personas.Nombres, item.Personas.Apellidos, item.Personas.Direccion, item.Personas.Telefono, item.Personas.Correo, item.Licencia);
            }
        }

        /// <summary>
        /// Carga los datos de todos los socios activos en el DataGridView
        /// </summary>
        /// <param name="datos">Representa una lista de objetos Conductor</param>
        void cargarSocio(List<Conductor> datos)
        {
            dgvConductor.Rows.Clear();
            foreach (Conductor item in datos)
            {
                dgvConductor.Rows.Add(item.Personas.Identificacion, item.Personas.Nombres, item.Personas.Apellidos, item.Personas.Direccion, item.Personas.Telefono, item.Personas.Correo, item.Licencia);
            }
        }


        /// <summary>
        /// Permite obtener un objeto conductor mediante la Cedula
        /// </summary>
        /// <returns>Devuelve un objeto Conductor</returns>
        private Conductor getConductor()
        {
            var dgv = dgvConductor.CurrentRow;
            string cedula = dgv.Cells[0].Value.ToString();
            return ConductorController.leerI(cedula);
        }


        /// <summary>
        /// Permite Seleccionar una fila que tiene a un conductor deseado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvConductor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            conductor = getConductor();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Conductor> datos = new List<Conductor>();
            if (!(String.IsNullOrEmpty(txtNombres.Text) || String.IsNullOrWhiteSpace(txtNombres.Text)))
            {
                datos = ConductorController.lista(txtNombres.Text.Trim());
            }
            else
            {
                datos = ConductorController.lista(null);
            }
            if (datos != null)
                cargarSocio(datos);
            else
            {
                cargarSocio();
                MessageBox.Show("No existe el socio o el nombre esta mal escrito", "Verificar Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
        }
    }
}
