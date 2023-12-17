using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManSys
{
	public partial class VolanteDePago : Form
	{
		public VolanteDePago()
		{
			InitializeComponent();
		}
		Bitmap bmp; 
		private void ImprimirRecibo_Click(object sender, EventArgs e)
		{
			Graphics g = this.CreateGraphics();

			bmp = new Bitmap(this.Width, this.Height, g);
			Graphics mg = Graphics.FromImage(bmp);
			mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
			this.PrintDialogo.ShowDialog();
		}

		private void Recibo_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(bmp, 0, 0);
		}

		private void Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void ImprimirMultiples()
		{
			Graphics g = this.CreateGraphics();

			bmp = new Bitmap(this.Width, this.Height, g);
			Graphics mg = Graphics.FromImage(bmp);
			mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
			PrintDocument document = new PrintDocument();
			
			
			
		}
		private void ImprimirTodos_Click(object sender, EventArgs e)
		{
			this.ImprimirMultiples();
		}
	}
}
