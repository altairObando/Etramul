namespace CapaVista.Creditos
{
    partial class AgregarAbono
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAbono));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDatos = new MetroFramework.Controls.MetroPanel();
            this.cboVehiculo = new MetroFramework.Controls.MetroComboBox();
            this.lblConductor = new MetroFramework.Controls.MetroLabel();
            this.dgvCreditos = new System.Windows.Forms.DataGridView();
            this.cmsAbono = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.registrarAbonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblFactura = new MetroFramework.Controls.MetroLabel();
            this.panelOpciones = new MetroFramework.Controls.MetroPanel();
            this.lblAbonando = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cREDITOSPENDIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditosDataset = new CapaVista.Creditos.CreditosDataset();
            this.cREDITOS_PENDIENTESTableAdapter = new CapaVista.Creditos.CreditosDatasetTableAdapters.CREDITOS_PENDIENTESTableAdapter();
            this.facturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaTransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).BeginInit();
            this.cmsAbono.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITOSPENDIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditosDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDatos
            // 
            this.panelDatos.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panelDatos.Controls.Add(this.cboVehiculo);
            this.panelDatos.Controls.Add(this.lblConductor);
            this.panelDatos.HorizontalScrollbarBarColor = true;
            this.panelDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDatos.HorizontalScrollbarSize = 10;
            this.panelDatos.Location = new System.Drawing.Point(23, 72);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(209, 95);
            this.panelDatos.TabIndex = 0;
            this.panelDatos.VerticalScrollbarBarColor = true;
            this.panelDatos.VerticalScrollbarHighlightOnWheel = false;
            this.panelDatos.VerticalScrollbarSize = 10;
            // 
            // cboVehiculo
            // 
            this.cboVehiculo.FormattingEnabled = true;
            this.cboVehiculo.ItemHeight = 23;
            this.cboVehiculo.Location = new System.Drawing.Point(15, 31);
            this.cboVehiculo.Name = "cboVehiculo";
            this.cboVehiculo.Size = new System.Drawing.Size(180, 29);
            this.cboVehiculo.TabIndex = 1;
            this.cboVehiculo.SelectedIndexChanged += new System.EventHandler(this.cboVehiculo_SelectedIndexChanged);
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblConductor.Location = new System.Drawing.Point(3, 3);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(161, 25);
            this.lblConductor.TabIndex = 0;
            this.lblConductor.Text = "Seleccione Vehiculo";
            // 
            // dgvCreditos
            // 
            this.dgvCreditos.AllowUserToAddRows = false;
            this.dgvCreditos.AllowUserToDeleteRows = false;
            this.dgvCreditos.AutoGenerateColumns = false;
            this.dgvCreditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreditos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCreditos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreditos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facturaDataGridViewTextBoxColumn,
            this.Detalle,
            this.fechaTransaccionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgvCreditos.ContextMenuStrip = this.cmsAbono;
            this.dgvCreditos.DataSource = this.cREDITOSPENDIENTESBindingSource;
            this.dgvCreditos.Location = new System.Drawing.Point(23, 173);
            this.dgvCreditos.Name = "dgvCreditos";
            this.dgvCreditos.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCreditos.RowHeadersVisible = false;
            this.dgvCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditos.Size = new System.Drawing.Size(681, 240);
            this.dgvCreditos.TabIndex = 2;
            // 
            // cmsAbono
            // 
            this.cmsAbono.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAbonoToolStripMenuItem});
            this.cmsAbono.Name = "cmsAbono";
            this.cmsAbono.Size = new System.Drawing.Size(160, 26);
            this.cmsAbono.Opening += new System.ComponentModel.CancelEventHandler(this.cmsAbono_Opening);
            this.cmsAbono.Click += new System.EventHandler(this.cmsAbono_Click);
            // 
            // registrarAbonoToolStripMenuItem
            // 
            this.registrarAbonoToolStripMenuItem.Name = "registrarAbonoToolStripMenuItem";
            this.registrarAbonoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.registrarAbonoToolStripMenuItem.Text = "Registrar Abono";
            this.registrarAbonoToolStripMenuItem.Click += new System.EventHandler(this.registrarAbonoToolStripMenuItem_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(267, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Factura: ";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFactura.Location = new System.Drawing.Point(335, 25);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(39, 25);
            this.lblFactura.TabIndex = 4;
            this.lblFactura.Text = " ##";
            // 
            // panelOpciones
            // 
            this.panelOpciones.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panelOpciones.Controls.Add(this.txtMonto);
            this.panelOpciones.Controls.Add(this.btnCerrar);
            this.panelOpciones.Controls.Add(this.btnCancelar);
            this.panelOpciones.Controls.Add(this.btnGuardar);
            this.panelOpciones.Controls.Add(this.lblAbonando);
            this.panelOpciones.HorizontalScrollbarBarColor = true;
            this.panelOpciones.HorizontalScrollbarHighlightOnWheel = false;
            this.panelOpciones.HorizontalScrollbarSize = 10;
            this.panelOpciones.Location = new System.Drawing.Point(238, 72);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(466, 95);
            this.panelOpciones.TabIndex = 1;
            this.panelOpciones.VerticalScrollbarBarColor = true;
            this.panelOpciones.VerticalScrollbarHighlightOnWheel = false;
            this.panelOpciones.VerticalScrollbarSize = 10;
            // 
            // lblAbonando
            // 
            this.lblAbonando.AutoSize = true;
            this.lblAbonando.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAbonando.Location = new System.Drawing.Point(15, 3);
            this.lblAbonando.Name = "lblAbonando";
            this.lblAbonando.Size = new System.Drawing.Size(146, 25);
            this.lblAbonando.TabIndex = 0;
            this.lblAbonando.Text = "Monto del Abono";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::CapaVista.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(234, 18);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 56);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(315, 18);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 56);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::CapaVista.Properties.Resources.door;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(387, 18);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 56);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cREDITOSPENDIENTESBindingSource
            // 
            this.cREDITOSPENDIENTESBindingSource.DataMember = "CREDITOS_PENDIENTES";
            this.cREDITOSPENDIENTESBindingSource.DataSource = this.creditosDataset;
            // 
            // creditosDataset
            // 
            this.creditosDataset.DataSetName = "CreditosDataset";
            this.creditosDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cREDITOS_PENDIENTESTableAdapter
            // 
            this.cREDITOS_PENDIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // facturaDataGridViewTextBoxColumn
            // 
            this.facturaDataGridViewTextBoxColumn.DataPropertyName = "Factura";
            this.facturaDataGridViewTextBoxColumn.HeaderText = "Factura";
            this.facturaDataGridViewTextBoxColumn.Name = "facturaDataGridViewTextBoxColumn";
            this.facturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Detalle
            // 
            this.Detalle.DataPropertyName = "Detalle";
            this.Detalle.HeaderText = "Codigo";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // fechaTransaccionDataGridViewTextBoxColumn
            // 
            this.fechaTransaccionDataGridViewTextBoxColumn.DataPropertyName = "FechaTransaccion";
            this.fechaTransaccionDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaTransaccionDataGridViewTextBoxColumn.Name = "fechaTransaccionDataGridViewTextBoxColumn";
            this.fechaTransaccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            dataGridViewCellStyle6.Format = "C2";
            this.montoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo";
            dataGridViewCellStyle7.Format = "C2";
            this.saldoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(15, 40);
            this.txtMonto.Mask = "999999";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PromptChar = ' ';
            this.txtMonto.Size = new System.Drawing.Size(171, 26);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AgregarAbono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgvCreditos);
            this.Controls.Add(this.panelDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarAbono";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.ShowIcon = false;
            this.Text = "Agregar Abono";
            this.Load += new System.EventHandler(this.AgregarAbono_Load);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).EndInit();
            this.cmsAbono.ResumeLayout(false);
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITOSPENDIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditosDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelDatos;
        public MetroFramework.Controls.MetroComboBox cboVehiculo;
        private MetroFramework.Controls.MetroLabel lblConductor;
        private System.Windows.Forms.DataGridView dgvCreditos;
        private System.Windows.Forms.ContextMenuStrip cmsAbono;
        private System.Windows.Forms.ToolStripMenuItem registrarAbonoToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblFactura;
        private System.Windows.Forms.BindingSource cREDITOSPENDIENTESBindingSource;
        private CreditosDataset creditosDataset;
        private CreditosDatasetTableAdapters.CREDITOS_PENDIENTESTableAdapter cREDITOS_PENDIENTESTableAdapter;
        private MetroFramework.Controls.MetroPanel panelOpciones;
        private MetroFramework.Controls.MetroLabel lblAbonando;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaTransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox txtMonto;
    }
}