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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportesDataSet = new CapaVista.Reportes.ReportesDataSet();
            this.verEntreFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verEntreFechasTableAdapter = new CapaVista.Reportes.ReportesDataSetTableAdapters.verEntreFechasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verEntreFechasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportesDataSet";
            reportDataSource1.Value = this.verEntreFechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista.Reportes.EntreFechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(810, 683);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportesDataSet
            // 
            this.ReportesDataSet.DataSetName = "ReportesDataSet";
            this.ReportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verEntreFechasBindingSource
            // 
            this.verEntreFechasBindingSource.DataMember = "verEntreFechas";
            this.verEntreFechasBindingSource.DataSource = this.ReportesDataSet;
            // 
            // verEntreFechasTableAdapter
            // 
            this.verEntreFechasTableAdapter.ClearBeforeFill = true;
            // 
            // VerEntreFechasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 763);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VerEntreFechasForm";
            this.Text = "Visor Reportes";
            this.Load += new System.EventHandler(this.VerEntreFechasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verEntreFechasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource verEntreFechasBindingSource;
        private ReportesDataSet ReportesDataSet;
        private ReportesDataSetTableAdapters.verEntreFechasTableAdapter verEntreFechasTableAdapter;
    }
}