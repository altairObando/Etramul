namespace CapaVista.Transacciones
{
    partial class DetalleCarrera
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblNumero = new MetroFramework.Controls.MetroLabel();
            this.detallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaccionesDataSet = new CapaVista.Transacciones.TransaccionesDataSet();
            this.lblConductor = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblFecha = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblPlaca = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.dgvEgresos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblApellidos = new MetroFramework.Controls.MetroLabel();
            this.detallesTableAdapter = new CapaVista.Transacciones.TransaccionesDataSetTableAdapters.DetallesTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "No. Carrera:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesBindingSource, "Id_carrera", true));
            this.lblNumero.Location = new System.Drawing.Point(108, 107);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(21, 19);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "--";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detallesBindingSource
            // 
            this.detallesBindingSource.DataMember = "Detalles";
            this.detallesBindingSource.DataSource = this.transaccionesDataSet;
            // 
            // transaccionesDataSet
            // 
            this.transaccionesDataSet.DataSetName = "TransaccionesDataSet";
            this.transaccionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesBindingSource, "Nombres", true));
            this.lblConductor.Location = new System.Drawing.Point(108, 136);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(21, 19);
            this.lblConductor.TabIndex = 1;
            this.lblConductor.Text = "--";
            this.lblConductor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(31, 136);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Conductor:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(317, 107);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Fecha Carrera:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesBindingSource, "FechaCarrera", true));
            this.lblFecha.Location = new System.Drawing.Point(418, 107);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(21, 19);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "--";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(62, 166);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(43, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Placa:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesBindingSource, "Placa", true));
            this.lblPlaca.Location = new System.Drawing.Point(108, 166);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(25, 19);
            this.lblPlaca.TabIndex = 2;
            this.lblPlaca.Text = "-- ";
            this.lblPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(333, 136);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(83, 19);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "Total Egreso:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(418, 136);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(21, 19);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "--";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEgresos
            // 
            this.dgvEgresos.AllowUserToAddRows = false;
            this.dgvEgresos.AllowUserToDeleteRows = false;
            this.dgvEgresos.AllowUserToResizeColumns = false;
            this.dgvEgresos.AllowUserToResizeRows = false;
            this.dgvEgresos.AutoGenerateColumns = false;
            this.dgvEgresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEgresos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.egresoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.dgvEgresos.DataSource = this.detallesBindingSource;
            this.dgvEgresos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEgresos.Location = new System.Drawing.Point(20, 194);
            this.dgvEgresos.Name = "dgvEgresos";
            this.dgvEgresos.ReadOnly = true;
            this.dgvEgresos.RowHeadersVisible = false;
            this.dgvEgresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEgresos.Size = new System.Drawing.Size(555, 150);
            this.dgvEgresos.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // egresoDataGridViewTextBoxColumn
            // 
            this.egresoDataGridViewTextBoxColumn.DataPropertyName = "Egreso";
            this.egresoDataGridViewTextBoxColumn.HeaderText = "Egreso";
            this.egresoDataGridViewTextBoxColumn.Name = "egresoDataGridViewTextBoxColumn";
            this.egresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesBindingSource, "Apellidos", true));
            this.lblApellidos.Location = new System.Drawing.Point(175, 136);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(21, 19);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "--";
            this.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detallesTableAdapter
            // 
            this.detallesTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnSalir.Location = new System.Drawing.Point(517, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 41);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // DetalleCarrera
            // 
            this.AcceptButton = this.btnSalir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(595, 364);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.dgvEgresos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblConductor);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetalleCarrera";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Text = "Detalle de Carrera";
            this.Load += new System.EventHandler(this.DetalleCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel lblNumero;
        private MetroFramework.Controls.MetroLabel lblConductor;
        private MetroFramework.Controls.MetroLabel lblFecha;
        private MetroFramework.Controls.MetroLabel lblPlaca;
        private MetroFramework.Controls.MetroLabel lblTotal;
        public System.Windows.Forms.DataGridView dgvEgresos;
        //private System.Windows.Forms.BindingSource EgresosBinding;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idcarreraDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel lblApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn egresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource detallesBindingSource;
        private TransaccionesDataSet transaccionesDataSet;
        private TransaccionesDataSetTableAdapters.DetallesTableAdapter detallesTableAdapter;
        private System.Windows.Forms.Button btnSalir;
    }
}