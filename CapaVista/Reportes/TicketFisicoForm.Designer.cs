namespace CapaVista.Reportes
{
    partial class TicketFisicoForm
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
            this.ticketDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaccionesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaccionesDataSet = new CapaVista.Transacciones.TransaccionesDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ticketDetalleTableAdapter = new CapaVista.Transacciones.TransaccionesDataSetTableAdapters.TicketDetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketDetalleBindingSource
            // 
            this.ticketDetalleBindingSource.DataMember = "TicketDetalle";
            this.ticketDetalleBindingSource.DataSource = this.transaccionesDataSetBindingSource;
            // 
            // transaccionesDataSetBindingSource
            // 
            this.transaccionesDataSetBindingSource.DataSource = this.transaccionesDataSet;
            this.transaccionesDataSetBindingSource.Position = 0;
            // 
            // transaccionesDataSet
            // 
            this.transaccionesDataSet.DataSetName = "TransaccionesDataSet";
            this.transaccionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Ticket";
            reportDataSource1.Value = this.ticketDetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista.Reportes.TicketFisico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(704, 665);
            this.reportViewer1.TabIndex = 0;
            // 
            // ticketDetalleTableAdapter
            // 
            this.ticketDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // TicketFisicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 745);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TicketFisicoForm";
            this.Text = "Visor Reportes";
            this.Load += new System.EventHandler(this.TicketFisicoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource transaccionesDataSetBindingSource;
        private Transacciones.TransaccionesDataSet transaccionesDataSet;
        private System.Windows.Forms.BindingSource ticketDetalleBindingSource;
        private Transacciones.TransaccionesDataSetTableAdapters.TicketDetalleTableAdapter ticketDetalleTableAdapter;
    }
}