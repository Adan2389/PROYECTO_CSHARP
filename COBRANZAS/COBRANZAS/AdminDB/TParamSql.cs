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
        private SqlConnectionStringBuilder objBuilder = new SqlConnectionStringBuilder();
        public TParamSql() {
            objBuilder.DataSource = "LAPTOP-CJKKEAQ4\\MYSERVER";
            objBuilder.InitialCatalog = "PROYECTO_CSHARP";
            objBuilder.UserID = "sa";
            objBuilder.Password = "1234";
        }

        // Devulve las credencias del servidor de base datos
        public String getStringCon()
        {
            return objBuilder.ConnectionString;
        }

        public String getUser() {
            return objBuilder.UserID;
        }

        public String getPassword()
        {
            return objBuilder.Password;
        }

        public String getServer()
        {
            return objBuilder.DataSource;
        }
        public String getDatabase()
        {
            return objBuilder.InitialCatalog;
        }

    }
}
