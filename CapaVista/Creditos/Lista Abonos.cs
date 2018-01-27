using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using MetroFramework.Forms;
using CapaControlador;

namespace CapaVista.Creditos
{
    public partial class Lista_Abonos : MetroForm
    {
        private Transaccion data;
        private DataTable AbonosTable;
        public Lista_Abonos(Transaccion data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void Lista_Abonos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                AbonosTable = new DataTable("Abonos");
                //Agregando columnas
                AbonosTable.Columns.Add("Factura", typeof(int));
                AbonosTable.Columns.Add("Fecha", typeof(DateTime));
                AbonosTable.Columns.Add("Cajero", typeof(String));
                AbonosTable.Columns.Add("Monto", typeof(Decimal));
                AbonosTable.Columns.Add("Saldo_Por_Abono", typeof(Decimal));
                //Obteniendo datos y llenando la tabla
                lblFactura.Text = data.IdTransaccion.ToString();
                lblFecha.Text = data.FechaTransaccion.ToShortDateString();
                lblCajero.Text = UsuariosController.leer(data.Id_usuario).ToString();
                lblMonto.Text = string.Format("{0:C2}", 
                    data.Egreso.FirstOrDefault(x=> x.TipoTransaccion == 2).Cantidad
                    );
                lblPlaca.Text = data.Vehiculo.Placa;
                lblRubro.Text = data.Egreso.FirstOrDefault(x => x.TipoTransaccion == 2).TipoEgreso.Descripcion;

                foreach (var item in data.Abono)
                {
                    var row = AbonosTable.NewRow();
                    row["Factura"] = item.Id_transaccion;
                    row["Fecha"] = item.Transaccion.FechaTransaccion;
                    row["Cajero"] = UsuariosController.leer(item.Transaccion.Id_usuario).ToString();
                    row["Monto"] = item.Monto;
                    row["Saldo_Por_Abono"] = item.Detalle.Cantidad - item.Monto;
                }
                //Estableciendo la fuente de datos para el grid
                dgvAbonos.DataSource = AbonosTable;
                dgvAbonos.Columns["Monto"].DefaultCellStyle.Format = "C2";
                dgvAbonos.Columns["Saldo_Por_Abono"].DefaultCellStyle.Format = "C2";

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
