
namespace practice_main
{
    partial class datacon
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clb_hobbies = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_img = new System.Windows.Forms.TextBox();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.cmb_dept = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_srch_dept = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.cb_view_pic = new System.Windows.Forms.CheckBox();
            this.cb_view = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToOrderColumns = true;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(512, 13);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(406, 239);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(512, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clb_hobbies);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_img);
            this.panel1.Controls.Add(this.rbtn_female);
            this.panel1.Controls.Add(this.rbtn_male);
            this.panel1.Controls.Add(this.cmb_dept);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 337);
            this.panel1.TabIndex = 5;
            // 
            // clb_hobbies
            // 
            this.clb_hobbies.FormattingEnabled = true;
            this.clb_hobbies.Items.AddRange(new object[] {
            "Reading",
            "Dancing",
            "Drawing",
            "Photography",
            "Music",
            "Others"});
            this.clb_hobbies.Location = new System.Drawing.Point(167, 133);
            this.clb_hobbies.Name = "clb_hobbies";
            this.clb_hobbies.Size = new System.Drawing.Size(120, 106);
            this.clb_hobbies.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 289);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2021, 2, 13, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Date of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hobbies";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // txt_img
            // 
            this.txt_img.Location = new System.Drawing.Point(167, 70);
            this.txt_img.Name = "txt_img";
            this.txt_img.Size = new System.Drawing.Size(121, 22);
            this.txt_img.TabIndex = 3;
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Location = new System.Drawing.Point(283, 251);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(75, 21);
            this.rbtn_female.TabIndex = 7;
            this.rbtn_female.Text = "Female";
            this.rbtn_female.UseVisualStyleBackColor = true;
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Checked = true;
            this.rbtn_male.Location = new System.Drawing.Point(167, 251);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(59, 21);
            this.rbtn_male.TabIndex = 6;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            // 
            // cmb_dept
            // 
            this.cmb_dept.FormattingEnabled = true;
            this.cmb_dept.Location = new System.Drawing.Point(167, 98);
            this.cmb_dept.Name = "cmb_dept";
            this.cmb_dept.Size = new System.Drawing.Size(121, 24);
            this.cmb_dept.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(167, 42);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(121, 22);
            this.txt_name.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(167, 14);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(120, 22);
            this.txt_id.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_srch_dept);
            this.panel2.Controls.Add(this.btn_browse);
            this.panel2.Controls.Add(this.cb_view_pic);
            this.panel2.Controls.Add(this.cb_view);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.btn_next);
            this.panel2.Controls.Add(this.btn_prev);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_insert);
            this.panel2.Controls.Add(this.btn_view);
            this.panel2.Location = new System.Drawing.Point(13, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 147);
            this.panel2.TabIndex = 6;
            // 
            // btn_srch_dept
            // 
            this.btn_srch_dept.Location = new System.Drawing.Point(392, 7);
            this.btn_srch_dept.Name = "btn_srch_dept";
            this.btn_srch_dept.Size = new System.Drawing.Size(98, 44);
            this.btn_srch_dept.TabIndex = 19;
            this.btn_srch_dept.Text = "Search By Department";
            this.btn_srch_dept.UseVisualStyleBackColor = true;
            this.btn_srch_dept.Click += new System.EventHandler(this.btn_srch_dept_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(379, 112);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(111, 32);
            this.btn_browse.TabIndex = 18;
            this.btn_browse.Text = "Browse Image";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // cb_view_pic
            // 
            this.cb_view_pic.AutoSize = true;
            this.cb_view_pic.Checked = true;
            this.cb_view_pic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_view_pic.Location = new System.Drawing.Point(25, 30);
            this.cb_view_pic.Name = "cb_view_pic";
            this.cb_view_pic.Size = new System.Drawing.Size(130, 21);
            this.cb_view_pic.TabIndex = 10;
            this.cb_view_pic.Text = "View PictureBox";
            this.cb_view_pic.UseVisualStyleBackColor = true;
            this.cb_view_pic.CheckedChanged += new System.EventHandler(this.cb_view_pic_CheckedChanged);
            // 
            // cb_view
            // 
            this.cb_view.AutoSize = true;
            this.cb_view.Checked = true;
            this.cb_view.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_view.Location = new System.Drawing.Point(26, 7);
            this.cb_view.Name = "cb_view";
            this.cb_view.Size = new System.Drawing.Size(149, 21);
            this.cb_view.TabIndex = 9;
            this.cb_view.Text = "View DataGridView";
            this.cb_view.UseVisualStyleBackColor = true;
            this.cb_view.CheckedChanged += new System.EventHandler(this.cb_view_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(392, 57);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 44);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "Search By ID";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(106, 86);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 16;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(25, 86);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 23);
            this.btn_prev.TabIndex = 15;
            this.btn_prev.Text = "Previous";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(187, 57);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(271, 57);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(106, 57);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 12;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(25, 57);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 23);
            this.btn_view.TabIndex = 11;
            this.btn_view.Text = "View ";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "*For Images: the location must be valid and must match extension of the file";
            // 
            // datacon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv1);
            this.Name = "datacon";
            this.Text = "Data Connection";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_img;
        private System.Windows.Forms.RadioButton rbtn_female;
        private System.Windows.Forms.RadioButton rbtn_male;
        private System.Windows.Forms.ComboBox cmb_dept;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.CheckBox cb_view;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.CheckBox cb_view_pic;
        private System.Windows.Forms.CheckedListBox clb_hobbies;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_srch_dept;
        private System.Windows.Forms.Label label2;
    }
}