namespace CapaVista.Socios
{
    partial class ModificarSocio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneDatosPersonales = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.dtpF_asociacion = new System.Windows.Forms.DateTimePicker();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.F_Asociacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSocio = new System.Windows.Forms.DataGridView();
            this.paneDatosPersonales.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocio)).BeginInit();
            this.SuspendLayout();
            // 
            // paneDatosPersonales
            // 
            this.paneDatosPersonales.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.paneDatosPersonales.Controls.Add(this.metroLabel5);
            this.paneDatosPersonales.Controls.Add(this.panel1);
            this.paneDatosPersonales.Controls.Add(this.dtpF_asociacion);
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
            this.paneDatosPersonales.HorizontalScrollbarBarColor = true;
            this.paneDatosPersonales.HorizontalScrollbarHighlightOnWheel = false;
            this.paneDatosPersonales.HorizontalScrollbarSize = 10;
            this.paneDatosPersonales.Location = new System.Drawing.Point(20, 67);
            this.paneDatosPersonales.Name = "paneDatosPersonales";
            this.paneDatosPersonales.Size = new System.Drawing.Size(580, 202);
            this.paneDatosPersonales.Style = MetroFramework.MetroColorStyle.Silver;
            this.paneDatosPersonales.TabIndex = 0;
            this.paneDatosPersonales.Theme = MetroFramework.MetroThemeStyle.Light;
            this.paneDatosPersonales.VerticalScrollbarBarColor = true;
            this.paneDatosPersonales.VerticalScrollbarHighlightOnWheel = false;
            this.paneDatosPersonales.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(297, 157);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Estado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnInactivo);
            this.panel1.Controls.Add(this.rbtnActivo);
            this.panel1.Location = new System.Drawing.Point(360, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 30);
            this.panel1.TabIndex = 18;
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Location = new System.Drawing.Point(81, 3);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtnInactivo.TabIndex = 1;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UseVisualStyleBackColor = true;
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Checked = true;
            this.rbtnActivo.Location = new System.Drawing.Point(3, 3);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtnActivo.TabIndex = 0;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            // 
            // dtpF_asociacion
            // 
            this.dtpF_asociacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpF_asociacion.Location = new System.Drawing.Point(164, 153);
            this.dtpF_asociacion.Name = "dtpF_asociacion";
            this.dtpF_asociacion.Size = new System.Drawing.Size(109, 20);
            this.dtpF_asociacion.TabIndex = 4;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 154);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(128, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Fecha de Asociación";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Teléfono";
            // 
            // lblDatosPersonales
            // 
            this.lblDatosPersonales.AutoSize = true;
            this.lblDatosPersonales.Location = new System.Drawing.Point(3, 4);
            this.lblDatosPersonales.Name = "lblDatosPersonales";
            this.lblDatosPersonales.Size = new System.Drawing.Size(107, 19);
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
            this.txtCorreo.Size = new System.Drawing.Size(196, 23);
            this.txtCorreo.TabIndex = 6;
            // 
            // txtDirecion
            // 
            this.txtDirecion.Location = new System.Drawing.Point(360, 33);
            this.txtDirecion.Multiline = true;
            this.txtDirecion.Name = "txtDirecion";
            this.txtDirecion.Size = new System.Drawing.Size(196, 75);
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
            this.txtCedula.Enabled = false;
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
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(701, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 58);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Salir";
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
            this.btnGuardar.Image = global::CapaVista.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(620, 211);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 58);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::CapaVista.Properties.Resources.worker;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(620, 138);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 58);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::CapaVista.Properties.Resources.plus;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(701, 138);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 58);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.teamwork;
            this.pictureBox1.Location = new System.Drawing.Point(625, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // F_Asociacion
            // 
            this.F_Asociacion.HeaderText = "Fecha Asociacion";
            this.F_Asociacion.Name = "F_Asociacion";
            this.F_Asociacion.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellidos";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombres";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // dgvSocio
            // 
            this.dgvSocio.AllowUserToAddRows = false;
            this.dgvSocio.AllowUserToDeleteRows = false;
            this.dgvSocio.AllowUserToResizeRows = false;
            this.dgvSocio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSocio.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSocio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSocio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.Telefono,
            this.Correo,
            this.F_Asociacion});
            this.dgvSocio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSocio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSocio.Location = new System.Drawing.Point(20, 287);
            this.dgvSocio.MultiSelect = false;
            this.dgvSocio.Name = "dgvSocio";
            this.dgvSocio.ReadOnly = true;
            this.dgvSocio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSocio.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSocio.RowHeadersVisible = false;
            this.dgvSocio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSocio.Size = new System.Drawing.Size(754, 187);
            this.dgvSocio.TabIndex = 5;
            this.dgvSocio.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSocio_CellContentClick);
            // 
            // ModificarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvSocio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.paneDatosPersonales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarSocio";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.ShowInTaskbar = false;
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.ModificarSocio_Load);
            this.paneDatosPersonales.ResumeLayout(false);
            this.paneDatosPersonales.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel paneDatosPersonales;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblDatosPersonales;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblCedula;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblApellidos;
        private MetroFramework.Controls.MetroLabel lblNombres;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Asociacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        public System.Windows.Forms.DateTimePicker dtpF_asociacion;
        public MetroFramework.Controls.MetroTextBox txtCorreo;
        public System.Windows.Forms.TextBox txtDirecion;
        public System.Windows.Forms.MaskedTextBox txtCedula;
        public System.Windows.Forms.MaskedTextBox txtTelefono;
        public MetroFramework.Controls.MetroTextBox txtNombres;
        public MetroFramework.Controls.MetroTextBox txtApellidos;
        public System.Windows.Forms.RadioButton rbtnInactivo;
        public System.Windows.Forms.RadioButton rbtnActivo;
        public System.Windows.Forms.DataGridView dgvSocio;
        public System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnNuevo;
    }
}