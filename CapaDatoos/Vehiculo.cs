
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
    
public partial class Vehiculo
{

    public Vehiculo()
    {

        this.Carrera = new HashSet<Carrera>();

        this.Transaccion = new HashSet<Transaccion>();

    }


    public int Id_Vehiculo { get; set; }

    public string Placa { get; set; }

    public string Marca { get; set; }

    public string Modelo { get; set; }

    public bool Activo { get; set; }

    public int Id_socio { get; set; }



    public virtual ICollection<Carrera> Carrera { get; set; }

    public virtual ICollection<Transaccion> Transaccion { get; set; }

    public virtual Socio Socio { get; set; }
        public override string ToString()
        {
            return Placa;
        }
    }

}
