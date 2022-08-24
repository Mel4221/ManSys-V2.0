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
using QuickTools;

namespace SISCANE
{
    public partial class Form3 : Form
    {
        // Realizo la Conexión a la Base de Datos
        string connectionString = "";
        bool nuevo;

        public Form3()
        {
            //string connectionString = "";
            ConnectionString con = new ConnectionString();
            connectionString = con.Connection();
            Get.Green("InitializeComponent Mantenimiento_De_Empleados ");
            
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
int wparam, int lparam);

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "SP_Insert_Mantenimiento_de_Empleados";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            cm.Parameters["@Id"].Value = txtId.Text;

            cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cm.Parameters["@Nombre"].Value = txtNombre.Text;

            cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
            cm.Parameters["@Apellido"].Value = txtApellido.Text;

            cm.Parameters.Add(new SqlParameter("@Dirección", SqlDbType.VarChar));
            cm.Parameters["@Dirección"].Value = txtdireccion.Text;

            cm.Parameters.Add(new SqlParameter("@Teléfono", SqlDbType.VarChar));
            cm.Parameters["@Teléfono"].Value = txttelefono.Text;

            cm.Parameters.Add(new SqlParameter("@Fecha_de_Ingreso", SqlDbType.VarChar));
            cm.Parameters["@Fecha_de_Ingreso"].Value = txtfechadeingreso.Text;

            cm.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
            cm.Parameters["@Puesto_Ocupado"].Value = txtpuestoocupado.Text;

            cm.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
            cm.Parameters["@Departamento"].Value = txtdeparmento.Text;

            cm.Parameters.Add(new SqlParameter("@DNI", SqlDbType.VarChar));
            cm.Parameters["@DNI"].Value = txtdni.Text;

            cm.Parameters.Add(new SqlParameter("@Salario_Base", SqlDbType.VarChar));
            cm.Parameters["@Salario_Base"].Value = txtsalariobase.Text;

            cm.Parameters.Add(new SqlParameter("@Tipo_de_Cobro", SqlDbType.VarChar));
            cm.Parameters["@Tipo_de_Cobro"].Value = txttipodecobro.Text;

            cm.Parameters.Add(new SqlParameter("@Turno", SqlDbType.VarChar));
            cm.Parameters["@Turno"].Value = txtturno.Text;

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
            txtturno.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LLenarGridEmpleados();

            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;

            
        }

        private void LLenarGridEmpleados()
        {
            //Codigo para llenar grid de empleados


            DataTable dtempleados = new DataTable();

            SqlConnection dataConnection = new SqlConnection(connectionString);
            SqlCommand cm = new SqlCommand();
            cm.Connection = dataConnection;

            SqlDataAdapter daempleados = new SqlDataAdapter("GetDB_Mantenimiento_de_Empleados", dataConnection);

            daempleados.SelectCommand.CommandType = CommandType.StoredProcedure;

           
            ListadodeEmpleados.DataSource = dtempleados;
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
            nuevo = true;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Mantenimiento_de_Empleados WHERE Id=" + txtId.Text;

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


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtfechadeingreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Mantenimiento_de_Empleados WHERE Id=" + txtbusqueda.Text;

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
                    txtNombre.Focus();
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
                    nuevo = false;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;

            cm.CommandText = "SP_Update_Mantenimiento_de_Empleados";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            cm.Parameters["@Id"].Value = txtId.Text;

            cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cm.Parameters["@Nombre"].Value = txtNombre.Text;

            cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
            cm.Parameters["@Apellido"].Value = txtApellido.Text;

            cm.Parameters.Add(new SqlParameter("@Dirección", SqlDbType.VarChar));
            cm.Parameters["@Dirección"].Value = txtdireccion.Text;

            cm.Parameters.Add(new SqlParameter("@Teléfono", SqlDbType.VarChar));
            cm.Parameters["@Teléfono"].Value = txttelefono.Text;

            cm.Parameters.Add(new SqlParameter("@Fecha_de_Ingreso", SqlDbType.VarChar));
            cm.Parameters["@Fecha_de_Ingreso"].Value = txtfechadeingreso.Text;

            cm.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
            cm.Parameters["@Puesto_Ocupado"].Value = txtpuestoocupado.Text;

            cm.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
            cm.Parameters["@Departamento"].Value = txtdeparmento.Text;

            cm.Parameters.Add(new SqlParameter("@DNI", SqlDbType.VarChar));
            cm.Parameters["@DNI"].Value = txtdni.Text;

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

            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LLenarGridEmpleados();
        }

        private void ListadodeEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = ListadodeEmpleados.CurrentRow.Cells["Codigo"].Value.ToString();
            txtNombre.Text = ListadodeEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = ListadodeEmpleados.CurrentRow.Cells["Apellido"].Value.ToString();
            txtdireccion.Text = ListadodeEmpleados.CurrentRow.Cells["Dirección"].Value.ToString();
            txttelefono.Text = ListadodeEmpleados.CurrentRow.Cells["Teléfono"].Value.ToString();
            txtfechadeingreso.Text = ListadodeEmpleados.CurrentRow.Cells["Fecha_de_Ingreso"].Value.ToString();
            txtpuestoocupado.Text = ListadodeEmpleados.CurrentRow.Cells["Puesto_Ocupado"].Value.ToString();
            txtdeparmento.Text = ListadodeEmpleados.CurrentRow.Cells["Departamento"].Value.ToString();
            txtdni.Text = ListadodeEmpleados.CurrentRow.Cells["DNI"].Value.ToString();
            txtsalariobase.Text = ListadodeEmpleados.CurrentRow.Cells["Salario_Base"].Value.ToString();
            txttipodecobro.Text = ListadodeEmpleados.CurrentRow.Cells["Tipo_de_Cobro"].Value.ToString();
            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        private void bntlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
    }

