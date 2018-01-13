using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaControlador
{
    public static class TransaccionController
    {
        /// <summary>
        /// Permite agregar una transaccion al modelo
        /// </summary>
        /// <param name="idUsuario">Numero de identificacion del usuario</param>
        /// <param name="idVehiculo">Numero de identificacion del vehiculo</param>
        /// <param name="fecha">Fecha de la transaccion</param>
        /// <param name="activo">Estado de la transaccion</param>
        /// <returns>1 en caso de tener exito, -1 en caso contrario</returns>
        public static int agregar(int idUsuario, int idVehiculo, DateTime fecha, bool activo)
        {
            int result = -1;
            Transaccion tran = new Transaccion()
            {
                Id_usuario = idUsuario,
                Id_Vehiculo = idVehiculo,
                FechaTransaccion = fecha,
                Activo = activo
            };
            try
            {
                _Transaccion db = new _Transaccion(tran);
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
        /// Permite anular transaccion especifica
        /// </summary>
        /// <param name="idTransaccion">Representa un numero de identificacion de una transaccion</param>
        /// <returns>1 si tiene exito, -1 en caso contrario</returns>
        public static int anular(int idTransaccion)
        {
            int result = -1;
            Transaccion tran = new Transaccion()
            {
                IdTransaccion = idTransaccion
            };
            try
            {
                _Transaccion db = new _Transaccion(tran);
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
        /// Devuelve una lista de transacciones deacuerdo a un vehiculo o las devuelve todas
        /// </summary>
        /// <param name="parametro">Puede representar el IdVehiculo</param>
        /// <returns>Devuelve una lista de objetos transaccion</returns>
        public static List<Transaccion> listar(int parametro)
        {
            _Transaccion tran = null;
            if (parametro > 0)
            {
                Transaccion t = new Transaccion { Id_Vehiculo = parametro };
                tran = new _Transaccion(t);
            }
            else
            {
                tran = new _Transaccion(new Transaccion());
            }
            var result = tran.listar();
            return result;
        }

        /// <summary>
        /// Permite leer un objeto transaccion
        /// </summary>
        /// <param name="idtransaccion">Representa el numero de identificacion de una Transaccion</param>
        /// <returns>Devuelve un objeto transaccion en caso de tener exito</returns>
        public static Transaccion leer(int idtransaccion)
        {
            Transaccion temp = new Transaccion { IdTransaccion = idtransaccion };
            return new _Transaccion(temp).leer();
        }


        public static Transaccion getUltima()
        {
            return new _Transaccion(new Transaccion()).getUltima();
        }
    }
}
