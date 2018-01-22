namespace CapaVista.Transacciones
{
    partial class AgregarTransaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarTransaccion));
            this.panelDatos = new MetroFramework.Controls.MetroPanel();
            this.lblNoFactura = new MetroFramework.Controls.MetroLabel();
            this.lblFactura = new MetroFramework.Controls.MetroLabel();
            this.lblNombreCajero = new MetroFramework.Controls.MetroLabel();
            this.lblCajero = new MetroFramework.Controls.MetroLabel();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCarrera = new MetroFramework.Controls.MetroLabel();
            this.cboVehiculo = new MetroFramework.Controls.MetroComboBox();
            this.lblConductor = new MetroFramework.Controls.MetroLabel();
            this.lblDatosGeneral = new MetroFramework.Controls.MetroLabel();
            this.mpEgresos = new MetroFramework.Controls.MetroPanel();
            this.btnAnular = new System.Windows.Forms.Button();
            this.txtFac = new System.Windows.Forms.TextBox();
            this.btnCarrera = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnEgreso = new System.Windows.Forms.RadioButton();
            this.rbtnIngreso = new System.Windows.Forms.RadioButton();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.dgvEgresos = new System.Windows.Forms.DataGridView();
            this.CodEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpcionesBasicas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboEgresos = new MetroFramework.Controls.MetroComboBox();
            this.lblAgregar = new MetroFramework.Controls.MetroLabel();
            this.lblEgresos = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblUser = new MetroFramework.Controls.MetroLink();
            this.lblSalir = new MetroFramework.Controls.MetroLink();
            this.lblCambiarContra = new MetroFramework.Controls.MetroLink();
            this.panelDatos.SuspendLayout();
            this.mpEgresos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).BeginInit();
            this.OpcionesBasicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatos
            // 
            this.panelDatos.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panelDatos.Controls.Add(this.lblNoFactura);
            this.panelDatos.Controls.Add(this.lblFactura);
            this.panelDatos.Controls.Add(this.lblNombreCajero);
            this.panelDatos.Controls.Add(this.lblCajero);
            this.panelDatos.Controls.Add(this.dtFecha);
            this.panelDatos.Controls.Add(this.lblFechaCarrera);
            this.panelDatos.Controls.Add(this.cboVehiculo);
            this.panelDatos.Controls.Add(this.lblConductor);
            this.panelDatos.Controls.Add(this.lblDatosGeneral);
            this.panelDatos.HorizontalScrollbarBarColor = true;
            this.panelDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDatos.HorizontalScrollbarSize = 10;
            this.panelDatos.Location = new System.Drawing.Point(23, 63);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(613, 117);
            this.panelDatos.TabIndex = 1;
            this.panelDatos.VerticalScrollbarBarColor = true;
            this.panelDatos.VerticalScrollbarHighlightOnWheel = false;
            this.panelDatos.VerticalScrollbarSize = 10;
            // 
            // lblNoFactura
            // 
            this.lblNoFactura.AutoSize = true;
            this.lblNoFactura.Location = new System.Drawing.Point(246, 10);
            this.lblNoFactura.Name = "lblNoFactura";
            this.lblNoFactura.Size = new System.Drawing.Size(21, 19);
            this.lblNoFactura.TabIndex = 5;
            this.lblNoFactura.Text = "--";
            this.lblNoFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(178, 10);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(58, 19);
            this.lblFactura.TabIndex = 4;
            this.lblFactura.Text = "Factura: ";
            // 
            // lblNombreCajero
            // 
            this.lblNombreCajero.AutoSize = true;
            this.lblNombreCajero.Location = new System.Drawing.Point(414, 10);
            this.lblNombreCajero.Name = "lblNombreCajero";
            this.lblNombreCajero.Size = new System.Drawing.Size(25, 19);
            this.lblNombreCajero.TabIndex = 7;
            this.lblNombreCajero.Text = " --";
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Location = new System.Drawing.Point(361, 10);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(51, 19);
            this.lblCajero.TabIndex = 6;
            this.lblCajero.Text = "Cajero:";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(318, 63);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 1;
            // 
            // lblFechaCarrera
            // 
            this.lblFechaCarrera.AutoSize = true;
            this.lblFechaCarrera.Location = new System.Drawing.Point(321, 36);
            this.lblFechaCarrera.Name = "lblFechaCarrera";
            this.lblFechaCarrera.Size = new System.Drawing.Size(113, 19);
            this.lblFechaCarrera.TabIndex = 8;
            this.lblFechaCarrera.Text = "Fecha Transacción";
            // 
            // cboVehiculo
            // 
            this.cboVehiculo.FormattingEnabled = true;
            this.cboVehiculo.ItemHeight = 23;
            this.cboVehiculo.Location = new System.Drawing.Point(6, 58);
            this.cboVehiculo.Name = "cboVehiculo";
            this.cboVehiculo.Size = new System.Drawing.Size(236, 29);
            this.cboVehiculo.TabIndex = 0;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Location = new System.Drawing.Point(6, 36);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(122, 19);
            this.lblConductor.TabIndex = 3;
            this.lblConductor.Text = "Seleccione Vehiculo";
            // 
            // lblDatosGeneral
            // 
            this.lblDatosGeneral.AutoSize = true;
            this.lblDatosGeneral.Location = new System.Drawing.Point(3, 10);
            this.lblDatosGeneral.Name = "lblDatosGeneral";
            this.lblDatosGeneral.Size = new System.Drawing.Size(103, 19);
            this.lblDatosGeneral.TabIndex = 2;
            this.lblDatosGeneral.Text = "Datos Generales";
            // 
            // mpEgresos
            // 
            this.mpEgresos.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.mpEgresos.Controls.Add(this.btnAnular);
            this.mpEgresos.Controls.Add(this.txtFac);
            this.mpEgresos.Controls.Add(this.btnCarrera);
            this.mpEgresos.Controls.Add(this.btnResumen);
            this.mpEgresos.Controls.Add(this.metroLabel3);
            this.mpEgresos.Controls.Add(this.panel1);
            this.mpEgresos.Controls.Add(this.txtMonto);
            this.mpEgresos.Controls.Add(this.dgvEgresos);
            this.mpEgresos.Controls.Add(this.metroLabel2);
            this.mpEgresos.Controls.Add(this.metroLabel1);
            this.mpEgresos.Controls.Add(this.txtDescripcion);
            this.mpEgresos.Controls.Add(this.btnAgregar);
            this.mpEgresos.Controls.Add(this.cboEgresos);
            this.mpEgresos.Controls.Add(this.lblAgregar);
            this.mpEgresos.Controls.Add(this.lblEgresos);
            this.mpEgresos.HorizontalScrollbarBarColor = true;
            this.mpEgresos.HorizontalScrollbarHighlightOnWheel = false;
            this.mpEgresos.HorizontalScrollbarSize = 10;
            this.mpEgresos.Location = new System.Drawing.Point(23, 195);
            this.mpEgresos.Name = "mpEgresos";
            this.mpEgresos.Size = new System.Drawing.Size(616, 446);
            this.mpEgresos.TabIndex = 1;
            this.mpEgresos.VerticalScrollbarBarColor = true;
            this.mpEgresos.VerticalScrollbarHighlightOnWheel = false;
            this.mpEgresos.VerticalScrollbarSize = 10;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(485, 14);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(110, 33);
            this.btnAnular.TabIndex = 12;
            this.btnAnular.Text = "Buscar Factura";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // txtFac
            // 
            this.txtFac.Location = new System.Drawing.Point(361, 21);
            this.txtFac.Name = "txtFac";
            this.txtFac.Size = new System.Drawing.Size(118, 20);
            this.txtFac.TabIndex = 11;
            // 
            // btnCarrera
            // 
            this.btnCarrera.Location = new System.Drawing.Point(361, 65);
            this.btnCarrera.Name = "btnCarrera";
            this.btnCarrera.Size = new System.Drawing.Size(118, 33);
            this.btnCarrera.TabIndex = 9;
            this.btnCarrera.Text = "Registrar Viaje";
            this.btnCarrera.UseVisualStyleBackColor = true;
            this.btnCarrera.Click += new System.EventHandler(this.btnCarrera_Click);
            // 
            // btnResumen
            // 
            this.btnResumen.Location = new System.Drawing.Point(485, 65);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(110, 33);
            this.btnResumen.TabIndex = 10;
            this.btnResumen.Text = "Resumen del Dia";
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 14);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(119, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Detalle Transacción";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnEgreso);
            this.panel1.Controls.Add(this.rbtnIngreso);
            this.panel1.Location = new System.Drawing.Point(120, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 68);
            this.panel1.TabIndex = 0;
            // 
            // rbtnEgreso
            // 
            this.rbtnEgreso.AutoSize = true;
            this.rbtnEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEgreso.Location = new System.Drawing.Point(3, 36);
            this.rbtnEgreso.Name = "rbtnEgreso";
            this.rbtnEgreso.Size = new System.Drawing.Size(89, 28);
            this.rbtnEgreso.TabIndex = 1;
            this.rbtnEgreso.Text = "Egreso";
            this.rbtnEgreso.UseVisualStyleBackColor = true;
            // 
            // rbtnIngreso
            // 
            this.rbtnIngreso.AutoSize = true;
            this.rbtnIngreso.Checked = true;
            this.rbtnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIngreso.Location = new System.Drawing.Point(3, 6);
            this.rbtnIngreso.Name = "rbtnIngreso";
            this.rbtnIngreso.Size = new System.Drawing.Size(91, 28);
            this.rbtnIngreso.TabIndex = 0;
            this.rbtnIngreso.TabStop = true;
            this.rbtnIngreso.Text = "Ingreso";
            this.rbtnIngreso.UseVisualStyleBackColor = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(394, 129);
            this.txtMonto.Mask = "$ 999999.99";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.RejectInputOnFirstFailure = true;
            this.txtMonto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 3;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvEgresos
            // 
            this.dgvEgresos.AllowUserToAddRows = false;
            this.dgvEgresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEgresos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEgresos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodEgreso,
            this.Egreso,
            this.descripcion,
            this.TipoTransaccion,
            this.monto});
            this.dgvEgresos.ContextMenuStrip = this.OpcionesBasicas;
            this.dgvEgresos.Location = new System.Drawing.Point(6, 163);
            this.dgvEgresos.Name = "dgvEgresos";
            this.dgvEgresos.RowHeadersVisible = false;
            this.dgvEgresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEgresos.Size = new System.Drawing.Size(607, 280);
            this.dgvEgresos.TabIndex = 5;
            // 
            // CodEgreso
            // 
            this.CodEgreso.HeaderText = "Codigo";
            this.CodEgreso.Name = "CodEgreso";
            // 
            // Egreso
            // 
            this.Egreso.HeaderText = "Tipo Detalle";
            this.Egreso.Name = "Egreso";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // TipoTransaccion
            // 
            this.TipoTransaccion.HeaderText = "Tipo Transacción";
            this.TipoTransaccion.Name = "TipoTransaccion";
            this.TipoTransaccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto Total";
            this.monto.Name = "monto";
            // 
            // OpcionesBasicas
            // 
            this.OpcionesBasicas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarRegistroToolStripMenuItem,
            this.cambiarTipoToolStripMenuItem});
            this.OpcionesBasicas.Name = "OpcionesBasicas";
            this.OpcionesBasicas.Size = new System.Drawing.Size(161, 48);
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            this.eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            this.eliminarRegistroToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.eliminarRegistroToolStripMenuItem.Text = "&Eliminar registro";
            this.eliminarRegistroToolStripMenuItem.Click += new System.EventHandler(this.eliminarRegistroToolStripMenuItem_Click);
            // 
            // cambiarTipoToolStripMenuItem
            // 
            this.cambiarTipoToolStripMenuItem.Name = "cambiarTipoToolStripMenuItem";
            this.cambiarTipoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cambiarTipoToolStripMenuItem.Text = "Cambiar Tipo";
            this.cambiarTipoToolStripMenuItem.Click += new System.EventHandler(this.cambiarTipoToolStripMenuItem_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(397, 101);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Monto C$";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(192, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(192, 129);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(196, 23);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Text = " SIN DEFINIR";
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(508, 125);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(58, 29);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboEgresos
            // 
            this.cboEgresos.FormattingEnabled = true;
            this.cboEgresos.ItemHeight = 23;
            this.cboEgresos.Location = new System.Drawing.Point(6, 123);
            this.cboEgresos.Name = "cboEgresos";
            this.cboEgresos.Size = new System.Drawing.Size(182, 29);
            this.cboEgresos.TabIndex = 1;
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(6, 101);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(98, 19);
            this.lblAgregar.TabIndex = 8;
            this.lblAgregar.Text = "Tipo de Detalle";
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Location = new System.Drawing.Point(6, 50);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(108, 19);
            this.lblEgresos.TabIndex = 7;
            this.lblEgresos.Text = "Tipo Transacción:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(519, 647);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 58);
            this.btnCancelar.TabIndex = 4;
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
            this.btnGuardar.Location = new System.Drawing.Point(421, 647);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 58);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(397, 24);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(150, 23);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username";
            this.lblUser.UseStyleColors = true;
            // 
            // lblSalir
            // 
            this.lblSalir.Location = new System.Drawing.Point(558, 24);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(75, 23);
            this.lblSalir.Style = MetroFramework.MetroColorStyle.Red;
            this.lblSalir.TabIndex = 5;
            this.lblSalir.Text = "Salir";
            this.lblSalir.UseStyleColors = true;
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // lblCambiarContra
            // 
            this.lblCambiarContra.Location = new System.Drawing.Point(252, 24);
            this.lblCambiarContra.Name = "lblCambiarContra";
            this.lblCambiarContra.Size = new System.Drawing.Size(150, 23);
            this.lblCambiarContra.TabIndex = 6;
            this.lblCambiarContra.Text = "Cambiar Contraseña";
            this.lblCambiarContra.UseStyleColors = true;
            this.lblCambiarContra.Click += new System.EventHandler(this.lblCambiarContra_Click);
            // 
            // AgregarTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 724);
            this.Controls.Add(this.lblCambiarContra);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.mpEgresos);
            this.Controls.Add(this.panelDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarTransaccion";
            this.Resizable = false;
            this.Text = "Agregar Transaccion";
            this.Load += new System.EventHandler(this.AgregarTransaccion_Load);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.mpEgresos.ResumeLayout(false);
            this.mpEgresos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).EndInit();
            this.OpcionesBasicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelDatos;
        private MetroFramework.Controls.MetroLabel lblNoFactura;
        private MetroFramework.Controls.MetroLabel lblFactura;
        private MetroFramework.Controls.MetroLabel lblNombreCajero;
        private MetroFramework.Controls.MetroLabel lblCajero;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private MetroFramework.Controls.MetroLabel lblFechaCarrera;
        private MetroFramework.Controls.MetroLabel lblConductor;
        private MetroFramework.Controls.MetroLabel lblDatosGeneral;
        private MetroFramework.Controls.MetroPanel mpEgresos;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.DataGridView dgvEgresos;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private MetroFramework.Controls.MetroComboBox cboEgresos;
        private MetroFramework.Controls.MetroLabel lblAgregar;
        private MetroFramework.Controls.MetroLabel lblEgresos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnEgreso;
        private System.Windows.Forms.RadioButton rbtnIngreso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public MetroFramework.Controls.MetroComboBox cboVehiculo;
        private System.Windows.Forms.ContextMenuStrip OpcionesBasicas;
        private System.Windows.Forms.ToolStripMenuItem eliminarRegistroToolStripMenuItem;
        private System.Windows.Forms.Button btnResumen;
        private MetroFramework.Controls.MetroLink lblUser;
        private MetroFramework.Controls.MetroLink lblSalir;
        private System.Windows.Forms.Button btnCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.ToolStripMenuItem cambiarTipoToolStripMenuItem;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.TextBox txtFac;
        private MetroFramework.Controls.MetroLink lblCambiarContra;
    }
}