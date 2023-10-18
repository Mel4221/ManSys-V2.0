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
    public partial class ConsultaDeEmpleados : Form
    {
        public ConsultaDeEmpleados()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
        int wparam, int lparam);

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultaDeEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntlimpiar_Click(object sender, EventArgs e)
        {
            txtbusqueda.ResetText();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;

            cn.Open();

            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Mantenimiento_de_Empleados WHERE Id like ('" + txtbusqueda.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            ListadodeEmpleados.DataSource = dt;

            cn.Close();
        }
        private void LLenarGridEmpleados()
        {
            //Codigo para llenar grid de empleados


            DataTable dtempleados = new DataTable();

            SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = dataConnection;

            SqlDataAdapter daempleados = new SqlDataAdapter("GetDB_Mantenimiento_de_Empleados", dataConnection);

            daempleados.SelectCommand.CommandType = CommandType.StoredProcedure;

            daempleados.Fill(dtempleados);
            ListadodeEmpleados.DataSource = dtempleados;
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LLenarGridEmpleados();
        }

        private void ConsultaDeEmpleados_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
