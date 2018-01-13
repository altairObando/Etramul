using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class _Vehiculo
    {
        /// <summary>
        /// Objeto de la clase Vehiculo
        /// </summary>
        private Vehiculo vehiculo;


        /// <summary>
        /// Constructor con parametros de la clase
        /// </summary>
        /// <param name="vehiculo">Objeto de la clase Vehiculo</param>
        public _Vehiculo(Vehiculo veh)
        {
            this.vehiculo = veh;
        }


        /// <summary>
        /// Constructor vacio de la clase
        /// </summary>
        public _Vehiculo()
        {
            this.vehiculo = new Vehiculo();
        }


        /// <summary>
        /// Agregar un vehiculo a la capa de datos
        /// </summary>
        /// <returns></returns>
        public int agregar()
        {
            int result = -1;
            using (var db = new ModeloContainer())
            {
                try
                {
                    //Verificar si no existe un vehiculo con la misma placa
                   db.VehiculoSet.Add(vehiculo);
                   result =  db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return result;
        }
        /// <summary>
        /// Modifica un vehiculo existente
        /// </summary>
        /// <returns>1 en caso de exito, -1 en caso contrario</returns>
        public int modificar()
        {
            int result = -1;
            try
            {
                using (var db = new ModeloContainer())
                {
                    var mod = (from v in db.VehiculoSet
                               where v.Id_Vehiculo == vehiculo.Id_Vehiculo
                               select v).First();

                    //mod.Id_Propietario = vehiculo.Id_Propietario;
                    mod.Placa = vehiculo.Placa;
                    mod.Modelo = vehiculo.Modelo;
                    mod.Marca = vehiculo.Marca;
                    result = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
        /// <summary>
        /// Lee un objeto Vehiculo
        /// </summary>
        /// <returns>Devuelve un objeto tipo vehiculo</returns>
        public Vehiculo leer()
        {
            Vehiculo tmp = null;
            var db = new ModeloContainer();
            {
                //Busqueda por ID
                if(vehiculo.Id_Vehiculo!=0)
                {
                    tmp = (from v in db.VehiculoSet
                           where v.Id_Vehiculo == vehiculo.Id_Vehiculo
                           select v).FirstOrDefault();
                }
                else
                {
                    //Busqueda por propietario
                    if (vehiculo.Id_socio!=0) 
                    {
                        tmp = (from v in db.VehiculoSet
                               where v.Id_socio == vehiculo.Id_socio
                               select v).FirstOrDefault();
                    }
                    else //Busqueda por placa
                    {
                        tmp = (from v in db.VehiculoSet
                               where v.Placa == vehiculo.Placa
                               select v).FirstOrDefault();
                    }
                
                }               
                
            }
            return tmp;
        }
        public int eliminar()
        {
            int result;
            try
            {
                using (var db = new ModeloContainer())
                {
                    //Buscando el vehiculo
                    var tmp = db.VehiculoSet.First(x => x.Id_Vehiculo == vehiculo.Id_Vehiculo);
                    if (tmp != null)
                    {
                        tmp.Activo = false;
                       result = db.SaveChanges();
                    }
                    else
                        result = -1;
                }
            }
            catch (Exception)
            {
                result = -1;
                throw;
            }
            return result;
        }
        public List<Vehiculo> listar()
        {
            List<Vehiculo> temp = null;
            var db = new ModeloContainer();
            {
                if(vehiculo.Placa == null )
                    temp = (from v in db.VehiculoSet select v).ToList();
                else
                    temp = (from bus in db.VehiculoSet where bus.Placa.StartsWith(vehiculo.Placa) select bus).ToList();
            }
            return temp;
        }

        public int cambiarEstado()
        {
            int result = -1;
            try
            {
                using (var db = new ModeloContainer())
                {
                    var v = db.VehiculoSet.FirstOrDefault(x => x.Placa == this.vehiculo.Placa);
                    v.Activo = !v.Activo;
                    result = db.SaveChanges();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public Vehiculo ultimo()
        {
            try
            {
                var db = new ModeloContainer();
                Vehiculo tmp = (from item in db.VehiculoSet orderby item.Id_Vehiculo descending select item).First();
                return tmp;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
