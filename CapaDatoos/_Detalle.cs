using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class _Detalle
    {
        /// <summary>
        /// Representa un objeto Detalle
        /// </summary>
        private Detalle det;


        /// <summary>
        /// Representa el conductor de la clase _Detalle
        /// </summary>
        /// <param name="det">Representa un objeto tipo detalle</param>
        public _Detalle(Detalle det)
        {
            this.det = det;
        }


        /// <summary>
        /// Representa el constructor vacio de la clase _Detalle
        /// </summary>
        public _Detalle()
        { }


        /// <summary>
        /// Permite agregar un nuevo detalle de una transaccion especifica
        /// </summary>
        /// <returns>1 en caso de tener exito, -1 en caso contrario</returns>
        public int agregar()
        { 
            int result = -1;
            using (var db = new ModeloContainer())
            {
                try
                {
                    var temp = db.TransaccionSet.First(x => x.IdTransaccion == det.IdTransaccion);
                    if (temp == null)
                        throw new Exception("El numero de transaccion ingresado no existe");
                    else
                    {
                        db.DetalleSet.Add(det);
                        result = db.SaveChanges();
                        //Si es un credito actualizamos la tabla de los creditos
                        if((bool)det.credito)
                        {
                            //Obtenemos el ultimo detalle agregado
                            int ultimo = (from item in db.DetalleSet orderby item.IdDetalle descending select item).First().IdDetalle;
                            //Agregamos a la tabla de creditos
                            var credito = new _Credito(
                                new Credito { id_detalle = ultimo, saldo = det.Cantidad, anulado = false, cancelado = false}
                                );
                            result = credito.agregar();
                        }
                    }
                }
                catch (Exception ex)
                {
                    result = -1;
                    throw new Exception("No se pudo ingresar el elemento", ex);
                }                
            }
            return result;            
        }


        /// <summary>
        /// Permite anular un detalle existente
        /// </summary>
        /// <returns>1 si tiene exito, -1 en caso contario</returns>
        public int anular()
        {
            int result = -1;
            using (var db = new ModeloContainer())
            {
                try
                {
                    var temp = (from u in db.DetalleSet where u.IdDetalle == det.IdDetalle select u).First();
                    temp.Activo = false;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new Exception("No se pudo insertar el elemento", ex);
                }
            }
            return result;
        }


        /// <summary>
        /// Permite listar detalles de transacciones deacuerdo a una transaccion
        /// </summary>
        /// <returns> Devuelve una lista de objetos Detalle</returns>
        public List<Detalle> listar()
        {
            List<Detalle> lista = null;
            var db = new ModeloContainer();
            {                
                lista = (from u in db.DetalleSet where u.IdTransaccion == det.IdTransaccion select u).ToList();
            }
            return lista;
        }


        /// <summary>
        /// Permite leer un detalle
        /// </summary>
        /// <returns>Devuelve un detalle en especifico</returns>
        public Detalle leer()
        {
            Detalle temp = null;
            using (var db = new ModeloContainer())
            {
                temp = (from u in db.DetalleSet where u.IdDetalle == det.IdDetalle select u).FirstOrDefault();
            }
            return temp;
        }
    }
}
