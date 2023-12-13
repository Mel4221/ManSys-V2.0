namespace ManSys
{
    partial class GenerarNomina
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarNomina));
			this.label22 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CierreDeNomina = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.InicioDeNomina = new System.Windows.Forms.DateTimePicker();
			this.ListadodeNominaRegistrada = new System.Windows.Forms.DataGridView();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.bntlimpiar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.RegistroAutomatico = new System.Windows.Forms.CheckBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.DiasTrabajadosBox = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.PeridoDeNomina = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ListadodeNominaRegistrada)).BeginInit();
			this.SuspendLayout();
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
			this.label22.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label22.Location = new System.Drawing.Point(18, 20);
			this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(478, 35);
			this.label22.TabIndex = 187;
			this.label22.Text = "GENERAR NOMINA SALARIAL\r\n";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(1200, 31);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(220, 29);
			this.label3.TabIndex = 269;
			this.label3.Text = "Cierre de Nomina";
			// 
			// CierreDeNomina
			// 
			this.CierreDeNomina.Location = new System.Drawing.Point(1156, 63);
			this.CierreDeNomina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CierreDeNomina.Name = "CierreDeNomina";
			this.CierreDeNomina.Size = new System.Drawing.Size(298, 26);
			this.CierreDeNomina.TabIndex = 268;
			this.CierreDeNomina.ValueChanged += new System.EventHandler(this.CierreDeNomina_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(840, 31);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(210, 29);
			this.label4.TabIndex = 267;
			this.label4.Text = "Inicio de Nomina";
			// 
			// InicioDeNomina
			// 
			this.InicioDeNomina.Location = new System.Drawing.Point(808, 63);
			this.InicioDeNomina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.InicioDeNomina.Name = "InicioDeNomina";
			this.InicioDeNomina.Size = new System.Drawing.Size(298, 26);
			this.InicioDeNomina.TabIndex = 266;
			this.InicioDeNomina.Value = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
			this.InicioDeNomina.ValueChanged += new System.EventHandler(this.InicioDeNomina_ValueChanged);
			// 
			// ListadodeNominaRegistrada
			// 
			this.ListadodeNominaRegistrada.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.ListadodeNominaRegistrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ListadodeNominaRegistrada.Location = new System.Drawing.Point(34, 649);
			this.ListadodeNominaRegistrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ListadodeNominaRegistrada.Name = "ListadodeNominaRegistrada";
			this.ListadodeNominaRegistrada.ReadOnly = true;
			this.ListadodeNominaRegistrada.RowHeadersWidth = 62;
			this.ListadodeNominaRegistrada.Size = new System.Drawing.Size(1420, 397);
			this.ListadodeNominaRegistrada.TabIndex = 270;
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.Red;
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.ForeColor = System.Drawing.Color.Black;
			this.btnCerrar.Location = new System.Drawing.Point(1299, 459);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(160, 74);
			this.btnCerrar.TabIndex = 274;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// bntlimpiar
			// 
			this.bntlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntlimpiar.ForeColor = System.Drawing.Color.Black;
			this.bntlimpiar.Location = new System.Drawing.Point(1299, 386);
			this.bntlimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.bntlimpiar.Name = "bntlimpiar";
			this.bntlimpiar.Size = new System.Drawing.Size(160, 52);
			this.bntlimpiar.TabIndex = 277;
			this.bntlimpiar.Text = "Limpiar";
			this.bntlimpiar.UseVisualStyleBackColor = true;
			this.bntlimpiar.Click += new System.EventHandler(this.bntlimpiar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(1300, 157);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 31);
			this.label1.TabIndex = 275;
			this.label1.Text = "BOTONES";
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(1299, 210);
			this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(160, 49);
			this.btnRegistrar.TabIndex = 271;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(1299, 268);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(160, 49);
			this.btnModificar.TabIndex = 272;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(1299, 327);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(160, 49);
			this.btnEliminar.TabIndex = 273;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// RegistroAutomatico
			// 
			this.RegistroAutomatico.AutoSize = true;
			this.RegistroAutomatico.Checked = true;
			this.RegistroAutomatico.CheckState = System.Windows.Forms.CheckState.Checked;
			this.RegistroAutomatico.Location = new System.Drawing.Point(870, 170);
			this.RegistroAutomatico.Name = "RegistroAutomatico";
			this.RegistroAutomatico.Size = new System.Drawing.Size(116, 24);
			this.RegistroAutomatico.TabIndex = 346;
			this.RegistroAutomatico.Text = "Automatico";
			this.RegistroAutomatico.UseVisualStyleBackColor = true;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(615, 318);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(213, 26);
			this.textBox7.TabIndex = 345;
			this.textBox7.Text = "425";
			this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(445, 315);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(144, 26);
			this.textBox2.TabIndex = 344;
			this.textBox2.Text = "315";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(34, 316);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(393, 29);
			this.label9.TabIndex = 343;
			this.label9.Text = "Precio Hora Posicion Supervisor";
			// 
			// DiasTrabajadosBox
			// 
			this.DiasTrabajadosBox.Location = new System.Drawing.Point(445, 228);
			this.DiasTrabajadosBox.Name = "DiasTrabajadosBox";
			this.DiasTrabajadosBox.Size = new System.Drawing.Size(144, 26);
			this.DiasTrabajadosBox.TabIndex = 342;
			this.DiasTrabajadosBox.Text = "15%";
			this.DiasTrabajadosBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(615, 417);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(213, 26);
			this.textBox8.TabIndex = 341;
			this.textBox8.Text = "560";
			this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(614, 365);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(213, 26);
			this.textBox6.TabIndex = 340;
			this.textBox6.Text = "452";
			this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(615, 276);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(213, 26);
			this.textBox5.TabIndex = 339;
			this.textBox5.Text = "285";
			this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(445, 276);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(144, 26);
			this.textBox4.TabIndex = 338;
			this.textBox4.Text = "210";
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(444, 365);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(144, 26);
			this.textBox3.TabIndex = 337;
			this.textBox3.Text = "335";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(445, 417);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 26);
			this.textBox1.TabIndex = 336;
			this.textBox1.Text = "415";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// PeridoDeNomina
			// 
			this.PeridoDeNomina.Location = new System.Drawing.Point(445, 168);
			this.PeridoDeNomina.Name = "PeridoDeNomina";
			this.PeridoDeNomina.ReadOnly = true;
			this.PeridoDeNomina.Size = new System.Drawing.Size(383, 26);
			this.PeridoDeNomina.TabIndex = 335;
			this.PeridoDeNomina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(34, 178);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(106, 29);
			this.label7.TabIndex = 334;
			this.label7.Text = "Periodo";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(33, 229);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(205, 29);
			this.label5.TabIndex = 333;
			this.label5.Text = "Dias Trabajados";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(445, 468);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(144, 26);
			this.textBox9.TabIndex = 332;
			this.textBox9.Text = "15%";
			this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 468);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(324, 29);
			this.label2.TabIndex = 331;
			this.label2.Text = "Incentivo Horario Nocturno";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(33, 417);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(369, 29);
			this.label10.TabIndex = 330;
			this.label10.Text = "Precio Hora Posicion Manager";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(33, 365);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(357, 29);
			this.label8.TabIndex = 329;
			this.label8.Text = "Precio Hora Posicion Calidad";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(610, 229);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(218, 29);
			this.label6.TabIndex = 328;
			this.label6.Text = "Precio Hora Extra";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(33, 276);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(349, 29);
			this.label14.TabIndex = 327;
			this.label14.Text = "Precio Hora Posicion Agente";
			// 
			// GenerarNomina
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1899, 1060);
			this.Controls.Add(this.RegistroAutomatico);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.DiasTrabajadosBox);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.PeridoDeNomina);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.bntlimpiar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.ListadodeNominaRegistrada);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CierreDeNomina);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.InicioDeNomina);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "GenerarNomina";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "rec";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.GenerarNomina_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GenerarNomina_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.ListadodeNominaRegistrada)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker CierreDeNomina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker InicioDeNomina;
		private System.Windows.Forms.DataGridView ListadodeNominaRegistrada;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button bntlimpiar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.CheckBox RegistroAutomatico;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox DiasTrabajadosBox;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox PeridoDeNomina;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label14;
	}
}