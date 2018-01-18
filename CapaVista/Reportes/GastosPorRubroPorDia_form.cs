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
    public partial class GastosPorRubroPorDia_form : MetroForm
    {
        int tipo;
        DateTime fecha;
        public GastosPorRubroPorDia_form(int tipo, DateTime fecha)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.fecha = fecha;
        }

        private void GastosPorRubroPorDia_form_Load(object sender, EventArgs e)
        {
            this.transaccionesDataSet.EnforceConstraints = false;
            this.gastosPorRubroPorDiaTableAdapter.Fill(this.transaccionesDataSet.GastosPorRubroPorDia, tipo, fecha);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
