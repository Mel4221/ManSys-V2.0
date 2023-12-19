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



			try
			{

				Get.Green("Starting ManSys...");
				Log.Event("ProgramFlow", $"Program Started: {DateTime.Now}");
				Application.EnableVisualStyles();
				//Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MenuPrincipal());
				//Application.Run(new MantenimientoDeEmpleados());
				//Application.Run(new mantenimientoDept());
				//Application.Run(new mantenimientoPosc());
				//Application.Run(new mantenimientoImp
				//Application.Run(new mantenimientoDeducciones()); 
				//Application.Run(new Mantenimiento_de_Horario());
				//Application.Run(new GenerarVolanteDePago());
				//Application.Run(new GenerarNomina());
				//Application.Run(new Incidencias());
				//Application.Run(new GenerarNomina()); 
				//Application.Run(new Bonificaciones());
				//Application.Run(new GenerarVolanteDePago());
				//Application.Run(new VolanteDePago());
				//Application.Run(new Empleado());
				//Application.Run(new Consulta_de_Deducciones());
				//Application.Run(new ConsultadeDepartamentos());
				//Application.Run(new ConsultaDeEmpleados());
				//Application.Run(new Consulta_de_Impuestos());
				//Application.Run(new Consulta_de_Incidencias());	
				//Application.Run(new Generar_JornadaLaboral());
			}
			catch (Exception e)
			{
				Log.Event("FatalError", e);
				Get.Red("Something Really Bad just happened , more details : \n"+e);
				Get.Wait();
			}




}
	}
}
