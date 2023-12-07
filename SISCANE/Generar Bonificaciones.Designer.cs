
namespace ManSys
{
    partial class Bonificaciones
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
			this.label14 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.BtnDeBusqueda = new System.Windows.Forms.Button();
			this.ListadoDeBonificaciones = new System.Windows.Forms.DataGridView();
			this.CajaDePosicion = new System.Windows.Forms.ComboBox();
			this.CajaDeCodigoDeBonificacion = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.FechaDeApplicacion = new System.Windows.Forms.DateTimePicker();
			this.CajaDeMonto = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.CajaDeEmpleado = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.CajaDeDepartamento = new System.Windows.Forms.ComboBox();
			this.ApplicarATodos = new System.Windows.Forms.CheckBox();
			this.ApplicarSoloADepartamento = new System.Windows.Forms.CheckBox();
			this.ApplicarSoloAPosicion = new System.Windows.Forms.CheckBox();
			this.CajaDeEmpleadoId = new System.Windows.Forms.TextBox();
			this.BuscarBonificacion = new System.Windows.Forms.Button();
			this.bntlimpiar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.FechaDeEmision = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.CajaDeTipoDeBonificacion = new System.Windows.Forms.ComboBox();
			this.BtnRefrescar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ListadoDeBonificaciones)).BeginInit();
			this.SuspendLayout();
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(715, 21);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(336, 40);
			this.label14.TabIndex = 160;
			this.label14.Text = "BONIFICACIONES";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(433, 81);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 29);
			this.label5.TabIndex = 170;
			this.label5.Text = "ID";
			// 
			// BtnDeBusqueda
			// 
			this.BtnDeBusqueda.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.BtnDeBusqueda.Location = new System.Drawing.Point(1051, 75);
			this.BtnDeBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnDeBusqueda.Name = "BtnDeBusqueda";
			this.BtnDeBusqueda.Size = new System.Drawing.Size(112, 35);
			this.BtnDeBusqueda.TabIndex = 172;
			this.BtnDeBusqueda.Text = "Buscar";
			this.BtnDeBusqueda.UseVisualStyleBackColor = true;
			this.BtnDeBusqueda.Click += new System.EventHandler(this.BtnDeBusqueda_Click);
			// 
			// ListadoDeBonificaciones
			// 
			this.ListadoDeBonificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ListadoDeBonificaciones.Location = new System.Drawing.Point(241, 540);
			this.ListadoDeBonificaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ListadoDeBonificaciones.Name = "ListadoDeBonificaciones";
			this.ListadoDeBonificaciones.RowHeadersWidth = 62;
			this.ListadoDeBonificaciones.Size = new System.Drawing.Size(1236, 534);
			this.ListadoDeBonificaciones.TabIndex = 174;
			// 
			// CajaDePosicion
			// 
			this.CajaDePosicion.FormattingEnabled = true;
			this.CajaDePosicion.Location = new System.Drawing.Point(729, 217);
			this.CajaDePosicion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CajaDePosicion.Name = "CajaDePosicion";
			this.CajaDePosicion.Size = new System.Drawing.Size(298, 28);
			this.CajaDePosicion.TabIndex = 219;
			// 
			// CajaDeCodigoDeBonificacion
			// 
			this.CajaDeCodigoDeBonificacion.Location = new System.Drawing.Point(729, 412);
			this.CajaDeCodigoDeBonificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CajaDeCodigoDeBonificacion.Name = "CajaDeCodigoDeBonificacion";
			this.CajaDeCodigoDeBonificacion.Size = new System.Drawing.Size(298, 26);
			this.CajaDeCodigoDeBonificacion.TabIndex = 203;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(433, 409);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(98, 29);
			this.label10.TabIndex = 204;
			this.label10.Text = "Codigo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(433, 258);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(282, 29);
			this.label3.TabIndex = 207;
			this.label3.Text = "Tipo de Bonificaciones";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(433, 371);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(250, 29);
			this.label4.TabIndex = 210;
			this.label4.Text = "Fecha de Aplicación";
			// 
			// FechaDeApplicacion
			// 
			this.FechaDeApplicacion.Location = new System.Drawing.Point(729, 373);
			this.FechaDeApplicacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.FechaDeApplicacion.Name = "FechaDeApplicacion";
			this.FechaDeApplicacion.Size = new System.Drawing.Size(298, 26);
			this.FechaDeApplicacion.TabIndex = 211;
			// 
			// CajaDeMonto
			// 
			this.CajaDeMonto.Location = new System.Drawing.Point(729, 296);
			this.CajaDeMonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CajaDeMonto.Name = "CajaDeMonto";
			this.CajaDeMonto.Size = new System.Drawing.Size(298, 26);
			this.CajaDeMonto.TabIndex = 212;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(433, 296);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(272, 29);
			this.label6.TabIndex = 213;
			this.label6.Text = "Monto de Bonificación";
			// 
			// CajaDeEmpleado
			// 
			this.CajaDeEmpleado.Location = new System.Drawing.Point(729, 129);
			this.CajaDeEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CajaDeEmpleado.Name = "CajaDeEmpleado";
			this.CajaDeEmpleado.ReadOnly = true;
			this.CajaDeEmpleado.Size = new System.Drawing.Size(298, 26);
			this.CajaDeEmpleado.TabIndex = 214;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(433, 126);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(132, 29);
			this.label7.TabIndex = 215;
			this.label7.Text = "Empleado";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(433, 217);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 29);
			this.label8.TabIndex = 216;
			this.label8.Text = "Posición";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(433, 168);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(177, 29);
			this.label9.TabIndex = 217;
			this.label9.Text = "Departamento";
			// 
			// CajaDeDepartamento
			// 
			this.CajaDeDepartamento.FormattingEnabled = true;
			this.CajaDeDepartamento.Location = new System.Drawing.Point(729, 173);
			this.CajaDeDepartamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CajaDeDepartamento.Name = "CajaDeDepartamento";
			this.CajaDeDepartamento.Size = new System.Drawing.Size(298, 28);
			this.CajaDeDepartamento.TabIndex = 218;
			// 
			// ApplicarATodos
			// 
			this.ApplicarATodos.AutoSize = true;
			this.ApplicarATodos.Location = new System.Drawing.Point(1051, 130);
			this.ApplicarATodos.Name = "ApplicarATodos";
			this.ApplicarATodos.Size = new System.Drawing.Size(267, 24);
			this.ApplicarATodos.TabIndex = 220;
			this.ApplicarATodos.Text = "Applicar a Todos Los Empleados";
			this.ApplicarATodos.UseVisualStyleBackColor = true;
			// 
			// ApplicarSoloADepartamento
			// 
			this.ApplicarSoloADepartamento.AutoSize = true;
			this.ApplicarSoloADepartamento.Location = new System.Drawing.Point(1051, 174);
			this.ApplicarSoloADepartamento.Name = "ApplicarSoloADepartamento";
			this.ApplicarSoloADepartamento.Size = new System.Drawing.Size(224, 24);
			this.ApplicarSoloADepartamento.TabIndex = 221;
			this.ApplicarSoloADepartamento.Text = "Solo a Este Departamento";
			this.ApplicarSoloADepartamento.UseVisualStyleBackColor = true;
			// 
			// ApplicarSoloAPosicion
			// 
			this.ApplicarSoloAPosicion.AutoSize = true;
			this.ApplicarSoloAPosicion.Location = new System.Drawing.Point(1051, 214);
			this.ApplicarSoloAPosicion.Name = "ApplicarSoloAPosicion";
			this.ApplicarSoloAPosicion.Size = new System.Drawing.Size(205, 24);
			this.ApplicarSoloAPosicion.TabIndex = 222;
			this.ApplicarSoloAPosicion.Text = "Solo a Estas Posiciones";
			this.ApplicarSoloAPosicion.UseVisualStyleBackColor = true;
			// 
			// CajaDeEmpleadoId
			// 
			this.CajaDeEmpleadoId.Location = new System.Drawing.Point(729, 85);
			this.CajaDeEmpleadoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CajaDeEmpleadoId.Name = "CajaDeEmpleadoId";
			this.CajaDeEmpleadoId.Size = new System.Drawing.Size(298, 26);
			this.CajaDeEmpleadoId.TabIndex = 223;
			this.CajaDeEmpleadoId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CajaDeEmpleadoId_KeyDown);
			this.CajaDeEmpleadoId.Leave += new System.EventHandler(this.CajaDeEmpleadoId_Leave);
			// 
			// BuscarBonificacion
			// 
			this.BuscarBonificacion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.BuscarBonificacion.Location = new System.Drawing.Point(1051, 408);
			this.BuscarBonificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BuscarBonificacion.Name = "BuscarBonificacion";
			this.BuscarBonificacion.Size = new System.Drawing.Size(112, 35);
			this.BuscarBonificacion.TabIndex = 225;
			this.BuscarBonificacion.Text = "Buscar";
			this.BuscarBonificacion.UseVisualStyleBackColor = true;
			this.BuscarBonificacion.Click += new System.EventHandler(this.BuscarBonificacion_Click);
			// 
			// bntlimpiar
			// 
			this.bntlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntlimpiar.ForeColor = System.Drawing.Color.Black;
			this.bntlimpiar.Location = new System.Drawing.Point(891, 452);
			this.bntlimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.bntlimpiar.Name = "bntlimpiar";
			this.bntlimpiar.Size = new System.Drawing.Size(136, 45);
			this.bntlimpiar.TabIndex = 231;
			this.bntlimpiar.Text = "Limpiar";
			this.bntlimpiar.UseVisualStyleBackColor = true;
			this.bntlimpiar.Click += new System.EventHandler(this.bntlimpiar_Click_1);
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.Red;
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.ForeColor = System.Drawing.Color.Black;
			this.btnCerrar.Location = new System.Drawing.Point(1051, 452);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(260, 45);
			this.btnCerrar.TabIndex = 229;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(579, 452);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(136, 45);
			this.btnModificar.TabIndex = 227;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(729, 452);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(136, 45);
			this.btnEliminar.TabIndex = 228;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(438, 452);
			this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(136, 45);
			this.btnRegistrar.TabIndex = 226;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
			// 
			// FechaDeEmision
			// 
			this.FechaDeEmision.Location = new System.Drawing.Point(729, 335);
			this.FechaDeEmision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.FechaDeEmision.Name = "FechaDeEmision";
			this.FechaDeEmision.Size = new System.Drawing.Size(298, 26);
			this.FechaDeEmision.TabIndex = 233;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(433, 333);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 29);
			this.label1.TabIndex = 232;
			this.label1.Text = "Fecha de Emision";
			// 
			// CajaDeTipoDeBonificacion
			// 
			this.CajaDeTipoDeBonificacion.FormattingEnabled = true;
			this.CajaDeTipoDeBonificacion.Location = new System.Drawing.Point(729, 258);
			this.CajaDeTipoDeBonificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CajaDeTipoDeBonificacion.Name = "CajaDeTipoDeBonificacion";
			this.CajaDeTipoDeBonificacion.Size = new System.Drawing.Size(298, 28);
			this.CajaDeTipoDeBonificacion.TabIndex = 234;
			// 
			// BtnRefrescar
			// 
			this.BtnRefrescar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.BtnRefrescar.Location = new System.Drawing.Point(1365, 495);
			this.BtnRefrescar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnRefrescar.Name = "BtnRefrescar";
			this.BtnRefrescar.Size = new System.Drawing.Size(112, 35);
			this.BtnRefrescar.TabIndex = 235;
			this.BtnRefrescar.Text = "Refrescar";
			this.BtnRefrescar.UseVisualStyleBackColor = true;
			this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
			// 
			// Bonificaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1946, 1106);
			this.Controls.Add(this.BtnRefrescar);
			this.Controls.Add(this.CajaDeTipoDeBonificacion);
			this.Controls.Add(this.FechaDeEmision);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bntlimpiar);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.BuscarBonificacion);
			this.Controls.Add(this.CajaDeEmpleadoId);
			this.Controls.Add(this.ApplicarSoloAPosicion);
			this.Controls.Add(this.ApplicarSoloADepartamento);
			this.Controls.Add(this.ApplicarATodos);
			this.Controls.Add(this.CajaDePosicion);
			this.Controls.Add(this.CajaDeDepartamento);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.CajaDeEmpleado);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.CajaDeMonto);
			this.Controls.Add(this.FechaDeApplicacion);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.CajaDeCodigoDeBonificacion);
			this.Controls.Add(this.ListadoDeBonificaciones);
			this.Controls.Add(this.BtnDeBusqueda);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label14);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Bonificaciones";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BONIFICACIONES";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Bonificaciones_Load);
			((System.ComponentModel.ISupportInitialize)(this.ListadoDeBonificaciones)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnDeBusqueda;
        private System.Windows.Forms.DataGridView ListadoDeBonificaciones;
        private System.Windows.Forms.ComboBox CajaDePosicion;
        private System.Windows.Forms.TextBox CajaDeCodigoDeBonificacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechaDeApplicacion;
        private System.Windows.Forms.TextBox CajaDeMonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CajaDeEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CajaDeDepartamento;
		private System.Windows.Forms.CheckBox ApplicarATodos;
		private System.Windows.Forms.CheckBox ApplicarSoloADepartamento;
		private System.Windows.Forms.CheckBox ApplicarSoloAPosicion;
		private System.Windows.Forms.TextBox CajaDeEmpleadoId;
		private System.Windows.Forms.Button BuscarBonificacion;
		private System.Windows.Forms.Button bntlimpiar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.DateTimePicker FechaDeEmision;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CajaDeTipoDeBonificacion;
		private System.Windows.Forms.Button BtnRefrescar;
	}
}