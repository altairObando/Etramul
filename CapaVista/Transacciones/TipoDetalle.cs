using CapaControlador;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace CapaVista.Transacciones
{
    public partial class TipoDetalle : MetroForm
    {
        public TipoDetalle()
        {
            InitializeComponent();
        }

        private void loadGrid()
        {
            dgvTipoDetalle.Rows.Clear();
            var tmp = TipoDetalleController.listar();
            for (int i = 0; i < tmp.Count; i++)
            {
                dgvTipoDetalle.Rows.Add(tmp[i].IdTipoDetalle, tmp[i].Descripcion);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tipoDetalleSetTableAdapter.Update(transaccionesDataSet.TipoDetalleSet);
        }
        private void TipoDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transaccionesDataSet.TipoDetalleSet' Puede moverla o quitarla según sea necesario.
            this.tipoDetalleSetTableAdapter.Fill(this.transaccionesDataSet.TipoDetalleSet);
        }

        private void btnGuardarCambios(object sender, EventArgs e)
        {
            
            tipoDetalleSetTableAdapter.Update(transaccionesDataSet.TipoDetalleSet);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tipoDetalleSetBindingSource.CancelEdit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            TipoDetalle_Load(null, null);
        }

        private void dgvTipoDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
