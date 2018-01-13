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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Ingresos_DiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportesDataSet = new CapaVista.Reportes.ReportesDataSet();
            this.Egresos_DiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Ingresos_DiaTableAdapter = new CapaVista.Reportes.ReportesDataSetTableAdapters.Ingresos_DiaTableAdapter();
            this.Egresos_DiaTableAdapter = new CapaVista.Reportes.ReportesDataSetTableAdapters.Egresos_DiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Ingresos_DiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Egresos_DiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Ingresos_DiaBindingSource
            // 
            this.Ingresos_DiaBindingSource.DataMember = "Ingresos_Dia";
            this.Ingresos_DiaBindingSource.DataSource = this.ReportesDataSet;
            // 
            // ReportesDataSet
            // 
            this.ReportesDataSet.DataSetName = "ReportesDataSet";
            this.ReportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Egresos_DiaBindingSource
            // 
            this.Egresos_DiaBindingSource.DataMember = "Egresos_Dia";
            this.Egresos_DiaBindingSource.DataSource = this.ReportesDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Ingresos_DiaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Egresos_DiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista.Reportes.Ver hoy.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(639, 653);
            this.reportViewer1.TabIndex = 0;
            // 
            // Ingresos_DiaTableAdapter
            // 
            this.Ingresos_DiaTableAdapter.ClearBeforeFill = true;
            // 
            // Egresos_DiaTableAdapter
            // 
            this.Egresos_DiaTableAdapter.ClearBeforeFill = true;
            // 
            // ver_hoy_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 733);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ver_hoy_form";
            this.Text = "Visor Reportes";
            this.Load += new System.EventHandler(this.ver_hoy_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ingresos_DiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Egresos_DiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Ingresos_DiaBindingSource;
        private ReportesDataSet ReportesDataSet;
        private System.Windows.Forms.BindingSource Egresos_DiaBindingSource;
        private ReportesDataSetTableAdapters.Ingresos_DiaTableAdapter Ingresos_DiaTableAdapter;
        private ReportesDataSetTableAdapters.Egresos_DiaTableAdapter Egresos_DiaTableAdapter;
    }
}