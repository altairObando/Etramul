namespace CapaVista.Vehiculos
{
    partial class UltimasTransacciones
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
            this.lblPlaca = new MetroFramework.Controls.MetroLabel();
            this.lblCodigoPlaca = new MetroFramework.Controls.MetroLabel();
            this.lblNumero = new MetroFramework.Controls.MetroLabel();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.reset = new MetroFramework.Controls.MetroLink();
            this.lblMostrar = new MetroFramework.Controls.MetroLabel();
            this.tbTOP = new MetroFramework.Controls.MetroTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.detalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(23, 65);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(43, 19);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblCodigoPlaca
            // 
            this.lblCodigoPlaca.AutoSize = true;
            this.lblCodigoPlaca.Location = new System.Drawing.Point(72, 68);
            this.lblCodigoPlaca.Name = "lblCodigoPlaca";
            this.lblCodigoPlaca.Size = new System.Drawing.Size(27, 19);
            this.lblCodigoPlaca.TabIndex = 0;
            this.lblCodigoPlaca.Text = "---";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(408, 65);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(21, 19);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "--";
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.AllowUserToResizeColumns = false;
            this.dgDatos.AllowUserToResizeRows = false;
            this.dgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDatos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Fecha,
            this.Cajero,
            this.Ingreso,
            this.Egreso});
            this.dgDatos.ContextMenuStrip = this.detalles;
            this.dgDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgDatos.Location = new System.Drawing.Point(20, 119);
            this.dgDatos.MultiSelect = false;
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.RowHeadersVisible = false;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(615, 236);
            this.dgDatos.TabIndex = 6;
            this.dgDatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDatos_CellContentDoubleClick);
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // Fecha
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle4;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Cajero
            // 
            this.Cajero.HeaderText = "Cajero";
            this.Cajero.Name = "Cajero";
            this.Cajero.ReadOnly = true;
            // 
            // Ingreso
            // 
            dataGridViewCellStyle5.Format = "C";
            this.Ingreso.DefaultCellStyle = dataGridViewCellStyle5;
            this.Ingreso.HeaderText = "Ingreso total";
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.ReadOnly = true;
            // 
            // Egreso
            // 
            dataGridViewCellStyle6.Format = "C";
            this.Egreso.DefaultCellStyle = dataGridViewCellStyle6;
            this.Egreso.HeaderText = "Egreso Total";
            this.Egreso.Name = "Egreso";
            this.Egreso.ReadOnly = true;
            // 
            // detalles
            // 
            this.detalles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDetallesToolStripMenuItem});
            this.detalles.Name = "detalles";
            this.detalles.Size = new System.Drawing.Size(134, 26);
            // 
            // verDetallesToolStripMenuItem
            // 
            this.verDetallesToolStripMenuItem.Name = "verDetallesToolStripMenuItem";
            this.verDetallesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.verDetallesToolStripMenuItem.Text = "&Ver detalles";
            this.verDetallesToolStripMenuItem.Click += new System.EventHandler(this.verDetallesToolStripMenuItem_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(551, 51);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(81, 37);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(444, 61);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 4;
            this.reset.Text = "Restablecer";
            this.reset.Theme = MetroFramework.MetroThemeStyle.Light;
            this.reset.UseStyleColors = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(191, 65);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(59, 19);
            this.lblMostrar.TabIndex = 1;
            this.lblMostrar.Text = "Mostrar:";
            // 
            // tbTOP
            // 
            this.tbTOP.BackColor = System.Drawing.Color.Transparent;
            this.tbTOP.Location = new System.Drawing.Point(239, 65);
            this.tbTOP.Name = "tbTOP";
            this.tbTOP.Size = new System.Drawing.Size(163, 23);
            this.tbTOP.TabIndex = 2;
            this.tbTOP.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbTOP_Scroll);
            // 
            // UltimasTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 375);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.tbTOP);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCodigoPlaca);
            this.Controls.Add(this.lblPlaca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UltimasTransacciones";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.ShowInTaskbar = false;
            this.Text = "Ultimas Transacciones";
            this.Load += new System.EventHandler(this.UltimasTransacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.detalles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblPlaca;
        private MetroFramework.Controls.MetroLabel lblCodigoPlaca;
        private MetroFramework.Controls.MetroLabel lblNumero;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.Button btnCerrar;
        private MetroFramework.Controls.MetroLink reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egreso;
        private MetroFramework.Controls.MetroLabel lblMostrar;
        private MetroFramework.Controls.MetroTrackBar tbTOP;
        private System.Windows.Forms.ContextMenuStrip detalles;
        private System.Windows.Forms.ToolStripMenuItem verDetallesToolStripMenuItem;
    }
}