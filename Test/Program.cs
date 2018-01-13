using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControlador;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Crear tipos de usuario
                TipoUsuarioController.agregar("Administrador");
                TipoUsuarioController.agregar("Cajero");
                //Creando usuario
                int admin = TipoUsuarioController.leer("Administrador").Id_tipo;
                UsuariosController.agregar("001-221190-0025A", "Noel", "Obando", "", "78553482", "", true, "altair", "123321", admin);
                //Creando un Socio
                SociosController.agregar(DateTime.Now.Date, "001-221190-0025A", "Pancho", "ramirez", "", "", "", true);
                ConductorController.agregar("213248798", "Macario", "Rocha", "", "", "", true, "213248798");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
