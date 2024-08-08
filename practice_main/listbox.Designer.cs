
namespace practice_main
{
    partial class listbox
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_ot_selected = new System.Windows.Forms.Button();
            this.btn_ot_all = new System.Windows.Forms.Button();
            this.btn_to_selected = new System.Windows.Forms.Button();
            this.btn_to_all = new System.Windows.Forms.Button();
            this.btn_rem1 = new System.Windows.Forms.Button();
            this.btn_rem2 = new System.Windows.Forms.Button();
            this.tb_remList1 = new System.Windows.Forms.TextBox();
            this.tb_remList2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_filterList1 = new System.Windows.Forms.ComboBox();
            this.cmb_filterList2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(141, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(165, 148);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(502, 35);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(165, 148);
            this.listBox2.TabIndex = 1;
            // 
            // btn_ot_selected
            // 
            this.btn_ot_selected.Location = new System.Drawing.Point(369, 53);
            this.btn_ot_selected.Name = "btn_ot_selected";
            this.btn_ot_selected.Size = new System.Drawing.Size(75, 23);
            this.btn_ot_selected.TabIndex = 2;
            this.btn_ot_selected.Text = ">";
            this.btn_ot_selected.UseVisualStyleBackColor = true;
            this.btn_ot_selected.Click += new System.EventHandler(this.btn_ot_selected_Click);
            // 
            // btn_ot_all
            // 
            this.btn_ot_all.Location = new System.Drawing.Point(369, 82);
            this.btn_ot_all.Name = "btn_ot_all";
            this.btn_ot_all.Size = new System.Drawing.Size(75, 23);
            this.btn_ot_all.TabIndex = 3;
            this.btn_ot_all.Text = ">>";
            this.btn_ot_all.UseVisualStyleBackColor = true;
            this.btn_ot_all.Click += new System.EventHandler(this.btn_ot_all_Click);
            // 
            // btn_to_selected
            // 
            this.btn_to_selected.Location = new System.Drawing.Point(369, 111);
            this.btn_to_selected.Name = "btn_to_selected";
            this.btn_to_selected.Size = new System.Drawing.Size(75, 23);
            this.btn_to_selected.TabIndex = 4;
            this.btn_to_selected.Text = "<";
            this.btn_to_selected.UseVisualStyleBackColor = true;
            this.btn_to_selected.Click += new System.EventHandler(this.btn_to_selected_Click);
            // 
            // btn_to_all
            // 
            this.btn_to_all.Location = new System.Drawing.Point(369, 140);
            this.btn_to_all.Name = "btn_to_all";
            this.btn_to_all.Size = new System.Drawing.Size(75, 23);
            this.btn_to_all.TabIndex = 5;
            this.btn_to_all.Text = "<<";
            this.btn_to_all.UseVisualStyleBackColor = true;
            this.btn_to_all.Click += new System.EventHandler(this.btn_to_all_Click);
            // 
            // btn_rem1
            // 
            this.btn_rem1.Location = new System.Drawing.Point(141, 217);
            this.btn_rem1.Name = "btn_rem1";
            this.btn_rem1.Size = new System.Drawing.Size(165, 23);
            this.btn_rem1.TabIndex = 6;
            this.btn_rem1.Text = "Remove(list 1)";
            this.btn_rem1.UseVisualStyleBackColor = true;
            this.btn_rem1.Click += new System.EventHandler(this.btn_rem1_Click);
            // 
            // btn_rem2
            // 
            this.btn_rem2.Location = new System.Drawing.Point(502, 217);
            this.btn_rem2.Name = "btn_rem2";
            this.btn_rem2.Size = new System.Drawing.Size(165, 23);
            this.btn_rem2.TabIndex = 7;
            this.btn_rem2.Text = "Remove(list 2)";
            this.btn_rem2.UseVisualStyleBackColor = true;
            this.btn_rem2.Click += new System.EventHandler(this.btn_rem2_Click);
            // 
            // tb_remList1
            // 
            this.tb_remList1.Location = new System.Drawing.Point(141, 189);
            this.tb_remList1.Name = "tb_remList1";
            this.tb_remList1.Size = new System.Drawing.Size(165, 22);
            this.tb_remList1.TabIndex = 8;
            // 
            // tb_remList2
            // 
            this.tb_remList2.Location = new System.Drawing.Point(502, 189);
            this.tb_remList2.Name = "tb_remList2";
            this.tb_remList2.Size = new System.Drawing.Size(165, 22);
            this.tb_remList2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Remove at: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Remove at: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(757, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "**Change the \"Selection Mode\" property of list box to MultiSimple or MultiEextend" +
    "ed to select multiple values in listboxes";
            // 
            // cmb_filterList1
            // 
            this.cmb_filterList1.FormattingEnabled = true;
            this.cmb_filterList1.Location = new System.Drawing.Point(141, 263);
            this.cmb_filterList1.Name = "cmb_filterList1";
            this.cmb_filterList1.Size = new System.Drawing.Size(165, 24);
            this.cmb_filterList1.TabIndex = 13;
            this.cmb_filterList1.SelectedIndexChanged += new System.EventHandler(this.cmb_filterList1_SelectedIndexChanged);
            // 
            // cmb_filterList2
            // 
            this.cmb_filterList2.FormattingEnabled = true;
            this.cmb_filterList2.Location = new System.Drawing.Point(502, 263);
            this.cmb_filterList2.Name = "cmb_filterList2";
            this.cmb_filterList2.Size = new System.Drawing.Size(165, 24);
            this.cmb_filterList2.TabIndex = 14;
            this.cmb_filterList2.SelectedIndexChanged += new System.EventHandler(this.cmb_filterList2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Filter: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Filter: ";
            // 
            // listbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_filterList2);
            this.Controls.Add(this.cmb_filterList1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_remList2);
            this.Controls.Add(this.tb_remList1);
            this.Controls.Add(this.btn_rem2);
            this.Controls.Add(this.btn_rem1);
            this.Controls.Add(this.btn_to_all);
            this.Controls.Add(this.btn_to_selected);
            this.Controls.Add(this.btn_ot_all);
            this.Controls.Add(this.btn_ot_selected);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "listbox";
            this.Text = "listbox";
            this.Load += new System.EventHandler(this.listbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_ot_selected;
        private System.Windows.Forms.Button btn_ot_all;
        private System.Windows.Forms.Button btn_to_selected;
        private System.Windows.Forms.Button btn_to_all;
        private System.Windows.Forms.Button btn_rem1;
        private System.Windows.Forms.Button btn_rem2;
        private System.Windows.Forms.TextBox tb_remList1;
        private System.Windows.Forms.TextBox tb_remList2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_filterList1;
        private System.Windows.Forms.ComboBox cmb_filterList2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}