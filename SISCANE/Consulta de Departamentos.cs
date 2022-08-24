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
    public partial class ConsultadeDepartamentos : Form
    {

           string connectionString;


        public ConsultadeDepartamentos()
        {
            //string connectionString;
            ConnectionString con = new ConnectionString();
            connectionString = con.Connection();
            Get.Green("InitializeComponent ConsultadeDepartamentos");
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
int wparam, int lparam);
        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bntlimpiar_Click(object sender, EventArgs e)
        {
            txtbusqueda.Clear();
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;

            cn.Open();

            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Mantenimiento_de_Nomina WHERE Id like ('" + txtbusqueda.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            ListadodeDepartamentos.DataSource = dt;

            cn.Close();
        }

        private void ListadodeDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LLenarGridNomina()
        {
            //Codigo para llenar grid de empleados


            DataTable dtempleados = new DataTable();

            SqlConnection dataConnection = new SqlConnection(connectionString);
            SqlCommand cm = new SqlCommand();
            cm.Connection = dataConnection;

            SqlDataAdapter daempleados = new SqlDataAdapter("GetDB_Mantenimiento_de_Nomina", dataConnection);

            daempleados.SelectCommand.CommandType = CommandType.StoredProcedure;

            daempleados.Fill(dtempleados);

            ListadodeDepartamentos.DataSource = dtempleados;
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LLenarGridNomina();
        }

        private void Form6_MouseDown(object sender, MouseEventArgs e)
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
