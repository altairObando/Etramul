using MetroFramework.Forms;
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
    public partial class ver_hoy_form : MetroForm
    {
        private DateTime fecha;
        private int? id_vehiculo;
        private string placa;
        public ver_hoy_form(int? id_vehiculo, DateTime fecha, string placa)
        {
            InitializeComponent();
            this.id_vehiculo = id_vehiculo;
            this.placa = placa;
            this.fecha = fecha;
        }

        private void ver_hoy_form_Load(object sender, EventArgs e)
        {
            this.ReportesDataSet.EnforceConstraints = false;
            // TODO: esta línea de código carga datos en la tabla 'ReportesDataSet.TRANSACCION_DIA_VEHICULO' Puede moverla o quitarla según sea necesario.
            this.TRANSACCION_DIA_VEHICULOTableAdapter.Fill(this.ReportesDataSet.TRANSACCION_DIA_VEHICULO, id_vehiculo,fecha.Date);
            reportViewer1.LocalReport.SetParameters(
                new ReportParameter[]
                {
                    new ReportParameter("placa", placa),
                    new ReportParameter("fecha", fecha.ToShortDateString())
                }
                );
            this.reportViewer1.RefreshReport();
        }
    }
}
