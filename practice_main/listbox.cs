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
    public partial class listbox : Form
    {
        public listbox()
        {
            InitializeComponent();
        }

        void moveitems(ListBox source, ListBox destination)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            foreach (var item in sourceItems)
            {
                destination.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }

        }

        void moveall(ListBox source, ListBox destination)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            destination.Items.AddRange(source.Items);
            source.Items.Clear();
        }

        private void listbox_Load(object sender, EventArgs e)
        {
            try
            {
                //runtime adding items in listbox1(dynamic)
                string[] list1 = { "item a", "item b", "item c", "item d", "item e","item f","item g","item h" };
                foreach (string var in list1)
                {
                    listBox1.Items.Add(var);
                }
                
                //adding items in listbox2(dynamic without foreach or for loop)
                listBox2.Items.Add("item i");
                listBox2.Items.Add("item j");
                listBox2.Items.Add("item k");
                listBox2.Items.Add("item l");
                listBox2.Items.Add("item m");
                listBox2.Items.Add("item n");
                listBox2.Items.Add("item o");

                string[] cmb1 = {"a-c","d-e","f-h"};
                foreach (string var in cmb1)
                {
                    cmb_filterList1.Items.Add(var);
                }

                string[] cmb2 = {"i-k","l-n","o"};
                foreach (string var in cmb2)
                {
                    cmb_filterList2.Items.Add(var);
                }

                ToolTip t1 = new ToolTip();
                t1.SetToolTip(listBox1, "ListBox 1");
                t1.SetToolTip(listBox2, "ListBox 2");
                t1.SetToolTip(btn_ot_selected, "Move selected Items from ListBox1 to ListBox2 \n//one to two(ot)");
                t1.SetToolTip(btn_ot_all, "Move all items from ListBox1 to ListBox2 \n//one to two(ot)");
                t1.SetToolTip(btn_to_selected, "Move selected Items from ListBox2 to ListBox1 \n//two to one(to)");
                t1.SetToolTip(btn_to_all, "Move all items from ListBox2 to ListBox1 \n//two to one(to)");
                t1.SetToolTip(btn_rem1, "Remove items from listBox1 at position required");
                t1.SetToolTip(btn_rem2, "Remove items from listBox2 at position required");
                t1.SetToolTip(cmb_filterList1, "Filter ListBox1");
                t1.SetToolTip(cmb_filterList2, "Filter ListBox2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ot_selected_Click(object sender, EventArgs e)
        {
            moveitems(listBox1, listBox2);
        }

        private void btn_ot_all_Click(object sender, EventArgs e)
        {
            moveall(listBox1, listBox2);
        }

        private void btn_to_selected_Click(object sender, EventArgs e)
        {
            moveitems(listBox2, listBox1);
        }

        private void btn_to_all_Click(object sender, EventArgs e)
        {
            moveall(listBox2, listBox1);
        }

        private void btn_rem1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(tb_remList1.Text);
                if(n< listBox1.Items.Count)
                {
                    listBox1.Items.RemoveAt(n - 1);
                    tb_remList1.Text = "";
                }
                else
                {
                    MessageBox.Show("Enter valid position to remove item at");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_rem2_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(tb_remList2.Text);
                if (n < listBox2.Items.Count)
                {
                    listBox2.Items.RemoveAt(n - 1);
                    tb_remList2.Text = "";
                }
                else
                {
                    MessageBox.Show("Enter valid position to remove item at");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_filterList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmb_filterList1.SelectedIndex.ToString() == "0")
                {
                    listBox1.Items.Clear();
                    string[] abc = { "item a","item b","item c" };
                    foreach(string var in abc)
                    {
                        listBox1.Items.Add(var);
                    }                    
                }
                else if (cmb_filterList1.SelectedIndex.ToString() == "1")
                {
                    listBox1.Items.Clear();
                    string[] de = { "item d", "item e" };
                    foreach (string var in de)
                    {
                        listBox1.Items.Add(var);
                    }
                }
                else if (cmb_filterList1.SelectedIndex.ToString() == "2")
                {
                    listBox1.Items.Clear();
                    string[] fgh = { "item f", "item g","item h" };
                    foreach (string var in fgh)
                    {
                        listBox1.Items.Add(var);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_filterList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_filterList2.SelectedIndex.ToString() == "0")
                {
                    listBox2.Items.Clear();
                    string[] ijk = { "item i", "item j", "item k" };
                    foreach (string var in ijk)
                    {
                        listBox2.Items.Add(var);
                    }
                }
                else if (cmb_filterList2.SelectedIndex.ToString() == "1")
                {
                    listBox2.Items.Clear();
                    string[] lmn = { "item l", "item m","item n" };
                    foreach (string var in lmn)
                    {
                        listBox2.Items.Add(var);
                    }
                }
                else if (cmb_filterList2.SelectedIndex.ToString() == "2")
                {
                    listBox2.Items.Clear();
                    string[] o = { "item o"};
                    foreach (string var in o)
                    {
                        listBox2.Items.Add(var);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
