namespace CapaVista
{
    partial class AdministrarUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarUsuarios));
            this.lblCedula = new MetroFramework.Controls.MetroLabel();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.txtNombres = new MetroFramework.Controls.MetroTextBox();
            this.lblNombres = new MetroFramework.Controls.MetroLabel();
            this.lblApellidos = new MetroFramework.Controls.MetroLabel();
            this.txtApellidos = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCorreo = new MetroFramework.Controls.MetroTextBox();
            this.paneDatosPersonales = new MetroFramework.Controls.MetroPanel();
            this.txtDirecion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblDatosPersonales = new MetroFramework.Controls.MetroLabel();
            this.panelUsuario = new MetroFramework.Controls.MetroPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cboTipos = new MetroFramework.Controls.MetroComboBox();
            this.lblTipo = new MetroFramework.Controls.MetroLabel();
            this.txtClave2 = new MetroFramework.Controls.MetroTextBox();
            this.lblClave2 = new MetroFramework.Controls.MetroLabel();
            this.txtclave = new MetroFramework.Controls.MetroTextBox();
            this.lblClave1 = new MetroFramework.Controls.MetroLabel();
            this.txtNick = new MetroFramework.Controls.MetroTextBox();
            this.lblNickname = new MetroFramework.Controls.MetroLabel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDesplegable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneDatosPersonales.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.menuDesplegable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(100, 33);
            this.txtCedula.Mask = "000-000000-0000A";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(173, 20);
            this.txtCedula.TabIndex = 0;
            this.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(100, 59);
            this.txtNombres.MaxLength = 50;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PromptText = "Nombres";
            this.txtNombres.Size = new System.Drawing.Size(173, 23);
            this.txtNombres.TabIndex = 1;
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
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(30, 90);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(63, 19);
            this.lblApellidos.TabIndex = 5;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(100, 88);
            this.txtApellidos.MaxLength = 50;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PromptText = "1er y 2do apellido";
            this.txtApellidos.Size = new System.Drawing.Size(173, 23);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.Click += new System.EventHandler(this.txtApellidos_Click);
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(291, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Direccion";
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
            this.txtCorreo.Location = new System.Drawing.Point(360, 114);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PromptText = "Correo electronico";
            this.txtCorreo.Size = new System.Drawing.Size(155, 23);
            this.txtCorreo.TabIndex = 5;
            // 
            // paneDatosPersonales
            // 
            this.paneDatosPersonales.Controls.Add(this.txtDirecion);
            this.paneDatosPersonales.Controls.Add(this.metroLabel3);
            this.paneDatosPersonales.Controls.Add(this.lblDatosPersonales);
            this.paneDatosPersonales.Controls.Add(this.metroLabel2);
            this.paneDatosPersonales.Controls.Add(this.txtCorreo);
            this.paneDatosPersonales.Controls.Add(this.lblCedula);
            this.paneDatosPersonales.Controls.Add(this.metroLabel1);
            this.paneDatosPersonales.Controls.Add(this.txtCedula);
            this.paneDatosPersonales.Controls.Add(this.txtTelefono);
            this.paneDatosPersonales.Controls.Add(this.txtNombres);
            this.paneDatosPersonales.Controls.Add(this.lblApellidos);
            this.paneDatosPersonales.Controls.Add(this.lblNombres);
            this.paneDatosPersonales.Controls.Add(this.txtApellidos);
            this.paneDatosPersonales.HorizontalScrollbarBarColor = true;
            this.paneDatosPersonales.HorizontalScrollbarHighlightOnWheel = false;
            this.paneDatosPersonales.HorizontalScrollbarSize = 10;
            this.paneDatosPersonales.Location = new System.Drawing.Point(10, 63);
            this.paneDatosPersonales.Name = "paneDatosPersonales";
            this.paneDatosPersonales.Size = new System.Drawing.Size(538, 157);
            this.paneDatosPersonales.Style = MetroFramework.MetroColorStyle.Silver;
            this.paneDatosPersonales.TabIndex = 0;
            this.paneDatosPersonales.Theme = MetroFramework.MetroThemeStyle.Light;
            this.paneDatosPersonales.VerticalScrollbarBarColor = true;
            this.paneDatosPersonales.VerticalScrollbarHighlightOnWheel = false;
            this.paneDatosPersonales.VerticalScrollbarSize = 10;
            // 
            // txtDirecion
            // 
            this.txtDirecion.Location = new System.Drawing.Point(360, 34);
            this.txtDirecion.Multiline = true;
            this.txtDirecion.Name = "txtDirecion";
            this.txtDirecion.PromptText = "Direccion de vivienda";
            this.txtDirecion.Size = new System.Drawing.Size(155, 77);
            this.txtDirecion.TabIndex = 4;
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
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.btnCancelar);
            this.panelUsuario.Controls.Add(this.btnGuardar);
            this.panelUsuario.Controls.Add(this.metroLabel4);
            this.panelUsuario.Controls.Add(this.cboTipos);
            this.panelUsuario.Controls.Add(this.lblTipo);
            this.panelUsuario.Controls.Add(this.txtClave2);
            this.panelUsuario.Controls.Add(this.lblClave2);
            this.panelUsuario.Controls.Add(this.txtclave);
            this.panelUsuario.Controls.Add(this.lblClave1);
            this.panelUsuario.Controls.Add(this.txtNick);
            this.panelUsuario.Controls.Add(this.lblNickname);
            this.panelUsuario.HorizontalScrollbarBarColor = true;
            this.panelUsuario.HorizontalScrollbarHighlightOnWheel = false;
            this.panelUsuario.HorizontalScrollbarSize = 10;
            this.panelUsuario.Location = new System.Drawing.Point(10, 226);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(538, 132);
            this.panelUsuario.TabIndex = 1;
            this.panelUsuario.VerticalScrollbarBarColor = true;
            this.panelUsuario.VerticalScrollbarHighlightOnWheel = false;
            this.panelUsuario.VerticalScrollbarSize = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnCancelar.Location = new System.Drawing.Point(440, 71);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 58);
            this.btnCancelar.TabIndex = 15;
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
            this.btnGuardar.Image = global::CapaVista.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(360, 69);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 58);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(102, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Datos de Sesión";
            // 
            // cboTipos
            // 
            this.cboTipos.FormattingEnabled = true;
            this.cboTipos.ItemHeight = 23;
            this.cboTipos.Location = new System.Drawing.Point(310, 32);
            this.cboTipos.Name = "cboTipos";
            this.cboTipos.Size = new System.Drawing.Size(205, 29);
            this.cboTipos.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(338, 14);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(148, 19);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Seleccione Tipo Usuario";
            // 
            // txtClave2
            // 
            this.txtClave2.Location = new System.Drawing.Point(100, 96);
            this.txtClave2.MaxLength = 50;
            this.txtClave2.Name = "txtClave2";
            this.txtClave2.PasswordChar = '•';
            this.txtClave2.PromptText = "Repita Clave de Acceso";
            this.txtClave2.Size = new System.Drawing.Size(173, 23);
            this.txtClave2.TabIndex = 2;
            // 
            // lblClave2
            // 
            this.lblClave2.AutoSize = true;
            this.lblClave2.Location = new System.Drawing.Point(8, 100);
            this.lblClave2.Name = "lblClave2";
            this.lblClave2.Size = new System.Drawing.Size(82, 19);
            this.lblClave2.TabIndex = 9;
            this.lblClave2.Text = "Repita Clave";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(100, 67);
            this.txtclave.MaxLength = 50;
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '•';
            this.txtclave.PromptText = "Clave de acceso";
            this.txtclave.Size = new System.Drawing.Size(173, 23);
            this.txtclave.TabIndex = 1;
            // 
            // lblClave1
            // 
            this.lblClave1.AutoSize = true;
            this.lblClave1.Location = new System.Drawing.Point(49, 71);
            this.lblClave1.Name = "lblClave1";
            this.lblClave1.Size = new System.Drawing.Size(41, 19);
            this.lblClave1.TabIndex = 7;
            this.lblClave1.Text = "Clave";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(100, 38);
            this.txtNick.MaxLength = 50;
            this.txtNick.Name = "txtNick";
            this.txtNick.PromptText = "Nombre de usuario";
            this.txtNick.Size = new System.Drawing.Size(173, 23);
            this.txtNick.TabIndex = 0;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(23, 42);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(67, 19);
            this.lblNickname.TabIndex = 5;
            this.lblNickname.Text = "Nickname";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cargo,
            this.Nickname,
            this.Nombres,
            this.Apellidos,
            this.Correo,
            this.Telefono});
            this.dgvUsuarios.ContextMenuStrip = this.menuDesplegable;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(10, 364);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 40;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(746, 158);
            this.dgvUsuarios.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Identificacion";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // Nickname
            // 
            this.Nickname.HeaderText = "Nickname";
            this.Nickname.Name = "Nickname";
            this.Nickname.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
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
            // menuDesplegable
            // 
            this.menuDesplegable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.toolStripSeparator1});
            this.menuDesplegable.Name = "menuDesplegable";
            this.menuDesplegable.Size = new System.Drawing.Size(203, 54);
            // 
            // editarUsuarioToolStripMenuItem
            // 
            this.editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            this.editarUsuarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.editarUsuarioToolStripMenuItem.Text = "Editar Usuario";
            this.editarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.editarUsuario_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarMenuItem);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.student;
            this.pictureBox1.Location = new System.Drawing.Point(554, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(769, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.paneDatosPersonales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministrarUsuarios";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Administrar Usuarios";
            this.Load += new System.EventHandler(this.AdministrarUsuarios_Load);
            this.paneDatosPersonales.ResumeLayout(false);
            this.paneDatosPersonales.PerformLayout();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.menuDesplegable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCedula;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private MetroFramework.Controls.MetroTextBox txtNombres;
        private MetroFramework.Controls.MetroLabel lblNombres;
        private MetroFramework.Controls.MetroLabel lblApellidos;
        private MetroFramework.Controls.MetroTextBox txtApellidos;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCorreo;
        private MetroFramework.Controls.MetroPanel paneDatosPersonales;
        private MetroFramework.Controls.MetroLabel lblDatosPersonales;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel panelUsuario;
        private MetroFramework.Controls.MetroTextBox txtNick;
        private MetroFramework.Controls.MetroLabel lblNickname;
        private MetroFramework.Controls.MetroTextBox txtClave2;
        private MetroFramework.Controls.MetroLabel lblClave2;
        private MetroFramework.Controls.MetroTextBox txtclave;
        private MetroFramework.Controls.MetroLabel lblClave1;
        private MetroFramework.Controls.MetroComboBox cboTipos;
        private MetroFramework.Controls.MetroLabel lblTipo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.ContextMenuStrip menuDesplegable;
        private System.Windows.Forms.ToolStripMenuItem editarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private MetroFramework.Controls.MetroTextBox txtDirecion;
    }
}