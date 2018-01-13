namespace CapaVista.Saldo
{
    partial class ConsultaSaldo
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
            this.cboVehiculo = new MetroFramework.Controls.MetroComboBox();
            this.lblVehiculo = new MetroFramework.Controls.MetroLabel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panelDatos = new MetroFramework.Controls.MetroPanel();
            this.Socio = new MetroFramework.Controls.MetroLabel();
            this.lblSocio = new MetroFramework.Controls.MetroLabel();
            this.lblPlaca = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblCuenta = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panelDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboVehiculo
            // 
            this.cboVehiculo.FormattingEnabled = true;
            this.cboVehiculo.ItemHeight = 23;
            this.cboVehiculo.Location = new System.Drawing.Point(23, 90);
            this.cboVehiculo.Name = "cboVehiculo";
            this.cboVehiculo.Size = new System.Drawing.Size(205, 29);
            this.cboVehiculo.TabIndex = 12;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(23, 68);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(122, 19);
            this.lblVehiculo.TabIndex = 13;
            this.lblVehiculo.Text = "Seleccione Vehiculo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(258, 90);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(58, 29);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.lblCuenta);
            this.panelDatos.Controls.Add(this.metroLabel3);
            this.panelDatos.Controls.Add(this.lblPlaca);
            this.panelDatos.Controls.Add(this.metroLabel2);
            this.panelDatos.Controls.Add(this.lblSocio);
            this.panelDatos.Controls.Add(this.Socio);
            this.panelDatos.HorizontalScrollbarBarColor = true;
            this.panelDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDatos.HorizontalScrollbarSize = 10;
            this.panelDatos.Location = new System.Drawing.Point(23, 150);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(293, 147);
            this.panelDatos.TabIndex = 15;
            this.panelDatos.VerticalScrollbarBarColor = true;
            this.panelDatos.VerticalScrollbarHighlightOnWheel = false;
            this.panelDatos.VerticalScrollbarSize = 10;
            // 
            // Socio
            // 
            this.Socio.AutoSize = true;
            this.Socio.Location = new System.Drawing.Point(18, 9);
            this.Socio.Name = "Socio";
            this.Socio.Size = new System.Drawing.Size(44, 19);
            this.Socio.TabIndex = 18;
            this.Socio.Text = "Socio:";
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Location = new System.Drawing.Point(92, 9);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(21, 19);
            this.lblSocio.TabIndex = 19;
            this.lblSocio.Text = "--";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(92, 43);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(21, 19);
            this.lblPlaca.TabIndex = 21;
            this.lblPlaca.Text = "--";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(18, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Placa:";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(92, 86);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(21, 19);
            this.lblCuenta.TabIndex = 23;
            this.lblCuenta.Text = "--";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 86);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Estado:";
            // 
            // ConsultaSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 320);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboVehiculo);
            this.Controls.Add(this.lblVehiculo);
            this.Name = "ConsultaSaldo";
            this.Text = "ConsultaSaldo";
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboVehiculo;
        private MetroFramework.Controls.MetroLabel lblVehiculo;
        private System.Windows.Forms.Button btnAceptar;
        private MetroFramework.Controls.MetroPanel panelDatos;
        private MetroFramework.Controls.MetroLabel lblCuenta;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblPlaca;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblSocio;
        private MetroFramework.Controls.MetroLabel Socio;
    }
}