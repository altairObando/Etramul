using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class _Transaccion
    {
        /// <summary>
        /// Representa un objeto transaccion
        /// </summary>
        private Transaccion tran;


        /// <summary>
        /// Constructor que permite agregar un objeto transaccion
        /// </summary>
        /// <param name="tran">Representa un objeto de tipo Transaccion</param>
        public _Transaccion(Transaccion tran)
        {
            this.tran = tran;
        }

        /// <summary>
        /// Constructor Vacio de Transaccion
        /// </summary>
        public _Transaccion() { }


        /// <summary>
        /// Permite agregar una nueva transaccion al modelo de datos
        /// </summary>
        /// <returns>1 si tuvo exito, -1 en caso contrario</returns>
        public int agregar()
        {
            int result = -1;
            using (var db= new ModeloContainer())
            {
                try
                {
                    var temp = db.UsuariosSet.First(x => x.Id_usuario == tran.Id_usuario);
                    var temp1 = db.VehiculoSet.First(x => x.Id_Vehiculo == tran.Id_Vehiculo);
                    if (temp == null || temp1 == null)
                        throw new Exception("No existe el usuario o el vehiculo");
                    else
                    {
                        db.TransaccionSet.Add(tran);
                        result = db.SaveChanges();     
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("No se pudo ingresar el elemento", ex);                    
                }
            }

            return result;
        }


        /// <summary>
        /// Permite anular una transaccion existente
        /// </summary>
        /// <returns>un numero mayor a 1 en caso satisfactorio, -1 en caso contrario</returns>
        public int anular()
        {
            int result = -1;
            using (var db = new ModeloContainer())
            {
                try
                {
                    /// Obteniendo la transaccion y el detalle 
                    /// para ser anulados.
                    var temp = (from u in db.TransaccionSet
                               where u.IdTransaccion==tran.IdTransaccion && u.Activo select u).First();
                    temp.Activo = false;
                    for (int i = 0; i < temp.Egreso.Count; i++)
                    {
                        temp.Egreso.ElementAt(i).Activo = false;
                    }
                    result = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("No se pudo insertar el elemento",ex);
                }
            }
            return result;
        }

        /// <summary>
        /// Permite realizar una lista de transacciones
        /// </summary>
        /// <returns></returns>
        public List<Transaccion> listar()
        {
            List<Transaccion> lista = null;
            var db = new ModeloContainer();
            {
                if (tran.Id_Vehiculo > 0)
                    lista = (from u in db.TransaccionSet where u.Id_Vehiculo == tran.Id_Vehiculo orderby u.IdTransaccion descending select u).ToList();
                else
                    lista = (from u in db.TransaccionSet where u.Activo orderby u.IdTransaccion descending select u).ToList();
            }           
            return lista;
        }

        public Transaccion leer()
        {
            Transaccion tmp = null;
            var db = new ModeloContainer();
            {
                tmp = (from u in db.TransaccionSet where u.IdTransaccion == tran.IdTransaccion select u).FirstOrDefault();
            }
            return tmp;
        }
        public Transaccion getUltima()
        {
            try
            {
                Transaccion last;
                var db = new ModeloContainer();
                last = (from item in db.TransaccionSet orderby item.IdTransaccion descending select item).FirstOrDefault();
                return last;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
