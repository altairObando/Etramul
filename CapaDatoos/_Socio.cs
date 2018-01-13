using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class _Socio
    {
        /// <summary>
        /// instancia de Socio con la que se trabjara
        /// </summary>
        private Socio so;
      
        /// <summary>
        /// constructor de la clase _Socio
        /// </summary>
        /// <param name="temp"></param>instancia con la que se manejar la informacion
        public _Socio(Socio temp)
        {
            this.so = temp; 
        }

        //constructor sin argumentos de _socio
        public _Socio()
        {

        }
        /// <summary>
        /// metodo para agregar un socio
        /// </summary>
        /// <returns>retorna 1 en caso de ser agregado correctamente de lo contrario retorna -1</returns>
        public int agregar()
        {
            int result = -1;
            using (var db = new ModeloContainer())
            {
                try
                {
                    db.PersonasSet.Add(so.Personas);
                    db.SaveChanges();
                    so.Id_socio = (from item in db.PersonasSet orderby item.Id_persona descending select item).FirstOrDefault().Id_persona;

                    db.SocioSet.Add(so);
                    result = db.SaveChanges();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                return result;
            }

        }//fin del metodo agregar

        /// <summary>
        /// metodo para modificar los datos de un socio
        /// </summary>
        /// <returns>retorna 1 si los datos se modificaron correctamente de lo contrario retorna -1</returns>
        public int modificar()
        {
            int result = -1;
            try
            {
                using(var db = new ModeloContainer())
                {
                    //Buscando a una persona con los datos especificados
                    var mod = (from u in db.SocioSet where u.Personas.Identificacion == so.Personas.Identificacion select u).First();            

                    //cambio del valor de los atributos de un socio
                    mod.Personas.Identificacion = so.Personas.Identificacion;
                    mod.Personas.Nombres = so.Personas.Nombres;
                    mod.Personas.Apellidos = so.Personas.Apellidos;
                    mod.Personas.Direccion = so.Personas.Direccion;
                    mod.Personas.Telefono = so.Personas.Telefono;
                    mod.Personas.Correo = so.Personas.Correo;
                    mod.Personas.Activo = so.Personas.Activo;
                    result = db.SaveChanges();
                    //Actualizando el socio
                    var sociom = (from socio in db.SocioSet where socio.Id_socio == mod.Personas.Id_persona select socio).First();
                    sociom.FechaAsociacion = so.FechaAsociacion;
                    result += db.SaveChanges();
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("error "+e.Message);
            }
            return result;
        }//fin del metodo modificar

        /// <summary>
        /// metodo que regresa una lista llena de los socios activo.
        /// </summary>
        /// <returns></returns>
        public List<Socio> listar()
        {
            List<Socio> lista = new List<Socio>();// se crea una lista nueva.
            try
            {
                var db = new ModeloContainer();
                lista = (from u in db.SocioSet where u.Personas.Activo select u).ToList();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            return lista;
        }//fin del metodo listar

        /// <summary>
        /// metodo que regresa una lista llena de los socios activo.
        /// </summary>
        /// <returns></returns>
        public List<Socio> listar(string nombre)
        {
            List<Socio> lista = new List<Socio>();// se crea una lista nueva.

            using (var db = new ModeloContainer())
            {
                lista = (from u in db.SocioSet where u.Personas.Activo && u.Personas.Nombres.StartsWith(nombre) select u).ToList();

            }
            return lista;
        }
        //fin del metodo listar

        /// <summary>
        /// Metodo para leer la informacion de un socio
        /// </summary>
        /// <returns></returns>
        public Socio leer()
        {
            Socio tmp = null;
            try
            {
                var db = new ModeloContainer();
                {

                    if (so.Id_socio > 0)
                    {
                        //busqueda por id
                        tmp = (from u in db.SocioSet where u.Id_socio == so.Id_socio select u).FirstOrDefault();
                    }
                    else
                    {
                        //busqueda por nombre
                        if (so.Personas.Nombres != null)
                            tmp = (from u in db.SocioSet where u.Personas.Nombres == so.Personas.Nombres select u).FirstOrDefault();
                        else
                            tmp = (from u in db.SocioSet where u.Personas.Identificacion == so.Personas.Identificacion select u).FirstOrDefault();
                    }

                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            return tmp;
        }//fin del metodo leer
    }
}
