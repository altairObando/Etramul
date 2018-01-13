namespace CapaVista.Transacciones
{
    partial class GastosPorRubro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbEntreFechas = new System.Windows.Forms.CheckBox();
            this.dtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.idTipoDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastosPorRubroPorDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaccionesDataSet = new CapaVista.Transacciones.TransaccionesDataSet();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblNombre = new MetroFramework.Controls.MetroLink();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cboTipo = new MetroFramework.Controls.MetroComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gastosPorRubroPorDiaTableAdapter = new CapaVista.Transacciones.TransaccionesDataSetTableAdapters.GastosPorRubroPorDiaTableAdapter();
            this.gastosPorRubroEntreFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gastosPorRubroEntreFechasTableAdapter = new CapaVista.Transacciones.TransaccionesDataSetTableAdapters.GastosPorRubroEntreFechasTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosPorRubroPorDiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosPorRubroEntreFechasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.cbEntreFechas);
            this.groupBox1.Controls.Add(this.dtFecha2);
            this.groupBox1.Controls.Add(this.dtFecha1);
            this.groupBox1.Location = new System.Drawing.Point(226, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entre Fechas";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = global::CapaVista.Properties.Resources.exchange_1_;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(83, 45);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(112, 35);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Aplicar Filtro";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbEntreFechas
            // 
            this.cbEntreFechas.AutoSize = true;
            this.cbEntreFechas.Location = new System.Drawing.Point(6, 21);
            this.cbEntreFechas.Name = "cbEntreFechas";
            this.cbEntreFechas.Size = new System.Drawing.Size(15, 14);
            this.cbEntreFechas.TabIndex = 4;
            this.cbEntreFechas.UseVisualStyleBackColor = true;
            this.cbEntreFechas.CheckedChanged += new System.EventHandler(this.cbEntreFechas_CheckedChanged);
            // 
            // dtFecha2
            // 
            this.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha2.Location = new System.Drawing.Point(128, 19);
            this.dtFecha2.Name = "dtFecha2";
            this.dtFecha2.Size = new System.Drawing.Size(95, 20);
            this.dtFecha2.TabIndex = 3;
            // 
            // dtFecha1
            // 
            this.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha1.Location = new System.Drawing.Point(27, 19);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(95, 20);
            this.dtFecha1.TabIndex = 2;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(23, 87);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(178, 20);
            this.dtFecha.TabIndex = 1;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoDetalleDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.Monto});
            this.dgvDatos.DataSource = this.gastosPorRubroPorDiaBindingSource;
            this.dgvDatos.Location = new System.Drawing.Point(23, 176);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(436, 150);
            this.dgvDatos.TabIndex = 2;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // idTipoDetalleDataGridViewTextBoxColumn
            // 
            this.idTipoDetalleDataGridViewTextBoxColumn.DataPropertyName = "IdTipoDetalle";
            this.idTipoDetalleDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.idTipoDetalleDataGridViewTextBoxColumn.Name = "idTipoDetalleDataGridViewTextBoxColumn";
            this.idTipoDetalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle1.Format = "C2";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // gastosPorRubroPorDiaBindingSource
            // 
            this.gastosPorRubroPorDiaBindingSource.DataMember = "GastosPorRubroPorDia";
            this.gastosPorRubroPorDiaBindingSource.DataSource = this.transaccionesDataSet;
            // 
            // transaccionesDataSet
            // 
            this.transaccionesDataSet.DataSetName = "TransaccionesDataSet";
            this.transaccionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::CapaVista.Properties.Resources.printer;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(374, 31);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(49, 35);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(232, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(136, 23);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "--";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(307, 332);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 19);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(354, 332);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(105, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ItemHeight = 23;
            this.cboTipo.Location = new System.Drawing.Point(23, 117);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(178, 29);
            this.cboTipo.TabIndex = 10;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipos_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(429, 41);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 19);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Cerrar";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gastosPorRubroPorDiaTableAdapter
            // 
            this.gastosPorRubroPorDiaTableAdapter.ClearBeforeFill = true;
            // 
            // gastosPorRubroEntreFechasBindingSource
            // 
            this.gastosPorRubroEntreFechasBindingSource.DataMember = "GastosPorRubroEntreFechas";
            this.gastosPorRubroEntreFechasBindingSource.DataSource = this.transaccionesDataSet;
            // 
            // gastosPorRubroEntreFechasTableAdapter
            // 
            this.gastosPorRubroEntreFechasTableAdapter.ClearBeforeFill = true;
            // 
            // GastosPorRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 375);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GastosPorRubro";
            this.ShowInTaskbar = false;
            this.Text = "Gastos Por Rubro";
            this.Load += new System.EventHandler(this.GastosPorRubro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosPorRubroPorDiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosPorRubroEntreFechasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbEntreFechas;
        private System.Windows.Forms.DateTimePicker dtFecha2;
        private System.Windows.Forms.DateTimePicker dtFecha1;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnPrint;
        private MetroFramework.Controls.MetroLink lblNombre;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private TransaccionesDataSet transaccionesDataSet;
        private MetroFramework.Controls.MetroComboBox cboTipo;
        private System.Windows.Forms.Button btnClose;
        private TransaccionesDataSetTableAdapters.GastosPorRubroPorDiaTableAdapter gastosPorRubroPorDiaTableAdapter;
        private System.Windows.Forms.BindingSource gastosPorRubroPorDiaBindingSource;
        private System.Windows.Forms.BindingSource gastosPorRubroEntreFechasBindingSource;
        private TransaccionesDataSetTableAdapters.GastosPorRubroEntreFechasTableAdapter gastosPorRubroEntreFechasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
    }
}