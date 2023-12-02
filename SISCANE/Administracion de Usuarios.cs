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
    public partial class Empleado : Form
    {
        // Realizo la Conexión a la Base de Datos
        //string connectionString = @"Server=DESKTOP-802OK33;Database=ManSys;Trusted_Connection=True;";

      
        public Empleado()
        {
            InitializeComponent();
        }


       
        private void LLenarGridUsuarios()
        {
            //Codigo para llenar grid de empleados

            /*
            DataTable dtempleados = new DataTable();

            SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = dataConnection;

            SqlDataAdapter daempleados = new SqlDataAdapter("GetDB_Gestión_de_Usuarios", dataConnection);

            daempleados.SelectCommand.CommandType = CommandType.StoredProcedure;

      
            ListadodeUsuarios.DataSource = dtempleados
                */
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void Limpiar()
        {
            txtid.Clear();
            txtEmpleado.Clear();
            txtcontra.Clear();
            txtcontra2.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //// Cargo el estado para el botón Nuevo y los demás elementos.
            //btnNuevo.Enabled = false;
            //btnRegistrar.Enabled = true;
            //btnModificar.Enabled = true;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = true;
            //btnBuscar.Enabled = true;
            //txtbusqueda.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

			if (this.txtid.Text == "")
			{
				MessageBox.Show("Falta el ID del Empleado");
				return;
			}
			if (!this.ExisteRegistro(this.txtid.Text))
			{
				MessageBox.Show("El Empleado no existe");
				return;
			}
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    con.Open();
					string query = "DELETE FROM dbo.Gestion_de_Usuarios WHERE EmpleadoId = @Id";

					SqlCommand cmd = new SqlCommand(query, con);

					cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
					cmd.Parameters["@Id"].Value = this.txtid.Text;
					cmd.ExecuteNonQuery();
                    this.Limpiar();
                    this.CargarUsuarios();
                }
            }catch(Exception ex){
                ShowError("Hubo un error al Eliminar el Usuario", ex);
            }
			//SqlConnection con = new SqlConnection(connectionString);
			//SqlCommand cmd = new SqlCommand(sql, con);
			//cmd.CommandType = CommandType.Text;
			//con.Open();

			//try
			//{
			//    int i = cmd.ExecuteNonQuery();
			//    if (1 > 0)
			//        MessageBox.Show("Registro Eliminado Correctamente !");
			//}
			//catch (Exception ex)
			//{
			//    MessageBox.Show("Error:" + ex.ToString());
			//}
			//finally
			//{
			//    con.Close();
			//}

			//btnNuevo.Enabled = true;
			//btnRegistrar.Enabled = false;
			//btnModificar.Enabled = false;
			//btnCancelar.Enabled = true;
			//btnEliminar.Enabled = false;
			//btnBuscar.Enabled = true;
			//txtbusqueda.Enabled = true;
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            this.BuscarEmpleado(null);
            //string sql = "SELECT * FROM Gestión_de_Usuarios WHERE Id=" + txtbusqueda.Text;

            //SqlConnection con = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = CommandType.Text;
            //SqlDataReader reader;
            //con.Open();
            //try
            //{
            //    reader = cmd.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        btnNuevo.Enabled = false;
            //        btnRegistrar.Enabled = true;
            //        btnModificar.Enabled = true;
            //        btnCancelar.Enabled = true;
            //        btnEliminar.Enabled = true;
            //        btnBuscar.Enabled = true;
            //        txtbusqueda.Enabled = true;
            //        txtnombre.Focus();
            //        txtid.Text = reader[0].ToString();
            //        txtnombre.Text = reader[1].ToString();
            //        txtapellido.Text = reader[2].ToString();
            //        txtpuesto.Text = reader[3].ToString();
            //        txtdepartamento.Text = reader[4].ToString();
            //        txtturno.Text = reader[5].ToString();
            //        txtnombreusuario.Text = reader[6].ToString();
            //        txtcontraseña.Text = reader[7].ToString();

            //    }
            //    else
            //        MessageBox.Show("Ningun Registro Encontrado con el Dato de Busqueda Ingresado !");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.ToString());
            //}
            //finally
            //{
            //    con.Close();
            //}

            //txtbusqueda.Text = "";

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LLenarGridUsuarios();
        }

		private bool ExisteRegistro(string id)
		{
            try
            {
                using (SqlConnection cn = new SqlConnection(Connection.ConnectionString))
                {
                    cn.Open();

                    SqlCommand cm = new SqlCommand("SELECT * FROM dbo.Empleados WHERE Id = @Id", cn);


                    cm.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
                    cm.Parameters["@Id"].Value = id;

                    SqlDataReader reader = cm.ExecuteReader();


                    if (reader.Read())
                    {
                        return true;
                    }
                    return false;
                }
            }catch{
                return false;
            }

		}
        private bool ExisteUsuario(string usuario){
			try
			{
				using (SqlConnection cn = new SqlConnection(Connection.ConnectionString))
				{
					cn.Open();

					SqlCommand cm = new SqlCommand("SELECT * FROM dbo.Gestion_de_Usuarios WHERE EmpleadoId = @EmpleadoId", cn);


					cm.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
					cm.Parameters["@EmpleadoId"].Value = usuario;

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
		public void ShowError(string message, Exception ex)
		{
			MessageBox.Show($"{message}\n{ex}", "Algo Salio mal!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}


		private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if(this.txtid.Text == ""){
                MessageBox.Show("Falta el ID del Empleado");
                return;
            }if(this.txtcontra.Text == "" || this.txtcontra.Text == ""){
				MessageBox.Show("Falta La contraseña del Empleado");
                return;
			}if(this.txtcontra.Text != this.txtcontra.Text){
				MessageBox.Show("Las Contraseñas no son iguales");
				return;
            }if(!this.ExisteRegistro(this.txtid.Text))
            {
				MessageBox.Show("El Empleado no existe");
				return;
            }if(this.txtcontra.Text.Length < 4){
				MessageBox.Show("La Contraseña es muy corta");
                return;
			}if(this.ExisteUsuario(this.txtid.Text))
            {
                MessageBox.Show("Este Usuario ya existe");
                return;
            }
            
			try
             {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    con.Open();
                    string query = $"INSERT INTO dbo.Gestion_de_Usuarios(EmpleadoId,Empleado,Contra)values(@EmpleadoId,@Empleado,@Contra)";
                    SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
					cmd.Parameters["@EmpleadoId"].Value = txtid.Text;
					cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
                    cmd.Parameters["@Empleado"].Value = txtEmpleado.Text;
					cmd.Parameters.Add(new SqlParameter("@Contra", SqlDbType.VarChar));
					cmd.Parameters["@Contra"].Value = txtcontra.Text;
                    cmd.ExecuteNonQuery();
                    this.Limpiar();
                    this.CargarUsuarios();
				}
               // MessageBox.Show($"{this.ExisteRegistro(this.txtid.Text)}");
             }catch(Exception ex)
             {
                this.ShowError("Hubo un error al procesar el registro de usuario debidoa a: ", ex);  
             }

            //SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            //SqlCommand cm = new SqlCommand();
            //cm.Connection = cn;
            //cm.CommandText = "SP_Insert_Gestión_de_Usuarios";
            //cm.CommandType = CommandType.StoredProcedure;
            
            //cm.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            //cm.Parameters["@Id"].Value = txtid.Text;

            //cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            //cm.Parameters["@Nombre"].Value = txtnombre.Text;

            //cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
            //cm.Parameters["@Apellido"].Value = txtapellido.Text;
        
            //cm.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
            //cm.Parameters["@Puesto_Ocupado"].Value = txtpuesto.Text;

            //cm.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
            //cm.Parameters["@Departamento"].Value = txtdepartamento.Text;

            //cm.Parameters.Add(new SqlParameter("@Turno", SqlDbType.VarChar));
            //cm.Parameters["@Turno"].Value = txtturno.Text;

            //cm.Parameters.Add(new SqlParameter("@Nombre_de_Usuario", SqlDbType.VarChar));
            //cm.Parameters["@Nombre_de_Usuario"].Value = txtnombreusuario.Text;

            //cm.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.VarChar));
            //cm.Parameters["@Contraseña"].Value = txtcontraseña.Text;

            //cn.Open();
            //cm.ExecuteNonQuery();
            //MessageBox.Show("Registro Guardado Satisfactoriamente");

            //this.EnableBtns();
    

        }
        private void EnableBtns()
        {
            //btnNuevo.Enabled = true;
            //btnRegistrar.Enabled = false;
            //btnModificar.Enabled = false;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = true;
            //btnBuscar.Enabled = true;
            //txtbusqueda.Enabled = true;
        }

        private void ListadodeUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtid.Text = ListadodeUsuarios.CurrentRow.Cells["Id"].Value.ToString();
            //txtnombre.Text = ListadodeUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            //txtapellido.Text = ListadodeUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
            //txtpuesto.Text = ListadodeUsuarios.CurrentRow.Cells["Puesto_Ocupado"].Value.ToString();
            //txtdepartamento.Text = ListadodeUsuarios.CurrentRow.Cells["Departamento"].Value.ToString();
            //txtturno.Text = ListadodeUsuarios.CurrentRow.Cells["Turno"].Value.ToString();
            //txtnombreusuario.Text = ListadodeUsuarios.CurrentRow.Cells["Nombre_de_Usuario"].Value.ToString();
            //txtcontraseña.Text = ListadodeUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
            //btnNuevo.Enabled = true;
            //btnRegistrar.Enabled = true;
            //btnModificar.Enabled = true;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
			if (this.txtid.Text == "")
			{
				MessageBox.Show("Falta el ID del Empleado");
				return;
			}
			if (this.txtcontra.Text == "" || this.txtcontra.Text == "")
			{
				MessageBox.Show("Falta La contraseña del Empleado");
				return;
			}
			if (this.txtcontra.Text != this.txtcontra.Text)
			{
				MessageBox.Show("Las Contraseñas no son iguales");
				return;
			}
			if (!this.ExisteRegistro(this.txtid.Text))
			{
				MessageBox.Show("El Empleado no existe");
				return;
			}
			if (this.txtcontra.Text.Length < 4)
			{
				MessageBox.Show("La Contraseña es muy corta");
				return;
			}
			if (!this.ExisteUsuario(this.txtid.Text))
			{
				MessageBox.Show("Este Usuario no existe");
				return;
			}

			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					string query = $"UPDATE dbo.Gestion_de_Usuarios SET EmpleadoId=@EmpleadoId,Empleado=@Empleado,Contra=@Contra WHERE EmpleadoId=@EmpleadoId";
					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
					cmd.Parameters["@EmpleadoId"].Value = txtid.Text;
					cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.VarChar));
					cmd.Parameters["@Empleado"].Value = txtEmpleado.Text;
					cmd.Parameters.Add(new SqlParameter("@Contra", SqlDbType.VarChar));
					cmd.Parameters["@Contra"].Value = txtcontra.Text;
					cmd.ExecuteNonQuery();
					this.Limpiar();
					this.CargarUsuarios();
                    MessageBox.Show("Constraseña Actualizada Correctamente!!!");
				}
				// MessageBox.Show($"{this.ExisteRegistro(;this.txtid.Text)}");
			}
			catch (Exception ex)
			{
				this.ShowError("Hubo un error al procesar el registro de usuario debidoa a: ", ex);
			}

			//SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
			//SqlCommand cm = new SqlCommand();
			//cm.Connection = cn;
			//cm.CommandText = "SP_Update_Gestión_de_Usuarios";
			//cm.CommandType = CommandType.StoredProcedure;

			//cm.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
			//cm.Parameters["@Id"].Value = txtid.Text;

			//cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
			//cm.Parameters["@Nombre"].Value = txtnombre.Text;

			//cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
			//cm.Parameters["@Apellido"].Value = txtapellido.Text;

			//cm.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
			//cm.Parameters["@Puesto_Ocupado"].Value = txtpuesto.Text;

			//cm.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
			//cm.Parameters["@Departamento"].Value = txtdepartamento.Text;

			//cm.Parameters.Add(new SqlParameter("@Turno", SqlDbType.VarChar));
			//cm.Parameters["@Turno"].Value = txtturno.Text;

			//cm.Parameters.Add(new SqlParameter("@Nombre_de_Usuario", SqlDbType.VarChar));
			//cm.Parameters["@Nombre_de_Usuario"].Value = txtnombreusuario.Text;

			//cm.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.VarChar));
			//cm.Parameters["@Contraseña"].Value = txtcontraseña.Text;

			//cn.Open();
			//cm.ExecuteNonQuery();
			//MessageBox.Show("Registro Guardado Satisfactoriamente");


			//btnNuevo.Enabled = true;
			//btnRegistrar.Enabled = false;
			//btnModificar.Enabled = false;
			//btnCancelar.Enabled = true;
			//btnEliminar.Enabled = true;
			//btnBuscar.Enabled = true;
			//txtbusqueda.Enabled = true;
		}

        private void bntlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
          //  txtcontraseña.UseSystemPasswordChar = false;
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
           // txtcontraseña.UseSystemPasswordChar = true;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
           // txtcontraseña.UseSystemPasswordChar = false;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
          //  txtcontraseña.UseSystemPasswordChar = true;
        }

		private void MostrarConstra_CheckStateChanged(object sender, EventArgs e)
		{
            if(!this.MostrarConstra.Checked)
            {
                this.txtcontra.UseSystemPasswordChar = true;
				this.txtcontra2.UseSystemPasswordChar = true;

				return;
			}else{
				this.txtcontra.UseSystemPasswordChar = false;
				this.txtcontra2.UseSystemPasswordChar = false;

			}
		}

		private void Gestión_de_Usuarios_Load(object sender, EventArgs e)
		{
			//LLenarGridUsuarios();
			//btnNuevo.Enabled = true;
			//btnRegistrar.Enabled = false;
			//btnModificar.Enabled = false;
			//btnCancelar.Enabled = true;
			//btnEliminar.Enabled = true;
			//btnBuscar.Enabled = true;
			//txtbusqueda.Enabled = true;
			this.txtcontra.UseSystemPasswordChar = true;
			this.txtcontra2.UseSystemPasswordChar = true;
            this.CargarUsuarios();

		}
        private void CargarUsuarios()
        {
			try
			{

				using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
				{
					dataConnection.Open();
					DataTable dtempleados = new DataTable();
					SqlDataAdapter daempleados = new SqlDataAdapter("SELECT * FROM dbo.Gestion_de_Usuarios", dataConnection);
 					daempleados.Fill(dtempleados);
					ListadodeUsuarios.DataSource = dtempleados;
				}
			}
			catch (Exception ex)
			{
				ShowError("Hubo un error al Cargar los Usuarios", ex);
			}
		}

		private void txtid_Leave(object sender, EventArgs e)
		{
            this.BuscarEmpleado(this.txtid.Text);
		}
        private void BuscarEmpleado(string id)
        {

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
                    if (row["Id"].ToString()  == id)
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
		private void TomarDatos(DataRow datos)
		{
            //  DateTime.ParseExact(datos["Fecha_de_Ingreso"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            //MessageBox.Show(DateTime.ParseExact(datos["Fecha_de_Ingreso"].ToString(), "dd/MM/yyyy"));
            //return;
            txtid.Text = datos["Id"].ToString();
 			txtEmpleado.Text = datos["Nombre"].ToString()+" "+datos["Apellido"].ToString();
			//txtdireccion.Text = datos["Direccion"].ToString();
			//txttelefono.Text = datos["Telefono"].ToString();
			//Fecha_de_Ingreso_Label.Text = datos["Fecha_de_Ingreso"].ToString();
			//txtpuestoocupado.Text =datos["Puesto_Ocupado"].ToString();
			//txtdeparmento.Text = datos["Departamento"].ToString();
			//txtdni.Text = datos["CEDULA"].ToString();
			//txtsalariobase.Text = datos["Salario_Base"].ToString();
			//txttipodecobro.Text = datos["Tipo_de_Cobro"].ToString();
			//txtturno.Text = datos["Turno"].ToString();
		}
		private void txtid_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.BuscarEmpleado(this.txtid.Text);
				//e.SuppressKeyPress = false;
			}
		}

		private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.BuscarEmpleado(null);
			}
		}
	}
}
