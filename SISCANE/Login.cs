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
using Domain;
using Common.Cache;

namespace SISCANE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO") {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text=="")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "USUARIO") {
                if (txtpass.Text != "CONTRASEÑA") {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                        Form1 MainMenu = new Form1();
                        MessageBox.Show("Bienvenido Sr/Sra " + UserLoginCache.Nombre + ", " + UserLoginCache.Apellido);
                        MainMenu.Show();
                        MainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Nombre de Usuario o Contraseña Incorrecto. \n Por Favor Intenta Otra Vez.");
                        txtpass.Text = "CONTRASEÑA";
                        txtuser.Focus();
                    }

                }
                else msgError("Por Favor Ingresa tu Contraseña");
            }
            else msgError("Por favor Ingresa tu Nombre de Usuario");
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "CONTRASEÑA";
            txtuser.Text = "USUARIO";
            lblErrorMessage.Visible = false;
            this.Show();
            //txtuser.Focus();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_MouseEnter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                
                txtpass.Text = "";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = true;


            }
        }

        private void txtpass_MouseLeave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;

            }
            else
            {

            }
        }
    }
}
