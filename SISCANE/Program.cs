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
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


            
              Color.Green("Starting ManSys...");
          
                Log.Event("LastStarted","The Program Attendted to start for the last time on "+DateTime.UtcNow+"\n");
  
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form3());

         

      
            
            

        }
    }
}
