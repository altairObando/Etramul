using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using CapaDatos;
using CapaControlador;

namespace CapaVista
{
    public partial class FormTipoUsuario : MetroForm
    {
        public FormTipoUsuario()
        {
            InitializeComponent();
        }

        private void TipoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transaccionesDataSet.TipoUsuarioSet' Puede moverla o quitarla según sea necesario.
            this.tipoUsuarioSetTableAdapter.Fill(this.transaccionesDataSet.TipoUsuarioSet);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.tipoUsuarioSetTableAdapter.Update(transaccionesDataSet.TipoUsuarioSet);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tipoUsuarioSetBindingSource.CancelEdit();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            TipoUsuario_Load(null, null);
        }
    }
}
