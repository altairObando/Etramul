
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
    
public partial class Transaccion
{

    public Transaccion()
    {

        this.Egreso = new HashSet<Detalle>();

        this.Abono = new HashSet<Abono>();

    }


    public int IdTransaccion { get; set; }

    public int Id_usuario { get; set; }

    public int Id_Vehiculo { get; set; }

    public System.DateTime FechaTransaccion { get; set; }

    public bool Activo { get; set; }



    public virtual Vehiculo Vehiculo { get; set; }

    public virtual ICollection<Detalle> Egreso { get; set; }

    public virtual ICollection<Abono> Abono { get; set; }

}

}
