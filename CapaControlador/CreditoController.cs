using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaControlador
{
    public static class CreditoController
    {
        public static int Agregar(int id_detalle, decimal saldo)
        {
            Credito data = new Credito { id_detalle = id_detalle, saldo = saldo, cancelado = false, anulado = false};
            return new _Credito(data).agregar();
        }
        public static Credito Leer(int id_credito)
        {
            Credito data = new Credito { Id_credito = id_credito };
            return new _Credito(data).leer();
        }
        public static List<Credito> Listar()
        {
            return new _Credito(new Credito()).getAllCredito();
        }
        public static List<Credito> Listar(int id_vehiculo)
        {
            return new _Credito(new Credito()).getAllCredito(id_vehiculo);
        }
        public static List<Credito> Listar(int id_rubro, DateTime fecha)
        {
            return new _Credito(new Credito()).getAllCredito(id_rubro, fecha.Date);
        }
        public static int anular(int id_credito)
        {
            return new _Credito(new Credito { Id_credito = id_credito }).Anular();
        }
    }
}
