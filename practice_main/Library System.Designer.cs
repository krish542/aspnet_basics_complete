
namespace practice_main
{
    partial class Library_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_pswd = new System.Windows.Forms.TextBox();
            this.txt_usrnm = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.txt_pswd);
            this.panel1.Controls.Add(this.txt_usrnm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 159);
            this.panel1.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(124, 102);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 39);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "&Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_pswd
            // 
            this.txt_pswd.Location = new System.Drawing.Point(124, 56);
            this.txt_pswd.Name = "txt_pswd";
            this.txt_pswd.Size = new System.Drawing.Size(100, 22);
            this.txt_pswd.TabIndex = 3;
            // 
            // txt_usrnm
            // 
            this.txt_usrnm.Location = new System.Drawing.Point(124, 15);
            this.txt_usrnm.Name = "txt_usrnm";
            this.txt_usrnm.Size = new System.Drawing.Size(100, 22);
            this.txt_usrnm.TabIndex = 2;
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(20, 42);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(80, 36);
            this.btn_signup.TabIndex = 3;
            this.btn_signup.Text = "&Sign Up";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "New User? Sign Up Here";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_signup);
            this.panel2.Location = new System.Drawing.Point(12, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 100);
            this.panel2.TabIndex = 5;
            // 
            // Library_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 354);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Library_System";
            this.Text = "Library_System";
            this.Load += new System.EventHandler(this.Library_System_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_pswd;
        private System.Windows.Forms.TextBox txt_usrnm;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}