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
    public partial class multicmb : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Krishna/source/repos/practice_main/practice.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public multicmb()
        {
            InitializeComponent();
        }

        private void multicmb_Load(object sender, EventArgs e)
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

                da = new OleDbDataAdapter("select * from tbl_designation", con);
                ds = new DataSet();
                da.Fill(ds);
                cmb_designation.DataSource = ds.Tables[0];
                cmb_designation.DisplayMember = "designation_type";
                cmb_designation.ValueMember = "designation_id";
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new OleDbDataAdapter("select t1.employee_name,dept.dept_name,desig.designation_type from (((Table2 as t2 inner join Table1 as t1 on t2.employee_id = t1.ID) inner join tbl_dept as dept on t2.dept_id = dept.dept_id) inner join tbl_designation as desig on desig.designation_id = t2.designation_id) where t2.dept_id = " + cmb_dept.SelectedValue + " or t2.designation_id = " + cmb_designation.SelectedValue + "", con);
                ds = new DataSet();
                da.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
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
