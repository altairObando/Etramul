using MetroFramework.Forms;
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
    public partial class CarrerasPorDia_Form : MetroForm
    {
        private DateTime fecha;
        private string placa;

        public CarrerasPorDia_Form(DateTime fecha, string placa)
        {
            this.fecha = fecha;
            this.placa = placa;
            InitializeComponent();
        }

        private void CarrerasPorDia_Form_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReportesDataSet.carrerasPorDia' Puede moverla o quitarla según sea necesario.
            this.carrerasPorDiaTableAdapter.Fill(this.ReportesDataSet.carrerasPorDia, fecha, placa);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }
    }
}
