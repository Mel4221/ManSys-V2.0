namespace ManSys
{
	partial class Mantenimiento_de_Horario
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
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.Registrar_Jornada = new System.Windows.Forms.Button();
			this.bntlimpiar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.ListadodeEmpleados = new System.Windows.Forms.DataGridView();
			this.FechaDeJornada = new System.Windows.Forms.DateTimePicker();
			this.EmpleadoIdLabel = new System.Windows.Forms.Label();
			this.EmpleadoId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.HoraDeEntrada = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.HoraDeSalida = new System.Windows.Forms.DateTimePicker();
			this.btnRefrescar = new System.Windows.Forms.Button();
			this.BuscarJornadaLaboral = new System.Windows.Forms.DateTimePicker();
			this.NomreDeEmpleado = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.HorasTrabajadas = new System.Windows.Forms.TextBox();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ListadodeEmpleados)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.Registrar_Jornada);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.bntlimpiar);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCerrar);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.btnModificar);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.btnEliminar);
			this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(222, 324);
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(1270, 48);
			this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(222, 324);
			this.toolStripContainer1.TabIndex = 137;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.toolStripContainer1.TopToolStripPanelVisible = false;
			// 
			// Registrar_Jornada
			// 
			this.Registrar_Jornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Registrar_Jornada.Location = new System.Drawing.Point(16, 18);
			this.Registrar_Jornada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Registrar_Jornada.Name = "Registrar_Jornada";
			this.Registrar_Jornada.Size = new System.Drawing.Size(202, 43);
			this.Registrar_Jornada.TabIndex = 111;
			this.Registrar_Jornada.Text = "Registrar";
			this.Registrar_Jornada.UseVisualStyleBackColor = true;
			this.Registrar_Jornada.Click += new System.EventHandler(this.Registrar_Jornada_Click);
			// 
			// bntlimpiar
			// 
			this.bntlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntlimpiar.ForeColor = System.Drawing.Color.Black;
			this.bntlimpiar.Location = new System.Drawing.Point(16, 193);
			this.bntlimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.bntlimpiar.Name = "bntlimpiar";
			this.bntlimpiar.Size = new System.Drawing.Size(202, 40);
			this.bntlimpiar.TabIndex = 110;
			this.bntlimpiar.Text = "Limpiar";
			this.bntlimpiar.UseVisualStyleBackColor = true;
			this.bntlimpiar.Click += new System.EventHandler(this.bntlimpiar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.Red;
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.ForeColor = System.Drawing.Color.Black;
			this.btnCerrar.Location = new System.Drawing.Point(16, 243);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(202, 40);
			this.btnCerrar.TabIndex = 106;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(16, 76);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(202, 43);
			this.btnModificar.TabIndex = 32;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(16, 133);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(202, 45);
			this.btnEliminar.TabIndex = 33;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// ListadodeEmpleados
			// 
			this.ListadodeEmpleados.AllowUserToAddRows = false;
			this.ListadodeEmpleados.AllowUserToDeleteRows = false;
			this.ListadodeEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.ListadodeEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ListadodeEmpleados.Location = new System.Drawing.Point(91, 487);
			this.ListadodeEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ListadodeEmpleados.Name = "ListadodeEmpleados";
			this.ListadodeEmpleados.ReadOnly = true;
			this.ListadodeEmpleados.RowHeadersWidth = 62;
			this.ListadodeEmpleados.Size = new System.Drawing.Size(1432, 605);
			this.ListadodeEmpleados.TabIndex = 138;
			// 
			// FechaDeJornada
			// 
			this.FechaDeJornada.Location = new System.Drawing.Point(205, 132);
			this.FechaDeJornada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.FechaDeJornada.Name = "FechaDeJornada";
			this.FechaDeJornada.Size = new System.Drawing.Size(298, 26);
			this.FechaDeJornada.TabIndex = 143;
			this.FechaDeJornada.ValueChanged += new System.EventHandler(this.FechaDeJornada_ValueChanged);
			// 
			// EmpleadoIdLabel
			// 
			this.EmpleadoIdLabel.AutoSize = true;
			this.EmpleadoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EmpleadoIdLabel.Location = new System.Drawing.Point(86, 80);
			this.EmpleadoIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.EmpleadoIdLabel.Name = "EmpleadoIdLabel";
			this.EmpleadoIdLabel.Size = new System.Drawing.Size(38, 29);
			this.EmpleadoIdLabel.TabIndex = 144;
			this.EmpleadoIdLabel.Text = "ID";
			// 
			// EmpleadoId
			// 
			this.EmpleadoId.Location = new System.Drawing.Point(205, 84);
			this.EmpleadoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.EmpleadoId.Name = "EmpleadoId";
			this.EmpleadoId.Size = new System.Drawing.Size(296, 26);
			this.EmpleadoId.TabIndex = 145;
			this.EmpleadoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.EmpleadoId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmpleadoId_KeyDown);
			this.EmpleadoId.Leave += new System.EventHandler(this.EmpleadoId_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(86, 130);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 29);
			this.label1.TabIndex = 146;
			this.label1.Text = "Fecha";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
			this.label14.Location = new System.Drawing.Point(561, 19);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(664, 35);
			this.label14.TabIndex = 147;
			this.label14.Text = "MANTENIMIENTO DE JORNADA LABORAL";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(86, 186);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 29);
			this.label2.TabIndex = 148;
			this.label2.Text = "Entrada";
			// 
			// HoraDeEntrada
			// 
			this.HoraDeEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.HoraDeEntrada.Location = new System.Drawing.Point(205, 189);
			this.HoraDeEntrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.HoraDeEntrada.Name = "HoraDeEntrada";
			this.HoraDeEntrada.Size = new System.Drawing.Size(298, 26);
			this.HoraDeEntrada.TabIndex = 149;
			this.HoraDeEntrada.Value = new System.DateTime(2023, 12, 4, 9, 0, 0, 0);
			this.HoraDeEntrada.ValueChanged += new System.EventHandler(this.HoraDeEntrada_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(86, 236);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 29);
			this.label3.TabIndex = 150;
			this.label3.Text = "Salida";
			// 
			// HoraDeSalida
			// 
			this.HoraDeSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.HoraDeSalida.Location = new System.Drawing.Point(205, 239);
			this.HoraDeSalida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.HoraDeSalida.Name = "HoraDeSalida";
			this.HoraDeSalida.Size = new System.Drawing.Size(298, 26);
			this.HoraDeSalida.TabIndex = 151;
			this.HoraDeSalida.Value = new System.DateTime(2023, 12, 4, 17, 0, 0, 0);
			this.HoraDeSalida.ValueChanged += new System.EventHandler(this.HoraDeSalida_ValueChanged);
			// 
			// btnRefrescar
			// 
			this.btnRefrescar.ForeColor = System.Drawing.Color.DodgerBlue;
			this.btnRefrescar.Location = new System.Drawing.Point(1335, 442);
			this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnRefrescar.Name = "btnRefrescar";
			this.btnRefrescar.Size = new System.Drawing.Size(154, 35);
			this.btnRefrescar.TabIndex = 153;
			this.btnRefrescar.Text = "Refrescar";
			this.btnRefrescar.UseVisualStyleBackColor = true;
			this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
			// 
			// BuscarJornadaLaboral
			// 
			this.BuscarJornadaLaboral.Location = new System.Drawing.Point(1029, 451);
			this.BuscarJornadaLaboral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BuscarJornadaLaboral.Name = "BuscarJornadaLaboral";
			this.BuscarJornadaLaboral.Size = new System.Drawing.Size(298, 26);
			this.BuscarJornadaLaboral.TabIndex = 154;
			this.BuscarJornadaLaboral.ValueChanged += new System.EventHandler(this.BuscarJornadaLaboral_ValueChanged);
			// 
			// NomreDeEmpleado
			// 
			this.NomreDeEmpleado.Location = new System.Drawing.Point(693, 87);
			this.NomreDeEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NomreDeEmpleado.Name = "NomreDeEmpleado";
			this.NomreDeEmpleado.ReadOnly = true;
			this.NomreDeEmpleado.Size = new System.Drawing.Size(487, 26);
			this.NomreDeEmpleado.TabIndex = 156;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(553, 83);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 29);
			this.label4.TabIndex = 155;
			this.label4.Text = "Empleado";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(86, 291);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(325, 29);
			this.label5.TabIndex = 157;
			this.label5.Text = "Total de Horas Trabajadas";
			// 
			// HorasTrabajadas
			// 
			this.HorasTrabajadas.Location = new System.Drawing.Point(438, 291);
			this.HorasTrabajadas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.HorasTrabajadas.Name = "HorasTrabajadas";
			this.HorasTrabajadas.ReadOnly = true;
			this.HorasTrabajadas.Size = new System.Drawing.Size(65, 26);
			this.HorasTrabajadas.TabIndex = 158;
			this.HorasTrabajadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Mantenimiento_de_Horario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1543, 1106);
			this.Controls.Add(this.HorasTrabajadas);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.NomreDeEmpleado);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.BuscarJornadaLaboral);
			this.Controls.Add(this.btnRefrescar);
			this.Controls.Add(this.HoraDeSalida);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.HoraDeEntrada);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.EmpleadoId);
			this.Controls.Add(this.EmpleadoIdLabel);
			this.Controls.Add(this.FechaDeJornada);
			this.Controls.Add(this.ListadodeEmpleados);
			this.Controls.Add(this.toolStripContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Mantenimiento_de_Horario";
			this.Text = "Mantenimiento_de_Horario";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Mantenimiento_de_Horario_Load);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ListadodeEmpleados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.Button bntlimpiar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.DataGridView ListadodeEmpleados;
		private System.Windows.Forms.DateTimePicker FechaDeJornada;
		private System.Windows.Forms.Label EmpleadoIdLabel;
		private System.Windows.Forms.TextBox EmpleadoId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker HoraDeEntrada;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker HoraDeSalida;
		private System.Windows.Forms.Button btnRefrescar;
		private System.Windows.Forms.DateTimePicker BuscarJornadaLaboral;
		private System.Windows.Forms.TextBox NomreDeEmpleado;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Registrar_Jornada;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox HorasTrabajadas;
	}
}