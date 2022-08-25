namespace SISCANE
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label14 = new System.Windows.Forms.Label();
            this.gblistadovisitas = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.ListadodeEmpleados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.bntlimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsalariobase = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtturno = new System.Windows.Forms.TextBox();
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
            this.gblistadovisitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadodeEmpleados)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(249, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(313, 25);
            this.label14.TabIndex = 138;
            this.label14.Text = "REGISTRO DE EMPLEADOS";
            // 
            // gblistadovisitas
            // 
            this.gblistadovisitas.Controls.Add(this.btnRefrescar);
            this.gblistadovisitas.Controls.Add(this.ListadodeEmpleados);
            this.gblistadovisitas.Controls.Add(this.btnBuscar);
            this.gblistadovisitas.Controls.Add(this.label15);
            this.gblistadovisitas.Controls.Add(this.txtbusqueda);
            this.gblistadovisitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gblistadovisitas.ForeColor = System.Drawing.Color.DarkCyan;
            this.gblistadovisitas.Location = new System.Drawing.Point(4, 279);
            this.gblistadovisitas.Name = "gblistadovisitas";
            this.gblistadovisitas.Size = new System.Drawing.Size(592, 243);
            this.gblistadovisitas.TabIndex = 137;
            this.gblistadovisitas.TabStop = false;
            this.gblistadovisitas.Text = "Empleados Registrados";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRefrescar.Location = new System.Drawing.Point(483, 45);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(103, 23);
            this.btnRefrescar.TabIndex = 7;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // ListadodeEmpleados
            // 
            this.ListadodeEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ListadodeEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadodeEmpleados.Location = new System.Drawing.Point(7, 73);
            this.ListadodeEmpleados.Name = "ListadodeEmpleados";
            this.ListadodeEmpleados.ReadOnly = true;
            this.ListadodeEmpleados.Size = new System.Drawing.Size(579, 164);
            this.ListadodeEmpleados.TabIndex = 8;
            this.ListadodeEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadodeEmpleados_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.Location = new System.Drawing.Point(218, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(10, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Criterio de Búsqueda";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(10, 45);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(202, 22);
            this.txtbusqueda.TabIndex = 0;
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label13);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCerrar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnModificar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnEliminar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnRegistrar);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(148, 316);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(602, 206);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(148, 316);
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
            this.bntlimpiar.Location = new System.Drawing.Point(10, 118);
            this.bntlimpiar.Name = "bntlimpiar";
            this.bntlimpiar.Size = new System.Drawing.Size(135, 26);
            this.bntlimpiar.TabIndex = 110;
            this.bntlimpiar.Text = "Limpiar";
            this.bntlimpiar.UseVisualStyleBackColor = true;
            this.bntlimpiar.Click += new System.EventHandler(this.bntlimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(8, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 26);
            this.btnCancelar.TabIndex = 109;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Location = new System.Drawing.Point(10, 146);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(135, 26);
            this.btnNuevo.TabIndex = 108;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 18);
            this.label13.TabIndex = 107;
            this.label13.Text = "BOTONES";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(8, 213);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(135, 26);
            this.btnCerrar.TabIndex = 106;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(8, 53);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 28);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(8, 87);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 29);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(8, 15);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 32);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(382, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 18);
            this.label12.TabIndex = 135;
            this.label12.Text = "Fecha de Ingreso";
            // 
            // txtsalariobase
            // 
            this.txtsalariobase.Location = new System.Drawing.Point(151, 178);
            this.txtsalariobase.Name = "txtsalariobase";
            this.txtsalariobase.Size = new System.Drawing.Size(199, 20);
            this.txtsalariobase.TabIndex = 133;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(397, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 18);
            this.label11.TabIndex = 131;
            this.label11.Text = "Tipo de Cobro";
            // 
            // txtturno
            // 
            this.txtturno.Location = new System.Drawing.Point(477, 124);
            this.txtturno.Name = "txtturno";
            this.txtturno.Size = new System.Drawing.Size(63, 20);
            this.txtturno.TabIndex = 130;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(397, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 129;
            this.label10.Text = "Turno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 18);
            this.label9.TabIndex = 127;
            this.label9.Text = "Departamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 126;
            this.label8.Text = "Salario Base";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(477, 100);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(199, 20);
            this.txtdni.TabIndex = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(397, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 124;
            this.label7.Text = "Cedula";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(477, 75);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(199, 20);
            this.txttelefono.TabIndex = 123;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 122;
            this.label6.Text = "Teléfono";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(120, 204);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(230, 60);
            this.txtdireccion.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 120;
            this.label5.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 118;
            this.label3.Text = "Puesto Ocupado";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(113, 101);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(199, 20);
            this.txtApellido.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 116;
            this.label2.Text = "Apellido(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 114;
            this.label4.Text = "Nombre(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 113;
            this.label1.Text = "ID";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 20);
            this.txtNombre.TabIndex = 115;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(113, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(91, 20);
            this.txtId.TabIndex = 141;
            // 
            // txtfechadeingreso
            // 
            this.txtfechadeingreso.Location = new System.Drawing.Point(519, 171);
            this.txtfechadeingreso.Name = "txtfechadeingreso";
            this.txtfechadeingreso.Size = new System.Drawing.Size(200, 20);
            this.txtfechadeingreso.TabIndex = 142;
            // 
            // txttipodecobro
            // 
            this.txttipodecobro.FormattingEnabled = true;
            this.txttipodecobro.Location = new System.Drawing.Point(519, 147);
            this.txttipodecobro.Name = "txttipodecobro";
            this.txttipodecobro.Size = new System.Drawing.Size(200, 21);
            this.txttipodecobro.TabIndex = 143;
            // 
            // txtdeparmento
            // 
            this.txtdeparmento.FormattingEnabled = true;
            this.txtdeparmento.Location = new System.Drawing.Point(151, 152);
            this.txtdeparmento.Name = "txtdeparmento";
            this.txtdeparmento.Size = new System.Drawing.Size(200, 21);
            this.txtdeparmento.TabIndex = 144;
            // 
            // txtpuestoocupado
            // 
            this.txtpuestoocupado.FormattingEnabled = true;
            this.txtpuestoocupado.Location = new System.Drawing.Point(151, 124);
            this.txtpuestoocupado.Name = "txtpuestoocupado";
            this.txtpuestoocupado.Size = new System.Drawing.Size(200, 21);
            this.txtpuestoocupado.TabIndex = 145;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(754, 532);
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
            this.Controls.Add(this.txtturno);
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
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento_de_Empleado";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.gblistadovisitas.ResumeLayout(false);
            this.gblistadovisitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadodeEmpleados)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtsalariobase;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtturno;
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
    }
}