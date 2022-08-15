using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SISCANE.Conexion
{
    class clsConexion
    {
        public SqlConnection conn = new SqlConnection();
        public clsConexion()
        {
            conn.ConnectionString = "integrated security=SSPI;data source=LAPTOP-LOPEZ;" + "persist security info=False;initial catalog=SISCANE";

        }

    }
}
