
//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CapaDatos
{

using System;
    using System.Collections.Generic;
    
public partial class TipoDetalle
{

    public TipoDetalle()
    {

        this.Egreso = new HashSet<Detalle>();

    }


    public int IdTipoDetalle { get; set; }

    public string Descripcion { get; set; }

    public bool Activo { get; set; }


        public override string ToString()
        {
            return Descripcion;
        }
        public virtual ICollection<Detalle> Egreso { get; set; }

}

}
