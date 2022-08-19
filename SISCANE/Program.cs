using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickTools; 
using System.Configuration; 
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SISCANE
{
    static class Program
    {


            /// <summary>
            /// This method Get The connection string from the configuration file then return it 
            /// </summary>
            /// <returns>The Connection String </returns>
            public static string Connection()
        {
            string conection = null;

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["connection"];


            conection = settings.ConnectionString;

            return conection; 

        }




        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


            
              Color.Green("Starting ManSys...");
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch(Exception e)
            {
                Log.Event("FatalError",e);
                Color.Red("Something Really Bad just happened , more details : \n"+e);
            }
      
            
            

        }
    }
}
