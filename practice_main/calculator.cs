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
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;

        private void Form4_Load(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(btn_add, "Addition");
            t1.SetToolTip(btn_sub, "Subtraction");
            t1.SetToolTip(btn_div, "Division");
            t1.SetToolTip(btn_multi, "Multiply");
            t1.SetToolTip(btn_equal, "Equals to");
            t1.SetToolTip(btn_clr, "Clear everything");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_input.Text = txt_input.Text + 9;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_input.Text = txt_input.Text + 8;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_input.Text = txt_input.Text + 7;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_input.Text = txt_input.Text + 6;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_input.Text = txt_input.Text + 5;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_input.Text = txt_input.Text + 4;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_input.Text = txt_input.Text + 3;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_input.Text = txt_input.Text + 2;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_input.Text = txt_input.Text + 1;
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            txt_input.Text = txt_input.Text + 0 + 0;
        }

        private void btn_decimal_Click(object sender, EventArgs e)
        {
            int c = txt_input.TextLength;
            int flag = 0;
            string text = txt_input.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; 
                    break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txt_input.Text = txt_input.Text + ".";
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_input.Clear();
            count = 0;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txt_input.Text);
            txt_input.Clear();
            txt_input.Focus();
            count = 4;
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txt_input.Text);
            txt_input.Clear();
            txt_input.Focus();
            count = 3;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txt_input.Text);
            txt_input.Clear();
            txt_input.Focus();
            count = 2;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txt_input.Text);
            txt_input.Clear();
            txt_input.Focus();
            count = 1;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    ans = num1 + float.Parse(txt_input.Text);
                    txt_input.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 - float.Parse(txt_input.Text);
                    txt_input.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(txt_input.Text);
                    txt_input.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(txt_input.Text);
                    txt_input.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_input.Text = txt_input.Text + 0;
        }
    }
}
