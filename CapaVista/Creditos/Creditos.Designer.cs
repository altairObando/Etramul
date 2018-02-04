namespace CapaVista.Creditos
{
    partial class Creditos_form
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
            this.dgvCreditos = new System.Windows.Forms.DataGridView();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirAbonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboRubros = new System.Windows.Forms.ComboBox();
            this.lblRubros = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.check = new System.Windows.Forms.CheckBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).BeginInit();
            this.ctxMenu.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCreditos
            // 
            this.dgvCreditos.AllowUserToAddRows = false;
            this.dgvCreditos.AllowUserToDeleteRows = false;
            this.dgvCreditos.AllowUserToResizeRows = false;
            this.dgvCreditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreditos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCreditos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditos.ContextMenuStrip = this.ctxMenu;
            this.dgvCreditos.Location = new System.Drawing.Point(12, 133);
            this.dgvCreditos.Name = "dgvCreditos";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCreditos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditos.Size = new System.Drawing.Size(885, 325);
            this.dgvCreditos.TabIndex = 5;
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDetallesToolStripMenuItem,
            this.imprimirAbonosToolStripMenuItem});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(165, 70);
            this.ctxMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ctxMenu_Opening);
            // 
            // verDetallesToolStripMenuItem
            // 
            this.verDetallesToolStripMenuItem.Name = "verDetallesToolStripMenuItem";
            this.verDetallesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.verDetallesToolStripMenuItem.Text = "&Abonos";
            this.verDetallesToolStripMenuItem.Click += new System.EventHandler(this.verDetallesToolStripMenuItem_Click);
            // 
            // imprimirAbonosToolStripMenuItem
            // 
            this.imprimirAbonosToolStripMenuItem.Name = "imprimirAbonosToolStripMenuItem";
            this.imprimirAbonosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.imprimirAbonosToolStripMenuItem.Text = "&Imprimir Abonos";
            this.imprimirAbonosToolStripMenuItem.Click += new System.EventHandler(this.imprimirAbonosToolStripMenuItem_Click);
            // 
            // cboRubros
            // 
            this.cboRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRubros.FormattingEnabled = true;
            this.cboRubros.Location = new System.Drawing.Point(12, 91);
            this.cboRubros.Name = "cboRubros";
            this.cboRubros.Size = new System.Drawing.Size(158, 28);
            this.cboRubros.TabIndex = 1;
            this.cboRubros.SelectedIndexChanged += new System.EventHandler(this.cboRubros_SelectedIndexChanged);
            // 
            // lblRubros
            // 
            this.lblRubros.AutoSize = true;
            this.lblRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubros.Location = new System.Drawing.Point(12, 64);
            this.lblRubros.Name = "lblRubros";
            this.lblRubros.Size = new System.Drawing.Size(140, 17);
            this.lblRubros.TabIndex = 0;
            this.lblRubros.Text = "Seleccione un Rubro";
            // 
            // dtFecha
            // 
            this.dtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(176, 92);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(125, 23);
            this.dtFecha.TabIndex = 2;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.check);
            this.gbFiltro.Controls.Add(this.btnFiltrar);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Controls.Add(this.dtFecha2);
            this.gbFiltro.Controls.Add(this.dtFecha1);
            this.gbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltro.Location = new System.Drawing.Point(388, 64);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(508, 64);
            this.gbFiltro.TabIndex = 4;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Busqueda entre fechas:";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(23, 28);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(15, 14);
            this.check.TabIndex = 0;
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = global::CapaVista.Properties.Resources.search_1_;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(397, 17);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(101, 36);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde: ";
            // 
            // dtFecha2
            // 
            this.dtFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha2.Location = new System.Drawing.Point(269, 24);
            this.dtFecha2.Name = "dtFecha2";
            this.dtFecha2.Size = new System.Drawing.Size(106, 23);
            this.dtFecha2.TabIndex = 4;
            // 
            // dtFecha1
            // 
            this.dtFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha1.Location = new System.Drawing.Point(102, 24);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(106, 23);
            this.dtFecha1.TabIndex = 2;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(307, 87);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 30);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "Todo";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::CapaVista.Properties.Resources.printer;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(744, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 53);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Creditos_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 487);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lblRubros);
            this.Controls.Add(this.cboRubros);
            this.Controls.Add(this.dgvCreditos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Creditos_form";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.ShowIcon = false;
            this.Text = "Creditos";
            this.Load += new System.EventHandler(this.Creditos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCreditos;
        private System.Windows.Forms.ComboBox cboRubros;
        private System.Windows.Forms.Label lblRubros;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.DateTimePicker dtFecha2;
        private System.Windows.Forms.DateTimePicker dtFecha1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem verDetallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirAbonosToolStripMenuItem;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.CheckBox check;
    }
}