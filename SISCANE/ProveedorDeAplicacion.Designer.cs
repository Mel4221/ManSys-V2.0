namespace ManSys
{
    partial class ProveedorDeAplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedorDeAplicacion));
            this.ActualizarProveedor = new System.Windows.Forms.Button();
            this.RestoreDefaultBtn = new System.Windows.Forms.Button();
            this.TipoDeProveedor = new System.Windows.Forms.ComboBox();
            this.ConfigurationInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ActualizarProveedor
            // 
            this.ActualizarProveedor.Location = new System.Drawing.Point(439, 39);
            this.ActualizarProveedor.Name = "ActualizarProveedor";
            this.ActualizarProveedor.Size = new System.Drawing.Size(186, 23);
            this.ActualizarProveedor.TabIndex = 1;
            this.ActualizarProveedor.Text = "Actualizar Proveedor";
            this.ActualizarProveedor.UseVisualStyleBackColor = true;
            this.ActualizarProveedor.Click += new System.EventHandler(this.ActualizarProveedor_Click);
            // 
            // RestoreDefaultBtn
            // 
            this.RestoreDefaultBtn.Location = new System.Drawing.Point(439, 68);
            this.RestoreDefaultBtn.Name = "RestoreDefaultBtn";
            this.RestoreDefaultBtn.Size = new System.Drawing.Size(186, 58);
            this.RestoreDefaultBtn.TabIndex = 2;
            this.RestoreDefaultBtn.Text = "Restaurar Valores Predeterminados";
            this.RestoreDefaultBtn.UseVisualStyleBackColor = true;
            this.RestoreDefaultBtn.Click += new System.EventHandler(this.RestoreDefaultBtn_Click);
            // 
            // TipoDeProveedor
            // 
            this.TipoDeProveedor.FormattingEnabled = true;
            this.TipoDeProveedor.Items.AddRange(new object[] {
            "Por API",
            "Por SqlConnectionString"});
            this.TipoDeProveedor.Location = new System.Drawing.Point(439, 12);
            this.TipoDeProveedor.Name = "TipoDeProveedor";
            this.TipoDeProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TipoDeProveedor.Size = new System.Drawing.Size(186, 21);
            this.TipoDeProveedor.TabIndex = 3;
            this.TipoDeProveedor.Text = "Tipo De Proveedor";
            // 
            // ConfigurationInput
            // 
            this.ConfigurationInput.Location = new System.Drawing.Point(12, 12);
            this.ConfigurationInput.Name = "ConfigurationInput";
            this.ConfigurationInput.Size = new System.Drawing.Size(333, 250);
            this.ConfigurationInput.TabIndex = 4;
            this.ConfigurationInput.Text = "";
            // 
            // ProveedorDeAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(637, 277);
            this.Controls.Add(this.ConfigurationInput);
            this.Controls.Add(this.TipoDeProveedor);
            this.Controls.Add(this.RestoreDefaultBtn);
            this.Controls.Add(this.ActualizarProveedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProveedorDeAplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.ProveedorDeAplicacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ActualizarProveedor;
        private System.Windows.Forms.Button RestoreDefaultBtn;
        private System.Windows.Forms.ComboBox TipoDeProveedor;
        private System.Windows.Forms.RichTextBox ConfigurationInput;
    }
}