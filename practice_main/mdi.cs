using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_main
{
    public partial class mdi : Form
    {
        public mdi()
        {
            InitializeComponent();
        }

        private void mdi_Load(object sender, EventArgs e)
        {
            TreeNode node1 = new TreeNode("Node1");
            treeView1.Nodes.Add(node1);
            
            TreeNode child1node2 = new TreeNode("child1node2");
            TreeNode child2node2 = new TreeNode("child2node2");
            TreeNode[] array2 = new TreeNode[] { child1node2, child2node2 };
            TreeNode node2 = new TreeNode("Node2", array2);
            treeView1.Nodes.Add(node2);

            TreeNode secondchild1node3 = new TreeNode("secondchild1node3");
            TreeNode secondchild2node3 = new TreeNode("secondchild2node3");
            TreeNode[] array1of3 = new TreeNode[] { secondchild1node3, secondchild2node3 };
            TreeNode child1node3 = new TreeNode("child1node3");
            TreeNode child2node3 = new TreeNode("child2node3");
            TreeNode child3node3 = new TreeNode("child3node3", array1of3);
            TreeNode[] array2of3 = new TreeNode[] { child1node3, child2node3, child3node3 };
            TreeNode node3 = new TreeNode("Node3",array2of3);
            treeView1.Nodes.Add(node3);

            
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(this.t_tick);
            timer1.Start();
        }

        private void treeView2_DoubleClick(object sender, EventArgs e)
        {            
            // Get the selected node            
            TreeNode node = treeView2.SelectedNode;
            string str = "You selected: " + node.Text;          
            MessageBox.Show(str);
        }

        private void t_tick(object sender, EventArgs e)
        {            
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time = "";
            
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            lbl_timelapse.Text = time;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Date selected: "+ dateTimePicker1.Value.ToString("dd|MM|yyyy"));
        }
    }
}
