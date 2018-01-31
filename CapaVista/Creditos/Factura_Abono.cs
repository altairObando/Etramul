using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace CapaVista.Creditos
{
    public partial class Factura_Abono : MetroForm
    {
        private decimal cantidad;
        private DateTime fecha;
        private DateTime fecha_crd;
        private int factura;
        private int transaccion;
        private decimal monto;
        private string cajero;
        private string placa;
        private string rubro;
        private decimal saldo;

        public Factura_Abono()
        {
            InitializeComponent();
        }

        public Factura_Abono(string placa, int idTransaccion1, DateTime fechaTransaccion1, string nickname, int idTransaccion2, DateTime fechaTransaccion2, string v1, decimal cantidad, decimal monto, decimal v2)
        {
            InitializeComponent();

            this.placa = placa;
            this.factura = idTransaccion1;
            this.fecha = fechaTransaccion1;
            this.cajero = nickname;
            this.transaccion = idTransaccion2;
            this.fecha_crd = fechaTransaccion2;
            this.rubro = v1;
            this.cantidad = cantidad;
            this.monto = monto;
            this.saldo = v2;
        }

        private void Factura_Abono_Load(object sender, EventArgs e)
        {
            fact.LocalReport.SetParameters(
                new ReportParameter[]
                {
                    new ReportParameter("FACTURA", factura.ToString()),
                    new ReportParameter("PLACA", placa),
                    new ReportParameter("FECHA", fecha.ToShortDateString()),
                    new ReportParameter("CAJERO", cajero),
                    new ReportParameter("TRANSACCION", transaccion.ToString()),
                    new ReportParameter("FECHA_CRD", fecha_crd.ToString()),
                    new ReportParameter("RUBRO", rubro),
                    new ReportParameter("MONTO", cantidad.ToString()),
                    new ReportParameter("ABONO", monto.ToString()),
                    new ReportParameter("SALDO", saldo.ToString()),
                }
                );
            fact.RefreshReport();
            fact.SetDisplayMode(DisplayMode.PrintLayout);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
