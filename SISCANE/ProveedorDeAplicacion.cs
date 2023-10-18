using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManSys
{
    public partial class ProveedorDeAplicacion : Form
    {
        public ProveedorDeAplicacion()
        {
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
