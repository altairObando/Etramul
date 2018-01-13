using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class _TipoUsuario
    {
        TipoUsuario tipo;
        public _TipoUsuario(TipoUsuario tmp)
        {
            this.tipo = tmp;
        }

        public List<TipoUsuario> listar()
        {
            List<TipoUsuario> tipos = null;
            try
            {
                using (var db = new ModeloContainer())
                {
                    tipos = db.TipoUsuarioSet.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return tipos;
        }

        public int agregar()
        {
            try
            {
                int result = -1;
                using (var db =new ModeloContainer())
                {
                    db.TipoUsuarioSet.Add(this.tipo);
                    result = db.SaveChanges();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoUsuario leer()
        {
            try
            {
                TipoUsuario tmp = null;
                using (var db = new ModeloContainer())
                {
                    tmp = db.TipoUsuarioSet.FirstOrDefault(x => x.Descripcion.Equals(this.tipo.Descripcion));
                }
                if (tmp == null)
                    throw new Exception("La busqueda no produjo resultados");
                return tmp;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
