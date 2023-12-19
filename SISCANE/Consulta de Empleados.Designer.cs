namespace ManSys
{
    partial class ConsultaDeEmpleados
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaDeEmpleados));
			this.label1 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtbusqueda = new System.Windows.Forms.TextBox();
			this.gblistadovisitas = new System.Windows.Forms.GroupBox();
			this.btnRefrescar = new System.Windows.Forms.Button();
			this.ListadodeEmpleados = new System.Windows.Forms.DataGridView();
			this.Tipo = new System.Windows.Forms.ComboBox();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.label25 = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.BusquedaAvanzada = new System.Windows.Forms.CheckBox();
			this.gblistadovisitas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ListadodeEmpleados)).BeginInit();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 117);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 29);
			this.label1.TabIndex = 32;
			this.label1.Text = "Filtrar Por";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
			this.label22.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label22.Location = new System.Drawing.Point(114, 32);
			this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(457, 35);
			this.label22.TabIndex = 188;
			this.label22.Text = "CONSULTA DE EMPLEADOS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(388, 117);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(214, 29);
			this.label2.TabIndex = 189;
			this.label2.Text = "Digitar Busqueda";
			// 
			// txtbusqueda
			// 
			this.txtbusqueda.Location = new System.Drawing.Point(393, 151);
			this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtbusqueda.Name = "txtbusqueda";
			this.txtbusqueda.Size = new System.Drawing.Size(336, 26);
			this.txtbusqueda.TabIndex = 190;
			this.txtbusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbusqueda_KeyDown);
			// 
			// gblistadovisitas
			// 
			this.gblistadovisitas.Controls.Add(this.btnRefrescar);
			this.gblistadovisitas.Controls.Add(this.ListadodeEmpleados);
			this.gblistadovisitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gblistadovisitas.ForeColor = System.Drawing.Color.DarkCyan;
			this.gblistadovisitas.Location = new System.Drawing.Point(18, 277);
			this.gblistadovisitas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gblistadovisitas.Name = "gblistadovisitas";
			this.gblistadovisitas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gblistadovisitas.Size = new System.Drawing.Size(1178, 318);
			this.gblistadovisitas.TabIndex = 259;
			this.gblistadovisitas.TabStop = false;
			this.gblistadovisitas.Text = "Empleados Registrados";
			// 
			// btnRefrescar
			// 
			this.btnRefrescar.ForeColor = System.Drawing.Color.DodgerBlue;
			this.btnRefrescar.Location = new System.Drawing.Point(1012, 32);
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
			this.ListadodeEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.ListadodeEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ListadodeEmpleados.Location = new System.Drawing.Point(9, 74);
			this.ListadodeEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ListadodeEmpleados.Name = "ListadodeEmpleados";
			this.ListadodeEmpleados.ReadOnly = true;
			this.ListadodeEmpleados.RowHeadersWidth = 62;
			this.ListadodeEmpleados.Size = new System.Drawing.Size(1158, 235);
			this.ListadodeEmpleados.TabIndex = 8;
			// 
			// Tipo
			// 
			this.Tipo.FormattingEnabled = true;
			this.Tipo.Items.AddRange(new object[] {
            "ID",
            "CEDULA",
            "TELEFONO",
            "NOMBRE"});
			this.Tipo.Location = new System.Drawing.Point(27, 149);
			this.Tipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Tipo.Name = "Tipo";
			this.Tipo.Size = new System.Drawing.Size(322, 28);
			this.Tipo.TabIndex = 260;
			this.Tipo.Text = "ID";
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.btnBuscar);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.btnLimpiar);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.label25);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCerrar);
			this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(786, 85);
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(410, 191);
			this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(786, 85);
			this.toolStripContainer1.TabIndex = 261;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.toolStripContainer1.TopToolStripPanelVisible = false;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.Color.Black;
			this.btnBuscar.Location = new System.Drawing.Point(147, 31);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(202, 40);
			this.btnBuscar.TabIndex = 109;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
			this.btnLimpiar.Location = new System.Drawing.Point(358, 31);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(202, 40);
			this.btnLimpiar.TabIndex = 108;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(4, 35);
			this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(140, 29);
			this.label25.TabIndex = 107;
			this.label25.Text = "BOTONES";
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.Red;
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.ForeColor = System.Drawing.Color.Black;
			this.btnCerrar.Location = new System.Drawing.Point(570, 31);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(202, 40);
			this.btnCerrar.TabIndex = 106;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
			// 
			// BusquedaAvanzada
			// 
			this.BusquedaAvanzada.AutoSize = true;
			this.BusquedaAvanzada.Location = new System.Drawing.Point(768, 149);
			this.BusquedaAvanzada.Name = "BusquedaAvanzada";
			this.BusquedaAvanzada.Size = new System.Drawing.Size(183, 24);
			this.BusquedaAvanzada.TabIndex = 270;
			this.BusquedaAvanzada.Text = "Busqueda Avanzada";
			this.BusquedaAvanzada.UseVisualStyleBackColor = true;
			// 
			// ConsultaDeEmpleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1214, 614);
			this.Controls.Add(this.BusquedaAvanzada);
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.Tipo);
			this.Controls.Add(this.gblistadovisitas);
			this.Controls.Add(this.txtbusqueda);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ConsultaDeEmpleados";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta de Empleados";
			this.Load += new System.EventHandler(this.ConsultaDeEmpleados_Load);
			this.gblistadovisitas.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ListadodeEmpleados)).EndInit();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.GroupBox gblistadovisitas;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridView ListadodeEmpleados;
        private System.Windows.Forms.ComboBox Tipo;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.CheckBox BusquedaAvanzada;
	}
}