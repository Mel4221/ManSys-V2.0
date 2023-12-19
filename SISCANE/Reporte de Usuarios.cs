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
    public partial class ReporteDeUsuarios : Form
    {
        public ReporteDeUsuarios()
        {
            InitializeComponent();
        }

     

        private void Form8_Load(object sender, EventArgs e)
        {
            this.CargarUsuarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form8_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void CargarUsuarios()
        {
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Gestion_de_Jornada", con);
					DataTable table  = new DataTable();
					adapter.Fill(table);
                    this.Listado_de_Usuarios.DataSource = table;
				}
			}
			catch (Exception ex)
			{
				new MantenimientoDeEmpleados().ShowError("Hubo un error al cargar la Nomina", ex);
			}
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			this.CargarUsuarios();
		}

		private void FechaDeJornada_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Gestion_de_Jornada", con);
					DataTable table = new DataTable();
					DataTable filtro = new DataTable();
					filtro.Columns.Add("EmpleadoId", typeof(int));
					filtro.Columns.Add("Empleado", typeof(string));
					filtro.Columns.Add("Fecha", typeof(string));
					filtro.Columns.Add("Entrada", typeof(string));
					filtro.Columns.Add("Salida", typeof(string));
					filtro.Columns.Add("HorasTrabajadas", typeof(float));

					adapter.Fill(table);

					foreach (DataRow row in table.Rows)
					{
						if (row["Fecha"].ToString() == FechaDeJornada.Value.ToString("dd/MM/yyyy"))
						{
							DataRow r = filtro.NewRow();
							r["EmpleadoId"] = row["EmpleadoId"];
							r["Empleado"] = row["Empleado"];
							r["Fecha"] = row["Fecha"];
							r["Entrada"] = row["Entrada"];//EmpleadoId,Empleado,Fecha,Entrada,Salida,
							r["Salida"] = row["Salida"];
							r["HorasTrabajadas"] = row["HorasTrabajadas"];
							filtro.Rows.Add(r);
						}
					}
					this.Listado_de_Usuarios.DataSource = filtro;
				}
			}
			catch (Exception ex)
			{
				new MantenimientoDeEmpleados().ShowError($"Hubo un error al tratar de Cargar las Entradas Y Salidas", ex);
			}
		}
	}
}
