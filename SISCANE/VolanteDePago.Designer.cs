namespace ManSys
{
	partial class VolanteDePago
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolanteDePago));
			this.PrintDialogo = new System.Windows.Forms.PrintPreviewDialog();
			this.Recibo = new System.Drawing.Printing.PrintDocument();
			this.ImprimirRecibo = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Cerrar = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ImprimirTodos = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PrintDialogo
			// 
			this.PrintDialogo.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.PrintDialogo.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.PrintDialogo.ClientSize = new System.Drawing.Size(400, 300);
			this.PrintDialogo.Document = this.Recibo;
			this.PrintDialogo.Enabled = true;
			this.PrintDialogo.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintDialogo.Icon")));
			this.PrintDialogo.Name = "PrintDialogo";
			this.PrintDialogo.Visible = false;
			// 
			// Recibo
			// 
			this.Recibo.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Recibo_PrintPage);
			// 
			// ImprimirRecibo
			// 
			this.ImprimirRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ImprimirRecibo.Location = new System.Drawing.Point(828, 112);
			this.ImprimirRecibo.Name = "ImprimirRecibo";
			this.ImprimirRecibo.Size = new System.Drawing.Size(167, 42);
			this.ImprimirRecibo.TabIndex = 0;
			this.ImprimirRecibo.Text = "Imprimir";
			this.ImprimirRecibo.UseVisualStyleBackColor = true;
			this.ImprimirRecibo.Click += new System.EventHandler(this.ImprimirRecibo_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(97, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 26);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Id";
			// 
			// Cerrar
			// 
			this.Cerrar.BackColor = System.Drawing.Color.IndianRed;
			this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cerrar.Location = new System.Drawing.Point(828, 208);
			this.Cerrar.Name = "Cerrar";
			this.Cerrar.Size = new System.Drawing.Size(175, 49);
			this.Cerrar.TabIndex = 3;
			this.Cerrar.Text = "Cerrar";
			this.Cerrar.UseVisualStyleBackColor = false;
			this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(828, 59);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 26);
			this.textBox2.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(860, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Id";
			// 
			// ImprimirTodos
			// 
			this.ImprimirTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ImprimirTodos.Location = new System.Drawing.Point(828, 160);
			this.ImprimirTodos.Name = "ImprimirTodos";
			this.ImprimirTodos.Size = new System.Drawing.Size(167, 42);
			this.ImprimirTodos.TabIndex = 7;
			this.ImprimirTodos.Text = "Imprimir";
			this.ImprimirTodos.UseVisualStyleBackColor = true;
			this.ImprimirTodos.Click += new System.EventHandler(this.ImprimirTodos_Click);
			// 
			// VolanteDePago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1080, 720);
			this.Controls.Add(this.ImprimirTodos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.Cerrar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.ImprimirRecibo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "VolanteDePago";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Volante De Pago";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PrintPreviewDialog PrintDialogo;
		private System.Drawing.Printing.PrintDocument Recibo;
		private System.Windows.Forms.Button ImprimirRecibo;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Cerrar;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button ImprimirTodos;
	}
}