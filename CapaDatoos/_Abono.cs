using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class _Abono
    {
        private Abono data;
        public _Abono(Abono data)
        {
            this.data = data;
        }
        public int Agregar()
        {
            int result = -1;
            try
            {
                using (var db = new ModeloContainer())
                {
                    //Guardando el abono
                    db.AbonoSet.Add(data);
                    result = db.SaveChanges();
                    //Actualizando el saldo
                    var saldo = db.Saldo_detalleSet.First(x => x.id_detalle == data.id_detalle);
                    saldo.Saldo -= data.Monto;
                    if(saldo.Saldo <= 0)
                    {
                        var det = db.DetalleSet.First(x => x.IdDetalle == data.id_detalle);
                        det.Cancelado = true;
                    }
                    result = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public List<Abono> getAllAbono()
        {
            //instancia de base de datos
            var db = new ModeloContainer();
            try
            {
                //lectura de todos los abonos
                var list = (from item in db.AbonoSet
                            where item.Transaccion.Activo
                            orderby item.Transaccion.FechaTransaccion descending
                            select item).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db != null && db.Database.Connection.State == System.Data.ConnectionState.Open)
                    db.Database.Connection.Close();
            }
        }

        public Abono leer()
        {
            ModeloContainer db = null;
            try
            {
                db = new ModeloContainer();
                var result = (from item in db.AbonoSet where item.Id_abono.Equals(data.Id_abono) select item).First();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db != null && db.Database.Connection.State == System.Data.ConnectionState.Open)
                    db.Database.Connection.Close();
            }
        }

        public int anular()
        {
            try
            {
                int result = -1;
                using (var db = new ModeloContainer())
                {
                    //Buscando el abono
                    var abono = db.AbonoSet.FirstOrDefault(x => x.Id_abono.Equals(data.Id_abono));
                    if(abono != null)
                    {
                        var transact = db.TransaccionSet.FirstOrDefault(x=> x.IdTransaccion.Equals(abono.Id_transaccion));
                        //Marcamos como anulada
                        transact.Activo = false;
                        //Guardamos los cambios
                        result = db.SaveChanges();
                    }
                }
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
