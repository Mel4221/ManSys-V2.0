using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickTools.QCore;
using QuickTools.QIO;
using QuickTools.QColors; 
using System.Configuration; 
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ManSys
{
    static class Program
    {




        public const string ProgramKey = "8wWGJ23446L";


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


            
              Color.Green("Starting ManSys...");
            Log.Event("ProgramFlow",$"Program Started: {DateTime.Now}");
            //try
            //{
            Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new MenuPrincipal());
			//Application.Run(new MantenimientoDeEmpleados());
			//Application.Run(new mantenimientoDept());
			//Application.Run(new mantenimientoPosc());
			//Application.Run(new mantenimientoImp
			//Application.Run(new mantenimientoDeducciones()); 
			//Application.Run(new GenerarVolanteDePago());
			//Application.Run(new GenerarNomina());
			//Application.Run(new Incidencias());
			//Application.Run(new GenerarNomina()); 
			Application.Run(new Empleado());
			//}
			//catch (Exception e)
			//{
			//    Log.Event("FatalError",e);
			//    Color.Red("Something Really Bad just happened , more details : \n"+e);
			//}




		}
	}
}
