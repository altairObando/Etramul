using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;

namespace CapaVista.Reportes
{
    public partial class DetalleEgresoEntreFechas_form : MetroForm
    {
        private int? id_rubro;
        private int? id_vehiculo;
        private DateTime? fecha1;
        private DateTime? fecha2;
        private string placa;

        public DetalleEgresoEntreFechas_form(int? id_rubro, int? id_vehiculo,DateTime? fecha1 , DateTime? fecha2, string placa)
        {
            InitializeComponent();
            this.id_rubro = id_rubro;
            this.id_vehiculo = id_vehiculo;
            this.fecha1 = fecha1;
            this.fecha2 = fecha2;
            this.placa = placa;
        }

        private void DetalleEgresoEntreFechas_form_Load(object sender, EventArgs e)
        {
            egresosDetallePorRubroEntreFechasTableAdapter.Fill(this.transaccionesDataSet.EgresosDetallePorRubroEntreFechas, id_rubro, id_vehiculo, fecha1, fecha2);
            this.reportViewer1.LocalReport.SetParameters( 
                new ReportParameter[] {
                    //Parametros
                new ReportParameter("RUBRO", id_rubro.ToString()),
                new ReportParameter("PLACA", placa), 
                new ReportParameter("FECHA", fecha1.ToString()),
                new ReportParameter("FECHA2", fecha2.ToString())
            });
            this.reportViewer1.RefreshReport();
        }
    }
}
