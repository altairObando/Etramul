using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;

namespace CapaVista.Reportes
{
    public partial class VerEntreFechasForm : MetroForm
    {
        private DateTime FechaInicio;
        private DateTime FechaFin;
        private int IdVehiculo;
        private string Placa;
        public VerEntreFechasForm(DateTime FechaInicio, DateTime FechaFin, int IdVehiculo, string Placa)
        {
            InitializeComponent();
            this.FechaInicio = FechaInicio;
            this.FechaFin = FechaFin;
            this.IdVehiculo = IdVehiculo;
            this.Placa = Placa;
        }

        private void VerEntreFechasForm_Load(object sender, EventArgs e)
        {
            
            this.ReportesDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'ReportesDataset.verEntreFechas' table. You can move, or remove it, as needed.
            this.verEntreFechasTableAdapter.Fill(this.ReportesDataSet.verEntreFechas, FechaInicio.Date, FechaFin.Date, IdVehiculo);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {
                new ReportParameter("FechaInicio", FechaInicio.ToShortDateString()),
                new ReportParameter("FechaFin", FechaFin.ToShortDateString()),
                new ReportParameter("PLACA", Placa)                
            });
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
