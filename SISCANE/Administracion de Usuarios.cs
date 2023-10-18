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
    public partial class Gestión_de_Usuarios : Form
    {
        // Realizo la Conexión a la Base de Datos
        string connectionString = @"Server=DESKTOP-802OK33;Database=ManSys;Trusted_Connection=True;";

      
        public Gestión_de_Usuarios()
        {
            InitializeComponent();
        }


        


        private void Form4_Load(object sender, EventArgs e)
        {
            LLenarGridUsuarios();
            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
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
            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
            Limpiar();
        }
        private void Limpiar()
        {
            txtid.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtpuesto.ResetText();
            txtdepartamento.ResetText();
            txtturno.Clear();
            txtnombreusuario.Clear();
            txtcontraseña.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Cargo el estado para el botón Nuevo y los demás elementos.
            btnNuevo.Enabled = false;
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Gestión_de_Usuarios WHERE Id=" + txtid.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (1 > 0)
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

            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Gestión_de_Usuarios WHERE Id=" + txtbusqueda.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    btnNuevo.Enabled = false;
                    btnRegistrar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnBuscar.Enabled = true;
                    txtbusqueda.Enabled = true;
                    txtnombre.Focus();
                    txtid.Text = reader[0].ToString();
                    txtnombre.Text = reader[1].ToString();
                    txtapellido.Text = reader[2].ToString();
                    txtpuesto.Text = reader[3].ToString();
                    txtdepartamento.Text = reader[4].ToString();
                    txtturno.Text = reader[5].ToString();
                    txtnombreusuario.Text = reader[6].ToString();
                    txtcontraseña.Text = reader[7].ToString();

                }
                else
                    MessageBox.Show("Ningun Registro Encontrado con el Dato de Busqueda Ingresado !");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            txtbusqueda.Text = "";

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LLenarGridUsuarios();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "SP_Insert_Gestión_de_Usuarios";
            cm.CommandType = CommandType.StoredProcedure;
            
            cm.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            cm.Parameters["@Id"].Value = txtid.Text;

            cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cm.Parameters["@Nombre"].Value = txtnombre.Text;

            cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
            cm.Parameters["@Apellido"].Value = txtapellido.Text;
        
            cm.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
            cm.Parameters["@Puesto_Ocupado"].Value = txtpuesto.Text;

            cm.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
            cm.Parameters["@Departamento"].Value = txtdepartamento.Text;

            cm.Parameters.Add(new SqlParameter("@Turno", SqlDbType.VarChar));
            cm.Parameters["@Turno"].Value = txtturno.Text;

            cm.Parameters.Add(new SqlParameter("@Nombre_de_Usuario", SqlDbType.VarChar));
            cm.Parameters["@Nombre_de_Usuario"].Value = txtnombreusuario.Text;

            cm.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.VarChar));
            cm.Parameters["@Contraseña"].Value = txtcontraseña.Text;

            cn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Guardado Satisfactoriamente");

            this.EnableBtns();
    

        }
        private void EnableBtns()
        {
            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
        }

        private void ListadodeUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = ListadodeUsuarios.CurrentRow.Cells["Id"].Value.ToString();
            txtnombre.Text = ListadodeUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            txtapellido.Text = ListadodeUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
            txtpuesto.Text = ListadodeUsuarios.CurrentRow.Cells["Puesto_Ocupado"].Value.ToString();
            txtdepartamento.Text = ListadodeUsuarios.CurrentRow.Cells["Departamento"].Value.ToString();
            txtturno.Text = ListadodeUsuarios.CurrentRow.Cells["Turno"].Value.ToString();
            txtnombreusuario.Text = ListadodeUsuarios.CurrentRow.Cells["Nombre_de_Usuario"].Value.ToString();
            txtcontraseña.Text = ListadodeUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "SP_Update_Gestión_de_Usuarios";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            cm.Parameters["@Id"].Value = txtid.Text;

            cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cm.Parameters["@Nombre"].Value = txtnombre.Text;

            cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
            cm.Parameters["@Apellido"].Value = txtapellido.Text;

            cm.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
            cm.Parameters["@Puesto_Ocupado"].Value = txtpuesto.Text;

            cm.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
            cm.Parameters["@Departamento"].Value = txtdepartamento.Text;

            cm.Parameters.Add(new SqlParameter("@Turno", SqlDbType.VarChar));
            cm.Parameters["@Turno"].Value = txtturno.Text;

            cm.Parameters.Add(new SqlParameter("@Nombre_de_Usuario", SqlDbType.VarChar));
            cm.Parameters["@Nombre_de_Usuario"].Value = txtnombreusuario.Text;

            cm.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.VarChar));
            cm.Parameters["@Contraseña"].Value = txtcontraseña.Text;

            cn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Guardado Satisfactoriamente");


            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
        }

        private void bntlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtcontraseña.UseSystemPasswordChar = false;
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
            txtcontraseña.UseSystemPasswordChar = true;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            txtcontraseña.UseSystemPasswordChar = false;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            txtcontraseña.UseSystemPasswordChar = true;
        }
    }
}
