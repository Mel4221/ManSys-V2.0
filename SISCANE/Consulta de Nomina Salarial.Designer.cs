namespace ManSys
{
    partial class ConsultadeNominaSalarial
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
			this.btnCerrar = new System.Windows.Forms.Button();
			this.bntlimpiar = new System.Windows.Forms.Button();
			this.bntbuscar = new System.Windows.Forms.Button();
			this.label22 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtcodigo = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.ListadodeNominaRegistrada = new System.Windows.Forms.DataGridView();
			this.PeriodoDeNomina = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.ListadodeNominaRegistrada)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.Red;
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.ForeColor = System.Drawing.Color.Black;
			this.btnCerrar.Location = new System.Drawing.Point(1058, 243);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(160, 74);
			this.btnCerrar.TabIndex = 233;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// bntlimpiar
			// 
			this.bntlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntlimpiar.ForeColor = System.Drawing.Color.Black;
			this.bntlimpiar.Location = new System.Drawing.Point(886, 254);
			this.bntlimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.bntlimpiar.Name = "bntlimpiar";
			this.bntlimpiar.Size = new System.Drawing.Size(160, 52);
			this.bntlimpiar.TabIndex = 237;
			this.bntlimpiar.Text = "Limpiar";
			this.bntlimpiar.UseVisualStyleBackColor = true;
			this.bntlimpiar.Click += new System.EventHandler(this.bntlimpiar_Click);
			// 
			// bntbuscar
			// 
			this.bntbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntbuscar.Location = new System.Drawing.Point(697, 254);
			this.bntbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.bntbuscar.Name = "bntbuscar";
			this.bntbuscar.Size = new System.Drawing.Size(160, 52);
			this.bntbuscar.TabIndex = 267;
			this.bntbuscar.Text = "Buscar";
			this.bntbuscar.UseVisualStyleBackColor = true;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
			this.label22.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label22.Location = new System.Drawing.Point(46, 14);
			this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(657, 42);
			this.label22.TabIndex = 259;
			this.label22.Text = "CONSULTA DE NOMINA SALARIAL";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label31.Location = new System.Drawing.Point(337, 219);
			this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(209, 29);
			this.label31.TabIndex = 260;
			this.label31.Text = "Periodo de pago";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(32, 219);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(261, 29);
			this.label4.TabIndex = 266;
			this.label4.Text = "Codigo de Empleado";
			// 
			// txtcodigo
			// 
			this.txtcodigo.Location = new System.Drawing.Point(88, 269);
			this.txtcodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtcodigo.Name = "txtcodigo";
			this.txtcodigo.Size = new System.Drawing.Size(205, 26);
			this.txtcodigo.TabIndex = 268;
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.Location = new System.Drawing.Point(32, 269);
			this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(38, 29);
			this.label30.TabIndex = 269;
			this.label30.Text = "ID";
			// 
			// ListadodeNominaRegistrada
			// 
			this.ListadodeNominaRegistrada.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.ListadodeNominaRegistrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ListadodeNominaRegistrada.Location = new System.Drawing.Point(23, 331);
			this.ListadodeNominaRegistrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ListadodeNominaRegistrada.Name = "ListadodeNominaRegistrada";
			this.ListadodeNominaRegistrada.ReadOnly = true;
			this.ListadodeNominaRegistrada.RowHeadersWidth = 62;
			this.ListadodeNominaRegistrada.Size = new System.Drawing.Size(1195, 713);
			this.ListadodeNominaRegistrada.TabIndex = 273;
			this.ListadodeNominaRegistrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadodeNominaRegistrada_CellContentClick);
			// 
			// PeriodoDeNomina
			// 
			this.PeriodoDeNomina.FormattingEnabled = true;
			this.PeriodoDeNomina.Location = new System.Drawing.Point(342, 269);
			this.PeriodoDeNomina.Name = "PeriodoDeNomina";
			this.PeriodoDeNomina.Size = new System.Drawing.Size(285, 28);
			this.PeriodoDeNomina.TabIndex = 274;
			this.PeriodoDeNomina.TextChanged += new System.EventHandler(this.PeriodoDeNomina_TextChanged);
			// 
			// ConsultadeNominaSalarial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1472, 1085);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.PeriodoDeNomina);
			this.Controls.Add(this.bntlimpiar);
			this.Controls.Add(this.ListadodeNominaRegistrada);
			this.Controls.Add(this.txtcodigo);
			this.Controls.Add(this.bntbuscar);
			this.Controls.Add(this.label30);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.label22);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ConsultadeNominaSalarial";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "generarnomina";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ConsultadeNominaSalarial_Load);
			((System.ComponentModel.ISupportInitialize)(this.ListadodeNominaRegistrada)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button bntlimpiar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button bntbuscar;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView ListadodeNominaRegistrada;
		private System.Windows.Forms.ComboBox PeriodoDeNomina;
	}
}