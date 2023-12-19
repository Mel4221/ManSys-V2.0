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
    public partial class ConsultadeNominaSalarial : Form
    {
        public ConsultadeNominaSalarial()
        {
            InitializeComponent();
        }
       
       

        private void generarnomina_Load(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadodeNominaRegistrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BuscarNominas()
        {
            
        }
		private void ConsultadeNominaSalarial_Load(object sender, EventArgs e)
		{
            this.BuscarNominas();
		}

		private void PeriodoDeNomina_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
