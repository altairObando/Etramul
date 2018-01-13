namespace CapaVista.Reportes
{
    partial class MenuHerramientas
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
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.btnSocios = new MetroFramework.Controls.MetroTile();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnClose);
            this.panel.Controls.Add(this.metroTile2);
            this.panel.Controls.Add(this.btnSocios);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Location = new System.Drawing.Point(20, 60);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(304, 188);
            this.panel.TabIndex = 0;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnClose.Location = new System.Drawing.Point(204, 135);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(144, 3);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(157, 105);
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Tipos de Transaccion";
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // btnSocios
            // 
            this.btnSocios.Location = new System.Drawing.Point(3, 3);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Size = new System.Drawing.Size(135, 105);
            this.btnSocios.TabIndex = 2;
            this.btnSocios.Text = "Tipos de usuario";
            this.btnSocios.Click += new System.EventHandler(this.btnSocios_Click);
            // 
            // MenuHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 268);
            this.Controls.Add(this.panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "MenuHerramientas";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.ShowInTaskbar = false;
            this.Text = "Menu Herramientas";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panel;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile btnSocios;
        private System.Windows.Forms.Button btnClose;
    }
}