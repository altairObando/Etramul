using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaControlador
{
    public static class _AbonoController
    {
        public static int Agregar(int id_transac, int id_detalle, decimal monto)
        {
            if (id_transac < 1|| id_detalle < 1 || monto < 1)
                throw new NullReferenceException("No se ha ingresado la informacion correctamente!", new Exception("Valores en negativo o ceros!"));
            return new _Abono(new Abono { Id_transaccion = id_transac,id_detalle = id_detalle,Monto = monto }).Agregar();
        }
        public static Abono Leer(int id_abono)
        {
            if (id_abono <= 0)
                throw new Exception("Codigo de abono no valido");
            return new _Abono(new Abono { Id_abono = id_abono }).leer();
        }
        public static List<Abono> getAllAbono()
        {
            List<Abono> lista = new _Abono(new Abono()).getAllAbono();
            if (lista == null)
                throw new Exception("No se han registrado abonos en el sistema");
            return lista;
        }
        public static List<Abono> getAllAbono(int id_vehiculo)
        {
            var list = getAllAbono().Where(x => x.Transaccion.Id_Vehiculo.Equals(id_vehiculo)).ToList();
            if (list == null)
                throw new NullReferenceException("No se han registrado abonos con el vehiculo seleccionado", 
                    new Exception("Referencia a instancia nulll"));
            return list;
        }
        public static List<Abono> getAllAbono(DateTime fechaInicio, DateTime fechaFin)
        {
            var list = getAllAbono().Where(x =>
            x.Transaccion.FechaTransaccion >= fechaInicio.Date &&
            x.Transaccion.FechaTransaccion <= fechaFin.Date
            ).ToList();
            if (list == null)
                throw new NullReferenceException("No se han registrado abonos con el vehiculo seleccionado",
                    new Exception("Referencia a instancia nulll"));
            return list;
        }
        public static List<Abono> getAllAbono(int id_vehiculo, DateTime fechaInicio, DateTime fechaFin)
        {
            var list = getAllAbono().Where(x =>
            x.Transaccion.FechaTransaccion >= fechaInicio.Date &&
            x.Transaccion.FechaTransaccion <= fechaFin.Date &&
            x.Transaccion.Id_Vehiculo.Equals(id_vehiculo)
            ).ToList();
            if (list == null)
                throw new NullReferenceException("No se han registrado abonos con el vehiculo seleccionado",
                    new Exception("Referencia a instancia null"));
            return list;
        }
        public static int Anular(int id_abono)
        {
            if (id_abono <= 0)
                throw new Exception("El codigo del abono no puede ser cero ó Negativo");
            return new _Abono(new Abono { Id_abono = id_abono }).anular();
        }
    }
}

