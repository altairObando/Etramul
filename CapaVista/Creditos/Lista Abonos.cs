﻿using System;
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
        private Detalle data;
        private DataTable AbonosTable;
        public Lista_Abonos(Detalle data)
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
                lblFecha.Text = data.Transaccion.FechaTransaccion.ToShortDateString();
                lblCajero.Text = UsuariosController.leer(data.Transaccion.Id_usuario).ToString();
                lblMonto.Text = string.Format("{0:C2}", 
                    data.Transaccion.Egreso.FirstOrDefault(x=> x.TipoTransaccion == 2).Cantidad
                    );
                lblPlaca.Text = data.Transaccion.Vehiculo.Placa;
                lblRubro.Text = data.Transaccion.Egreso.FirstOrDefault(x => x.TipoTransaccion == 2).TipoEgreso.Descripcion;
                decimal saldo = data.Cantidad;
                foreach (var item in data.Abono)
                {
                    var row = AbonosTable.NewRow();
                    row["Factura"] = item.Id_transaccion;
                    row["Fecha"] = item.Transaccion.FechaTransaccion;
                    row["Cajero"] = UsuariosController.leer(item.Transaccion.Id_usuario).ToString();
                    row["Monto"] = item.Monto;
                    saldo -= item.Monto;
                    row["Saldo_Por_Abono"] = (saldo >= 0) ? saldo : 0;
                    AbonosTable.Rows.Add(row);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new Ticket_abonos(data);
                form.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
