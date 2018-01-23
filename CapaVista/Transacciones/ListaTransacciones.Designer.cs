namespace CapaVista.Transacciones
{
    partial class ListaTransacciones
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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvEgresos = new System.Windows.Forms.DataGridView();
            this.CodEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDesplegable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtFechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.txtEgreso = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblAnuladas = new MetroFramework.Controls.MetroLabel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).BeginInit();
            this.menuDesplegable.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFiltrar.Image = global::CapaVista.Properties.Resources.exchange_1_;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(420, 73);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(134, 34);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar Resultados";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ingrese la placa:";
            // 
            // dgvEgresos
            // 
            this.dgvEgresos.AllowUserToAddRows = false;
            this.dgvEgresos.AllowUserToDeleteRows = false;
            this.dgvEgresos.AllowUserToResizeColumns = false;
            this.dgvEgresos.AllowUserToResizeRows = false;
            this.dgvEgresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEgresos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEgresos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodEgreso,
            this.descripcion,
            this.Egreso,
            this.TipoTransaccion,
            this.monto,
            this.Egresos});
            this.dgvEgresos.ContextMenuStrip = this.menuDesplegable;
            this.dgvEgresos.Location = new System.Drawing.Point(25, 130);
            this.dgvEgresos.Name = "dgvEgresos";
            this.dgvEgresos.ReadOnly = true;
            this.dgvEgresos.RowHeadersVisible = false;
            this.dgvEgresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEgresos.Size = new System.Drawing.Size(727, 311);
            this.dgvEgresos.TabIndex = 6;
            this.dgvEgresos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEgresos_CellContentClick);
            // 
            // CodEgreso
            // 
            this.CodEgreso.HeaderText = "No. Transacción";
            this.CodEgreso.Name = "CodEgreso";
            this.CodEgreso.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Cajero";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // Egreso
            // 
            this.Egreso.HeaderText = "Placa";
            this.Egreso.Name = "Egreso";
            this.Egreso.ReadOnly = true;
            // 
            // TipoTransaccion
            // 
            this.TipoTransaccion.HeaderText = "Fecha Transacción";
            this.TipoTransaccion.Name = "TipoTransaccion";
            this.TipoTransaccion.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.HeaderText = "Ingreso";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // Egresos
            // 
            this.Egresos.HeaderText = "Egresos";
            this.Egresos.Name = "Egresos";
            this.Egresos.ReadOnly = true;
            // 
            // menuDesplegable
            // 
            this.menuDesplegable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vToolStripMenuItem,
            this.imprimirFacturaToolStripMenuItem});
            this.menuDesplegable.Name = "contextMenuStrip1";
            this.menuDesplegable.Size = new System.Drawing.Size(163, 48);
            // 
            // vToolStripMenuItem
            // 
            this.vToolStripMenuItem.Name = "vToolStripMenuItem";
            this.vToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.vToolStripMenuItem.Text = "Ver Detalles";
            this.vToolStripMenuItem.Click += new System.EventHandler(this.vToolStripMenuItem_Click);
            // 
            // imprimirFacturaToolStripMenuItem
            // 
            this.imprimirFacturaToolStripMenuItem.Name = "imprimirFacturaToolStripMenuItem";
            this.imprimirFacturaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.imprimirFacturaToolStripMenuItem.Text = "Imprimir Factura";
            this.imprimirFacturaToolStripMenuItem.Click += new System.EventHandler(this.imprimirFacturaToolStripMenuItem_Click);
            // 
            // dtFechaFiltro
            // 
            this.dtFechaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFiltro.Location = new System.Drawing.Point(266, 78);
            this.dtFechaFiltro.Name = "dtFechaFiltro";
            this.dtFechaFiltro.Size = new System.Drawing.Size(123, 20);
            this.dtFechaFiltro.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(149, 444);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Total Ingresos:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(331, 444);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Total Egresos:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(571, 444);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(39, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Total:";
            // 
            // txtIngreso
            // 
            this.txtIngreso.BackColor = System.Drawing.Color.White;
            this.txtIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngreso.Location = new System.Drawing.Point(241, 448);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.ReadOnly = true;
            this.txtIngreso.Size = new System.Drawing.Size(89, 13);
            this.txtIngreso.TabIndex = 9;
            this.txtIngreso.Text = "C$ -";
            // 
            // txtEgreso
            // 
            this.txtEgreso.BackColor = System.Drawing.Color.White;
            this.txtEgreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEgreso.Location = new System.Drawing.Point(422, 448);
            this.txtEgreso.Name = "txtEgreso";
            this.txtEgreso.ReadOnly = true;
            this.txtEgreso.Size = new System.Drawing.Size(89, 13);
            this.txtEgreso.TabIndex = 11;
            this.txtEgreso.Text = "C$ -";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(614, 448);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(89, 13);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.Text = "C$ -";
            // 
            // lblAnuladas
            // 
            this.lblAnuladas.AutoSize = true;
            this.lblAnuladas.Location = new System.Drawing.Point(51, 444);
            this.lblAnuladas.Name = "lblAnuladas";
            this.lblAnuladas.Size = new System.Drawing.Size(66, 19);
            this.lblAnuladas.Style = MetroFramework.MetroColorStyle.Red;
            this.lblAnuladas.TabIndex = 7;
            this.lblAnuladas.Text = "*Anuladas";
            this.lblAnuladas.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblAnuladas.UseStyleColors = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(577, 73);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(84, 34);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(130, 78);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(130, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // ListaTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 483);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblAnuladas);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtEgreso);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dtFechaFiltro);
            this.Controls.Add(this.dgvEgresos);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnFiltrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaTransacciones";
            this.Resizable = false;
            this.Text = "Histórico de Transacciones";
            this.Load += new System.EventHandler(this.ListaTransacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).EndInit();
            this.menuDesplegable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvEgresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egresos;
        private System.Windows.Forms.ContextMenuStrip menuDesplegable;
        private System.Windows.Forms.ToolStripMenuItem vToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirFacturaToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtFechaFiltro;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.TextBox txtEgreso;
        private System.Windows.Forms.TextBox txtTotal;
        private MetroFramework.Controls.MetroLabel lblAnuladas;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.TextBox txtDescripcion;
    }
}