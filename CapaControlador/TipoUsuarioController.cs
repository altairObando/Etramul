using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaControlador
{
    public static class TipoUsuarioController
    {
        public static List<TipoUsuario> listar()
        {
            var tmp = new _TipoUsuario(new TipoUsuario());
            return tmp.listar();
        }
        public static int agregar(string descripcion)
        {
            return new _TipoUsuario(new TipoUsuario { Descripcion = descripcion}).agregar();
        }

        public static TipoUsuario leer(string descripcion)
        {
            return new _TipoUsuario(new TipoUsuario {Descripcion = descripcion }).leer();
        }
    }
}
