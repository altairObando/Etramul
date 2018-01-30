namespace CapaVista.Creditos
{
    partial class Factura_Abono
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
            this.fact = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.fact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fact.LocalReport.ReportEmbeddedResource = "CapaVista.Creditos.Factura_por_abono.rdlc";
            this.fact.Location = new System.Drawing.Point(20, 60);
            this.fact.Name = "reportViewer1";
            this.fact.Size = new System.Drawing.Size(484, 425);
            this.fact.TabIndex = 0;
            // 
            // Factura_Abono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 505);
            this.Controls.Add(this.fact);
            this.Name = "Factura_Abono";
            this.Text = "Visor Reportes";
            this.Load += new System.EventHandler(this.Factura_Abono_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer fact;
    }
}