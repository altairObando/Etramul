namespace CapaVista.Conductores
{
    partial class MenuConductores
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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Vehiculos Activos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Vehiculos Inactivos", System.Windows.Forms.HorizontalAlignment.Left);
            this.Imagenes = new System.Windows.Forms.ImageList(this.components);
            this.listaVehiculos = new System.Windows.Forms.ListView();
            this.OpcionesVehiculos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.marcarComoInactivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarPlacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ultimaCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHoyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtpOperacionesGenerales = new MetroFramework.Controls.MetroPanel();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSocios = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lbltitulo = new MetroFramework.Controls.MetroLabel();
            this.OpcionesVehiculos.SuspendLayout();
            this.mtpOperacionesGenerales.SuspendLayout();
            this.SuspendLayout();
            // 
            // Imagenes
            // 
            this.Imagenes.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.Imagenes.ImageSize = new System.Drawing.Size(64, 64);
            this.Imagenes.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listaVehiculos
            // 
            this.listaVehiculos.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listaVehiculos.BackgroundImageTiled = true;
            this.listaVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaVehiculos.ContextMenuStrip = this.OpcionesVehiculos;
            this.listaVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaVehiculos.GridLines = true;
            listViewGroup3.Header = "Vehiculos Activos";
            listViewGroup3.Name = "activos";
            listViewGroup4.Header = "Vehiculos Inactivos";
            listViewGroup4.Name = "inactivos";
            this.listaVehiculos.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.listaVehiculos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaVehiculos.LabelWrap = false;
            this.listaVehiculos.LargeImageList = this.Imagenes;
            this.listaVehiculos.Location = new System.Drawing.Point(20, 129);
            this.listaVehiculos.MultiSelect = false;
            this.listaVehiculos.Name = "listaVehiculos";
            this.listaVehiculos.ShowItemToolTips = true;
            this.listaVehiculos.Size = new System.Drawing.Size(960, 472);
            this.listaVehiculos.SmallImageList = this.Imagenes;
            this.listaVehiculos.TabIndex = 1;
            this.listaVehiculos.TileSize = new System.Drawing.Size(256, 256);
            this.listaVehiculos.UseCompatibleStateImageBehavior = false;
            this.listaVehiculos.ItemActivate += new System.EventHandler(this.listaVehiculos_ItemActivate);
            // 
            // OpcionesVehiculos
            // 
            this.OpcionesVehiculos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcarComoInactivoToolStripMenuItem,
            this.copiarPlacaToolStripMenuItem,
            this.detallesToolStripMenuItem,
            this.toolStripSeparator1,
            this.ultimaCarreraToolStripMenuItem,
            this.verHoyToolStripMenuItem,
            this.transaccionesToolStripMenuItem});
            this.OpcionesVehiculos.Name = "contextVehiculos";
            this.OpcionesVehiculos.Size = new System.Drawing.Size(196, 142);
            this.OpcionesVehiculos.Opening += new System.ComponentModel.CancelEventHandler(this.contextVehiculos_Opening);
            // 
            // marcarComoInactivoToolStripMenuItem
            // 
            this.marcarComoInactivoToolStripMenuItem.Name = "marcarComoInactivoToolStripMenuItem";
            this.marcarComoInactivoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.marcarComoInactivoToolStripMenuItem.Text = "&Marcar Activo/Inactivo";
            this.marcarComoInactivoToolStripMenuItem.Click += new System.EventHandler(this.marcarComoInactivoToolStripMenuItem_Click);
            // 
            // copiarPlacaToolStripMenuItem
            // 
            this.copiarPlacaToolStripMenuItem.Name = "copiarPlacaToolStripMenuItem";
            this.copiarPlacaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.copiarPlacaToolStripMenuItem.Text = "&Copiar Placa";
            this.copiarPlacaToolStripMenuItem.Click += new System.EventHandler(this.copiarPlacaToolStripMenuItem_Click);
            // 
            // detallesToolStripMenuItem
            // 
            this.detallesToolStripMenuItem.Name = "detallesToolStripMenuItem";
            this.detallesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.detallesToolStripMenuItem.Text = "&Detalles";
            this.detallesToolStripMenuItem.Click += new System.EventHandler(this.detallesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // ultimaCarreraToolStripMenuItem
            // 
            this.ultimaCarreraToolStripMenuItem.Name = "ultimaCarreraToolStripMenuItem";
            this.ultimaCarreraToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ultimaCarreraToolStripMenuItem.Text = "&Ultima carrera";
            this.ultimaCarreraToolStripMenuItem.Click += new System.EventHandler(this.ultimaCarreraToolStripMenuItem_Click);
            // 
            // verHoyToolStripMenuItem
            // 
            this.verHoyToolStripMenuItem.Name = "verHoyToolStripMenuItem";
            this.verHoyToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.verHoyToolStripMenuItem.Text = "Ver hoy";
            this.verHoyToolStripMenuItem.Click += new System.EventHandler(this.verHoyToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.transaccionesToolStripMenuItem.Text = "&Transacciones";
            this.transaccionesToolStripMenuItem.Click += new System.EventHandler(this.transaccionesToolStripMenuItem_Click);
            // 
            // mtpOperacionesGenerales
            // 
            this.mtpOperacionesGenerales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtpOperacionesGenerales.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.mtpOperacionesGenerales.Controls.Add(this.btnGastos);
            this.mtpOperacionesGenerales.Controls.Add(this.btnReload);
            this.mtpOperacionesGenerales.Controls.Add(this.btnTotal);
            this.mtpOperacionesGenerales.Controls.Add(this.btnSalir);
            this.mtpOperacionesGenerales.Controls.Add(this.btnSocios);
            this.mtpOperacionesGenerales.Controls.Add(this.btnModificar);
            this.mtpOperacionesGenerales.Controls.Add(this.btnNuevo);
            this.mtpOperacionesGenerales.Controls.Add(this.lbltitulo);
            this.mtpOperacionesGenerales.HorizontalScrollbarBarColor = true;
            this.mtpOperacionesGenerales.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpOperacionesGenerales.HorizontalScrollbarSize = 10;
            this.mtpOperacionesGenerales.Location = new System.Drawing.Point(74, 63);
            this.mtpOperacionesGenerales.Name = "mtpOperacionesGenerales";
            this.mtpOperacionesGenerales.Size = new System.Drawing.Size(833, 60);
            this.mtpOperacionesGenerales.TabIndex = 0;
            this.mtpOperacionesGenerales.VerticalScrollbarBarColor = true;
            this.mtpOperacionesGenerales.VerticalScrollbarHighlightOnWheel = false;
            this.mtpOperacionesGenerales.VerticalScrollbarSize = 10;
            // 
            // btnGastos
            // 
            this.btnGastos.FlatAppearance.BorderSize = 0;
            this.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastos.Image = global::CapaVista.Properties.Resources.payment1;
            this.btnGastos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGastos.Location = new System.Drawing.Point(510, 3);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(85, 54);
            this.btnGastos.TabIndex = 6;
            this.btnGastos.Text = "Gastos Rubro";
            this.btnGastos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGastos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnReload
            // 
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Image = global::CapaVista.Properties.Resources.exchange_1_;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReload.Location = new System.Drawing.Point(612, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(85, 54);
            this.btnReload.TabIndex = 7;
            this.btnReload.Text = "Actualizar";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.FlatAppearance.BorderSize = 0;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.Image = global::CapaVista.Properties.Resources.payment1;
            this.btnTotal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTotal.Location = new System.Drawing.Point(393, 3);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(85, 54);
            this.btnTotal.TabIndex = 5;
            this.btnTotal.Text = "Ingresos Hoy";
            this.btnTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::CapaVista.Properties.Resources.close_button;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(726, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 54);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSocios
            // 
            this.btnSocios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSocios.FlatAppearance.BorderSize = 0;
            this.btnSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocios.Image = global::CapaVista.Properties.Resources.teamwork1;
            this.btnSocios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSocios.Location = new System.Drawing.Point(300, 3);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Size = new System.Drawing.Size(75, 54);
            this.btnSocios.TabIndex = 3;
            this.btnSocios.Text = "Socios";
            this.btnSocios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSocios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSocios.UseVisualStyleBackColor = true;
            this.btnSocios.Click += new System.EventHandler(this.btnSocios_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Image = global::CapaVista.Properties.Resources.file;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.Location = new System.Drawing.Point(208, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 54);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::CapaVista.Properties.Resources.plus;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(117, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 54);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(3, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(87, 38);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Operaciones \r\ncon Vehiculos";
            // 
            // MenuConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(998, 613);
            this.Controls.Add(this.mtpOperacionesGenerales);
            this.Controls.Add(this.listaVehiculos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuConductores";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.MenuConductores_Load);
            this.OpcionesVehiculos.ResumeLayout(false);
            this.mtpOperacionesGenerales.ResumeLayout(false);
            this.mtpOperacionesGenerales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listaVehiculos;
        private System.Windows.Forms.ContextMenuStrip OpcionesVehiculos;
        private System.Windows.Forms.ToolStripMenuItem marcarComoInactivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultimaCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesToolStripMenuItem;
        public System.Windows.Forms.ImageList Imagenes;
        private MetroFramework.Controls.MetroPanel mtpOperacionesGenerales;
        private MetroFramework.Controls.MetroLabel lbltitulo;
        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarPlacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem verHoyToolStripMenuItem;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnGastos;

    }
}