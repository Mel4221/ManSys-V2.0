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
using QuickTools;

namespace SISCANE
{
    public partial class Form7 : Form
    {
        string connectionString;
        public Form7()
        {
            //string connectionString;
            ConnectionString con = new ConnectionString();
            connectionString = con.Connection();
            Get.Green("InitializeComponent Reporte_de_Empleados");
            Get.Yellow("Not Completed Yet ");
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
int wparam, int lparam);

        private void Form7_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
