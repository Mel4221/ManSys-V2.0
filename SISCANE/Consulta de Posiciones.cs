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
using System.Data.SqlTypes;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace ManSys
{
    public partial class Consulta_de_Posiciones : Form
    {
        public Consulta_de_Posiciones()
        {
            InitializeComponent();
        }
        private void CargarPosiciones()
		{
			using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
			{
				con.Open();
				SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Posiciones", con);
				DataTable table = new DataTable();
				adapter.Fill(table);
				this.ListadodeEmpleados.DataSource = table;

			}
		}
        private void Consulta_de_Posiciones_Load(object sender, EventArgs e)
        {
			this.CargarPosiciones();
        }

        private void Consulta_de_Posiciones_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void btnRefrescar_Click(object sender, EventArgs e)
		{
			this.CargarPosiciones();
		}
        private void BuscarPosicion()
        {
 			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					string query, user;
					query = this.txtnombre.Text == "" ? null : this.Tipo.Text;
					user  = this.txtnombre.Text;

					switch (query)
					{
						case "ID":
							if (!QuickTools.QCore.Get.IsNumber(user)) { MessageBox.Show($"El Tipo se encuentra en ID , PERO EL VALOR NO ES DE TIPO NUMERICO  '{user}'"); return; }
							query = $"SELECT * FROM dbo.Posiciones WHERE Id = {user}";
							break;
						case "Nombre":
							query = $"SELECT * FROM dbo.Posiciones WHERE Nombre = '{user}'";
							break;
						default:
							query = "SELECT * FROM dbo.Posiciones";
							break;

					}
					SqlDataAdapter adapter = new SqlDataAdapter(query, con);
					DataTable table = new DataTable();
					adapter.Fill(table);
					this.ListadodeEmpleados.DataSource = table;
				}
			}
			catch (Exception ex)
			{
				new Empleado().ShowError("Hubo un error al tratar de buscar las Posiciones", ex);
			}

		}
		private void btnBuscar_Click(object sender, EventArgs e)
		{
            this.BuscarPosicion();
		}

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BuscarPosicion();
            }
        }
	}
}
