using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class _Credito
    {
        private Credito data { get; set; }
        public _Credito( Credito data)
        {
            this.data = data;
        }
        public int agregar()
        {
            int result = 0;
            try
            {
                using (var db = new ModeloContainer())
                {
                    db.CreditoSet.Add(data);
                    result = db.SaveChanges();
                }
                return result;
            }
            catch (Exception ex)
            {
                result = 0;
                throw ex;
            }
        }
        public Credito leer()
        {
            Credito tmp = null;
            try
            {
                using (var db = new ModeloContainer())
                {
                    tmp = db.CreditoSet.FirstOrDefault(x => x.Id_credito.Equals(data.Id_credito));
                }
                return tmp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Credito> getAllCredito()
        {
            List<Credito> lista = null;
            try
            {
                var db = new ModeloContainer();
                lista = (from item in db.CreditoSet where !item.anulado select item).ToList();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Credito> getAllCredito(int id_vehiculo)
        {
            List<Credito> lista = null;
            try
            {
                var db = new ModeloContainer();
                lista = (from item in db.CreditoSet where item.Detalle.Transaccion.Id_Vehiculo.Equals(id_vehiculo) select item).ToList();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Credito> getAllCredito(int id_rubro, DateTime fecha)
        {
            List<Credito> lista = null;
            try
            {
                var db = new ModeloContainer();
                lista = (from item in db.CreditoSet
                         where item.Detalle.TipoDetalle.Equals(id_rubro) &&
                         item.Detalle.Transaccion.FechaTransaccion.Date.Equals(fecha)
                         && !item.anulado
                         select item
                         ).ToList();
                if (lista != null)
                    return lista;
                else
                    throw new NullReferenceException("No se han localizado Creditos en base a el rubro solicitado",
                        new Exception("El credito pudo ser anulado?"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Anular()
        {
            int result = 0;
            try
            {
                using (var db = new ModeloContainer())
                {
                    //Obteniendo valor original
                    var tmp = db.CreditoSet.FirstOrDefault(x => x.Id_credito.Equals(data.Id_credito));
                    tmp.anulado = true;
                    result = db.SaveChanges();
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
