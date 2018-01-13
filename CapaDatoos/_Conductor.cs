using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class _Conductor
    {
        /// <summary>
        /// Instancia de un objeto Conductor
        /// </summary>
        private Conductor chof;
        private Personas data;


        /// <summary>
        /// Constructor con parametro de la clase _Conductor
        /// </summary>
        /// <param name="chofer">Representa un objeto de la clase Conductor</param>
        public _Conductor(Conductor chofer)
        {
            this.chof = chofer;
            data = null;
        }
        /// <summary>
        /// Permite agregar un nuevo conductor al modelo de datos
        /// </summary>
        /// <returns>Devuelve 1 en caso de haber ejecutado con exito, -1 en caso contrario</returns>
        public int agregar()
        {
            int result = -1;
            using (var db = new ModeloContainer())
            {

                try
                {
                    var temp = db.PersonasSet.First(x => x.Identificacion == data.Identificacion && (x.Activo));
                    var temp1 = db.ConductorSet.First(x => x.Licencia == chof.Licencia);
                    if (temp != null && temp1 != null)
                        result = 0;
                    throw new Exception("Conductor Duplicado!");
                }
                catch (Exception)
                {

                    try
                    {
                        //Agregando Persona
                        db.PersonasSet.Add(chof.Personas);
                        db.SaveChanges();
                        //Obteniendo ID
                        chof.Id_conductor = (from item in db.PersonasSet orderby item.Id_persona descending select item).FirstOrDefault().Id_persona;
                        //Agregando Conductor
                        db.ConductorSet.Add(chof);
                        result = db.SaveChanges();
                        
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// Permite modificar un Conductor existente
        /// </summary>
        /// <returns>Devuelve 1 en caso de haber ejecutado con exito, -1 en caso contrario</returns>
        public int modificar()
        {
            int result = -1;
            try
            {
                using (var db = new ModeloContainer())
                {
                    var mod = (from u in db.ConductorSet
                               where u.Id_conductor == chof.Id_conductor
                               select u).First();
                    //Cambio de nombres
                    //mod.Id_persona = user.Id_persona;
                    mod.Personas.Identificacion = chof.Personas.Identificacion;
                    mod.Personas.Nombres = chof.Personas.Nombres;
                    mod.Personas.Apellidos = chof.Personas.Apellidos;
                    mod.Personas.Telefono = chof.Personas.Telefono;
                    mod.Personas.Correo = chof.Personas.Correo;
                    mod.Personas.Direccion = chof.Personas.Direccion;
                    mod.Licencia = chof.Licencia;
                    mod.Personas.Activo = chof.Personas.Activo;
                    result = db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }


        /// <summary>
        /// Permite leer la instancia de un objeto Conductor en el modelo de datos
        /// </summary>
        /// <returns>Regresa un objeto especifico de Conductor</returns>
        public Conductor leer()
        {
            Conductor temp = null;
            var db = new ModeloContainer();
            {
                if (chof.Id_conductor != 0)
                {
                    temp = (from u in db.ConductorSet
                            where u.Id_conductor == chof.Id_conductor
                            select u).First();
                }
                else
                {
                    if (chof.Personas.Identificacion != null && !string.IsNullOrWhiteSpace(chof.Personas.Identificacion))
                        temp = (from u in db.ConductorSet
                                where u.Personas.Identificacion == chof.Personas.Identificacion
                                select u).First();
                    else //Busqueda por nombre
                        temp = (from u in db.ConductorSet
                                where u.Personas.Nombres.StartsWith(chof.Personas.Nombres)
                                select u).FirstOrDefault();
                }
                
                return temp;
            }
        }


        /// <summary>
        /// Permite listar los conductores que se encuentrar registrados en el sistema
        /// </summary>
        /// <returns>Devuelve una lista de objetos Conductor</returns>
        public List<Conductor> listar()
        {
            List<Conductor> lista = null;
            var db = new ModeloContainer();
            {
                if (chof.Personas.Nombres != null)
                    lista = (from u in db.ConductorSet where u.Personas.Activo && u.Personas.Nombres.StartsWith(chof.Personas.Nombres) select u).ToList();
                else
                    lista = (from u in db.ConductorSet where u.Personas.Activo select u).ToList();
            }
            return lista;

        }


    }
}
