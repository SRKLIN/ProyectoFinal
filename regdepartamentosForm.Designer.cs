namespace ProyectoFinal
{
    partial class regdepartamentoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdBuscar = new System.Windows.Forms.TextBox();
            this.rdbtnSi = new System.Windows.Forms.RadioButton();
            this.rdbtnNo = new System.Windows.Forms.RadioButton();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.codigodepartamentoTextbox = new System.Windows.Forms.TextBox();
            this.nombredepartamentoTextBox = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBase = new System.Windows.Forms.DataGridView();
            this.codDeptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDeptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.universidadDataSetklin1 = new ProyectoFinal.universidadDataSetklin1();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universidadDataSet = new ProyectoFinal.universidadDataSet();
            this.departamentoTableAdapter = new ProyectoFinal.universidadDataSetTableAdapters.DepartamentoTableAdapter();
            this.departamentoTableAdapter1 = new ProyectoFinal.universidadDataSetklin1TableAdapters.DepartamentoTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSetklin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(287, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "REGISTRO DEPARTAMENTO";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(161, 119);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 34);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Buscar por código:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdBuscar
            // 
            this.txtIdBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdBuscar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBuscar.Location = new System.Drawing.Point(16, 119);
            this.txtIdBuscar.Name = "txtIdBuscar";
            this.txtIdBuscar.Size = new System.Drawing.Size(135, 24);
            this.txtIdBuscar.TabIndex = 8;
            // 
            // rdbtnSi
            // 
            this.rdbtnSi.AutoSize = true;
            this.rdbtnSi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSi.Location = new System.Drawing.Point(84, 39);
            this.rdbtnSi.Name = "rdbtnSi";
            this.rdbtnSi.Size = new System.Drawing.Size(35, 21);
            this.rdbtnSi.TabIndex = 7;
            this.rdbtnSi.Text = "Si";
            this.rdbtnSi.UseVisualStyleBackColor = true;
            this.rdbtnSi.CheckedChanged += new System.EventHandler(this.rdbtnSi_CheckedChanged);
            // 
            // rdbtnNo
            // 
            this.rdbtnNo.AutoSize = true;
            this.rdbtnNo.Checked = true;
            this.rdbtnNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNo.Location = new System.Drawing.Point(16, 39);
            this.rdbtnNo.Name = "rdbtnNo";
            this.rdbtnNo.Size = new System.Drawing.Size(42, 21);
            this.rdbtnNo.TabIndex = 6;
            this.rdbtnNo.TabStop = true;
            this.rdbtnNo.Text = "No";
            this.rdbtnNo.UseVisualStyleBackColor = true;
            this.rdbtnNo.CheckedChanged += new System.EventHandler(this.rdbtnNo_CheckedChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(161, 77);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(108, 34);
            this.btnActualizar.TabIndex = 10;
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
            this.btnSeleccionar.Location = new System.Drawing.Point(161, 35);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(108, 34);
            this.btnSeleccionar.TabIndex = 9;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // codigodepartamentoTextbox
            // 
            this.codigodepartamentoTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigodepartamentoTextbox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigodepartamentoTextbox.Location = new System.Drawing.Point(17, 60);
            this.codigodepartamentoTextbox.Name = "codigodepartamentoTextbox";
            this.codigodepartamentoTextbox.Size = new System.Drawing.Size(360, 25);
            this.codigodepartamentoTextbox.TabIndex = 1;
            // 
            // nombredepartamentoTextBox
            // 
            this.nombredepartamentoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombredepartamentoTextBox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombredepartamentoTextBox.Location = new System.Drawing.Point(17, 126);
            this.nombredepartamentoTextBox.Name = "nombredepartamentoTextBox";
            this.nombredepartamentoTextBox.Size = new System.Drawing.Size(360, 25);
            this.nombredepartamentoTextBox.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ProyectoFinal.Properties.Resources.botonGuardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(86, 176);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(45, 34);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(697, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(52, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::ProyectoFinal.Properties.Resources.botonLimpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(176, 176);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(54, 34);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Código de departamento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nombre del departamento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.codigodepartamentoTextbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nombredepartamentoTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Location = new System.Drawing.Point(20, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 237);
            this.panel1.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 63;
            this.label7.Text = "Detalle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtIdBuscar);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.btnSeleccionar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.rdbtnNo);
            this.panel2.Controls.Add(this.rdbtnSi);
            this.panel2.Location = new System.Drawing.Point(445, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 178);
            this.panel2.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Cambios?";
            // 
            // dgvBase
            // 
            this.dgvBase.AutoGenerateColumns = false;
            this.dgvBase.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codDeptoDataGridViewTextBoxColumn,
            this.nombreDeptoDataGridViewTextBoxColumn});
            this.dgvBase.DataSource = this.departamentoBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBase.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBase.EnableHeadersVisualStyles = false;
            this.dgvBase.GridColor = System.Drawing.Color.OrangeRed;
            this.dgvBase.Location = new System.Drawing.Point(20, 339);
            this.dgvBase.Name = "dgvBase";
            this.dgvBase.ReadOnly = true;
            this.dgvBase.RowHeadersWidth = 51;
            this.dgvBase.RowTemplate.Height = 24;
            this.dgvBase.Size = new System.Drawing.Size(716, 175);
            this.dgvBase.TabIndex = 48;
            this.dgvBase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBase_CellContentClick);
            // 
            // codDeptoDataGridViewTextBoxColumn
            // 
            this.codDeptoDataGridViewTextBoxColumn.DataPropertyName = "Cod_Depto";
            this.codDeptoDataGridViewTextBoxColumn.HeaderText = "Cod_Depto";
            this.codDeptoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codDeptoDataGridViewTextBoxColumn.Name = "codDeptoDataGridViewTextBoxColumn";
            this.codDeptoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codDeptoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDeptoDataGridViewTextBoxColumn
            // 
            this.nombreDeptoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDeptoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Depto";
            this.nombreDeptoDataGridViewTextBoxColumn.HeaderText = "Nombre_Depto";
            this.nombreDeptoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDeptoDataGridViewTextBoxColumn.Name = "nombreDeptoDataGridViewTextBoxColumn";
            this.nombreDeptoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departamentoBindingSource1
            // 
            this.departamentoBindingSource1.DataMember = "Departamento";
            this.departamentoBindingSource1.DataSource = this.universidadDataSetklin1;
            // 
            // universidadDataSetklin1
            // 
            this.universidadDataSetklin1.DataSetName = "universidadDataSetklin1";
            this.universidadDataSetklin1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.universidadDataSet;
            // 
            // universidadDataSet
            // 
            this.universidadDataSet.DataSetName = "universidadDataSet";
            this.universidadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // departamentoTableAdapter1
            // 
            this.departamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // regdepartamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.fondo33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 537);
            this.Controls.Add(this.dgvBase);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "regdepartamentoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Departamento";
            this.Load += new System.EventHandler(this.regdepartamentoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSetklin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdBuscar;
        private System.Windows.Forms.RadioButton rdbtnSi;
        private System.Windows.Forms.RadioButton rdbtnNo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox codigodepartamentoTextbox;
        private System.Windows.Forms.TextBox nombredepartamentoTextBox;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBase;
        private universidadDataSet universidadDataSet;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private universidadDataSetTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDeptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private universidadDataSetklin1 universidadDataSetklin1;
        private System.Windows.Forms.BindingSource departamentoBindingSource1;
        private universidadDataSetklin1TableAdapters.DepartamentoTableAdapter departamentoTableAdapter1;
    }
}