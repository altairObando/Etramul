namespace CapaVista.Creditos
{
    partial class Creditos_Bus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboRubros = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.facturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaTransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREDITOSPORBUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditosDataset = new CapaVista.Creditos.CreditosDataset();
            this.cREDITOSPORBUSRUBROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cREDITOS_POR_BUSTableAdapter = new CapaVista.Creditos.CreditosDatasetTableAdapters.CREDITOS_POR_BUSTableAdapter();
            this.cREDITOS_POR_BUS_RUBROTableAdapter = new CapaVista.Creditos.CreditosDatasetTableAdapters.CREDITOS_POR_BUS_RUBROTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITOSPORBUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditosDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITOSPORBUSRUBROBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboRubros
            // 
            this.cboRubros.FormattingEnabled = true;
            this.cboRubros.ItemHeight = 23;
            this.cboRubros.Location = new System.Drawing.Point(24, 83);
            this.cboRubros.Name = "cboRubros";
            this.cboRubros.Size = new System.Drawing.Size(153, 29);
            this.cboRubros.TabIndex = 1;
            this.cboRubros.SelectedIndexChanged += new System.EventHandler(this.cboRubros_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.dtFecha2);
            this.groupBox1.Controls.Add(this.dtFecha1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(198, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 62);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el perido";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CapaVista.Properties.Resources.search_1_;
            this.button1.Location = new System.Drawing.Point(343, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.filtro_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(174, 31);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Hasta:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Desde:";
            // 
            // dtFecha2
            // 
            this.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha2.Location = new System.Drawing.Point(221, 31);
            this.dtFecha2.Name = "dtFecha2";
            this.dtFecha2.Size = new System.Drawing.Size(104, 22);
            this.dtFecha2.TabIndex = 3;
            // 
            // dtFecha1
            // 
            this.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha1.Location = new System.Drawing.Point(64, 31);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(104, 22);
            this.dtFecha1.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Rubro:";
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.AllowUserToResizeColumns = false;
            this.dgDatos.AllowUserToResizeRows = false;
            this.dgDatos.AutoGenerateColumns = false;
            this.dgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDatos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facturaDataGridViewTextBoxColumn,
            this.Codigo,
            this.fechaTransaccionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgDatos.DataSource = this.cREDITOSPORBUSBindingSource;
            this.dgDatos.Location = new System.Drawing.Point(16, 143);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.RowHeadersVisible = false;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(612, 150);
            this.dgDatos.TabIndex = 3;
            this.dgDatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDatos_CellContentDoubleClick);
            // 
            // facturaDataGridViewTextBoxColumn
            // 
            this.facturaDataGridViewTextBoxColumn.DataPropertyName = "Factura";
            this.facturaDataGridViewTextBoxColumn.HeaderText = "Factura";
            this.facturaDataGridViewTextBoxColumn.Name = "facturaDataGridViewTextBoxColumn";
            this.facturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // fechaTransaccionDataGridViewTextBoxColumn
            // 
            this.fechaTransaccionDataGridViewTextBoxColumn.DataPropertyName = "FechaTransaccion";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.fechaTransaccionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Format = "C2";
            this.montoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo";
            dataGridViewCellStyle6.Format = "C2";
            this.saldoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
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
            // cREDITOSPORBUSBindingSource
            // 
            this.cREDITOSPORBUSBindingSource.DataMember = "CREDITOS_POR_BUS";
            this.cREDITOSPORBUSBindingSource.DataSource = this.creditosDataset;
            // 
            // creditosDataset
            // 
            this.creditosDataset.DataSetName = "CreditosDataset";
            this.creditosDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cREDITOSPORBUSRUBROBindingSource
            // 
            this.cREDITOSPORBUSRUBROBindingSource.DataMember = "CREDITOS_POR_BUS_RUBRO";
            this.cREDITOSPORBUSRUBROBindingSource.DataSource = this.creditosDataset;
            // 
            // cREDITOS_POR_BUSTableAdapter
            // 
            this.cREDITOS_POR_BUSTableAdapter.ClearBeforeFill = true;
            // 
            // cREDITOS_POR_BUS_RUBROTableAdapter
            // 
            this.cREDITOS_POR_BUS_RUBROTableAdapter.ClearBeforeFill = true;
            // 
            // Creditos_Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 316);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboRubros);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Creditos_Bus";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.Text = "Creditos por vehiculo";
            this.Load += new System.EventHandler(this.Creditos_Bus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITOSPORBUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditosDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITOSPORBUSRUBROBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboRubros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFecha2;
        private System.Windows.Forms.DateTimePicker dtFecha1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.BindingSource cREDITOSPORBUSRUBROBindingSource;
        private CreditosDataset creditosDataset;
        private System.Windows.Forms.BindingSource cREDITOSPORBUSBindingSource;
        private CreditosDatasetTableAdapters.CREDITOS_POR_BUSTableAdapter cREDITOS_POR_BUSTableAdapter;
        private CreditosDatasetTableAdapters.CREDITOS_POR_BUS_RUBROTableAdapter cREDITOS_POR_BUS_RUBROTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaTransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}