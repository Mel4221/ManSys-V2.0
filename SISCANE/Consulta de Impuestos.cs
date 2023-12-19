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
    public partial class Consulta_de_Impuestos : Form
    {
        public Consulta_de_Impuestos()
        {
            InitializeComponent();
        }
        
        

        private void Consulta_de_Impuestos_Load(object sender, EventArgs e)
        {
            // this.Close();
            this.BuscarImpuesto();
        }

        private void Consulta_de_Impuestos_MouseDown(object sender, MouseEventArgs e)
        {
         
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarImpuesto()
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

							query = $"SELECT * FROM dbo.Impuestos WHERE Id = {user}";
							break;
						case "Porcentage":
							if (!QuickTools.QCore.Get.IsNumber(user)) { MessageBox.Show($"El Tipo se encuentra en Porcentage , PERO EL VALOR NO ES DE TIPO NUMERICO  '{user}'"); return; }
							query = $"SELECT * FROM dbo.Impuestos WHERE Porcentage =  {user}";
							break;
						case "Nombre":
							query = $"SELECT * FROM dbo.Impuestos WHERE Nombre = '{user}'";
							break;
						default:
							query = "SELECT * FROM dbo.Impuestos";
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
				new Empleado().ShowError("Hubo un error al tratar de buscar los Impuestos", ex);
			}
		}
		private void btnBuscar_Click(object sender, EventArgs e)
		{
            this.BuscarImpuesto();
		}

		private void txtnombre_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.BuscarImpuesto();
				e.SuppressKeyPress = true;
			}
		}

		private void btnRefrescar_Click(object sender, EventArgs e)
		{
            this.BuscarImpuesto();
		}
	}
}
