using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;

namespace CapaVista.Reportes
{
    public partial class DetalleGastosRubroDia : MetroForm
    {
        private int? id_rubro;
        private DateTime? fecha;
        private string placa;
        private int id_vehiculo;

        public DetalleGastosRubroDia(int? id_rubro, DateTime? fecha, string placa)
        {
            InitializeComponent();
            this.id_rubro = id_rubro;
            this.fecha = fecha;
            this.placa = placa;
            this.id_vehiculo = CapaControlador.VehiculosController.leer(placa).Id_Vehiculo;
        }

        private void DetalleGastosRubroDia_Load(object sender, EventArgs e)
        {
            this.reportesDataSet.EnforceConstraints = false;
            egresosDetallePorRubroTableAdapter.Fill(this.reportesDataSet.EgresosDetallePorRubro, id_rubro, id_vehiculo, fecha);
            reportViewer1.LocalReport.SetParameters( new ReportParameter[] {
                new ReportParameter("RUBRO", id_rubro.ToString()),
                new ReportParameter("FECHA", fecha.ToString()),
                new ReportParameter("PLACA", placa)
            });
            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}
