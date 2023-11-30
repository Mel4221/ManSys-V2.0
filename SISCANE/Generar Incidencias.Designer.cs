namespace ManSys
{
    partial class Incidencias
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
			this.NuevaIncidencia = new System.Windows.Forms.Button();
			this.bntlimpiar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnbusqueda = new System.Windows.Forms.Button();
			this.txtbusqueda = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Fecha_de_Salida = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtid = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.IncidenciasGrid = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmpleadoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre_de_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTipoDeIncidencia = new System.Windows.Forms.ComboBox();
			this.Fecha_de_Entrada = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtEmpleado = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtObservacion = new System.Windows.Forms.RichTextBox();
			this.txtDepartamento = new System.Windows.Forms.TextBox();
			this.txtPosicion = new System.Windows.Forms.TextBox();
			this.txtEmpleadoIdLabel = new System.Windows.Forms.Label();
			this.txtEmpleadoId = new System.Windows.Forms.TextBox();
			this.BtnRefrescar = new System.Windows.Forms.Button();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IncidenciasGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.NuevaIncidencia);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.bntlimpiar);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCerrar);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.btnModificar);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.btnEliminar);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.btnRegistrar);
			this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1095, 98);
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(18, 360);
			this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(1095, 98);
			this.toolStripContainer1.TabIndex = 187;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.toolStripContainer1.TopToolStripPanelVisible = false;
			// 
			// NuevaIncidencia
			// 
			this.NuevaIncidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NuevaIncidencia.Location = new System.Drawing.Point(177, 19);
			this.NuevaIncidencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NuevaIncidencia.Name = "NuevaIncidencia";
			this.NuevaIncidencia.Size = new System.Drawing.Size(136, 45);
			this.NuevaIncidencia.TabIndex = 111;
			this.NuevaIncidencia.Text = "Nuevo";
			this.NuevaIncidencia.UseVisualStyleBackColor = true;
			this.NuevaIncidencia.Click += new System.EventHandler(this.NuevaIncidencia_Click);
			// 
			// bntlimpiar
			// 
			this.bntlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntlimpiar.ForeColor = System.Drawing.Color.Black;
			this.bntlimpiar.Location = new System.Drawing.Point(660, 19);
			this.bntlimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.bntlimpiar.Name = "bntlimpiar";
			this.bntlimpiar.Size = new System.Drawing.Size(136, 45);
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
			this.btnCerrar.Location = new System.Drawing.Point(822, 19);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(255, 45);
			this.btnCerrar.TabIndex = 106;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(340, 19);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(136, 45);
			this.btnModificar.TabIndex = 32;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(501, 19);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(136, 45);
			this.btnEliminar.TabIndex = 33;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(18, 19);
			this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(136, 45);
			this.btnRegistrar.TabIndex = 31;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// btnbusqueda
			// 
			this.btnbusqueda.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnbusqueda.Location = new System.Drawing.Point(382, 320);
			this.btnbusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnbusqueda.Name = "btnbusqueda";
			this.btnbusqueda.Size = new System.Drawing.Size(112, 35);
			this.btnbusqueda.TabIndex = 186;
			this.btnbusqueda.Text = "Buscar";
			this.btnbusqueda.UseVisualStyleBackColor = true;
			this.btnbusqueda.Click += new System.EventHandler(this.btnbusqueda_Click);
			// 
			// txtbusqueda
			// 
			this.txtbusqueda.Location = new System.Drawing.Point(16, 323);
			this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtbusqueda.Name = "txtbusqueda";
			this.txtbusqueda.Size = new System.Drawing.Size(355, 26);
			this.txtbusqueda.TabIndex = 185;
			this.txtbusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbusqueda_KeyDown);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 286);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(384, 29);
			this.label5.TabIndex = 184;
			this.label5.Text = "Codigo o Nombre de Empleado";
			// 
			// Fecha_de_Salida
			// 
			this.Fecha_de_Salida.Location = new System.Drawing.Point(492, 46);
			this.Fecha_de_Salida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Fecha_de_Salida.Name = "Fecha_de_Salida";
			this.Fecha_de_Salida.Size = new System.Drawing.Size(298, 26);
			this.Fecha_de_Salida.TabIndex = 181;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(530, 14);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(203, 29);
			this.label2.TabIndex = 180;
			this.label2.Text = "Fecha de Salida";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(54, 112);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 29);
			this.label1.TabIndex = 177;
			this.label1.Text = "Codigo";
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(156, 114);
			this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(116, 26);
			this.txtid.TabIndex = 176;
			this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
			this.txtid.Leave += new System.EventHandler(this.txtid_Leave);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.label14.Location = new System.Drawing.Point(44, 14);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(287, 46);
			this.label14.TabIndex = 175;
			this.label14.Text = "INCIDENCIAS";
			// 
			// IncidenciasGrid
			// 
			this.IncidenciasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.IncidenciasGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Duracion,
            this.Observacion,
            this.EmpleadoID,
            this.Nombre_de_Empleado,
            this.Posicion,
            this.Departamento});
			this.IncidenciasGrid.Location = new System.Drawing.Point(36, 468);
			this.IncidenciasGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.IncidenciasGrid.Name = "IncidenciasGrid";
			this.IncidenciasGrid.RowHeadersWidth = 62;
			this.IncidenciasGrid.Size = new System.Drawing.Size(1627, 335);
			this.IncidenciasGrid.TabIndex = 188;
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.MinimumWidth = 8;
			this.Id.Name = "Id";
			this.Id.Width = 50;
			// 
			// Nombre
			// 
			this.Nombre.DataPropertyName = "Nombre";
			this.Nombre.HeaderText = "Tipo";
			this.Nombre.MinimumWidth = 8;
			this.Nombre.Name = "Nombre";
			this.Nombre.Width = 150;
			// 
			// Duracion
			// 
			this.Duracion.DataPropertyName = "Duracion";
			this.Duracion.HeaderText = "Dias";
			this.Duracion.MinimumWidth = 8;
			this.Duracion.Name = "Duracion";
			this.Duracion.Width = 150;
			// 
			// Observacion
			// 
			this.Observacion.DataPropertyName = "Observacion";
			this.Observacion.HeaderText = "Observacion";
			this.Observacion.MinimumWidth = 8;
			this.Observacion.Name = "Observacion";
			this.Observacion.Width = 150;
			// 
			// EmpleadoID
			// 
			this.EmpleadoID.DataPropertyName = "EmpleadoID";
			this.EmpleadoID.HeaderText = "EmpleadoID";
			this.EmpleadoID.MinimumWidth = 8;
			this.EmpleadoID.Name = "EmpleadoID";
			this.EmpleadoID.Width = 150;
			// 
			// Nombre_de_Empleado
			// 
			this.Nombre_de_Empleado.DataPropertyName = "Nombre_de_Empleado";
			this.Nombre_de_Empleado.HeaderText = "Empleado";
			this.Nombre_de_Empleado.MinimumWidth = 8;
			this.Nombre_de_Empleado.Name = "Nombre_de_Empleado";
			this.Nombre_de_Empleado.Width = 150;
			// 
			// Posicion
			// 
			this.Posicion.DataPropertyName = "Posicion";
			this.Posicion.HeaderText = "Posicion";
			this.Posicion.MinimumWidth = 8;
			this.Posicion.Name = "Posicion";
			this.Posicion.Width = 150;
			// 
			// Departamento
			// 
			this.Departamento.DataPropertyName = "Departamento";
			this.Departamento.HeaderText = "Departamento";
			this.Departamento.MinimumWidth = 8;
			this.Departamento.Name = "Departamento";
			this.Departamento.Width = 150;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(48, 159);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(230, 29);
			this.label3.TabIndex = 182;
			this.label3.Text = "Tipo de Incidencia";
			// 
			// txtTipoDeIncidencia
			// 
			this.txtTipoDeIncidencia.FormattingEnabled = true;
			this.txtTipoDeIncidencia.Items.AddRange(new object[] {
            "Retardos y Faltas",
            "Despido",
            "Permisos",
            "Vacaciones",
            "Enfermedades laborales",
            "Accidentes"});
			this.txtTipoDeIncidencia.Location = new System.Drawing.Point(52, 194);
			this.txtTipoDeIncidencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTipoDeIncidencia.Name = "txtTipoDeIncidencia";
			this.txtTipoDeIncidencia.Size = new System.Drawing.Size(220, 28);
			this.txtTipoDeIncidencia.TabIndex = 189;
			this.txtTipoDeIncidencia.Text = "Retardos y Faltas";
			// 
			// Fecha_de_Entrada
			// 
			this.Fecha_de_Entrada.Location = new System.Drawing.Point(814, 46);
			this.Fecha_de_Entrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Fecha_de_Entrada.Name = "Fecha_de_Entrada";
			this.Fecha_de_Entrada.Size = new System.Drawing.Size(298, 26);
			this.Fecha_de_Entrada.TabIndex = 191;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(852, 14);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(219, 29);
			this.label4.TabIndex = 190;
			this.label4.Text = "Fecha de Entrada";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(1330, 66);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(167, 29);
			this.label6.TabIndex = 193;
			this.label6.Text = "Observación ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(327, 153);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(277, 29);
			this.label7.TabIndex = 195;
			this.label7.Text = "Nombre del Empleado";
			// 
			// txtEmpleado
			// 
			this.txtEmpleado.Location = new System.Drawing.Point(612, 157);
			this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtEmpleado.Name = "txtEmpleado";
			this.txtEmpleado.ReadOnly = true;
			this.txtEmpleado.Size = new System.Drawing.Size(375, 26);
			this.txtEmpleado.TabIndex = 194;
			this.txtEmpleado.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(327, 193);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 29);
			this.label8.TabIndex = 197;
			this.label8.Text = "Posición";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(327, 233);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(177, 29);
			this.label9.TabIndex = 199;
			this.label9.Text = "Departamento";
			// 
			// txtObservacion
			// 
			this.txtObservacion.Location = new System.Drawing.Point(1145, 109);
			this.txtObservacion.Name = "txtObservacion";
			this.txtObservacion.Size = new System.Drawing.Size(518, 349);
			this.txtObservacion.TabIndex = 202;
			this.txtObservacion.Text = "";
			// 
			// txtDepartamento
			// 
			this.txtDepartamento.Location = new System.Drawing.Point(612, 241);
			this.txtDepartamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDepartamento.Name = "txtDepartamento";
			this.txtDepartamento.ReadOnly = true;
			this.txtDepartamento.Size = new System.Drawing.Size(375, 26);
			this.txtDepartamento.TabIndex = 203;
			// 
			// txtPosicion
			// 
			this.txtPosicion.Location = new System.Drawing.Point(612, 200);
			this.txtPosicion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtPosicion.Name = "txtPosicion";
			this.txtPosicion.ReadOnly = true;
			this.txtPosicion.Size = new System.Drawing.Size(375, 26);
			this.txtPosicion.TabIndex = 204;
			// 
			// txtEmpleadoIdLabel
			// 
			this.txtEmpleadoIdLabel.AutoSize = true;
			this.txtEmpleadoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpleadoIdLabel.Location = new System.Drawing.Point(327, 114);
			this.txtEmpleadoIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.txtEmpleadoIdLabel.Name = "txtEmpleadoIdLabel";
			this.txtEmpleadoIdLabel.Size = new System.Drawing.Size(215, 29);
			this.txtEmpleadoIdLabel.TabIndex = 205;
			this.txtEmpleadoIdLabel.Text = "ID de Empleado: ";
			// 
			// txtEmpleadoId
			// 
			this.txtEmpleadoId.Location = new System.Drawing.Point(612, 116);
			this.txtEmpleadoId.Name = "txtEmpleadoId";
			this.txtEmpleadoId.ReadOnly = true;
			this.txtEmpleadoId.Size = new System.Drawing.Size(375, 26);
			this.txtEmpleadoId.TabIndex = 206;
			// 
			// BtnRefrescar
			// 
			this.BtnRefrescar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.BtnRefrescar.Location = new System.Drawing.Point(502, 320);
			this.BtnRefrescar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnRefrescar.Name = "BtnRefrescar";
			this.BtnRefrescar.Size = new System.Drawing.Size(112, 35);
			this.BtnRefrescar.TabIndex = 207;
			this.BtnRefrescar.Text = "Refrescar";
			this.BtnRefrescar.UseVisualStyleBackColor = true;
			this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
			// 
			// Incidencias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1689, 927);
			this.Controls.Add(this.BtnRefrescar);
			this.Controls.Add(this.txtEmpleadoId);
			this.Controls.Add(this.txtEmpleadoIdLabel);
			this.Controls.Add(this.txtPosicion);
			this.Controls.Add(this.txtDepartamento);
			this.Controls.Add(this.txtObservacion);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtEmpleado);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Fecha_de_Entrada);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTipoDeIncidencia);
			this.Controls.Add(this.IncidenciasGrid);
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.btnbusqueda);
			this.Controls.Add(this.txtbusqueda);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Fecha_de_Salida);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.label14);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Incidencias";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Generar Incidencias";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Incidencias_Load);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.IncidenciasGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button bntlimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnbusqueda;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Fecha_de_Salida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView IncidenciasGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtTipoDeIncidencia;
        private System.Windows.Forms.DateTimePicker Fecha_de_Entrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RichTextBox txtObservacion;
		private System.Windows.Forms.TextBox txtDepartamento;
		private System.Windows.Forms.TextBox txtPosicion;
		private System.Windows.Forms.Label txtEmpleadoIdLabel;
		private System.Windows.Forms.TextBox txtEmpleadoId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_de_Empleado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
		private System.Windows.Forms.Button NuevaIncidencia;
		private System.Windows.Forms.Button BtnRefrescar;
	}
}