using CapaDatos;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace CapaVista.Creditos
{
    public partial class Ticket_abonos : Form
    {
        private Detalle tipo;

        public Ticket_abonos(Detalle detalle)
        {
            InitializeComponent();
            this.tipo = detalle;
        }

        private void Ticket_abonos_Load(object sender, EventArgs e)
        {
            this.CreditosDataset.EnforceConstraints = false;
            // TODO: esta línea de código carga datos en la tabla 'CreditosDataset.ABONOS_POR_DETALLE' Puede moverla o quitarla según sea necesario.
            this.ABONOS_POR_DETALLETableAdapter.Fill(this.CreditosDataset.ABONOS_POR_DETALLE, tipo.IdDetalle );
            reporte.LocalReport.SetParameters(
                new ReportParameter[] 
                {
                    new ReportParameter("factura", tipo.IdTransaccion.ToString()),
                    new ReportParameter("fecha", tipo.Transaccion.FechaTransaccion.ToString()),
                    new ReportParameter("rubro", tipo.TipoEgreso.ToString()),
                    new ReportParameter("credito", tipo.Cantidad.ToString())
                }
                );
            this.reporte.SetDisplayMode( DisplayMode.PrintLayout);
            this.reporte.RefreshReport();
        }
    }
}
