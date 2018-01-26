using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaControlador
{
    public static class DetalleController
    {

        /// <summary>
        /// Permite agregar un nuevo detalle de una transacccion
        /// </summary>
        /// <param name="idtransaccion"> Representa el numero de identificacion de una transaccion existente</param>
        /// <param name="IdTipoDetalle">Representa el numero de identificacion de un tipo de detalle</param>
        /// <param name="Descripcion">Representa la descripcion del detalle</param>
        /// <param name="cantidad">Representa la cantidad ingresar de la transaccion</param>
        /// <param name="TipoTransaccion">Representa el numero </param>
        /// <param name="activo">Representa el estado del detalle</param>
        /// <returns></returns>
        public static int agregar(int idtransaccion, int IdTipoDetalle, string Descripcion, decimal cantidad, int TipoTransaccion, bool activo)
        {
            int result = -1;
            Detalle det = new Detalle()
            {
                IdTransaccion = idtransaccion,
                TipoDetalle = IdTipoDetalle,
                Descripcion = Descripcion,
                Cantidad = cantidad,
                TipoTransaccion = TipoTransaccion,
                Activo = activo
            };

            try
            {
                _Detalle db = new _Detalle(det);
                result = db.agregar();
            }
            catch (Exception ex)
            {
                result = -1;
                throw ex;
            }
            return result;
        }



        /// <summary>
        /// Permite anular un detalle existente
        /// </summary>
        /// <param name="idDetalle"></param>
        /// <returns></returns>
        public static int anular(int idDetalle)
        {
            int result = -1;
            Detalle det = new Detalle { IdDetalle = idDetalle };
            try
            {
                _Detalle db = new _Detalle(det);
                result = db.anular();
            }
            catch (Exception ex)
            {
                result = -1;
                throw ex;
            }
            return result;
        }


        /// <summary>
        /// Permite listar los detalles deacuerdo a una transaccion
        /// </summary>
        /// <param name="idTransaccion"></param>
        /// <returns></returns>
        public static List<Detalle> listar(int idTransaccion)
        {
            List<Detalle> lista = null;
            try
            {
                Detalle det = new Detalle { IdTransaccion = idTransaccion };
                _Detalle db = new _Detalle(det);
                lista = db.listar();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo insertar el elemento", ex);
            }
            return lista;
        }


        /// <summary>
        /// Permite leer un detalle
        /// </summary>
        /// <param name="idDetalle"></param>
        /// <returns></returns>
        public static Detalle leer(int idDetalle)
        {
            Detalle temp = new Detalle { IdDetalle = idDetalle };
            return new _Detalle(temp).leer();
        }
    }
}
