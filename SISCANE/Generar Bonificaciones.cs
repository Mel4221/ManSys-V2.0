﻿using System;
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
using QuickTools.QCore;
namespace ManSys
{
    public partial class Bonificaciones : Form
    {
        public Bonificaciones()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bonificaciones_Load(object sender, EventArgs e)
        {
          this.CargarDatos();
        }
		private bool EsEleccionMultiple()
		{		if(ApplicarATodos.Checked || 
					ApplicarSoloADepartamento.Checked ||
					ApplicarSoloAPosicion.Checked){
				return true;
					}else{
				return false;
					}
		}

		private void RegistrarBonificacionATodos()
		{


			try
			{
				SqlDataAdapter adapter;
				DataTable table; 
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					table = new DataTable();
					adapter = new SqlDataAdapter("SELECT * FROM dbo.Empleados", con);
					adapter.Fill(table);
					con.Close();
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					foreach (DataRow row in table.Rows)
					{
						SqlCommand cmd = new SqlCommand($"INSERT INTO dbo.Bonificaciones(EmpleadoId,Empleado,Tipo_de_Bonificacion,Monto,Fecha,Fecha_de_Applicacion) values(@EmpleadoId,@Empleado,@Tipo_de_Bonificacion,@Monto,@Fecha,@Fecha_de_Applicacion)", con);

						cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
						cmd.Parameters["@EmpleadoId"].Value = row["Id"].ToString();

						cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
						cmd.Parameters["@Empleado"].Value = row["Nombre"].ToString()+" "+row["Apellido"].ToString();

						cmd.Parameters.Add(new SqlParameter("@Tipo_de_Bonificacion", SqlDbType.VarChar));
						cmd.Parameters["@Tipo_de_Bonificacion"].Value = CajaDeTipoDeBonificacion.Text;

						cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Float));
						cmd.Parameters["@Monto"].Value = this.CajaDeMonto.Text;

						cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
						cmd.Parameters["@Fecha"].Value = DateTime.Now.ToString("dd/MM/yyyy");

						cmd.Parameters.Add(new SqlParameter("@Fecha_de_Applicacion", SqlDbType.VarChar));
						cmd.Parameters["@Fecha_de_Applicacion"].Value = FechaDeApplicacion.Value.ToString("dd/MM/yyyy");

						cmd.ExecuteNonQuery();
					}

					this.CargarBonificaciones();
					this.LimpiarCampos();

				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un errror al Registrar la Bonificacion", ex);
			}
		}
		private void RegistrarSoloADepartamentos()
		{
			
			
			try
			{
				SqlDataAdapter adapter;
				DataTable table;
				
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					table = new DataTable();
					SqlCommand cmd; cmd = new SqlCommand("SELECT * FROM dbo.Empleados WHERE Departamento = @Departamento", con);

					cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
					cmd.Parameters["@Departamento"].Value =  this.CajaDeDepartamento.Text;

					adapter = new SqlDataAdapter(cmd);
					adapter.Fill(table);
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					foreach (DataRow row in table.Rows)
					{
						SqlCommand cmd = new SqlCommand($"INSERT INTO dbo.Bonificaciones(EmpleadoId,Empleado,Tipo_de_Bonificacion,Monto,Fecha,Fecha_de_Applicacion) values(@EmpleadoId,@Empleado,@Tipo_de_Bonificacion,@Monto,@Fecha,@Fecha_de_Applicacion)", con);

						cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
						cmd.Parameters["@EmpleadoId"].Value = row["Id"].ToString();

						cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
						cmd.Parameters["@Empleado"].Value = row["Nombre"].ToString()+" "+row["Apellido"].ToString();

						cmd.Parameters.Add(new SqlParameter("@Tipo_de_Bonificacion", SqlDbType.VarChar));
						cmd.Parameters["@Tipo_de_Bonificacion"].Value = CajaDeTipoDeBonificacion.Text;

						cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Float));
						cmd.Parameters["@Monto"].Value = this.CajaDeMonto.Text;

						cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
						cmd.Parameters["@Fecha"].Value = DateTime.Now.ToString("dd/MM/yyyy");

						cmd.Parameters.Add(new SqlParameter("@Fecha_de_Applicacion", SqlDbType.VarChar));
						cmd.Parameters["@Fecha_de_Applicacion"].Value = FechaDeApplicacion.Value.ToString("dd/MM/yyyy");

						cmd.ExecuteNonQuery();
					}

					this.CargarBonificaciones();
					this.LimpiarCampos();

				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un errror al Registrar la Bonificacion", ex);
			}
		}
		private void RegistrarSoloAPosiciones()
		{

			try
			{
				SqlDataAdapter adapter;
				DataTable table;

				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					table = new DataTable();
					SqlCommand cmd; cmd = new SqlCommand("SELECT * FROM dbo.Empleados WHERE Puesto_Ocupado = @Puesto_Ocupado", con);

					cmd.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
					cmd.Parameters["@Puesto_Ocupado"].Value =  this.CajaDePosicion.Text;

					adapter = new SqlDataAdapter(cmd);
					adapter.Fill(table);
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					foreach (DataRow row in table.Rows)
					{
						SqlCommand cmd = new SqlCommand($"INSERT INTO dbo.Bonificaciones(EmpleadoId,Empleado,Tipo_de_Bonificacion,Monto,Fecha,Fecha_de_Applicacion) values(@EmpleadoId,@Empleado,@Tipo_de_Bonificacion,@Monto,@Fecha,@Fecha_de_Applicacion)", con);

						cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
						cmd.Parameters["@EmpleadoId"].Value = row["Id"].ToString();

						cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
						cmd.Parameters["@Empleado"].Value = row["Nombre"].ToString()+" "+row["Apellido"].ToString();

						cmd.Parameters.Add(new SqlParameter("@Tipo_de_Bonificacion", SqlDbType.VarChar));
						cmd.Parameters["@Tipo_de_Bonificacion"].Value = CajaDeTipoDeBonificacion.Text;

						cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Float));
						cmd.Parameters["@Monto"].Value = this.CajaDeMonto.Text;

						cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
						cmd.Parameters["@Fecha"].Value = DateTime.Now.ToString("dd/MM/yyyy");

						cmd.Parameters.Add(new SqlParameter("@Fecha_de_Applicacion", SqlDbType.VarChar));
						cmd.Parameters["@Fecha_de_Applicacion"].Value = FechaDeApplicacion.Value.ToString("dd/MM/yyyy");

						cmd.ExecuteNonQuery();
					}

					this.CargarBonificaciones();
					this.LimpiarCampos();

				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un errror al Registrar la Bonificacion", ex);
			}
		}

		private void RegistrarCombinadas()
		{
			try
			{
				SqlDataAdapter adapter;
				DataTable table;

				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					table = new DataTable();
					SqlCommand cmd; cmd = new SqlCommand("SELECT * FROM dbo.Empleados WHERE Puesto_Ocupado = @Puesto_Ocupado AND Departamento = @Departamento", con);

					cmd.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
					cmd.Parameters["@Puesto_Ocupado"].Value =  this.CajaDePosicion.Text;

					cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
					cmd.Parameters["@Departamento"].Value =  this.CajaDeDepartamento.Text;

					adapter = new SqlDataAdapter(cmd);
					adapter.Fill(table);
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					foreach (DataRow row in table.Rows)
					{
						SqlCommand cmd = new SqlCommand($"INSERT INTO dbo.Bonificaciones(EmpleadoId,Empleado,Tipo_de_Bonificacion,Monto,Fecha,Fecha_de_Applicacion) values(@EmpleadoId,@Empleado,@Tipo_de_Bonificacion,@Monto,@Fecha,@Fecha_de_Applicacion)", con);

						cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
						cmd.Parameters["@EmpleadoId"].Value = row["Id"].ToString();

						cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
						cmd.Parameters["@Empleado"].Value = row["Nombre"].ToString()+" "+row["Apellido"].ToString();

						cmd.Parameters.Add(new SqlParameter("@Tipo_de_Bonificacion", SqlDbType.VarChar));
						cmd.Parameters["@Tipo_de_Bonificacion"].Value = CajaDeTipoDeBonificacion.Text;

						cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Float));
						cmd.Parameters["@Monto"].Value = this.CajaDeMonto.Text;

						cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
						cmd.Parameters["@Fecha"].Value = DateTime.Now.ToString("dd/MM/yyyy");

						cmd.Parameters.Add(new SqlParameter("@Fecha_de_Applicacion", SqlDbType.VarChar));
						cmd.Parameters["@Fecha_de_Applicacion"].Value = FechaDeApplicacion.Value.ToString("dd/MM/yyyy");

						cmd.ExecuteNonQuery();
					}

					this.CargarBonificaciones();
					this.LimpiarCampos();

				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un errror al Registrar la Bonificacion", ex);
			}
		}
		private void RegistrarMultiples()
		{
			
			if(ApplicarATodos.Checked)
			{
				this.RegistrarBonificacionATodos();
				return;
			}
			if(ApplicarSoloADepartamento.Checked && ApplicarSoloAPosicion.Checked)
			{
				this.RegistrarCombinadas();
				return;
			}
			if(ApplicarSoloADepartamento.Checked)
			{
				this.RegistrarSoloADepartamentos();
				return;
			}else{
				this.RegistrarSoloAPosiciones();
				return;
			}
		}


		private void EliminarTodos()
		{

			try
			{
			
				if (this.CajaDeTipoDeBonificacion.Text == "")
				{
					MessageBox.Show("Falta el Tipo de Bonificacion");
					return;
				}

				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();


					SqlCommand cmd; cmd = new SqlCommand("DELETE FROM dbo.Bonificaciones WHERE Tipo_de_Bonificacion = @Tipo_de_Bonificacion AND Fecha = @Fecha", con);

					cmd.Parameters.Add(new SqlParameter("@Tipo_de_Bonificacion", SqlDbType.VarChar));
					cmd.Parameters["@Tipo_de_Bonificacion"].Value = CajaDeTipoDeBonificacion.Text;

					cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
					cmd.Parameters["@Fecha"].Value = FechaDeEmision.Value.ToString("dd/MM/yyyy");
					cmd.ExecuteNonQuery();


					this.CargarBonificaciones();
					this.LimpiarCampos();

				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un errror al Eliminar la Bonificacion", ex);
			}

		}
		private void EliminarCombinados()
		{
			try
			{
				SqlDataAdapter adapter;
				DataTable table;
				if(this.CajaDeDepartamento.Text == "")
				{
					MessageBox.Show("Falta el Departamento");
					return;
				}if(this.CajaDePosicion.Text == "")
				{
					MessageBox.Show("Falta la Posicion");
					return;
				}if(this.CajaDeTipoDeBonificacion.Text == "")
				{
					MessageBox.Show("Falta el Tipo de Bonificacion");
					return;
				}

				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					table = new DataTable();
					SqlCommand cmd; cmd = new SqlCommand("SELECT * FROM dbo.Empleados WHERE Departamento = @Departamento AND Puesto_Ocupado = @Puesto_Ocupado", con);

					cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
					cmd.Parameters["@Departamento"].Value =  this.CajaDeDepartamento.Text;

					cmd.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
					cmd.Parameters["@Puesto_Ocupado"].Value =  this.CajaDePosicion.Text;

					adapter = new SqlDataAdapter(cmd);
					adapter.Fill(table);
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();

					foreach (DataRow row in table.Rows)
					{
						SqlCommand cmd; cmd = new SqlCommand("DELETE FROM dbo.Bonificaciones WHERE Tipo_de_Bonificacion = @Tipo_de_Bonificacion AND Fecha = @Fecha AND EmpleadoId = @EmpleadoId", con);


						cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
						cmd.Parameters["@EmpleadoId"].Value = row["Id"].ToString();

						cmd.Parameters.Add(new SqlParameter("@Tipo_de_Bonificacion", SqlDbType.VarChar));
						cmd.Parameters["@Tipo_de_Bonificacion"].Value = CajaDeTipoDeBonificacion.Text;

						cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
						cmd.Parameters["@Fecha"].Value = FechaDeEmision.Value.ToString("dd/MM/yyyy");
						cmd.ExecuteNonQuery();

					}
					this.CargarBonificaciones();
					this.LimpiarCampos();

				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un errror al Eliminar la Bonificacion", ex);
			}
		}
		private void EliminarSoloDepartamento()
		{
			try
			{
				SqlDataAdapter adapter;
				DataTable table;
				if (this.CajaDeDepartamento.Text == "")
				{
					MessageBox.Show("Falta el Departamento");
					return;
				}
				if (this.CajaDeTipoDeBonificacion.Text == "")
				{
					MessageBox.Show("Falta el Tipo de Bonificacion");
					return;
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					table = new DataTable();
					SqlCommand cmd; cmd = new SqlCommand("SELECT * FROM dbo.Empleados WHERE Departamento = @Departamento", con);

					cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
					cmd.Parameters["@Departamento"].Value =  this.CajaDeDepartamento.Text;

					adapter = new SqlDataAdapter(cmd);
					adapter.Fill(table);
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();

					foreach (DataRow row in table.Rows)
					{
						SqlCommand cmd; cmd = new SqlCommand("DELETE FROM dbo.Bonificaciones WHERE Tipo_de_Bonificacion = @Tipo_de_Bonificacion AND Fecha = @Fecha AND EmpleadoId = @EmpleadoId", con);


						cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
						cmd.Parameters["@EmpleadoId"].Value = row["Id"].ToString();

						cmd.Parameters.Add(new SqlParameter("@Tipo_de_Bonificacion", SqlDbType.VarChar));
						cmd.Parameters["@Tipo_de_Bonificacion"].Value = CajaDeTipoDeBonificacion.Text;

						cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
						cmd.Parameters["@Fecha"].Value = FechaDeEmision.Value.ToString("dd/MM/yyyy");
						cmd.ExecuteNonQuery();

					}
					this.CargarBonificaciones();
					this.LimpiarCampos();

				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un errror al Eliminar la Bonificacion", ex);
			}
		}
		private void EliminarSoloPosicion()
		{
			try
			{
				SqlDataAdapter adapter;
				DataTable table;
		 
				if (this.CajaDePosicion.Text == "")
				{
					MessageBox.Show("Falta la Posicion");
					return;
				}
				if (this.CajaDeTipoDeBonificacion.Text == "")
				{
					MessageBox.Show("Falta el Tipo de Bonificacion");
					return;
				}

				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					table = new DataTable();
					SqlCommand cmd; cmd = new SqlCommand("SELECT * FROM dbo.Empleados WHERE Puesto_Ocupado = @Puesto_Ocupado", con);

					cmd.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
					cmd.Parameters["@Puesto_Ocupado"].Value =  this.CajaDePosicion.Text;

					adapter = new SqlDataAdapter(cmd);
					adapter.Fill(table);
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();

					foreach (DataRow row in table.Rows)
					{
						SqlCommand cmd; cmd = new SqlCommand("DELETE FROM dbo.Bonificaciones WHERE Tipo_de_Bonificacion = @Tipo_de_Bonificacion AND Fecha = @Fecha AND EmpleadoId = @EmpleadoId", con);


						cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
						cmd.Parameters["@EmpleadoId"].Value = row["Id"].ToString();

						cmd.Parameters.Add(new SqlParameter("@Tipo_de_Bonificacion", SqlDbType.VarChar));
						cmd.Parameters["@Tipo_de_Bonificacion"].Value = CajaDeTipoDeBonificacion.Text;

						cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
						cmd.Parameters["@Fecha"].Value = FechaDeEmision.Value.ToString("dd/MM/yyyy");
						cmd.ExecuteNonQuery();

					}
					this.CargarBonificaciones();
					this.LimpiarCampos();

				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un errror al Eliminar la Bonificacion", ex);
			}
		}
		private void EliminarMultiples()
		{


			if (ApplicarATodos.Checked)
			{
				this.EliminarTodos();
				return;
			}
			if (ApplicarSoloADepartamento.Checked && ApplicarSoloAPosicion.Checked)
			{
				this.EliminarCombinados();
				return;
			}
			if (ApplicarSoloADepartamento.Checked)
			{
				this.EliminarSoloDepartamento();
				return;
			}
			else
			{
				this.EliminarSoloPosicion();
				return;
			}
		}
		private void LimpiarCampos()
		{
			this.CajaDeCodigoDeBonificacion.Clear();
			this.CajaDeEmpleado.Clear();
			this.CajaDeMonto.Clear();
			this.CajaDeEmpleadoId.Clear();
			this.ApplicarATodos.Checked =false;
			this.ApplicarSoloADepartamento.Checked = false;
			this.ApplicarSoloAPosicion.Checked = false; 
			this.CajaDeDepartamento.Text = "";
			this.CajaDePosicion.Text = "";
			this.CajaDeTipoDeBonificacion.Text ="";

		}

		 
		
	 
		private void CargarPosiciones()
        {
			try
			{

				using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
				{
					dataConnection.Open();
					DataTable posiciones = new DataTable();


					SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Posiciones", dataConnection);


					adapter.Fill(posiciones);
					this.CajaDePosicion.Items.Clear();
				 
					foreach (DataRow row in posiciones.Rows)
					{
						this.CajaDePosicion.Items.Add(row["Nombre"].ToString());
					}
 
				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un error al Cargar las Posiciones", ex);
			}
		}
        private void CargarDepartamentos()
        {
			try
			{

				using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
				{
					dataConnection.Open();
					DataTable departamentos = new DataTable();


					SqlDataAdapter daempleados = new SqlDataAdapter("SELECT * FROM dbo.Departamentos", dataConnection);
					daempleados.Fill(departamentos);
					this.CajaDeDepartamento.Items.Clear();
					foreach (DataRow row in departamentos.Rows)
					{
						this.CajaDeDepartamento.Items.Add(row["Nombre"].ToString());
					}


				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un error al Cargar los Departamentos", ex);
			}
		}
		public void ShowError(string message, Exception ex) => MessageBox.Show($"{message}\n{ex}", "Algo Salio mal!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		
	
		private void CargarBonificaciones()
        {
			try
			{
			 
				using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
				{
					dataConnection.Open();
					DataTable bonificaciones = new DataTable();
					SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Bonificaciones", dataConnection);

					adapter.Fill(bonificaciones);
					ListadoDeBonificaciones.DataSource = bonificaciones;
					this.CajaDeTipoDeBonificacion.Items.Clear();
					foreach (DataRow row in bonificaciones.Rows)
					{
						if(!this.CajaDeTipoDeBonificacion.Items.Contains(row["Tipo_de_Bonificacion"].ToString()))
						{
							this.CajaDeTipoDeBonificacion.Items.Add(row["Tipo_de_Bonificacion"].ToString());
						}
					}
				}
			}
			catch (Exception ex)
			{
				ShowError("Hubo un error al Cargar las Bonificaciones", ex);
			}
		}
        private void CargarDatos()
        {
            this.CargarPosiciones();
            this.CargarDepartamentos();
            this.CargarBonificaciones();
		}

		private void BuscarEmpleado()
		{

			//if (this.BusquedaAvanzadaCheck.Checked)
			//{
			//	this.BusquedaAvanzada();
			//	return;
			//}
			//try
			//{
			//if (reader.Read())
			//{
			/*
            btnNuevo.Enabled = false;
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
            txtNombre.Focus();
            */
			using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
			{

				//string query = $"SELECT * FROM dbo.Empleados WHERE {ConvertirACriterioDeBusqueda(this.CriterioDeBusqueda.Text)}";
				//MessageBox.Show(query);
				//return;
				connection.Open();

				SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM dbo.Empleados", connection);


				DataTable data = new DataTable();
				adapter.Fill(data);

				/*his.ListadodeEmpleados.DataSource = data;*/
				foreach (DataRow row in data.Rows)
				{
					//  Get.Green("[" + row["ID"] + "]" + "[" + row["created"] + "]" + " " + "[" + row["uname"] + "]" + " " + "[" + row["msg"] + "]");
				
					if (row["CEDULA"].ToString() == this.CajaDeEmpleadoId.Text)
					{
						this.TomarDatos(row);
						return;
					}
					if (row["Id"].ToString()  == this.CajaDeEmpleadoId.Text)
					{
						this.TomarDatos(row);
						return;
					}
					if (row["Nombre"].ToString().ToLower() +" "+row["Apellido"].ToString().ToLower()  ==  this.CajaDeEmpleadoId.Text.ToLower())
					{
						this.TomarDatos(row);
						return;
					}
					if (row["Telefono"].ToString()  == this.CajaDeEmpleadoId.Text)
					{
						this.TomarDatos(row);
						return;
					}
				}



				/*
				txtId.Text = reader[0].ToString();
				txtNombre.Text = reader[1].ToString();
				txtApellido.Text = reader[2].ToString();
				txtdireccion.Text = reader[3].ToString();
				txttelefono.Text = reader[4].ToString();
				txtfechadeingreso.Text = reader[5].ToString();
				txtpuestoocupado.Text = reader[6].ToString();
				txtdeparmento.Text = reader[7].ToString();
				txtdni.Text = reader[8].ToString();
				txtsalariobase.Text = reader[9].ToString();
				txttipodecobro.Text = reader[10].ToString();
				txtturno.Text = reader[11].ToString();
				*/
				//nuevo = false;

			}


			//}
			//else
			MessageBox.Show("Ningun Registro Encontrado con el Dato de Busqueda Ingresado");

		}

		private void TomarDatos(DataRow datos)
		{
			//  DateTime.ParseExact(datos["Fecha_de_Ingreso"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

			//MessageBox.Show(DateTime.ParseExact(datos["Fecha_de_Ingreso"].ToString(), "dd/MM/yyyy"));
			//return;
			CajaDeEmpleadoId.Text = datos["Id"].ToString();
			CajaDeEmpleado.Text = datos["Nombre"].ToString() +" "+datos["Apellido"].ToString();
			//txtApellido.Text = datos["Apellido"].ToString();
			//txtdireccion.Text = datos["Direccion"].ToString();
			//txttelefono.Text = datos["Telefono"].ToString();
			//Fecha_de_Ingreso_Label.Text = datos["Fecha_de_Ingreso"].ToString();
			CajaDePosicion.Text =datos["Puesto_Ocupado"].ToString();
			CajaDeDepartamento.Text = datos["Departamento"].ToString();
			//txtdni.Text = datos["CEDULA"].ToString();
			//txtsalariobase.Text = datos["Salario_Base"].ToString();
			//txttipodecobro.Text = datos["Tipo_de_Cobro"].ToString();
			//txtturno.Text = datos["Turno"].ToString();
		}

		private void BtnDeBusqueda_Click(object sender, EventArgs e)
		{
			this.BuscarEmpleado();
		}

		private void CajaDeEmpleadoId_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.BuscarEmpleado();
				e.SuppressKeyPress = true;
			}
		}

		private void bntlimpiar_Click(object sender, EventArgs e)
		{
			this.LimpiarCampos();
		}

		private void btnCerrar_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnRegistrar_Click_1(object sender, EventArgs e)
		{
			if (this.CajaDeTipoDeBonificacion.Text == "")
			{
				MessageBox.Show("Falta El tipo de Bonificacion");
				return;
			}
			if(this.CajaDeMonto.Text == ""){
				MessageBox.Show("Falta el monto de la Bonificacion");
				return;
			}
			if (this.EsEleccionMultiple())
			{
				this.RegistrarMultiples();
				return;
			}
			if (this.CajaDeEmpleadoId.Text == "")
			{
				MessageBox.Show("Falta el ID del Empleado");
				return;
			}
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					SqlCommand cmd = new SqlCommand($"INSERT INTO dbo.Bonificaciones(EmpleadoId,Empleado,Tipo_de_Bonificacion,Monto,Fecha,Fecha_de_Applicacion) values(@EmpleadoId,@Empleado,@Tipo_de_Bonificacion,@Monto,@Fecha,@Fecha_de_Applicacion)", con);

					cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
					cmd.Parameters["@EmpleadoId"].Value = this.CajaDeEmpleadoId.Text;

					cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
					cmd.Parameters["@Empleado"].Value = this.CajaDeEmpleado.Text;

					cmd.Parameters.Add(new SqlParameter("@Tipo_de_Bonificacion", SqlDbType.VarChar));
					cmd.Parameters["@Tipo_de_Bonificacion"].Value = CajaDeTipoDeBonificacion.Text;

					cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Float));
					cmd.Parameters["@Monto"].Value = this.CajaDeMonto.Text;

					cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
					cmd.Parameters["@Fecha"].Value = DateTime.Now.ToString("dd/MM/yyyy");

					cmd.Parameters.Add(new SqlParameter("@Fecha_de_Applicacion", SqlDbType.VarChar));
					cmd.Parameters["@Fecha_de_Applicacion"].Value = FechaDeApplicacion.Value.ToString("dd/MM/yyyy");

					cmd.ExecuteNonQuery();
					this.CargarBonificaciones();
					this.LimpiarCampos();

				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un errror al Registrar la Bonificacion", ex);
			}
		}

		private void bntlimpiar_Click_1(object sender, EventArgs e)
		{
			this.LimpiarCampos();
		}

		private void ModificarTodos()
		{
			if (this.CajaDeTipoDeBonificacion.Text == "")
			{

				MessageBox.Show("Falta El tipo de Bonificacion");
				return;
			}
					 
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					//SqlCommand cmd = new SqlCommand($"UPDATE dbo.Bonificaciones SET EmpleadoId = @EmpleadoId ,Empleado = @Empleado,Tipo_de_Bonificacion = @Tipo_de_Bonificacion,Monto = @Monto,Fecha = @Fecha,Fecha_de_Applicacion = @Fecha_de_Applicacion WHERE Id = @Id AND EmpleadoId = @EmpleadoId AND Fecha = @Fecha", con);
					SqlCommand cmd = new SqlCommand($"UPDATE dbo.Bonificaciones SET Tipo_de_Bonificacion = @Tipo_de_Bonificacion,Monto = @Monto,Fecha_de_Applicacion = @Fecha_de_Applicacion WHERE Fecha = @Fecha AND Tipo_de_Bonificacion = @Tipo_de_Bonificacion", con);

					//cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
					//cmd.Parameters["@Id"].Value = this.CajaDeCodigoDeBonificacion.Text;


					//cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
					//cmd.Parameters["@EmpleadoId"].Value = this.CajaDeEmpleadoId.Text;

					//cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
					//cmd.Parameters["@Empleado"].Value = this.CajaDeEmpleado.Text;

					cmd.Parameters.Add(new SqlParameter("@Tipo_de_Bonificacion", SqlDbType.VarChar));
					cmd.Parameters["@Tipo_de_Bonificacion"].Value = CajaDeTipoDeBonificacion.Text;

					cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Float));
					cmd.Parameters["@Monto"].Value = this.CajaDeMonto.Text;

					cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
					cmd.Parameters["@Fecha"].Value = this.FechaDeEmision.Value.ToString("dd/MM/yyyy");

					cmd.Parameters.Add(new SqlParameter("@Fecha_de_Applicacion", SqlDbType.VarChar));
					cmd.Parameters["@Fecha_de_Applicacion"].Value = FechaDeApplicacion.Value.ToString("dd/MM/yyyy");

					cmd.ExecuteNonQuery();
					this.CargarBonificaciones();
					this.LimpiarCampos();

				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un errror al Modificar la Bonificacion", ex);
			}
		}
		private void ModificarCombinados()
		{
			try
			{
				SqlDataAdapter adapter;
				DataTable table;
				if (this.CajaDeDepartamento.Text == "")
				{
					MessageBox.Show("Falta el Departamento");
					return;
				}
				if(this.CajaDePosicion.Text == "")
				{
					MessageBox.Show("Falta La Posicion");
					return;
				}
				if (this.CajaDeTipoDeBonificacion.Text == "")
				{
					MessageBox.Show("Falta el Tipo de Bonificacion");
					return;
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					table = new DataTable();
					SqlCommand cmd; cmd = new SqlCommand("SELECT * FROM dbo.Empleados WHERE Departamento = @Departamento AND Puesto_Ocupado = @Puesto_Ocupado", con);

					cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
					cmd.Parameters["@Departamento"].Value =  this.CajaDeDepartamento.Text;


					cmd.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
					cmd.Parameters["@Puesto_Ocupado"].Value =  this.CajaDePosicion.Text;

					adapter = new SqlDataAdapter(cmd);
					adapter.Fill(table);
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();

					foreach (DataRow row in table.Rows)
					{
						//SqlCommand cmd = new SqlCommand($"UPDATE dbo.Bonificaciones SET EmpleadoId = @EmpleadoId ,Empleado = @Empleado,Tipo_de_Bonificacion = @Tipo_de_Bonificacion,Monto = @Monto,Fecha = @Fecha,Fecha_de_Applicacion = @Fecha_de_Applicacion WHERE Id = @Id AND EmpleadoId = @EmpleadoId AND Fecha = @Fecha", con);
						SqlCommand cmd = new SqlCommand($"UPDATE dbo.Bonificaciones SET Tipo_de_Bonificacion = @Tipo_de_Bonificacion,Monto = @Monto,Fecha_de_Applicacion = @Fecha_de_Applicacion WHERE Fecha = @Fecha AND Tipo_de_Bonificacion = @Tipo_de_Bonificacion AND EmpleadoId = @EmpleadoId", con);

						cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
						cmd.Parameters["@EmpleadoId"].Value = row["Id"].ToString();


						//cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
						//cmd.Parameters["@EmpleadoId"].Value = this.CajaDeEmpleadoId.Text;

						//cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
						//cmd.Parameters["@Empleado"].Value = this.CajaDeEmpleado.Text;


						cmd.Parameters.Add(new SqlParameter("@Tipo_de_Bonificacion", SqlDbType.VarChar));
						cmd.Parameters["@Tipo_de_Bonificacion"].Value = CajaDeTipoDeBonificacion.Text;

						cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Float));
						cmd.Parameters["@Monto"].Value = this.CajaDeMonto.Text;

						cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
						cmd.Parameters["@Fecha"].Value = this.FechaDeEmision.Value.ToString("dd/MM/yyyy");

						cmd.Parameters.Add(new SqlParameter("@Fecha_de_Applicacion", SqlDbType.VarChar));
						cmd.Parameters["@Fecha_de_Applicacion"].Value = FechaDeApplicacion.Value.ToString("dd/MM/yyyy");

						cmd.ExecuteNonQuery();
					}

					this.CargarBonificaciones();
					this.LimpiarCampos();

				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un errror al Modificar la Bonificacion", ex);
			}
		}
		private void ModificarSoloDepartamento()
		{
			try
			{
				SqlDataAdapter adapter;
				DataTable table;
				if (this.CajaDeDepartamento.Text == "")
				{
					MessageBox.Show("Falta el Departamento");
					return;
				}
				if (this.CajaDeTipoDeBonificacion.Text == "")
				{
					MessageBox.Show("Falta el Tipo de Bonificacion");
					return;
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					table = new DataTable();
					SqlCommand cmd; cmd = new SqlCommand("SELECT * FROM dbo.Empleados WHERE Departamento = @Departamento", con);

					cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
					cmd.Parameters["@Departamento"].Value =  this.CajaDeDepartamento.Text;

					adapter = new SqlDataAdapter(cmd);
					adapter.Fill(table);
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();

					foreach (DataRow row in table.Rows)
					{
						//SqlCommand cmd = new SqlCommand($"UPDATE dbo.Bonificaciones SET EmpleadoId = @EmpleadoId ,Empleado = @Empleado,Tipo_de_Bonificacion = @Tipo_de_Bonificacion,Monto = @Monto,Fecha = @Fecha,Fecha_de_Applicacion = @Fecha_de_Applicacion WHERE Id = @Id AND EmpleadoId = @EmpleadoId AND Fecha = @Fecha", con);
						SqlCommand cmd = new SqlCommand($"UPDATE dbo.Bonificaciones SET Tipo_de_Bonificacion = @Tipo_de_Bonificacion,Monto = @Monto,Fecha_de_Applicacion = @Fecha_de_Applicacion WHERE Fecha = @Fecha AND Tipo_de_Bonificacion = @Tipo_de_Bonificacion AND EmpleadoId = @EmpleadoId", con);

						cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
						cmd.Parameters["@EmpleadoId"].Value = row["Id"].ToString();


						//cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
						//cmd.Parameters["@EmpleadoId"].Value = this.CajaDeEmpleadoId.Text;

						//cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
						//cmd.Parameters["@Empleado"].Value = this.CajaDeEmpleado.Text;


						cmd.Parameters.Add(new SqlParameter("@Tipo_de_Bonificacion", SqlDbType.VarChar));
						cmd.Parameters["@Tipo_de_Bonificacion"].Value = CajaDeTipoDeBonificacion.Text;

						cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Float));
						cmd.Parameters["@Monto"].Value = this.CajaDeMonto.Text;

						cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
						cmd.Parameters["@Fecha"].Value = this.FechaDeEmision.Value.ToString("dd/MM/yyyy");

						cmd.Parameters.Add(new SqlParameter("@Fecha_de_Applicacion", SqlDbType.VarChar));
						cmd.Parameters["@Fecha_de_Applicacion"].Value = FechaDeApplicacion.Value.ToString("dd/MM/yyyy");

						cmd.ExecuteNonQuery();
					}

					this.CargarBonificaciones();
					this.LimpiarCampos();

				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un errror al Modificar la Bonificacion", ex);
			}
		}
		private void ModificarSoloPosicion()
		{
			try
			{
				SqlDataAdapter adapter;
				DataTable table;
				if (this.CajaDePosicion.Text == "")
				{
					MessageBox.Show("Falta La Posicion");
					return;
				}
				if (this.CajaDeTipoDeBonificacion.Text == "")
				{
					MessageBox.Show("Falta el Tipo de Bonificacion");
					return;
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					table = new DataTable();
					SqlCommand cmd; cmd = new SqlCommand("SELECT * FROM dbo.Empleados WHERE Puesto_Ocupado = @Puesto_Ocupado", con);

					cmd.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
					cmd.Parameters["@Puesto_Ocupado"].Value =  this.CajaDePosicion.Text;

					adapter = new SqlDataAdapter(cmd);
					adapter.Fill(table);
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();

					foreach (DataRow row in table.Rows)
					{
						//SqlCommand cmd = new SqlCommand($"UPDATE dbo.Bonificaciones SET EmpleadoId = @EmpleadoId ,Empleado = @Empleado,Tipo_de_Bonificacion = @Tipo_de_Bonificacion,Monto = @Monto,Fecha = @Fecha,Fecha_de_Applicacion = @Fecha_de_Applicacion WHERE Id = @Id AND EmpleadoId = @EmpleadoId AND Fecha = @Fecha", con);
						SqlCommand cmd = new SqlCommand($"UPDATE dbo.Bonificaciones SET Tipo_de_Bonificacion = @Tipo_de_Bonificacion,Monto = @Monto,Fecha_de_Applicacion = @Fecha_de_Applicacion WHERE Fecha = @Fecha AND Tipo_de_Bonificacion = @Tipo_de_Bonificacion AND EmpleadoId = @EmpleadoId", con);

						cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
						cmd.Parameters["@EmpleadoId"].Value = row["Id"].ToString();


						//cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
						//cmd.Parameters["@EmpleadoId"].Value = this.CajaDeEmpleadoId.Text;

						//cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
						//cmd.Parameters["@Empleado"].Value = this.CajaDeEmpleado.Text;


						cmd.Parameters.Add(new SqlParameter("@Tipo_de_Bonificacion", SqlDbType.VarChar));
						cmd.Parameters["@Tipo_de_Bonificacion"].Value = CajaDeTipoDeBonificacion.Text;

						cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Float));
						cmd.Parameters["@Monto"].Value = this.CajaDeMonto.Text;

						cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
						cmd.Parameters["@Fecha"].Value = this.FechaDeEmision.Value.ToString("dd/MM/yyyy");

						cmd.Parameters.Add(new SqlParameter("@Fecha_de_Applicacion", SqlDbType.VarChar));
						cmd.Parameters["@Fecha_de_Applicacion"].Value = FechaDeApplicacion.Value.ToString("dd/MM/yyyy");

						cmd.ExecuteNonQuery();
					}

					this.CargarBonificaciones();
					this.LimpiarCampos();

				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un errror al Modificar la Bonificacion", ex);
			}
		}
		private void ModificarMultiples()
		{
			if (ApplicarATodos.Checked)
			{
				this.ModificarTodos();
				return;
			}
			if (ApplicarSoloADepartamento.Checked && ApplicarSoloAPosicion.Checked)
			{
				this.ModificarCombinados();
				return;
			}
			if (ApplicarSoloADepartamento.Checked)
			{
				this.ModificarSoloDepartamento();
				return;
			}
			else
			{
				this.ModificarSoloPosicion();
				return;
			}
		}
		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (this.CajaDeTipoDeBonificacion.Text == "")
			{

				MessageBox.Show("Falta El tipo de Bonificacion");
				return;
			}
			if (this.EsEleccionMultiple())
			{
				if (ApplicarSoloADepartamento.Checked || ApplicarSoloAPosicion.Checked)
				{
					MessageBox.Show("No se pueden Actualizar todos si se marcan los departamentos y las posiciones");
					return;
				}
				this.ModificarMultiples();
				return;
			}
			if (this.CajaDeEmpleadoId.Text == "")
			{
				MessageBox.Show("Falta el ID del Empleado");
				return;
			}
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					SqlCommand cmd = new SqlCommand($"UPDATE dbo.Bonificaciones SET EmpleadoId = @EmpleadoId ,Empleado = @Empleado,Tipo_de_Bonificacion = @Tipo_de_Bonificacion,Monto = @Monto,Fecha = @Fecha,Fecha_de_Applicacion = @Fecha_de_Applicacion WHERE Id = @Id AND EmpleadoId = @EmpleadoId AND Fecha = @Fecha", con);

					cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
					cmd.Parameters["@Id"].Value = this.CajaDeCodigoDeBonificacion.Text;


					cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
					cmd.Parameters["@EmpleadoId"].Value = this.CajaDeEmpleadoId.Text;

					cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
					cmd.Parameters["@Empleado"].Value = this.CajaDeEmpleado.Text;

					cmd.Parameters.Add(new SqlParameter("@Tipo_de_Bonificacion", SqlDbType.VarChar));
					cmd.Parameters["@Tipo_de_Bonificacion"].Value = CajaDeTipoDeBonificacion.Text;

					cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Float));
					cmd.Parameters["@Monto"].Value = this.CajaDeMonto.Text;

					cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
					cmd.Parameters["@Fecha"].Value = this.FechaDeEmision.Value.ToString("dd/MM/yyyy");

					cmd.Parameters.Add(new SqlParameter("@Fecha_de_Applicacion", SqlDbType.VarChar));
					cmd.Parameters["@Fecha_de_Applicacion"].Value = FechaDeApplicacion.Value.ToString("dd/MM/yyyy");

					cmd.ExecuteNonQuery();
					this.CargarBonificaciones();
					this.LimpiarCampos();

				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un errror al Modificar la Bonificacion", ex);
			}
		}
		private string EmisionDeBonificacion{ get; set; }
		private void BuscarBonificacion_Click(object sender, EventArgs e)
		{
			if(this.CajaDeCodigoDeBonificacion.Text == ""){
				MessageBox.Show("Falta el codigo de Bonificacion");
				return;
			}
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					SqlCommand cmd = new SqlCommand($"SELECT * FROM dbo.Bonificaciones WHERE Id = @Id OR EmpleadoId = @Id",con);
					cmd.Parameters.Add(new SqlParameter("@Id",SqlDbType.Int));
					cmd.Parameters["@Id"].Value = this.CajaDeCodigoDeBonificacion.Text; 

					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable tabla = new DataTable();
					adapter.Fill(tabla);
					this.ListadoDeBonificaciones.DataSource = tabla;

					foreach(DataRow row in tabla.Rows)
					{
						this.CajaDeEmpleado.Text = row["Empleado"].ToString();
						this.CajaDeMonto.Text = row["Monto"].ToString();
						this.CajaDeEmpleadoId.Text = row["EmpleadoId"].ToString();
						this.CajaDeTipoDeBonificacion.Text = row["Tipo_de_Bonificacion"].ToString();
						this.FechaDeEmision.Value = DateTime.ParseExact(row["Fecha"].ToString(), "dd/MM/yyyy", null);
						this.FechaDeApplicacion.Value =  DateTime.ParseExact(row["Fecha_de_Applicacion"].ToString(), "dd/MM/yyyy", null);
						this.EmisionDeBonificacion = DateTime.ParseExact(row["Fecha"].ToString(), "dd/MM/yyyy", null).ToString();
						this.BuscarEmpleado();
					}
					//this.CajaDeCodigoDeBonificacion.
					//this.CajaDeMonto.Clear();
					//this.CajaDeEmpleadoId.Clear();
					//this.CajaDeTipoDeBonificacion.Clear();
					//this.CajaDeDepartamento.Text = "";
					//this.CajaDePosicion.Text = "";

				}
			}catch(Exception ex)
			{
				ShowError("Hubo un error al buscar la Bonificacion", ex);
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{

			DialogResult result;
			if (this.EsEleccionMultiple())
			{
				result = MessageBox.Show("Esta Seguro , Va a eliminar Una Bonificacion Permanentemente", "Precaucion!!!", MessageBoxButtons.YesNo);

				if (result != DialogResult.Yes)
				{
					return;
				}
				this.EliminarMultiples();
				return;
			}
			if (this.CajaDeCodigoDeBonificacion.Text == "")
			{
				MessageBox.Show("Falta el codigo de Bonificacion");
				return;
			}
				result = MessageBox.Show("Esta Seguro , Va a eliminar Una Bonificacion Permanentemente", "Precaucion!!!", MessageBoxButtons.YesNo);
			if (result != DialogResult.Yes)
			{
				return;
			}
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Bonificaciones WHERE Id = @Id", con);
					cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
					cmd.Parameters["@Id"].Value = this.CajaDeCodigoDeBonificacion.Text;
					cmd.ExecuteNonQuery();
					this.CargarBonificaciones();
				}
			}
			catch (Exception ex )
			{
				ShowError("Hubo un error al tratar de Eliminar la Bonificacion",ex);
			}
		}

		private void CajaDeEmpleadoId_Leave(object sender, EventArgs e)
		{
			if(this.CajaDeEmpleadoId.Text != "")
			{
				this.BuscarEmpleado();
			}			

		}

		private void BtnRefrescar_Click(object sender, EventArgs e)
		{
			this.CargarBonificaciones();
		}
	}
}
