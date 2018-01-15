namespace CapaVista.Reportes
{
    partial class VerEntreFechasForm
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
            this.verEntreFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportesDataset = new CapaVista.Reportes.ReportesDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.verEntreFechasTableAdapter = new CapaVista.Reportes.ReportesDataSetTableAdapters.verEntreFechasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.verEntreFechasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // verEntreFechasBindingSource
            // 
            this.verEntreFechasBindingSource.DataMember = "verEntreFechas";
            this.verEntreFechasBindingSource.DataSource = this.ReportesDataset;
            // 
            // ReportesDataset
            // 
            this.ReportesDataset.DataSetName = "ReportesDataset";
            this.ReportesDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "VerEntreFechas";
            reportDataSource1.Value = this.verEntreFechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista.Reportes.VerEntreFechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(353, 615);
            this.reportViewer1.TabIndex = 0;
            // 
            // verEntreFechasTableAdapter
            // 
            this.verEntreFechasTableAdapter.ClearBeforeFill = true;
            // 
            // VerEntreFechasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 695);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VerEntreFechasForm";
            this.Text = "Visor Reportes";
            this.Load += new System.EventHandler(this.VerEntreFechasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.verEntreFechasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource verEntreFechasBindingSource;
        private ReportesDataSet ReportesDataset;
        private ReportesDataSetTableAdapters.verEntreFechasTableAdapter verEntreFechasTableAdapter;
    }
}