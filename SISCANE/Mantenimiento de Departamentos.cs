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
using System.Runtime.InteropServices;
using QuickTools;

namespace SISCANE
{
    public partial class mantenimientoDept : Form
    {
        string connectionString = "";
        public mantenimientoDept()
        {

            ConnectionString con = new ConnectionString();
            connectionString = con.Connection();
            Get.Green("InitializeComponent Mantenimiento de  Departamentos");
            Get.Yellow("Not completed yet ");

            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
int wparam, int lparam);

        private void mantenimientoDept_Load(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mantenimientoDept_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtid.Text != "")
                {
                    /*
                     SqlCommand cmd = new SqlCommand("AddFool", con);
                    cmd.CommandType = CommandType.StoredProcedure; 
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = 9;
                    cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = "W333333333";
                    cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = "B"; 
                    cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = "S"; 
                    cmd.ExecuteNonQuery(); DataTable dt = new DataTable(); 
                    SqlDataAdapter adapter = new SqlDataAdapter("GetFools", con); 
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure; 
                    adapter.Fill(dt);
                   */

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cm = new SqlCommand("dbo.Registrar_Departamento", con);

                        cm.CommandType = CommandType.StoredProcedure;

                        cm.Parameters.AddWithValue(@"Codigo", SqlDbType.Int).Value = int.Parse(txtid.Text);

                        cm.Parameters.AddWithValue("@Departamento", SqlDbType.VarChar).Value = txtnombre.Text;




                        cm.ExecuteNonQuery();


                        MessageBox.Show("Registro Guardado Satisfactoriamente");


                    }
                }

            }
            catch(Exception error)
            {
                MessageBox.Show("Algo No Salio Bien "+error);
            }

            }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;

            cm.CommandText = "Modificar_Departamento";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@Codigo", SqlDbType.Int).Value = txtid.Text;
            cm.Parameters.AddWithValue("@Departamento", SqlDbType.VarChar).Value = txtnombre.Text;




            cn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Actualizado Satisfactoriamente"); 
            cn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {


                con.Open();



                try
                {
                    SqlCommand cmd = new SqlCommand("Delete from dbo.Mantenimiento_de_Departmamento where Codigo=" + txtid.Text, con);
                    cmd.CommandType = CommandType.Text;


                    int i = cmd.ExecuteNonQuery();
                    if (1 > 0)
                    {
                        MessageBox.Show("Registro Eliminado Correctamente !");
                    }
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

            }
        } 
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open(); 
                SqlCommand cmd = new SqlCommand("Get_Departamentos", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapter.Fill(data); 
                
                SqlDataReader reader = cmd.ExecuteReader();

                data.Load(reader);
                ListadodeUsuarios.DataSource = data; 
            }
        }

        private void ListadodeUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bntlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtid.Text = "";
        }
    }
}