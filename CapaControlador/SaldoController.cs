using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaControlador
{
   public class SaldoController
    {
        /// <summary>
        /// Permite almacenar el saldo pendiente de cada placa de bus.
        /// </summary>
        /// <param name="IDsaldo">Representa el numero de identificacion de un saldo</param>
        /// <param name="IDvehiculo">Representa el numero de identificacoin de un vehiculo</param>
        /// <param name="Total">Representa el saldo pendiente de una placa, este campo des de tipo float</param>
        /// <param name="ultimaT">Representa la ultima trasnsaccion realizada</param>
        /// <returns>Devuelve 1 en caso de agregar con exito, -1 en caso contrario</returns>
        public static int agregar(int IDvehiculo, float Total, int ultimaT)
        {
            int result = -1;
            Saldo sal = new Saldo()
            {
             Id_vehiculo = IDvehiculo,
             Total_sado = Total,
             ultima_transacion = ultimaT,
            };

            try
            {
                _Saldo db = new _Saldo(sal);
                result = db.agregar();
            }
            catch (Exception ex)
            {
                throw ex;               
            }
            return result;
        }

        public static int actualizar(int IDvehiculo, float Total, bool IE, int ultima)
        {
            if (!IE)
                Total *= -1;
            Saldo sal = new Saldo()
            {
                Id_vehiculo = IDvehiculo,                           
                Total_sado = Total,
                ultima_transacion = ultima
                          
            };
            return new _Saldo(sal).actualizar();
        }
    
     public static Saldo leer(int ID_vehiculo)
        {
            Saldo temp = new Saldo { Id_vehiculo = ID_vehiculo};
            return new _Saldo(temp).leer();
        }
       
            
    }
}
