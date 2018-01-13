using CrystalDecisions.CrystalReports.Engine;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaVista.Transacciones
{
    public partial class DetalleEgresos : MetroForm
    {
        private int id_vehiculo;
        private int id_rubro;
        private DateTime fecha;        
        private DateTime Fecha1;
        private DateTime Fecha2;
        private string placa;
        public DetalleEgresos(string placa, int id_vehiculo, int id_rubro, DateTime fecha, decimal total)
        {
            this.id_vehiculo = id_vehiculo;
            this.id_rubro = id_rubro;
            this.fecha = fecha;
            this.placa = placa;
            InitializeComponent();
            this.lblTotal.Text = string.Format("{0:C2}", total);
            band = false;
        }

        public DetalleEgresos(string placa, int id_vehiculo, int id_tipo, DateTime dateTime1, DateTime dateTime2, decimal total)
        {
            // TODO: Complete member initialization
            this.id_vehiculo = id_vehiculo;
            this.id_rubro = id_tipo;
            this.Fecha1 = dateTime1;
            this.Fecha2 = dateTime2;
            this.placa = placa;
            InitializeComponent();
            band = true;
            this.lblTotal.Text = string.Format("{0:C2}", total);
        }
        private bool band;
        private void DetalleEgresos_Load(object sender, EventArgs e)
        {
            this.lblPlaca.Text = placa;
            transaccionesDataSet.EnforceConstraints = false;
            if(!band)
            {
                egresosDetallePorRubroTableAdapter.Fill(transaccionesDataSet.EgresosDetallePorRubro, id_rubro, id_vehiculo, fecha);
                dgFechas.Hide();
            }
            else
            {
                egresosDetallePorRubroEntreFechasTableAdapter.Fill(this.transaccionesDataSet.EgresosDetallePorRubroEntreFechas, id_rubro, id_vehiculo, Fecha1, Fecha2);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Form reporte = null;
            string rubro = CapaControlador.TipoDetalleController.leer(id_rubro).ToString();
            if(dgvDetalles.Rows.Count > 0)
            {
                reporte = new Reportes.DetalleGastosRubroDia(id_rubro, fecha, lblPlaca.Text);
            }
            else
            {
                reporte = new Reportes.DetalleEgresoEntreFechas_form(id_rubro, id_vehiculo, Fecha1, Fecha2, lblPlaca.Text);
            }
            if (reporte != null)
            {
                reporte.ShowDialog();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No se pudo cargar el modulo de los reportes", "Error en parametros??", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
