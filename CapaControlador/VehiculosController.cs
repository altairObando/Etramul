using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaControlador
{
    public static class VehiculosController
    {
        /// <summary>
        /// Permite Agregar los datos desde la vista de Vehiculos al sistema
        /// </summary>
        /// <param name="IdSocio">Representa el numero de identificación de un socio</param>
        /// <param name="placa">Representa el numero de placa de un vehiculo</param>
        /// <param name="marca">Representa la marca de un vehiculo</param>
        /// <param name="modelo">Representa el modelo de un vehiculo</param>
        /// <returns>Devuelve 1 en caso de agregar con exito, -1 en caso contrario</returns>
        public static int agregar(int IdSocio, string placa, string marca, string modelo)
        {
            int result = -1;
            Vehiculo veh = new Vehiculo()
            {
                Id_socio = IdSocio,
                Placa = placa,
                Marca = marca,
                Modelo = modelo,
                Activo = true
            };
            try
            {
                _Vehiculo db = new _Vehiculo(veh);
                result = db.agregar();
                ////Si se agrega ingresar a los saldos
                // result = SaldoController.agregar(getUltimo().Id_Vehiculo, 0 , 0);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            return result;
        }

        public static Vehiculo getUltimo()
        {
            return new _Vehiculo(new Vehiculo()).ultimo();
        }


        /// <summary>
        /// Permite modificar los datos de un vehiculo
        /// </summary>
        /// <param name="IdSocio">Representa el numero de identificación de un socio</param>
        /// <param name="placa">Representa el numero de placa de un vehiculo</param>
        /// <param name="marca">Representa la marca de un vehiculo</param>
        /// <param name="modelo">Representa el modelo de un vehiculo</param>
        /// <returns>Devuelve 1 en caso de modificar con exito, -1 en caso contrario</returns>
        public static int modificar(int? id_vehiculo, int IdSocio, string placa, string marca, string modelo)
        {
            int result = -1;
            Vehiculo veh = new Vehiculo()
            {
                Id_Vehiculo = (int)id_vehiculo,
                Id_socio = IdSocio,
                Placa = placa,
                Marca = marca,
                Modelo = modelo
            };
            try
            {
                var db = new _Vehiculo(veh);
                result = db.modificar();
                
            }
            catch (Exception ex)
            {
                
                throw new Exception (ex.Message, ex);
            }
            return result;
        }

        /// <summary>
        /// Permite listar toda la información de los vehiculos
        /// </summary>
        /// <returns>Devuelve una lista de objetos Vehiculo</returns>
        public static List<Vehiculo> lista(Vehiculo tmp)
        {
            _Vehiculo temp = new _Vehiculo(tmp);
            var lista = temp.listar();
            if (lista != null)
                return lista;
            else
                throw new Exception("Error durante la obtencion de la informacion");        
        }
        public static List<Vehiculo> lista()
        {
            return new _Vehiculo().listar();
        }
        /// <summary>
        /// Permite leer un objeto de tipo Vehiculo
        /// </summary>
        /// <param name="IdVehiculo">Representa el numero de identificación de un vehiculo</param>
        /// <returns>Devuelve un objeto especifico de Vehiculo</returns>
        public static Vehiculo leer(int IdVehiculo)
        { 
            Vehiculo temp = new Vehiculo {Id_Vehiculo = IdVehiculo};
            return new _Vehiculo(temp).leer();
        }


        /// <summary>
        /// Permite leer un objeto de tipo Vehiculo
        /// </summary>
        /// <param name="placa">Representa el numero de placa de un Vehiculo</param>
        /// <returns>Devuelve un objeto especifico de Vehiculo</returns>
        public static Vehiculo leer(string placa)
        {
            Vehiculo temp = new Vehiculo { Placa = placa };
            return new _Vehiculo(temp).leer();
        }

        /// <summary>
        /// Permite leer un objeto de tipo Vehiculo
        /// </summary>
        /// <param name="IdSocio">Representa el numero de indentificación de un Propietario</param>
        /// <returns>Devuelve un objeto especifico de Vehiculo</returns>
        public static Vehiculo leerSocio(int IdSocio)
        {
            Vehiculo temp = new Vehiculo { Id_socio = IdSocio };
            return new _Vehiculo(temp).leer();
        }

        public static int cambiarEstado(string placa)
        {
            return new _Vehiculo(new Vehiculo { Placa = placa }).cambiarEstado();
        }
    }
}
