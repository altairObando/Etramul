using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class _Carrera
    {
        private Carrera carrera;

        public _Carrera(Carrera carrera)
        {
            // TODO: Complete member initialization
            this.carrera = carrera;
        }
        public int Agregar()
        {
            int result = -1;
            try
            {
                using (var db = new ModeloContainer())
                {
                    //Guardando transaccion
                    db.CarreraSet.Add(carrera);
                    result = db.SaveChanges();
                    if(result == -1)
                      throw new Exception("No se pudo ingresar la carrera");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public Carrera getUltima()
        {
            Carrera carrera = null;
            var db = new ModeloContainer();
                carrera = (from item in db.CarreraSet orderby item.Id_carrera descending select item).FirstOrDefault();
            return carrera;
        }

        public int Eliminar()
        {
            int result = -1;
            try
            {
                using(var db = new ModeloContainer())
                {
                    var eliminable = db.CarreraSet.FirstOrDefault(x => x.Id_carrera.Equals(carrera.Id_carrera));
                    eliminable.Activo = false;
                    result = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<Carrera> Listar()
        {
            List<Carrera> tmp = null;
            try
            {
                var db = new ModeloContainer();
                tmp = db.CarreraSet.Where(x => x.Activo).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tmp;
        }

        public Carrera Leer()
        {
            try
            {
                Carrera car;
                var db = new ModeloContainer();
                {
                    car = db.CarreraSet.FirstOrDefault(x => x.Id_carrera == this.carrera.Id_carrera);
                }
                if (car == null)
                    throw new NullReferenceException("La busqueda de la carrera :" + this.carrera.Id_carrera + ", Produjo resultados null");
                return car;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
