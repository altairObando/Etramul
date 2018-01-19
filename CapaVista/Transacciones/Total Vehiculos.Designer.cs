namespace CapaVista.Vehiculos
{
    partial class Total_Vehiculos
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
            this.dgvTotal = new System.Windows.Forms.DataGridView();
            this.idVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verDetalles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportesDataSet = new CapaVista.Reportes.ReportesDataSet();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.txtEgreso = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblUsuario = new MetroFramework.Controls.MetroLink();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFiltrar = new MetroFramework.Controls.MetroLink();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.ingreso_TotalTableAdapter = new CapaVista.Reportes.ReportesDataSetTableAdapters.ingreso_total_por_diaTableAdapter();
            this.IngresoEntreFechas = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            this.verDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingresoTotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngresoEntreFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTotal
            // 
            this.dgvTotal.AllowUserToAddRows = false;
            this.dgvTotal.AllowUserToDeleteRows = false;
            this.dgvTotal.AutoGenerateColumns = false;
            this.dgvTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotal.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVehiculoDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.ingresoDataGridViewTextBoxColumn,
            this.egresoDataGridViewTextBoxColumn});
            this.dgvTotal.ContextMenuStrip = this.verDetalles;
            this.dgvTotal.DataSource = this.ingresoTotalBindingSource;
            this.dgvTotal.Location = new System.Drawing.Point(23, 122);
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.ReadOnly = true;
            this.dgvTotal.RowHeadersVisible = false;
            this.dgvTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTotal.Size = new System.Drawing.Size(636, 207);
            this.dgvTotal.TabIndex = 6;
            this.dgvTotal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTotal_CellContentClick);
            // 
            // idVehiculoDataGridViewTextBoxColumn
            // 
            this.idVehiculoDataGridViewTextBoxColumn.DataPropertyName = "Id_Vehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.HeaderText = "Vehiculo No.";
            this.idVehiculoDataGridViewTextBoxColumn.Name = "idVehiculoDataGridViewTextBoxColumn";
            this.idVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingresoDataGridViewTextBoxColumn
            // 
            this.ingresoDataGridViewTextBoxColumn.DataPropertyName = "Ingreso";
            dataGridViewCellStyle1.Format = "C2";
            this.ingresoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ingresoDataGridViewTextBoxColumn.HeaderText = "Ingreso";
            this.ingresoDataGridViewTextBoxColumn.Name = "ingresoDataGridViewTextBoxColumn";
            this.ingresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // egresoDataGridViewTextBoxColumn
            // 
            this.egresoDataGridViewTextBoxColumn.DataPropertyName = "Egreso";
            dataGridViewCellStyle2.Format = "C2";
            this.egresoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.egresoDataGridViewTextBoxColumn.HeaderText = "Egreso";
            this.egresoDataGridViewTextBoxColumn.Name = "egresoDataGridViewTextBoxColumn";
            this.egresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verDetalles
            // 
            this.verDetalles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDetallesToolStripMenuItem});
            this.verDetalles.Name = "verDetalles";
            this.verDetalles.Size = new System.Drawing.Size(135, 26);
            // 
            // verDetallesToolStripMenuItem
            // 
            this.verDetallesToolStripMenuItem.Name = "verDetallesToolStripMenuItem";
            this.verDetallesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.verDetallesToolStripMenuItem.Text = "&Ver Detalles";
            this.verDetallesToolStripMenuItem.Click += new System.EventHandler(this.verDetallesToolStripMenuItem_Click);
            // 
            // ingresoTotalBindingSource
            // 
            this.ingresoTotalBindingSource.DataMember = "ingreso_total_por_dia";
            this.ingresoTotalBindingSource.DataSource = this.reportesDataSet;
            // 
            // reportesDataSet
            // 
            this.reportesDataSet.DataSetName = "ReportesDataSet";
            this.reportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(23, 91);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(111, 20);
            this.dtFecha.TabIndex = 1;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Por dia:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 346);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Ingreso Total:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(212, 346);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Egreso Total:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(414, 346);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Utilidad Total:";
            // 
            // txtIngreso
            // 
            this.txtIngreso.BackColor = System.Drawing.Color.White;
            this.txtIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreso.Location = new System.Drawing.Point(106, 346);
            this.txtIngreso.Multiline = true;
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.ReadOnly = true;
            this.txtIngreso.Size = new System.Drawing.Size(109, 19);
            this.txtIngreso.TabIndex = 8;
            this.txtIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEgreso
            // 
            this.txtEgreso.BackColor = System.Drawing.Color.White;
            this.txtEgreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEgreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEgreso.Location = new System.Drawing.Point(294, 346);
            this.txtEgreso.Multiline = true;
            this.txtEgreso.Name = "txtEgreso";
            this.txtEgreso.ReadOnly = true;
            this.txtEgreso.Size = new System.Drawing.Size(118, 19);
            this.txtEgreso.TabIndex = 10;
            this.txtEgreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(519, 346);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(140, 19);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(556, 69);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(78, 46);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::CapaVista.Properties.Resources.printer;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(463, 68);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(87, 46);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(463, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(136, 23);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "--";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFiltrar);
            this.groupBox1.Controls.Add(this.dtFechaFin);
            this.groupBox1.Controls.Add(this.dtFechaInicio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(149, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 45);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entre Fechas:";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Location = new System.Drawing.Point(215, 16);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(48, 23);
            this.lblFiltrar.TabIndex = 2;
            this.lblFiltrar.Text = "Filtrar";
            this.lblFiltrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblFiltrar.UseStyleColors = true;
            this.lblFiltrar.Click += new System.EventHandler(this.lblFiltrar_Click);
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(113, 19);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(96, 20);
            this.dtFechaFin.TabIndex = 1;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(6, 19);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(96, 20);
            this.dtFechaInicio.TabIndex = 0;
            // 
            // ingreso_TotalTableAdapter
            // 
            this.ingreso_TotalTableAdapter.ClearBeforeFill = true;
            // 
            // Total_Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(682, 398);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtEgreso);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.dgvTotal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Total_Vehiculos";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.ShowInTaskbar = false;
            this.Text = "Total Generado por dia";
            this.Load += new System.EventHandler(this.Total_Vehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            this.verDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ingresoTotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IngresoEntreFechas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTotal;
        private Reportes.ReportesDataSet reportesDataSet;
        private System.Windows.Forms.BindingSource ingresoTotalBindingSource;
        private Reportes.ReportesDataSetTableAdapters.ingreso_total_por_diaTableAdapter ingreso_TotalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.TextBox txtEgreso;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnPrint;
        private MetroFramework.Controls.MetroLink lblUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private MetroFramework.Controls.MetroLink lblFiltrar;
        private System.Windows.Forms.ContextMenuStrip verDetalles;
        private System.Windows.Forms.ToolStripMenuItem verDetallesToolStripMenuItem;
        private System.Windows.Forms.BindingSource IngresoEntreFechas;        

    }
}