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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarTransaccion));
            this.panelDatos = new MetroFramework.Controls.MetroPanel();
            this.btnAnular = new System.Windows.Forms.Button();
            this.txtFac = new System.Windows.Forms.TextBox();
            this.lblNoFactura = new MetroFramework.Controls.MetroLabel();
            this.lblFactura = new MetroFramework.Controls.MetroLabel();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cboVehiculo = new MetroFramework.Controls.MetroComboBox();
            this.lblConductor = new MetroFramework.Controls.MetroLabel();
            this.lblDatosGeneral = new MetroFramework.Controls.MetroLabel();
            this.mpEgresos = new MetroFramework.Controls.MetroPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCarrera = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbCredito = new System.Windows.Forms.RadioButton();
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboEgresos = new MetroFramework.Controls.MetroComboBox();
            this.lblAgregar = new MetroFramework.Controls.MetroLabel();
            this.lblEgresos = new MetroFramework.Controls.MetroLabel();
            this.lblUser = new MetroFramework.Controls.MetroLink();
            this.lblSalir = new MetroFramework.Controls.MetroLink();
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
            this.panelDatos.Controls.Add(this.btnAnular);
            this.panelDatos.Controls.Add(this.txtFac);
            this.panelDatos.Controls.Add(this.lblNoFactura);
            this.panelDatos.Controls.Add(this.lblFactura);
            this.panelDatos.Controls.Add(this.dtFecha);
            this.panelDatos.Controls.Add(this.cboVehiculo);
            this.panelDatos.Controls.Add(this.lblConductor);
            this.panelDatos.Controls.Add(this.lblDatosGeneral);
            this.panelDatos.HorizontalScrollbarBarColor = true;
            this.panelDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDatos.HorizontalScrollbarSize = 10;
            this.panelDatos.Location = new System.Drawing.Point(23, 63);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(707, 117);
            this.panelDatos.TabIndex = 1;
            this.panelDatos.VerticalScrollbarBarColor = true;
            this.panelDatos.VerticalScrollbarHighlightOnWheel = false;
            this.panelDatos.VerticalScrollbarSize = 10;
            // 
            // btnAnular
            // 
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Image = global::CapaVista.Properties.Resources.search_1_;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.Location = new System.Drawing.Point(535, 59);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(140, 39);
            this.btnAnular.TabIndex = 12;
            this.btnAnular.Text = "Buscar Factura";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // txtFac
            // 
            this.txtFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFac.Location = new System.Drawing.Point(382, 69);
            this.txtFac.Name = "txtFac";
            this.txtFac.Size = new System.Drawing.Size(147, 22);
            this.txtFac.TabIndex = 11;
            this.txtFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNoFactura
            // 
            this.lblNoFactura.AutoSize = true;
            this.lblNoFactura.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNoFactura.Location = new System.Drawing.Point(229, 6);
            this.lblNoFactura.Name = "lblNoFactura";
            this.lblNoFactura.Size = new System.Drawing.Size(110, 25);
            this.lblNoFactura.TabIndex = 5;
            this.lblNoFactura.Text = "--------------";
            this.lblNoFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFactura.Location = new System.Drawing.Point(166, 5);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(75, 25);
            this.lblFactura.TabIndex = 4;
            this.lblFactura.Text = "Factura: ";
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Location = new System.Drawing.Point(487, 10);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 1;
            // 
            // cboVehiculo
            // 
            this.cboVehiculo.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.cboVehiculo.FormattingEnabled = true;
            this.cboVehiculo.ItemHeight = 29;
            this.cboVehiculo.Location = new System.Drawing.Point(9, 69);
            this.cboVehiculo.Name = "cboVehiculo";
            this.cboVehiculo.Size = new System.Drawing.Size(236, 35);
            this.cboVehiculo.TabIndex = 0;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblConductor.Location = new System.Drawing.Point(9, 43);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(161, 25);
            this.lblConductor.TabIndex = 3;
            this.lblConductor.Text = "Seleccione Vehiculo";
            // 
            // lblDatosGeneral
            // 
            this.lblDatosGeneral.AutoSize = true;
            this.lblDatosGeneral.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDatosGeneral.Location = new System.Drawing.Point(3, 5);
            this.lblDatosGeneral.Name = "lblDatosGeneral";
            this.lblDatosGeneral.Size = new System.Drawing.Size(135, 25);
            this.lblDatosGeneral.TabIndex = 2;
            this.lblDatosGeneral.Text = "Datos Generales";
            // 
            // mpEgresos
            // 
            this.mpEgresos.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.mpEgresos.Controls.Add(this.btnGuardar);
            this.mpEgresos.Controls.Add(this.btnCarrera);
            this.mpEgresos.Controls.Add(this.btnResumen);
            this.mpEgresos.Controls.Add(this.panel1);
            this.mpEgresos.Controls.Add(this.txtMonto);
            this.mpEgresos.Controls.Add(this.dgvEgresos);
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
            this.mpEgresos.Size = new System.Drawing.Size(707, 497);
            this.mpEgresos.TabIndex = 1;
            this.mpEgresos.VerticalScrollbarBarColor = true;
            this.mpEgresos.VerticalScrollbarHighlightOnWheel = false;
            this.mpEgresos.VerticalScrollbarSize = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Image = global::CapaVista.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(606, 123);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 58);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCarrera
            // 
            this.btnCarrera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCarrera.FlatAppearance.BorderSize = 0;
            this.btnCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrera.Image = global::CapaVista.Properties.Resources.road1;
            this.btnCarrera.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarrera.Location = new System.Drawing.Point(377, 31);
            this.btnCarrera.Name = "btnCarrera";
            this.btnCarrera.Size = new System.Drawing.Size(147, 33);
            this.btnCarrera.TabIndex = 9;
            this.btnCarrera.Text = "Registrar Viaje";
            this.btnCarrera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrera.UseVisualStyleBackColor = true;
            this.btnCarrera.Click += new System.EventHandler(this.btnCarrera_Click);
            // 
            // btnResumen
            // 
            this.btnResumen.FlatAppearance.BorderSize = 0;
            this.btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumen.Image = global::CapaVista.Properties.Resources.list;
            this.btnResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResumen.Location = new System.Drawing.Point(545, 30);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(130, 33);
            this.btnResumen.TabIndex = 10;
            this.btnResumen.Text = "Resumen";
            this.btnResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbCredito);
            this.panel1.Controls.Add(this.rbtnEgreso);
            this.panel1.Controls.Add(this.rbtnIngreso);
            this.panel1.Location = new System.Drawing.Point(6, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 42);
            this.panel1.TabIndex = 0;
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCredito.Location = new System.Drawing.Point(195, 6);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(88, 28);
            this.rbCredito.TabIndex = 2;
            this.rbCredito.Text = "Credito";
            this.rbCredito.UseVisualStyleBackColor = true;
            // 
            // rbtnEgreso
            // 
            this.rbtnEgreso.AutoSize = true;
            this.rbtnEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEgreso.Location = new System.Drawing.Point(100, 6);
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
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(394, 137);
            this.txtMonto.Mask = "$ 999999.99";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.RejectInputOnFirstFailure = true;
            this.txtMonto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMonto.Size = new System.Drawing.Size(121, 27);
            this.txtMonto.TabIndex = 3;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvEgresos
            // 
            this.dgvEgresos.AllowUserToAddRows = false;
            this.dgvEgresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEgresos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEgresos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEgresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodEgreso,
            this.Egreso,
            this.descripcion,
            this.TipoTransaccion,
            this.monto});
            this.dgvEgresos.ContextMenuStrip = this.OpcionesBasicas;
            this.dgvEgresos.Location = new System.Drawing.Point(6, 205);
            this.dgvEgresos.Name = "dgvEgresos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEgresos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEgresos.RowHeadersVisible = false;
            this.dgvEgresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEgresos.Size = new System.Drawing.Size(681, 280);
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(192, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDescripcion.Location = new System.Drawing.Point(192, 133);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(196, 35);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Text = " SIN DEFINIR";
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::CapaVista.Properties.Resources.plus;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(521, 123);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 58);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboEgresos
            // 
            this.cboEgresos.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.cboEgresos.FormattingEnabled = true;
            this.cboEgresos.ItemHeight = 29;
            this.cboEgresos.Location = new System.Drawing.Point(6, 133);
            this.cboEgresos.Name = "cboEgresos";
            this.cboEgresos.Size = new System.Drawing.Size(182, 35);
            this.cboEgresos.TabIndex = 1;
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAgregar.Location = new System.Drawing.Point(6, 101);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(126, 25);
            this.lblAgregar.TabIndex = 8;
            this.lblAgregar.Text = "Tipo de Detalle";
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEgresos.Location = new System.Drawing.Point(74, 2);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(142, 25);
            this.lblEgresos.TabIndex = 7;
            this.lblEgresos.Text = "Tipo Transacción:";
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(397, 24);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(150, 23);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username";
            this.lblUser.UseStyleColors = true;
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
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
            // AgregarTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 706);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.lblUser);
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
        private System.Windows.Forms.DateTimePicker dtFecha;
        private MetroFramework.Controls.MetroLabel lblConductor;
        private MetroFramework.Controls.MetroLabel lblDatosGeneral;
        private MetroFramework.Controls.MetroPanel mpEgresos;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.DataGridView dgvEgresos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private MetroFramework.Controls.MetroComboBox cboEgresos;
        private MetroFramework.Controls.MetroLabel lblAgregar;
        private MetroFramework.Controls.MetroLabel lblEgresos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnEgreso;
        private System.Windows.Forms.RadioButton rbtnIngreso;
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
        private System.Windows.Forms.RadioButton rbCredito;
    }
}