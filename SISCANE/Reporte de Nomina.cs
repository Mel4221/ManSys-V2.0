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
    public partial class ReporteDeNomina : Form
    {
        public ReporteDeNomina()
        {
            InitializeComponent();
        }

        DataTable _Nomina;
        private void ReporteDeNomina_Load(object sender, EventArgs e)
        {
			// TODO: esta línea de código carga datos en la tabla 'ManSysDataSet.Mantenimiento_de_Nomina' Puede moverla o quitarla según sea necesario.
			this.CargarNomina();
            try{
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Nomina",con);
                    this._Nomina = new DataTable();
                    adapter.Fill(this._Nomina);
                    this.ReporteDeNominaGrid.DataSource = this._Nomina; 
                }
            }catch(Exception ex)
            {
                new MantenimientoDeEmpleados().ShowError("Hubo un error al cargar la Nomina", ex); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		private void CargarNomina()
		{

			try
			{

				using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
				{
					dataConnection.Open();
					DataTable nomina = new DataTable();
					DataTable filtro = new DataTable();
					filtro.Columns.Add("Periodo", typeof(string));
					//filtro.Columns.Add("Fecha", typeof(string));

					SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Nomina", dataConnection);
					adapter.Fill(nomina);
					List<string> lista = new List<string>();
					foreach (DataRow row in nomina.Rows)
					{
						if (!lista.Contains(row["Periodo"].ToString()))
						{
							lista.Add(Name = row["Periodo"].ToString());
						}
					}
					lista.ForEach((item) => {
						this.PeriodoDeNomina.Items.Add(item);
					});



				}
			}
			catch (Exception ex)
			{
				new Empleado().ShowError("Hubo un error al Cargar las Nominas", ex);
			}

		}
		private void ReporteDeNomina_MouseDown(object sender, MouseEventArgs e)
        {
             
        }

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void ReporteDeNominaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void BuscarNomina()
		{
			try
			{

				using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
				{
					dataConnection.Open();
					DataTable nomina = new DataTable();
				 
					string	query = $"SELECT * FROM dbo.Nomina WHERE Periodo = '{PeriodoDeNomina.Text}'";
					 

					SqlDataAdapter adapter = new SqlDataAdapter(query, dataConnection);
					adapter.Fill(nomina);

					this.ReporteDeNominaGrid.DataSource = nomina;

				}
			}
			catch (Exception ex)
			{
				new Empleado().ShowError("Hubo un error al Cargar las Nominas", ex);
			}
		}

		private void PeriodoDeNomina_TextChanged(object sender, EventArgs e)
		{
			this.BuscarNomina();
		}
	}
}
