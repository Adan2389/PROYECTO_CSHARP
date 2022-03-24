using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace COBRANZAS.AdminDB
{
    public class TParamSql
    {
        // Generar la cadena de conexion y asignar los param. de conexion DB. 
        private SqlConnectionStringBuilder objBuilder = new SqlConnectionStringBuilder();

        // Asignando los parametros de conexion DB.
        public TParamSql() {
            objBuilder.DataSource = "LAPTOP-CJKKEAQ4\\MYSERVER";
            objBuilder.InitialCatalog = "PROYECTO_CSHARP";
            objBuilder.UserID = "sa";
            objBuilder.Password = "1234";
        }

        // Devulve la cadena de conexion del servidor de base datos
        public String getStringCon()
        {
            return objBuilder.ConnectionString;
        }

        // Devuelve el Usuario DB.
        public String getUser() {
            return objBuilder.UserID;
        }

        // Devuelve el Password DB.
        public String getPassword()
        {
            return objBuilder.Password;
        }

        // Devuelve el nombre server
        public String getServer()
        {
            return objBuilder.DataSource;
        }
        // Devuelve el nombre BD.
        public String getDatabase()
        {
            return objBuilder.InitialCatalog;
        }

    }
}
