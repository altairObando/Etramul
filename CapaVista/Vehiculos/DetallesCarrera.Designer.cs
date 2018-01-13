namespace CapaVista.Vehiculos
{
    partial class DetallesCarrera
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
            this.paneldetalles = new MetroFramework.Controls.MetroPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.gbtransact = new System.Windows.Forms.GroupBox();
            this.tvGastos = new System.Windows.Forms.TreeView();
            this.lblIngreso = new MetroFramework.Controls.MetroLabel();
            this.lblCajero = new MetroFramework.Controls.MetroLabel();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.mlblGastoTotal = new MetroFramework.Controls.MetroLabel();
            this.mlblIngreso = new MetroFramework.Controls.MetroLabel();
            this.mlblCajero = new MetroFramework.Controls.MetroLabel();
            this.mlblCodigo = new MetroFramework.Controls.MetroLabel();
            this.gbbasic = new System.Windows.Forms.GroupBox();
            this.lblLlegada = new MetroFramework.Controls.MetroLabel();
            this.lblSalida = new MetroFramework.Controls.MetroLabel();
            this.lblFecha = new MetroFramework.Controls.MetroLabel();
            this.lblConductor = new MetroFramework.Controls.MetroLabel();
            this.lblCarrera = new MetroFramework.Controls.MetroLabel();
            this.mlblLlegada = new MetroFramework.Controls.MetroLabel();
            this.mlblSalida = new MetroFramework.Controls.MetroLabel();
            this.mlblFecha = new MetroFramework.Controls.MetroLabel();
            this.mlblConductor = new MetroFramework.Controls.MetroLabel();
            this.mlblCarrera = new MetroFramework.Controls.MetroLabel();
            this.lblanulada = new MetroFramework.Controls.MetroLabel();
            this.paneldetalles.SuspendLayout();
            this.gbtransact.SuspendLayout();
            this.gbbasic.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldetalles
            // 
            this.paneldetalles.AutoSize = true;
            this.paneldetalles.Controls.Add(this.button1);
            this.paneldetalles.Controls.Add(this.gbtransact);
            this.paneldetalles.Controls.Add(this.gbbasic);
            this.paneldetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldetalles.HorizontalScrollbarBarColor = true;
            this.paneldetalles.HorizontalScrollbarHighlightOnWheel = false;
            this.paneldetalles.HorizontalScrollbarSize = 10;
            this.paneldetalles.Location = new System.Drawing.Point(20, 60);
            this.paneldetalles.Name = "paneldetalles";
            this.paneldetalles.Size = new System.Drawing.Size(318, 432);
            this.paneldetalles.TabIndex = 0;
            this.paneldetalles.VerticalScrollbarBarColor = true;
            this.paneldetalles.VerticalScrollbarHighlightOnWheel = false;
            this.paneldetalles.VerticalScrollbarSize = 10;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CapaVista.Properties.Resources.close_button;
            this.button1.Location = new System.Drawing.Point(170, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbtransact
            // 
            this.gbtransact.AutoSize = true;
            this.gbtransact.Controls.Add(this.tvGastos);
            this.gbtransact.Controls.Add(this.lblIngreso);
            this.gbtransact.Controls.Add(this.lblCajero);
            this.gbtransact.Controls.Add(this.lblCodigo);
            this.gbtransact.Controls.Add(this.mlblGastoTotal);
            this.gbtransact.Controls.Add(this.mlblIngreso);
            this.gbtransact.Controls.Add(this.mlblCajero);
            this.gbtransact.Controls.Add(this.mlblCodigo);
            this.gbtransact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtransact.Location = new System.Drawing.Point(4, 154);
            this.gbtransact.Name = "gbtransact";
            this.gbtransact.Size = new System.Drawing.Size(293, 233);
            this.gbtransact.TabIndex = 1;
            this.gbtransact.TabStop = false;
            this.gbtransact.Text = "Datos de Transaccion";
            // 
            // tvGastos
            // 
            this.tvGastos.Location = new System.Drawing.Point(6, 108);
            this.tvGastos.Name = "tvGastos";
            this.tvGastos.Size = new System.Drawing.Size(281, 97);
            this.tvGastos.TabIndex = 3;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(136, 67);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(55, 19);
            this.lblIngreso.TabIndex = 2;
            this.lblIngreso.Text = "Ingreso:";
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Location = new System.Drawing.Point(136, 48);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(51, 19);
            this.lblCajero.TabIndex = 1;
            this.lblCajero.Text = "Cajero:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(136, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 19);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // mlblGastoTotal
            // 
            this.mlblGastoTotal.AutoSize = true;
            this.mlblGastoTotal.Location = new System.Drawing.Point(6, 86);
            this.mlblGastoTotal.Name = "mlblGastoTotal";
            this.mlblGastoTotal.Size = new System.Drawing.Size(78, 19);
            this.mlblGastoTotal.TabIndex = 8;
            this.mlblGastoTotal.Text = "Gasto Total:";
            // 
            // mlblIngreso
            // 
            this.mlblIngreso.AutoSize = true;
            this.mlblIngreso.Location = new System.Drawing.Point(6, 67);
            this.mlblIngreso.Name = "mlblIngreso";
            this.mlblIngreso.Size = new System.Drawing.Size(55, 19);
            this.mlblIngreso.TabIndex = 7;
            this.mlblIngreso.Text = "Ingreso:";
            // 
            // mlblCajero
            // 
            this.mlblCajero.AutoSize = true;
            this.mlblCajero.Location = new System.Drawing.Point(6, 48);
            this.mlblCajero.Name = "mlblCajero";
            this.mlblCajero.Size = new System.Drawing.Size(51, 19);
            this.mlblCajero.TabIndex = 6;
            this.mlblCajero.Text = "Cajero:";
            // 
            // mlblCodigo
            // 
            this.mlblCodigo.AutoSize = true;
            this.mlblCodigo.Location = new System.Drawing.Point(6, 29);
            this.mlblCodigo.Name = "mlblCodigo";
            this.mlblCodigo.Size = new System.Drawing.Size(56, 19);
            this.mlblCodigo.TabIndex = 5;
            this.mlblCodigo.Text = "Codigo:";
            // 
            // gbbasic
            // 
            this.gbbasic.Controls.Add(this.lblLlegada);
            this.gbbasic.Controls.Add(this.lblSalida);
            this.gbbasic.Controls.Add(this.lblFecha);
            this.gbbasic.Controls.Add(this.lblConductor);
            this.gbbasic.Controls.Add(this.lblCarrera);
            this.gbbasic.Controls.Add(this.mlblLlegada);
            this.gbbasic.Controls.Add(this.mlblSalida);
            this.gbbasic.Controls.Add(this.mlblFecha);
            this.gbbasic.Controls.Add(this.mlblConductor);
            this.gbbasic.Controls.Add(this.mlblCarrera);
            this.gbbasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbbasic.Location = new System.Drawing.Point(4, 3);
            this.gbbasic.Name = "gbbasic";
            this.gbbasic.Size = new System.Drawing.Size(287, 133);
            this.gbbasic.TabIndex = 0;
            this.gbbasic.TabStop = false;
            this.gbbasic.Text = "Datos Basicos";
            // 
            // lblLlegada
            // 
            this.lblLlegada.AccessibleName = "Etiquetas de informacion";
            this.lblLlegada.AutoSize = true;
            this.lblLlegada.Location = new System.Drawing.Point(136, 94);
            this.lblLlegada.Name = "lblLlegada";
            this.lblLlegada.Size = new System.Drawing.Size(91, 19);
            this.lblLlegada.TabIndex = 4;
            this.lblLlegada.Text = "Hora Llegada:";
            // 
            // lblSalida
            // 
            this.lblSalida.AccessibleName = "Etiquetas de informacion";
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(136, 75);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(80, 19);
            this.lblSalida.TabIndex = 3;
            this.lblSalida.Text = "Hora Salida:";
            // 
            // lblFecha
            // 
            this.lblFecha.AccessibleName = "Etiquetas de informacion";
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(136, 56);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 19);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblConductor
            // 
            this.lblConductor.AccessibleName = "Etiquetas de informacion";
            this.lblConductor.AutoSize = true;
            this.lblConductor.Location = new System.Drawing.Point(136, 37);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(74, 19);
            this.lblConductor.TabIndex = 1;
            this.lblConductor.Text = "Conductor:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AccessibleName = "Etiquetas de informacion";
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(136, 18);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(82, 19);
            this.lblCarrera.TabIndex = 0;
            this.lblCarrera.Text = "No. Carrera:";
            // 
            // mlblLlegada
            // 
            this.mlblLlegada.AccessibleName = "EtiquetasComplementaria";
            this.mlblLlegada.AutoSize = true;
            this.mlblLlegada.Location = new System.Drawing.Point(6, 95);
            this.mlblLlegada.Name = "mlblLlegada";
            this.mlblLlegada.Size = new System.Drawing.Size(91, 19);
            this.mlblLlegada.TabIndex = 8;
            this.mlblLlegada.Text = "Hora Llegada:";
            // 
            // mlblSalida
            // 
            this.mlblSalida.AccessibleName = "EtiquetasComplementaria";
            this.mlblSalida.AutoSize = true;
            this.mlblSalida.Location = new System.Drawing.Point(6, 76);
            this.mlblSalida.Name = "mlblSalida";
            this.mlblSalida.Size = new System.Drawing.Size(80, 19);
            this.mlblSalida.TabIndex = 7;
            this.mlblSalida.Text = "Hora Salida:";
            // 
            // mlblFecha
            // 
            this.mlblFecha.AccessibleName = "EtiquetasComplementaria";
            this.mlblFecha.AutoSize = true;
            this.mlblFecha.Location = new System.Drawing.Point(6, 57);
            this.mlblFecha.Name = "mlblFecha";
            this.mlblFecha.Size = new System.Drawing.Size(46, 19);
            this.mlblFecha.TabIndex = 6;
            this.mlblFecha.Text = "Fecha:";
            // 
            // mlblConductor
            // 
            this.mlblConductor.AccessibleName = "EtiquetasComplementaria";
            this.mlblConductor.AutoSize = true;
            this.mlblConductor.Location = new System.Drawing.Point(6, 38);
            this.mlblConductor.Name = "mlblConductor";
            this.mlblConductor.Size = new System.Drawing.Size(74, 19);
            this.mlblConductor.TabIndex = 5;
            this.mlblConductor.Text = "Conductor:";
            // 
            // mlblCarrera
            // 
            this.mlblCarrera.AccessibleName = "EtiquetasComplementaria";
            this.mlblCarrera.AutoSize = true;
            this.mlblCarrera.Location = new System.Drawing.Point(6, 19);
            this.mlblCarrera.Name = "mlblCarrera";
            this.mlblCarrera.Size = new System.Drawing.Size(82, 19);
            this.mlblCarrera.TabIndex = 4;
            this.mlblCarrera.Text = "No. Carrera:";
            // 
            // lblanulada
            // 
            this.lblanulada.AutoSize = true;
            this.lblanulada.ForeColor = System.Drawing.Color.Red;
            this.lblanulada.Location = new System.Drawing.Point(213, 38);
            this.lblanulada.Name = "lblanulada";
            this.lblanulada.Size = new System.Drawing.Size(63, 19);
            this.lblanulada.Style = MetroFramework.MetroColorStyle.Magenta;
            this.lblanulada.TabIndex = 1;
            this.lblanulada.Text = "Anulada*";
            this.lblanulada.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblanulada.UseStyleColors = true;
            // 
            // DetallesCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 512);
            this.Controls.Add(this.lblanulada);
            this.Controls.Add(this.paneldetalles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetallesCarrera";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Detalles Carrera";
            this.Load += new System.EventHandler(this.DetallesCarrera_Load);
            this.paneldetalles.ResumeLayout(false);
            this.paneldetalles.PerformLayout();
            this.gbtransact.ResumeLayout(false);
            this.gbtransact.PerformLayout();
            this.gbbasic.ResumeLayout(false);
            this.gbbasic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel paneldetalles;
        private System.Windows.Forms.GroupBox gbbasic;
        private MetroFramework.Controls.MetroLabel mlblCodigo;
        private MetroFramework.Controls.MetroLabel mlblCarrera;
        private System.Windows.Forms.GroupBox gbtransact;
        private MetroFramework.Controls.MetroLabel mlblFecha;
        private MetroFramework.Controls.MetroLabel mlblConductor;
        private MetroFramework.Controls.MetroLabel mlblSalida;
        private MetroFramework.Controls.MetroLabel mlblLlegada;
        private MetroFramework.Controls.MetroLabel mlblGastoTotal;
        private MetroFramework.Controls.MetroLabel mlblIngreso;
        private MetroFramework.Controls.MetroLabel mlblCajero;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel lblLlegada;
        private MetroFramework.Controls.MetroLabel lblSalida;
        private MetroFramework.Controls.MetroLabel lblFecha;
        private MetroFramework.Controls.MetroLabel lblConductor;
        private MetroFramework.Controls.MetroLabel lblCarrera;
        private MetroFramework.Controls.MetroLabel lblIngreso;
        private MetroFramework.Controls.MetroLabel lblCajero;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private System.Windows.Forms.TreeView tvGastos;
        private MetroFramework.Controls.MetroLabel lblanulada;
    }
}