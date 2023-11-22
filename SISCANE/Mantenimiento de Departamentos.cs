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
using System.Collections;
using QuickTools.QData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ManSys
{
    public partial class mantenimientoDept : Form
    {
        public mantenimientoDept()
        {
            InitializeComponent();
        }


        private void mantenimientoDept_Load(object sender, EventArgs e)
        {
            this.CargarDepartamentos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mantenimientoDept_MouseDown_1(object sender, MouseEventArgs e)
        {

        }
		private  bool IsLike(string valueA, string valueB)
		{
			int b = 0;
			try
			{
				if (valueB.Length == 1)
				{
					if (valueA[0] == valueB[0])
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				for (int ch = 0; ch < valueA.Length; ch++)
				{

					if (valueA[ch] != valueB[b])
					{
						return false;
					}
					if (b < valueB.Length)
					{
						b++;
					}
					if (b == valueB.Length -1)
					{
						return true;
					}

				}
				return true;
			}
			catch
			{
				return false;
			}
		}
		
		private bool Existe(string departamento)
        {
            using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
            {
                con.Open();
				//select * from dbo.Departamentos where Nombre = 'Telefono'
				string query = $"SELECT * FROM dbo.Departamentos WHERE Nombre = '{departamento}'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;

                }else{
                    return false; 
                }
            }
			
		}

	
		private void btnRegistrar_Click(object sender, EventArgs e)
		{
            
            if(this.txtnombre.Text == "")
            {
                MessageBox.Show("Porfavor Agregar la informacion del departamento");
                return;
            }
            if(this.Existe(this.txtnombre.Text)){
				MessageBox.Show($"El Departamento '{this.txtnombre.Text}' ya existe!!!");
				return;
            }
            using(SqlConnection con = new SqlConnection(Connection.ConnectionString))
            {
		
                try{
					con.Open();
					string query = $"INSERT INTO dbo.Departamentos(Nombre) values(@Nombre)";

					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.AddWithValue("@Nombre", this.txtnombre.Text);
					cmd.ExecuteNonQuery();
                    this.CargarDepartamentos();
				}
				catch (Exception ex){
                    ShowError($"Algo salio mal al Registrar el Departamento '{this.txtnombre.Text}'",ex);
                }
            }
            
            

		}
        private void CargarDepartamentos()
        {
            try{

				using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
				{
					dataConnection.Open();
					DataTable departamentos = new DataTable();


					SqlDataAdapter daempleados = new SqlDataAdapter("SELECT * FROM dbo.Departamentos", dataConnection);


					daempleados.Fill(departamentos);

					ListadodeUsuarios.DataSource = departamentos;
				}
			}
			catch(Exception ex ){
                ShowError($"Hubo un error al Cargar los Departamentos", ex);
            }
		}   
		private void btnRefrescar_Click(object sender, EventArgs e)
		{
            this.CargarDepartamentos(); 
		}
		private void ShowError(string message, Exception ex)
		{
			MessageBox.Show($"{message}\n{ex}", "Algo Salio mal!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}
		private void btnEliminar_Click(object sender, EventArgs e)
		{
            using(SqlConnection con = new SqlConnection(Connection.ConnectionString))
            {
                try{

					if (txtid.Text == "")
					{
						MessageBox.Show("Porfavor completar los campos requeridos!!!");
						return;
					}
					con.Open();
					string query = $"DELETE FROM dbo.Departamentos WHERE Id = {txtid.Text}";
					SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    this.CargarDepartamentos();
				}
				catch (Exception ex){
                    ShowError($"Hubo un error al tratar de eliminar el Departamento con id'{txtid.Text}'", ex);
                }
            }
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
			{
				try
				{

					if (txtid.Text == "" || txtnombre.Text == "")
					{
						MessageBox.Show("Porfavor completar los campos requeridos!!!");
						return;
					}
					con.Open();
					string query = $"UPDATE dbo.Departamentos SET Nombre = '{txtnombre.Text}' WHERE Id = {txtid.Text}";
					SqlCommand cmd = new SqlCommand(query, con);
					cmd.ExecuteNonQuery();
					this.CargarDepartamentos();
				}
				catch (Exception ex)
				{
					ShowError($"Hubo un error al tratar de actualizar el Departamento con id'{txtid.Text}'", ex);
				}
			}
		}

        private void BuscarDepartamento()
        {
            try{
				if(this.txtbusqueda.Text == "")
				{
					this.CargarDepartamentos();
					return;
				}
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
						if (this.IsLike(row["Nombre"].ToString().ToLower(), this.txtbusqueda.Text.ToLower()))
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
					this.ListadodeUsuarios.DataSource = filled;

				}
				//this.txtbusqueda.CausesValidation = true;
				//this.txtbusqueda.DropDownStyle = ComboBoxStyle.DropDown;
				//this.txtbusqueda.DropDownStyle = ComboBoxStyle.DropDown;

			}
			catch (Exception ex){
                ShowError($"Hubo un error al Buscar el Departamento: '{this.txtbusqueda.Text}'", ex);
            }
        }
		private void bntlimpiar_Click(object sender, EventArgs e)
		{
            this.txtnombre.Text = "";
            this.txtid.Text = "";
            this.txtbusqueda.Text = "";

		}

		private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
                this.BuscarDepartamento();
				e.SuppressKeyPress = false;
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
            this.BuscarDepartamento();
		}


		private void txtbusqueda_KeyDown_1(object sender, KeyEventArgs e)
		{
			this.BuscarDepartamento();
			e.SuppressKeyPress = false;

		}
	}
}
