namespace ManSys
{
    partial class mantenimientoDeducciones
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
			this.txtcantidad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gblistadovisitas = new System.Windows.Forms.GroupBox();
			this.btnRefrescar = new System.Windows.Forms.Button();
			this.ListadodeUsuarios = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Applicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.txtbusqueda = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.bntlimpiar = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtid = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ApplicacionOId = new System.Windows.Forms.ComboBox();
			this.ApplicacionOIdLimpiear = new System.Windows.Forms.Button();
			this.gblistadovisitas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ListadodeUsuarios)).BeginInit();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtcantidad
			// 
			this.txtcantidad.Location = new System.Drawing.Point(418, 188);
			this.txtcantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtcantidad.Name = "txtcantidad";
			this.txtcantidad.Size = new System.Drawing.Size(355, 26);
			this.txtcantidad.TabIndex = 178;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(424, 155);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(285, 29);
			this.label2.TabIndex = 177;
			this.label2.Text = "Cantidad de Deducción";
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
			this.gblistadovisitas.Location = new System.Drawing.Point(8, 262);
			this.gblistadovisitas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gblistadovisitas.Name = "gblistadovisitas";
			this.gblistadovisitas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gblistadovisitas.Size = new System.Drawing.Size(1170, 546);
			this.gblistadovisitas.TabIndex = 176;
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
            this.Id,
            this.Nombre,
            this.Cantidad,
            this.Applicacion});
			this.ListadodeUsuarios.Location = new System.Drawing.Point(10, 112);
			this.ListadodeUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ListadodeUsuarios.Name = "ListadodeUsuarios";
			this.ListadodeUsuarios.ReadOnly = true;
			this.ListadodeUsuarios.RowHeadersWidth = 62;
			this.ListadodeUsuarios.Size = new System.Drawing.Size(1148, 423);
			this.ListadodeUsuarios.TabIndex = 8;
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "ID";
			this.Id.MinimumWidth = 8;
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Width = 150;
			// 
			// Nombre
			// 
			this.Nombre.DataPropertyName = "Nombre";
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.MinimumWidth = 8;
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.Width = 200;
			// 
			// Cantidad
			// 
			this.Cantidad.DataPropertyName = "Cantidad";
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.MinimumWidth = 8;
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			this.Cantidad.Width = 150;
			// 
			// Applicacion
			// 
			this.Applicacion.DataPropertyName = "Applicacion";
			this.Applicacion.HeaderText = "Applicacion";
			this.Applicacion.MinimumWidth = 8;
			this.Applicacion.Name = "Applicacion";
			this.Applicacion.ReadOnly = true;
			this.Applicacion.Width = 150;
			// 
			// btnBuscar
			// 
			this.btnBuscar.ForeColor = System.Drawing.Color.DodgerBlue;
			this.btnBuscar.Location = new System.Drawing.Point(374, 69);
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
			this.txtbusqueda.Size = new System.Drawing.Size(348, 30);
			this.txtbusqueda.TabIndex = 0;
			this.txtbusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbusqueda_KeyDown);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(498, 9);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(680, 40);
			this.label14.TabIndex = 175;
			this.label14.Text = "MANTENIMIENTO DE DEDUCCIONES";
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
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(222, 451);
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(1218, 346);
			this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(222, 451);
			this.toolStripContainer1.TabIndex = 174;
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
			this.label13.Location = new System.Drawing.Point(45, 292);
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
			this.btnCerrar.Location = new System.Drawing.Point(16, 232);
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
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(16, 188);
			this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(355, 26);
			this.txtnombre.TabIndex = 173;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(22, 155);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(275, 29);
			this.label4.TabIndex = 172;
			this.label4.Text = "Nombre de Deducción";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 118);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 29);
			this.label1.TabIndex = 171;
			this.label1.Text = "Codigo";
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(124, 120);
			this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(116, 26);
			this.txtid.TabIndex = 170;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(827, 143);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(366, 29);
			this.label3.TabIndex = 179;
			this.label3.Text = "Applicacion o ID de Empleado";
			// 
			// ApplicacionOId
			// 
			this.ApplicacionOId.FormattingEnabled = true;
			this.ApplicacionOId.Items.AddRange(new object[] {
            "A Todos"});
			this.ApplicacionOId.Location = new System.Drawing.Point(832, 186);
			this.ApplicacionOId.Name = "ApplicacionOId";
			this.ApplicacionOId.Size = new System.Drawing.Size(238, 28);
			this.ApplicacionOId.TabIndex = 180;
			this.ApplicacionOId.Text = "A Todos";
			// 
			// ApplicacionOIdLimpiear
			// 
			this.ApplicacionOIdLimpiear.Location = new System.Drawing.Point(1076, 185);
			this.ApplicacionOIdLimpiear.Name = "ApplicacionOIdLimpiear";
			this.ApplicacionOIdLimpiear.Size = new System.Drawing.Size(90, 32);
			this.ApplicacionOIdLimpiear.TabIndex = 181;
			this.ApplicacionOIdLimpiear.Text = "Limpiear";
			this.ApplicacionOIdLimpiear.UseVisualStyleBackColor = true;
			this.ApplicacionOIdLimpiear.Click += new System.EventHandler(this.ApplicacionOIdLimpiear_Click);
			// 
			// mantenimientoDeducciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1534, 818);
			this.Controls.Add(this.ApplicacionOIdLimpiear);
			this.Controls.Add(this.ApplicacionOId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtcantidad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gblistadovisitas);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "mantenimientoDeducciones";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "mantenimientoDeducciones";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.mantenimientoDeducciones_Load);
			this.gblistadovisitas.ResumeLayout(false);
			this.gblistadovisitas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ListadodeUsuarios)).EndInit();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gblistadovisitas;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridView ListadodeUsuarios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button bntlimpiar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox ApplicacionOId;
		private System.Windows.Forms.Button ApplicacionOIdLimpiear;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Applicacion;
	}
}