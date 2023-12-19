using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace ManSys
{
    public partial class ReporteDeEmpleados : Form
    {
        public ReporteDeEmpleados()
        {
            InitializeComponent();
        }
 
        private void ReporteDeEmpleados_Load(object sender, EventArgs e)
        {

			this.CargarEmpleados();
        }
        private void CargarEmpleados()
        {
			try
			{

				using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
				{
					dataConnection.Open();
					DataTable dtempleados = new DataTable();
					SqlDataAdapter daempleados = new SqlDataAdapter("GetDB_Mantenimiento_de_Empleados", dataConnection);
					daempleados.SelectCommand.CommandType = CommandType.StoredProcedure;
					daempleados.Fill(dtempleados);
					this.Listado_de_Empleados.DataSource = dtempleados;
				}
			}
			catch (Exception ex)
			{
				new MantenimientoDeEmpleados().ShowError("Hubo un error al Cargar los Empleados", ex);
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReporteDeEmpleados_MouseDown(object sender, MouseEventArgs e)
        {

             
        }

		private void button1_Click(object sender, EventArgs e)
		{
			this.CargarEmpleados();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			try
			{

				using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
				{
					dataConnection.Open();
					DataTable dtempleados = new DataTable();
					SqlDataAdapter daempleados = new SqlDataAdapter($"SELECT * FROM dbo.Empleados WHERE Fecha_de_Ingreso = '{dateTimePicker1.Value.ToString("dd/MM/yyyy")}'", dataConnection);
					//daempleados.SelectCommand.CommandType = CommandType.StoredProcedure;
					daempleados.Fill(dtempleados);
					this.Listado_de_Empleados.DataSource = dtempleados;
				}
			}
			catch (Exception ex)
			{
				new MantenimientoDeEmpleados().ShowError("Hubo un error al Cargar los Empleados", ex);
			}
		}
	}
}
