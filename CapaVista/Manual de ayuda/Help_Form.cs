using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Manual_de_ayuda
{
    using MetroFramework.Forms;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;

    public partial class Help_Form : MetroForm
    {
        public Help_Form()
        {
            InitializeComponent();
        }

        private void Help_Form_Load(object sender, EventArgs e)
        {
            try
            {
                this.Browser.Navigate(Directory.GetCurrentDirectory() + "\\Manual\\index.htm");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
