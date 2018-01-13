namespace CapaVista.Transacciones
{
    partial class Ticket
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
            this.Reporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Reporte
            // 
            this.Reporte.ActiveViewIndex = -1;
            this.Reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Reporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.Reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reporte.Location = new System.Drawing.Point(20, 60);
            this.Reporte.Name = "Reporte";
            this.Reporte.ReuseParameterValuesOnRefresh = true;
            this.Reporte.ShowCloseButton = false;
            this.Reporte.ShowCopyButton = false;
            this.Reporte.ShowGroupTreeButton = false;
            this.Reporte.ShowLogo = false;
            this.Reporte.ShowParameterPanelButton = false;
            this.Reporte.ShowTextSearchButton = false;
            this.Reporte.Size = new System.Drawing.Size(571, 416);
            this.Reporte.TabIndex = 0;
            this.Reporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 496);
            this.Controls.Add(this.Reporte);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer Reporte;
    }
}