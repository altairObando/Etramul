
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
    
public partial class Saldo_detalle
{

    public int Id_saldo { get; set; }

    public int id_detalle { get; set; }

    public decimal Saldo { get; set; }



    public virtual Detalle Detalle { get; set; }

}

}