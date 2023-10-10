namespace SISCANE
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoOcupadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioBaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDeCobroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDePagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasNormalesTrabajadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioXHorasNormalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasExtraTrabajadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioXHorasExtraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoAPagarPorHorasNormalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoAPagarPorHorasExtraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDeAsignacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguroMédicoARSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguroDePensiónAFPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoNetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantenimientodeNominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISCANEDataSet = new SISCANE.SISCANEDataSet();
            this.mantenimiento_de_NominaTableAdapter = new SISCANE.SISCANEDataSetTableAdapters.Mantenimiento_de_NominaTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientodeNominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCANEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Seleccionar fecha de Pago";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(854, 25);
            this.bindingNavigator1.TabIndex = 52;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(439, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "Reporte de Nomina";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(645, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 32);
            this.button1.TabIndex = 49;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "";
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.puestoOcupadoDataGridViewTextBoxColumn,
            this.salarioBaseDataGridViewTextBoxColumn,
            this.tipoDeCobroDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn,
            this.fechaDePagoDataGridViewTextBoxColumn,
            this.horasNormalesTrabajadasDataGridViewTextBoxColumn,
            this.precioXHorasNormalesDataGridViewTextBoxColumn,
            this.horasExtraTrabajadasDataGridViewTextBoxColumn,
            this.precioXHorasExtraDataGridViewTextBoxColumn,
            this.montoAPagarPorHorasNormalesDataGridViewTextBoxColumn,
            this.montoAPagarPorHorasExtraDataGridViewTextBoxColumn,
            this.totalDeAsignacionesDataGridViewTextBoxColumn,
            this.seguroMédicoARSDataGridViewTextBoxColumn,
            this.seguroDePensiónAFPDataGridViewTextBoxColumn,
            this.sueldoNetoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mantenimientodeNominaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(821, 276);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.Tag = "";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombre(s)";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombre(s)";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellido(s)";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellido(s)";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // puestoOcupadoDataGridViewTextBoxColumn
            // 
            this.puestoOcupadoDataGridViewTextBoxColumn.DataPropertyName = "Puesto Ocupado";
            this.puestoOcupadoDataGridViewTextBoxColumn.HeaderText = "Puesto Ocupado";
            this.puestoOcupadoDataGridViewTextBoxColumn.Name = "puestoOcupadoDataGridViewTextBoxColumn";
            // 
            // salarioBaseDataGridViewTextBoxColumn
            // 
            this.salarioBaseDataGridViewTextBoxColumn.DataPropertyName = "Salario Base";
            this.salarioBaseDataGridViewTextBoxColumn.HeaderText = "Salario Base";
            this.salarioBaseDataGridViewTextBoxColumn.Name = "salarioBaseDataGridViewTextBoxColumn";
            // 
            // tipoDeCobroDataGridViewTextBoxColumn
            // 
            this.tipoDeCobroDataGridViewTextBoxColumn.DataPropertyName = "Tipo de Cobro";
            this.tipoDeCobroDataGridViewTextBoxColumn.HeaderText = "Tipo de Cobro";
            this.tipoDeCobroDataGridViewTextBoxColumn.Name = "tipoDeCobroDataGridViewTextBoxColumn";
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            // 
            // fechaDePagoDataGridViewTextBoxColumn
            // 
            this.fechaDePagoDataGridViewTextBoxColumn.DataPropertyName = "Fecha de Pago";
            this.fechaDePagoDataGridViewTextBoxColumn.HeaderText = "Fecha de Pago";
            this.fechaDePagoDataGridViewTextBoxColumn.Name = "fechaDePagoDataGridViewTextBoxColumn";
            // 
            // horasNormalesTrabajadasDataGridViewTextBoxColumn
            // 
            this.horasNormalesTrabajadasDataGridViewTextBoxColumn.DataPropertyName = "Horas Normales Trabajadas";
            this.horasNormalesTrabajadasDataGridViewTextBoxColumn.HeaderText = "Horas Normales Trabajadas";
            this.horasNormalesTrabajadasDataGridViewTextBoxColumn.Name = "horasNormalesTrabajadasDataGridViewTextBoxColumn";
            // 
            // precioXHorasNormalesDataGridViewTextBoxColumn
            // 
            this.precioXHorasNormalesDataGridViewTextBoxColumn.DataPropertyName = "Precio x Horas Normales";
            this.precioXHorasNormalesDataGridViewTextBoxColumn.HeaderText = "Precio x Horas Normales";
            this.precioXHorasNormalesDataGridViewTextBoxColumn.Name = "precioXHorasNormalesDataGridViewTextBoxColumn";
            // 
            // horasExtraTrabajadasDataGridViewTextBoxColumn
            // 
            this.horasExtraTrabajadasDataGridViewTextBoxColumn.DataPropertyName = "Horas Extra Trabajadas";
            this.horasExtraTrabajadasDataGridViewTextBoxColumn.HeaderText = "Horas Extra Trabajadas";
            this.horasExtraTrabajadasDataGridViewTextBoxColumn.Name = "horasExtraTrabajadasDataGridViewTextBoxColumn";
            // 
            // precioXHorasExtraDataGridViewTextBoxColumn
            // 
            this.precioXHorasExtraDataGridViewTextBoxColumn.DataPropertyName = "Precio x Horas Extra";
            this.precioXHorasExtraDataGridViewTextBoxColumn.HeaderText = "Precio x Horas Extra";
            this.precioXHorasExtraDataGridViewTextBoxColumn.Name = "precioXHorasExtraDataGridViewTextBoxColumn";
            // 
            // montoAPagarPorHorasNormalesDataGridViewTextBoxColumn
            // 
            this.montoAPagarPorHorasNormalesDataGridViewTextBoxColumn.DataPropertyName = "Monto a Pagar por Horas Normales";
            this.montoAPagarPorHorasNormalesDataGridViewTextBoxColumn.HeaderText = "Monto a Pagar por Horas Normales";
            this.montoAPagarPorHorasNormalesDataGridViewTextBoxColumn.Name = "montoAPagarPorHorasNormalesDataGridViewTextBoxColumn";
            // 
            // montoAPagarPorHorasExtraDataGridViewTextBoxColumn
            // 
            this.montoAPagarPorHorasExtraDataGridViewTextBoxColumn.DataPropertyName = "Monto a Pagar por Horas Extra";
            this.montoAPagarPorHorasExtraDataGridViewTextBoxColumn.HeaderText = "Monto a Pagar por Horas Extra";
            this.montoAPagarPorHorasExtraDataGridViewTextBoxColumn.Name = "montoAPagarPorHorasExtraDataGridViewTextBoxColumn";
            // 
            // totalDeAsignacionesDataGridViewTextBoxColumn
            // 
            this.totalDeAsignacionesDataGridViewTextBoxColumn.DataPropertyName = "Total de Asignaciones";
            this.totalDeAsignacionesDataGridViewTextBoxColumn.HeaderText = "Total de Asignaciones";
            this.totalDeAsignacionesDataGridViewTextBoxColumn.Name = "totalDeAsignacionesDataGridViewTextBoxColumn";
            // 
            // seguroMédicoARSDataGridViewTextBoxColumn
            // 
            this.seguroMédicoARSDataGridViewTextBoxColumn.DataPropertyName = "Seguro Médico(ARS)";
            this.seguroMédicoARSDataGridViewTextBoxColumn.HeaderText = "Seguro Médico(ARS)";
            this.seguroMédicoARSDataGridViewTextBoxColumn.Name = "seguroMédicoARSDataGridViewTextBoxColumn";
            // 
            // seguroDePensiónAFPDataGridViewTextBoxColumn
            // 
            this.seguroDePensiónAFPDataGridViewTextBoxColumn.DataPropertyName = "Seguro de Pensión(AFP)";
            this.seguroDePensiónAFPDataGridViewTextBoxColumn.HeaderText = "Seguro de Pensión(AFP)";
            this.seguroDePensiónAFPDataGridViewTextBoxColumn.Name = "seguroDePensiónAFPDataGridViewTextBoxColumn";
            // 
            // sueldoNetoDataGridViewTextBoxColumn
            // 
            this.sueldoNetoDataGridViewTextBoxColumn.DataPropertyName = "Sueldo Neto";
            this.sueldoNetoDataGridViewTextBoxColumn.HeaderText = "Sueldo Neto";
            this.sueldoNetoDataGridViewTextBoxColumn.Name = "sueldoNetoDataGridViewTextBoxColumn";
            // 
            // mantenimientodeNominaBindingSource
            // 
            this.mantenimientodeNominaBindingSource.DataMember = "Mantenimiento_de_Nomina";
            this.mantenimientodeNominaBindingSource.DataSource = this.sISCANEDataSet;
            // 
            // sISCANEDataSet
            // 
            this.sISCANEDataSet.DataSetName = "SISCANEDataSet";
            this.sISCANEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mantenimiento_de_NominaTableAdapter
            // 
            this.mantenimiento_de_NominaTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(654, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 24);
            this.button2.TabIndex = 108;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(854, 428);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Nomina";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form9_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientodeNominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCANEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SISCANEDataSet sISCANEDataSet;
        private System.Windows.Forms.BindingSource mantenimientodeNominaBindingSource;
        private SISCANEDataSetTableAdapters.Mantenimiento_de_NominaTableAdapter mantenimiento_de_NominaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestoOcupadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioBaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDeCobroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDePagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasNormalesTrabajadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioXHorasNormalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasExtraTrabajadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioXHorasExtraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoAPagarPorHorasNormalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoAPagarPorHorasExtraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDeAsignacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seguroMédicoARSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seguroDePensiónAFPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoNetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}