
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
    
public partial class Carrera
{

    public int Id_carrera { get; set; }

    public int Id_conductor { get; set; }

    public int Id_vehiculo { get; set; }

    public int No_transaccion { get; set; }

    public System.TimeSpan HoraSalida { get; set; }

    public System.TimeSpan HoraLlegada { get; set; }

    public System.DateTime FechaCarrera { get; set; }

    public bool Vuelta_Completa { get; set; }

    public bool Activo { get; set; }



    public virtual Vehiculo Vehiculo { get; set; }

    public virtual Conductor Conductor { get; set; }


    }

}
