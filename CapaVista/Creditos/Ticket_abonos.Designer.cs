namespace CapaVista.Creditos
{
    partial class Ticket_abonos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CreditosDataset = new CapaVista.Creditos.CreditosDataset();
            this.ABONOS_POR_DETALLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ABONOS_POR_DETALLETableAdapter = new CapaVista.Creditos.CreditosDatasetTableAdapters.ABONOS_POR_DETALLETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CreditosDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ABONOS_POR_DETALLEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ABONOS_POR_DETALLEBindingSource;
            this.reporte.LocalReport.DataSources.Add(reportDataSource2);
            this.reporte.LocalReport.ReportEmbeddedResource = "CapaVista.Creditos.Ticke_abonos.rdlc";
            this.reporte.Location = new System.Drawing.Point(0, 0);
            this.reporte.Name = "reportViewer1";
            this.reporte.Size = new System.Drawing.Size(705, 390);
            this.reporte.TabIndex = 0;
            // 
            // CreditosDataset
            // 
            this.CreditosDataset.DataSetName = "CreditosDataset";
            this.CreditosDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ABONOS_POR_DETALLEBindingSource
            // 
            this.ABONOS_POR_DETALLEBindingSource.DataMember = "ABONOS_POR_DETALLE";
            this.ABONOS_POR_DETALLEBindingSource.DataSource = this.CreditosDataset;
            // 
            // ABONOS_POR_DETALLETableAdapter
            // 
            this.ABONOS_POR_DETALLETableAdapter.ClearBeforeFill = true;
            // 
            // Ticket_abonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 390);
            this.Controls.Add(this.reporte);
            this.Name = "Ticket_abonos";
            this.Text = "Visor Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ticket_abonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CreditosDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ABONOS_POR_DETALLEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte;
        private System.Windows.Forms.BindingSource ABONOS_POR_DETALLEBindingSource;
        private CreditosDataset CreditosDataset;
        private CreditosDatasetTableAdapters.ABONOS_POR_DETALLETableAdapter ABONOS_POR_DETALLETableAdapter;
    }
}