using CapaVista.Transacciones;
using CrystalDecisions.CrystalReports.Engine;
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
using CapaVista.Reportes;
namespace CapaVista.Vehiculos
{
    public partial class Total_Vehiculos : MetroForm
    {
        private bool por_dia;
        public Total_Vehiculos()
        {
            InitializeComponent();
        }

        private void Total_Vehiculos_Load(object sender, EventArgs e)
        {
            filtrar();
            this.lblUsuario.Text = MainContainer.sesion.Personas.ToString();
        }

        private void filtrar()
        {
            try
            {
                por_dia = true;
                ingreso_TotalTableAdapter.Fill(reportesDataSet.ingreso_total_por_dia, dtFecha.Value.Date);
                dgvTotal.DataSource = ingresoTotalBindingSource;
                /* Calculando totales */
                decimal ingreso = 0, egreso = 0;
                foreach (DataGridViewRow item in dgvTotal.Rows)
                {
                    if (!string.IsNullOrWhiteSpace(item.Cells[2].Value.ToString()))
                        ingreso += (decimal)item.Cells[2].Value;
                    if (!string.IsNullOrWhiteSpace(item.Cells[3].Value.ToString()))
                        egreso += (decimal)item.Cells[3].Value;
                }
                txtIngreso.Text = string.Format("{0:C2}", ingreso);
                txtEgreso.Text = string.Format("{0:C2}", egreso);
                txtTotal.Text = string.Format("{0:C2}", ingreso - egreso);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error durante la obtencion de la informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Form reporte = null;
                if (dgvTotal.DataSource.Equals(ingresoTotalBindingSource))
                    reporte = new Ingreso_total(dtFecha.Value.Date);
                else
                    reporte = new IngresoTotalPorFechas(dtFechaInicio.Value, dtFechaFin.Value);
                reporte.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvTotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Obtener el vehiculo por la placa
                string placa = dgvTotal.SelectedRows[0].Cells[1].Value.ToString();
                var vehiculo = CapaControlador.VehiculosController.leer(placa);
                var form = new Ver_dia(vehiculo);
                form.dtFecha.Enabled = false;
                if (por_dia)
                {
                    form.dtFecha.Value = dtFecha.Value;
                    form.ShowDialog();
                }
                else
                {
                    form.Show();
                    form.cargaEntreFechas(dtFechaInicio.Value.Date, dtFechaFin.Value.Date);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error grave");
            }
        }
        private void verDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvTotal_CellContentClick(sender, null);
        }
        private void lblFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                por_dia = false;
                TransaccionesDataSet transacciones = new Transacciones.TransaccionesDataSet();
                var total_entre_fechasTableAdapter = new Transacciones.TransaccionesDataSetTableAdapters.Total_entre_fechasTableAdapter();
                total_entre_fechasTableAdapter.Fill(transacciones.Total_entre_fechas, dtFechaInicio.Value.Date, dtFechaFin.Value.Date);
                IngresoEntreFechas.DataSource = transacciones;
                IngresoEntreFechas.DataMember = "Total_entre_fechas";
                dgvTotal.DataSource = IngresoEntreFechas;
                /* Calculando totales */
                decimal ingreso = 0, egreso = 0;
                foreach (DataGridViewRow item in dgvTotal.Rows)
                {
                    if (!string.IsNullOrWhiteSpace(item.Cells[2].Value.ToString()))
                        ingreso += (decimal)item.Cells[2].Value;
                    if (!string.IsNullOrWhiteSpace(item.Cells[3].Value.ToString()))
                        egreso += (decimal)item.Cells[3].Value;
                }
                txtIngreso.Text = string.Format("{0:C2}", ingreso);
                txtEgreso.Text = string.Format("{0:C2}", egreso);
                txtTotal.Text = string.Format("{0:C2}", ingreso - egreso);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error durante la obtencion de la informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
