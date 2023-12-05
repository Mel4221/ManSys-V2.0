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
            CargarDatos();
        }
		private bool EsMultipleRegistro()
		{		if(ApplicarATodos.Checked || 
					ApplicarSoloADepartamento.Checked ||		
					ApplicarSoloAPosicion.Checked){
				return true;
					}else{
				return false;
					}
		}
		private void RegistrarMultiples()
		{

		}
		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			if(this.CajaDeTipoDeBonificacion.Text == "")
			{
				MessageBox.Show("Falta El tipo de Bonificacion");
				return;
			}if(this.EsMultipleRegistro())
			{
				this.RegistrarMultiples();
				return;
			}
			if(this.CajaDeEmpleadoId.Text == "")
			{
				MessageBox.Show("Falta el ID del Empleado");
				return;
			}
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
	}
}
