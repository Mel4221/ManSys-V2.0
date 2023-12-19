namespace ManSys
{
	partial class Generar_Volante_de_Pago
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
			this.btnImprimir = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.label22 = new System.Windows.Forms.Label();
			this.Fecha_de_Pago = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.EmpleadoId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.Tipo_de_Cobro = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Salario_Base = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Nombre = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Departramento = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Puesto_Ocupado = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.Apellido = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnImprimir
			// 
			this.btnImprimir.Location = new System.Drawing.Point(1226, 107);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(202, 43);
			this.btnImprimir.TabIndex = 0;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.Red;
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.ForeColor = System.Drawing.Color.Black;
			this.btnCerrar.Location = new System.Drawing.Point(1226, 279);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(202, 40);
			this.btnCerrar.TabIndex = 107;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
			this.label22.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label22.Location = new System.Drawing.Point(567, 37);
			this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(500, 35);
			this.label22.TabIndex = 264;
			this.label22.Text = "GENERAR RECIBO DE NOMINA";
			// 
			// Fecha_de_Pago
			// 
			this.Fecha_de_Pago.FormattingEnabled = true;
			this.Fecha_de_Pago.Location = new System.Drawing.Point(748, 372);
			this.Fecha_de_Pago.Name = "Fecha_de_Pago";
			this.Fecha_de_Pago.Size = new System.Drawing.Size(234, 28);
			this.Fecha_de_Pago.TabIndex = 265;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(573, 372);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 20);
			this.label1.TabIndex = 266;
			this.label1.Text = "Periodo de Nomina";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1226, 170);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(202, 43);
			this.button1.TabIndex = 267;
			this.button1.Text = "Imprimir Todos";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ImprimirTodasLasNominas_Click);
			// 
			// EmpleadoId
			// 
			this.EmpleadoId.Location = new System.Drawing.Point(743, 102);
			this.EmpleadoId.Name = "EmpleadoId";
			this.EmpleadoId.Size = new System.Drawing.Size(234, 26);
			this.EmpleadoId.TabIndex = 268;
			this.EmpleadoId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmpleadoId_KeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(568, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 20);
			this.label2.TabIndex = 269;
			this.label2.Text = "Empleado ID";
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(1226, 228);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(202, 43);
			this.btnLimpiar.TabIndex = 270;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(573, 328);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 20);
			this.label4.TabIndex = 274;
			this.label4.Text = "Tipo de Cobro";
			// 
			// Tipo_de_Cobro
			// 
			this.Tipo_de_Cobro.Location = new System.Drawing.Point(747, 325);
			this.Tipo_de_Cobro.Name = "Tipo_de_Cobro";
			this.Tipo_de_Cobro.Size = new System.Drawing.Size(234, 26);
			this.Tipo_de_Cobro.TabIndex = 273;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(571, 291);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 20);
			this.label5.TabIndex = 276;
			this.label5.Text = "Salario Base";
			// 
			// Salario_Base
			// 
			this.Salario_Base.Location = new System.Drawing.Point(745, 285);
			this.Salario_Base.Name = "Salario_Base";
			this.Salario_Base.Size = new System.Drawing.Size(234, 26);
			this.Salario_Base.TabIndex = 275;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(569, 142);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 20);
			this.label6.TabIndex = 278;
			this.label6.Text = "Nombre";
			// 
			// Nombre
			// 
			this.Nombre.Location = new System.Drawing.Point(743, 142);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(234, 26);
			this.Nombre.TabIndex = 277;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(569, 251);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 20);
			this.label7.TabIndex = 280;
			this.label7.Text = "Departamento";
			// 
			// Departramento
			// 
			this.Departramento.Location = new System.Drawing.Point(743, 248);
			this.Departramento.Name = "Departramento";
			this.Departramento.Size = new System.Drawing.Size(234, 26);
			this.Departramento.TabIndex = 279;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(568, 211);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(128, 20);
			this.label8.TabIndex = 282;
			this.label8.Text = "Puesto Ocupado";
			// 
			// Puesto_Ocupado
			// 
			this.Puesto_Ocupado.Location = new System.Drawing.Point(742, 211);
			this.Puesto_Ocupado.Name = "Puesto_Ocupado";
			this.Puesto_Ocupado.Size = new System.Drawing.Size(234, 26);
			this.Puesto_Ocupado.TabIndex = 281;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(568, 178);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 20);
			this.label9.TabIndex = 284;
			this.label9.Text = "Apellido";
			// 
			// Apellido
			// 
			this.Apellido.Location = new System.Drawing.Point(743, 178);
			this.Apellido.Name = "Apellido";
			this.Apellido.Size = new System.Drawing.Size(234, 26);
			this.Apellido.TabIndex = 283;
			// 
			// Generar_Volante_de_Pago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(1450, 727);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.Apellido);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Puesto_Ocupado);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Departramento);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Nombre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Salario_Base);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Tipo_de_Cobro);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.EmpleadoId);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Fecha_de_Pago);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnImprimir);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Generar_Volante_de_Pago";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Generar Recibo de Pago";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Generar_Volante_de_Pago_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.ComboBox Fecha_de_Pago;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox EmpleadoId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Tipo_de_Cobro;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Salario_Base;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Nombre;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Departramento;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox Puesto_Ocupado;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox Apellido;
	}
}