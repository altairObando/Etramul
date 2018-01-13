using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaControlador
{
    public static class ConductorController
    {
        /// <summary>
        /// Permite agregar un nuevo conductor al modelo
        /// </summary>
        /// <param name="identificacion">Representa la identificación del conductor</param>
        /// <param name="nombres">Representa los nombres del conductor</param>
        /// <param name="apellidos">Representa los apellidos del conductor</param>
        /// <param name="direccion">Representa la dirección de residencia del conductor</param>
        /// <param name="telefono">Representa el numero de telefono del conductor</param>
        /// <param name="correo">Representa el correo del conductor</param>
        /// <param name="activo">Representa el estado de actividad del conductor</param>
        /// <param name="licencia">Representa el numero de licencia del conductor</param>
        /// <returns>Devuelve 1 en caso de haber tenido exito, -1 en caso contrario</returns>
        public static int agregar(string identificacion, string nombres, string apellidos, string direccion,
                            string telefono, string correo, bool activo, string licencia)
        {
            int result = -1;
            Conductor con = new Conductor()
            {
                
                Licencia = licencia,                
                Personas = new Personas{
                Identificacion = identificacion,
                Nombres = nombres,
                Apellidos = apellidos,
                Direccion = direccion,
                Telefono = telefono,
                Correo = correo,
                Activo = activo
                }
            };
            try
            {
                _Conductor db = new _Conductor(con);
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
        /// Permite realizar modificaciones a un conductor existente
        /// </summary>
        /// <param name="identificacion">Representa la identificación del conductor</param>
        /// <param name="nombres">Representa los nombres del conductor</param>
        /// <param name="apellidos">Representa los apellidos del conductor</param>
        /// <param name="direccion">Representa la dirección de residencia del conductor</param>
        /// <param name="telefono">Representa el numero de telefono del conductor</param>
        /// <param name="correo">Representa el correo del conductor</param>
        /// <param name="activo">Representa el estado de actividad del conductor</param>
        /// <param name="licencia">Representa el numero de licencia del conductor</param>
        /// <returns>Devuelve 1 en caso de haber tenido exito, -1 en caso contrario</returns>
        public static int modificar(int id_conductor,string identificacion, string nombres, string apellidos, string direccion,
                            string telefono, string correo, bool activo, string licencia)
        {
            int result = -1;
            Conductor con = new Conductor()
            {
                Id_conductor 
                = id_conductor,
                Licencia = licencia,

                Personas = new Personas
                {
                    Identificacion = identificacion,
                    Nombres = nombres,
                    Apellidos = apellidos,
                    Direccion = direccion,
                    Telefono = telefono,
                    Correo = correo,
                    Activo = activo
                }
            };
            try
            {
                _Conductor db = new _Conductor(con);
                result = db.modificar();
            }
            catch (Exception ex)
            {
                result = -1;
                throw ex;
            }
            return result;
        }


        /// <summary>
        /// Permite listar los conductores existentes en el sistema
        /// </summary>
        /// <param name="parametro">Representa el parametro para realizar la lista, puede ser nulo o tener el nombre del objeto que se busca</param>
        /// <returns>Devuelve una lista de objetos Conductor</returns>
        public static List<Conductor> lista(string parametro)
        {
            Conductor con = new Conductor() { Personas = new Personas { Nombres = parametro } };
            _Conductor ch = new _Conductor(con);
            var result = ch.listar();
            return result;
        }
        public static List<Conductor> lista()
        {
            _Conductor ch = new _Conductor(new Conductor() { Personas = new Personas()});
            var result = ch.listar();
            return result;
        }
        /// <summary>
        /// Permite obtener un objeto Conductor por medio su numero autoincremental de identificación
        /// </summary>
        /// <param name="id_persona">Representa el numero autoincremental de un objeto Conductor</param>
        /// <returns>Devuelve un objeto Conductor en especifico</returns>
        public static Conductor leer(int id_persona)
        {
            Conductor temporal = new Conductor {Id_conductor = id_persona, Personas = new Personas { Id_persona = id_persona } };
            return new _Conductor(temporal).leer();

        }//fin del metodo leer con un parametro


        /// <summary>
        /// Permite obtener un objeto Conductor por medio su nombre
        /// </summary>
        /// <param name="nombre">Representa el nombre de un objeto Conductor</param>
        /// <returns>Devuelve un objeto Conductor en especifico</returns>
        public static Conductor leer(string nombre)
        {
            Conductor temporal = new Conductor { Personas = new Personas { Nombres = nombre } };
            return new _Conductor(temporal).leer();

        }//Fin del metodo por nombre


        /// <summary>
        /// Permite obtener un objeto Conductor por medio su nombre
        /// </summary>
        /// <param name="cedula">Representa el numero de cedula de un objeto Conductor</param>
        /// <returns>Devuelve un objeto Conductor en especifico</returns>
        public static Conductor leerI(string cedula)
        {
            Conductor temporal = new Conductor { Personas = new Personas { Identificacion = cedula } };
            return new _Conductor(temporal).leer();
        }

      }
}
