using CapaDatos;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace CapaVista.Creditos
{
    public partial class Creditos_entre_fechas_rubro : MetroForm
    {
        DateTime fecha1, fecha2;
        string rubro;
        int id_rubro;
        public Creditos_entre_fechas_rubro(DateTime fecha1, DateTime fecha2, TipoDetalle rubro)
        {
            InitializeComponent();
            this.fecha1 = fecha1;
            this.fecha2 = fecha2;
            this.rubro = rubro.Descripcion;
            this.id_rubro = rubro.IdTipoDetalle;
        }

        private void Creditos_entre_fechas_rubro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'CreditosDataset.CREDITOS_ENTRE_FECHAS_RUBRO' Puede moverla o quitarla según sea necesario.
            this.CREDITOS_ENTRE_FECHAS_RUBROTableAdapter.Fill(this.CreditosDataset.CREDITOS_ENTRE_FECHAS_RUBRO,fecha1.Date, fecha2.Date, id_rubro );
            reportViewer1.LocalReport.SetParameters(
                new ReportParameter[] 
                {
                    new ReportParameter("fecha1", fecha1.ToShortDateString()),
                    new ReportParameter("fecha2", fecha2.ToShortDateString()),
                    new ReportParameter("rubro", rubro)
                }
                );
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
