namespace CapaVista.Creditos
{
    partial class Creditos_entre_fechas
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
            this.CreditosDataset = new CapaVista.Creditos.CreditosDataset();
            this.CREDITOS_ENTRE_FECHASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CREDITOS_ENTRE_FECHASTableAdapter = new CapaVista.Creditos.CreditosDatasetTableAdapters.CREDITOS_ENTRE_FECHASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CreditosDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CREDITOS_ENTRE_FECHASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CREDITOS_ENTRE_FECHASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista.Creditos.Creditos_Entre_Fechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(961, 440);
            this.reportViewer1.TabIndex = 0;
            // 
            // CreditosDataset
            // 
            this.CreditosDataset.DataSetName = "CreditosDataset";
            this.CreditosDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CREDITOS_ENTRE_FECHASBindingSource
            // 
            this.CREDITOS_ENTRE_FECHASBindingSource.DataMember = "CREDITOS_ENTRE_FECHAS";
            this.CREDITOS_ENTRE_FECHASBindingSource.DataSource = this.CreditosDataset;
            // 
            // CREDITOS_ENTRE_FECHASTableAdapter
            // 
            this.CREDITOS_ENTRE_FECHASTableAdapter.ClearBeforeFill = true;
            // 
            // Creditos_entre_fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 440);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Creditos_entre_fechas";
            this.Text = "Visor Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Creditos_entre_fechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CreditosDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CREDITOS_ENTRE_FECHASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CREDITOS_ENTRE_FECHASBindingSource;
        private CreditosDataset CreditosDataset;
        private CreditosDatasetTableAdapters.CREDITOS_ENTRE_FECHASTableAdapter CREDITOS_ENTRE_FECHASTableAdapter;
    }
}