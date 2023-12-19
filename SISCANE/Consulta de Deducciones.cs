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
    public partial class Consulta_de_Deducciones : Form
    {
        public Consulta_de_Deducciones()
        {
            InitializeComponent();
        }
      

        private void Consulta_de_Deducciones_Load(object sender, EventArgs e)
        {
            this.BuscarDeduciones();
        }

        private void Consulta_de_Deducciones_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BuscarDeduciones()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    con.Open();
                    string query, user;
                    query = this.Tipo.Text == "Applicacion Personal"&&this.txtnombre.Text == ""? null:this.Tipo.Text;
					user = this.txtnombre.Text;
                    
					switch (query)
                    {
                        
                        case "Applicacion Personal":
                                query = $"SELECT * FROM dbo.Deducciones WHERE Applicacion = '{user}'";
							break;
                        case "Applicacion A Todos":
							    query = $"SELECT * FROM dbo.Deducciones WHERE Applicacion = 'A Todos'";
							break;
                        case "Nombre":
							    query = $"SELECT * FROM dbo.Deducciones WHERE Nombre = '{user}'";
							break;
                        case "Valor":
							    query = $"SELECT * FROM dbo.Deducciones WHERE Cantidad = '{user}'";
							break;
						default:
                                query = "SELECT * FROM dbo.Deducciones"; 
                            break;

					}
					SqlDataAdapter adapter = new SqlDataAdapter(query,con);
					DataTable table = new DataTable();
                    adapter.Fill(table);
                    ListadoDeDeducciones.DataSource = table; 
				}
			}
			catch (Exception ex)
            {
                new Empleado().ShowError("Hubo un error al tratar de buscar las Deducciones", ex); 
            }
	 


		}
		private void txtnombre_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
                this.BuscarDeduciones();
				e.SuppressKeyPress = true;
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
            this.BuscarDeduciones();
		}

		private void btnRefrescar_Click(object sender, EventArgs e)
		{
            this.BuscarDeduciones();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
            this.txtnombre.Clear();
		}
	}
}
