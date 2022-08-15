namespace SISCANE
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gblistadovisitas = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.ListadodeUsuarios = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.bntlimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gblistadovisitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadodeUsuarios)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 178;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 18);
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
            this.gblistadovisitas.Location = new System.Drawing.Point(5, 170);
            this.gblistadovisitas.Name = "gblistadovisitas";
            this.gblistadovisitas.Size = new System.Drawing.Size(590, 355);
            this.gblistadovisitas.TabIndex = 176;
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
            // 
            // ListadodeUsuarios
            // 
            this.ListadodeUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ListadodeUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadodeUsuarios.Location = new System.Drawing.Point(7, 73);
            this.ListadodeUsuarios.Name = "ListadodeUsuarios";
            this.ListadodeUsuarios.ReadOnly = true;
            this.ListadodeUsuarios.Size = new System.Drawing.Size(579, 275);
            this.ListadodeUsuarios.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.Location = new System.Drawing.Point(249, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(10, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Criterio de Búsqueda";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(10, 45);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(233, 22);
            this.txtbusqueda.TabIndex = 0;
            this.txtbusqueda.Text = "Digitar Codigo de Deducción";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(86, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(466, 29);
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCancelar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnNuevo);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label13);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCerrar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnModificar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnEliminar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnRegistrar);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(148, 293);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(601, 215);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(148, 293);
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
            this.bntlimpiar.Location = new System.Drawing.Point(10, 118);
            this.bntlimpiar.Name = "bntlimpiar";
            this.bntlimpiar.Size = new System.Drawing.Size(135, 26);
            this.bntlimpiar.TabIndex = 110;
            this.bntlimpiar.Text = "Limpiar";
            this.bntlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(8, 178);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 29);
            this.btnCancelar.TabIndex = 109;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
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
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(8, 22);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 25);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(11, 122);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(238, 20);
            this.txtnombre.TabIndex = 173;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 18);
            this.label4.TabIndex = 172;
            this.label4.Text = "Nombre de Deducción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 171;
            this.label1.Text = "Codigo";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(83, 78);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(79, 20);
            this.txtid.TabIndex = 170;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(279, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 20);
            this.textBox2.TabIndex = 180;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 179;
            this.label3.Text = "Posición";
            // 
            // mantenimientoDeducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(754, 532);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gblistadovisitas);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mantenimientoDeducciones";
            this.Text = "mantenimientoDeducciones";
            this.Load += new System.EventHandler(this.mantenimientoDeducciones_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mantenimientoDeducciones_MouseDown);
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

        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}