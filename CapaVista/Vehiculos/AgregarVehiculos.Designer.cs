namespace CapaVista.Vehiculos
{
    partial class AgregarVehiculos
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
            this.mpPanel = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtModelo = new MetroFramework.Controls.MetroTextBox();
            this.txtMarca = new MetroFramework.Controls.MetroTextBox();
            this.txtPlaca = new MetroFramework.Controls.MetroTextBox();
            this.txtCodSocio = new MetroFramework.Controls.MetroTextBox();
            this.lblModelo = new MetroFramework.Controls.MetroLabel();
            this.lblMarca = new MetroFramework.Controls.MetroLabel();
            this.lblPlaca = new MetroFramework.Controls.MetroLabel();
            this.lblSocio = new MetroFramework.Controls.MetroLabel();
            this.mpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mpPanel
            // 
            this.mpPanel.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.mpPanel.Controls.Add(this.pictureBox1);
            this.mpPanel.Controls.Add(this.btnCancelar);
            this.mpPanel.Controls.Add(this.btnBuscar);
            this.mpPanel.Controls.Add(this.btnGuardar);
            this.mpPanel.Controls.Add(this.txtModelo);
            this.mpPanel.Controls.Add(this.txtMarca);
            this.mpPanel.Controls.Add(this.txtPlaca);
            this.mpPanel.Controls.Add(this.txtCodSocio);
            this.mpPanel.Controls.Add(this.lblModelo);
            this.mpPanel.Controls.Add(this.lblMarca);
            this.mpPanel.Controls.Add(this.lblPlaca);
            this.mpPanel.Controls.Add(this.lblSocio);
            this.mpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpPanel.HorizontalScrollbarBarColor = true;
            this.mpPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mpPanel.HorizontalScrollbarSize = 10;
            this.mpPanel.Location = new System.Drawing.Point(20, 60);
            this.mpPanel.Name = "mpPanel";
            this.mpPanel.Size = new System.Drawing.Size(564, 243);
            this.mpPanel.TabIndex = 0;
            this.mpPanel.VerticalScrollbarBarColor = true;
            this.mpPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mpPanel.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.school_bus_1_;
            this.pictureBox1.Location = new System.Drawing.Point(418, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(256, 178);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 62);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::CapaVista.Properties.Resources.exchange_1_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(333, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 36);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::CapaVista.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(165, 178);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 62);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.CustomBackground = true;
            this.txtModelo.Location = new System.Drawing.Point(130, 135);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(201, 23);
            this.txtModelo.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModelo.TabIndex = 3;
            this.txtModelo.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtMarca
            // 
            this.txtMarca.CustomBackground = true;
            this.txtMarca.Location = new System.Drawing.Point(130, 97);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(201, 23);
            this.txtMarca.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMarca.TabIndex = 2;
            this.txtMarca.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtPlaca
            // 
            this.txtPlaca.CustomBackground = true;
            this.txtPlaca.Location = new System.Drawing.Point(130, 59);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(201, 23);
            this.txtPlaca.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtCodSocio
            // 
            this.txtCodSocio.CustomBackground = true;
            this.txtCodSocio.Enabled = false;
            this.txtCodSocio.Location = new System.Drawing.Point(130, 21);
            this.txtCodSocio.Name = "txtCodSocio";
            this.txtCodSocio.Size = new System.Drawing.Size(201, 23);
            this.txtCodSocio.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodSocio.TabIndex = 0;
            this.txtCodSocio.TabStop = false;
            this.txtCodSocio.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(69, 135);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(55, 19);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(78, 97);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 19);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(31, 59);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(92, 19);
            this.lblPlaca.TabIndex = 3;
            this.lblPlaca.Text = "Placa Vehiculo";
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Location = new System.Drawing.Point(35, 21);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(89, 19);
            this.lblSocio.TabIndex = 2;
            this.lblSocio.Text = "Codigo Socio";
            // 
            // AgregarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 323);
            this.Controls.Add(this.mpPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "AgregarVehiculos";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Agregar Vehiculo";
            this.mpPanel.ResumeLayout(false);
            this.mpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpPanel;
        private MetroFramework.Controls.MetroLabel lblModelo;
        private MetroFramework.Controls.MetroLabel lblMarca;
        private MetroFramework.Controls.MetroLabel lblPlaca;
        private MetroFramework.Controls.MetroLabel lblSocio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroTextBox txtPlaca;
        public MetroFramework.Controls.MetroTextBox txtCodSocio;
        public System.Windows.Forms.Button btnBuscar;
        public MetroFramework.Controls.MetroTextBox txtModelo;
        public MetroFramework.Controls.MetroTextBox txtMarca;
    }
}