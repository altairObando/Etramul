using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
   public class _Saldo
    {
       /// <summary>
       /// Objeto de la clase Saldo;
       /// </summary>
       private Saldo saldo;

       /// <summary>
       /// Constructor con parametros de la clase _Saldo.
       /// </summary>
       /// <param name="sal"></param>
       public _Saldo (Saldo sal)
       {
           this.saldo = sal;
       }

       /// <summary>
       /// Constructor vacio de la clase _Saldo
       /// </summary>
       public _Saldo() { }

       public int agregar()
       {
           int result = -1;
           using (var db = new ModeloContainer())
           {
               try
               {
                 
                   db.SaldoSet.Add(saldo);
                   result = db.SaveChanges();

               }
               catch (Exception ex)
               {
                   Console.WriteLine(ex.Message);
                   
               }
           }
           return result;
       }


       public int actualizar()
       {
           int result = -1;
           using (var db = new ModeloContainer())
           {
               try
               {
                   var tmp = db.SaldoSet.FirstOrDefault(x => x.Id_vehiculo == this.saldo.Id_vehiculo);
                   tmp.Total_sado += saldo.Total_sado;
                   tmp.ultima_transacion = saldo.ultima_transacion;
                   result = db.SaveChanges();
	           }
	 catch (Exception ex)
	{
		
		Console.WriteLine(ex.Message);
	}
           }
           return result;
       }

       
       public Saldo leer()
       {
           Saldo temp = null;
           using (var db = new ModeloContainer())
           { 
              
              if (saldo.Id_vehiculo != 0)
              {
                  temp = (from a in db.SaldoSet where a.Id_vehiculo == saldo.Id_vehiculo select a).FirstOrDefault();
              }
           }return temp;

       }

    }
}
