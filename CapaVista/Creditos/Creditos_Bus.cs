using CapaControlador;
using CapaDatos;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace CapaVista.Creditos
{
    public partial class Creditos_Bus : MetroForm
    {
        Vehiculo data;
        public Creditos_Bus(Vehiculo data)
        {
            InitializeComponent();
            this.data = data;
        }
        private void Creditos_Bus_Load(object sender, EventArgs e)
        {
            //Cargar Rubros
            try
            {
                this.creditosDataset.EnforceConstraints = false;
                cboRubros.Items.Add(new TipoDetalle { IdTipoDetalle = 0, Descripcion = "NINGUNO" });
                cboRubros.Items.AddRange(TipoDetalleController.listar().ToArray());
                cboRubros.SelectedIndex = 0;
                //Cargar primera vez el datagrid
                cREDITOS_POR_BUSTableAdapter.Fill(this.creditosDataset.CREDITOS_POR_BUS, data.Id_Vehiculo, dtFecha1.Value, dtFecha2.Value);
                dgDatos.DataSource = cREDITOSPORBUSBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filtro_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtener el rubro
                this.creditosDataset.EnforceConstraints = false;
                TipoDetalle det = (TipoDetalle)cboRubros.SelectedItem;
                if(!det.Descripcion.Equals("NINGUNO"))
                {
                    cREDITOS_POR_BUS_RUBROTableAdapter.Fill(creditosDataset.CREDITOS_POR_BUS_RUBRO, data.Id_Vehiculo,det.IdTipoDetalle, dtFecha1.Value, dtFecha2.Value);
                    dgDatos.DataSource = cREDITOSPORBUSRUBROBindingSource;
                }else
                {
                    cREDITOS_POR_BUSTableAdapter.Fill(this.creditosDataset.CREDITOS_POR_BUS, data.Id_Vehiculo, dtFecha1.Value, dtFecha2.Value);
                    dgDatos.DataSource = cREDITOSPORBUSBindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Durante la conexion");
            }
        }
        private void dgDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var abonos = new Lista_Abonos(DetalleController.leer((int)dgDatos.SelectedRows[0].Cells[1].Value));
            abonos.ShowDialog();
        }

        private void cboRubros_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtro_Click(sender, e);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
