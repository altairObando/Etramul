namespace CapaVista.Vehiculos
{
    partial class VerDetalles
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
            this.txtSocio = new MetroFramework.Controls.MetroLabel();
            this.txtPlaca = new MetroFramework.Controls.MetroLabel();
            this.txtMarca = new MetroFramework.Controls.MetroLabel();
            this.txtModelo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblPlaca = new MetroFramework.Controls.MetroLabel();
            this.lblSocio = new MetroFramework.Controls.MetroLabel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSocio
            // 
            this.txtSocio.AccessibleName = "Datos de vehiculos";
            this.txtSocio.AutoSize = true;
            this.txtSocio.Location = new System.Drawing.Point(118, 62);
            this.txtSocio.Name = "txtSocio";
            this.txtSocio.Size = new System.Drawing.Size(33, 19);
            this.txtSocio.TabIndex = 0;
            this.txtSocio.Text = "----";
            // 
            // txtPlaca
            // 
            this.txtPlaca.AccessibleName = "Datos de vehiculos";
            this.txtPlaca.AutoSize = true;
            this.txtPlaca.Location = new System.Drawing.Point(118, 88);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(33, 19);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.Text = "----";
            // 
            // txtMarca
            // 
            this.txtMarca.AccessibleName = "Datos de vehiculos";
            this.txtMarca.AutoSize = true;
            this.txtMarca.Location = new System.Drawing.Point(118, 114);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(33, 19);
            this.txtMarca.TabIndex = 2;
            this.txtMarca.Text = "----";
            // 
            // txtModelo
            // 
            this.txtModelo.AccessibleName = "Datos de vehiculos";
            this.txtModelo.AutoSize = true;
            this.txtModelo.Location = new System.Drawing.Point(118, 140);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(33, 19);
            this.txtModelo.TabIndex = 3;
            this.txtModelo.Text = "----";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AccessibleName = "Datos de vehiculos";
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(29, 140);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(55, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Modelo";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AccessibleName = "Datos de vehiculos";
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(29, 114);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(46, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Marca";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AccessibleName = "Datos de vehiculos";
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(29, 88);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(40, 19);
            this.lblPlaca.TabIndex = 6;
            this.lblPlaca.Text = "Placa";
            // 
            // lblSocio
            // 
            this.lblSocio.AccessibleName = "Datos de vehiculos";
            this.lblSocio.AutoSize = true;
            this.lblSocio.Location = new System.Drawing.Point(29, 62);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(41, 19);
            this.lblSocio.TabIndex = 5;
            this.lblSocio.Text = "Socio";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnCerrar.Location = new System.Drawing.Point(168, 164);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 41);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // VerDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 208);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtSocio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerDetalles";
            this.Resizable = false;
            this.Text = "Detalles de vehiculo";
            this.Load += new System.EventHandler(this.VerDetalles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel txtSocio;
        private MetroFramework.Controls.MetroLabel txtPlaca;
        private MetroFramework.Controls.MetroLabel txtMarca;
        private MetroFramework.Controls.MetroLabel txtModelo;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblPlaca;
        private MetroFramework.Controls.MetroLabel lblSocio;
        private System.Windows.Forms.Button btnCerrar;
    }
}