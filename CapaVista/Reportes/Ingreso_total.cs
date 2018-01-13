using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace CapaVista.Reportes
{
    public partial class Ingreso_total : MetroForm
    {
        private DateTime fecha;
        public Ingreso_total(DateTime fecha)
        {
            this.fecha = fecha;
            InitializeComponent();
        }
        
        private void Visor2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReportesDataSet.Ingreso_Total' Puede moverla o quitarla según sea necesario.
            this.ingreso_total_por_diaTableAdapter.Fill(this.reportesDataSet.ingreso_total_por_dia, fecha);
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] {
                new ReportParameter("fecha", fecha.ToShortDateString()) });
            this.reportViewer.RefreshReport();
        }
    }
}
