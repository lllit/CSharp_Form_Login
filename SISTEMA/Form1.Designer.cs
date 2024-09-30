namespace SISTEMA
{
    partial class Form1
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
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(98, 102);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(248, 20);
            this.txt_usuario.TabIndex = 0;
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(98, 180);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '*';
            this.txt_contrasena.Size = new System.Drawing.Size(248, 20);
            this.txt_contrasena.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(175, 253);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(89, 42);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 387);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_usuario);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Button btn_login;
    }
}