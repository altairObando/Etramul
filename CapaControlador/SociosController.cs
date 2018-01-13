using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaControlador
{
   public static class SociosController
    {

       public static int agregar(DateTime f_Asociacion, string identificacion, string nombres, string apellidos, string direccion,
                            string telefono, string correo, bool activo)
       {
           int res = -1;
           Socio so = new Socio()
           {
               FechaAsociacion = f_Asociacion,
               Personas = new Personas { Identificacion = identificacion,
               Nombres = nombres,
               Apellidos = apellidos,
               Direccion = direccion,
               Telefono = telefono,
               Correo = correo,
               Activo = activo}               
           };//finaliza la creacion del nuevo socio 
           try
           {
               var db = new _Socio(so);
               res = db.agregar();
           }
           catch (Exception e)
           {

               Console.WriteLine("ERROR "+ e.Message);
           }
           return res;
       }//fin del metodo agregar


       public static int modificar(DateTime f_Asociacion, string identificacion, string nombres, string apellidos, string direccion,
                            string telefono, string correo, bool activo)
       {
           int res = -1;
           Socio so = new Socio
           {
               FechaAsociacion = f_Asociacion,
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
               var db = new _Socio(so);
               res = db.modificar();
           }
           catch (Exception e)
           {

               Console.WriteLine("ERROR "+ e.Message);
           }
           return res;
       }//fin del metodo  modificar

       /// <summary>
       /// Permite crear una lista de objetos Socio
       /// </summary>
       /// <returns>Devuelve una lista de objetos Socio</returns>
       public static List<Socio> lista()
       {
           _Socio tmp = new _Socio();
           var result = tmp.listar(); //invocacion al metodo listar
           if (result != null)
               return result;
           else
               throw new Exception("Error durante la obtencion de la informacion");

       }//fin del metodo lista

       /// <summary>
       /// Permite crear una lista de objetos Socio
       /// </summary>
       /// <param name="nombre">Representa los nombres de un objetos socio</param>
       /// <returns>Devuelve una lista de objetos Socio</returns>
       public static List<Socio> lista(string nombre)
       {
           _Socio tmp = new _Socio();
           var result = tmp.listar(nombre); //invocacion al metodo listar
           if (result != null)
               return result;
           else
               throw new Exception("Error durante la obtencion de la informacion");

       }//fin del metodo lista

       public static Socio leer(int id_persona )
       {
           Socio temporal = new Socio {Id_socio = id_persona, Personas = new Personas{ Id_persona = id_persona }};
           return new _Socio(temporal).leer();
          
       }//fin del metodo leer con un parametro

       public static Socio leer(string nombre)
       {
           Socio temporal = new Socio { Personas = new Personas { Nombres = nombre } };
           return new _Socio(temporal).leer();

       }//Fin del metodo por nombre

       public static Socio leerI(string cedula)
       {
           Socio temporal = new Socio { Personas = new Personas {  Identificacion = cedula } };
           return new _Socio(temporal).leer();
       }

    }//fin de la clase 
}
