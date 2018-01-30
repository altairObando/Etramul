using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using CapaDatos;
using MetroFramework.Forms;

namespace CapaVista.Creditos
{
    public partial class Creditos_form : MetroForm
    {
        /// <summary>
        /// Contendra la secuencia en la cual debe de mostrarse el reporte
        /// haciendo uso de la siguiente tabla de valores
        /// 0 = Todos los creditos por fecha
        /// 1 = Todos los creditos por fecha y rubro
        /// 2 = Todos los creditos Entre fechas
        /// 3 = Todos los creditos entre fechas y rubro
        /// </summary>
        private int ordenImpresion;
        /// <summary>
        /// Reportes almacenados en un arreglo
        /// </summary>
        public Creditos_form()
        {
            InitializeComponent();
            newInstanceCreditosTable();
        }
        private DataTable CreditosTable = null;
        private void Creditos_Load(object sender, EventArgs e)
        {
            //Cargar Combo rubros
            cboRubros.DataSource = TipoDetalleController.listar();
            dgvCreditos.Columns["Monto"].DefaultCellStyle.Format = "C2";
            dgvCreditos.Columns["Saldo"].DefaultCellStyle.Format = "C2";
            check_CheckedChanged(sender, e);
        }
        private void newInstanceCreditosTable()
        {
            //Generando instancia de Tabla
            CreditosTable = new DataTable("Creditos");
            //Generando Columnas
            CreditosTable.Columns.Add(new DataColumn { ColumnName = "Factura", Caption="Factura", DataType = typeof(Int32), ReadOnly = true});
            CreditosTable.Columns.Add(new DataColumn { ColumnName = "Placa", Caption = "Placa", DataType = typeof(String), ReadOnly = true });
            CreditosTable.Columns.Add(new DataColumn { ColumnName = "Fecha", Caption = "Fecha", DataType = typeof(DateTime), ReadOnly = true });
            CreditosTable.Columns.Add(new DataColumn { ColumnName = "Monto", Caption = "Monto", DataType = typeof(Decimal), ReadOnly = true });
            CreditosTable.Columns.Add(new DataColumn { ColumnName = "Saldo", Caption = "Saldo", DataType = typeof(Decimal), ReadOnly = true });
            CreditosTable.Columns.Add(new DataColumn { ColumnName = "Abonos", Caption = "Abonos", DataType = typeof(Int32), ReadOnly = true });
            CreditosTable.Columns.Add(new DataColumn { ColumnName = "Cancelado", Caption = "Cancelado", DataType = typeof(Boolean), ReadOnly = true });

        }
        private void CargarDatos(List<Detalle> lista)
        {
            CreditosTable.Rows.Clear();
            foreach (var item in lista)
            {
                var row = CreditosTable.NewRow();
                row["Factura"] = item.Transaccion.IdTransaccion;
                row["Placa"] = item.Transaccion.Vehiculo.Placa;
                row["Fecha"] = item.Transaccion.FechaTransaccion.Date;
                row["Monto"] = item.Cantidad;
                if (item.Saldo_detalle != null)
                    row["Saldo"] = item.Saldo_detalle.Saldo;
                else
                    row["Saldo"] = item.Cantidad;
                if (item.Abono != null)
                    row["Abonos"] = item.Abono.Count;
                else
                    row["Abonos"] = 0;
                row["Cancelado"] = item.Cancelado;
                CreditosTable.Rows.Add(row);
            }
            dgvCreditos.DataSource = CreditosTable;
        }
        private List<Detalle> obtenerCreditos()
        {
            List<Detalle> lista = null;
            try
            {
                //Obteniendo todos las
                lista = DetalleController.listar(-1).Where(x => x.TipoTransaccion == 2 && x.Activo).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error durante la obtencion de la informacion",ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }
        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            cboRubros_SelectedIndexChanged(sender, e);
        }
        private TipoDetalle obtenerCbo()
        {
            return (TipoDetalle)cboRubros.SelectedItem;
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarDatos(
                obtenerCreditos().
                    Where(x =>
                        x.Transaccion.FechaTransaccion >= dtFecha1.Value.Date &&
                        x.Transaccion.FechaTransaccion <= dtFecha2.Value.Date 
                  /*&&  x.TipoDetalle.Equals(obtenerCbo().IdTipoDetalle)      */
                ).ToList()
                );
            ordenImpresion = 2;
        }
        private void ctxMenu_Opening(object sender, CancelEventArgs e)
        {
            //Verificar que se haya seleccionado una fila
            if (dgvCreditos.SelectedRows.Count < 1)
                ctxMenu.Enabled = false;
            else
                ctxMenu.Enabled = true;
        }
        private void cboRubros_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Detalle> lista;
            if(!check.Checked)
            {
                lista = obtenerCreditos().
                 Where(
                     x =>
                     x.TipoDetalle.Equals(obtenerCbo().IdTipoDetalle) &&
                     x.Transaccion.FechaTransaccion.Equals(dtFecha.Value.Date)
                     ).ToList();
                ordenImpresion = 1;
            }else
            {
                lista = obtenerCreditos().
                 Where(
                     x =>
                     x.TipoDetalle.Equals(obtenerCbo().IdTipoDetalle) &&
                     x.Transaccion.FechaTransaccion >= dtFecha1.Value.Date &&
                     x.Transaccion.FechaTransaccion <= dtFecha2.Value.Date
                     ).ToList();
                ordenImpresion = 3;
            }
            if(lista!= null)
                CargarDatos(lista);
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            CargarDatos(obtenerCreditos().Where(x=> x.Transaccion.FechaTransaccion.Equals(dtFecha.Value.Date)).ToList());
            ordenImpresion = 0;
        }

        private void verDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Obteniendo el indice seleccionado
            int id_transacc = (int)dgvCreditos.SelectedRows[0].Cells[0].Value;
            var transaccion = TransaccionController.leer(id_transacc);
            if (transaccion != null)
            {
                var form = new Lista_Abonos(transaccion);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha localizado dicha factura!", "Error durante la busqueada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            bool band = false;
            if (check.Checked)
                band = true;
            dtFecha.Enabled = !band;
            btnAll.Enabled = !band;
            dtFecha1.Enabled = band;
            dtFecha2.Enabled = band;
            btnFiltrar.Enabled = band;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            switch (ordenImpresion)
            {
                case 0: var form = new Creditos_por_fecha(dtFecha.Value); form.ShowDialog() ;break;
            }
        }
    }
}
