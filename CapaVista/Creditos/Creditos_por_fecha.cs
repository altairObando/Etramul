﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Creditos
{
    public partial class Creditos_por_fecha : Form
    {
        private DateTime fecha;

        public Creditos_por_fecha(DateTime fecha)
        {
            InitializeComponent();
            this.fecha = fecha;
        }

        private void Creditos_por_fecha_Load(object sender, EventArgs e)
        {
            CreditosDataset.EnforceConstraints = false;
            // TODO: esta línea de código carga datos en la tabla 'CreditosDataset.CREDITOS_POR_FECHA' Puede moverla o quitarla según sea necesario.
            this.CREDITOS_POR_FECHATableAdapter.Fill(this.CreditosDataset.CREDITOS_POR_FECHA, fecha.Date);
            reportViewer1.LocalReport.SetParameters(
                new ReportParameter[] {new ReportParameter("fecha",fecha.ToShortDateString()) }
                );
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
