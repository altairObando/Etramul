using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaControlador
{
    public static class CarreraController
    {

        public static int Agregar(int id_transaccion, int id_vehiculo, int id_conductor, TimeSpan salida, TimeSpan llegada, DateTime Fecha, bool vuelta)
        {
            Carrera car = new Carrera {
                Id_conductor = id_conductor,
                Id_vehiculo = id_vehiculo,
                FechaCarrera = Fecha,
                HoraSalida = salida, 
                HoraLlegada = llegada, 
                Vuelta_Completa = vuelta,
                No_transaccion = id_transaccion,
                Activo = true      
             };
            return new _Carrera(car).Agregar();
        }

        public static Carrera getUltima()
        {
            _Carrera car = new _Carrera(new Carrera());
            return car.getUltima();
        }

        public static int Eliminar(int codigo)
        {
            _Carrera car = new _Carrera(new Carrera { Id_carrera = codigo});
            return car.Eliminar();
        }
        public static List<Carrera> listar()
        {
            return new _Carrera(new Carrera()).Listar();
        }

        public static Carrera leer(int codigo)
        {
            return new _Carrera(new Carrera { Id_carrera = codigo }).Leer();
        }
    }
}
