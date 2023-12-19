using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;


namespace ManSys
{
    public partial class ConsultadeDepartamentos : Form
    {


        public ConsultadeDepartamentos()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bntlimpiar_Click(object sender, EventArgs e)
        {
            txtbusqueda.Clear();
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;

            cn.Open();

            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Mantenimiento_de_Nomina WHERE Id like ('" + txtbusqueda.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            ListadodeDepartamentos.DataSource = dt;

            cn.Close();
        }

        private void ListadodeDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LLenarGridNomina()
        {
            //Codigo para llenar grid de empleados


            DataTable dtempleados = new DataTable();

            SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = dataConnection;

            SqlDataAdapter daempleados = new SqlDataAdapter("GetDB_Mantenimiento_de_Nomina", dataConnection);

            daempleados.SelectCommand.CommandType = CommandType.StoredProcedure;

            daempleados.Fill(dtempleados);

            ListadodeDepartamentos.DataSource = dtempleados;
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LLenarGridNomina();
        }

        private void Form6_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

		/*
         
            Combinado
Nombre
ID
         */
		private void BuscarDepartamento()
        {
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					string query, user;
					query = this.Tipo.Text == "Combinado"&&this.txtbusqueda.Text == "" ? null : this.Tipo.Text;
					user = this.txtbusqueda.Text;

					switch (query)
					{

						case "Combinado":
							if(QuickTools.QCore.Get.IsNumber(user)){
								query = $"SELECT * FROM dbo.Departamentos  WHERE Id = {user}";
							}
							if (!QuickTools.QCore.Get.IsNumber(user))
							{
								query = $"SELECT * FROM dbo.Departamentos  WHERE Nombre = '{user}'";
							}
							break;
						case "Nombre":
							query = $"SELECT * FROM dbo.Departamentos  WHERE Nombre = '{user}'";
							break;
						case "ID":
							query = $"SELECT * FROM dbo.Departamentos  WHERE Cantidad = '{user}'";
							break;
						default:
							query = "SELECT * FROM dbo.Departamentos ";
							break;

					}
					SqlDataAdapter adapter = new SqlDataAdapter(query, con);
					DataTable table = new DataTable();
					adapter.Fill(table);
					ListadodeDepartamentos.DataSource = table;
				}
			}
			catch (Exception ex)
			{
				new Empleado().ShowError("Hubo un error al tratar de buscar los Departamentos", ex);
			}
		}
        private void BuscarAvanzado()
        {
			try
			{
	 
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();//SELECT * FROM ask WHERE name LIKE 'ali'
					SqlCommand cmd = new SqlCommand($"SELECT * FROM dbo.Departamentos", con);

					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable filled = new DataTable();
					DataTable departamentos = new DataTable();
					adapter.Fill(departamentos);

					filled.Columns.Add("Id", typeof(int));
					filled.Columns.Add("Nombre", typeof(string));
		

					foreach (DataRow row in departamentos.Rows)
					{
						if (new MantenimientoDeEmpleados().IsLike(row["Nombre"].ToString().ToLower(), this.txtbusqueda.Text.ToLower()))
						{
							DataRow r = filled.NewRow();
							r["Id"]  = row["Id"];
							r["Nombre"] = row["Nombre"];
							
							filled.Rows.Add(r);

							//MessageBox.Show($"Row: {row["Nombre"].ToString()} Match: {this.Match(row["Nombre"].ToString(), this.txtbusqueda.Text)}");
							//if (!this.txtbusqueda.Items.Contains(row["Nombre"].ToString()))
							//{
							//	//this.txtbusqueda.Items.Add(row["Nombre"].ToString());
							//	}
							//this.txtbusqueda.Focus();
						}

					}
					this.ListadodeDepartamentos.DataSource = filled;

				}
				//this.txtbusqueda.CausesValidation = true;
				//this.txtbusqueda.DropDownStyle = ComboBoxStyle.DropDown;
				//this.txtbusqueda.DropDownStyle = ComboBoxStyle.DropDown;

			}
			catch (Exception ex)
			{
				new Empleado().ShowError("Hubo un error al tratar de buscar los Departamentos", ex);
			}
		}
		private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
		{
            if(this.BusquedaAvanzada.Checked)
            {
                this.BuscarAvanzado();
                return;
            }
			if (e.KeyCode == Keys.Enter)
			{
				this.BuscarDepartamento();
				e.SuppressKeyPress = true;
			}

		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
            this.BuscarDepartamento();
		}

		private void btnRefrescar_Click_1(object sender, EventArgs e)
		{
            this.BuscarDepartamento();
		}

		private void ConsultadeDepartamentos_Load(object sender, EventArgs e)
		{
			this.BuscarDepartamento();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			this.txtbusqueda.Clear();
		}
	}
}
