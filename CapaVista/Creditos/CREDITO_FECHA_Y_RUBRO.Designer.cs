namespace CapaVista.Creditos
{
    partial class CREDITO_FECHA_Y_RUBRO
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
            this.reporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CreditosDataset = new CapaVista.Creditos.CreditosDataset();
            this.CREDITOS_POR_FECHA_Y_RUBROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CREDITOS_POR_FECHA_Y_RUBROTableAdapter = new CapaVista.Creditos.CreditosDatasetTableAdapters.CREDITOS_POR_FECHA_Y_RUBROTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CreditosDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CREDITOS_POR_FECHA_Y_RUBROBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CREDITOS_POR_FECHA_Y_RUBROBindingSource;
            this.reporte.LocalReport.DataSources.Add(reportDataSource1);
            this.reporte.LocalReport.ReportEmbeddedResource = "CapaVista.Creditos.CREDITOS_FECHA_Y_RUBRO.rdlc";
            this.reporte.Location = new System.Drawing.Point(0, 0);
            this.reporte.Name = "reportViewer1";
            this.reporte.Size = new System.Drawing.Size(711, 453);
            this.reporte.TabIndex = 0;
            // 
            // CreditosDataset
            // 
            this.CreditosDataset.DataSetName = "CreditosDataset";
            this.CreditosDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CREDITOS_POR_FECHA_Y_RUBROBindingSource
            // 
            this.CREDITOS_POR_FECHA_Y_RUBROBindingSource.DataMember = "CREDITOS_POR_FECHA_Y_RUBRO";
            this.CREDITOS_POR_FECHA_Y_RUBROBindingSource.DataSource = this.CreditosDataset;
            // 
            // CREDITOS_POR_FECHA_Y_RUBROTableAdapter
            // 
            this.CREDITOS_POR_FECHA_Y_RUBROTableAdapter.ClearBeforeFill = true;
            // 
            // CREDITO_FECHA_RUBRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 453);
            this.Controls.Add(this.reporte);
            this.Name = "CREDITO_FECHA_RUBRO";
            this.Text = "Visor Reportes";
            this.Load += new System.EventHandler(this.CREDITO_FECHA_RUBRO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CreditosDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CREDITOS_POR_FECHA_Y_RUBROBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte;
        private System.Windows.Forms.BindingSource CREDITOS_POR_FECHA_Y_RUBROBindingSource;
        private CreditosDataset CreditosDataset;
        private CreditosDatasetTableAdapters.CREDITOS_POR_FECHA_Y_RUBROTableAdapter CREDITOS_POR_FECHA_Y_RUBROTableAdapter;
    }
}