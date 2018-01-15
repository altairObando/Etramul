namespace CapaVista.Reportes
{
    partial class Ingreso_total
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso_total));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ingresototalpordiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportesDataSet = new CapaVista.Reportes.ReportesDataSet();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ingreso_total_por_diaTableAdapter = new CapaVista.Reportes.ReportesDataSetTableAdapters.ingreso_total_por_diaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ingresototalpordiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ingresototalpordiaBindingSource
            // 
            this.ingresototalpordiaBindingSource.DataMember = "ingreso_total_por_dia";
            this.ingresototalpordiaBindingSource.DataSource = this.reportesDataSetBindingSource;
            // 
            // reportesDataSetBindingSource
            // 
            this.reportesDataSetBindingSource.DataSource = this.reportesDataSet;
            this.reportesDataSetBindingSource.Position = 0;
            // 
            // reportesDataSet
            // 
            this.reportesDataSet.DataSetName = "ReportesDataSet";
            this.reportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            resources.ApplyResources(this.reportViewer, "reportViewer");
            reportDataSource1.Name = "ingreso_total_por_dia";
            reportDataSource1.Value = this.ingresototalpordiaBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CapaVista.Reportes.ingreso_total.rdlc";
            this.reportViewer.Name = "reportViewer";
            // 
            // ingreso_total_por_diaTableAdapter
            // 
            this.ingreso_total_por_diaTableAdapter.ClearBeforeFill = true;
            // 
            // Ingreso_total
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer);
            this.Name = "Ingreso_total";
            this.Load += new System.EventHandler(this.Visor2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ingresototalpordiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource ingresototalpordiaBindingSource;
        private System.Windows.Forms.BindingSource reportesDataSetBindingSource;
        private ReportesDataSet reportesDataSet;
        private ReportesDataSetTableAdapters.ingreso_total_por_diaTableAdapter ingreso_total_por_diaTableAdapter;
    }
}