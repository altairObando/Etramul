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
using Microsoft.Reporting.WinForms;

namespace CapaVista.Reportes
{
    public partial class IngresoTotalPorFechas : MetroForm
    {
        private DateTime FechaInicio;
        private DateTime FechaFin;
        public IngresoTotalPorFechas(DateTime FechaInicio, DateTime FechaFin)
        {
            InitializeComponent();
            this.FechaInicio = FechaInicio;
            this.FechaFin = FechaFin;
        }

        private void IngresoTotalPorFechas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportesDataset.Total_entre_fechas' table. You can move, or remove it, as needed.
            this.Total_entre_fechasTableAdapter.Fill(this.ReportesDataset.Total_entre_fechas, FechaInicio, FechaFin);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {
                new ReportParameter("FechaInicio", FechaInicio.ToShortDateString()),
                new ReportParameter("FechaFin", FechaFin.ToShortDateString())
            });
            this.reportViewer1.RefreshReport();
        }
    }
}
