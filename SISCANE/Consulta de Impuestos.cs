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
    public partial class Consulta_de_Impuestos : Form
    {
        public Consulta_de_Impuestos()
        {
            InitializeComponent();
        }
        
        

        private void Consulta_de_Impuestos_Load(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void Consulta_de_Impuestos_MouseDown(object sender, MouseEventArgs e)
        {
         
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
