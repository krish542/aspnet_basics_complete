
namespace practice_main
{
    partial class homepage_Student
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookIssueDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksIssuedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksReturnedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_stream = new System.Windows.Forms.Label();
            this.lbl_class = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_idupdate = new System.Windows.Forms.Label();
            this.lbl_classupdate = new System.Windows.Forms.Label();
            this.lbl_streamupdate = new System.Windows.Forms.Label();
            this.lbl_nameupdate = new System.Windows.Forms.Label();
            this.btn_updatedet = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_stream = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.txt_studid = new System.Windows.Forms.TextBox();
            this.updateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDetailsToolStripMenuItem,
            this.bookIssueDetailsToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAccountToolStripMenuItem,
            this.updateDetailsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            // 
            // viewAccountToolStripMenuItem
            // 
            this.viewAccountToolStripMenuItem.Name = "viewAccountToolStripMenuItem";
            this.viewAccountToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewAccountToolStripMenuItem.Text = "View Account";
            this.viewAccountToolStripMenuItem.Click += new System.EventHandler(this.viewAccountToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // bookIssueDetailsToolStripMenuItem
            // 
            this.bookIssueDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksIssuedToolStripMenuItem,
            this.booksReturnedToolStripMenuItem});
            this.bookIssueDetailsToolStripMenuItem.Name = "bookIssueDetailsToolStripMenuItem";
            this.bookIssueDetailsToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.bookIssueDetailsToolStripMenuItem.Text = "Book Issue Details";
            // 
            // booksIssuedToolStripMenuItem
            // 
            this.booksIssuedToolStripMenuItem.Name = "booksIssuedToolStripMenuItem";
            this.booksIssuedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.booksIssuedToolStripMenuItem.Text = "Books Issued ";
            // 
            // booksReturnedToolStripMenuItem
            // 
            this.booksReturnedToolStripMenuItem.Name = "booksReturnedToolStripMenuItem";
            this.booksReturnedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.booksReturnedToolStripMenuItem.Text = "Books Returned";
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(12, 44);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(65, 22);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name: ";
            this.lbl_name.Visible = false;
            // 
            // lbl_stream
            // 
            this.lbl_stream.AutoSize = true;
            this.lbl_stream.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stream.Location = new System.Drawing.Point(12, 83);
            this.lbl_stream.Name = "lbl_stream";
            this.lbl_stream.Size = new System.Drawing.Size(76, 22);
            this.lbl_stream.TabIndex = 3;
            this.lbl_stream.Text = "Stream: ";
            this.lbl_stream.Visible = false;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.Location = new System.Drawing.Point(12, 120);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(56, 22);
            this.lbl_class.TabIndex = 4;
            this.lbl_class.Text = "Class:";
            this.lbl_class.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(12, 157);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(109, 22);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "Student ID: ";
            this.lbl_id.Visible = false;
            // 
            // lbl_idupdate
            // 
            this.lbl_idupdate.AutoSize = true;
            this.lbl_idupdate.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idupdate.Location = new System.Drawing.Point(127, 157);
            this.lbl_idupdate.Name = "lbl_idupdate";
            this.lbl_idupdate.Size = new System.Drawing.Size(46, 20);
            this.lbl_idupdate.TabIndex = 9;
            this.lbl_idupdate.Text = "label5";
            this.lbl_idupdate.Visible = false;
            // 
            // lbl_classupdate
            // 
            this.lbl_classupdate.AutoSize = true;
            this.lbl_classupdate.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_classupdate.Location = new System.Drawing.Point(127, 122);
            this.lbl_classupdate.Name = "lbl_classupdate";
            this.lbl_classupdate.Size = new System.Drawing.Size(46, 20);
            this.lbl_classupdate.TabIndex = 8;
            this.lbl_classupdate.Text = "label6";
            this.lbl_classupdate.Visible = false;
            // 
            // lbl_streamupdate
            // 
            this.lbl_streamupdate.AutoSize = true;
            this.lbl_streamupdate.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_streamupdate.Location = new System.Drawing.Point(127, 84);
            this.lbl_streamupdate.Name = "lbl_streamupdate";
            this.lbl_streamupdate.Size = new System.Drawing.Size(46, 20);
            this.lbl_streamupdate.TabIndex = 7;
            this.lbl_streamupdate.Text = "label7";
            this.lbl_streamupdate.Visible = false;
            // 
            // lbl_nameupdate
            // 
            this.lbl_nameupdate.AutoSize = true;
            this.lbl_nameupdate.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nameupdate.Location = new System.Drawing.Point(127, 44);
            this.lbl_nameupdate.Name = "lbl_nameupdate";
            this.lbl_nameupdate.Size = new System.Drawing.Size(46, 20);
            this.lbl_nameupdate.TabIndex = 6;
            this.lbl_nameupdate.Text = "label8";
            this.lbl_nameupdate.Visible = false;
            // 
            // btn_updatedet
            // 
            this.btn_updatedet.Location = new System.Drawing.Point(16, 209);
            this.btn_updatedet.Name = "btn_updatedet";
            this.btn_updatedet.Size = new System.Drawing.Size(157, 31);
            this.btn_updatedet.TabIndex = 11;
            this.btn_updatedet.Text = "Update Details";
            this.btn_updatedet.UseVisualStyleBackColor = true;
            this.btn_updatedet.Visible = false;
            this.btn_updatedet.Click += new System.EventHandler(this.btn_updatedet_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(131, 43);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 12;
            this.txt_name.Visible = false;
            // 
            // txt_stream
            // 
            this.txt_stream.Location = new System.Drawing.Point(131, 82);
            this.txt_stream.Name = "txt_stream";
            this.txt_stream.Size = new System.Drawing.Size(100, 22);
            this.txt_stream.TabIndex = 13;
            this.txt_stream.Visible = false;
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(131, 119);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(100, 22);
            this.txt_class.TabIndex = 14;
            this.txt_class.Visible = false;
            // 
            // txt_studid
            // 
            this.txt_studid.Location = new System.Drawing.Point(131, 156);
            this.txt_studid.Name = "txt_studid";
            this.txt_studid.Size = new System.Drawing.Size(100, 22);
            this.txt_studid.TabIndex = 15;
            this.txt_studid.Visible = false;
            // 
            // updateDetailsToolStripMenuItem
            // 
            this.updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            this.updateDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateDetailsToolStripMenuItem.Text = "Update Details";
            this.updateDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDetailsToolStripMenuItem_Click);
            // 
            // homepage_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.txt_studid);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.txt_stream);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_updatedet);
            this.Controls.Add(this.lbl_idupdate);
            this.Controls.Add(this.lbl_classupdate);
            this.Controls.Add(this.lbl_streamupdate);
            this.Controls.Add(this.lbl_nameupdate);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.lbl_stream);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "homepage_Student";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.homepage_Student_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookIssueDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksIssuedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksReturnedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_stream;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_idupdate;
        private System.Windows.Forms.Label lbl_classupdate;
        private System.Windows.Forms.Label lbl_streamupdate;
        private System.Windows.Forms.Label lbl_nameupdate;
        private System.Windows.Forms.Button btn_updatedet;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_stream;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.TextBox txt_studid;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsToolStripMenuItem;
    }
}