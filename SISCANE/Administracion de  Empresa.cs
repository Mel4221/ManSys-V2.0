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
    public partial class Gestión_de_Empresa : Form
    {
        // Realizo la Conexión a la Base de Datos
        string connectionString = @"Server=DESKTOP-802OK33;Database=ManSys;Trusted_Connection=True;";

        public Gestión_de_Empresa()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntlimpiar_Click(object sender, EventArgs e)
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
            txtrnc.Clear();
            txtnombre.Clear();
            txtsector.Clear();
            txtdireccion.Clear();
            txtpais.Clear();
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
            string sql = "DELETE FROM Gestión_de_Usuarios WHERE Id=" + txtrnc.Text;

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "SP_Update_Gestión_de_Empresas";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@RNC", SqlDbType.Int));
            cm.Parameters["@Id"].Value = txtrnc.Text;

            cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cm.Parameters["@Nombre"].Value = txtnombre.Text;

            cm.Parameters.Add(new SqlParameter("@Sector_Empresarial", SqlDbType.VarChar));
            cm.Parameters["@Sector_Empresarial"].Value = txtsector.Text;

            cm.Parameters.Add(new SqlParameter("@Dirección", SqlDbType.VarChar));
            cm.Parameters["@Dirección"].Value = txtdireccion.Text;

            cm.Parameters.Add(new SqlParameter("@Pais", SqlDbType.VarChar));
            cm.Parameters["@Pais"].Value = txtpais.Text;

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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "SP_Insert_Gestión_de_Empresas";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@RNC", SqlDbType.Int));
            cm.Parameters["@RNC"].Value = txtrnc.Text;

            cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cm.Parameters["@Nombre"].Value = txtnombre.Text;

            cm.Parameters.Add(new SqlParameter("@Sector_Empresarial", SqlDbType.VarChar));
            cm.Parameters["@Sector_Empresarial"].Value = txtsector.Text;

            cm.Parameters.Add(new SqlParameter("@Dirección", SqlDbType.VarChar));
            cm.Parameters["@Dirección"].Value = txtdireccion.Text;

            cm.Parameters.Add(new SqlParameter("@Pais", SqlDbType.VarChar));
            cm.Parameters["@Pais"].Value = txtpais.Text;

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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LLenarGridEmpresas();
        }

        private void LLenarGridEmpresas()
        {
            //Codigo para llenar grid de empleados


            DataTable dtempleados = new DataTable();

            SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = dataConnection;

            SqlDataAdapter daempleados = new SqlDataAdapter("GetDB_Gestión_de_Empresas", dataConnection);

            daempleados.SelectCommand.CommandType = CommandType.StoredProcedure;



            ListadodeEmpresas.DataSource = dtempleados;
        }

        private void ListadodeEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtrnc.Text = ListadodeEmpresas.CurrentRow.Cells["RNC"].Value.ToString();
            txtnombre.Text = ListadodeEmpresas.CurrentRow.Cells["Nombre"].Value.ToString();
            txtsector.Text = ListadodeEmpresas.CurrentRow.Cells["Sector_Empresarial"].Value.ToString();
            txtdireccion.Text = ListadodeEmpresas.CurrentRow.Cells["Dirección"].Value.ToString();
            txtpais.Text = ListadodeEmpresas.CurrentRow.Cells["Pais"].Value.ToString();
            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void Gestión_de_Empresa_Load(object sender, EventArgs e)
        {
            LLenarGridEmpresas();
            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Gestión_de_Empresas WHERE RNC=" + txtbusqueda.Text;

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
                    txtrnc.Text = reader[0].ToString();
                    txtnombre.Text = reader[1].ToString();
                    txtsector.Text = reader[2].ToString();
                    txtdireccion.Text = reader[3].ToString();
                    txtpais.Text = reader[4].ToString();


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

        private void Gestión_de_Empresa_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtcontraseña_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
