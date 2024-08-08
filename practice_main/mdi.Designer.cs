
namespace practice_main
{
    partial class mdi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("child1node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("child2node2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("child1node3");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("child2node3");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("secondchild1node3");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("secondchild2node3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("child3node3", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode9});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_timelapse = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(193, 223);
            this.treeView1.TabIndex = 0;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(233, 12);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "child1node2";
            treeNode2.Text = "child1node2";
            treeNode3.Name = "child2node2";
            treeNode3.Text = "child2node2";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Node2";
            treeNode5.Name = "child1node3";
            treeNode5.Text = "child1node3";
            treeNode6.Name = "child2node3";
            treeNode6.Text = "child2node3";
            treeNode7.Name = "secondchild1node3";
            treeNode7.Text = "secondchild1node3";
            treeNode8.Name = "secondchild2node3";
            treeNode8.Text = "secondchild2node3";
            treeNode9.Name = "child3node3";
            treeNode9.Text = "child3node3";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Node3";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode10});
            this.treeView2.Size = new System.Drawing.Size(193, 223);
            this.treeView2.TabIndex = 1;
            this.treeView2.DoubleClick += new System.EventHandler(this.treeView2_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Static Treenodes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dynamic Treenodes";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time: ";
            // 
            // lbl_timelapse
            // 
            this.lbl_timelapse.AutoSize = true;
            this.lbl_timelapse.Location = new System.Drawing.Point(65, 282);
            this.lbl_timelapse.Name = "lbl_timelapse";
            this.lbl_timelapse.Size = new System.Drawing.Size(0, 17);
            this.lbl_timelapse.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 318);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // mdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 474);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_timelapse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "mdi";
            this.Text = "mdi";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.mdi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_timelapse;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}