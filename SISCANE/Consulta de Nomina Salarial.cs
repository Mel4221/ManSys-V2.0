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
using QuickTools.QData;

namespace ManSys
{
    public partial class ConsultadeNominaSalarial : Form
    {
        public ConsultadeNominaSalarial()
        {
            InitializeComponent();
        }
       
       

        private void generarnomina_Load(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadodeNominaRegistrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

		private void ConsultadeNominaSalarial_Load(object sender, EventArgs e)
		{
            this.CargarNomina();
		}
        private void BuscarNomina()
		{

			try
			{

				using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
				{
					dataConnection.Open();
					DataTable nomina = new DataTable();
					string query = PeriodoDeNomina.Text; 
					if(this.txtcodigo.Text == ""){
						query = $"SELECT * FROM dbo.Nomina WHERE Periodo = '{PeriodoDeNomina.Text}'";
					}if(this.txtcodigo.Text != "")
					{
						if (!QuickTools.QCore.Get.IsNumber(this.txtcodigo.Text)) { MessageBox.Show($"El Tipo se encuentra en ID , PERO EL VALOR NO ES DE TIPO NUMERICO  '{this.txtcodigo.Text}'"); return; }
						query = $"SELECT * FROM dbo.Nomina WHERE Periodo = '{PeriodoDeNomina.Text}' AND EmpleadoId = {this.txtcodigo.Text}";
					}

					SqlDataAdapter adapter = new SqlDataAdapter(query, dataConnection);
					adapter.Fill(nomina);
 					 
					this.ListadodeNominaRegistrada.DataSource = nomina;

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

		private void bntlimpiar_Click(object sender, EventArgs e)
		{
			this.txtcodigo.Clear();
			this.PeriodoDeNomina.Text = "";
		}
	}
}
