namespace ManSys
{
    partial class MantenimientoDeEmpleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoDeEmpleados));
            this.label14 = new System.Windows.Forms.Label();
            this.gblistadovisitas = new System.Windows.Forms.GroupBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.ListadodeEmpleados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto_Ocupado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario_Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_de_Cobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosDataSet = new ManSys.EmpleadosDataSet();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.bntlimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsalariobase = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtfechadeingreso = new System.Windows.Forms.DateTimePicker();
            this.txttipodecobro = new System.Windows.Forms.ComboBox();
            this.txtdeparmento = new System.Windows.Forms.ComboBox();
            this.txtpuestoocupado = new System.Windows.Forms.ComboBox();
            this.txtturno = new System.Windows.Forms.ComboBox();
            this.empleadosTableAdapter = new ManSys.EmpleadosDataSetTableAdapters.EmpleadosTableAdapter();
            this.CriterioDeBusqueda = new System.Windows.Forms.ComboBox();
            this.gblistadovisitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadodeEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataSet)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(374, 14);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(450, 35);
            this.label14.TabIndex = 138;
            this.label14.Text = "REGISTRO DE EMPLEADOS";
            // 
            // gblistadovisitas
            // 
            this.gblistadovisitas.Controls.Add(this.CriterioDeBusqueda);
            this.gblistadovisitas.Controls.Add(this.btnGuardarCambios);
            this.gblistadovisitas.Controls.Add(this.btnRefrescar);
            this.gblistadovisitas.Controls.Add(this.ListadodeEmpleados);
            this.gblistadovisitas.Controls.Add(this.btnBuscar);
            this.gblistadovisitas.Controls.Add(this.label15);
            this.gblistadovisitas.Controls.Add(this.txtbusqueda);
            this.gblistadovisitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gblistadovisitas.ForeColor = System.Drawing.Color.DarkCyan;
            this.gblistadovisitas.Location = new System.Drawing.Point(35, 429);
            this.gblistadovisitas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gblistadovisitas.Name = "gblistadovisitas";
            this.gblistadovisitas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gblistadovisitas.Size = new System.Drawing.Size(1771, 512);
            this.gblistadovisitas.TabIndex = 137;
            this.gblistadovisitas.TabStop = false;
            this.gblistadovisitas.Text = "Empleados Registrados";
            this.gblistadovisitas.Enter += new System.EventHandler(this.gblistadovisitas_Enter);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarCambios.Location = new System.Drawing.Point(699, 69);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(154, 35);
            this.btnGuardarCambios.TabIndex = 9;
            this.btnGuardarCambios.Text = "Guardar";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRefrescar.Location = new System.Drawing.Point(497, 69);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(154, 35);
            this.btnRefrescar.TabIndex = 7;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // ListadodeEmpleados
            // 
            this.ListadodeEmpleados.AllowUserToAddRows = false;
            this.ListadodeEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ListadodeEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadodeEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.Telefono,
            this.Fecha_de_Ingreso,
            this.Puesto_Ocupado,
            this.Departamento,
            this.CEDULA,
            this.Salario_Base,
            this.Tipo_de_Cobro,
            this.Turno});
            this.ListadodeEmpleados.Location = new System.Drawing.Point(10, 112);
            this.ListadodeEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListadodeEmpleados.Name = "ListadodeEmpleados";
            this.ListadodeEmpleados.RowHeadersWidth = 62;
            this.ListadodeEmpleados.Size = new System.Drawing.Size(1688, 371);
            this.ListadodeEmpleados.TabIndex = 8;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 8;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 150;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 8;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 8;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 150;
            // 
            // Fecha_de_Ingreso
            // 
            this.Fecha_de_Ingreso.DataPropertyName = "Fecha_de_Ingreso";
            this.Fecha_de_Ingreso.HeaderText = "Fecha_de_Ingreso";
            this.Fecha_de_Ingreso.MinimumWidth = 8;
            this.Fecha_de_Ingreso.Name = "Fecha_de_Ingreso";
            this.Fecha_de_Ingreso.Width = 150;
            // 
            // Puesto_Ocupado
            // 
            this.Puesto_Ocupado.DataPropertyName = "Puesto_Ocupado";
            this.Puesto_Ocupado.HeaderText = "Puesto_Ocupado";
            this.Puesto_Ocupado.MinimumWidth = 8;
            this.Puesto_Ocupado.Name = "Puesto_Ocupado";
            this.Puesto_Ocupado.Width = 150;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.MinimumWidth = 8;
            this.Departamento.Name = "Departamento";
            this.Departamento.Width = 150;
            // 
            // CEDULA
            // 
            this.CEDULA.DataPropertyName = "CEDULA";
            this.CEDULA.HeaderText = "CEDULA";
            this.CEDULA.MinimumWidth = 8;
            this.CEDULA.Name = "CEDULA";
            this.CEDULA.Width = 150;
            // 
            // Salario_Base
            // 
            this.Salario_Base.DataPropertyName = "Salario_Base";
            this.Salario_Base.HeaderText = "Salario_Base";
            this.Salario_Base.MinimumWidth = 8;
            this.Salario_Base.Name = "Salario_Base";
            this.Salario_Base.Width = 150;
            // 
            // Tipo_de_Cobro
            // 
            this.Tipo_de_Cobro.DataPropertyName = "Tipo_de_Cobro";
            this.Tipo_de_Cobro.HeaderText = "Tipo_de_Cobro";
            this.Tipo_de_Cobro.MinimumWidth = 8;
            this.Tipo_de_Cobro.Name = "Tipo_de_Cobro";
            this.Tipo_de_Cobro.Width = 150;
            // 
            // Turno
            // 
            this.Turno.DataPropertyName = "Turno";
            this.Turno.HeaderText = "Turno";
            this.Turno.MinimumWidth = 8;
            this.Turno.Name = "Turno";
            this.Turno.Width = 150;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.Location = new System.Drawing.Point(345, 66);
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
            this.label15.Size = new System.Drawing.Size(234, 22);
            this.label15.TabIndex = 1;
            this.label15.Text = "Criterio de Búsqueda por";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(15, 69);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(301, 28);
            this.txtbusqueda.TabIndex = 0;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.empleadosDataSet;
            // 
            // empleadosDataSet
            // 
            this.empleadosDataSet.DataSetName = "EmpleadosDataSet";
            this.empleadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.bntlimpiar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCancelar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnNuevo);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCerrar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnModificar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnEliminar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnRegistrar);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(222, 486);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(1363, 23);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(222, 486);
            this.toolStripContainer1.TabIndex = 136;
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
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(12, 278);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(202, 40);
            this.btnCancelar.TabIndex = 109;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Location = new System.Drawing.Point(15, 225);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(202, 40);
            this.btnNuevo.TabIndex = 108;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(12, 328);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(202, 40);
            this.btnCerrar.TabIndex = 106;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
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
            this.btnRegistrar.Location = new System.Drawing.Point(12, 23);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(202, 49);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(671, 264);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 29);
            this.label12.TabIndex = 135;
            this.label12.Text = "Fecha de Ingreso";
            // 
            // txtsalariobase
            // 
            this.txtsalariobase.Location = new System.Drawing.Point(226, 274);
            this.txtsalariobase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsalariobase.Name = "txtsalariobase";
            this.txtsalariobase.Size = new System.Drawing.Size(296, 26);
            this.txtsalariobase.TabIndex = 133;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(694, 227);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 29);
            this.label11.TabIndex = 131;
            this.label11.Text = "Tipo de Cobro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(694, 195);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 29);
            this.label10.TabIndex = 129;
            this.label10.Text = "Turno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 234);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 29);
            this.label9.TabIndex = 127;
            this.label9.Text = "Departamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 29);
            this.label8.TabIndex = 126;
            this.label8.Text = "Salario Base";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(814, 155);
            this.txtdni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(296, 26);
            this.txtdni.TabIndex = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(694, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 29);
            this.label7.TabIndex = 124;
            this.label7.Text = "Cedula";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(814, 116);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(296, 26);
            this.txttelefono.TabIndex = 123;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(694, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 122;
            this.label6.Text = "Teléfono";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(180, 314);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(343, 90);
            this.txtdireccion.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 317);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 120;
            this.label5.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 118;
            this.label3.Text = "Puesto Ocupado";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(170, 155);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(296, 26);
            this.txtApellido.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 116;
            this.label2.Text = "Apellido(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 114;
            this.label4.Text = "Nombre(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 29);
            this.label1.TabIndex = 113;
            this.label1.Text = "ID";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(170, 115);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(296, 26);
            this.txtNombre.TabIndex = 115;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(170, 75);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(134, 26);
            this.txtId.TabIndex = 141;
            // 
            // txtfechadeingreso
            // 
            this.txtfechadeingreso.Location = new System.Drawing.Point(876, 264);
            this.txtfechadeingreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfechadeingreso.Name = "txtfechadeingreso";
            this.txtfechadeingreso.Size = new System.Drawing.Size(298, 26);
            this.txtfechadeingreso.TabIndex = 142;
            // 
            // txttipodecobro
            // 
            this.txttipodecobro.FormattingEnabled = true;
            this.txttipodecobro.Items.AddRange(new object[] {
            "Efectivo",
            "Checke",
            "Deposito",
            "Paypal"});
            this.txttipodecobro.Location = new System.Drawing.Point(876, 227);
            this.txttipodecobro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttipodecobro.Name = "txttipodecobro";
            this.txttipodecobro.Size = new System.Drawing.Size(298, 28);
            this.txttipodecobro.TabIndex = 143;
            // 
            // txtdeparmento
            // 
            this.txtdeparmento.FormattingEnabled = true;
            this.txtdeparmento.Items.AddRange(new object[] {
            "Investigación académica",
            "Contabilidad",
            "Cuentas y finanzas",
            "Administración",
            "Publicidad",
            "Aeroespacial",
            "Agricultura",
            "Agricultura, animales y plantas.",
            "Arquitectura",
            "Fuerzas Armadas",
            "Banca, seguros y servicios financieros",
            "Servicios de construcción",
            "Análisis de sistemas y negocios",
            "Organizaciones benéficas y sector voluntario",
            "Caridad, servicio público y civil",
            "Civiles y estructurales",
            "Servicios civiles",
            "Cumplimiento y regulación",
            "Construcción",
            "Consultante",
            "Artes creativas y diseño.",
            "Ciencia de los datos",
            "Dental",
            "Diseño",
            "Digital",
            "Educación",
            "Servicios de emergencia",
            "Energía, recursos naturales y servicios públicos",
            "Ingeniería",
            "Ambiental",
            "Gestión de eventos",
            "Alimento",
            "RRHH y reclutamiento",
            "Cuidado de la salud",
            "Educación más alta",
            "Hostelería, deporte, ocio y turismo",
            "Gestión hotelera",
            "Gestión de recursos humanos",
            "Servicios de información",
            "Seguro",
            "Banca de inversión y gestión de fondos",
            "Periodismo",
            "Idiomas, bibliotecas y cultura",
            "Ley",
            "abogados",
            "Cumplimiento de la ley",
            "abogados abogados",
            "Derecho, servicios legales y patentes.",
            "Turismo de ocio",
            "Gestión",
            "Gestión y negocios",
            "Consultoría de gestión",
            "Fabricación y procesamiento",
            "Marketing",
            "Marketing, publicidad y relaciones públicas",
            "Medios de comunicación",
            "Medios, periodismo y publicaciones",
            "Médico",
            "Médico, sanitario y dental",
            "Comercialización",
            "Museos, bibliotecas y patrimonio",
            "Ingeniería en Redes",
            "Farmacéutico",
            "Obtención",
            "Adquisiciones y cadena de suministro",
            "I+D de productos",
            "Gestión de activos inmobiliarios",
            "La consultora inmobiliaria",
            "Propiedad, construcción y QS",
            "Relaciones públicas y comunicaciones.",
            "Servicio público",
            "Publicación",
            "Reclutamiento",
            "Minorista",
            "Servicios minoristas, empresariales y comerciales",
            "Ventas",
            "Ventas y alquileres",
            "Ciencia, I+D, industria alimentaria",
            "Seguridad e inteligencia",
            "Investigación social y de mercado",
            "Asistencia social",
            "Social, comunitario y juvenil",
            "Ingeniería de software",
            "Pruebas de software",
            "Deportes",
            "Cadena de suministro",
            "topografía",
            "Enseñando",
            "Enseñanza y educación",
            "Consultoría técnica",
            "Ventas técnicas",
            "Apoyo técnico",
            "Tecnología",
            "Entrenamiento y desarrollo",
            "Veterinario",
            "Gestion de almacenes",
            "desarrollo web"});
            this.txtdeparmento.Location = new System.Drawing.Point(226, 234);
            this.txtdeparmento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdeparmento.Name = "txtdeparmento";
            this.txtdeparmento.Size = new System.Drawing.Size(298, 28);
            this.txtdeparmento.TabIndex = 144;
            // 
            // txtpuestoocupado
            // 
            this.txtpuestoocupado.FormattingEnabled = true;
            this.txtpuestoocupado.Items.AddRange(new object[] {
            "Agente",
            "Supervisor",
            "Manager",
            "Calidad"});
            this.txtpuestoocupado.Location = new System.Drawing.Point(226, 191);
            this.txtpuestoocupado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpuestoocupado.Name = "txtpuestoocupado";
            this.txtpuestoocupado.Size = new System.Drawing.Size(298, 28);
            this.txtpuestoocupado.TabIndex = 145;
            // 
            // txtturno
            // 
            this.txtturno.FormattingEnabled = true;
            this.txtturno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Nocturno",
            "Rotativo"});
            this.txtturno.Location = new System.Drawing.Point(812, 196);
            this.txtturno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtturno.Name = "txtturno";
            this.txtturno.Size = new System.Drawing.Size(298, 28);
            this.txtturno.TabIndex = 146;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // CriterioDeBusqueda
            // 
            this.CriterioDeBusqueda.FormattingEnabled = true;
            this.CriterioDeBusqueda.Items.AddRange(new object[] {
            "Id",
            "Nombre y Apellido",
            "Numero"});
            this.CriterioDeBusqueda.Location = new System.Drawing.Point(271, 29);
            this.CriterioDeBusqueda.Name = "CriterioDeBusqueda";
            this.CriterioDeBusqueda.Size = new System.Drawing.Size(133, 30);
            this.CriterioDeBusqueda.TabIndex = 10;
            this.CriterioDeBusqueda.Text = "CEDULA";
            // 
            // MantenimientoDeEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1834, 955);
            this.Controls.Add(this.txtturno);
            this.Controls.Add(this.txtpuestoocupado);
            this.Controls.Add(this.txtdeparmento);
            this.Controls.Add(this.txttipodecobro);
            this.Controls.Add(this.txtfechadeingreso);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.gblistadovisitas);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtsalariobase);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MantenimientoDeEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento_de_Empleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MantenimientoDeEmpleados_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MantenimientoDeEmpleados_MouseDown);
            this.gblistadovisitas.ResumeLayout(false);
            this.gblistadovisitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadodeEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataSet)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gblistadovisitas;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridView ListadodeEmpleados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtsalariobase;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button bntlimpiar;
        private System.Windows.Forms.DateTimePicker txtfechadeingreso;
        private System.Windows.Forms.ComboBox txttipodecobro;
        private System.Windows.Forms.ComboBox txtdeparmento;
        private System.Windows.Forms.ComboBox txtpuestoocupado;
        private System.Windows.Forms.ComboBox txtturno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto_Ocupado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario_Base;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_Cobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private EmpleadosDataSet empleadosDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private EmpleadosDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.ComboBox CriterioDeBusqueda;
    }
}