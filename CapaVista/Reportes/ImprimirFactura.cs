﻿using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Reportes
{
    public partial class ImprimirFactura : MetroForm
    {
        private string cajero;
        private int? codigo;
        private DateTime fecha;
        private string placa;

        public ImprimirFactura(int? codigo, string cajero,string placa, DateTime fecha)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.cajero = cajero;
            this.placa = placa;
            this.fecha = fecha;
            this.ReportesDataSet.EnforceConstraints = false;
        }
        private decimal total, total_credito;
        private void calcularTotales()
        {
            total = 0;
            total_credito = 0;
            //Calculando total Ingresos
            total += ReportesDataSet.DetalleDeTransaccion.Where(x => !x.Transaccion.Equals("Credito")).Sum(x => x.Cantidad);
            //Total Credito
            total_credito += ReportesDataSet.DetalleDeTransaccion.Where(y => y.Transaccion.Equals("Credito")).Sum(x => x.Cantidad);
        }
        private void ImprimirFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportesDataSet.DetalleDeTransaccion' table. You can move, or remove it, as needed.
            this.DetalleDeTransaccionTableAdapter.Fill(this.ReportesDataSet.DetalleDeTransaccion, codigo);
            calcularTotales();
            reportViewer1.LocalReport.SetParameters(
                new ReportParameter[]
                {
                    new ReportParameter("CAJERO", cajero),
                    new ReportParameter("PLACA", placa),
                    new ReportParameter("FECHA", fecha.ToShortDateString()),
                    new ReportParameter("total", total.ToString()),
                    new ReportParameter("total_credito", total_credito.ToString())
                }
                );
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
