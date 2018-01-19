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
    public partial class TicketFisicoForm : MetroForm
    {
        private int transac;
        private string fecha;
        private string cajero;
        private string placa;
        private string conductor;
        private string socio;
        private decimal ingreso;
        private decimal egreso;
        private decimal total;

        public TicketFisicoForm(int transac, string fecha, string cajerp, string placa, string conductor, string socio, decimal ingreso
            , decimal egreso, decimal total)
        {
            InitializeComponent();
            this.transac = transac;
            this.fecha = fecha;
            this.cajero = cajerp;
            this.placa = placa;
            this.conductor = conductor;
            this.socio = socio;
            this.ingreso = ingreso;
            this.egreso = egreso;
            this.total = total;
        }

        private void TicketFisicoForm_Load(object sender, EventArgs e)
        {
            ticketDetalleTableAdapter.FillTicketCarrera(this.transaccionesDataSet.TicketDetalle, transac);
            this.reportViewer1.LocalReport.SetParameters(
                new ReportParameter[]
                {
                    new ReportParameter("Codigo", transac.ToString()),
                    new ReportParameter("Fecha", fecha.ToString()),
                    new ReportParameter("Cajero", cajero.ToString()),
                    new ReportParameter("Placa", placa.ToString()),
                    new ReportParameter("Conductor", conductor.ToString()),
                    new ReportParameter("Socio", socio.ToString()),
                    new ReportParameter("Ingreso", ingreso.ToString()),
                    new ReportParameter("Egresos", egreso.ToString()),
                    new ReportParameter("Total", total.ToString())
                });
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
