namespace CapaVista.Transacciones
{
    partial class Administracion
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
            this.cboUsuario = new MetroFramework.Controls.MetroComboBox();
            this.lblInfo = new MetroFramework.Controls.MetroLabel();
            this.lblUser = new MetroFramework.Controls.MetroLabel();
            this.lblClave = new MetroFramework.Controls.MetroLabel();
            this.lblError = new MetroFramework.Controls.MetroLabel();
            this.txtClave = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.ItemHeight = 23;
            this.cboUsuario.Location = new System.Drawing.Point(86, 86);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(263, 29);
            this.cboUsuario.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(88, 64);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(183, 19);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Proporcione Sus Credenciales";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(6, 86);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(67, 19);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Nickname";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(32, 122);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(41, 19);
            this.lblClave.TabIndex = 6;
            this.lblClave.Text = "Clave";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(96, 151);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(211, 19);
            this.lblError.Style = MetroFramework.MetroColorStyle.Red;
            this.lblError.TabIndex = 8;
            this.lblError.Text = "*La clave proporciona no es valida";
            this.lblError.UseStyleColors = true;
            this.lblError.Visible = false;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(87, 125);
            this.txtClave.MaxLength = 20;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '•';
            this.txtClave.PromptText = "Verifique su clave de acceso";
            this.txtClave.Size = new System.Drawing.Size(263, 23);
            this.txtClave.Style = MetroFramework.MetroColorStyle.Red;
            this.txtClave.TabIndex = 3;
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClave.UseStyleColors = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(215, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 38);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Image = global::CapaVista.Properties.Resources.btnLogin;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(123, 174);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 40);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Administracion
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(425, 235);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.cboUsuario);
            this.Movable = false;
            this.Name = "Administracion";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Control de cuentas de usuario";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboUsuario;
        private MetroFramework.Controls.MetroLabel lblInfo;
        private MetroFramework.Controls.MetroLabel lblUser;
        private MetroFramework.Controls.MetroLabel lblClave;
        private MetroFramework.Controls.MetroLabel lblError;
        private MetroFramework.Controls.MetroTextBox txtClave;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}