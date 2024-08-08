
namespace practice_main
{
    partial class register
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_usrnm = new System.Windows.Forms.Label();
            this.lbl_pswd = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_usrnm = new System.Windows.Forms.TextBox();
            this.txt_pswd = new System.Windows.Forms.TextBox();
            this.rbtn_student = new System.Windows.Forms.RadioButton();
            this.rbtn_staff = new System.Windows.Forms.RadioButton();
            this.rbtn_lecturer = new System.Windows.Forms.RadioButton();
            this.rbtn_librarian = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_dept = new System.Windows.Forms.Label();
            this.lbl_eno = new System.Windows.Forms.Label();
            this.lbl_class = new System.Windows.Forms.Label();
            this.cmb_dept = new System.Windows.Forms.ComboBox();
            this.cmb_class = new System.Windows.Forms.ComboBox();
            this.txt_eno = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_stfno = new System.Windows.Forms.TextBox();
            this.lbl_stfno = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 20F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(20, 80);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(62, 17);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name *: ";
            // 
            // lbl_usrnm
            // 
            this.lbl_usrnm.AutoSize = true;
            this.lbl_usrnm.Location = new System.Drawing.Point(20, 108);
            this.lbl_usrnm.Name = "lbl_usrnm";
            this.lbl_usrnm.Size = new System.Drawing.Size(86, 17);
            this.lbl_usrnm.TabIndex = 2;
            this.lbl_usrnm.Text = "Username *:";
            // 
            // lbl_pswd
            // 
            this.lbl_pswd.AutoSize = true;
            this.lbl_pswd.Location = new System.Drawing.Point(20, 136);
            this.lbl_pswd.Name = "lbl_pswd";
            this.lbl_pswd.Size = new System.Drawing.Size(82, 17);
            this.lbl_pswd.TabIndex = 3;
            this.lbl_pswd.Text = "Password *:";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(20, 163);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(82, 17);
            this.lbl_category.TabIndex = 4;
            this.lbl_category.Text = "Category *: ";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(130, 77);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(121, 22);
            this.txt_name.TabIndex = 5;
            // 
            // txt_usrnm
            // 
            this.txt_usrnm.Location = new System.Drawing.Point(130, 105);
            this.txt_usrnm.Name = "txt_usrnm";
            this.txt_usrnm.Size = new System.Drawing.Size(121, 22);
            this.txt_usrnm.TabIndex = 6;
            // 
            // txt_pswd
            // 
            this.txt_pswd.Location = new System.Drawing.Point(130, 133);
            this.txt_pswd.Name = "txt_pswd";
            this.txt_pswd.Size = new System.Drawing.Size(121, 22);
            this.txt_pswd.TabIndex = 7;
            // 
            // rbtn_student
            // 
            this.rbtn_student.AutoSize = true;
            this.rbtn_student.Location = new System.Drawing.Point(3, 3);
            this.rbtn_student.Name = "rbtn_student";
            this.rbtn_student.Size = new System.Drawing.Size(78, 21);
            this.rbtn_student.TabIndex = 8;
            this.rbtn_student.Text = "Student";
            this.rbtn_student.UseVisualStyleBackColor = true;
            this.rbtn_student.CheckedChanged += new System.EventHandler(this.rbtn_student_CheckedChanged);
            // 
            // rbtn_staff
            // 
            this.rbtn_staff.AutoSize = true;
            this.rbtn_staff.Location = new System.Drawing.Point(87, 3);
            this.rbtn_staff.Name = "rbtn_staff";
            this.rbtn_staff.Size = new System.Drawing.Size(58, 21);
            this.rbtn_staff.TabIndex = 9;
            this.rbtn_staff.Text = "Staff";
            this.rbtn_staff.UseVisualStyleBackColor = true;
            this.rbtn_staff.CheckedChanged += new System.EventHandler(this.rbtn_staff_CheckedChanged);
            // 
            // rbtn_lecturer
            // 
            this.rbtn_lecturer.AutoSize = true;
            this.rbtn_lecturer.Checked = true;
            this.rbtn_lecturer.Location = new System.Drawing.Point(3, 3);
            this.rbtn_lecturer.Name = "rbtn_lecturer";
            this.rbtn_lecturer.Size = new System.Drawing.Size(82, 21);
            this.rbtn_lecturer.TabIndex = 10;
            this.rbtn_lecturer.TabStop = true;
            this.rbtn_lecturer.Text = "Lecturer";
            this.rbtn_lecturer.UseVisualStyleBackColor = true;
            this.rbtn_lecturer.Visible = false;
            // 
            // rbtn_librarian
            // 
            this.rbtn_librarian.AutoSize = true;
            this.rbtn_librarian.Location = new System.Drawing.Point(91, 3);
            this.rbtn_librarian.Name = "rbtn_librarian";
            this.rbtn_librarian.Size = new System.Drawing.Size(85, 21);
            this.rbtn_librarian.TabIndex = 11;
            this.rbtn_librarian.Text = "Librarian";
            this.rbtn_librarian.UseVisualStyleBackColor = true;
            this.rbtn_librarian.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_student);
            this.panel1.Controls.Add(this.rbtn_staff);
            this.panel1.Location = new System.Drawing.Point(130, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 33);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtn_lecturer);
            this.panel2.Controls.Add(this.rbtn_librarian);
            this.panel2.Location = new System.Drawing.Point(130, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 29);
            this.panel2.TabIndex = 13;
            // 
            // lbl_dept
            // 
            this.lbl_dept.AutoSize = true;
            this.lbl_dept.Location = new System.Drawing.Point(20, 253);
            this.lbl_dept.Name = "lbl_dept";
            this.lbl_dept.Size = new System.Drawing.Size(90, 17);
            this.lbl_dept.TabIndex = 14;
            this.lbl_dept.Text = "Department :";
            this.lbl_dept.Visible = false;
            // 
            // lbl_eno
            // 
            this.lbl_eno.AutoSize = true;
            this.lbl_eno.Location = new System.Drawing.Point(20, 315);
            this.lbl_eno.Name = "lbl_eno";
            this.lbl_eno.Size = new System.Drawing.Size(107, 17);
            this.lbl_eno.TabIndex = 15;
            this.lbl_eno.Text = "Enrol. Number: ";
            this.lbl_eno.Visible = false;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Location = new System.Drawing.Point(20, 286);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(50, 17);
            this.lbl_class.TabIndex = 16;
            this.lbl_class.Text = "Class :";
            this.lbl_class.Visible = false;
            // 
            // cmb_dept
            // 
            this.cmb_dept.FormattingEnabled = true;
            this.cmb_dept.Items.AddRange(new object[] {
            "cs",
            "mb",
            "es",
            "bt"});
            this.cmb_dept.Location = new System.Drawing.Point(130, 253);
            this.cmb_dept.Name = "cmb_dept";
            this.cmb_dept.Size = new System.Drawing.Size(121, 24);
            this.cmb_dept.TabIndex = 17;
            this.cmb_dept.Visible = false;
            // 
            // cmb_class
            // 
            this.cmb_class.FormattingEnabled = true;
            this.cmb_class.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmb_class.Location = new System.Drawing.Point(130, 283);
            this.cmb_class.Name = "cmb_class";
            this.cmb_class.Size = new System.Drawing.Size(121, 24);
            this.cmb_class.TabIndex = 18;
            this.cmb_class.Visible = false;
            // 
            // txt_eno
            // 
            this.txt_eno.Location = new System.Drawing.Point(130, 312);
            this.txt_eno.Name = "txt_eno";
            this.txt_eno.Size = new System.Drawing.Size(121, 22);
            this.txt_eno.TabIndex = 19;
            this.txt_eno.Visible = false;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(232, 350);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(106, 35);
            this.btn_register.TabIndex = 20;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_stfno
            // 
            this.txt_stfno.Location = new System.Drawing.Point(130, 237);
            this.txt_stfno.Name = "txt_stfno";
            this.txt_stfno.Size = new System.Drawing.Size(121, 22);
            this.txt_stfno.TabIndex = 21;
            this.txt_stfno.Visible = false;
            // 
            // lbl_stfno
            // 
            this.lbl_stfno.AutoSize = true;
            this.lbl_stfno.Location = new System.Drawing.Point(20, 240);
            this.lbl_stfno.Name = "lbl_stfno";
            this.lbl_stfno.Size = new System.Drawing.Size(62, 17);
            this.lbl_stfno.TabIndex = 22;
            this.lbl_stfno.Text = "Staff ID :";
            this.lbl_stfno.Visible = false;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 397);
            this.Controls.Add(this.lbl_stfno);
            this.Controls.Add(this.txt_stfno);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_eno);
            this.Controls.Add(this.cmb_class);
            this.Controls.Add(this.cmb_dept);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.lbl_eno);
            this.Controls.Add(this.lbl_dept);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_pswd);
            this.Controls.Add(this.txt_usrnm);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_pswd);
            this.Controls.Add(this.lbl_usrnm);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label1);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_usrnm;
        private System.Windows.Forms.Label lbl_pswd;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_usrnm;
        private System.Windows.Forms.TextBox txt_pswd;
        private System.Windows.Forms.RadioButton rbtn_student;
        private System.Windows.Forms.RadioButton rbtn_staff;
        private System.Windows.Forms.RadioButton rbtn_lecturer;
        private System.Windows.Forms.RadioButton rbtn_librarian;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_dept;
        private System.Windows.Forms.Label lbl_eno;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.ComboBox cmb_dept;
        private System.Windows.Forms.ComboBox cmb_class;
        private System.Windows.Forms.TextBox txt_eno;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txt_stfno;
        private System.Windows.Forms.Label lbl_stfno;
    }
}