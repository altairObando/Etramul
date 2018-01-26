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

namespace CapaVista.Vehiculos
{
    public partial class DetallesCarrera : MetroForm
    {
        private CapaDatos.Vehiculo vehiculo;
        private CapaDatos.Carrera ultimaCarrera;

        public DetallesCarrera()
        {
            InitializeComponent();
        }

        public DetallesCarrera(CapaDatos.Vehiculo vehiculo, CapaDatos.Carrera ultimaCarrera)
        {
            // TODO: Complete member initialization
            this.vehiculo = vehiculo;
            this.ultimaCarrera = ultimaCarrera;
            InitializeComponent();
        }

        private void DetallesCarrera_Load(object sender, EventArgs e)
        {
            try
            {
                //Obteniendo la transaccion
                var transact = CapaControlador.TransaccionController.leer(ultimaCarrera.No_transaccion);
                //Seteando valores
                lblCarrera.Text = ultimaCarrera.Id_carrera.ToString();
                lblConductor.Text = CapaControlador.ConductorController.leer
                    (ultimaCarrera.Id_conductor).ToString();
                lblFecha.Text = ultimaCarrera.FechaCarrera.Date.ToShortDateString();
                lblSalida.Text = string.Format("{0}:{1}:{2}",
                    ultimaCarrera.HoraSalida.Hours,
                    ultimaCarrera.HoraSalida.Minutes,
                    ultimaCarrera.HoraSalida.Seconds);
                lblLlegada.Text = string.Format("{0}:{1}:{2}",
                    ultimaCarrera.HoraLlegada.Hours,
                    ultimaCarrera.HoraLlegada.Minutes,
                    ultimaCarrera.HoraLlegada.Seconds);
                // Datos de la transaccion
                lblCodigo.Text = transact.IdTransaccion.ToString();
                lblCajero.Text = CapaControlador.UsuariosController.leer
                    (transact.Id_usuario).ToString();
                //Ingreso de la carrera
                decimal ingreso = transact.Egreso.First(x => x.TipoTransaccion == 0).Cantidad;
                lblIngreso.Text = string.Format("{0:C}", ingreso);
                //Cargando lista de egresos para mostrar en la lista
                List<CapaDatos.Detalle> lsegresos = transact.Egreso.Where(x => x.TipoTransaccion.Equals(false)).ToList();
                //Obteniendo la suma de los egresos
                decimal egreso = lsegresos.Sum(x=> x.Cantidad);
                //Agregando datos al nodo
                TreeNode[] nodos = new TreeNode[lsegresos.Count];
                //Llenando valor de los nodos
                int i = 0;
                foreach (var item in lsegresos)
                {
                    nodos[i] = new TreeNode(
                        string.Format("Cod: {2} Desc: {0}  {1:C}", item.TipoEgreso.Descripcion, item.Cantidad, item.TipoEgreso.IdTipoDetalle));
                    i++;
                }
                TreeNode raiz = new TreeNode("Detalle de gastos", nodos);
                tvGastos.Nodes.Add(string.Format("Gasto Total: {0:C}", egreso));
                tvGastos.Nodes.Add(raiz);

                if (ultimaCarrera.Activo == false)
                    lblanulada.Visible = true;
                else
                    lblanulada.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
