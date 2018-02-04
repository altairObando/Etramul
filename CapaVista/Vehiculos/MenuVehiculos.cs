using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using CapaDatos;
using MetroFramework;
using MetroFramework.Forms;
using CapaVista.Vehiculos;
namespace CapaVista.Conductores
{
    public partial class MenuConductores : MetroForm
    {
        public MenuConductores()
        {
            InitializeComponent();
        }

        private void listaVehiculos_ItemActivate(object sender, EventArgs e)
        {
            detallesToolStripMenuItem_Click(null, null);
        }
        private List<Vehiculo> lista;
        MetroMessageBox msg;
        private void MenuConductores_Load(object sender, EventArgs e)
        {
            this.Imagenes.Images.Add(Properties.Resources.school_bus);
            msg = new MetroMessageBox();
            loadElements();
        }

        private void loadElements()
        {
            //Cargando elementos
            lista = VehiculosController.lista();
            listaVehiculos.Items.Clear();
            //llenando la lista
            foreach (var item in lista)
            {
                ListViewItem element = new ListViewItem(item.Placa, 0);
                if (item.Activo)
                    element.Group = this.listaVehiculos.Groups["activos"];
                else
                    element.Group = this.listaVehiculos.Groups["inactivos"];
                listaVehiculos.Items.Add(element);
            }
        }
        private void marcarComoInactivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Obtener la placa del vehiculo
            string placa = listaVehiculos.SelectedItems[0].Text;
            //Cambiar el estado
            int i = VehiculosController.cambiarEstado(placa);
            if (i > 0) // Si se cambio
                loadElements();//volver a cargar los elementos
            else
            {
                MessageBox.Show("No se pudo cambiar el estado del objeto", "Error al cambiar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_click(object sender, EventArgs e)
        {
            var form = new AgregarVehiculos();
            form.ShowDialog();
            loadElements();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //verificar que se haya seleccionado un elemento
            try
            {
                var vehiculo = getVehiculo();
                var form = new Vehiculos.AgregarVehiculos(vehiculo.Placa);
                form.txtCodSocio.Text = vehiculo.Socio.Personas.Identificacion;
                form.txtMarca.Text = vehiculo.Marca;
                form.txtModelo.Text = vehiculo.Modelo;
                form.txtPlaca.Text = vehiculo.Placa;
                form.ShowDialog();
                //Recargar elementos
                loadElements();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un elemento de la lista", ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private Vehiculo getVehiculo()
        {
            string indice = listaVehiculos.SelectedItems[0].Text;
            //Obtener el vehiculo usando la placa
            Vehiculo vehiculo = lista.Find(x => x.Placa.Equals(indice));
            //Obtener ultima carrera del elemento
            return vehiculo;
        }
        private void ultimaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var vehiculo = getVehiculo();
                var ultimaCarrera = vehiculo.Carrera.Last();
                
                var detalles = new DetallesCarrera(vehiculo, ultimaCarrera);
                detalles.ShowDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new VerDetalles(getVehiculo());
            form.ShowDialog();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            var form = new Socios.ModificarSocio();
            form.ShowDialog();
        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            var form = new CapaVista.Carrera();
            form.ShowDialog();
        }

        private void verSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Obtener el vehiculo seleccionado
            var vehiculo = getVehiculo();
            var form = new DetallesSocio(vehiculo);
            form.ShowDialog();
        }

        private void contextVehiculos_Opening(object sender, CancelEventArgs e)
        {
            //verificar que se haya seleccionado un elemento de la lista
            if (listaVehiculos.SelectedItems.Count == 0)
                OpcionesVehiculos.Enabled = false;
            else
                OpcionesVehiculos.Enabled = true;
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new UltimasTransacciones(getVehiculo());
               form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void copiarPlacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(getVehiculo().Placa);
        }
        
        private void btnReload_Click(object sender, EventArgs e)
        {
            this.loadElements();
        }

        private void verHoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Ver_dia(getVehiculo());
            form.ShowDialog();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            var form = new Total_Vehiculos();
            form.Show();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            var form = new Transacciones.GastosPorRubro();
            form.ShowDialog();
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            loadElements();
        }

        private void creditosYAbonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Creditos.Creditos_Bus(getVehiculo());
            form.ShowDialog();
        }
    }
}
