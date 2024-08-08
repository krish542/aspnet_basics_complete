using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace practice_main
{
    public partial class txt_refresh : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Krishna/source/repos/practice_main/practice.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public txt_refresh()
        {
            InitializeComponent();
        }

        private void txt_refresh_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new OleDbDataAdapter("select * from tbl_dept", con);
                ds = new DataSet();
                da.Fill(ds);

                cmb_dept.DataSource = ds.Tables[0];
                cmb_dept.DisplayMember = "dept_name";
                cmb_dept.ValueMember = "dept_id";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void txt_salary_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //net sal = basic + hra + da - pf
                //hra = 10% of basic
                //da = 5% of basic
                //pf = 100
                if(cmb_dept.SelectedValue.ToString() == "1")
                {
                    int sal;
                    float hra, da, pf, netsal;
                    sal = Convert.ToInt32(txt_salary.Text);
                    hra = Convert.ToSingle( 0.1 * sal);
                    da = Convert.ToSingle(0.05 * sal);
                    pf = Convert.ToSingle(100);
                    netsal = Convert.ToSingle(sal + hra + da - pf);
                    txt_da.Text = Convert.ToString(da);
                    txt_hra.Text = Convert.ToString(hra);
                    txt_pf.Text = Convert.ToString(pf);
                    txt_netsal.Text = Convert.ToString(netsal);
                }
                else if(cmb_dept.SelectedValue.ToString() == "2")
                {
                    int sal;
                    float hra, da, pf, netsal;
                    sal = Convert.ToInt32(txt_salary.Text);
                    hra = Convert.ToSingle(0.2 * sal);
                    da = Convert.ToSingle(0.04 * sal);
                    pf = Convert.ToSingle(100);
                    netsal = Convert.ToSingle(sal + hra + da - pf);
                    txt_da.Text = Convert.ToString(da);
                    txt_hra.Text = Convert.ToString(hra);
                    txt_pf.Text = Convert.ToString(pf);
                    txt_netsal.Text = Convert.ToString(netsal);
                }
                else if (cmb_dept.SelectedValue.ToString() == "3")
                {
                    int sal;
                    float hra, da, pf, netsal;
                    sal = Convert.ToInt32(txt_salary.Text);
                    hra = Convert.ToSingle(0.3 * sal);
                    da = Convert.ToSingle(0.03 * sal);
                    pf = Convert.ToSingle(100);
                    netsal = Convert.ToSingle(sal + hra + da - pf);
                    txt_da.Text = Convert.ToString(da);
                    txt_hra.Text = Convert.ToString(hra);
                    txt_pf.Text = Convert.ToString(pf);
                    txt_netsal.Text = Convert.ToString(netsal);
                }
                else if (cmb_dept.SelectedValue.ToString() == "4")
                {
                    int sal;
                    float hra, da, pf, netsal;
                    sal = Convert.ToInt32(txt_salary.Text);
                    hra = Convert.ToSingle(0.4 * sal);
                    da = Convert.ToSingle(0.02 * sal);
                    pf = Convert.ToSingle(100);
                    netsal = Convert.ToSingle(sal + hra + da - pf);
                    txt_da.Text = Convert.ToString(da);
                    txt_hra.Text = Convert.ToString(hra);
                    txt_pf.Text = Convert.ToString(pf);
                    txt_netsal.Text = Convert.ToString(netsal);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                /*da = new OleDbDataAdapter("select * from tbl_dept", con);
                ds = new DataSet();
                da.Fill(ds);
                cmb_dept.DataSource = ds.Tables[0];
                cmb_dept.DisplayMember = "dept_name";
                cmb_dept.ValueMember = "dept_id";*/

                cmb_dept.SelectedIndex = 0;
                txt_salary.Text = "";
                txt_da.Text = "";
                txt_hra.Text = "";
                txt_pf.Text = "";
                txt_netsal.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
