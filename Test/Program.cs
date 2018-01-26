using System;
using CapaControlador;
using CapaDatos;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guardamos transaccion
            new _Transaccion(new Transaccion { Id_usuario = 1, Id_Vehiculo = 23, FechaTransaccion = DateTime.Now.Date, Activo = true }).agregar();
            Console.WriteLine("transaccion guardada");
            var ult = new _Transaccion().getUltima();
            new _Abono(new Abono { Id_transaccion = ult.IdTransaccion, id_detalle = 1, Monto = 1000 }).Agregar();
            Console.WriteLine("Abono agregado");
            Console.ReadKey();
            //try
            //{
            ////Agregando Usuarios
            ////TipoUsuarioController.agregar("Administrador");
            ////TipoUsuarioController.agregar("Cajero");
            //////Usuario
            ////UsuariosController.agregar("001-221190-0025A", "Noel", "Obando", "", "78553482", "pxnfilo@gmail.com", true, "altair", "123321", 1);
            //UsuariosController.agregar("", "aizen", "souske", "", "", "", true, "aizen", "123321", 2);
            //    //Agregando Socios
            //    SociosController.agregar(DateTime.Now, "", "Hermogenes", " Martinez", "", "", "", true);
            //    SociosController.agregar(DateTime.Now, "", "Luis", "Martinez", "", "", "", true);
            //    SociosController.agregar(DateTime.Now, "", "Santos", "Somarriba", "", "", "", true);
            //    SociosController.agregar(DateTime.Now, "", "Miriam", "Morales", "", "", "", true);
            //    SociosController.agregar(DateTime.Now, "", "Maria", "Orozco", "", "", "", true);
            //    SociosController.agregar(DateTime.Now, "", "Carlos", "Sandoval", "", "", "", true);
            //    SociosController.agregar(DateTime.Now, "", "Edgar", "Fonseca", "", "", "", true);
            //    SociosController.agregar(DateTime.Now, "", "Daniel", "Chinchilla", "", "", "", true);
            //    SociosController.agregar(DateTime.Now, "", "Marvin", "Castañeda", "", "", "", true);
            //    Console.WriteLine("Ultimo Socio agregado");
            //    Console.WriteLine("Socios Agregados");
            //    //Data Source=.;Initial Catalog=Etramulv2;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True
            //    VehiculosController.agregar(2, "M 2287", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(2, "M 2023", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(2, "M 2024", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(2, "M 2434", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(2, "M 0574", "MERCEDEZ", "BENZ");

            //    VehiculosController.agregar(3, "M 1940", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(3, "M 2460", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(3, "M 2459", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(3, "M 0891", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(3, "M 2170", "MERCEDEZ", "BENZ");

            //    VehiculosController.agregar(4, "M 2348", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(4, "M 0813", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(4, "M 1093", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(4, "M 1528", "MERCEDEZ", "BENZ");

            //    VehiculosController.agregar(5, "M 0571", "MERCEDEZ", "BENZ");

            //    VehiculosController.agregar(6, "M 1890", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(6, "M 1277", "MERCEDEZ", "BENZ");

            //    VehiculosController.agregar(7, "M 2432", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(7, "M 1235", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(7, "M 2526", "MERCEDEZ", "BENZ");

            //    VehiculosController.agregar(8, "M 0620", "MERCEDEZ", "BENZ");

            //    VehiculosController.agregar(9, "M 2410", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(9, "M 2663", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(9, "M 1060", "MERCEDEZ", "BENZ");
            //    VehiculosController.agregar(9, "M 2433", "MERCEDEZ", "BENZ");

            //    VehiculosController.agregar(10, "M 2411", "MERCEDEZ", "BENZ");
            //    Console.WriteLine("Agregados");
            //    Console.ReadKey();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
