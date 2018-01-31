using MetroFramework.Forms;
using System;
using Microsoft.Reporting.WinForms;
namespace CapaVista.Creditos
{
    public partial class Creditos_entre_fechas : MetroForm
    {
        private DateTime fecha1;
        private DateTime fecha2;

        public Creditos_entre_fechas(DateTime fecha1, DateTime fecha2)
        {
            InitializeComponent();
            this.fecha1 = fecha1;
            this.fecha2 = fecha2;
        }

        private void Creditos_entre_fechas_Load(object sender, EventArgs e)
        {
            CreditosDataset.EnforceConstraints = false;
            // TODO: esta línea de código carga datos en la tabla 'CreditosDataset.CREDITOS_ENTRE_FECHAS' Puede moverla o quitarla según sea necesario.
            this.CREDITOS_ENTRE_FECHASTableAdapter.Fill(this.CreditosDataset.CREDITOS_ENTRE_FECHAS, fecha1.Date, fecha2.Date);
            reportViewer1.LocalReport.SetParameters(
                new ReportParameter[] {
                    new ReportParameter("fecha1", fecha1.ToString()),
                    new ReportParameter("fecha2", fecha2.ToString())
                }
                );
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
