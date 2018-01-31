using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace CapaVista.Creditos
{
    public partial class CREDITO_FECHA_Y_RUBRO : MetroForm
    {
        private DateTime fecha;
        private int id_rubro;
        private string rubro;

        public CREDITO_FECHA_Y_RUBRO(DateTime fecha, string rubro, int id_rubro)
        {
            InitializeComponent();
            this.fecha = fecha;
            this.rubro = rubro;
            this.id_rubro = id_rubro;
        }

        private void CREDITO_FECHA_RUBRO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'CreditosDataset.CREDITOS_POR_FECHA_Y_RUBRO' Puede moverla o quitarla según sea necesario.
            this.CREDITOS_POR_FECHA_Y_RUBROTableAdapter.Fill(this.CreditosDataset.CREDITOS_POR_FECHA_Y_RUBRO, fecha.Date, id_rubro);
            reporte.LocalReport.SetParameters(
                new ReportParameter[]
                {
                    new ReportParameter("fecha", fecha.ToShortDateString()),
                    new ReportParameter("rubro", rubro)
                }
                );
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            this.reporte.RefreshReport();
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
