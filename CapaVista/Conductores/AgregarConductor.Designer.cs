namespace CapaVista.Conductores
{
    partial class AgregarConductor
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
            this.paneDatosPersonales = new MetroFramework.Controls.MetroPanel();
            this.txtLicencia = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblDatosPersonales = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCorreo = new MetroFramework.Controls.MetroTextBox();
            this.txtDirecion = new System.Windows.Forms.TextBox();
            this.lblCedula = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtNombres = new MetroFramework.Controls.MetroTextBox();
            this.lblApellidos = new MetroFramework.Controls.MetroLabel();
            this.lblNombres = new MetroFramework.Controls.MetroLabel();
            this.txtApellidos = new MetroFramework.Controls.MetroTextBox();
            this.paneDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneDatosPersonales
            // 
            this.paneDatosPersonales.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.paneDatosPersonales.Controls.Add(this.txtLicencia);
            this.paneDatosPersonales.Controls.Add(this.btnCancelar);
            this.paneDatosPersonales.Controls.Add(this.btnGuardar);
            this.paneDatosPersonales.Controls.Add(this.metroLabel4);
            this.paneDatosPersonales.Controls.Add(this.metroLabel3);
            this.paneDatosPersonales.Controls.Add(this.lblDatosPersonales);
            this.paneDatosPersonales.Controls.Add(this.metroLabel2);
            this.paneDatosPersonales.Controls.Add(this.txtCorreo);
            this.paneDatosPersonales.Controls.Add(this.txtDirecion);
            this.paneDatosPersonales.Controls.Add(this.lblCedula);
            this.paneDatosPersonales.Controls.Add(this.metroLabel1);
            this.paneDatosPersonales.Controls.Add(this.txtCedula);
            this.paneDatosPersonales.Controls.Add(this.txtTelefono);
            this.paneDatosPersonales.Controls.Add(this.txtNombres);
            this.paneDatosPersonales.Controls.Add(this.lblApellidos);
            this.paneDatosPersonales.Controls.Add(this.lblNombres);
            this.paneDatosPersonales.Controls.Add(this.txtApellidos);
            this.paneDatosPersonales.CustomBackground = true;
            this.paneDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneDatosPersonales.HorizontalScrollbarBarColor = true;
            this.paneDatosPersonales.HorizontalScrollbarHighlightOnWheel = false;
            this.paneDatosPersonales.HorizontalScrollbarSize = 10;
            this.paneDatosPersonales.Location = new System.Drawing.Point(20, 60);
            this.paneDatosPersonales.Name = "paneDatosPersonales";
            this.paneDatosPersonales.Size = new System.Drawing.Size(550, 234);
            this.paneDatosPersonales.Style = MetroFramework.MetroColorStyle.Silver;
            this.paneDatosPersonales.TabIndex = 0;
            this.paneDatosPersonales.Theme = MetroFramework.MetroThemeStyle.Light;
            this.paneDatosPersonales.VerticalScrollbarBarColor = true;
            this.paneDatosPersonales.VerticalScrollbarHighlightOnWheel = false;
            this.paneDatosPersonales.VerticalScrollbarSize = 10;
            // 
            // txtLicencia
            // 
            this.txtLicencia.CustomBackground = true;
            this.txtLicencia.Location = new System.Drawing.Point(100, 153);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(155, 23);
            this.txtLicencia.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnCancelar.Location = new System.Drawing.Point(440, 153);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 58);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Image = global::CapaVista.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(342, 154);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 58);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 154);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Licencia";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Teléfono";
            // 
            // lblDatosPersonales
            // 
            this.lblDatosPersonales.AutoSize = true;
            this.lblDatosPersonales.Location = new System.Drawing.Point(3, 4);
            this.lblDatosPersonales.Name = "lblDatosPersonales";
            this.lblDatosPersonales.Size = new System.Drawing.Size(108, 19);
            this.lblDatosPersonales.TabIndex = 12;
            this.lblDatosPersonales.Text = "Datos Personales";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(303, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.CustomBackground = true;
            this.txtCorreo.Location = new System.Drawing.Point(360, 114);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(155, 23);
            this.txtCorreo.TabIndex = 6;
            // 
            // txtDirecion
            // 
            this.txtDirecion.Location = new System.Drawing.Point(360, 33);
            this.txtDirecion.Multiline = true;
            this.txtDirecion.Name = "txtDirecion";
            this.txtDirecion.Size = new System.Drawing.Size(155, 75);
            this.txtDirecion.TabIndex = 5;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(44, 33);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(50, 19);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cedula";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(291, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Direccion";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(100, 33);
            this.txtCedula.Mask = "000-000000-0000A";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(173, 20);
            this.txtCedula.TabIndex = 0;
            this.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(100, 117);
            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(173, 20);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombres
            // 
            this.txtNombres.CustomBackground = true;
            this.txtNombres.Location = new System.Drawing.Point(100, 59);
            this.txtNombres.MaxLength = 50;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(173, 23);
            this.txtNombres.TabIndex = 1;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(30, 90);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(63, 19);
            this.lblApellidos.TabIndex = 5;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(30, 61);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(64, 19);
            this.lblNombres.TabIndex = 3;
            this.lblNombres.Text = "Nombres";
            // 
            // txtApellidos
            // 
            this.txtApellidos.CustomBackground = true;
            this.txtApellidos.Location = new System.Drawing.Point(100, 88);
            this.txtApellidos.MaxLength = 50;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(173, 23);
            this.txtApellidos.TabIndex = 2;
            // 
            // AgregarConductor
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(590, 314);
            this.Controls.Add(this.paneDatosPersonales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarConductor";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.ShowInTaskbar = false;
            this.Text = "Agregar  Conductor";
            this.paneDatosPersonales.ResumeLayout(false);
            this.paneDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel paneDatosPersonales;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblDatosPersonales;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDirecion;
        private MetroFramework.Controls.MetroLabel lblCedula;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private MetroFramework.Controls.MetroTextBox txtNombres;
        private MetroFramework.Controls.MetroLabel lblApellidos;
        private MetroFramework.Controls.MetroLabel lblNombres;
        private MetroFramework.Controls.MetroTextBox txtApellidos;
        private MetroFramework.Controls.MetroTextBox txtLicencia;
    }
}