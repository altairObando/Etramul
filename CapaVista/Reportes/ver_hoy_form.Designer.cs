namespace CapaVista.Reportes
{
    partial class ver_hoy_form
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
            this.TRANSACCION_DIA_VEHICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportesDataSet = new CapaVista.Reportes.ReportesDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TRANSACCION_DIA_VEHICULOTableAdapter = new CapaVista.Reportes.ReportesDataSetTableAdapters.TRANSACCION_DIA_VEHICULOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TRANSACCION_DIA_VEHICULOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TRANSACCION_DIA_VEHICULOBindingSource
            // 
            this.TRANSACCION_DIA_VEHICULOBindingSource.DataMember = "TRANSACCION_DIA_VEHICULO";
            this.TRANSACCION_DIA_VEHICULOBindingSource.DataSource = this.ReportesDataSet;
            // 
            // ReportesDataSet
            // 
            this.ReportesDataSet.DataSetName = "ReportesDataSet";
            this.ReportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TRANSACCION_DIA_VEHICULOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista.Reportes.ver hoy.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(359, 628);
            this.reportViewer1.TabIndex = 0;
            // 
            // TRANSACCION_DIA_VEHICULOTableAdapter
            // 
            this.TRANSACCION_DIA_VEHICULOTableAdapter.ClearBeforeFill = true;
            // 
            // ver_hoy_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 708);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ver_hoy_form";
            this.Text = "Visor Reportes";
            this.Load += new System.EventHandler(this.ver_hoy_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TRANSACCION_DIA_VEHICULOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TRANSACCION_DIA_VEHICULOBindingSource;
        private ReportesDataSet ReportesDataSet;
        private ReportesDataSetTableAdapters.TRANSACCION_DIA_VEHICULOTableAdapter TRANSACCION_DIA_VEHICULOTableAdapter;
    }
}