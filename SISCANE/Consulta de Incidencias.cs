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
    public partial class Consulta_de_Incidencias : Form
    {
        public Consulta_de_Incidencias()
        {
            InitializeComponent();
        }
     

        private void Consulta_de_Incidencias_Load(object sender, EventArgs e)
        {
			this.BuscarIncidencias();
        }

        private void Consulta_de_Incidencias_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarIncidencias()
        {
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					string query, user;
					query = this.Tipo.Text == "ID"&&this.txtnombre.Text == "" ? null : this.Tipo.Text;
					user = this.txtnombre.Text;

					switch (query)
					{ 
						case "ID":
							if (!QuickTools.QCore.Get.IsNumber(user)) { MessageBox.Show($"El Tipo se encuentra en ID , PERO EL VALOR NO ES DE TIPO NUMERICO  '{user}'"); return; }
							query = $"SELECT * FROM dbo.Incidencias WHERE Id = {user}";
							break;
						case "EmpleadoId":
							if (!QuickTools.QCore.Get.IsNumber(user)) { MessageBox.Show($"El Tipo se encuentra en Porcentage , PERO EL VALOR NO ES DE TIPO NUMERICO  '{user}'"); return; }
							query = $"SELECT * FROM dbo.Incidencias WHERE EmpleadoId =  {user}";
							break;
						case "Departamento":
							query = $"SELECT * FROM dbo.Incidencias WHERE Departamento = '{user}'";
							break;
						default:
							query = "SELECT * FROM dbo.Incidencias";
							break;

					}
					SqlDataAdapter adapter = new SqlDataAdapter(query, con);
					DataTable table = new DataTable();
					adapter.Fill(table);
					ListadodeEmpleados.DataSource = table;
				}
			}
			catch (Exception ex)
			{
				new Empleado().ShowError("Hubo un error al tratar de buscar los Incidencias", ex);
			}
		}
		private void txtnombre_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.BuscarIncidencias();
				e.SuppressKeyPress = true;
			}
		}

		private void btnRefrescar_Click(object sender, EventArgs e)
		{
            this.BuscarIncidencias();
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
            this.txtnombre.Clear();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
            this.BuscarIncidencias();
		}
	}
}
