using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos
{
    public class _TipoDetalle
    {
        private TipoDetalle td;
        public _TipoDetalle(TipoDetalle tipo)
        {
            this.td = tipo;
        }
        public int agregar()
        {
            try
            {
                int result = -1;
                using (var db = new ModeloContainer())
                {
                    db.TipoDetalleSet.Add(this.td);
                    result = db.SaveChanges();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error durante la insercion", ex.InnerException);
            }
        }
        public int modificar()
        {
            try
            {
                int cambios = -1;
                using (var db = new ModeloContainer())
                {
                    //Obtener registro
                    var registro = (from item in db.TipoDetalleSet where item.IdTipoDetalle.Equals(this.td.IdTipoDetalle) select item).FirstOrDefault();
                    //Ingresar cambios
                    registro.Descripcion = this.td.Descripcion;
                    cambios = db.SaveChanges();
                }
                return cambios;
            }
            catch (Exception ex)
            {
                throw new Exception("Error durante la actualizacion de los registros", ex.InnerException);
            }
        }
        public int eliminar()
        {
            try
            {
                int result = -1;
                using (var db = new ModeloContainer())
                {
                    //Buscando el registro para eliminar
                    var r = (from item in db.TipoDetalleSet where item.IdTipoDetalle.Equals(this.td.IdTipoDetalle) select item).FirstOrDefault();
                    r.Activo = false;
                    result = db.SaveChanges();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error durante la eliminacion de los datos", ex.InnerException);
            }
        }
        public List<TipoDetalle> listar()
        {
            try
            {
                List<TipoDetalle> lista = null;
                using (var db = new ModeloContainer())
                {
                    lista = db.TipoDetalleSet.Where(x => x.Activo).ToList();
                }
                if (lista.Count == 0)
                    throw new Exception("No se han encontrado Tipos disponibles");
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TipoDetalle leer()
        {
            try
            {
                TipoDetalle result;
                using (var db = new ModeloContainer())
                {
                    if (this.td.IdTipoDetalle > 0)
                        result = db.TipoDetalleSet.First(x => x.IdTipoDetalle == this.td.IdTipoDetalle);
                    else
                        if (this.td.Descripcion.Length > 0)
                            result = db.TipoDetalleSet.First(x => x.Descripcion.Equals(td.Descripcion) && x.Activo);
                        else
                            throw new Exception("No se ha proporcionado un parametro valido para la busquead de detalles");
                }
                if (result == null)
                    throw new Exception("No se ha localizado el objeto solicitado");

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
