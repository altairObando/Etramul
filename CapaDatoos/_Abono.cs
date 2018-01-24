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
                    //Obtener el credito
                    var credito = db.CreditoSet.FirstOrDefault(x => x.Id_credito.Equals(data.id_credito));
                    ///Verificar que el credito no haya sido cancelado,
                    if (!credito.cancelado)
                    {//Actualizar el saldo
                        credito.saldo -= data.monto;
                        //Comprobar si ha sido cancelado
                        if (credito.saldo <= 0)
                        {
                            credito.cancelado = true;
                            //Actualizar el detalle para que aparezca como un ingreso
                            //credito.Detalle.credito = false;
                        }
                        //Registrar el abono
                        db.AbonoSet.Add(data);
                        result = db.SaveChanges();
                    }
                    else
                        throw new Exception("Este credito ya ha sido Cancelado");
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Anular()
        {
            int result = -1;
            try
            {
                using (var db = new ModeloContainer())
                {
                    //Buscar el abono por el id;
                    var ab = db.AbonoSet.First(x => x.id_abono.Equals(data.id_abono));
                    //Marcar el abono como anulado
                    ab.anulado = true;
                    //Actualizar el monto del credito
                    ab.Credito.saldo += ab.monto;
                    //Guardar los cambios
                    result = db.SaveChanges();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Abono leer()
        {
            Abono tmp = null;
            try
            {
                var db = new ModeloContainer();
                tmp = (from item in db.AbonoSet where item.id_abono.Equals(data.id_abono) select item).First();
                if (tmp == null)
                    throw new NullReferenceException("El abono no ha sido localizado", new Exception("El id_abono no coincide con ningun elemento en la base de datos"));
                db.Database.Connection.Close();
                return tmp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Abono> getAllAbonos()
        { 
            List<Abono> lista = null;
            try
            {
                var db = new ModeloContainer();
                lista = (from item in db.AbonoSet where !item.anulado select item).ToList();
                db.Database.Connection.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Abono> getAllAbonos(int id_vehiculo)
        {
            List<Abono> lista = null;
            try
            {
                var db = new ModeloContainer();
                lista = (from item in db.AbonoSet where !item.anulado && item.Credito.Detalle.Transaccion.Id_Vehiculo.Equals(id_vehiculo) select item).ToList();
                db.Database.Connection.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
