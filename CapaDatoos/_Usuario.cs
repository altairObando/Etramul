using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos
{
   public class _Usuario
    {
       /// <summary>
       /// Instancia de usuarios con la que se pretende trabajar el CRUD
       /// </summary>
        private Usuarios user;
        //private Personas data;
       /// <summary>
       /// Constructor de la clase
       /// </summary>
       /// <param name="temp">Instancia de la clase  Usuarios con la informacion que se trabajara</param>
       public _Usuario(Usuarios temp, Personas p)
        {
            this.user = temp;
            user.Personas = p;
        }
       public _Usuario(Usuarios temp)
        {
            this.user = temp;
            //data = null;
        }
       /// <summary>
       /// Permite Ingresar un nuevo usuario al sistema
       /// </summary>
       /// <returns>1 en Caso de  una insercion satisfactoria de lo contrario -1</returns>
       public _Usuario() { }
       public int agregar()
        {
            int result = -1;
            using (var db = new ModeloContainer())
            {
                try
                {
                    //Validar Existencias
                    var tmp = db.UsuariosSet.First(x => x.Nickname == user.Nickname && user.Personas.Activo);
                    var tmp2 = db.PersonasSet.First(x => x.Identificacion == user.Personas.Identificacion && x.Activo);
                    if (tmp != null && tmp2!= null )
                        throw new Exception("Usuario Duplicado!");
                }
                catch (Exception)
                {
                    try
                    {
                        //Agregando el registro de persona
                        db.PersonasSet.Add(user.Personas);
                        db.SaveChanges();
                        //obteniendo el ultimo id agregado
                        user.Personas = (from item in db.PersonasSet orderby item.Id_persona descending select item).FirstOrDefault();
                        user.Id_usuario = user.Personas.Id_persona;
                        db.UsuariosSet.Add(user);
                        result = db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        throw new Exception("No se pudo ingresar el elemento", e);
                    }
                }
            }
            return result;
        }
       
       public int Modificar()
        {
            int result = -1;
            try
            {
                using (var db = new ModeloContainer())
                {
                    var mod = (from u in db.UsuariosSet
                               where u.Personas.Identificacion == user.Personas.Identificacion && u.Personas.Activo
                               select u).First();
                    //Cambio de nombres
                    //mod.Id_persona = user.Id_persona;
                    var persona = (from p in db.PersonasSet
                                   where p.Id_persona == mod.Personas.Id_persona
                                   select p).First();
                    /* Datos de usuario */
                    mod.Id_tipo = user.Id_tipo;
                    mod.Personas.Activo = user.Personas.Activo;
                    mod.Nickname = user.Nickname;
                    mod.Clave = user.Clave;
                    result = db.SaveChanges();
                    /* Datos de persona */
                    persona.Identificacion = user.Personas.Identificacion;
                    persona.Nombres = user.Personas.Nombres;
                    persona.Apellidos = user.Personas.Apellidos;
                    persona.Telefono = user.Personas.Telefono;
                    persona.Correo = user.Personas.Correo;
                    persona.Direccion = user.Personas.Direccion;
                    
                  result += db.SaveChanges();
                    
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            return result;
        }

       public List<Usuarios> listar()
       {
           List<Usuarios> lista = null;
           var db = new ModeloContainer();
           try
           {
               lista = (from u in db.UsuariosSet
                            where u.Personas.Activo
                            select u).ToList();
           }
           catch (Exception ex)
           {
               Console.WriteLine(ex.Message);
           }
           return lista;
       }

       public Usuarios leer()
       {
           Usuarios tmp = null;
           var db = new ModeloContainer();
               //si se trata de un login
               if (!string.IsNullOrWhiteSpace(user.Nickname) && !string.IsNullOrWhiteSpace(user.Clave))
               {
                   tmp = (from u in db.UsuariosSet
                          where u.Nickname == user.Nickname && u.Clave == user.Clave && u.Personas.Activo
                          select u).FirstOrDefault();
               }
               else //Busqueda por identificacion
               {
                   if(user.Id_usuario > 0)
                   {
                       tmp = (from item in db.UsuariosSet where item.Id_usuario.Equals(user.Id_usuario) select item).FirstOrDefault();
                   }
                   else
                   tmp = (from u in db.UsuariosSet
                              where u.Nickname.ToUpper().Equals(user.Nickname.ToUpper()) &&     u.Personas.Activo
                              select u ).FirstOrDefault();
                   
               }
           return tmp;
       }
       /// <summary>
       /// Permite la eliminacion logica de un elemento dentro de la base de datos
       /// </summary>
       /// <returns> 1 en caso de realizar la eliminacion, -1 en caso de error</returns>
       public int eliminar()
       {
           int result;
           try
           {
               using (var db = new ModeloContainer())
               {
                   var tmp = db.UsuariosSet.First(x => x.Personas.Identificacion.Equals(user.Personas.Identificacion) && x.Personas.Activo);
                   tmp.Personas.Activo = false;
                   result = db.SaveChanges();
                   
               }
           }
           catch (Exception ex)
           {
               result =  -1;
               throw new Exception("No se pudo eliminar el registro", ex);
           }
           return result;
       }
       /// <summary>
       /// Obtiene una lista de todos los usuarios con la propiedad Administrador
       /// </summary>
       /// <returns></returns>
       public List<Usuarios> getAdministradores()
       {
           List<Usuarios> admins = null;
           try
           {
               var db = new ModeloContainer();
               {
              admins = (from user in db.UsuariosSet
                        from tipo in db.TipoUsuarioSet
                        where user.Id_tipo == tipo.Id_tipo && tipo.Descripcion.Equals("Administrador") && user.Personas.Activo
                             select user).ToList();
               }
           }
           catch (Exception ex)
           {
               //No se encontro ningun admin
               throw ex;
           }
           return admins;
       }
    }
}
