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
using QuickTools.QCore;
using System.Linq.Expressions;
using QuickTools.QIO;
using System.Globalization;

namespace ManSys
{
 
    public partial class MantenimientoDeEmpleados : Form
    {
        // Realizo la Conexión a la Base de Datos
        string connectionString = Connection.ConnectionString;
        bool nuevo;

        public MantenimientoDeEmpleados()
        {
            InitializeComponent();
        }


        private bool TodoEstaCompleto()
        {
            if (txtNombre.Text == "" ||
                 txtApellido.Text == ""||
                 txtdireccion.Text == ""||
                 txttelefono.Text == ""||
                 txtfechadeingreso.Text == "" ||
                 txtdeparmento.Text == "" ||
                 txtdni.Text == ""||
                 txtsalariobase.Text == ""||
                 txttipodecobro.Text == ""||
                 txtturno.Text == ""
               )
            {
                return false; 
            }

        
  
            return true;
        }
        private bool ExisteRegistro()
        {
               using(SqlConnection cn = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand cm = new SqlCommand();

                cn.Open();
                cm.Connection = cn;
                cm.CommandText = "SP_Verificar";
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                cm.Parameters["@Nombre"].Value = txtNombre.Text;

                cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
                cm.Parameters["@Apellido"].Value = txtApellido.Text;

                cm.Parameters.Add(new SqlParameter("@CEDULA", SqlDbType.VarChar));
                cm.Parameters["@CEDULA"].Value = txtdni.Text;
                SqlDataReader reader = cm.ExecuteReader();


                if (reader.Read())
                {
                    return true;
                }
                return false;
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
					this.txtpuestoocupado.Items.Clear();
					foreach (DataRow row in posiciones.Rows)
					{
						this.txtpuestoocupado.Items.Add(row["Nombre"].ToString());
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
                    this.txtdeparmento.Items.Clear(); 
                    foreach(DataRow row in  departamentos.Rows)
                    {
						this.txtdeparmento.Items.Add(row["Nombre"].ToString());
					}


				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un error al Cargar los Departamentos", ex);
			}
		}
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {

                bool cumpleCondiciones = true;
            if (ExisteRegistro())
            {
                MessageBox.Show("El Usuario ya Existe");
                cumpleCondiciones = false;
                return;
            }

            if (TodoEstaCompleto() == false)
            {
                MessageBox.Show("Pofavor completar todos los campos");
                cumpleCondiciones = false;
                return; 
            }
            if (cumpleCondiciones)
            {


                SqlCommand cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandText = "SP_Insert_Mantenimiento_de_Empleados";
                cm.CommandType = CommandType.StoredProcedure;
                /*
                cm.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
                cm.Parameters["@Id"].Value = txtId.Text;
                */
                cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                cm.Parameters["@Nombre"].Value = txtNombre.Text;

                cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
                cm.Parameters["@Apellido"].Value = txtApellido.Text;

                cm.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
                cm.Parameters["@Direccion"].Value = txtdireccion.Text;

                cm.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
                cm.Parameters["@Telefono"].Value = txttelefono.Text;

                cm.Parameters.Add(new SqlParameter("@Fecha_de_Ingreso", SqlDbType.VarChar));
                cm.Parameters["@Fecha_de_Ingreso"].Value = DateTime.Parse(txtfechadeingreso.Text).ToString("dd/M/yyyy");
                
                cm.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
                
                cm.Parameters["@Puesto_Ocupado"].Value = txtpuestoocupado.Text;

                cm.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
                cm.Parameters["@Departamento"].Value = txtdeparmento.Text;

                cm.Parameters.Add(new SqlParameter("@CEDULA", SqlDbType.VarChar));
                cm.Parameters["@CEDULA"].Value = txtdni.Text;

                cm.Parameters.Add(new SqlParameter("@Salario_Base", SqlDbType.VarChar));
                cm.Parameters["@Salario_Base"].Value = txtsalariobase.Text;

                cm.Parameters.Add(new SqlParameter("@Tipo_de_Cobro", SqlDbType.VarChar));
                cm.Parameters["@Tipo_de_Cobro"].Value = txttipodecobro.Text;

                cm.Parameters.Add(new SqlParameter("@Turno", SqlDbType.VarChar));
                cm.Parameters["@Turno"].Value = txtturno.Text;

                cn.Open();
                cm.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado Satisfactoriamente");

                /*
                btnNuevo.Enabled = true;
                btnRegistrar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = true;
                btnEliminar.Enabled = true;
                btnBuscar.Enabled = true;
                txtbusqueda.Enabled = true;
                */
                cn.Close();
               btnRegistrar.Enabled = false;

			}
        }catch(Exception ex)
            {
                ShowError("No se pudo hacer el registro porque: ", ex);
                cn.Close(); 
            }


}
        public void ShowError(string message , Exception ex) => MessageBox.Show($"{message}\n{ex}", "Algo Salio mal!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        private void Limpiar()
        {
            txtId.ResetText();
            txtNombre.Clear();
            txtApellido.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtfechadeingreso.ResetText();
            txtpuestoocupado.ResetText();
            txtdeparmento.ResetText();
            txtdni.Clear();
            txtsalariobase.Clear();
            txttipodecobro.ResetText();
            BusquedaAvanzadaCheck.Checked = false; 
            //txtturno.Clear();
        }

        private void MantenimientoDeEmpleados_Load(object sender, EventArgs e)
        {
            LLenarGridEmpleados();
            CargarDepartamentos();
            CargarPosiciones();
			// TODO: This line of code loads data into the 'empleadosDataSet.Empleados' table. You can move, or remove it, as needed.
			//this.empleadosTableAdapter.Fill(this.empleadosDataSet.Empleados);
			//
			// TODO: This line of code loads data into the 'manSysDBDataSet.GetDB_Mantenimiento_de_Empleados' table. You can move, or remove it, as needed.
			//this.getDB_Mantenimiento_de_EmpleadosTableAdapter.Fill(this.manSysDBDataSet.GetDB_Mantenimiento_de_Empleados);
			/*
           LLenarGridEmpleados();

           btnNuevo.Enabled = true;
           btnRegistrar.Enabled = false;
           btnModificar.Enabled = false;
           btnCancelar.Enabled = true;
           btnEliminar.Enabled = true;
           btnBuscar.Enabled = true;
           txtbusqueda.Enabled = true;
           */

		}

        private void LLenarGridEmpleados()
        {
            //Codigo para llenar grid de empleados

            //new Task(() =>
            //{
            try
            {

                using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
                {
                    dataConnection.Open();
                    DataTable dtempleados = new DataTable();
                    SqlDataAdapter daempleados = new SqlDataAdapter("GetDB_Mantenimiento_de_Empleados", dataConnection);
                    daempleados.SelectCommand.CommandType = CommandType.StoredProcedure;
                    daempleados.Fill(dtempleados);
                    ListadodeEmpleados.DataSource = dtempleados;
                }
            }catch(Exception ex)
            {
                ShowError("Hubo un error al Cargar los Empleados", ex);
            }
			//}).RunSynchronously();
			//ListadodeEmpleados.Update();/
			//ListadodeEmpleados.DataSource = daempleados;
			//ListadodeEmpleados.Refresh(); 
		}


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Cargo el estado para el botón Nuevo y los demás elementos.
            //btnNuevo.Enabled = false;
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = true;
            // btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
            nuevo = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //btnNuevo.Enabled = true;
            //btnRegistrar.Enabled = false;
            //btnModificar.Enabled = false;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = true;
            //btnBuscar.Enabled = true;
            //txtbusqueda.Enabled = true;
            //Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM dbo.Empleados WHERE Id=" + txtId.Text;
            if (MessageBox.Show($"Esta seguro que quiere Eliminar el Empleado: {txtNombre.Text} {txtApellido.Text}", "Alerta", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro Eliminado Correctamente !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            //btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            //btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
        }


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtfechadeingreso_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TomarDatos(DataRow datos)
        {
            //  DateTime.ParseExact(datos["Fecha_de_Ingreso"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            //MessageBox.Show(DateTime.ParseExact(datos["Fecha_de_Ingreso"].ToString(), "dd/MM/yyyy"));
            //return;
			txtId.Text = datos["Id"].ToString();
			txtNombre.Text = datos["Nombre"].ToString();
			txtApellido.Text = datos["Apellido"].ToString();
			txtdireccion.Text = datos["Direccion"].ToString();
			txttelefono.Text = datos["Telefono"].ToString();
            Fecha_de_Ingreso_Label.Text = datos["Fecha_de_Ingreso"].ToString();
			txtpuestoocupado.Text =datos["Puesto_Ocupado"].ToString();
			txtdeparmento.Text = datos["Departamento"].ToString();
			txtdni.Text = datos["CEDULA"].ToString();
			txtsalariobase.Text = datos["Salario_Base"].ToString();
			txttipodecobro.Text = datos["Tipo_de_Cobro"].ToString();
			txtturno.Text = datos["Turno"].ToString();
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


		private void BusquedaAvanzada()
        {
			try
			{
				if (txtbusqueda.Text == "")
				{
                    this.LLenarGridEmpleados();
					return;
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();//SELECT * FROM ask WHERE name LIKE 'ali'
					SqlCommand cmd = new SqlCommand($"SELECT * FROM dbo.Empleados", con);

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
						if (this.IsLike(row["Nombre"].ToString().ToLower(), this.txtbusqueda.Text.ToLower()))
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
				ShowError($"Hubo un error al Buscar el Departamento: '{this.txtbusqueda.Text}'", ex);
			}
		}
        private void BuscarEmpleado()
        {

                if(this.BusquedaAvanzadaCheck.Checked){
                    this.BusquedaAvanzada();
                return;
                }
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
		private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarEmpleado();
       
            //    }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.ToString());
            //}


            //txtbusqueda.Text = "";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        
            
            SqlConnection cn = new SqlConnection(Connection.ConnectionString);
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
             
            cm.CommandText = "SP_Update_Mantenimiento_de_Empleados";
            cm.CommandType = CommandType.StoredProcedure;
			cm.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            cm.Parameters["@Id"].Value = this.txtId.Text;

			cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cm.Parameters["@Nombre"].Value = txtNombre.Text;

            cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
            cm.Parameters["@Apellido"].Value = txtApellido.Text;

            cm.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
            cm.Parameters["@Direccion"].Value = txtdireccion.Text;

            cm.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
            cm.Parameters["@Telefono"].Value = txttelefono.Text;

            cm.Parameters.Add(new SqlParameter("@Fecha_de_Ingreso", SqlDbType.VarChar));
            cm.Parameters["@Fecha_de_Ingreso"].Value = DateTime.Parse(txtfechadeingreso.Text).ToString("dd/M/yyyy") ==  DateTime.Now.ToString("dd/M/yyyy") ? this.Fecha_de_Ingreso_Label.Text : DateTime.Parse(txtfechadeingreso.Text).ToString("dd/M/yyyy");

			cm.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
            cm.Parameters["@Puesto_Ocupado"].Value = txtpuestoocupado.Text;

            cm.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
            cm.Parameters["@Departamento"].Value = txtdeparmento.Text;

            cm.Parameters.Add(new SqlParameter("@CEDULA", SqlDbType.VarChar));
            cm.Parameters["@CEDULA"].Value = txtdni.Text;

            cm.Parameters.Add(new SqlParameter("@Salario_Base", SqlDbType.VarChar));
            cm.Parameters["@Salario_Base"].Value = txtsalariobase.Text;

            cm.Parameters.Add(new SqlParameter("@Tipo_de_Cobro", SqlDbType.VarChar));
            cm.Parameters["@Tipo_de_Cobro"].Value = txttipodecobro.Text;

            cm.Parameters.Add(new SqlParameter("@Turno", SqlDbType.VarChar));
            cm.Parameters["@Turno"].Value = txtturno.Text;



            cn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Actualizado Satisfactoriamente");
            LLenarGridEmpleados();
            cn.Close();

            //btnNuevo.Enabled = true;
            //btnRegistrar.Enabled = false;
            //btnModificar.Enabled = false;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = false;
            //btnBuscar.Enabled = true;
            //txtbusqueda.Enabled = true;
            
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LLenarGridEmpleados();
        }

        private void bntlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }



		private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
		{
            if(this.BusquedaAvanzadaCheck.Checked)
            {
                this.BusquedaAvanzada();
                return;
            }
			if (e.KeyCode == Keys.Enter)
			{
                this.BuscarEmpleado();
				e.SuppressKeyPress = false;
			}


		}
	}
    }

