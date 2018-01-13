using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Reportes
{
    public partial class MenuHerramientas : MetroForm
    {
        public MenuHerramientas()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            var tipo = new FormTipoUsuario();
            tipo.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            var tipo = new Transacciones.TipoDetalle();
            tipo.ShowDialog();
        }
    }
}
