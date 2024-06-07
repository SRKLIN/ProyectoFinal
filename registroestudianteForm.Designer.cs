namespace ProyectoFinal
{
    partial class registroestudianteForm
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
            this.dgvBDEstudiante = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estudianteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.universidadDataSetklin1 = new ProyectoFinal.universidadDataSetklin1();
            this.estudianteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.universidadDataSet = new ProyectoFinal.universidadDataSet();
            this.estudianteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.lblCarrera = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCodigoCarrera = new System.Windows.Forms.ComboBox();
            this.apellidoTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.codigoestudianteTextbox = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nombreTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.estudianteTableAdapter1 = new ProyectoFinal.universidadDataSetTableAdapters.EstudianteTableAdapter();
            this.estudianteTableAdapter = new ProyectoFinal.universidadDataSetklin1TableAdapters.EstudianteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSetklin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBDEstudiante
            // 
            this.dgvBDEstudiante.AllowUserToAddRows = false;
            this.dgvBDEstudiante.AllowUserToDeleteRows = false;
            this.dgvBDEstudiante.AutoGenerateColumns = false;
            this.dgvBDEstudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBDEstudiante.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvBDEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBDEstudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBDEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBDEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvBDEstudiante.DataSource = this.estudianteBindingSource3;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBDEstudiante.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBDEstudiante.EnableHeadersVisualStyles = false;
            this.dgvBDEstudiante.GridColor = System.Drawing.Color.OrangeRed;
            this.dgvBDEstudiante.Location = new System.Drawing.Point(12, 397);
            this.dgvBDEstudiante.Name = "dgvBDEstudiante";
            this.dgvBDEstudiante.ReadOnly = true;
            this.dgvBDEstudiante.RowHeadersWidth = 51;
            this.dgvBDEstudiante.RowTemplate.Height = 24;
            this.dgvBDEstudiante.Size = new System.Drawing.Size(716, 215);
            this.dgvBDEstudiante.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Estudiante";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod_Estudiante";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nomb_Estudiante";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nomb_Estudiante";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ape_Estudiante";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ape_Estudiante";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cod_Carrera";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cod_Carrera";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // estudianteBindingSource3
            // 
            this.estudianteBindingSource3.DataMember = "Estudiante";
            this.estudianteBindingSource3.DataSource = this.universidadDataSetklin1;
            // 
            // universidadDataSetklin1
            // 
            this.universidadDataSetklin1.DataSetName = "universidadDataSetklin1";
            this.universidadDataSetklin1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudianteBindingSource2
            // 
            this.estudianteBindingSource2.DataMember = "Estudiante";
            this.estudianteBindingSource2.DataSource = this.universidadDataSet;
            // 
            // universidadDataSet
            // 
            this.universidadDataSet.DataSetName = "universidadDataSet";
            this.universidadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudianteBindingSource1
            // 
            this.estudianteBindingSource1.DataMember = "Estudiante";
            this.estudianteBindingSource1.DataSource = this.universidadDataSet;
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
            this.panel2.Location = new System.Drawing.Point(437, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 163);
            this.panel2.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 64;
            this.label7.Text = "Cambios?";
            // 
            // txtIdBuscar
            // 
            this.txtIdBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdBuscar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBuscar.Location = new System.Drawing.Point(16, 99);
            this.txtIdBuscar.Name = "txtIdBuscar";
            this.txtIdBuscar.ReadOnly = true;
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
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(161, 103);
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
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(161, 61);
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
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(161, 19);
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
            this.label8.Location = new System.Drawing.Point(12, 69);
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
            this.rdbtnNo.Location = new System.Drawing.Point(21, 26);
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
            this.rdbtnSi.Location = new System.Drawing.Point(86, 26);
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
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblCarrera);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbCodigoCarrera);
            this.panel1.Controls.Add(this.apellidoTextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.codigoestudianteTextbox);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nombreTextbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 318);
            this.panel1.TabIndex = 54;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 65;
            this.label9.Text = "Detalle:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(124, 230);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(159, 18);
            this.lblCarrera.TabIndex = 62;
            this.lblCarrera.Text = "<==Seleccione un código";
            this.lblCarrera.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "Apellido del/la Estudiante";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cmbCodigoCarrera
            // 
            this.cmbCodigoCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoCarrera.FormattingEnabled = true;
            this.cmbCodigoCarrera.Location = new System.Drawing.Point(18, 228);
            this.cmbCodigoCarrera.Name = "cmbCodigoCarrera";
            this.cmbCodigoCarrera.Size = new System.Drawing.Size(100, 25);
            this.cmbCodigoCarrera.TabIndex = 4;
            this.cmbCodigoCarrera.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoCarrera_SelectedIndexChanged_1);
            // 
            // apellidoTextbox
            // 
            this.apellidoTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apellidoTextbox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextbox.Location = new System.Drawing.Point(18, 171);
            this.apellidoTextbox.Name = "apellidoTextbox";
            this.apellidoTextbox.Size = new System.Drawing.Size(360, 25);
            this.apellidoTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 61;
            this.label1.Text = "Codigo deCarrera:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = global::ProyectoFinal.Properties.Resources.botonGuardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(89, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(45, 34);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // codigoestudianteTextbox
            // 
            this.codigoestudianteTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoestudianteTextbox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoestudianteTextbox.Location = new System.Drawing.Point(18, 43);
            this.codigoestudianteTextbox.Name = "codigoestudianteTextbox";
            this.codigoestudianteTextbox.Size = new System.Drawing.Size(360, 25);
            this.codigoestudianteTextbox.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = global::ProyectoFinal.Properties.Resources.botonLimpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(199, 272);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(46, 34);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nombre del/la Estudiante";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nombreTextbox
            // 
            this.nombreTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreTextbox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextbox.Location = new System.Drawing.Point(18, 108);
            this.nombreTextbox.Name = "nombreTextbox";
            this.nombreTextbox.Size = new System.Drawing.Size(360, 25);
            this.nombreTextbox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Código de Estudiante:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnCancelar.Location = new System.Drawing.Point(683, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 34);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 30);
            this.label2.TabIndex = 53;
            this.label2.Text = "REGISTRO ESTUDIANTE";
            // 
            // estudianteTableAdapter1
            // 
            this.estudianteTableAdapter1.ClearBeforeFill = true;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // registroestudianteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.fondo33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 629);
            this.Controls.Add(this.dgvBDEstudiante);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "registroestudianteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Estudiante";
            this.Load += new System.EventHandler(this.registroestudianteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSetklin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBDEstudiante;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIdBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbtnNo;
        private System.Windows.Forms.RadioButton rdbtnSi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox codigoestudianteTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombreTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox apellidoTextbox;
       // private universidadDataSetKLIN universidadDataSetKLIN;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
       // private universidadDataSetKLINTableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEstudianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombEstudianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeEstudianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCarreraDataGridViewTextBoxColumn;
        private universidadDataSet universidadDataSet;
        private System.Windows.Forms.BindingSource estudianteBindingSource1;
        private universidadDataSetTableAdapters.EstudianteTableAdapter estudianteTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cmbCodigoCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource estudianteBindingSource2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private universidadDataSetklin1 universidadDataSetklin1;
        private System.Windows.Forms.BindingSource estudianteBindingSource3;
        private universidadDataSetklin1TableAdapters.EstudianteTableAdapter estudianteTableAdapter;
    }
}