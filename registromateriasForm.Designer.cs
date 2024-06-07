namespace ProyectoFinal
{
    partial class registromateriasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBase = new System.Windows.Forms.DataGridView();
            this.codMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDeptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.universidadDataSetklin1 = new ProyectoFinal.universidadDataSetklin1();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universidadDataSet = new ProyectoFinal.universidadDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbtnNo = new System.Windows.Forms.RadioButton();
            this.rdbtnSi = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtboxUV = new System.Windows.Forms.Label();
            this.apellidoTextbox = new System.Windows.Forms.TextBox();
            this.lblCodigodepartamento = new System.Windows.Forms.Label();
            this.cmbCodigodepartamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxCodigomateria = new System.Windows.Forms.TextBox();
            this.txtboxNombremateria = new System.Windows.Forms.Label();
            this.nombreTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.materiaTableAdapter = new ProyectoFinal.universidadDataSetTableAdapters.MateriaTableAdapter();
            this.materiaTableAdapter1 = new ProyectoFinal.universidadDataSetklin1TableAdapters.MateriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSetklin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBase
            // 
            this.dgvBase.AutoGenerateColumns = false;
            this.dgvBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBase.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMateriaDataGridViewTextBoxColumn,
            this.nombMateriaDataGridViewTextBoxColumn,
            this.uVDataGridViewTextBoxColumn,
            this.codDeptoDataGridViewTextBoxColumn});
            this.dgvBase.DataSource = this.materiaBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBase.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBase.EnableHeadersVisualStyles = false;
            this.dgvBase.GridColor = System.Drawing.Color.OrangeRed;
            this.dgvBase.Location = new System.Drawing.Point(14, 437);
            this.dgvBase.Name = "dgvBase";
            this.dgvBase.ReadOnly = true;
            this.dgvBase.RowHeadersWidth = 51;
            this.dgvBase.RowTemplate.Height = 24;
            this.dgvBase.Size = new System.Drawing.Size(716, 187);
            this.dgvBase.TabIndex = 64;
            // 
            // codMateriaDataGridViewTextBoxColumn
            // 
            this.codMateriaDataGridViewTextBoxColumn.DataPropertyName = "Cod_Materia";
            this.codMateriaDataGridViewTextBoxColumn.HeaderText = "Cod_Materia";
            this.codMateriaDataGridViewTextBoxColumn.Name = "codMateriaDataGridViewTextBoxColumn";
            this.codMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombMateriaDataGridViewTextBoxColumn
            // 
            this.nombMateriaDataGridViewTextBoxColumn.DataPropertyName = "Nomb_Materia";
            this.nombMateriaDataGridViewTextBoxColumn.HeaderText = "Nomb_Materia";
            this.nombMateriaDataGridViewTextBoxColumn.Name = "nombMateriaDataGridViewTextBoxColumn";
            this.nombMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uVDataGridViewTextBoxColumn
            // 
            this.uVDataGridViewTextBoxColumn.DataPropertyName = "UV";
            this.uVDataGridViewTextBoxColumn.HeaderText = "UV";
            this.uVDataGridViewTextBoxColumn.Name = "uVDataGridViewTextBoxColumn";
            this.uVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codDeptoDataGridViewTextBoxColumn
            // 
            this.codDeptoDataGridViewTextBoxColumn.DataPropertyName = "Cod_Depto";
            this.codDeptoDataGridViewTextBoxColumn.HeaderText = "Cod_Depto";
            this.codDeptoDataGridViewTextBoxColumn.Name = "codDeptoDataGridViewTextBoxColumn";
            this.codDeptoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materiaBindingSource1
            // 
            this.materiaBindingSource1.DataMember = "Materia";
            this.materiaBindingSource1.DataSource = this.universidadDataSetklin1;
            // 
            // universidadDataSetklin1
            // 
            this.universidadDataSetklin1.DataSetName = "universidadDataSetklin1";
            this.universidadDataSetklin1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "Materia";
            this.materiaBindingSource.DataSource = this.universidadDataSet;
            // 
            // universidadDataSet
            // 
            this.universidadDataSet.DataSetName = "universidadDataSet";
            this.universidadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtIdBuscar);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.btnSeleccionar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.rdbtnNo);
            this.panel2.Controls.Add(this.rdbtnSi);
            this.panel2.Location = new System.Drawing.Point(439, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 159);
            this.panel2.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 61;
            this.label7.Text = "Cambios?";
            // 
            // txtIdBuscar
            // 
            this.txtIdBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdBuscar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBuscar.Location = new System.Drawing.Point(15, 100);
            this.txtIdBuscar.Name = "txtIdBuscar";
            this.txtIdBuscar.Size = new System.Drawing.Size(135, 24);
            this.txtIdBuscar.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(164, 96);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 34);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(164, 54);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(108, 34);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Modificar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(164, 12);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(108, 34);
            this.btnSeleccionar.TabIndex = 11;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Buscar por código:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdbtnNo
            // 
            this.rdbtnNo.AutoSize = true;
            this.rdbtnNo.Checked = true;
            this.rdbtnNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNo.Location = new System.Drawing.Point(16, 35);
            this.rdbtnNo.Name = "rdbtnNo";
            this.rdbtnNo.Size = new System.Drawing.Size(42, 21);
            this.rdbtnNo.TabIndex = 8;
            this.rdbtnNo.TabStop = true;
            this.rdbtnNo.Text = "No";
            this.rdbtnNo.UseVisualStyleBackColor = true;
            this.rdbtnNo.CheckedChanged += new System.EventHandler(this.rdbtnNo_CheckedChanged);
            // 
            // rdbtnSi
            // 
            this.rdbtnSi.AutoSize = true;
            this.rdbtnSi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSi.Location = new System.Drawing.Point(81, 35);
            this.rdbtnSi.Name = "rdbtnSi";
            this.rdbtnSi.Size = new System.Drawing.Size(35, 21);
            this.rdbtnSi.TabIndex = 9;
            this.rdbtnSi.Text = "Si";
            this.rdbtnSi.UseVisualStyleBackColor = true;
            this.rdbtnSi.CheckedChanged += new System.EventHandler(this.rdbtnSi_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtboxUV);
            this.panel1.Controls.Add(this.apellidoTextbox);
            this.panel1.Controls.Add(this.lblCodigodepartamento);
            this.panel1.Controls.Add(this.cmbCodigodepartamento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtboxCodigomateria);
            this.panel1.Controls.Add(this.txtboxNombremateria);
            this.panel1.Controls.Add(this.nombreTextbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Location = new System.Drawing.Point(14, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 361);
            this.panel1.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 62;
            this.label9.Text = "Detalle:";
            // 
            // txtboxUV
            // 
            this.txtboxUV.AutoSize = true;
            this.txtboxUV.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUV.Location = new System.Drawing.Point(17, 161);
            this.txtboxUV.Name = "txtboxUV";
            this.txtboxUV.Size = new System.Drawing.Size(171, 18);
            this.txtboxUV.TabIndex = 58;
            this.txtboxUV.Text = "Unidades Valorativas (UV):";
            this.txtboxUV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // apellidoTextbox
            // 
            this.apellidoTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apellidoTextbox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextbox.Location = new System.Drawing.Point(17, 186);
            this.apellidoTextbox.Name = "apellidoTextbox";
            this.apellidoTextbox.Size = new System.Drawing.Size(360, 25);
            this.apellidoTextbox.TabIndex = 3;
            // 
            // lblCodigodepartamento
            // 
            this.lblCodigodepartamento.AutoSize = true;
            this.lblCodigodepartamento.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigodepartamento.Location = new System.Drawing.Point(123, 254);
            this.lblCodigodepartamento.Name = "lblCodigodepartamento";
            this.lblCodigodepartamento.Size = new System.Drawing.Size(159, 18);
            this.lblCodigodepartamento.TabIndex = 53;
            this.lblCodigodepartamento.Text = "<==Seleccione un código";
            this.lblCodigodepartamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cmbCodigodepartamento
            // 
            this.cmbCodigodepartamento.BackColor = System.Drawing.Color.White;
            this.cmbCodigodepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigodepartamento.FormattingEnabled = true;
            this.cmbCodigodepartamento.Location = new System.Drawing.Point(17, 252);
            this.cmbCodigodepartamento.Name = "cmbCodigodepartamento";
            this.cmbCodigodepartamento.Size = new System.Drawing.Size(100, 23);
            this.cmbCodigodepartamento.TabIndex = 4;
            this.cmbCodigodepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbCodigodepartamento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Codigo de Departamento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtboxCodigomateria
            // 
            this.txtboxCodigomateria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxCodigomateria.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCodigomateria.Location = new System.Drawing.Point(17, 59);
            this.txtboxCodigomateria.Name = "txtboxCodigomateria";
            this.txtboxCodigomateria.Size = new System.Drawing.Size(360, 25);
            this.txtboxCodigomateria.TabIndex = 1;
            // 
            // txtboxNombremateria
            // 
            this.txtboxNombremateria.AutoSize = true;
            this.txtboxNombremateria.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNombremateria.Location = new System.Drawing.Point(17, 98);
            this.txtboxNombremateria.Name = "txtboxNombremateria";
            this.txtboxNombremateria.Size = new System.Drawing.Size(147, 18);
            this.txtboxNombremateria.TabIndex = 43;
            this.txtboxNombremateria.Text = "Nombre de la materia:";
            this.txtboxNombremateria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nombreTextbox
            // 
            this.nombreTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreTextbox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextbox.Location = new System.Drawing.Point(17, 123);
            this.nombreTextbox.Name = "nombreTextbox";
            this.nombreTextbox.Size = new System.Drawing.Size(360, 25);
            this.nombreTextbox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Codigo de Materia:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ProyectoFinal.Properties.Resources.botonGuardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(115, 303);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(49, 42);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::ProyectoFinal.Properties.Resources.botonLimpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(196, 303);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(64, 42);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::ProyectoFinal.Properties.Resources.BotonSalir2;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(693, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 36);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 24);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(225, 30);
            this.label2.TabIndex = 61;
            this.label2.Text = "REGISTRO MATERIAS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // materiaTableAdapter1
            // 
            this.materiaTableAdapter1.ClearBeforeFill = true;
            // 
            // registromateriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.fondo33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 641);
            this.Controls.Add(this.dgvBase);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "registromateriasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Materias";
            this.Load += new System.EventHandler(this.registromateriasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSetklin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbtnNo;
        private System.Windows.Forms.RadioButton rdbtnSi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtboxUV;
        private System.Windows.Forms.TextBox apellidoTextbox;
        private System.Windows.Forms.Label lblCodigodepartamento;
        private System.Windows.Forms.ComboBox cmbCodigodepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxCodigomateria;
        private System.Windows.Forms.Label txtboxNombremateria;
        private System.Windows.Forms.TextBox nombreTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private universidadDataSet universidadDataSet;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private universidadDataSetTableAdapters.MateriaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDeptoDataGridViewTextBoxColumn;
        private universidadDataSetklin1 universidadDataSetklin1;
        private System.Windows.Forms.BindingSource materiaBindingSource1;
        private universidadDataSetklin1TableAdapters.MateriaTableAdapter materiaTableAdapter1;
    }
}