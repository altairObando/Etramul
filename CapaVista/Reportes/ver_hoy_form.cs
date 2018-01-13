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
        private DateTime? fecha;
        private int? id_vehiculo;
        private string placa;
        public ver_hoy_form(int? id_vehiculo, DateTime? fecha, string placa)
        {
            InitializeComponent();
            this.id_vehiculo = id_vehiculo;
            this.placa = placa;
            this.fecha = fecha;
        }

        private void ver_hoy_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportesDataSet.Ingresos_Dia' table. You can move, or remove it, as needed.
            this.Ingresos_DiaTableAdapter.Fill(this.ReportesDataSet.Ingresos_Dia, id_vehiculo, fecha);
            // TODO: This line of code loads data into the 'ReportesDataSet.Egresos_Dia' table. You can move, or remove it, as needed.
            this.Egresos_DiaTableAdapter.Fill(this.ReportesDataSet.Egresos_Dia, id_vehiculo, fecha);
            reportViewer1.LocalReport.SetParameters(
                new ReportParameter[] 
                {
                    new ReportParameter("PLACA", placa),
                    new ReportParameter("FECHA", fecha.ToString())
                }
                );
            this.reportViewer1.RefreshReport();
        }
    }
}
