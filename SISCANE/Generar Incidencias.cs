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
    public partial class Incidencias : Form
    {
        string connectionString = ""; 
        public Incidencias()
        {
            //string connectionString = "";
            ConnectionString con = new ConnectionString();
            connectionString = con.Connection();
            Get.Green("InitializeComponent Generar Incidencias ");
            Get.Yellow("Not completed yet ");
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
        int wparam, int lparam);

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Incidencias_Load(object sender, EventArgs e)
        {

        }


        private void Incidencias_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
