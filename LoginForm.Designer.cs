namespace ProyectoFinal
{
    partial class LoginForm
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
            this.iniciosesionBtn = new System.Windows.Forms.Button();
            this.salirBtn = new System.Windows.Forms.Button();
            this.usuarioTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTxtbox = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iniciosesionBtn
            // 
            this.iniciosesionBtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciosesionBtn.Location = new System.Drawing.Point(52, 223);
            this.iniciosesionBtn.Name = "iniciosesionBtn";
            this.iniciosesionBtn.Size = new System.Drawing.Size(130, 37);
            this.iniciosesionBtn.TabIndex = 3;
            this.iniciosesionBtn.Text = "Login";
            this.iniciosesionBtn.UseVisualStyleBackColor = true;
            this.iniciosesionBtn.Click += new System.EventHandler(this.iniciosesionBtn_Click);
            // 
            // salirBtn
            // 
            this.salirBtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirBtn.Location = new System.Drawing.Point(247, 223);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(130, 37);
            this.salirBtn.TabIndex = 4;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // usuarioTextbox
            // 
            this.usuarioTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuarioTextbox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextbox.Location = new System.Drawing.Point(36, 88);
            this.usuarioTextbox.Name = "usuarioTextbox";
            this.usuarioTextbox.Size = new System.Drawing.Size(360, 29);
            this.usuarioTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.AutoSize = true;
            this.passwordTxtbox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbox.Location = new System.Drawing.Point(32, 136);
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.Size = new System.Drawing.Size(80, 22);
            this.passwordTxtbox.TabIndex = 5;
            this.passwordTxtbox.Text = "Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextbox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(33, 161);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(363, 29);
            this.passwordTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "LOGIN";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTxtbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuarioTextbox);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.iniciosesionBtn);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iniciosesionBtn;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.TextBox usuarioTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passwordTxtbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label label2;
    }
}