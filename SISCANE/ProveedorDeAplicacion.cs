using QuickTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCANE
{
    public partial class ProveedorDeAplicacion : Form
    {
        string connectionString;
        public ProveedorDeAplicacion()
        {
            //string connectionString;
            ConnectionString con = new ConnectionString();
            connectionString = con.Connection();
            Get.Green("InitializeComponent Proveedor_De_Applicacion");
            Get.Yellow("Not Completed Yet ");
            InitializeComponent();
        }

        private void ProveedorDeAplicacion_Load(object sender, EventArgs e)
        {
         

        }

        private void RestoreDefaultBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Al Restaurar los valores por defecto la aplicacion se reiniciara ",
                      "Informacion", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Application.Restart();
                    break;
            }
        }

        private void ActualizarProveedor_Click(object sender, EventArgs e)
        {

        }
    }
}
