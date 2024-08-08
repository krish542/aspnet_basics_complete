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
    public partial class statecity : Form
    {
        public statecity()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Krishna/source/repos/practice_main/practice.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        private void statecity_Load(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();            
            t1.SetToolTip(cmb_state, "Select State");
            t1.SetToolTip(cmb_city, "Select City");
            try
            {
                con.Open();
                da = new OleDbDataAdapter("select * from tbl_state",con);
                ds = new DataSet();
                da.Fill(ds);
                cmb_state.DataSource = ds.Tables[0];
                cmb_state.DisplayMember = "state_name";
                cmb_state.ValueMember = "state_id";
                cmb_state.SelectedValue = 0;

                da = new OleDbDataAdapter("select * from tbl_city", con);
                ds = new DataSet();
                da.Fill(ds);
                cmb_city.DataSource = ds.Tables[0];
                cmb_city.DisplayMember = "city_name";
                cmb_city.ValueMember = "city_id";
                //cmb_city.Enabled = false;

                da = new OleDbDataAdapter("select loc.employee_id, st.state_name, city.city_name from ((tbl_location as loc inner join tbl_city as city on loc.city_id =city.city_id )inner join tbl_state as st on loc.state_id=st.state_id )", con);
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

        private void cmb_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                da = new OleDbDataAdapter("select * from tbl_city where state_id = " +Convert.ToInt32(cmb_state.SelectedValue)+"", con);
                ds = new DataSet();
                da.Fill(ds);
                cmb_city.DataSource = ds.Tables[0];
                //cmb_city.Enabled = true;
                cmb_city.DisplayMember = "city_name";
                cmb_city.ValueMember = "city_id";
                cmb_city.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                
            }
        }

        private void dgv1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int i = dgv1.CurrentCell.RowIndex;
                da = new OleDbDataAdapter("select * from tbl_location", con);
                ds = new DataSet();
                da.Fill(ds);
                txt_id.Text = ds.Tables[0].Rows[i][0].ToString();
                cmb_state.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[i][1].ToString());
                if(i == 0)
                {
                    cmb_city.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[i][2].ToString());
                }
                else
                cmb_city.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[i][2].ToString()) % i; 
                //logic behind this is unknown for me but this works fine
                //the else block statement didn't work for i == 0 so added the if else condition

            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_index_Click(object sender, EventArgs e)
        {//selected Index starts from: 1
            try
            {
                if(rbtn_state.Checked == true)
                {
                    MessageBox.Show("Selected Index of State ComboBox: " + cmb_state.SelectedIndex );
                }
                else if(rbtn_city.Checked == true)
                {
                    MessageBox.Show("Selected Index of City ComboBox: " + cmb_city.SelectedIndex);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_item_Click(object sender, EventArgs e)
        {//gives the text of the selected item 
            try
            {
                if (rbtn_state.Checked == true)
                {
                    MessageBox.Show("Selected Item of State ComboBox: " + cmb_state.Text);
                }
                else if (rbtn_city.Checked == true)
                {
                    MessageBox.Show("Selected Item of City ComboBox: " + cmb_city.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_value_Click(object sender, EventArgs e)
        {
            //selected Value: starts from 0
            try
            {
                if (rbtn_state.Checked == true)
                {
                    MessageBox.Show("Selected Value of State ComboBox: " + cmb_state.SelectedValue);
                }
                else if (rbtn_city.Checked == true)
                {
                    MessageBox.Show("Selected Value of City ComboBox: " + cmb_city.SelectedValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
