using CapaVista.Reportes;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CapaVista.Vehiculos
{

    public partial class Ver_dia : MetroForm
    {
        CapaDatos.Vehiculo datos;
        private Decimal total = 0;
        private bool fecha_unica;
        public Ver_dia(CapaDatos.Vehiculo datos)
        {
            InitializeComponent();
            this.datos = datos;
        }
        public Ver_dia()
        {

        }
        private void Ver_dia_Load(object sender, EventArgs e)
        {
            cargarPordia();
        }
        private void cargarEntreFechas()
        {
            fecha_unica = false;
            dgvEgresos.Rows.Clear();
            dgvIngresos.Rows.Clear();
            txtUnidad.Text = datos.Placa;
            List<CapaDatos.Transaccion> trans = datos.Transaccion.
                Where(x => x.FechaTransaccion >= dtFechaInicio.Value.Date && 
                           x.FechaTransaccion <= dtFechaFin.Value.Date ).ToList();
            setData(trans);
        }
        public void cargaEntreFechas(DateTime inicio, DateTime fin)
        {
            fecha_unica = false;
            dgvEgresos.Rows.Clear();
            dgvIngresos.Rows.Clear();
            txtUnidad.Text = datos.Placa;
            List<CapaDatos.Transaccion> trans = datos.Transaccion.
                Where(x => x.FechaTransaccion >= inicio.Date &&
                           x.FechaTransaccion <= fin.Date).ToList();
            setData(trans);
        }
        private void setData(List<CapaDatos.Transaccion> trans)
        {
            int i = 0;
            int eg = 0;
            /* Totales */
            decimal ingresos = 0, egresos = 0;
            //Recorriendo transacciones 
            foreach (var item in trans)
            {
                //Recorriendo detalles de transaccion
                foreach (var det in item.Egreso)
                {
                    //Si es un ingreso
                    if (det.TipoTransaccion == 1)
                    {
                        i++;
                        dgvIngresos.Rows.Add(item.IdTransaccion, det.TipoEgreso.Descripcion, det.Cantidad);
                        ingresos += det.Cantidad;
                    }
                    else if(det.TipoTransaccion == 0)
                    {
                        eg++;
                        dgvEgresos.Rows.Add(item.IdTransaccion, det.TipoEgreso.Descripcion, det.Cantidad);
                        egresos += det.Cantidad;
                    }
                }
            }
            setTotales(ingresos, egresos);
        }
        private void cargarPordia()
        {
            fecha_unica = true;
            dgvEgresos.Rows.Clear();
            dgvIngresos.Rows.Clear();
            txtUnidad.Text = datos.Placa;
            //Obteniendo las transacciones del dia
            var trans = datos.Transaccion.Where(x => x.FechaTransaccion.Equals(dtFecha.Value.Date) && x.Activo).ToList();
            setData(trans);
        }
        private void setTotales(decimal ingresos, decimal egresos)
        {
            this.txtIngresos.Text = string.Format("{0:C2}",ingresos);
            this.txtEgresos.Text = string.Format("{0:C2}", egresos);
            total = ingresos - egresos;
            this.txtTotal.Text = string.Format("{0:C2}", total);
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            dgvEgresos.Rows.Clear();
            dgvIngresos.Rows.Clear();
            cargarPordia();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Form reporte = null;
            if (fecha_unica)
            {
                reporte = new ver_hoy_form(datos.Id_Vehiculo, dtFecha.Value, datos.Placa);
            }
            else
            {
                reporte = new VerEntreFechasForm(dtFechaInicio.Value, dtFechaFin.Value, datos.Id_Vehiculo, datos.Placa);
            }
            if(reporte != null)
            {
                reporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se puede realizar la impresion","Error TransactSQL");
            }
        }

        private void lblFiltrar_Click(object sender, EventArgs e)
        {
            cargarEntreFechas();
        }
    }
}
