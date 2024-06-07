namespace ProyectoFinal
{
    partial class mainframeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainframeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscribirMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroUsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panellogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTxtbox = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioTextbox = new System.Windows.Forms.TextBox();
            this.salirBtn = new System.Windows.Forms.Button();
            this.iniciosesionBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panellogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.masToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(824, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroEstudiantesToolStripMenuItem,
            this.inscribirMateriasToolStripMenuItem});
            this.estudiantesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estudiantesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.estudiantesToolStripMenuItem_Click);
            // 
            // registroEstudiantesToolStripMenuItem
            // 
            this.registroEstudiantesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.registroEstudiantesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registroEstudiantesToolStripMenuItem.Name = "registroEstudiantesToolStripMenuItem";
            this.registroEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.registroEstudiantesToolStripMenuItem.Text = "Registro estudiantes";
            this.registroEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.registroEstudiantesToolStripMenuItem_Click);
            // 
            // inscribirMateriasToolStripMenuItem
            // 
            this.inscribirMateriasToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.inscribirMateriasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inscribirMateriasToolStripMenuItem.Name = "inscribirMateriasToolStripMenuItem";
            this.inscribirMateriasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.inscribirMateriasToolStripMenuItem.Text = "Inscribir materias";
            this.inscribirMateriasToolStripMenuItem.Click += new System.EventHandler(this.inscribirMateriasToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroProfesorToolStripMenuItem,
            this.asignarMateriasToolStripMenuItem});
            this.profesoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profesoresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            this.profesoresToolStripMenuItem.Click += new System.EventHandler(this.profesoresToolStripMenuItem_Click);
            // 
            // registroProfesorToolStripMenuItem
            // 
            this.registroProfesorToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.registroProfesorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registroProfesorToolStripMenuItem.Name = "registroProfesorToolStripMenuItem";
            this.registroProfesorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registroProfesorToolStripMenuItem.Text = "Registro profesor";
            this.registroProfesorToolStripMenuItem.Click += new System.EventHandler(this.registroProfesorToolStripMenuItem_Click);
            // 
            // asignarMateriasToolStripMenuItem
            // 
            this.asignarMateriasToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.asignarMateriasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.asignarMateriasToolStripMenuItem.Name = "asignarMateriasToolStripMenuItem";
            this.asignarMateriasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.asignarMateriasToolStripMenuItem.Text = "Asignar materias";
            this.asignarMateriasToolStripMenuItem.Click += new System.EventHandler(this.asignarMateriasToolStripMenuItem_Click);
            // 
            // masToolStripMenuItem
            // 
            this.masToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroCarreraToolStripMenuItem,
            this.registroDepartamentoToolStripMenuItem,
            this.registroUsuariosToolStripMenuItem,
            this.registroUsuariosToolStripMenuItem1});
            this.masToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.masToolStripMenuItem.Name = "masToolStripMenuItem";
            this.masToolStripMenuItem.Size = new System.Drawing.Size(115, 21);
            this.masToolStripMenuItem.Text = "Mantenimiento";
            this.masToolStripMenuItem.Click += new System.EventHandler(this.masToolStripMenuItem_Click);
            // 
            // registroCarreraToolStripMenuItem
            // 
            this.registroCarreraToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.registroCarreraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registroCarreraToolStripMenuItem.Name = "registroCarreraToolStripMenuItem";
            this.registroCarreraToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.registroCarreraToolStripMenuItem.Text = "Registro carrera";
            this.registroCarreraToolStripMenuItem.Click += new System.EventHandler(this.registroCarreraToolStripMenuItem_Click);
            // 
            // registroDepartamentoToolStripMenuItem
            // 
            this.registroDepartamentoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.registroDepartamentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registroDepartamentoToolStripMenuItem.Name = "registroDepartamentoToolStripMenuItem";
            this.registroDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.registroDepartamentoToolStripMenuItem.Text = "Registro departamento";
            this.registroDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.registroDepartamentoToolStripMenuItem_Click);
            // 
            // registroUsuariosToolStripMenuItem
            // 
            this.registroUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.registroUsuariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registroUsuariosToolStripMenuItem.Name = "registroUsuariosToolStripMenuItem";
            this.registroUsuariosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.registroUsuariosToolStripMenuItem.Text = "Registro materias";
            this.registroUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registroUsuariosToolStripMenuItem_Click);
            // 
            // registroUsuariosToolStripMenuItem1
            // 
            this.registroUsuariosToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.registroUsuariosToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.registroUsuariosToolStripMenuItem1.Name = "registroUsuariosToolStripMenuItem1";
            this.registroUsuariosToolStripMenuItem1.Size = new System.Drawing.Size(218, 22);
            this.registroUsuariosToolStripMenuItem1.Text = "Registro usuarios";
            this.registroUsuariosToolStripMenuItem1.Click += new System.EventHandler(this.registroUsuariosToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panellogin
            // 
            this.panellogin.AutoSize = true;
            this.panellogin.BackgroundImage = global::ProyectoFinal.Properties.Resources.campus_uped_editado;
            this.panellogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panellogin.Controls.Add(this.label2);
            this.panellogin.Controls.Add(this.passwordTxtbox);
            this.panellogin.Controls.Add(this.passwordTextbox);
            this.panellogin.Controls.Add(this.label1);
            this.panellogin.Controls.Add(this.usuarioTextbox);
            this.panellogin.Controls.Add(this.salirBtn);
            this.panellogin.Controls.Add(this.iniciosesionBtn);
            this.panellogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panellogin.Location = new System.Drawing.Point(0, 25);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(824, 557);
            this.panellogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(115, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(629, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "UNIVERSIDAD PEDAGOGICA DE EL SALVADOR";
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.passwordTxtbox.AutoSize = true;
            this.passwordTxtbox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTxtbox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbox.Location = new System.Drawing.Point(244, 176);
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.Size = new System.Drawing.Size(123, 30);
            this.passwordTxtbox.TabIndex = 12;
            this.passwordTxtbox.Text = "Contraseña";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextbox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(246, 209);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(363, 25);
            this.passwordTextbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario";
            // 
            // usuarioTextbox
            // 
            this.usuarioTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.usuarioTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuarioTextbox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextbox.Location = new System.Drawing.Point(249, 136);
            this.usuarioTextbox.Name = "usuarioTextbox";
            this.usuarioTextbox.Size = new System.Drawing.Size(360, 25);
            this.usuarioTextbox.TabIndex = 7;
            // 
            // salirBtn
            // 
            this.salirBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.salirBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.salirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salirBtn.FlatAppearance.BorderSize = 0;
            this.salirBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.salirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirBtn.Location = new System.Drawing.Point(460, 271);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(130, 37);
            this.salirBtn.TabIndex = 11;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = false;
            // 
            // iniciosesionBtn
            // 
            this.iniciosesionBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iniciosesionBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.iniciosesionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iniciosesionBtn.FlatAppearance.BorderSize = 0;
            this.iniciosesionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.iniciosesionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciosesionBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciosesionBtn.Location = new System.Drawing.Point(265, 271);
            this.iniciosesionBtn.Name = "iniciosesionBtn";
            this.iniciosesionBtn.Size = new System.Drawing.Size(130, 37);
            this.iniciosesionBtn.TabIndex = 10;
            this.iniciosesionBtn.Text = "Login";
            this.iniciosesionBtn.UseVisualStyleBackColor = false;
            this.iniciosesionBtn.Click += new System.EventHandler(this.iniciosesionBtn_Click);
            // 
            // mainframeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 582);
            this.Controls.Add(this.panellogin);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainframeForm";
            this.Text = "Sistema de inscripcion de materias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainframeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panellogin.ResumeLayout(false);
            this.panellogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroUsuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inscribirMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarMateriasToolStripMenuItem;
        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label passwordTxtbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuarioTextbox;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.Button iniciosesionBtn;
    }
}