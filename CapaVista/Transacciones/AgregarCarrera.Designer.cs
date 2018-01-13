namespace CapaVista
{
    partial class Carrera
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
            this.panelDatos = new MetroFramework.Controls.MetroPanel();
            this.lblNoFactura = new MetroFramework.Controls.MetroLabel();
            this.lblFactura = new MetroFramework.Controls.MetroLabel();
            this.lblNombreCajero = new MetroFramework.Controls.MetroLabel();
            this.lblCajero = new MetroFramework.Controls.MetroLabel();
            this.txtIngreso = new System.Windows.Forms.MaskedTextBox();
            this.lblIngresos = new MetroFramework.Controls.MetroLabel();
            this.cbVueltaCompleta = new MetroFramework.Controls.MetroCheckBox();
            this.cboVehiculo = new MetroFramework.Controls.MetroComboBox();
            this.lblVehiculo = new MetroFramework.Controls.MetroLabel();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCarrera = new MetroFramework.Controls.MetroLabel();
            this.dtLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtSalida = new System.Windows.Forms.DateTimePicker();
            this.lblLlegada = new MetroFramework.Controls.MetroLabel();
            this.lblSalida = new MetroFramework.Controls.MetroLabel();
            this.cboConductor = new MetroFramework.Controls.MetroComboBox();
            this.lblConductor = new MetroFramework.Controls.MetroLabel();
            this.lblDatosGeneral = new MetroFramework.Controls.MetroLabel();
            this.mpEgresos = new MetroFramework.Controls.MetroPanel();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.dgvEgresos = new System.Windows.Forms.DataGridView();
            this.CodEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.separador = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboEgresos = new MetroFramework.Controls.MetroComboBox();
            this.lblAgregar = new MetroFramework.Controls.MetroLabel();
            this.lblEgresos = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelDatos.SuspendLayout();
            this.mpEgresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).BeginInit();
            this.MenuGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.lblNoFactura);
            this.panelDatos.Controls.Add(this.lblFactura);
            this.panelDatos.Controls.Add(this.lblNombreCajero);
            this.panelDatos.Controls.Add(this.lblCajero);
            this.panelDatos.Controls.Add(this.txtIngreso);
            this.panelDatos.Controls.Add(this.lblIngresos);
            this.panelDatos.Controls.Add(this.cbVueltaCompleta);
            this.panelDatos.Controls.Add(this.cboVehiculo);
            this.panelDatos.Controls.Add(this.lblVehiculo);
            this.panelDatos.Controls.Add(this.dtFecha);
            this.panelDatos.Controls.Add(this.lblFechaCarrera);
            this.panelDatos.Controls.Add(this.dtLlegada);
            this.panelDatos.Controls.Add(this.dtSalida);
            this.panelDatos.Controls.Add(this.lblLlegada);
            this.panelDatos.Controls.Add(this.lblSalida);
            this.panelDatos.Controls.Add(this.cboConductor);
            this.panelDatos.Controls.Add(this.lblConductor);
            this.panelDatos.Controls.Add(this.lblDatosGeneral);
            this.panelDatos.HorizontalScrollbarBarColor = true;
            this.panelDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDatos.HorizontalScrollbarSize = 10;
            this.panelDatos.Location = new System.Drawing.Point(23, 75);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(571, 206);
            this.panelDatos.TabIndex = 0;
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
            this.lblNoFactura.TabIndex = 17;
            this.lblNoFactura.Text = "--";
            this.lblNoFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(157, 10);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(83, 19);
            this.lblFactura.TabIndex = 16;
            this.lblFactura.Text = "Carrera No: ";
            // 
            // lblNombreCajero
            // 
            this.lblNombreCajero.AutoSize = true;
            this.lblNombreCajero.Location = new System.Drawing.Point(414, 10);
            this.lblNombreCajero.Name = "lblNombreCajero";
            this.lblNombreCajero.Size = new System.Drawing.Size(25, 19);
            this.lblNombreCajero.TabIndex = 15;
            this.lblNombreCajero.Text = " --";
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Location = new System.Drawing.Point(361, 10);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(51, 19);
            this.lblCajero.TabIndex = 14;
            this.lblCajero.Text = "Cajero:";
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(355, 174);
            this.txtIngreso.Mask = "$ 99999.99";
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(189, 20);
            this.txtIngreso.TabIndex = 6;
            this.txtIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(257, 175);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(85, 19);
            this.lblIngresos.TabIndex = 12;
            this.lblIngresos.Text = "Ingreso Total";
            // 
            // cbVueltaCompleta
            // 
            this.cbVueltaCompleta.AutoSize = true;
            this.cbVueltaCompleta.Checked = true;
            this.cbVueltaCompleta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVueltaCompleta.Location = new System.Drawing.Point(62, 174);
            this.cbVueltaCompleta.Name = "cbVueltaCompleta";
            this.cbVueltaCompleta.Size = new System.Drawing.Size(116, 15);
            this.cbVueltaCompleta.TabIndex = 2;
            this.cbVueltaCompleta.Text = "Vuelta Completa?";
            this.cbVueltaCompleta.UseVisualStyleBackColor = true;
            // 
            // cboVehiculo
            // 
            this.cboVehiculo.FormattingEnabled = true;
            this.cboVehiculo.ItemHeight = 23;
            this.cboVehiculo.Location = new System.Drawing.Point(6, 117);
            this.cboVehiculo.Name = "cboVehiculo";
            this.cboVehiculo.Size = new System.Drawing.Size(236, 29);
            this.cboVehiculo.TabIndex = 1;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(6, 95);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(123, 19);
            this.lblVehiculo.TabIndex = 11;
            this.lblVehiculo.Text = "Seleccione Vehiculo";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(318, 63);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 3;
            // 
            // lblFechaCarrera
            // 
            this.lblFechaCarrera.AutoSize = true;
            this.lblFechaCarrera.Location = new System.Drawing.Point(321, 36);
            this.lblFechaCarrera.Name = "lblFechaCarrera";
            this.lblFechaCarrera.Size = new System.Drawing.Size(92, 19);
            this.lblFechaCarrera.TabIndex = 9;
            this.lblFechaCarrera.Text = "Fecha Carrera";
            // 
            // dtLlegada
            // 
            this.dtLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtLlegada.Location = new System.Drawing.Point(422, 126);
            this.dtLlegada.Name = "dtLlegada";
            this.dtLlegada.Size = new System.Drawing.Size(122, 20);
            this.dtLlegada.TabIndex = 5;
            // 
            // dtSalida
            // 
            this.dtSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtSalida.Location = new System.Drawing.Point(291, 126);
            this.dtSalida.Name = "dtSalida";
            this.dtSalida.Size = new System.Drawing.Size(125, 20);
            this.dtSalida.TabIndex = 4;
            // 
            // lblLlegada
            // 
            this.lblLlegada.AutoSize = true;
            this.lblLlegada.Location = new System.Drawing.Point(439, 95);
            this.lblLlegada.Name = "lblLlegada";
            this.lblLlegada.Size = new System.Drawing.Size(88, 19);
            this.lblLlegada.TabIndex = 6;
            this.lblLlegada.Text = "Hora Llegada";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(299, 95);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(77, 19);
            this.lblSalida.TabIndex = 3;
            this.lblSalida.Text = "Hora Salida";
            // 
            // cboConductor
            // 
            this.cboConductor.FormattingEnabled = true;
            this.cboConductor.ItemHeight = 23;
            this.cboConductor.Location = new System.Drawing.Point(6, 58);
            this.cboConductor.Name = "cboConductor";
            this.cboConductor.Size = new System.Drawing.Size(236, 29);
            this.cboConductor.TabIndex = 0;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Location = new System.Drawing.Point(6, 36);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(136, 19);
            this.lblConductor.TabIndex = 3;
            this.lblConductor.Text = "Seleccione Conductor";
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
            this.mpEgresos.Location = new System.Drawing.Point(23, 291);
            this.mpEgresos.Name = "mpEgresos";
            this.mpEgresos.Size = new System.Drawing.Size(571, 210);
            this.mpEgresos.TabIndex = 1;
            this.mpEgresos.VerticalScrollbarBarColor = true;
            this.mpEgresos.VerticalScrollbarHighlightOnWheel = false;
            this.mpEgresos.VerticalScrollbarSize = 10;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(394, 69);
            this.txtMonto.Mask = "$ 999999.99";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.RejectInputOnFirstFailure = true;
            this.txtMonto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 2;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvEgresos
            // 
            this.dgvEgresos.AllowUserToAddRows = false;
            this.dgvEgresos.AllowUserToDeleteRows = false;
            this.dgvEgresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEgresos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEgresos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodEgreso,
            this.Egreso,
            this.descripcion,
            this.monto});
            this.dgvEgresos.ContextMenuStrip = this.MenuGrid;
            this.dgvEgresos.Location = new System.Drawing.Point(6, 102);
            this.dgvEgresos.Name = "dgvEgresos";
            this.dgvEgresos.ReadOnly = true;
            this.dgvEgresos.RowHeadersVisible = false;
            this.dgvEgresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEgresos.Size = new System.Drawing.Size(560, 96);
            this.dgvEgresos.TabIndex = 4;
            // 
            // CodEgreso
            // 
            this.CodEgreso.HeaderText = "Codigo";
            this.CodEgreso.Name = "CodEgreso";
            this.CodEgreso.ReadOnly = true;
            // 
            // Egreso
            // 
            this.Egreso.HeaderText = "Tipo Egreso";
            this.Egreso.Name = "Egreso";
            this.Egreso.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto Total";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // MenuGrid
            // 
            this.MenuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.separador,
            this.btnEditar,
            this.btnEliminar});
            this.MenuGrid.Name = "MenuGrid";
            this.MenuGrid.Size = new System.Drawing.Size(171, 54);
            this.MenuGrid.Text = "Operaciones con registros";
            // 
            // separador
            // 
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(167, 6);
            // 
            // btnEditar
            // 
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(170, 22);
            this.btnEditar.Text = "Editar Seleccion";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(170, 22);
            this.btnEliminar.Text = "Eliminar Seleccion";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(397, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Monto C$";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(192, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(192, 69);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(196, 23);
            this.txtDescripcion.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(508, 65);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(58, 29);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboEgresos
            // 
            this.cboEgresos.FormattingEnabled = true;
            this.cboEgresos.ItemHeight = 23;
            this.cboEgresos.Location = new System.Drawing.Point(6, 63);
            this.cboEgresos.Name = "cboEgresos";
            this.cboEgresos.Size = new System.Drawing.Size(182, 29);
            this.cboEgresos.TabIndex = 0;
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(6, 41);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(97, 19);
            this.lblAgregar.TabIndex = 3;
            this.lblAgregar.Text = "Añadir Egresos";
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Location = new System.Drawing.Point(6, 11);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(91, 19);
            this.lblEgresos.TabIndex = 2;
            this.lblEgresos.Text = "Datos Egresos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::CapaVista.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(421, 507);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 56);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(502, 507);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 56);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 569);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.mpEgresos);
            this.Controls.Add(this.panelDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Carrera";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Nueva Carrera";
            this.Load += new System.EventHandler(this.Carrera_Load);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.mpEgresos.ResumeLayout(false);
            this.mpEgresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).EndInit();
            this.MenuGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelDatos;
        private MetroFramework.Controls.MetroLabel lblDatosGeneral;
        private MetroFramework.Controls.MetroComboBox cboConductor;
        private MetroFramework.Controls.MetroLabel lblConductor;
        private MetroFramework.Controls.MetroLabel lblLlegada;
        private MetroFramework.Controls.MetroLabel lblSalida;
        private System.Windows.Forms.DateTimePicker dtLlegada;
        private System.Windows.Forms.DateTimePicker dtSalida;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private MetroFramework.Controls.MetroLabel lblFechaCarrera;
        private MetroFramework.Controls.MetroLabel lblVehiculo;
        private MetroFramework.Controls.MetroCheckBox cbVueltaCompleta;
        private MetroFramework.Controls.MetroLabel lblIngresos;
        private MetroFramework.Controls.MetroPanel mpEgresos;
        private MetroFramework.Controls.MetroLabel lblEgresos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private MetroFramework.Controls.MetroComboBox cboEgresos;
        private MetroFramework.Controls.MetroLabel lblAgregar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dgvEgresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ContextMenuStrip MenuGrid;
        private System.Windows.Forms.ToolStripSeparator separador;
        private System.Windows.Forms.ToolStripMenuItem btnEditar;
        private System.Windows.Forms.ToolStripMenuItem btnEliminar;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.MaskedTextBox txtIngreso;
        private MetroFramework.Controls.MetroLabel lblNombreCajero;
        private MetroFramework.Controls.MetroLabel lblCajero;
        private MetroFramework.Controls.MetroLabel lblFactura;
        private MetroFramework.Controls.MetroLabel lblNoFactura;
        public MetroFramework.Controls.MetroComboBox cboVehiculo;
    }
}