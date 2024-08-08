
namespace practice_main
{
    partial class statecity
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
            this.cmb_state = new System.Windows.Forms.ComboBox();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_index = new System.Windows.Forms.Button();
            this.btn_item = new System.Windows.Forms.Button();
            this.btn_value = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_state = new System.Windows.Forms.RadioButton();
            this.rbtn_city = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_state
            // 
            this.cmb_state.FormattingEnabled = true;
            this.cmb_state.Location = new System.Drawing.Point(147, 40);
            this.cmb_state.Name = "cmb_state";
            this.cmb_state.Size = new System.Drawing.Size(121, 24);
            this.cmb_state.TabIndex = 0;
            this.cmb_state.SelectedIndexChanged += new System.EventHandler(this.cmb_state_SelectedIndexChanged);
            // 
            // cmb_city
            // 
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(147, 70);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(121, 24);
            this.cmb_city.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(147, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 22);
            this.txt_id.TabIndex = 2;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToOrderColumns = true;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(13, 197);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(353, 253);
            this.dgv1.TabIndex = 3;
            this.dgv1.CurrentCellChanged += new System.EventHandler(this.dgv1_CurrentCellChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "State:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "City:";
            // 
            // btn_index
            // 
            this.btn_index.Location = new System.Drawing.Point(3, 45);
            this.btn_index.Name = "btn_index";
            this.btn_index.Size = new System.Drawing.Size(117, 45);
            this.btn_index.TabIndex = 7;
            this.btn_index.Text = "Show SelectedIndex";
            this.btn_index.UseVisualStyleBackColor = true;
            this.btn_index.Click += new System.EventHandler(this.btn_index_Click);
            // 
            // btn_item
            // 
            this.btn_item.Location = new System.Drawing.Point(118, 45);
            this.btn_item.Name = "btn_item";
            this.btn_item.Size = new System.Drawing.Size(122, 45);
            this.btn_item.TabIndex = 8;
            this.btn_item.Text = "Show SelectedItem";
            this.btn_item.UseVisualStyleBackColor = true;
            this.btn_item.Click += new System.EventHandler(this.btn_item_Click);
            // 
            // btn_value
            // 
            this.btn_value.Location = new System.Drawing.Point(233, 45);
            this.btn_value.Name = "btn_value";
            this.btn_value.Size = new System.Drawing.Size(120, 45);
            this.btn_value.TabIndex = 9;
            this.btn_value.Text = "Show SelectedValue";
            this.btn_value.UseVisualStyleBackColor = true;
            this.btn_value.Click += new System.EventHandler(this.btn_value_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_city);
            this.panel1.Controls.Add(this.rbtn_state);
            this.panel1.Controls.Add(this.btn_index);
            this.panel1.Controls.Add(this.btn_value);
            this.panel1.Controls.Add(this.btn_item);
            this.panel1.Location = new System.Drawing.Point(7, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 93);
            this.panel1.TabIndex = 10;
            // 
            // rbtn_state
            // 
            this.rbtn_state.AutoSize = true;
            this.rbtn_state.Checked = true;
            this.rbtn_state.Location = new System.Drawing.Point(3, 18);
            this.rbtn_state.Name = "rbtn_state";
            this.rbtn_state.Size = new System.Drawing.Size(133, 21);
            this.rbtn_state.TabIndex = 10;
            this.rbtn_state.TabStop = true;
            this.rbtn_state.Text = "State ComboBox";
            this.rbtn_state.UseVisualStyleBackColor = true;
            // 
            // rbtn_city
            // 
            this.rbtn_city.AutoSize = true;
            this.rbtn_city.Location = new System.Drawing.Point(219, 18);
            this.rbtn_city.Name = "rbtn_city";
            this.rbtn_city.Size = new System.Drawing.Size(123, 21);
            this.rbtn_city.TabIndex = 11;
            this.rbtn_city.Text = "City ComboBox";
            this.rbtn_city.UseVisualStyleBackColor = true;
            // 
            // statecity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.cmb_city);
            this.Controls.Add(this.cmb_state);
            this.Name = "statecity";
            this.Text = "statecity";
            this.Load += new System.EventHandler(this.statecity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_state;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_index;
        private System.Windows.Forms.Button btn_item;
        private System.Windows.Forms.Button btn_value;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn_city;
        private System.Windows.Forms.RadioButton rbtn_state;
    }
}