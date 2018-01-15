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

        public DetalleGastosRubroDia(int? id_rubro, DateTime? fecha, string placa)
        {
            InitializeComponent();
            this.id_rubro = id_rubro;
            this.fecha = fecha;
            this.placa = placa;
        }

        private void DetalleGastosRubroDia_Load(object sender, EventArgs e)
        {
            gastosPorRubroPorDiaTableAdapter.Fill(this.transaccionesDataSet.GastosPorRubroPorDia, id_rubro, fecha);
            reportViewer1.LocalReport.SetParameters( new ReportParameter[] {
                new ReportParameter("RUBRO", id_rubro.ToString()),
                new ReportParameter("FECHA", fecha.ToString()),
                new ReportParameter("PLACA", placa)
            });
            this.reportViewer1.RefreshReport();
        }
    }
}
