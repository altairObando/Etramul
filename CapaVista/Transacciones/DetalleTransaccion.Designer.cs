﻿namespace CapaVista.Transacciones
{
    partial class DetalleTransaccion
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
            this.lblPlaca = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblfecha = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblCajero = new MetroFramework.Controls.MetroLabel();
            this.lblNumero = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvEgresos = new System.Windows.Forms.DataGridView();
            this.CodEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAnulacion = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.lblPlaca.Location = new System.Drawing.Point(394, 48);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(25, 19);
            this.lblPlaca.TabIndex = 3;
            this.lblPlaca.Text = "-- ";
            this.lblPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(348, 48);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(43, 19);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Placa:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.lblfecha.Location = new System.Drawing.Point(394, 19);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(21, 19);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "--";
            this.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(275, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(116, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Fecha Transaccion:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(57, 48);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Cajero:";
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.lblCajero.Location = new System.Drawing.Point(114, 48);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(21, 19);
            this.lblCajero.TabIndex = 1;
            this.lblCajero.Text = "--";
            this.lblCajero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.lblNumero.Location = new System.Drawing.Point(114, 19);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(21, 19);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "--";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Factura:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblPlaca);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.lblfecha);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.lblCajero);
            this.panel1.Controls.Add(this.lblNumero);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Location = new System.Drawing.Point(23, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 81);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(546, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(20, 16);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "---";
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
            this.Egreso,
            this.descripcion,
            this.TipoTransaccion,
            this.monto});
            this.dgvEgresos.Location = new System.Drawing.Point(23, 143);
            this.dgvEgresos.Name = "dgvEgresos";
            this.dgvEgresos.ReadOnly = true;
            this.dgvEgresos.RowHeadersVisible = false;
            this.dgvEgresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEgresos.Size = new System.Drawing.Size(666, 254);
            this.dgvEgresos.TabIndex = 1;
            // 
            // CodEgreso
            // 
            this.CodEgreso.HeaderText = "Codigo";
            this.CodEgreso.Name = "CodEgreso";
            this.CodEgreso.ReadOnly = true;
            // 
            // Egreso
            // 
            this.Egreso.HeaderText = "Tipo Detalle";
            this.Egreso.Name = "Egreso";
            this.Egreso.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // TipoTransaccion
            // 
            this.TipoTransaccion.HeaderText = "Tipo Transacción";
            this.TipoTransaccion.Name = "TipoTransaccion";
            this.TipoTransaccion.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto Total";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(632, 80);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 24);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Anular";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CapaVista.Properties.Resources.close_button;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(632, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cerrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblAnulacion);
            this.panel2.Location = new System.Drawing.Point(7, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 387);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblAnulacion
            // 
            this.lblAnulacion.AutoSize = true;
            this.lblAnulacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAnulacion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAnulacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAnulacion.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.lblAnulacion.Location = new System.Drawing.Point(16, 91);
            this.lblAnulacion.Name = "lblAnulacion";
            this.lblAnulacion.Size = new System.Drawing.Size(26, 25);
            this.lblAnulacion.Style = MetroFramework.MetroColorStyle.Red;
            this.lblAnulacion.TabIndex = 20;
            this.lblAnulacion.Text = "--";
            this.lblAnulacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetalleTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 420);
            this.Controls.Add(this.dgvEgresos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetalleTransaccion";
            this.Resizable = false;
            this.Text = "DetalleTransaccion";
            this.Load += new System.EventHandler(this.DetalleTransaccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblPlaca;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblfecha;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblCajero;
        private MetroFramework.Controls.MetroLabel lblNumero;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEgresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel lblAnulacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
    }
}