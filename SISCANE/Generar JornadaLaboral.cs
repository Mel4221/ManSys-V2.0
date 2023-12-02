using QuickTools.QConsole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManSys
{
	public partial class Generar_JornadaLaboral : Form
	{
		public Generar_JornadaLaboral()
		{
			InitializeComponent();
		}

		private void Generar_JornadaLaboral_Load(object sender, EventArgs e)
		{
			//this.ContentPanel.PointToClient
			this.toolStripContainer1.Location = new Point(150, 100);
			this.ListadoDeEntradsSalidas.Height = this.Height-25;
			this.Contra.UseSystemPasswordChar = true;
			this.HoraActualTimer.Enabled = true;
			this.ListadoDeEntradasYSalidasTimer.Enabled = true;
			this.HoraActualTimer.Start();
			this.ListadoDeEntradasYSalidasTimer.Start();
 		}
	 
		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
 		private bool ExisteEntrada(string usuario , string fecha)
		{
			try
			{
				using (SqlConnection cn = new SqlConnection(Connection.ConnectionString))
				{
					cn.Open();

					SqlCommand cm = new SqlCommand("SELECT * FROM dbo.Gestion_de_Jornada WHERE EmpleadoId = @EmpleadoId AND Fecha = @Fecha", cn);

					cm.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
					cm.Parameters["@EmpleadoId"].Value = usuario;
					cm.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
					cm.Parameters["@Fecha"].Value = fecha;
				

					SqlDataReader reader = cm.ExecuteReader();


					if (reader.Read())
					{
						return true;
					}
					return false;
				}
			}
			catch
			{
				return false;
			}
		}
		private bool UsuarioValido(string usuario,string contra)
		{
			try
			{
				using (SqlConnection cn = new SqlConnection(Connection.ConnectionString))
				{
					cn.Open();

					SqlCommand cm = new SqlCommand("SELECT * FROM dbo.Gestion_de_Usuarios WHERE EmpleadoId = @EmpleadoId AND Contra = @Contra ", cn);


					cm.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
					cm.Parameters["@EmpleadoId"].Value = usuario;
					cm.Parameters.Add(new SqlParameter("@Contra", SqlDbType.VarChar));
					cm.Parameters["@Contra"].Value = contra;

					SqlDataReader reader = cm.ExecuteReader();


					if (reader.Read())
					{
						this.EntradaUsuario = reader.GetValue(1).ToString();					
						return true;
					}
					return false;
				}
			}
			catch
			{
				return false;
			}
		}
		private string EntradaUsuario { get; set; } = null;
		public void ShowError(string message, Exception ex)
		{
			MessageBox.Show($"{message}\n{ex}", "Algo Salio mal!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}
		private void btnEntrada_Click(object sender, EventArgs e)
		{

			if (this.txtId.Text == "")
			{
				MessageBox.Show("Falta el ID del Empleado");
				return;
			}
			if (this.Contra.Text == "")
			{
				MessageBox.Show("Falta La contraseña del Empleado");
				return;
			}
 			if (!this.UsuarioValido(this.txtId.Text,this.Contra.Text))
			{
				MessageBox.Show("El ID Del Empleado o Contraseña Son incorrectos!!!");
				return;
			}if(this.ExisteEntrada(this.txtId.Text,DateTime.Now.ToString("dd/MM/yyyy")))
			{
				MessageBox.Show("La Entrada ya fue Realizada!!!");
				this.LimpiarCampos(); 
				return;
			}
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Gestion_de_Jornada(EmpleadoId,Empleado,Fecha,Entrada,Salida,HorasTrabajadas)values(@EmpleadoId,@Empleado,@Fecha,@Entrada,@Salida,@HorasTrabajadas)", con);
					cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
					cmd.Parameters["@EmpleadoId"].Value = this.txtId.Text;

					cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
					cmd.Parameters["@Empleado"].Value = this.EntradaUsuario;

					cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
					cmd.Parameters["@Fecha"].Value = DateTime.Now.ToString("dd/MM/yyyy");

					cmd.Parameters.Add(new SqlParameter("@Entrada", SqlDbType.VarChar));
					cmd.Parameters["@Entrada"].Value = DateTime.Now.ToString("hh:mm");

					cmd.Parameters.Add(new SqlParameter("@Salida", SqlDbType.VarChar));
					cmd.Parameters["@Salida"].Value = "Pendiente...";

					cmd.Parameters.Add(new SqlParameter("@HorasTrabajadas", SqlDbType.Float));
					cmd.Parameters["@HorasTrabajadas"].Value = 0;
					cmd.ExecuteNonQuery();
					this.LimpiarCampos(); 
				   
				}
			}catch(Exception ex)
			{
				this.ShowError($"Hubo un error al Tratar de Iniciar la Jornada de {this.EntradaUsuario}", ex);
			}
		}
		private void LimpiarCampos()
		{
			this.txtId.Clear();
			this.Contra.Clear(); 
		}
		private void HoraActualTimer_Tick(object sender, EventArgs e)
		{
			this.HoraActual.Text = $"Hora Actual: {DateTime.Now}";
		}
		private void CargarEntradasYSalidas()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Gestion_de_Jornada", con);
					DataTable table = new DataTable();
					DataTable filtro = new DataTable();
					filtro.Columns.Add("EmpleadoId", typeof(int));
					filtro.Columns.Add("Entrada", typeof(string));
					filtro.Columns.Add("Salida", typeof(string));

					adapter.Fill(table);
					foreach(DataRow row in table.Rows)
					{
						if(row["Fecha"].ToString() == DateTime.Now.ToString("dd/MM/yyyy"))
						{
							DataRow r = filtro.NewRow();
							r["EmpleadoId"] = row["EmpleadoId"];
							r["Entrada"] = row["Entrada"];//EmpleadoId,Empleado,Fecha,Entrada,Salida,
							r["Salida"] = row["Salida"];
							filtro.Rows.Add(r);

						}
					}
					this.ListadoDeEntradsSalidas.DataSource = filtro; 
				}
			}catch(Exception ex)
			{
				this.ShowError($"Hubo un error al tratar de Cargar las Entradas Y Salidas", ex);
			}
		}
		private void ListadoDeEntradasYSalidas_Tick(object sender, EventArgs e)
		{
			this.CargarEntradasYSalidas();
		}

		private void ListadoDeEntradasYSalidasTimer_Tick(object sender, EventArgs e)
		{
			this.CargarEntradasYSalidas();
		}

		private void btnSalida_Click(object sender, EventArgs e)
		{

			if (this.txtId.Text == "")
			{
				MessageBox.Show("Falta el ID del Empleado");
				return;
			}
			if (this.Contra.Text == "")
			{
				MessageBox.Show("Falta La contraseña del Empleado");
				return;
			}
			if (!this.UsuarioValido(this.txtId.Text, this.Contra.Text))
			{
				MessageBox.Show("El ID Del Empleado o Contraseña Son incorrectos!!!");
				return;
			}
			if (!this.ExisteEntrada(this.txtId.Text, DateTime.Now.ToString("dd/MM/yyyy")))
			{
				MessageBox.Show("No Existe Ninguna Entrada");
				//this.LimpiarCampos();
				return;
			}
		}
	}
}
