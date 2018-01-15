namespace CapaVista
{
    partial class MainContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainContainer));
            this.mpPanelPrincipal = new MetroFramework.Controls.MetroPanel();
            this.btnAyuda = new MetroFramework.Controls.MetroTile();
            this.btnTransacciones = new MetroFramework.Controls.MetroTile();
            this.btnSalir = new MetroFramework.Controls.MetroTile();
            this.btnTools = new MetroFramework.Controls.MetroTile();
            this.btnLogout = new MetroFramework.Controls.MetroTile();
            this.btnCarreras = new MetroFramework.Controls.MetroTile();
            this.btnBuses = new MetroFramework.Controls.MetroTile();
            this.btnConductores = new MetroFramework.Controls.MetroTile();
            this.btnSocios = new MetroFramework.Controls.MetroTile();
            this.btnUsuarios = new MetroFramework.Controls.MetroTile();
            this.mpPanelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpPanelPrincipal
            // 
            this.mpPanelPrincipal.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mpPanelPrincipal.Controls.Add(this.btnAyuda);
            this.mpPanelPrincipal.Controls.Add(this.btnTransacciones);
            this.mpPanelPrincipal.Controls.Add(this.btnSalir);
            this.mpPanelPrincipal.Controls.Add(this.btnTools);
            this.mpPanelPrincipal.Controls.Add(this.btnLogout);
            this.mpPanelPrincipal.Controls.Add(this.btnCarreras);
            this.mpPanelPrincipal.Controls.Add(this.btnBuses);
            this.mpPanelPrincipal.Controls.Add(this.btnConductores);
            this.mpPanelPrincipal.Controls.Add(this.btnSocios);
            this.mpPanelPrincipal.Controls.Add(this.btnUsuarios);
            this.mpPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpPanelPrincipal.HorizontalScrollbarBarColor = true;
            this.mpPanelPrincipal.HorizontalScrollbarHighlightOnWheel = false;
            this.mpPanelPrincipal.HorizontalScrollbarSize = 10;
            this.mpPanelPrincipal.Location = new System.Drawing.Point(20, 60);
            this.mpPanelPrincipal.Name = "mpPanelPrincipal";
            this.mpPanelPrincipal.Size = new System.Drawing.Size(971, 379);
            this.mpPanelPrincipal.Style = MetroFramework.MetroColorStyle.Orange;
            this.mpPanelPrincipal.TabIndex = 0;
            this.mpPanelPrincipal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mpPanelPrincipal.VerticalScrollbarBarColor = true;
            this.mpPanelPrincipal.VerticalScrollbarHighlightOnWheel = false;
            this.mpPanelPrincipal.VerticalScrollbarSize = 10;
            // 
            // btnAyuda
            // 
            this.btnAyuda.CustomForeColor = true;
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAyuda.Location = new System.Drawing.Point(779, 3);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(188, 181);
            this.btnAyuda.Style = MetroFramework.MetroColorStyle.White;
            this.btnAyuda.TabIndex = 10;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAyuda.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAyuda.TileImage = global::CapaVista.Properties.Resources.AYUDA;
            this.btnAyuda.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAyuda.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAyuda.UseTileImage = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnTransacciones
            // 
            this.btnTransacciones.Location = new System.Drawing.Point(392, 190);
            this.btnTransacciones.Name = "btnTransacciones";
            this.btnTransacciones.Size = new System.Drawing.Size(188, 181);
            this.btnTransacciones.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnTransacciones.TabIndex = 9;
            this.btnTransacciones.Text = "Transacciones";
            this.btnTransacciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransacciones.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnTransacciones.TileImage = global::CapaVista.Properties.Resources.payment;
            this.btnTransacciones.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTransacciones.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnTransacciones.UseTileImage = true;
            this.btnTransacciones.Click += new System.EventHandler(this.btnTransacciones_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(780, 190);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 181);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSalir.TileImage = global::CapaVista.Properties.Resources.door_2_;
            this.btnSalir.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnSalir.UseTileImage = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTools
            // 
            this.btnTools.Location = new System.Drawing.Point(585, 3);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(188, 181);
            this.btnTools.TabIndex = 8;
            this.btnTools.Text = "Herramientas";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTools.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnTools.TileImage = global::CapaVista.Properties.Resources.settings;
            this.btnTools.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTools.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnTools.UseTileImage = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(586, 190);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(188, 181);
            this.btnLogout.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Cambiar de Usuario";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLogout.TileImage = global::CapaVista.Properties.Resources.icon;
            this.btnLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnLogout.UseTileImage = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCarreras
            // 
            this.btnCarreras.Location = new System.Drawing.Point(391, 3);
            this.btnCarreras.Name = "btnCarreras";
            this.btnCarreras.Size = new System.Drawing.Size(188, 181);
            this.btnCarreras.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnCarreras.TabIndex = 2;
            this.btnCarreras.Text = "Carreras";
            this.btnCarreras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarreras.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCarreras.TileImage = global::CapaVista.Properties.Resources.road;
            this.btnCarreras.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCarreras.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCarreras.UseTileImage = true;
            this.btnCarreras.Click += new System.EventHandler(this.btnCarreras_Click);
            // 
            // btnBuses
            // 
            this.btnBuses.Location = new System.Drawing.Point(197, 190);
            this.btnBuses.Name = "btnBuses";
            this.btnBuses.Size = new System.Drawing.Size(188, 181);
            this.btnBuses.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnBuses.TabIndex = 4;
            this.btnBuses.Text = "Vehiculos";
            this.btnBuses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuses.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBuses.TileImage = global::CapaVista.Properties.Resources.school_bus_1_;
            this.btnBuses.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuses.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnBuses.UseTileImage = true;
            this.btnBuses.Click += new System.EventHandler(this.btnBuses_Click);
            // 
            // btnConductores
            // 
            this.btnConductores.Location = new System.Drawing.Point(3, 190);
            this.btnConductores.Name = "btnConductores";
            this.btnConductores.Size = new System.Drawing.Size(188, 181);
            this.btnConductores.Style = MetroFramework.MetroColorStyle.Green;
            this.btnConductores.TabIndex = 3;
            this.btnConductores.Text = "Conductores";
            this.btnConductores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConductores.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnConductores.TileImage = global::CapaVista.Properties.Resources.driver;
            this.btnConductores.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConductores.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnConductores.UseTileImage = true;
            this.btnConductores.Click += new System.EventHandler(this.btnConductores_Click);
            // 
            // btnSocios
            // 
            this.btnSocios.Location = new System.Drawing.Point(197, 3);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Size = new System.Drawing.Size(188, 181);
            this.btnSocios.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSocios.TabIndex = 1;
            this.btnSocios.Text = "Socios";
            this.btnSocios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSocios.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSocios.TileImage = global::CapaVista.Properties.Resources.teamwork;
            this.btnSocios.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSocios.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnSocios.UseTileImage = true;
            this.btnSocios.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(3, 3);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(188, 181);
            this.btnUsuarios.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnUsuarios.TileImage = global::CapaVista.Properties.Resources.student128x128;
            this.btnUsuarios.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUsuarios.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnUsuarios.UseTileImage = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // MainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 459);
            this.Controls.Add(this.mpPanelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainContainer";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Text = "COOTRACOSAN";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.MainContainer_Load);
            this.mpPanelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpPanelPrincipal;
        private MetroFramework.Controls.MetroTile btnUsuarios;
        private MetroFramework.Controls.MetroTile btnBuses;
        private MetroFramework.Controls.MetroTile btnConductores;
        private MetroFramework.Controls.MetroTile btnSocios;
        private MetroFramework.Controls.MetroTile btnCarreras;
        private MetroFramework.Controls.MetroTile btnTools;
        private MetroFramework.Controls.MetroTile btnTransacciones;
        private MetroFramework.Controls.MetroTile btnSalir;
        private MetroFramework.Controls.MetroTile btnLogout;
        private MetroFramework.Controls.MetroTile btnAyuda;
    }
}