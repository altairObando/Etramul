namespace CapaVista.Reportes
{
    partial class GastosPorRubroPorDia_form
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
            this.gastosPorRubroPorDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaccionesDataSet = new CapaVista.Transacciones.TransaccionesDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gastosPorRubroPorDiaTableAdapter = new CapaVista.Transacciones.TransaccionesDataSetTableAdapters.GastosPorRubroPorDiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gastosPorRubroPorDiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gastosPorRubroPorDiaBindingSource
            // 
            this.gastosPorRubroPorDiaBindingSource.DataMember = "GastosPorRubroPorDia";
            this.gastosPorRubroPorDiaBindingSource.DataSource = this.transaccionesDataSet;
            // 
            // transaccionesDataSet
            // 
            this.transaccionesDataSet.DataSetName = "TransaccionesDataSet";
            this.transaccionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gastosPorRubroPorDiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista.Reportes.GastosPorRubroPorDia_form.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(737, 617);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // gastosPorRubroPorDiaTableAdapter
            // 
            this.gastosPorRubroPorDiaTableAdapter.ClearBeforeFill = true;
            // 
            // GastosPorRubroPorDia_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 697);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GastosPorRubroPorDia_form";
            this.Text = "Visor Reportes";
            this.Load += new System.EventHandler(this.GastosPorRubroPorDia_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gastosPorRubroPorDiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource gastosPorRubroPorDiaBindingSource;
        private Transacciones.TransaccionesDataSet transaccionesDataSet;
        private Transacciones.TransaccionesDataSetTableAdapters.GastosPorRubroPorDiaTableAdapter gastosPorRubroPorDiaTableAdapter;
    }
}