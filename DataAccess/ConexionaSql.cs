using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConexionaSql
    {
        private readonly string connectionString;
        public ConexionaSql() {
            connectionString = "integrated security=SSPI;data source=DESKTOP-802OK33;" + "persist security info=False;initial catalog=SISCANE";
        }
        protected SqlConnection GetConnection(){
            return new SqlConnection(connectionString);
        }
    }
}
