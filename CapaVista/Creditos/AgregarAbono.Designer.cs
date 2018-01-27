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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDatos = new MetroFramework.Controls.MetroPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNoFactura = new MetroFramework.Controls.MetroLabel();
            this.lblFactura = new MetroFramework.Controls.MetroLabel();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cboVehiculo = new MetroFramework.Controls.MetroComboBox();
            this.lblConductor = new MetroFramework.Controls.MetroLabel();
            this.lblDatosGeneral = new MetroFramework.Controls.MetroLabel();
            this.dgvCreditos = new System.Windows.Forms.DataGridView();
            this.NoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsAbono = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.registrarAbonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSalir = new MetroFramework.Controls.MetroLink();
            this.lblUser = new MetroFramework.Controls.MetroLink();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).BeginInit();
            this.cmsAbono.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatos
            // 
            this.panelDatos.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panelDatos.Controls.Add(this.btnBuscar);
            this.panelDatos.Controls.Add(this.lblNoFactura);
            this.panelDatos.Controls.Add(this.lblFactura);
            this.panelDatos.Controls.Add(this.dtFecha);
            this.panelDatos.Controls.Add(this.cboVehiculo);
            this.panelDatos.Controls.Add(this.lblConductor);
            this.panelDatos.Controls.Add(this.lblDatosGeneral);
            this.panelDatos.HorizontalScrollbarBarColor = true;
            this.panelDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDatos.HorizontalScrollbarSize = 10;
            this.panelDatos.Location = new System.Drawing.Point(23, 77);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(682, 117);
            this.panelDatos.TabIndex = 2;
            this.panelDatos.VerticalScrollbarBarColor = true;
            this.panelDatos.VerticalScrollbarHighlightOnWheel = false;
            this.panelDatos.VerticalScrollbarSize = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::CapaVista.Properties.Resources.search_1_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(374, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 39);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar Credito";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // lblNoFactura
            // 
            this.lblNoFactura.AutoSize = true;
            this.lblNoFactura.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNoFactura.Location = new System.Drawing.Point(303, 6);
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
            this.lblFactura.Location = new System.Drawing.Point(240, 5);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(75, 25);
            this.lblFactura.TabIndex = 4;
            this.lblFactura.Text = "Factura: ";
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(487, 10);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(164, 20);
            this.dtFecha.TabIndex = 1;
            // 
            // cboVehiculo
            // 
            this.cboVehiculo.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.cboVehiculo.FormattingEnabled = true;
            this.cboVehiculo.ItemHeight = 29;
            this.cboVehiculo.Location = new System.Drawing.Point(9, 69);
            this.cboVehiculo.Name = "cboVehiculo";
            this.cboVehiculo.Size = new System.Drawing.Size(292, 35);
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
            // dgvCreditos
            // 
            this.dgvCreditos.AllowUserToAddRows = false;
            this.dgvCreditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreditos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCreditos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreditos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoFactura,
            this.Fecha,
            this.Concepto,
            this.Credito,
            this.Saldo});
            this.dgvCreditos.ContextMenuStrip = this.cmsAbono;
            this.dgvCreditos.Location = new System.Drawing.Point(23, 231);
            this.dgvCreditos.Name = "dgvCreditos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCreditos.RowHeadersVisible = false;
            this.dgvCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditos.Size = new System.Drawing.Size(681, 240);
            this.dgvCreditos.TabIndex = 6;
            // 
            // NoFactura
            // 
            this.NoFactura.HeaderText = "Factura";
            this.NoFactura.Name = "NoFactura";
            this.NoFactura.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Credito
            // 
            this.Credito.HeaderText = "Credito";
            this.Credito.Name = "Credito";
            this.Credito.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // cmsAbono
            // 
            this.cmsAbono.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAbonoToolStripMenuItem});
            this.cmsAbono.Name = "cmsAbono";
            this.cmsAbono.Size = new System.Drawing.Size(160, 26);
            this.cmsAbono.Click += new System.EventHandler(this.cmsAbono_Click);
            // 
            // registrarAbonoToolStripMenuItem
            // 
            this.registrarAbonoToolStripMenuItem.Name = "registrarAbonoToolStripMenuItem";
            this.registrarAbonoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.registrarAbonoToolStripMenuItem.Text = "Registrar Abono";
            // 
            // lblSalir
            // 
            this.lblSalir.Location = new System.Drawing.Point(635, 19);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(75, 23);
            this.lblSalir.Style = MetroFramework.MetroColorStyle.Red;
            this.lblSalir.TabIndex = 9;
            this.lblSalir.Text = "Salir";
            this.lblSalir.UseStyleColors = true;
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(479, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(150, 23);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Username";
            this.lblUser.UseStyleColors = true;
            // 
            // AgregarAbono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 485);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dgvCreditos);
            this.Controls.Add(this.panelDatos);
            this.Name = "AgregarAbono";
            this.Text = "Agregar Abono";
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).EndInit();
            this.cmsAbono.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelDatos;
        private System.Windows.Forms.Button btnBuscar;
        private MetroFramework.Controls.MetroLabel lblNoFactura;
        private MetroFramework.Controls.MetroLabel lblFactura;
        private System.Windows.Forms.DateTimePicker dtFecha;
        public MetroFramework.Controls.MetroComboBox cboVehiculo;
        private MetroFramework.Controls.MetroLabel lblConductor;
        private MetroFramework.Controls.MetroLabel lblDatosGeneral;
        private System.Windows.Forms.DataGridView dgvCreditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.ContextMenuStrip cmsAbono;
        private System.Windows.Forms.ToolStripMenuItem registrarAbonoToolStripMenuItem;
        private MetroFramework.Controls.MetroLink lblSalir;
        private MetroFramework.Controls.MetroLink lblUser;
    }
}