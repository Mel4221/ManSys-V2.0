namespace ManSys
{
    partial class ReporteDeUsuarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteDeUsuarios));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Listado_de_Usuarios = new System.Windows.Forms.DataGridView();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.FechaDeJornada = new System.Windows.Forms.DateTimePicker();
			this.btnRefrescar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Listado_de_Usuarios)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(401, 181);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(374, 29);
			this.label1.TabIndex = 53;
			this.label1.Text = "Seleccionar Fecha de Registro";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(18, 198);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(245, 29);
			this.label2.TabIndex = 50;
			this.label2.Text = "Listado de Usuarios";
			// 
			// Listado_de_Usuarios
			// 
			this.Listado_de_Usuarios.AccessibleName = "";
			this.Listado_de_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Listado_de_Usuarios.Location = new System.Drawing.Point(18, 231);
			this.Listado_de_Usuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Listado_de_Usuarios.Name = "Listado_de_Usuarios";
			this.Listado_de_Usuarios.RowHeadersWidth = 62;
			this.Listado_de_Usuarios.Size = new System.Drawing.Size(1425, 797);
			this.Listado_de_Usuarios.TabIndex = 48;
			this.Listado_de_Usuarios.Tag = "";
			this.Listado_de_Usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.ForeColor = System.Drawing.Color.Red;
			this.btnCerrar.Location = new System.Drawing.Point(1357, 184);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(86, 37);
			this.btnCerrar.TabIndex = 107;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.button2_Click);
			// 
			// FechaDeJornada
			// 
			this.FechaDeJornada.Location = new System.Drawing.Point(824, 184);
			this.FechaDeJornada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.FechaDeJornada.Name = "FechaDeJornada";
			this.FechaDeJornada.Size = new System.Drawing.Size(298, 26);
			this.FechaDeJornada.TabIndex = 144;
			this.FechaDeJornada.ValueChanged += new System.EventHandler(this.FechaDeJornada_ValueChanged);
			// 
			// btnRefrescar
			// 
			this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefrescar.Location = new System.Drawing.Point(1198, 173);
			this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnRefrescar.Name = "btnRefrescar";
			this.btnRefrescar.Size = new System.Drawing.Size(118, 49);
			this.btnRefrescar.TabIndex = 49;
			this.btnRefrescar.Text = "Refrescar";
			this.btnRefrescar.UseVisualStyleBackColor = true;
			this.btnRefrescar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// ReporteDeUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1475, 1074);
			this.Controls.Add(this.FechaDeJornada);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnRefrescar);
			this.Controls.Add(this.Listado_de_Usuarios);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ReporteDeUsuarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reporte de Usuarios";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form8_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form8_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.Listado_de_Usuarios)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Listado_de_Usuarios;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DateTimePicker FechaDeJornada;
		private System.Windows.Forms.Button btnRefrescar;
	}
}