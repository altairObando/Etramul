using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaControlador
{
    public static class UsuariosController
    {
        public static int agregar(string identificacion, string nombres, string apellidos, string direccion,
                            string telefono, string correo, bool activo, string nickname, string clave, int tipo_usuario)
        {
            int result = -1;
            clave = codificar(clave);
            Usuarios user = new Usuarios
            {
                Nickname = nickname,
                Clave = clave,
                Id_tipo = tipo_usuario
            };
            Personas data = new Personas
            {
                Identificacion = identificacion,
                Nombres = nombres,
                Apellidos = apellidos,
                Direccion = direccion,
                Telefono = telefono,
                Correo = correo,
                Activo = activo,
            };
            try
            {
                _Usuario db = new _Usuario(user, data);
                result = db.agregar();
                return result;
            }
            catch (Exception ex)
            {
                result = -1;
                throw ex;
            }
        }

        public static int modificar(string identificacion, string nombres, string apellidos, string direccion,
                            string telefono, string correo, bool activo, string nickname, string clave, int tipo_usuario)
        {
            int result = -1;

            Usuarios user = new Usuarios
            {
                Nickname = nickname,
                Clave = codificar(clave),
                Id_tipo = tipo_usuario,
                Personas = new Personas
            {
                Identificacion = identificacion,
                Nombres = nombres,
                Apellidos = apellidos,
                Direccion = direccion,
                Telefono = telefono,
                Correo = correo,
                Activo = activo,
            }
            };
            try
            {
                var db = new _Usuario(user);
                result = db.Modificar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
        public static List<Usuarios> lista()
        {
            _Usuario tmp = new _Usuario();
            List<Usuarios> result = null;
            try
            {
                result = tmp.listar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Permite obtener un usuario por medio de 
        /// su nickname y clave (Login)
        /// </summary>
        /// <returns> 1 usuario si el nickname y la clave coinciden, null en caso contrario</returns>
        public static Usuarios leer(string nick, string clave)
        {

            Usuarios tmp = new Usuarios {Nickname = nick, Clave = codificar(clave) };
            return new _Usuario(tmp).leer();
        }
        public static Usuarios leer(string nickname)
        {
            Usuarios tmp = new Usuarios { Nickname = nickname };
            return new _Usuario(tmp).leer();
        }
        public static Usuarios leer(int id_usuario)
        {
            Usuarios tmp = new Usuarios { Id_usuario = id_usuario };
            return new _Usuario(tmp).leer();
        }
        /*
         * Simulacion de codificacion de contrasenia
         * Usando ASCII 
         */
         static string codificar(string texto)
        {
            byte[] codificado = ASCIIEncoding.ASCII.GetBytes(texto);
            return Convert.ToBase64String(codificado);
            
        }
         static string decodificar(string texto)
        {
            byte[] decodificado = System.Convert.FromBase64String(texto);
            return ASCIIEncoding.ASCII.GetString(decodificado);
        }
         public static int eliminar(string Identificacion)
         {
             try
             {
                 _Usuario tmp = new _Usuario(new Usuarios { Personas = new Personas { Identificacion = Identificacion } });
                 return tmp.eliminar();
             }
             catch (Exception ex)
             {
                 throw new Exception(ex.Message,ex);
             }
         }

         public static List<Usuarios> getAdministradores()
         {
             return new _Usuario().getAdministradores();
         }
    }

}
