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

namespace CapaVista.Transacciones
{
    public partial class GastosPorRubro : MetroForm
    {
        public GastosPorRubro()
        {
            InitializeComponent();
            total = 0;
        }
        private Decimal total;
        private void GastosPorRubro_Load(object sender, EventArgs e)
        {
            this.transaccionesDataSet.EnforceConstraints = false;

            this.lblNombre.Text = MainContainer.sesion.Personas.ToString();
            gastosPorRubroPorDiaTableAdapter.Fill(transaccionesDataSet.GastosPorRubroPorDia, 3, dtFecha.Value.Date);
            cboTipo.DataSource = CapaControlador.TipoDetalleController.listar();
            CalcularTotal();
            dtFecha1.Enabled = false;
            dtFecha2.Enabled = false;
            btnFiltrar.Enabled = false;
        }
        private void CalcularTotal()
        {
            total = 0;
            foreach (DataGridViewRow item in dgvDatos.Rows)
            {
                if (!string.IsNullOrWhiteSpace(item.Cells[3].Value.ToString()))
                    total += (decimal)item.Cells[3].Value;
            }
            txtTotal.Text = string.Format("{0:C2}", total);
        }
        private void cbEntreFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEntreFechas.Checked)
            {
                dtFecha1.Enabled = true;
                dtFecha2.Enabled = true;
                btnFiltrar.Enabled = true;
                dtFecha.Enabled = false;
            }
            else
            {
                dtFecha1.Enabled = false;
                dtFecha2.Enabled = false;
                btnFiltrar.Enabled = false;
                dtFecha.Enabled = true;
            }
        }
        private void actualizarSencillo(){
            transaccionesDataSet.EnforceConstraints = false;
            gastosPorRubroPorDiaTableAdapter.Fill(transaccionesDataSet.GastosPorRubroPorDia,
                ((CapaDatos.TipoDetalle)cboTipo.SelectedItem).IdTipoDetalle,
                dtFecha.Value.Date);
            dgvDatos.DataSource = gastosPorRubroPorDiaBindingSource;
            CalcularTotal();
        }
        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            actualizarSencillo();
        }

        private void cboTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbEntreFechas.Checked)
                actualizarSencillo();
            else
            {
                transaccionesDataSet.EnforceConstraints = false;
                gastosPorRubroEntreFechasTableAdapter.Fill(transaccionesDataSet.GastosPorRubroEntreFechas,
                    ((CapaDatos.TipoDetalle)cboTipo.SelectedItem).IdTipoDetalle
                    , dtFecha1.Value.Date, dtFecha2.Value.Date);
                dgvDatos.DataSource = gastosPorRubroEntreFechasBindingSource;
                CalcularTotal();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var td = new  TransaccionesDataSetTableAdapters.GastosPorRubroEntreFechasTableAdapter();
            td.Fill(transaccionesDataSet.GastosPorRubroEntreFechas, ((CapaDatos.TipoDetalle)cboTipo.SelectedItem).IdTipoDetalle, dtFecha1.Value.Date, dtFecha2.Value.Date);
            dgvDatos.DataSource = gastosPorRubroEntreFechasBindingSource;
            CalcularTotal();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Form reporte = null;
            int tipo = ((CapaDatos.TipoDetalle)cboTipo.SelectedItem).IdTipoDetalle;
            if(dgvDatos.DataSource.Equals(gastosPorRubroPorDiaBindingSource))
            {
                reporte = new Reportes.GastosPorRubroPorDia_form(tipo,dtFecha.Value.Date);
            }
            else
            {
                reporte = new Reportes.GastosPorRubroEntreFechas_form(cboTipo.SelectedItem.ToString(), tipo, dtFecha1.Value, dtFecha2.Value);
            }
            if(reporte!=null)
            {
                reporte.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtieniendo informacion
            transaccionesDataSet.EnforceConstraints = false;
            try
            {
                string placa = dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
                decimal total = (decimal)dgvDatos.SelectedRows[0].Cells["Monto"].Value;
                // Identificar que tipo de fuente de datos se esta utilizando en el grid
                if(!cbEntreFechas.Checked)
                {
                    int id_tipo = ((CapaDatos.TipoDetalle)cboTipo.SelectedValue).IdTipoDetalle;
                    int id_vehiculo = CapaControlador.VehiculosController.leer(dgvDatos.SelectedRows[0].Cells[1].Value.ToString()).Id_Vehiculo;
                    var form = new DetalleEgresos(placa, id_vehiculo, id_tipo, dtFecha.Value.Date, total);
                    form.ShowDialog();
                }else
                {

                    int id_tipo = ((CapaDatos.TipoDetalle)cboTipo.SelectedValue).IdTipoDetalle;
                    int id_vehiculo = CapaControlador.VehiculosController.leer(dgvDatos.SelectedRows[0].Cells[1].Value.ToString()).Id_Vehiculo;
                    var form = new DetalleEgresos(placa,id_vehiculo, id_tipo, dtFecha1.Value.Date, dtFecha2.Value.Date, total);
                    form.ShowDialog();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
		  
	
}
