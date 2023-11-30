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
    public partial class Incidencias : Form
    {
        public Incidencias()
        {
            InitializeComponent();
        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Incidencias_Load(object sender, EventArgs e)
        {
			this.CargarIncidencias();

		}
		private void LimpiarCampos()
		{
			this.txtid.Text = "";
			this.txtbusqueda.Text = "";
			this.txtEmpleado.Text = "";
			this.txtEmpleadoId.Text = "";
			this.txtPosicion.Text = "";
			this.txtDepartamento.Text = "";
			this.txtTipoDeIncidencia.Text = "";
			this.txtObservacion.Text = "";
		}

		private void CargarIncidencias()
		{
			try{
					using(SqlConnection con = new SqlConnection(Connection.ConnectionString))
					{
						con.Open();
				 
						 
						DataTable incidencias = new DataTable();
						SqlDataAdapter daempleados = new SqlDataAdapter("SELECT * FROM dbo.Incidencias", con);
						daempleados.Fill(incidencias);
						IncidenciasGrid.DataSource = incidencias;
					
					}
			}
			catch (Exception ex)
			{
				ShowError($"Algo salio mal al Cargar las Incidencias", ex);
			}
		}	

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			if(this.txtObservacion.Text == "")
			{
				MessageBox.Show("Agregar Obesrvacioines Porfavor");
				return;
			}if(this.txtEmpleado.Text == "")
			{
				MessageBox.Show("Porfavor Buscar Empleado");
				return;
			}
			string dias, observacion, id, empleado, posicion, departamento;
			dias = (int.Parse((Fecha_de_Entrada.Value-Fecha_de_Salida.Value).Days.ToString())+1).ToString();
			observacion = this.txtObservacion.Text;
			id = this.txtEmpleadoId.Text;
			empleado = this.txtEmpleado.Text;
			posicion = this.txtPosicion.Text;
			departamento = this.txtDepartamento.Text;
			using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
			{

				try
				{
					con.Open();
					string query = $"INSERT INTO dbo.Incidencias(Nombre,Duracion,Observacion,EmpleadoID,Nombre_de_Empleado,Posicion,Departamento) values(@Nombre,@Duracion,@Observacion,@EmpleadoID,@Nombre_de_Empleado,@Posicion,@Departamento)";

					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.AddWithValue("@Nombre", txtTipoDeIncidencia.Text);
					cmd.Parameters.AddWithValue("@Duracion", txtTipoDeIncidencia.Text=="Despido"?"Permanente":dias);
					cmd.Parameters.AddWithValue("@Observacion", observacion);
					cmd.Parameters.AddWithValue("@EmpleadoID", int.Parse(id));
					cmd.Parameters.AddWithValue("@Nombre_de_Empleado", empleado);
					cmd.Parameters.AddWithValue("@Posicion", posicion);
					cmd.Parameters.AddWithValue("@Departamento", departamento);

					//values(@Nombre,@Duracion,@Observacion,@EmpleadoID,@Nombre_de_Empleado,@Posicion,@Departamento)
					cmd.ExecuteNonQuery();
		
					this.CargarIncidencias();
					this.btnRegistrar.Enabled = false; 
				}
				catch (Exception ex)
				{
					ShowError($"Algo salio mal al Registrar la Incidencia ", ex);
				}
			}

		}
		public void ShowError(string message, Exception ex)
		{
			MessageBox.Show($"{message}\n{ex}", "Algo Salio mal!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (this.txtObservacion.Text == "")
			{
				MessageBox.Show("Agregar Obesrvacioines Porfavor");
				return;
			}if(this.txtid.Text == ""){
				MessageBox.Show("Agregar Un Codigo de Incidencia");
				return;
			}if (this.txtEmpleado.Text == ""){ 
				MessageBox.Show("Porfavor Buscar primero el Empleado");
				return;
			}
			string dias, observacion, id, empleado, posicion, departamento;
			dias = (int.Parse((Fecha_de_Entrada.Value-Fecha_de_Salida.Value).Days.ToString())+1).ToString();
			observacion = this.txtObservacion.Text;
			id = this.txtEmpleadoId.Text;
			empleado = this.txtEmpleado.Text;
			posicion = this.txtPosicion.Text;
			departamento = this.txtDepartamento.Text;
			using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
			{

				try
				{
					con.Open();
					string query = $"UPDATE dbo.Incidencias SET Nombre=@Nombre,Duracion=@Duracion,Observacion=@Observacion,EmpleadoID=@EmpleadoID,Nombre_de_Empleado=@Nombre_de_Empleado,Posicion=@Posicion,Departamento=@Departamento WHERE Id = @Code";

					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.AddWithValue("@Nombre", txtTipoDeIncidencia.Text);
					cmd.Parameters.AddWithValue("@Duracion", txtTipoDeIncidencia.Text=="Despido" ? "Permanente" : dias);
					cmd.Parameters.AddWithValue("@Observacion", observacion);
					cmd.Parameters.AddWithValue("@EmpleadoID", int.Parse(id));
					cmd.Parameters.AddWithValue("@Nombre_de_Empleado", empleado);
					cmd.Parameters.AddWithValue("@Posicion", posicion);
					cmd.Parameters.AddWithValue("@Departamento", departamento);
					cmd.Parameters.AddWithValue("@Code", int.Parse(txtid.Text));


					//values(@Nombre,@Duracion,@Observacion,@EmpleadoID,@Nombre_de_Empleado,@Posicion,@Departamento)
					cmd.ExecuteNonQuery();

					this.CargarIncidencias();
					//this.btnRegistrar.Enabled = false;
				}
				catch (Exception ex)
				{
					ShowError($"Algo salio mal al Modificar  la Incidencia ", ex);
				}
			}

		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if(this.txtid.Text == "")
			{
				MessageBox.Show("Porfavor introucir un  Codigo de incidencia");
				return;
			}if(!QuickTools.QCore.Get.IsNumber(this.txtid.Text)){
				MessageBox.Show("El Codigo No parace que esta en el formato correcto");
				return;
			}
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					string query = $"DELETE FROM dbo.Incidencias WHERE Id = @Id";
					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.AddWithValue("@Id", int.Parse(txtid.Text));
					cmd.ExecuteNonQuery();
					this.CargarIncidencias();

				}
			}catch(Exception ex)
			{
				ShowError($"Hubo un error al eliminar la Incidencia con el codigo {txtid.Text}", ex);
			}
		}

		private void bntlimpiar_Click(object sender, EventArgs e)
		{
			this.LimpiarCampos();
		}

		private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.BuscarEmpleado();
			}
		}
		private void TomarDatos(DataRow datos)
		{
			 
			txtEmpleado.Text = $"{datos["Nombre"].ToString()} {datos["Apellido"].ToString()}";
			txtPosicion.Text =datos["Puesto_Ocupado"].ToString();
			txtDepartamento.Text = datos["Departamento"].ToString();
			txtEmpleadoId.Text =   datos["Id"].ToString();

			//txtdireccion.Text = datos["Direccion"].ToString();
			//txttelefono.Text = datos["Telefono"].ToString();
			//Fecha_de_Ingreso_Label.Text = datos["Fecha_de_Ingreso"].ToString();
			//txtdni.Text = datos["CEDULA"].ToString();
			//txtsalariobase.Text = datos["Salario_Base"].ToString();
			//txttipodecobro.Text = datos["Tipo_de_Cobro"].ToString();
			//txtturno.Text = datos["Turno"].ToString();
		}
		private void BuscarIncidencia()
		{
			using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
			{

				//string query = $"SELECT * FROM dbo.Empleados WHERE {ConvertirACriterioDeBusqueda(this.CriterioDeBusqueda.Text)}";
				//MessageBox.Show(query);
				//return;
				connection.Open();

				SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM dbo.Incidencias", connection);


				DataTable data = new DataTable();
				adapter.Fill(data);

				/*his.ListadodeEmpleados.DataSource = data;*/
				foreach (DataRow row in data.Rows)
				{
					//  Get.Green("[" + row["ID"] + "]" + "[" + row["created"] + "]" + " " + "[" + row["uname"] + "]" + " " + "[" + row["msg"] + "]");
					if (row["Id"].ToString()  == this.txtid.Text)
					{
						this.txtObservacion.Text = row["Observacion"].ToString();
						this.txtEmpleado.Text = row["Nombre_de_Empleado"].ToString();
						this.txtTipoDeIncidencia.Text = row["Nombre"].ToString();
						this.txtEmpleadoId.Text = row["EmpleadoID"].ToString();
						this.txtPosicion.Text = row["Posicion"].ToString();
						this.txtDepartamento.Text = row["Departamento"].ToString();
						return;
					}
				}
			}
		}
		private void BuscarEmpleado()
		{
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
					if (row["CEDULA"].ToString() == this.txtbusqueda.Text)
					{
						this.TomarDatos(row);
						return;
					}
					if (row["Id"].ToString()  == this.txtbusqueda.Text)
					{
						this.TomarDatos(row);
						return;
					}
					if (row["Nombre"].ToString().ToLower() +" "+row["Apellido"].ToString().ToLower()  ==  this.txtbusqueda.Text.ToLower())
					{
						this.TomarDatos(row);
						return;
					}
					if (row["Telefono"].ToString()  == this.txtbusqueda.Text)
					{
						this.TomarDatos(row);
						return;
					}
				}
			}
		}

		private void btnbusqueda_Click(object sender, EventArgs e)
		{
			this.BuscarEmpleado();
		}

		private void TestCheck_Click(object sender, EventArgs e)
		{

		}

		private void NuevaIncidencia_Click(object sender, EventArgs e)
		{
			this.btnRegistrar.Enabled = true;
			this.LimpiarCampos(); 
		}

		private void txtid_Leave(object sender, EventArgs e)
		{
			this.BuscarIncidencia(); 
		}

		private void txtid_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{	
				this.BuscarIncidencia();
			}
		}

		private void BtnRefrescar_Click(object sender, EventArgs e)
		{
			this.CargarIncidencias();
		}
	}
}
