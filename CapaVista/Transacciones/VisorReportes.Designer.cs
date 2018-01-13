namespace CapaVista.Transacciones
{
    partial class VisorReportes
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
            this.Visor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Visor
            // 
            this.Visor.ActiveViewIndex = -1;
            this.Visor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Visor.Cursor = System.Windows.Forms.Cursors.Default;
            this.Visor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Visor.Location = new System.Drawing.Point(20, 60);
            this.Visor.Name = "Visor";
            this.Visor.ShowCloseButton = false;
            this.Visor.ShowGroupTreeButton = false;
            this.Visor.ShowLogo = false;
            this.Visor.ShowParameterPanelButton = false;
            this.Visor.Size = new System.Drawing.Size(743, 411);
            this.Visor.TabIndex = 0;
            this.Visor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 491);
            this.Controls.Add(this.Visor);
            this.Name = "VisorReportes";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.ShowInTaskbar = false;
            this.Text = "Visor de Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer Visor;

        
    }
}