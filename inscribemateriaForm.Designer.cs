namespace ProyectoFinal
{
    partial class inscribemateriaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtValormateria = new System.Windows.Forms.TextBox();
            this.txtValorestudiante = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.rdbtnNo = new System.Windows.Forms.RadioButton();
            this.rdbtnSi = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvBase = new System.Windows.Forms.DataGridView();
            this.codEstudianteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaInscritaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.universidadDataSetklin1 = new ProyectoFinal.universidadDataSetklin1();
            this.materiaInscritaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universidadDataSet = new ProyectoFinal.universidadDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.codMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtboxMateria = new System.Windows.Forms.TextBox();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCodigomateria = new System.Windows.Forms.Label();
            this.lblCodigoprofesor = new System.Windows.Forms.Label();
            this.cmbCodigoestudiante = new System.Windows.Forms.ComboBox();
            this.cmbCodigomateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaTableAdapter = new ProyectoFinal.universidadDataSetTableAdapters.MateriaTableAdapter();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteTableAdapter = new ProyectoFinal.universidadDataSetTableAdapters.EstudianteTableAdapter();
            this.materia_InscritaTableAdapter = new ProyectoFinal.universidadDataSetTableAdapters.Materia_InscritaTableAdapter();
            this.materiaTableAdapter1 = new ProyectoFinal.universidadDataSetklin1TableAdapters.MateriaTableAdapter();
            this.materia_InscritaTableAdapter1 = new ProyectoFinal.universidadDataSetklin1TableAdapters.Materia_InscritaTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaInscritaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSetklin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaInscritaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtValormateria);
            this.panel2.Controls.Add(this.txtValorestudiante);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnSeleccionar);
            this.panel2.Controls.Add(this.rdbtnNo);
            this.panel2.Controls.Add(this.rdbtnSi);
            this.panel2.Location = new System.Drawing.Point(474, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 206);
            this.panel2.TabIndex = 67;
            // 
            // txtValormateria
            // 
            this.txtValormateria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValormateria.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValormateria.Location = new System.Drawing.Point(15, 122);
            this.txtValormateria.Name = "txtValormateria";
            this.txtValormateria.ReadOnly = true;
            this.txtValormateria.Size = new System.Drawing.Size(275, 25);
            this.txtValormateria.TabIndex = 66;
            // 
            // txtValorestudiante
            // 
            this.txtValorestudiante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorestudiante.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorestudiante.Location = new System.Drawing.Point(15, 64);
            this.txtValorestudiante.Name = "txtValorestudiante";
            this.txtValorestudiante.ReadOnly = true;
            this.txtValorestudiante.Size = new System.Drawing.Size(275, 25);
            this.txtValorestudiante.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 18);
            this.label11.TabIndex = 67;
            this.label11.Text = "Codigo materia seleccionado";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 18);
            this.label9.TabIndex = 65;
            this.label9.Text = "Codigo estudiante seleccionado:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 61;
            this.label8.Text = "Cambios?";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(162, 158);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 34);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(45, 158);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(86, 34);
            this.btnSeleccionar.TabIndex = 11;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // rdbtnNo
            // 
            this.rdbtnNo.AutoSize = true;
            this.rdbtnNo.Checked = true;
            this.rdbtnNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNo.Location = new System.Drawing.Point(104, 17);
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
            this.rdbtnSi.Location = new System.Drawing.Point(153, 17);
            this.rdbtnSi.Name = "rdbtnSi";
            this.rdbtnSi.Size = new System.Drawing.Size(35, 21);
            this.rdbtnSi.TabIndex = 9;
            this.rdbtnSi.Text = "Si";
            this.rdbtnSi.UseVisualStyleBackColor = true;
            this.rdbtnSi.CheckedChanged += new System.EventHandler(this.rdbtnSi_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 24);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(258, 32);
            this.label7.TabIndex = 66;
            this.label7.Text = "INSCRIBIR MATERIAS";
            // 
            // dgvBase
            // 
            this.dgvBase.AllowUserToDeleteRows = false;
            this.dgvBase.AutoGenerateColumns = false;
            this.dgvBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBase.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEstudianteDataGridViewTextBoxColumn,
            this.Cod_materia});
            this.dgvBase.DataSource = this.materiaInscritaBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBase.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBase.EnableHeadersVisualStyles = false;
            this.dgvBase.GridColor = System.Drawing.Color.OrangeRed;
            this.dgvBase.Location = new System.Drawing.Point(118, 313);
            this.dgvBase.MultiSelect = false;
            this.dgvBase.Name = "dgvBase";
            this.dgvBase.ReadOnly = true;
            this.dgvBase.RowHeadersWidth = 51;
            this.dgvBase.RowTemplate.Height = 24;
            this.dgvBase.Size = new System.Drawing.Size(307, 248);
            this.dgvBase.TabIndex = 65;
            // 
            // codEstudianteDataGridViewTextBoxColumn
            // 
            this.codEstudianteDataGridViewTextBoxColumn.DataPropertyName = "Cod_Estudiante";
            this.codEstudianteDataGridViewTextBoxColumn.HeaderText = "Cod_Estudiante";
            this.codEstudianteDataGridViewTextBoxColumn.Name = "codEstudianteDataGridViewTextBoxColumn";
            this.codEstudianteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cod_materia
            // 
            this.Cod_materia.DataPropertyName = "Cod_materia";
            this.Cod_materia.HeaderText = "Cod_materia";
            this.Cod_materia.Name = "Cod_materia";
            this.Cod_materia.ReadOnly = true;
            // 
            // materiaInscritaBindingSource1
            // 
            this.materiaInscritaBindingSource1.DataMember = "Materia_Inscrita";
            this.materiaInscritaBindingSource1.DataSource = this.universidadDataSetklin1;
            // 
            // universidadDataSetklin1
            // 
            this.universidadDataSetklin1.DataSetName = "universidadDataSetklin1";
            this.universidadDataSetklin1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiaInscritaBindingSource
            // 
            this.materiaInscritaBindingSource.DataMember = "Materia_Inscrita";
            this.materiaInscritaBindingSource.DataSource = this.universidadDataSet;
            // 
            // universidadDataSet
            // 
            this.universidadDataSet.DataSetName = "universidadDataSet";
            this.universidadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvMaterias);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtboxMateria);
            this.panel1.Controls.Add(this.btnInscribir);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.txtboxNombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblCodigomateria);
            this.panel1.Controls.Add(this.lblCodigoprofesor);
            this.panel1.Controls.Add(this.cmbCodigoestudiante);
            this.panel1.Controls.Add(this.cmbCodigomateria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(13, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 235);
            this.panel1.TabIndex = 64;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AllowUserToResizeRows = false;
            this.dgvMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaterias.AutoGenerateColumns = false;
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMaterias.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMateriaDataGridViewTextBoxColumn,
            this.nombMateriaDataGridViewTextBoxColumn});
            this.dgvMaterias.DataSource = this.materiaBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterias.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMaterias.EnableHeadersVisualStyles = false;
            this.dgvMaterias.GridColor = System.Drawing.Color.OrangeRed;
            this.dgvMaterias.Location = new System.Drawing.Point(614, 45);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMaterias.Size = new System.Drawing.Size(272, 148);
            this.dgvMaterias.TabIndex = 58;
            // 
            // codMateriaDataGridViewTextBoxColumn
            // 
            this.codMateriaDataGridViewTextBoxColumn.DataPropertyName = "Cod_Materia";
            this.codMateriaDataGridViewTextBoxColumn.HeaderText = "Cod_Materia";
            this.codMateriaDataGridViewTextBoxColumn.Name = "codMateriaDataGridViewTextBoxColumn";
            this.codMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codMateriaDataGridViewTextBoxColumn.Width = 103;
            // 
            // nombMateriaDataGridViewTextBoxColumn
            // 
            this.nombMateriaDataGridViewTextBoxColumn.DataPropertyName = "Nomb_Materia";
            this.nombMateriaDataGridViewTextBoxColumn.HeaderText = "Nomb_Materia";
            this.nombMateriaDataGridViewTextBoxColumn.Name = "nombMateriaDataGridViewTextBoxColumn";
            this.nombMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombMateriaDataGridViewTextBoxColumn.Width = 114;
            // 
            // materiaBindingSource1
            // 
            this.materiaBindingSource1.DataMember = "Materia";
            this.materiaBindingSource1.DataSource = this.universidadDataSetklin1;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(17, 188);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(275, 25);
            this.txtApellido.TabIndex = 55;
            // 
            // txtboxMateria
            // 
            this.txtboxMateria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxMateria.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMateria.Location = new System.Drawing.Point(326, 139);
            this.txtboxMateria.Name = "txtboxMateria";
            this.txtboxMateria.ReadOnly = true;
            this.txtboxMateria.Size = new System.Drawing.Size(266, 25);
            this.txtboxMateria.TabIndex = 55;
            // 
            // btnInscribir
            // 
            this.btnInscribir.BackColor = System.Drawing.Color.PeachPuff;
            this.btnInscribir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInscribir.FlatAppearance.BorderSize = 0;
            this.btnInscribir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnInscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribir.Location = new System.Drawing.Point(331, 188);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(96, 34);
            this.btnInscribir.TabIndex = 3;
            this.btnInscribir.Text = "Asignar";
            this.btnInscribir.UseVisualStyleBackColor = false;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(444, 188);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 34);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxNombre.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNombre.Location = new System.Drawing.Point(17, 128);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.ReadOnly = true;
            this.txtboxNombre.Size = new System.Drawing.Size(275, 25);
            this.txtboxNombre.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "Apellido estudiante:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "MATERIA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Nombre estudiante:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 56;
            this.label6.Text = "Materia:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 66;
            this.label10.Text = "PROFESOR:";
            // 
            // lblCodigomateria
            // 
            this.lblCodigomateria.AutoSize = true;
            this.lblCodigomateria.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigomateria.Location = new System.Drawing.Point(433, 72);
            this.lblCodigomateria.Name = "lblCodigomateria";
            this.lblCodigomateria.Size = new System.Drawing.Size(159, 18);
            this.lblCodigomateria.TabIndex = 69;
            this.lblCodigomateria.Text = "<==Seleccione un código";
            this.lblCodigomateria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCodigoprofesor
            // 
            this.lblCodigoprofesor.AutoSize = true;
            this.lblCodigoprofesor.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoprofesor.Location = new System.Drawing.Point(122, 67);
            this.lblCodigoprofesor.Name = "lblCodigoprofesor";
            this.lblCodigoprofesor.Size = new System.Drawing.Size(159, 18);
            this.lblCodigoprofesor.TabIndex = 69;
            this.lblCodigoprofesor.Text = "<==Seleccione un código";
            this.lblCodigoprofesor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cmbCodigoestudiante
            // 
            this.cmbCodigoestudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoestudiante.FormattingEnabled = true;
            this.cmbCodigoestudiante.Location = new System.Drawing.Point(16, 65);
            this.cmbCodigoestudiante.Name = "cmbCodigoestudiante";
            this.cmbCodigoestudiante.Size = new System.Drawing.Size(100, 23);
            this.cmbCodigoestudiante.TabIndex = 67;
            this.cmbCodigoestudiante.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoestudiante_SelectedIndexChanged);
            // 
            // cmbCodigomateria
            // 
            this.cmbCodigomateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigomateria.FormattingEnabled = true;
            this.cmbCodigomateria.Location = new System.Drawing.Point(327, 70);
            this.cmbCodigomateria.Name = "cmbCodigomateria";
            this.cmbCodigomateria.Size = new System.Drawing.Size(100, 23);
            this.cmbCodigomateria.TabIndex = 67;
            this.cmbCodigomateria.SelectedIndexChanged += new System.EventHandler(this.cmbCodigomateria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 68;
            this.label1.Text = "Codigo de Estudiante:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 68;
            this.label4.Text = "Codigo de Materia:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::ProyectoFinal.Properties.Resources.BotonSalir2;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(858, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(54, 44);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "Materia";
            this.materiaBindingSource.DataSource = this.universidadDataSet;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "Estudiante";
            this.estudianteBindingSource.DataSource = this.universidadDataSet;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // materia_InscritaTableAdapter
            // 
            this.materia_InscritaTableAdapter.ClearBeforeFill = true;
            // 
            // materiaTableAdapter1
            // 
            this.materiaTableAdapter1.ClearBeforeFill = true;
            // 
            // materia_InscritaTableAdapter1
            // 
            this.materia_InscritaTableAdapter1.ClearBeforeFill = true;
            // 
            // inscribemateriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.fondo33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvBase);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "inscribemateriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscribir Materia";
            this.Load += new System.EventHandler(this.inscribemateriaForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaInscritaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSetklin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaInscritaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtValormateria;
        private System.Windows.Forms.TextBox txtValorestudiante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.RadioButton rdbtnNo;
        private System.Windows.Forms.RadioButton rdbtnSi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvBase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtboxMateria;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCodigomateria;
        private System.Windows.Forms.Label lblCodigoprofesor;
        private System.Windows.Forms.ComboBox cmbCodigoestudiante;
        private System.Windows.Forms.ComboBox cmbCodigomateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private universidadDataSet universidadDataSet;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private universidadDataSetTableAdapters.MateriaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private universidadDataSetTableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private System.Windows.Forms.BindingSource materiaInscritaBindingSource;
        private universidadDataSetTableAdapters.Materia_InscritaTableAdapter materia_InscritaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEstudianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_materia;
        private universidadDataSetklin1 universidadDataSetklin1;
        private System.Windows.Forms.BindingSource materiaBindingSource1;
        private universidadDataSetklin1TableAdapters.MateriaTableAdapter materiaTableAdapter1;
        private System.Windows.Forms.BindingSource materiaInscritaBindingSource1;
        private universidadDataSetklin1TableAdapters.Materia_InscritaTableAdapter materia_InscritaTableAdapter1;
    }
}