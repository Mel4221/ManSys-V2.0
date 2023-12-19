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
    public partial class ConsultaDeEmpleados : Form
    {
        public ConsultaDeEmpleados()
        {
            InitializeComponent();
        }

  
 
       
       

      

        private void ConsultaDeEmpleados_Load(object sender, EventArgs e)
        {
			this.BuscarEmpleados();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

      
        private void LLenarGridEmpleados()
        {
            //Codigo para llenar grid de empleados

             
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LLenarGridEmpleados();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
	 


		private string ToPhone(string input)
		{
			string phone = input;
			string area = phone.Substring(0, 3);
			string major = phone.Substring(3, 3);
			string minor = phone.Substring(6);
			string formatted = string.Format("{0} {1}-{2}", area, major, minor);
			return formatted;
		}
        private void BuscarEmpleados()
        {
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					string query, user;
					query = this.Tipo.Text == "ID"&&this.txtbusqueda.Text == "" ? null : this.Tipo.Text;
					user = this.txtbusqueda.Text;
					/*
ID
CEDULA
TELEFONO
NOMBRE+APELLIDOS
					 */
					switch (query)
					{

						case "ID":
							query = $"SELECT * FROM dbo.Empleados WHERE Id = {user}";
							break;
						case "CEDULA":
							query = $"SELECT * FROM dbo.Empleados WHERE  CEDULA = '{user}'";
							break;
						case "TELEFONO":
							query = $"SELECT * FROM dbo.Empleados WHERE Telefono = '{this.ToPhone(user)}'";
							break;
						case "NOMBRE":
							query = $"SELECT * FROM dbo.Empleados WHERE Nombre = '{user}' ";
							break;
						default:
							query = "SELECT * FROM dbo.Empleados";
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
				new Empleado().ShowError("Hubo un error al tratar de buscar los Empleados", ex);
			}


		}
		private void btnBuscar_Click(object sender, EventArgs e)
		{
			this.BuscarEmpleados();
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
					filled.Columns.Add("Apellido", typeof(string));
					filled.Columns.Add("Direccion", typeof(string));
					filled.Columns.Add("Telefono", typeof(string));
					filled.Columns.Add("Fecha_de_Ingreso", typeof(string));
					filled.Columns.Add("Puesto_Ocupado", typeof(string));
					filled.Columns.Add("Departamento", typeof(string));
					filled.Columns.Add("CEDULA", typeof(string));
					filled.Columns.Add("Salario_Base", typeof(string));
					filled.Columns.Add("Tipo_de_Cobro", typeof(string));
					filled.Columns.Add("Turno", typeof(string));



					foreach (DataRow row in departamentos.Rows)
					{
						if (new MantenimientoDeEmpleados().IsLike(row["Nombre"].ToString().ToLower(), this.txtbusqueda.Text.ToLower()))
						{
							DataRow r = filled.NewRow();
							r["Id"]  = row["Id"];
							r["Nombre"] = row["Nombre"];
							r["Apellido"] = row["Apellido"];
							r["Direccion"] = row["Direccion"];
							r["Telefono"] = row["Telefono"];
							r["Fecha_de_Ingreso"] = row["Fecha_de_Ingreso"];
							r["Puesto_Ocupado"] = row["Puesto_Ocupado"];
							r["Departamento"] = row["Departamento"];
							r["CEDULA"] = row["CEDULA"];
							r["Salario_Base"] = row["Salario_Base"];
							r["Tipo_de_Cobro"] = row["Tipo_de_Cobro"];
							r["Turno"] = row["Turno"];

							filled.Rows.Add(r);

							//MessageBox.Show($"Row: {row["Nombre"].ToString()} Match: {this.Match(row["Nombre"].ToString(), this.txtbusqueda.Text)}");
							//if (!this.txtbusqueda.Items.Contains(row["Nombre"].ToString()))
							//{
							//	//this.txtbusqueda.Items.Add(row["Nombre"].ToString());
							//	}
							//this.txtbusqueda.Focus();
						}

					}
					this.ListadodeEmpleados.DataSource = filled;

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
			}
			if (e.KeyCode == Keys.Enter)
			{
				this.BuscarEmpleados();
				e.SuppressKeyPress = true;
			}
		}
	}
}
