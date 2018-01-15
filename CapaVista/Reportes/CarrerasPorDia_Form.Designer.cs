namespace CapaVista.Reportes
{
    partial class CarrerasPorDia_Form
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
            this.carrerasPorDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportesDataSet = new CapaVista.Reportes.ReportesDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.carrerasPorDiaTableAdapter = new CapaVista.Reportes.ReportesDataSetTableAdapters.carrerasPorDiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasPorDiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // carrerasPorDiaBindingSource
            // 
            this.carrerasPorDiaBindingSource.DataMember = "carrerasPorDia";
            this.carrerasPorDiaBindingSource.DataSource = this.ReportesDataSet;
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
            reportDataSource1.Value = this.carrerasPorDiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista.Reportes.CarrerasPorDia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(354, 689);
            this.reportViewer1.TabIndex = 0;
            // 
            // carrerasPorDiaTableAdapter
            // 
            this.carrerasPorDiaTableAdapter.ClearBeforeFill = true;
            // 
            // CarrerasPorDia_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 769);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CarrerasPorDia_Form";
            this.Text = "Carreras Efectuadas";
            this.Load += new System.EventHandler(this.CarrerasPorDia_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carrerasPorDiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource carrerasPorDiaBindingSource;
        private ReportesDataSet ReportesDataSet;
        private ReportesDataSetTableAdapters.carrerasPorDiaTableAdapter carrerasPorDiaTableAdapter;
    }
}