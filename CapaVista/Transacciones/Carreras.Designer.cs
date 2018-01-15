namespace CapaVista.Transacciones
{
    partial class Carreras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCarreras = new System.Windows.Forms.DataGridView();
            this.idcarreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conductorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaLlegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.anularCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEgresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.conductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaccionesDataSet = new CapaVista.Transacciones.TransaccionesDataSet();
            this.dtFiltroFecha = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTrackbar = new MetroFramework.Controls.MetroLabel();
            this.tbNumeroRegistros = new MetroFramework.Controls.MetroTrackBar();
            this.lblTrackValue = new MetroFramework.Controls.MetroLabel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblRestablecer = new MetroFramework.Controls.MetroLink();
            this.lblUser = new MetroFramework.Controls.MetroLink();
            this.carrerasTableTableAdapter = new CapaVista.Transacciones.TransaccionesDataSetTableAdapters.CarrerasTableTableAdapter();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarreras
            // 
            this.dgvCarreras.AllowUserToAddRows = false;
            this.dgvCarreras.AllowUserToDeleteRows = false;
            this.dgvCarreras.AllowUserToResizeColumns = false;
            this.dgvCarreras.AllowUserToResizeRows = false;
            this.dgvCarreras.AutoGenerateColumns = false;
            this.dgvCarreras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarreras.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCarreras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCarreras.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarreras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcarreraDataGridViewTextBoxColumn,
            this.notransaccionDataGridViewTextBoxColumn,
            this.conductorDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.horaSalidaDataGridViewTextBoxColumn,
            this.horaLlegadaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.ingresoDataGridViewTextBoxColumn,
            this.completaDataGridViewCheckBoxColumn});
            this.dgvCarreras.ContextMenuStrip = this.menu;
            this.dgvCarreras.DataSource = this.carrerasTableBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarreras.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCarreras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCarreras.Location = new System.Drawing.Point(20, 143);
            this.dgvCarreras.Name = "dgvCarreras";
            this.dgvCarreras.ReadOnly = true;
            this.dgvCarreras.RowHeadersVisible = false;
            this.dgvCarreras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarreras.Size = new System.Drawing.Size(760, 278);
            this.dgvCarreras.TabIndex = 7;
            // 
            // idcarreraDataGridViewTextBoxColumn
            // 
            this.idcarreraDataGridViewTextBoxColumn.DataPropertyName = "Id_carrera";
            this.idcarreraDataGridViewTextBoxColumn.HeaderText = "No.";
            this.idcarreraDataGridViewTextBoxColumn.Name = "idcarreraDataGridViewTextBoxColumn";
            this.idcarreraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notransaccionDataGridViewTextBoxColumn
            // 
            this.notransaccionDataGridViewTextBoxColumn.DataPropertyName = "No_transaccion";
            this.notransaccionDataGridViewTextBoxColumn.HeaderText = "No. Trs.";
            this.notransaccionDataGridViewTextBoxColumn.Name = "notransaccionDataGridViewTextBoxColumn";
            this.notransaccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conductorDataGridViewTextBoxColumn
            // 
            this.conductorDataGridViewTextBoxColumn.DataPropertyName = "Conductor";
            this.conductorDataGridViewTextBoxColumn.HeaderText = "Conductor";
            this.conductorDataGridViewTextBoxColumn.Name = "conductorDataGridViewTextBoxColumn";
            this.conductorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Placa";
            this.dataGridViewTextBoxColumn1.HeaderText = "Placa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // horaSalidaDataGridViewTextBoxColumn
            // 
            this.horaSalidaDataGridViewTextBoxColumn.DataPropertyName = "HoraSalida";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.horaSalidaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.horaSalidaDataGridViewTextBoxColumn.HeaderText = "Salida";
            this.horaSalidaDataGridViewTextBoxColumn.Name = "horaSalidaDataGridViewTextBoxColumn";
            this.horaSalidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaSalidaDataGridViewTextBoxColumn.ToolTipText = "Hora de salida";
            // 
            // horaLlegadaDataGridViewTextBoxColumn
            // 
            this.horaLlegadaDataGridViewTextBoxColumn.DataPropertyName = "HoraLlegada";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.horaLlegadaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.horaLlegadaDataGridViewTextBoxColumn.HeaderText = "Llegada";
            this.horaLlegadaDataGridViewTextBoxColumn.Name = "horaLlegadaDataGridViewTextBoxColumn";
            this.horaLlegadaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaLlegadaDataGridViewTextBoxColumn.ToolTipText = "Hora de llegada";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FechaCarrera";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ingresoDataGridViewTextBoxColumn
            // 
            this.ingresoDataGridViewTextBoxColumn.DataPropertyName = "Ingreso";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.ingresoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.ingresoDataGridViewTextBoxColumn.HeaderText = "Ingreso";
            this.ingresoDataGridViewTextBoxColumn.Name = "ingresoDataGridViewTextBoxColumn";
            this.ingresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // completaDataGridViewCheckBoxColumn
            // 
            this.completaDataGridViewCheckBoxColumn.DataPropertyName = "Completa";
            this.completaDataGridViewCheckBoxColumn.HeaderText = "Completa";
            this.completaDataGridViewCheckBoxColumn.Name = "completaDataGridViewCheckBoxColumn";
            this.completaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anularCarreraToolStripMenuItem,
            this.mostrarEgresosToolStripMenuItem,
            this.toolStripSeparator1,
            this.conductorToolStripMenuItem,
            this.socioToolStripMenuItem,
            this.toolStripSeparator2,
            this.copiarToolStripMenuItem});
            this.menu.Name = "Menu";
            this.menu.ShowImageMargin = false;
            this.menu.Size = new System.Drawing.Size(140, 148);
            this.menu.Text = "Operaciones de Registro";
            this.menu.Opening += new System.ComponentModel.CancelEventHandler(this.Menu_Opening);
            // 
            // anularCarreraToolStripMenuItem
            // 
            this.anularCarreraToolStripMenuItem.Name = "anularCarreraToolStripMenuItem";
            this.anularCarreraToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.anularCarreraToolStripMenuItem.Text = "&Anular Carrera";
            this.anularCarreraToolStripMenuItem.Click += new System.EventHandler(this.anularCarreraToolStripMenuItem_Click);
            // 
            // mostrarEgresosToolStripMenuItem
            // 
            this.mostrarEgresosToolStripMenuItem.Name = "mostrarEgresosToolStripMenuItem";
            this.mostrarEgresosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.mostrarEgresosToolStripMenuItem.Text = "&Detalle de Gastos";
            this.mostrarEgresosToolStripMenuItem.Click += new System.EventHandler(this.mostrarEgresosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // conductorToolStripMenuItem
            // 
            this.conductorToolStripMenuItem.Name = "conductorToolStripMenuItem";
            this.conductorToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.conductorToolStripMenuItem.Text = "&Conductor";
            this.conductorToolStripMenuItem.Click += new System.EventHandler(this.conductorToolStripMenuItem_Click);
            // 
            // socioToolStripMenuItem
            // 
            this.socioToolStripMenuItem.Name = "socioToolStripMenuItem";
            this.socioToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.socioToolStripMenuItem.Text = "&Socio";
            this.socioToolStripMenuItem.Click += new System.EventHandler(this.socioToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(136, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // carrerasTableBindingSource
            // 
            this.carrerasTableBindingSource.DataMember = "CarrerasTable";
            this.carrerasTableBindingSource.DataSource = this.transaccionesDataSet;
            // 
            // transaccionesDataSet
            // 
            this.transaccionesDataSet.DataSetName = "TransaccionesDataSet";
            this.transaccionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtFiltroFecha
            // 
            this.dtFiltroFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFiltroFecha.Location = new System.Drawing.Point(204, 71);
            this.dtFiltroFecha.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtFiltroFecha.Name = "dtFiltroFecha";
            this.dtFiltroFecha.Size = new System.Drawing.Size(164, 20);
            this.dtFiltroFecha.TabIndex = 0;
            this.dtFiltroFecha.Value = new System.DateTime(2017, 12, 16, 0, 0, 0, 0);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(176, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Seleccione un filtro de Fecha";
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::CapaVista.Properties.Resources.plus;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(523, 62);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 34);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTrackbar
            // 
            this.lblTrackbar.AutoSize = true;
            this.lblTrackbar.Location = new System.Drawing.Point(23, 107);
            this.lblTrackbar.Name = "lblTrackbar";
            this.lblTrackbar.Size = new System.Drawing.Size(113, 19);
            this.lblTrackbar.TabIndex = 6;
            this.lblTrackbar.Text = "Cantidad Maxima";
            // 
            // tbNumeroRegistros
            // 
            this.tbNumeroRegistros.BackColor = System.Drawing.Color.Gray;
            this.tbNumeroRegistros.Location = new System.Drawing.Point(204, 107);
            this.tbNumeroRegistros.Name = "tbNumeroRegistros";
            this.tbNumeroRegistros.Size = new System.Drawing.Size(126, 19);
            this.tbNumeroRegistros.TabIndex = 1;
            this.tbNumeroRegistros.Text = "No Registros";
            this.tbNumeroRegistros.Value = 20;
            this.tbNumeroRegistros.ValueChanged += new System.EventHandler(this.tbNumeroRegistros_ValueChanged);
            // 
            // lblTrackValue
            // 
            this.lblTrackValue.AutoSize = true;
            this.lblTrackValue.Location = new System.Drawing.Point(345, 107);
            this.lblTrackValue.Name = "lblTrackValue";
            this.lblTrackValue.Size = new System.Drawing.Size(23, 19);
            this.lblTrackValue.TabIndex = 8;
            this.lblTrackValue.Text = "20";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFiltrar.Image = global::CapaVista.Properties.Resources.exchange_1_;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(374, 63);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(134, 34);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar Resultados";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblRestablecer
            // 
            this.lblRestablecer.Location = new System.Drawing.Point(396, 103);
            this.lblRestablecer.Name = "lblRestablecer";
            this.lblRestablecer.Size = new System.Drawing.Size(112, 23);
            this.lblRestablecer.TabIndex = 3;
            this.lblRestablecer.Text = "Mostrar Todas";
            this.lblRestablecer.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblRestablecer.UseStyleColors = true;
            this.lblRestablecer.Click += new System.EventHandler(this.lblRestablecer_Click);
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(646, 34);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(133, 23);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User";
            // 
            // carrerasTableTableAdapter
            // 
            this.carrerasTableTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(619, 51);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 58);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblRestablecer);
            this.Controls.Add(this.lblTrackValue);
            this.Controls.Add(this.tbNumeroRegistros);
            this.Controls.Add(this.lblTrackbar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtFiltroFecha);
            this.Controls.Add(this.dgvCarreras);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Carreras";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.ShowInTaskbar = false;
            this.Text = "Carreras";
            this.Load += new System.EventHandler(this.Carreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carrerasTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarreras;
        public System.Windows.Forms.DateTimePicker dtFiltroFecha;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnAgregar;
        private MetroFramework.Controls.MetroLabel lblTrackbar;
        private MetroFramework.Controls.MetroTrackBar tbNumeroRegistros;
        private MetroFramework.Controls.MetroLabel lblTrackValue;
        private System.Windows.Forms.Button btnFiltrar;
        private MetroFramework.Controls.MetroLink lblRestablecer;
        private MetroFramework.Controls.MetroLink lblUser;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem anularCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEgresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conductorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        //private System.Windows.Forms.DataGridViewTextBoxColumn numeroCarreraDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn fechaCarreraDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn vueltaCompletaDataGridViewCheckBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ingresoTotalDataGridViewTextBoxColumn;
        private TransaccionesDataSet transaccionesDataSet;
        private System.Windows.Forms.BindingSource carrerasTableBindingSource;
        private TransaccionesDataSetTableAdapters.CarrerasTableTableAdapter carrerasTableTableAdapter;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcarreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conductorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaLlegadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completaDataGridViewCheckBoxColumn;
    }
}