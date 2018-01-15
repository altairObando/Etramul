using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.IO;

namespace CapaVista
{
    public static class Conexiones
    {
        /// <summary>
        /// Provee la cadena de conexion y los datos de login y password
        /// establecidos para el servidor del proyecto
        /// para CrystalDecisions.Shared y CristalDescision.CrystalReports.Engine
        /// </summary>
        /// <param name="reporte">Reporte al cual se establecera la autenticacion de base de datos</param>
        public static void SetReportConexion(ReportClass reporte)
        {
            try
            {
                //Instancia de Informacion de conexion
                var con = new ConnectionInfo();
                setConfiguracion();
                //Parametros de conexion
                con.DatabaseName = Database; //Nombre de db CASE SENSITIVE
                con.UserID = UserName; // Nombre de usuario
                con.Password = Password;//Contrasenia
                con.ServerName = ServerName;
                //Se obtienen todas las tablas o consultas que se utilizaran para mostrar el reporte
                var data = reporte.Database.Tables;
                for (int i = 0; i < reporte.Database.Tables.Count; i++)
                {
                    var login = new TableLogOnInfo();
                    login.ConnectionInfo = con;
                    reporte.Database.Tables[i].ApplyLogOnInfo(login);
                }
                try
                {
                    //Intentando con subreportes
                    for (int i = 0; i < reporte.Subreports.Count; i++)
                    {
                        for (int j = 0; j < reporte.Subreports[i].Database.Tables.Count; j++)
                        {
                            var login = new TableLogOnInfo();
                            login.ConnectionInfo = con;
                            reporte.Subreports[i].Database.Tables[j].ApplyLogOnInfo(login);
                        }
                    }
                    reporte.SetDatabaseLogon(UserName, Password, ServerName, Database);                
                }
                catch (Exception ex)
                {
                    
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static string ServerName { get; set; }
        private static string UserName { get; set; }
        private static string Password { get; set; }
        private static string Database { get; set; }
        private static string Path { get; set; }
        private static void setConfiguracion()
        {
            Path = Directory.GetCurrentDirectory() + "\\ServerConfig.data";
            try
            {
                using (var stream = new StreamReader(Path))
                {
                    ServerName = stream.ReadLine();
                    UserName = stream.ReadLine();
                    Password = stream.ReadLine();
                    Database = stream.ReadLine();
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
