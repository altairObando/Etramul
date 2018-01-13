using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaControlador
{
    public static class TipoDetalleController
    {
        /// <summary>
        /// Permite ingresar un nuevo tipo de detalle para registro de transacciones
        /// </summary>
        /// <param name="descripcion"> Descripcion o detalle para el registro</param>
        /// <returns>un valor positivo en caso de agregar de forma correcta</returns>
        public static int agregar(string descripcion)
        {
            return new _TipoDetalle(new TipoDetalle { Descripcion = descripcion, Activo = true}).agregar();
        }
        /// <summary>
        /// Permite realizar la modificacion de un registro
        /// para los tipos de detalles
        /// </summary>
        /// <param name="id"></param>
        /// <param name="desc"></param>
        /// <param name="activo"></param>
        /// <returns>Devuelve un valor positivo en caso de una insercion correcta</returns>
        public static int modificar(int id, string desc, bool activo)
        {
            return new _TipoDetalle(new TipoDetalle {IdTipoDetalle = id, Descripcion = desc, Activo = activo }).modificar();
        }
        /// <summary>
        /// Permite la desactivacion de un registro utilizando el id
        /// </summary>
        /// <param name="id">Codigo de identificacion para el registro que se desea eliminar</param>
        /// <returns>Devuelve un numero positivo en caso satisfactorio
        /// *Indica la cantidad de modificaciones realizadas</returns>
        public static int eliminar(int id)
        {
            return new _TipoDetalle(new TipoDetalle { IdTipoDetalle = id}).eliminar();
        }
        /// <summary>
        /// Permite obtener un registro utilizando  
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static TipoDetalle leer(int id)
        {
            return new _TipoDetalle(new TipoDetalle { IdTipoDetalle = id}).leer();
        }
        public static TipoDetalle leer(string descripcion)
        {
            return new _TipoDetalle(new TipoDetalle { Descripcion = descripcion}).leer();
        }
        public static List<TipoDetalle> listar()
        {
            return new _TipoDetalle(new TipoDetalle()).listar();
        
        }
    }
}