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
using MetroFramework.Forms;

namespace CapaVista.Creditos
{
    public partial class Creditos_form : MetroForm
    {
        public Creditos_form()
        {
            InitializeComponent();
            newInstanceCreditosTable();
            obtenerCreditos(CreditoController.Listar());
        }
        List<CapaDatos.Credito> datos = null;
        private DataTable CreditosTable = null;
        private void obtenerCreditos(List<CapaDatos.Credito> datos)
        {
            
            //Poblando la tabla
            foreach (var item in datos)
            {
                var fila = CreditosTable.NewRow();
                fila["Factura"] = item.Detalle.IdTransaccion;
                fila["Placa"] = item.Detalle.Transaccion.Vehiculo.Placa;
                fila["Fecha"] = item.Detalle.Transaccion.FechaTransaccion;
                fila["Monto"] = item.Detalle.Cantidad;
                fila["Saldo"] = item.saldo;
                fila["Abonos"] = item.Abono.Count();
                fila["Cancelado"] = item.cancelado;

                CreditosTable.Rows.Add(fila);
            }
            //Seteando al datagrid
            dgvCreditos.DataSource = CreditosTable;
            dgvCreditos.Refresh();
            Refresh();
        }
        private void Creditos_Load(object sender, EventArgs e)
        {
            //Cargar Combo rubros
            cboRubros.DataSource = TipoDetalleController.listar();
        }
        private void newInstanceCreditosTable()
        {
            //Generando instancia de Tabla
            CreditosTable = new DataTable("Creditos");
            //Generando Columnas
            CreditosTable.Columns.Add(new DataColumn { ColumnName = "Factura", Caption="Factura", DataType = typeof(Int32), ReadOnly = true});
            CreditosTable.Columns.Add(new DataColumn { ColumnName = "Placa", Caption = "Placa", DataType = typeof(Int32), ReadOnly = true });
            CreditosTable.Columns.Add(new DataColumn { ColumnName = "Fecha", Caption = "Fecha", DataType = typeof(DateTime), ReadOnly = true });
            CreditosTable.Columns.Add(new DataColumn { ColumnName = "Monto", Caption = "Monto", DataType = typeof(Decimal), ReadOnly = true });
            CreditosTable.Columns.Add(new DataColumn { ColumnName = "Saldo", Caption = "Saldo", DataType = typeof(Decimal), ReadOnly = true });
            CreditosTable.Columns.Add(new DataColumn { ColumnName = "Abonos", Caption = "Abonos", DataType = typeof(Int32), ReadOnly = true });
            CreditosTable.Columns.Add(new DataColumn { ColumnName = "Cancelado", Caption = "Cancelado", DataType = typeof(Boolean), ReadOnly = true });

        }

        private void cboRubros_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerCreditos(CreditoController.Listar(obtenerCbo().IdTipoDetalle, dtFecha.Value));
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            cboRubros_SelectedIndexChanged(sender, e);
        }
        private CapaDatos.TipoDetalle obtenerCbo()
        {
            return (CapaDatos.TipoDetalle)cboRubros.SelectedItem;
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<CapaDatos.Credito> lista = CreditoController.Listar()
                .Where(x =>
               x.Detalle.Transaccion.FechaTransaccion >= dtFecha1.Value.Date &&
               x.Detalle.Transaccion.FechaTransaccion <= dtFecha2.Value.Date
                ).ToList();
            obtenerCreditos(lista);
        }

        private void ctxMenu_Opening(object sender, CancelEventArgs e)
        {
            //Verificar que se haya seleccionado una fila
            if (dgvCreditos.SelectedRows.Count < 1)
                ctxMenu.Enabled = false;
            else
                ctxMenu.Enabled = true;
        }
    }
}
