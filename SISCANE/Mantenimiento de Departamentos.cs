﻿using System;
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
    }
}
