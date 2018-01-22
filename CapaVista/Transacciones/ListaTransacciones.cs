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
using MetroFramework.Forms;

namespace CapaVista.Transacciones
{
    public partial class ListaTransacciones : MetroForm
    {
        public ListaTransacciones()
        {
            InitializeComponent();
            loadGrid();
            
        }
        private decimal totalIngreso = 0;
        private decimal totalEgreso = 0;
        void loadGrid()
        {
            dgvEgresos.Rows.Clear();
            totalEgreso = 0;
            totalIngreso = 0;
            var list = TransaccionController.listar(-1).Where(x=> x.FechaTransaccion.Equals(dtFechaFiltro.Value.Date)).ToList();
            if(list==null)
                throw new Exception("No se pudo cargar");            
            for (int i = 0; i < list.Count; i++)
            {
                decimal ingreso = list[i].Egreso.Where(x=> x.TipoTransaccion && x.Activo).Sum(y=>y.Cantidad);
                decimal egreso = list[i].Egreso.Where(x => !x.TipoTransaccion && x.Activo).Sum(y => y.Cantidad);
                string cajero = UsuariosController.leer(list[i].Id_usuario).Personas.ToString();
                dgvEgresos.Rows.Add(list[i].IdTransaccion, cajero, list[i].Vehiculo.Placa, list[i].FechaTransaccion.ToShortDateString() ,ingreso, egreso);
                if (!list[i].Activo)
                    dgvEgresos.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                else
                {
                    dgvEgresos.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                totalIngreso += ingreso;
                totalEgreso += egreso;
            }
            setTotales();
        }

        private void setTotales()
        {
            txtIngreso.Text = string.Format("{0:C}", totalIngreso);
            txtEgreso.Text = string.Format("{0:C}", totalEgreso);
            decimal suma = totalIngreso - totalEgreso;
            txtTotal.Text = string.Format("{0:C}", suma);
            if (suma == 0)
                txtTotal.ForeColor = Color.Blue;
            else
                if (suma > 0)
                    txtTotal.ForeColor = Color.Green;
                else
                    txtTotal.ForeColor = Color.Red;
        }
        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = (int)dgvEgresos.SelectedRows[0].Cells[0].Value;
                var form = new DetalleTransaccion(codigo);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int codigo = (int)dgvEgresos.SelectedRows[0].Cells[0].Value;
        //        DialogResult result;
        //        var admin = new Administracion("Confirme la eliminacion del registro numero: " + codigo);
        //        admin.ShowDialog();
        //        result = admin.resultado;
        //        if (DialogResult.Yes.Equals(result))
        //        {
        //            try
        //            {
        //                int an = TransaccionController.anular(codigo);
        //                if (an < 0)
        //                    throw new Exception("Ne pudo eliminar la transaccion");
        //                //var list = DetalleController.listar(codigo);
        //                //for (int i = 0; i < list.Count; i++)
        //                //{
        //                //    int j = DetalleController.anular(list[i].IdDetalle);
        //                //    if (j < 0)
        //                //        throw new Exception("No se ha podido eliminar");
        //                //}
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }
        //        }    
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
             
        //}

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                totalEgreso = 0;
                totalIngreso = 0;
                if (String.IsNullOrWhiteSpace(txtDescripcion.Text) || String.IsNullOrEmpty(txtDescripcion.Text))
                    loadGrid();
                else
                {
                    dgvEgresos.Rows.Clear();
                    var codigoVehiculo = VehiculosController.leer(txtDescripcion.Text);
                    if (codigoVehiculo == null)
                        throw new Exception("No existe un vehiculo con esa placa");                      
                    
 var list = TransaccionController.listar(codigoVehiculo.Id_Vehiculo).Where(x=> x.FechaTransaccion.Equals(dtFechaFiltro.Value.Date)).ToList();

                    if (codigoVehiculo.Transaccion.Count==0)
                        throw new Exception("No hay transacciones para ese vehiculo");
                    for (int i = 0; i < list.Count ; i++)
                    {
                        decimal ingreso = list[i].Egreso.Where(y => y.TipoTransaccion && y.Activo).Sum(x => x.Cantidad);
                        decimal egreso = list[i].Egreso.Where(y => !y.TipoTransaccion && y.Activo).Sum(x => x.Cantidad);
                        string cajero = UsuariosController.leer(list[i].Id_usuario).Personas.ToString();
                        dgvEgresos.Rows.Add(list[i].IdTransaccion, cajero, list[i].Vehiculo.Placa, list[i].FechaTransaccion.ToShortDateString() ,ingreso, egreso);
                        if (!list[i].Activo)
                            dgvEgresos.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                        else
                            dgvEgresos.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                        totalIngreso += ingreso;
                        totalEgreso += egreso;
                    }
                    setTotales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var form = new AgregarTransaccion();
        //        form.ShowDialog();
        //        loadGrid();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void imprimirFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {                
                int codigo = (int)dgvEgresos.SelectedRows[0].Cells[0].Value;
                var transacc = TransaccionController.leer(codigo);
                var det = DetalleController.listar(codigo);
                string cajero = UsuariosController.leer(transacc.Id_usuario).ToString();
                decimal ingreso = det.Where(x => x.TipoTransaccion).Sum(y => y.Cantidad);
                decimal egreso = det.Where(x => !x.TipoTransaccion).Sum(y => y.Cantidad);
                decimal total = ingreso - egreso;
                Form ticket = new Reportes.ImprimirFactura(codigo, cajero,transacc.Vehiculo.Placa, dtFechaFiltro.Value);
                //ticket.SetParameterValue("@codigo", codigo);
                //ticket.SetParameterValue("Cajero", cajero);
                //ticket.SetParameterValue("Placa", transacc.Vehiculo.Placa);
                //ticket.SetParameterValue("Total", total);
                //ticket.SetParameterValue("Ingresos", ingreso);
                //ticket.SetParameterValue("Egresos", egreso);
                //Conexiones.SetReportConexion(ticket);
                //var visor = new VisorReportes();
                //visor.Visor.ReportSource = ticket;
                //visor.ShowDialog();
                ticket.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void ListaTransacciones_Load(object sender, EventArgs e)
        {
            //Cargando autocompletado
            var placas = VehiculosController.lista().Where(x => x.Activo);
            foreach (var item in placas)
                txtDescripcion.AutoCompleteCustomSource.Add(item.ToString());
        }

        private void dgvEgresos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obteniendo valores clave
            vToolStripMenuItem.PerformClick();
        }
    }
}
