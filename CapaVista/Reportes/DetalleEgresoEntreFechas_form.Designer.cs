namespace CapaVista.Reportes
{
    partial class DetalleEgresoEntreFechas_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportesDataSet = new CapaVista.Reportes.ReportesDataSet();
            this.egresosDetallePorRubroEntreFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.egresosDetallePorRubroEntreFechasTableAdapter = new CapaVista.Reportes.ReportesDataSetTableAdapters.EgresosDetallePorRubroEntreFechasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egresosDetallePorRubroEntreFechasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.egresosDetallePorRubroEntreFechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista.Reportes.DetalleEgresoEntreFechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(954, 660);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportesDataSet
            // 
            this.reportesDataSet.DataSetName = "ReportesDataSet";
            this.reportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // egresosDetallePorRubroEntreFechasBindingSource
            // 
            this.egresosDetallePorRubroEntreFechasBindingSource.DataMember = "EgresosDetallePorRubroEntreFechas";
            this.egresosDetallePorRubroEntreFechasBindingSource.DataSource = this.reportesDataSet;
            // 
            // egresosDetallePorRubroEntreFechasTableAdapter
            // 
            this.egresosDetallePorRubroEntreFechasTableAdapter.ClearBeforeFill = true;
            // 
            // DetalleEgresoEntreFechas_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 740);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DetalleEgresoEntreFechas_form";
            this.Text = "Visor Reportes";
            this.Load += new System.EventHandler(this.DetalleEgresoEntreFechas_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egresosDetallePorRubroEntreFechasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource egresosDetallePorRubroEntreFechasBindingSource;
        private ReportesDataSet reportesDataSet;
        private ReportesDataSetTableAdapters.EgresosDetallePorRubroEntreFechasTableAdapter egresosDetallePorRubroEntreFechasTableAdapter;
    }
}