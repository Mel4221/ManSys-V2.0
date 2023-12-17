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
using System.IO;
using System.Diagnostics;
 
using System.Runtime.Remoting.Contexts;
using System.Threading;
using QuickTools.QCore;
using QuickTools.QNet;
 

namespace ManSys
{
    public partial class GenerarVolanteDePago : Form
    {
        public GenerarVolanteDePago()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarVolanteDePago_Load(object sender, EventArgs e)
        {
			this.CargarNomina();
        }
		private DataTable _Nomina;

		public object LocalPrintServer { get; private set; }

		private void CargarNomina()
		{
			try
			{
				
				using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
				{
					dataConnection.Open();
					_Nomina = new DataTable();
					DataTable filtro = new DataTable();
					filtro.Columns.Add("Periodo", typeof(string));
					//filtro.Columns.Add("Fecha", typeof(string));

					SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Nomina", dataConnection);
					adapter.Fill(_Nomina);
					List<string> lista = new List<string>();
					foreach (DataRow row in _Nomina.Rows)
					{
						if (!lista.Contains(row["Periodo"].ToString()))
						{
							lista.Add(Name = row["Periodo"].ToString());
						}
					}
					lista.ForEach((item) => {
						this.Fecha_de_Pago.Items.Add(item);
					});

					

				}
			}
			catch (Exception ex)
			{
				ShowError("Hubo un error al Cargar las Nominas", ex);
			}
		}
        private void GenerarVolanteDePago_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void TomarDatos(DataRow datos)
		{
			//  DateTime.ParseExact(datos["Fecha_de_Ingreso"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

			//MessageBox.Show(DateTime.ParseExact(datos["Fecha_de_Ingreso"].ToString(), "dd/MM/yyyy"));
			//return;
			EmpleadoId.Text = datos["Id"].ToString();
			Nombre.Text = datos["Nombre"].ToString();
			Apellido.Text = datos["Apellido"].ToString();
			//txtdireccion.Text = datos["Direccion"].ToString();
			//txttelefono.Text = datos["Telefono"].ToString();
			//Fecha_de_Ingreso_Label.Text = datos["Fecha_de_Ingreso"].ToString();
			Puesto_Ocupado.Text =datos["Puesto_Ocupado"].ToString();
			Departramento.Text = datos["Departamento"].ToString();
			Cedula.Text = datos["CEDULA"].ToString();
			Salario_Base.Text = datos["Salario_Base"].ToString();
			Tipo_de_Cobro.Text = datos["Tipo_de_Cobro"].ToString();
			//Tuple.Text = datos["Turno"].ToString();
		}
		private void BuscarEmpleado()
        {
			try
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
						if (row["CEDULA"].ToString() == this.EmpleadoId.Text)
						{
							this.TomarDatos(row);
							return;
						}
						if (row["Id"].ToString()  == this.EmpleadoId.Text)
						{
							this.TomarDatos(row);
							return;
						}
						if (row["Nombre"].ToString().ToLower() +" "+row["Apellido"].ToString().ToLower()  ==  this.EmpleadoId.Text.ToLower())
						{
							this.TomarDatos(row);
							return;
						}
						if (row["Telefono"].ToString()  == this.EmpleadoId.Text)
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
					MessageBox.Show("Ningun Registro Encontrado con el Dato de Busqueda Ingresado");


				}
			}
			catch (Exception ex)
			{
				ShowError("Hubo un error al buscar el Empleado", ex);
			}
		}
		public void ShowError(string message, Exception ex) => MessageBox.Show($"{message}\n{ex}", "Algo Salio mal!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			this.BuscarEmpleado();
		}

		private void EmpleadoId_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.BuscarEmpleado();
				e.SuppressKeyPress = true;
			}
		}

	 
		private void BuscarNomina()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					SqlCommand cmd = new SqlCommand($"SELECT * FROM dbo.Nomina WHERE EmpleadoId = @EmpleadoId AND Periodo = @Periodo", con);

					cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
					cmd.Parameters["@EmpleadoId"].Value = this.EmpleadoId.Text;

					cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar));
					cmd.Parameters["@Periodo"].Value = this.Fecha_de_Pago.Text;

					DataTable table = new DataTable();
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					adapter.Fill(table);
				
					if(table.Rows.Count > 0 )
					{
						GenerarNomina nomina = new GenerarNomina();
						nomina.CargarDatos();
						
						foreach (DataRow row in table.Rows)
						{
							//this.Salario_Base.Text = row["Salario_Base"].ToString();
							this.Valor_Hora.Text = row["Salario_Base"].ToString();
							this.Horas_Trabajadas.Text = row["Horas_Trabajadas"].ToString();
							this.Horas_Trabajadas_Extra.Text = row["Horas_Extras"].ToString();
							this.Total_de_Ingreso.Text = row["Ingreso"].ToString();
							this.TotalBonos.Text = nomina.ConseguirTotalDeBonificaciones(int.Parse(row["EmpleadoId"].ToString())).ToString();
							nomina.BonosPersonales.ForEach(item => this.BonosList.Text+=$"{item.Name} {item.Value}\n");
							this.Total_de_Descuento.Text = nomina.ConseguirTotalDeDescuento(int.Parse(row["EmpleadoId"].ToString())).ToString();
							nomina.DescuentosPersonales.ForEach(item => this.DescuentosList.Text+=$"{item.Name} {item.Value}\n");
						}
						return;
					}else{
						MessageBox.Show($"No se encontraron registros de nomina para ese empleado de la siguiente fecha: {this.Fecha_de_Pago.Text}");
						return;
					}
					

				}
			}
			catch(Exception ex )
			{
				ShowError("Hubo un errror al tratar de buscar la Nomina", ex); 
			}
		}
		private void Fecha_de_Pago_TextChanged(object sender, EventArgs e)
		{
			this.BuscarNomina();
		}
		//Bitmap bmp;
		private void btnImprimir_Click(object sender, EventArgs e)
		{
			if (this.Fecha_de_Pago.Text == "") { MessageBox.Show("El Periodo de Nomina esta Vacio"); return; }
			string recibo = File.ReadAllText("Recibo.html");
			recibo = recibo.Replace("@Nombre",this.Nombre.Text);
			recibo = recibo.Replace("@Apellido", this.Apellido.Text);
			recibo = recibo.Replace("@Id",this.EmpleadoId.Text);
			recibo = recibo.Replace("@Nomina",this.Fecha_de_Pago.Text);



		}


	}
}
