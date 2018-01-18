namespace CapaVista.Reportes
{
    partial class ImprimirFactura
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
            this.DetalleDeTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportesDataSet = new CapaVista.Reportes.ReportesDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DetalleDeTransaccionTableAdapter = new CapaVista.Reportes.ReportesDataSetTableAdapters.DetalleDeTransaccionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDeTransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalleDeTransaccionBindingSource
            // 
            this.DetalleDeTransaccionBindingSource.DataMember = "DetalleDeTransaccion";
            this.DetalleDeTransaccionBindingSource.DataSource = this.ReportesDataSet;
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
            reportDataSource1.Value = this.DetalleDeTransaccionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista.Reportes.ImprimirFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(728, 643);
            this.reportViewer1.TabIndex = 0;
            // 
            // DetalleDeTransaccionTableAdapter
            // 
            this.DetalleDeTransaccionTableAdapter.ClearBeforeFill = true;
            // 
            // ImprimirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 723);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ImprimirFactura";
            this.Text = "Visor Reportes";
            this.Load += new System.EventHandler(this.ImprimirFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDeTransaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DetalleDeTransaccionBindingSource;
        private ReportesDataSet ReportesDataSet;
        private ReportesDataSetTableAdapters.DetalleDeTransaccionTableAdapter DetalleDeTransaccionTableAdapter;
    }
}