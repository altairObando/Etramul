namespace CapaVista.Transacciones
{
    partial class DetalleEgresos
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
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.idTransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaTransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egresosDetallePorRubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaccionesDataSet = new CapaVista.Transacciones.TransaccionesDataSet();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.egresosDetallePorRubroTableAdapter = new CapaVista.Transacciones.TransaccionesDataSetTableAdapters.EgresosDetallePorRubroTableAdapter();
            this.egresosDetallePorRubroEntreFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.egresosDetallePorRubroEntreFechasTableAdapter = new CapaVista.Transacciones.TransaccionesDataSetTableAdapters.EgresosDetallePorRubroEntreFechasTableAdapter();
            this.dgFechas = new System.Windows.Forms.DataGridView();
            this.idTransaccionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaTransaccionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPlaca = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egresosDetallePorRubroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egresosDetallePorRubroEntreFechasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AutoGenerateColumns = false;
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransaccionDataGridViewTextBoxColumn,
            this.fechaTransaccionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dgvDetalles.DataSource = this.egresosDetallePorRubroBindingSource;
            this.dgvDetalles.Location = new System.Drawing.Point(17, 99);
            this.dgvDetalles.MultiSelect = false;
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.Size = new System.Drawing.Size(477, 229);
            this.dgvDetalles.TabIndex = 0;
            // 
            // idTransaccionDataGridViewTextBoxColumn
            // 
            this.idTransaccionDataGridViewTextBoxColumn.DataPropertyName = "IdTransaccion";
            this.idTransaccionDataGridViewTextBoxColumn.HeaderText = "Factura";
            this.idTransaccionDataGridViewTextBoxColumn.Name = "idTransaccionDataGridViewTextBoxColumn";
            this.idTransaccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaTransaccionDataGridViewTextBoxColumn
            // 
            this.fechaTransaccionDataGridViewTextBoxColumn.DataPropertyName = "FechaTransaccion";
            this.fechaTransaccionDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaTransaccionDataGridViewTextBoxColumn.Name = "fechaTransaccionDataGridViewTextBoxColumn";
            this.fechaTransaccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // egresosDetallePorRubroBindingSource
            // 
            this.egresosDetallePorRubroBindingSource.DataMember = "EgresosDetallePorRubro";
            this.egresosDetallePorRubroBindingSource.DataSource = this.transaccionesDataSet;
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
            this.btnPrint.Location = new System.Drawing.Point(364, 44);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(49, 35);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnCerrar.Location = new System.Drawing.Point(419, 44);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(49, 35);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // egresosDetallePorRubroTableAdapter
            // 
            this.egresosDetallePorRubroTableAdapter.ClearBeforeFill = true;
            // 
            // egresosDetallePorRubroEntreFechasBindingSource
            // 
            this.egresosDetallePorRubroEntreFechasBindingSource.DataMember = "EgresosDetallePorRubroEntreFechas";
            this.egresosDetallePorRubroEntreFechasBindingSource.DataSource = this.transaccionesDataSet;
            // 
            // egresosDetallePorRubroEntreFechasTableAdapter
            // 
            this.egresosDetallePorRubroEntreFechasTableAdapter.ClearBeforeFill = true;
            // 
            // dgFechas
            // 
            this.dgFechas.AllowUserToAddRows = false;
            this.dgFechas.AllowUserToDeleteRows = false;
            this.dgFechas.AllowUserToOrderColumns = true;
            this.dgFechas.AutoGenerateColumns = false;
            this.dgFechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFechas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransaccionDataGridViewTextBoxColumn1,
            this.fechaTransaccionDataGridViewTextBoxColumn1,
            this.descripcionDataGridViewTextBoxColumn1,
            this.cantidadDataGridViewTextBoxColumn1});
            this.dgFechas.DataSource = this.egresosDetallePorRubroEntreFechasBindingSource;
            this.dgFechas.Location = new System.Drawing.Point(17, 99);
            this.dgFechas.MultiSelect = false;
            this.dgFechas.Name = "dgFechas";
            this.dgFechas.ReadOnly = true;
            this.dgFechas.RowHeadersVisible = false;
            this.dgFechas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFechas.Size = new System.Drawing.Size(477, 229);
            this.dgFechas.TabIndex = 3;
            // 
            // idTransaccionDataGridViewTextBoxColumn1
            // 
            this.idTransaccionDataGridViewTextBoxColumn1.DataPropertyName = "IdTransaccion";
            this.idTransaccionDataGridViewTextBoxColumn1.HeaderText = "Factura";
            this.idTransaccionDataGridViewTextBoxColumn1.Name = "idTransaccionDataGridViewTextBoxColumn1";
            this.idTransaccionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechaTransaccionDataGridViewTextBoxColumn1
            // 
            this.fechaTransaccionDataGridViewTextBoxColumn1.DataPropertyName = "FechaTransaccion";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.fechaTransaccionDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.fechaTransaccionDataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.fechaTransaccionDataGridViewTextBoxColumn1.Name = "fechaTransaccionDataGridViewTextBoxColumn1";
            this.fechaTransaccionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn1
            // 
            this.descripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.Name = "descripcionDataGridViewTextBoxColumn1";
            this.descripcionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn1
            // 
            this.cantidadDataGridViewTextBoxColumn1.DataPropertyName = "Cantidad";
            dataGridViewCellStyle6.Format = "C2";
            this.cantidadDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.cantidadDataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn1.Name = "cantidadDataGridViewTextBoxColumn1";
            this.cantidadDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(23, 60);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(45, 19);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "------";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(163, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Gasto Total: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(251, 60);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 19);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "------";
            // 
            // DetalleEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 345);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.dgFechas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvDetalles);
            this.Name = "DetalleEgresos";
            this.Text = "Detalle de Egresos";
            this.Load += new System.EventHandler(this.DetalleEgresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egresosDetallePorRubroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egresosDetallePorRubroEntreFechasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFechas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalles;
        private TransaccionesDataSet transaccionesDataSet;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.BindingSource egresosDetallePorRubroBindingSource;
        private TransaccionesDataSetTableAdapters.EgresosDetallePorRubroTableAdapter egresosDetallePorRubroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaTransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource egresosDetallePorRubroEntreFechasBindingSource;
        private TransaccionesDataSetTableAdapters.EgresosDetallePorRubroEntreFechasTableAdapter egresosDetallePorRubroEntreFechasTableAdapter;
        private System.Windows.Forms.DataGridView dgFechas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransaccionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaTransaccionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroLabel lblPlaca;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblTotal;
    }
}