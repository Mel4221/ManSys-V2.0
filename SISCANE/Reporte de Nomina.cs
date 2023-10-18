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

namespace ManSys
{
    public partial class ReporteDeNomina : Form
    {
        public ReporteDeNomina()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
int wparam, int lparam);

        private void ReporteDeNomina_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ManSysDataSet.Mantenimiento_de_Nomina' Puede moverla o quitarla según sea necesario.


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReporteDeNomina_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
