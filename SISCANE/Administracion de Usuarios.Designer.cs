namespace ManSys
{
    partial class Empleado
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
			this.label1 = new System.Windows.Forms.Label();
			this.txtid = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEmpleado = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtcontra = new System.Windows.Forms.TextBox();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.bntlimpiar = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.gblistadovisitas = new System.Windows.Forms.GroupBox();
			this.btnRefrescar = new System.Windows.Forms.Button();
			this.ListadodeUsuarios = new System.Windows.Forms.DataGridView();
			this.EmpleadoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmpleadoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Contra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.txtbusqueda = new System.Windows.Forms.TextBox();
			this.MostrarConstra = new System.Windows.Forms.CheckBox();
			this.txtcontra2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.gblistadovisitas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ListadodeUsuarios)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(381, 198);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 29);
			this.label1.TabIndex = 35;
			this.label1.Text = "ID";
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(618, 198);
			this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(116, 26);
			this.txtid.TabIndex = 34;
			this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
			this.txtid.Leave += new System.EventHandler(this.txtid_Leave);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(783, 194);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(132, 29);
			this.label5.TabIndex = 62;
			this.label5.Text = "Empleado";
			// 
			// txtEmpleado
			// 
			this.txtEmpleado.Location = new System.Drawing.Point(939, 198);
			this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtEmpleado.Name = "txtEmpleado";
			this.txtEmpleado.ReadOnly = true;
			this.txtEmpleado.Size = new System.Drawing.Size(296, 26);
			this.txtEmpleado.TabIndex = 63;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(378, 244);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(146, 29);
			this.label6.TabIndex = 64;
			this.label6.Text = "Contraseña";
			// 
			// txtcontra
			// 
			this.txtcontra.Location = new System.Drawing.Point(619, 246);
			this.txtcontra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtcontra.Name = "txtcontra";
			this.txtcontra.Size = new System.Drawing.Size(296, 26);
			this.txtcontra.TabIndex = 65;
			this.txtcontra.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged);
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.bntlimpiar);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.label13);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCerrar);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.btnModificar);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.btnEliminar);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.btnRegistrar);
			this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(222, 346);
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(1261, 64);
			this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(222, 346);
			this.toolStripContainer1.TabIndex = 137;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.toolStripContainer1.TopToolStripPanelVisible = false;
			// 
			// bntlimpiar
			// 
			this.bntlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntlimpiar.ForeColor = System.Drawing.Color.Black;
			this.bntlimpiar.Location = new System.Drawing.Point(15, 182);
			this.bntlimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.bntlimpiar.Name = "bntlimpiar";
			this.bntlimpiar.Size = new System.Drawing.Size(202, 40);
			this.bntlimpiar.TabIndex = 110;
			this.bntlimpiar.Text = "Limpiar";
			this.bntlimpiar.UseVisualStyleBackColor = true;
			this.bntlimpiar.Click += new System.EventHandler(this.bntlimpiar_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(54, 290);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(140, 29);
			this.label13.TabIndex = 107;
			this.label13.Text = "BOTONES";
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.Red;
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.ForeColor = System.Drawing.Color.Black;
			this.btnCerrar.Location = new System.Drawing.Point(12, 226);
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
			this.btnModificar.Location = new System.Drawing.Point(12, 82);
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
			this.btnEliminar.Location = new System.Drawing.Point(12, 134);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(202, 45);
			this.btnEliminar.TabIndex = 33;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(12, 34);
			this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(202, 38);
			this.btnRegistrar.TabIndex = 31;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(698, 32);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(454, 40);
			this.label14.TabIndex = 139;
			this.label14.Text = "GESTIÓN DE USUARIOS";
			// 
			// gblistadovisitas
			// 
			this.gblistadovisitas.Controls.Add(this.btnRefrescar);
			this.gblistadovisitas.Controls.Add(this.ListadodeUsuarios);
			this.gblistadovisitas.Controls.Add(this.btnBuscar);
			this.gblistadovisitas.Controls.Add(this.label15);
			this.gblistadovisitas.Controls.Add(this.txtbusqueda);
			this.gblistadovisitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gblistadovisitas.ForeColor = System.Drawing.Color.DarkCyan;
			this.gblistadovisitas.Location = new System.Drawing.Point(383, 420);
			this.gblistadovisitas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gblistadovisitas.Name = "gblistadovisitas";
			this.gblistadovisitas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gblistadovisitas.Size = new System.Drawing.Size(885, 372);
			this.gblistadovisitas.TabIndex = 140;
			this.gblistadovisitas.TabStop = false;
			this.gblistadovisitas.Text = "Empleados Registrados";
			// 
			// btnRefrescar
			// 
			this.btnRefrescar.ForeColor = System.Drawing.Color.DodgerBlue;
			this.btnRefrescar.Location = new System.Drawing.Point(724, 69);
			this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnRefrescar.Name = "btnRefrescar";
			this.btnRefrescar.Size = new System.Drawing.Size(154, 35);
			this.btnRefrescar.TabIndex = 7;
			this.btnRefrescar.Text = "Refrescar";
			this.btnRefrescar.UseVisualStyleBackColor = true;
			this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
			// 
			// ListadodeUsuarios
			// 
			this.ListadodeUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.ListadodeUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ListadodeUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpleadoId,
            this.EmpleadoNombre,
            this.Contra});
			this.ListadodeUsuarios.Location = new System.Drawing.Point(10, 112);
			this.ListadodeUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ListadodeUsuarios.Name = "ListadodeUsuarios";
			this.ListadodeUsuarios.ReadOnly = true;
			this.ListadodeUsuarios.RowHeadersWidth = 62;
			this.ListadodeUsuarios.Size = new System.Drawing.Size(868, 252);
			this.ListadodeUsuarios.TabIndex = 8;
			this.ListadodeUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadodeUsuarios_CellContentClick);
			// 
			// EmpleadoId
			// 
			this.EmpleadoId.DataPropertyName = "EmpleadoId";
			this.EmpleadoId.HeaderText = "ID";
			this.EmpleadoId.MinimumWidth = 8;
			this.EmpleadoId.Name = "EmpleadoId";
			this.EmpleadoId.ReadOnly = true;
			this.EmpleadoId.Width = 150;
			// 
			// EmpleadoNombre
			// 
			this.EmpleadoNombre.DataPropertyName = "Empleado";
			this.EmpleadoNombre.HeaderText = "Empleado";
			this.EmpleadoNombre.MinimumWidth = 8;
			this.EmpleadoNombre.Name = "EmpleadoNombre";
			this.EmpleadoNombre.ReadOnly = true;
			this.EmpleadoNombre.Width = 300;
			// 
			// Contra
			// 
			this.Contra.DataPropertyName = "Contra";
			this.Contra.HeaderText = "Contraseña";
			this.Contra.MinimumWidth = 8;
			this.Contra.Name = "Contra";
			this.Contra.ReadOnly = true;
			this.Contra.Visible = false;
			this.Contra.Width = 150;
			// 
			// btnBuscar
			// 
			this.btnBuscar.ForeColor = System.Drawing.Color.DodgerBlue;
			this.btnBuscar.Location = new System.Drawing.Point(327, 69);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(112, 35);
			this.btnBuscar.TabIndex = 5;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(15, 34);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(215, 25);
			this.label15.TabIndex = 1;
			this.label15.Text = "Criterio de Búsqueda";
			// 
			// txtbusqueda
			// 
			this.txtbusqueda.Location = new System.Drawing.Point(15, 69);
			this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtbusqueda.Name = "txtbusqueda";
			this.txtbusqueda.Size = new System.Drawing.Size(301, 30);
			this.txtbusqueda.TabIndex = 0;
			this.txtbusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbusqueda_KeyDown);
			// 
			// MostrarConstra
			// 
			this.MostrarConstra.AutoSize = true;
			this.MostrarConstra.Location = new System.Drawing.Point(939, 288);
			this.MostrarConstra.Name = "MostrarConstra";
			this.MostrarConstra.Size = new System.Drawing.Size(176, 24);
			this.MostrarConstra.TabIndex = 141;
			this.MostrarConstra.Text = "Mostrar Contraseña";
			this.MostrarConstra.UseVisualStyleBackColor = true;
			this.MostrarConstra.CheckStateChanged += new System.EventHandler(this.MostrarConstra_CheckStateChanged);
			// 
			// txtcontra2
			// 
			this.txtcontra2.Location = new System.Drawing.Point(619, 290);
			this.txtcontra2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtcontra2.Name = "txtcontra2";
			this.txtcontra2.Size = new System.Drawing.Size(296, 26);
			this.txtcontra2.TabIndex = 143;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(378, 288);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(239, 29);
			this.label2.TabIndex = 142;
			this.label2.Text = "Repetir Contraseña";
			// 
			// Empleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1596, 818);
			this.Controls.Add(this.txtcontra2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.MostrarConstra);
			this.Controls.Add(this.gblistadovisitas);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.txtcontra);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtEmpleado);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Empleado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gestión de Usuario";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Gestión_de_Usuarios_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.gblistadovisitas.ResumeLayout(false);
			this.gblistadovisitas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ListadodeUsuarios)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gblistadovisitas;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridView ListadodeUsuarios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbusqueda;
		private System.Windows.Forms.Button bntlimpiar;
		private System.Windows.Forms.CheckBox MostrarConstra;
		private System.Windows.Forms.TextBox txtcontra2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoId;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Contra;
	}
}