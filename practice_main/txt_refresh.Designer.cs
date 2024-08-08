
namespace practice_main
{
    partial class txt_refresh
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
            this.cmb_dept = new System.Windows.Forms.ComboBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_hra = new System.Windows.Forms.TextBox();
            this.txt_da = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_netsal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_dept
            // 
            this.cmb_dept.FormattingEnabled = true;
            this.cmb_dept.Location = new System.Drawing.Point(115, 12);
            this.cmb_dept.Name = "cmb_dept";
            this.cmb_dept.Size = new System.Drawing.Size(121, 24);
            this.cmb_dept.TabIndex = 0;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(115, 59);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(121, 22);
            this.txt_salary.TabIndex = 1;
            this.txt_salary.TextChanged += new System.EventHandler(this.txt_salary_TextChanged);
            // 
            // txt_hra
            // 
            this.txt_hra.Location = new System.Drawing.Point(115, 105);
            this.txt_hra.Name = "txt_hra";
            this.txt_hra.Size = new System.Drawing.Size(121, 22);
            this.txt_hra.TabIndex = 2;
            // 
            // txt_da
            // 
            this.txt_da.Location = new System.Drawing.Point(115, 153);
            this.txt_da.Name = "txt_da";
            this.txt_da.Size = new System.Drawing.Size(121, 22);
            this.txt_da.TabIndex = 3;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(15, 389);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "HRA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "DA";
            // 
            // txt_pf
            // 
            this.txt_pf.Location = new System.Drawing.Point(115, 203);
            this.txt_pf.Name = "txt_pf";
            this.txt_pf.Size = new System.Drawing.Size(121, 22);
            this.txt_pf.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "PF";
            // 
            // txt_netsal
            // 
            this.txt_netsal.Location = new System.Drawing.Point(115, 254);
            this.txt_netsal.Name = "txt_netsal";
            this.txt_netsal.Size = new System.Drawing.Size(121, 22);
            this.txt_netsal.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Net Salary";
            // 
            // txt_refresh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_netsal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_da);
            this.Controls.Add(this.txt_hra);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.cmb_dept);
            this.Name = "txt_refresh";
            this.Text = "txt_refresh";
            this.Load += new System.EventHandler(this.txt_refresh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_dept;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_hra;
        private System.Windows.Forms.TextBox txt_da;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_netsal;
        private System.Windows.Forms.Label label7;
    }
}