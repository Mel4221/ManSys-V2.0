using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManSys
{
	public partial class Mantenimiento_de_Horario : Form
	{
		public Mantenimiento_de_Horario()
		{
			InitializeComponent();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					SqlCommand cmd = new SqlCommand("UPDATE dbo.Gestion_de_Jornada SET EmpleadoId = @EmpleadoId ,Empleado = @Empleado,Fecha = @Fecha,Entrada = @Entrada,Salida = @Salida,HorasTrabajadas = @HorasTrabajadas WHERE EmpleadoId = @EmpleadoId AND Fecha = @Fecha", con);
					
					cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
					cmd.Parameters["@EmpleadoId"].Value = this.EmpleadoId.Text;

					cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
					cmd.Parameters["@Empleado"].Value = this.NomreDeEmpleado.Text;

					cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
					cmd.Parameters["@Fecha"].Value = this.FechaDeJornada.Value.ToString("dd/MM/yyyy");

					cmd.Parameters.Add(new SqlParameter("@Entrada", SqlDbType.VarChar));
					cmd.Parameters["@Entrada"].Value = this.HoraDeEntrada.Value.ToString("hh:mm tt");

					cmd.Parameters.Add(new SqlParameter("@Salida", SqlDbType.VarChar));
					cmd.Parameters["@Salida"].Value = this.HoraDeSalida.Value.ToString("hh:mm tt");

					cmd.Parameters.Add(new SqlParameter("@HorasTrabajadas", SqlDbType.Float));
					cmd.Parameters["@HorasTrabajadas"].Value = this.HorasTrabajadas.Text; //((DateTime.Now-DateTime.ParseExact(this.HoraDeEntrada, "hh:mm", null)).TotalMinutes / 60).ToString();

					cmd.ExecuteNonQuery();
					this.CargarEntradasYSalidasPersonal();


				}
			}
			catch (Exception ex)
			{
				this.ShowError($"Hubo un error al Tratar de Actualizar la Jornada de {this.NomreDeEmpleado.Text}", ex);
			}
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void CargarEntradasYSalidas(bool porMes)
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
					filtro.Columns.Add("Empleado", typeof(string));
					filtro.Columns.Add("Fecha", typeof(string));
					filtro.Columns.Add("Entrada", typeof(string));
					filtro.Columns.Add("Salida", typeof(string));
					filtro.Columns.Add("HorasTrabajadas", typeof(float));

					adapter.Fill(table);
					foreach (DataRow row in table.Rows)
					{
						if (!porMes)
						{
							if (row["Fecha"].ToString() == this.BuscarJornadaLaboral.Value.ToString("dd/MM/yyyy"))
							{
								DataRow r = filtro.NewRow();
								r["EmpleadoId"] = row["EmpleadoId"];
								r["Empleado"] = row["Empleado"];
								r["Fecha"] = row["Fecha"];
								r["Entrada"] = row["Entrada"];//EmpleadoId,Empleado,Fecha,Entrada,Salida,
								r["Salida"] = row["Salida"];
								r["HorasTrabajadas"] = row["HorasTrabajadas"];
								filtro.Rows.Add(r);

							}
						}
						if (porMes)
						{
							if (row["Fecha"].ToString().Substring(row["Fecha"].ToString().IndexOf("/")) == DateTime.Now.ToString("/MM/yyyy"))
							{
								DataRow r = filtro.NewRow();
								r["EmpleadoId"] = row["EmpleadoId"];
								r["Empleado"] = row["Empleado"];
								r["Fecha"] = row["Fecha"];
								r["Entrada"] = row["Entrada"];//EmpleadoId,Empleado,Fecha,Entrada,Salida,
								r["Salida"] = row["Salida"];
								r["HorasTrabajadas"] = row["HorasTrabajadas"];
								filtro.Rows.Add(r);

							}
						}
					}
					this.ListadodeEmpleados.DataSource = filtro;
				}

			}
			catch (Exception ex)
			{
				this.ShowError($"Hubo un error al tratar de Cargar las Entradas Y Salidas", ex);
			}
		}
		public void ShowError(string message, Exception ex)
		{
			MessageBox.Show($"{message}\n{ex}", "Algo Salio mal!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}
		private void btnRefrescar_Click(object sender, EventArgs e)
		{
			this.CargarEntradasYSalidas(true);
		}

		private void BuscarJornadaLaboral_ValueChanged(object sender, EventArgs e)
		{
			this.CargarEntradasYSalidas(false);
		}
		private string Usuario{ get; set; }
		private bool UsuarioValido(string usuario)
		{
			try
			{
				using (SqlConnection cn = new SqlConnection(Connection.ConnectionString))
				{
					cn.Open();

					SqlCommand cm = new SqlCommand("SELECT * FROM dbo.Gestion_de_Usuarios WHERE EmpleadoId = @EmpleadoId", cn);


					cm.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
					cm.Parameters["@EmpleadoId"].Value = usuario;
					//cm.Parameters.Add(new SqlParameter("@Contra", SqlDbType.VarChar));
					//cm.Parameters["@Contra"].Value = contra;

					SqlDataReader reader = cm.ExecuteReader();


					if (reader.Read())
					{
						this.NomreDeEmpleado.Text  = reader.GetValue(1).ToString();
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
		private string HoraDeEntradaText{ get; set; }
		private bool ExisteEntrada(string usuario, string fecha)
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
						this.HoraDeEntradaText = reader.GetValue(3).ToString();
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
		private void Registrar_Jornada_Click(object sender, EventArgs e)
		{
			if(this.EmpleadoId.Text == "" || this.NomreDeEmpleado.Text == "")
			{
				MessageBox.Show("Falta el ID Del Empleado");
				return;
			}if(!this.UsuarioValido(this.EmpleadoId.Text))
			{
				MessageBox.Show("El usuario no es un Usuario Valido");
				return;
			}if(this.ExisteEntrada(this.EmpleadoId.Text, this.FechaDeJornada.Value.ToString("dd/MM/yyyy")))
			{
				MessageBox.Show($"Ya Existe Una Entrada de {this.NomreDeEmpleado.Text} en la fecha {this.FechaDeJornada.Value.ToString("dd/MM/yyyy")}");
				return;
			}
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Gestion_de_Jornada(EmpleadoId,Empleado,Fecha,Entrada,Salida,HorasTrabajadas)values(@EmpleadoId,@Empleado,@Fecha,@Entrada,@Salida,@HorasTrabajadas)", con);
					cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
					cmd.Parameters["@EmpleadoId"].Value = this.EmpleadoId.Text;

					cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
					cmd.Parameters["@Empleado"].Value = this.NomreDeEmpleado.Text;

					cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
					cmd.Parameters["@Fecha"].Value = this.FechaDeJornada.Value.ToString("dd/MM/yyyy");

					cmd.Parameters.Add(new SqlParameter("@Entrada", SqlDbType.VarChar));
					cmd.Parameters["@Entrada"].Value = this.HoraDeEntrada.Value.ToString("hh:mm tt");

					cmd.Parameters.Add(new SqlParameter("@Salida", SqlDbType.VarChar));
					cmd.Parameters["@Salida"].Value = this.HoraDeSalida.Value.ToString("hh:mm tt");

					cmd.Parameters.Add(new SqlParameter("@HorasTrabajadas", SqlDbType.Float));
					cmd.Parameters["@HorasTrabajadas"].Value = this.HorasTrabajadas.Text; //((DateTime.Now-DateTime.ParseExact(this.HoraDeEntrada, "hh:mm", null)).TotalMinutes / 60).ToString();

					cmd.ExecuteNonQuery();
					this.CargarEntradasYSalidasPersonal();
					

				}
			}
			catch (Exception ex)
			{
				this.ShowError($"Hubo un error al Tratar de Registrar la Jornada de {this.NomreDeEmpleado.Text}", ex);
			}

		}

		private void EmpleadoId_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.VerificarUsuario();
				this.CargarEntradaYSalidaPersonalDeMes();

				e.SuppressKeyPress = true;
				return;
			}
		}
		private void VerificarUsuario()
		{
			this.UsuarioValido(this.EmpleadoId.Text);
		}
		private void EmpleadoId_Leave(object sender, EventArgs e)
		{
			this.VerificarUsuario();
			this.CargarEntradaYSalidaPersonalDeMes();
		}

		private void CargarEntradaYSalidaPersonalDeMes()
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
					filtro.Columns.Add("Empleado", typeof(string));
					filtro.Columns.Add("Fecha", typeof(string));
					filtro.Columns.Add("Entrada", typeof(string));
					filtro.Columns.Add("Salida", typeof(string));
					filtro.Columns.Add("HorasTrabajadas", typeof(float));

					adapter.Fill(table);
			
					foreach (DataRow row in table.Rows)
					{
						//MessageBox.Show(row["Fecha"].ToString().Substring(row["Fecha"].ToString().IndexOf("/")));
						//return;
						if (row["EmpleadoId"].ToString() == this.EmpleadoId.Text && row["Fecha"].ToString().Substring(row["Fecha"].ToString().IndexOf("/")) == FechaDeJornada.Value.ToString("dd/MM/yyyy").Substring(row["Fecha"].ToString().IndexOf("/")))
						{
							DataRow r = filtro.NewRow();
							r["EmpleadoId"] = row["EmpleadoId"];
							r["Empleado"] = row["Empleado"];
							r["Fecha"] = row["Fecha"];
							r["Entrada"] = row["Entrada"];//EmpleadoId,Empleado,Fecha,Entrada,Salida,
							r["Salida"] = row["Salida"];
							r["HorasTrabajadas"] = row["HorasTrabajadas"];
							filtro.Rows.Add(r);
						}
					}
					this.ListadodeEmpleados.DataSource = filtro;
				}
			}
			catch (Exception ex)
			{
				this.ShowError($"Hubo un error al tratar de Cargar las Entradas Y Salidas", ex);
			}
		}
		private void CargarEntradasYSalidasPersonal()
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
					filtro.Columns.Add("Empleado", typeof(string));
					filtro.Columns.Add("Fecha", typeof(string));
					filtro.Columns.Add("Entrada", typeof(string));
					filtro.Columns.Add("Salida", typeof(string));
					filtro.Columns.Add("HorasTrabajadas", typeof(float));

					adapter.Fill(table);
				
					foreach (DataRow row in table.Rows)
					{
						if (row["EmpleadoId"].ToString() == this.EmpleadoId.Text && row["Fecha"].ToString() == FechaDeJornada.Value.ToString("dd/MM/yyyy"))
						{
							DataRow r = filtro.NewRow();
							r["EmpleadoId"] = row["EmpleadoId"];
							r["Empleado"] = row["Empleado"];
							r["Fecha"] = row["Fecha"];
							r["Entrada"] = row["Entrada"];//EmpleadoId,Empleado,Fecha,Entrada,Salida,
							r["Salida"] = row["Salida"];
							r["HorasTrabajadas"] = row["HorasTrabajadas"];
							filtro.Rows.Add(r);
						}
					}
					this.ListadodeEmpleados.DataSource = filtro;
				}
			}
			catch (Exception ex)
			{
				this.ShowError($"Hubo un error al tratar de Cargar las Entradas Y Salidas", ex);
			}
		}
		private void FechaDeJornada_ValueChanged(object sender, EventArgs e)
		{
			this.CargarEntradasYSalidasPersonal();
		}

		private void Mantenimiento_de_Horario_Load(object sender, EventArgs e)
		{
			this.CargarEntradasYSalidas(true);
			this.ActualizarHoras();
		}
		private void ActualizarHoras()
		{
			this.HorasTrabajadas.Text = ((DateTime.ParseExact(this.HoraDeSalida.Value.ToString("hh:mm tt"), "hh:mm tt", null)-DateTime.ParseExact(this.HoraDeEntrada.Value.ToString("hh:mm tt"), "hh:mm tt", null)).TotalMinutes/60).ToString();
		}
		private void HoraDeEntrada_ValueChanged(object sender, EventArgs e)
		{
			this.ActualizarHoras();
		}

		private void HoraDeSalida_ValueChanged(object sender, EventArgs e)
		{
			this.ActualizarHoras();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (this.EmpleadoId.Text == "" || this.NomreDeEmpleado.Text == "")
			{
				MessageBox.Show("Falta el ID Del Empleado");
				return;
			}
			if (!this.UsuarioValido(this.EmpleadoId.Text))
			{
				MessageBox.Show("El usuario no es un Usuario Valido");
				return;
			}
			if (!this.ExisteEntrada(this.EmpleadoId.Text, this.FechaDeJornada.Value.ToString("dd/MM/yyyy")))
			{
				MessageBox.Show($"No Existe Una Entrada de {this.NomreDeEmpleado.Text} en la fecha {this.FechaDeJornada.Value.ToString("dd/MM/yyyy")}");
				return;
			}
			DialogResult result = MessageBox.Show("Esta Seguro , no podra restaurar la jornada , tendra que crearla manualmente!!!", "Precaucion!!!", MessageBoxButtons.YesNo);
			if(result != DialogResult.Yes)
			{
				return;
			}
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					SqlCommand cmd = new SqlCommand($"DELETE FROM dbo.Gestion_de_Jornada WHERE EmpleadoId = @EmpleadoId AND Fecha = @Fecha",con);
					cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
					cmd.Parameters["@EmpleadoId"].Value = this.EmpleadoId.Text;

					cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
					cmd.Parameters["@Fecha"].Value = this.FechaDeJornada.Value.ToString("dd/MM/yyyy");
					cmd.ExecuteNonQuery();
					this.CargarEntradasYSalidas(true);
				}
			}
			catch(Exception ex)
			{
				this.ShowError($"Hubo un error al eliminar La Jornada de {this.NomreDeEmpleado.Text}",ex);
			}
		}
		private void BorrarCampos()
		{
			this.EmpleadoId.Clear();
			this.NomreDeEmpleado.Clear();
		}
		private void bntlimpiar_Click(object sender, EventArgs e)
		{
			this.BorrarCampos();
		}
	}
}
