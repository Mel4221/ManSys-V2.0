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
    public partial class mantenimientoDeducciones : Form
    {
        public mantenimientoDeducciones()
        {
            InitializeComponent();
        }
 
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mantenimientoDeducciones_Load(object sender, EventArgs e)
        {
			this.CargarDeducciones();
        }

		private bool Existe(string departamento)
		{
			using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
			{
				con.Open();
				//select * from dbo.Departamentos where Nombre = 'Telefono'
				string query = $"SELECT * FROM dbo.Deducciones	 WHERE Nombre = '{departamento}'";
				SqlCommand cmd = new SqlCommand(query, con);
				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					return true;

				}
				else
				{
					return false;
				}
			}

		}
		private void BuscarDeducciones()
		{
			try
			{
				if (this.txtbusqueda.Text == "")
				{
					this.CargarDeducciones();
					return;
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();//SELECT * FROM ask WHERE name LIKE 'ali'
					SqlCommand cmd = new SqlCommand($"SELECT * FROM dbo.Deducciones", con);

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
			catch (Exception ex)
			{
				ShowError($"Hubo un error al Buscar el Impuesto: '{this.txtbusqueda.Text}'", ex);
			}
		}
		private bool IsLike(string valueA, string valueB)
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
		private void CargarDeducciones()
		{
			try
			{

				using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
				{
					dataConnection.Open();
					DataTable departamentos = new DataTable();


					SqlDataAdapter daempleados = new SqlDataAdapter("SELECT * FROM dbo.Deducciones", dataConnection);


					daempleados.Fill(departamentos);

					ListadodeUsuarios.DataSource = departamentos;
				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un error al Cargar los Impuestos", ex);
			}
		}

		private void ShowError(string message, Exception ex)
		{
			MessageBox.Show($"{message}\n{ex}", "Algo Salio mal!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}
		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			if (this.txtnombre.Text == "" || this.txtcantidad.Text == "")
			{
				MessageBox.Show("Porfavor Agregar la informacion de la deduccion");
				return;
			}
			if (this.Existe(this.txtnombre.Text))
			{
				MessageBox.Show($"La Deduccion '{this.txtnombre.Text}' ya existe!!!");
				return;
			}
			if (!QuickTools.QCore.Get.IsNumber(this.txtcantidad.Text))
			{
				MessageBox.Show($"La cantidad no parece correcta {this.txtcantidad.Text}");
				return;
			}
			using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
			{

				try
				{
					con.Open();
					string query = $"INSERT INTO dbo.Deducciones(Nombre,Cantidad) values(@Nombre,@Cantidad)";

					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.AddWithValue("@Nombre", this.txtnombre.Text);
					cmd.Parameters.AddWithValue("@Cantidad", float.Parse(this.txtcantidad.Text));

					cmd.ExecuteNonQuery();
					this.CargarDeducciones();
				}
				catch (Exception ex)
				{
					ShowError($"Algo salio mal al Registrar La Deduccion '{this.txtnombre.Text}'", ex);
				}
			}
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (this.txtnombre.Text == "" || this.txtcantidad.Text == "")
			{
				MessageBox.Show("Porfavor Agregar la informacion del Deduccion");
				return;
			}
			//if (this.Existe(this.txtnombre.Text))
			//{
			//	MessageBox.Show($"El Impuesto '{this.txtnombre.Text}' ya existe!!!");
			//	return;
			//}
			if (!QuickTools.QCore.Get.IsNumber(this.txtcantidad.Text))
			{
				MessageBox.Show($"El porcentaje no parece correcto {this.txtcantidad.Text}");
				return;
			}

			if (txtid.Text == "" || txtnombre.Text == "")
			{
				MessageBox.Show("Porfavor completar los campos requeridos!!!");
				return;
			}
			using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
			{
				try
				{

					con.Open();
					string query = $"UPDATE dbo.Deducciones SET Nombre = @Nombre , Cantidad = @Cantidad WHERE Id = @Id";
					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
					cmd.Parameters["@Nombre"].Value = txtnombre.Text;

					cmd.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Float));
					cmd.Parameters["@Cantidad"].Value = txtcantidad.Text;

					cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
					cmd.Parameters["@Id"].Value = txtid.Text;

					cmd.ExecuteNonQuery();
					this.CargarDeducciones();
				}
				catch (Exception ex)
				{
					ShowError($"Hubo un error al tratar de actualizar el Impuesto con id'{txtid.Text}'", ex);
				}
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
			{
				try
				{

					if (txtid.Text == "")
					{
						MessageBox.Show("Porfavor completar los campos requeridos!!!");
						return;
					}
					con.Open();
					string query = $"DELETE FROM dbo.Deducciones WHERE Id = {txtid.Text}";
					SqlCommand cmd = new SqlCommand(query, con);
					cmd.ExecuteNonQuery();
					this.CargarDeducciones();
				}
				catch (Exception ex)
				{
					ShowError($"Hubo un error al tratar de eliminar la Deduccio con id'{txtid.Text}'", ex);
				}
			}
		}

		private void bntlimpiar_Click(object sender, EventArgs e)
		{
			this.txtid.Text = "";
			this.txtnombre.Text = "";
			this.txtcantidad.Text = "";
			this.txtbusqueda.Text = ""; 
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			this.BuscarDeducciones();
		}

		private void btnRefrescar_Click(object sender, EventArgs e)
		{
			this.CargarDeducciones();
		}

		private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
		{
			this.BuscarDeducciones();
		}
	}
}
