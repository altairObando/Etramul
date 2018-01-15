using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;

namespace CapaVista.Reportes
{
    public partial class GastosPorRubroEntreFechas_form : MetroForm
    {
        int? Tipo;
        DateTime Fecha1;
        DateTime Fecha2;
        string rubro;
        public GastosPorRubroEntreFechas_form(string rubro, int? tipo, DateTime fecha1,DateTime fecha2)
        {
            InitializeComponent();
            this.Tipo = tipo;
            this.Fecha1 = fecha1;
            this.Fecha2 = fecha2;
            this.rubro = rubro;
        }

        private void GastosPorRubroEntreFechas_form_Load(object sender, EventArgs e)
        {
            transaccionesDataSet.EnforceConstraints = false;
            this.gastosPorRubroEntreFechasTableAdapter.Fill(this.transaccionesDataSet.GastosPorRubroEntreFechas, Tipo, Fecha1, Fecha2);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {
                new ReportParameter("RUBRO", rubro ),
                new ReportParameter("FECHA1",Fecha1.ToShortDateString() ),
                new ReportParameter("FECHA2",Fecha2.ToShortDateString())
            });
            this.reportViewer1.RefreshReport();
        }
    }
}
