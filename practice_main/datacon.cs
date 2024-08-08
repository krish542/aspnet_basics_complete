using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_main
{
    public partial class datacon : Form
    {
        public datacon()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Krishna/source/repos/practice_main/practice.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        int i;

        private void Form3_Load(object sender, EventArgs e)
        {
            //setting tool tips
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(btn_view, "View All records");
            t1.SetToolTip(btn_insert, "Insert New Record");
            t1.SetToolTip(btn_update, "Update a Record");
            t1.SetToolTip(btn_delete, "Delete a Record");
            t1.SetToolTip(btn_search, "Search By ID\nTextBox");
            t1.SetToolTip(btn_srch_dept, "Search By Department\nComboBox");
            t1.SetToolTip(btn_next, "View Next Record");
            t1.SetToolTip(btn_prev, "View Previous Record");
            t1.SetToolTip(txt_id, "Employee ID");
            t1.SetToolTip(txt_name, "Employee Name");
            t1.SetToolTip(txt_img, "Image Path");
            t1.SetToolTip(cmb_dept, "Department");
            t1.SetToolTip(clb_hobbies, "Hobbies");
            t1.SetToolTip(cb_view, "Hide DataGridView");
            t1.SetToolTip(cb_view_pic, "Hide Picturebox");
            t1.SetToolTip(btn_browse, "Browse Image in PictureBox");            
            t1.SetToolTip(pictureBox1, "PictureBox");
            try
            {    
                //populate ComboBox from database
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

        private void cb_view_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox to view or hide dataGridView
            try
            {
                if(cb_view.Checked)
                {
                    dgv1.Visible = true;
                }
                else
                {
                    dgv1.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_view_pic_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox to view or Hide PictureBox
            try
            {
                if (cb_view_pic.Checked)
                {
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            //view all records of Table1 in DataGridView
            try
            {
                con.Open();
                da = new OleDbDataAdapter("select * from Table1", con);
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

        private void btn_insert_Click(object sender, EventArgs e)
        { 
            //insert a record in Table1
            try
            {
                string strhobby = "";
                string strgend = "";
                con.Open();
                //create a common string to be updated for multiple hobbies selected
                if (clb_hobbies.CheckedItems.Count!=0)
                {
                    for(int i = 0; i <clb_hobbies.CheckedItems.Count;i++)
                    {
                        strhobby += clb_hobbies.CheckedItems[i]+" "; 
                    }
                }
                else
                {
                    MessageBox.Show("Select Hobbies");
                }
                //create a string to check the gender selected
                if (rbtn_male.Checked == true)
                {
                    strgend += "Male";
                }
                else if(rbtn_female.Checked == true)
                {
                    strgend += "Female";
                }
                cmd = new OleDbCommand();
                //DataTypes in Database Table
                //name, imagepath, hobbies, gender: Short Text
                //id, dept_id: Number
                //dob: Date/Time
                cmd.CommandText = "INSERT INTO Table1(id,employee_name,imagepath,dept_id,hobbies,gender,dob) VALUES('" + txt_id.Text+"','"+txt_name.Text+"','"+txt_img.Text+"','"+cmb_dept.SelectedValue+ "','" + Convert.ToString(strhobby) + "','" + Convert.ToString(strgend) + "','" + dateTimePicker1.Value.Date + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted");                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            //View Previous Record
            try
            {
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Table1", con);                
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (i != 0)//prev: i!=0; i = i - 1 in if block; else - messabebox(first record), i = 0
                {
                    i = i - 1;
                    txt_id.Text = ds.Tables[0].Rows[i][0].ToString();
                    txt_name.Text = ds.Tables[0].Rows[i][1].ToString();
                    txt_img.Text = ds.Tables[0].Rows[i][2].ToString();
                    cmb_dept.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[i][3].ToString());
                    if(ds.Tables[0].Rows[i][5].ToString() == "male")
                    {
                        rbtn_male.Checked = true;
                    }
                    else
                    {
                        rbtn_female.Checked = true;
                    }
                    dateTimePicker1.Value = Convert.ToDateTime(ds.Tables[0].Rows[i][6]);
                    pictureBox1.Image = Image.FromFile(ds.Tables[0].Rows[i][2].ToString());
                }
                else
                {
                    MessageBox.Show("first record");
                    i = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            //View Next Record
            try
            {
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Table1", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (i != ds.Tables[0].Rows.Count)//Next: i!= count; i = i + 1 in if block; else block - messagebox(last record),i=rowcount - 1
                {
                    txt_id.Text = ds.Tables[0].Rows[i][0].ToString();
                    txt_name.Text = ds.Tables[0].Rows[i][1].ToString();
                    txt_img.Text = ds.Tables[0].Rows[i][2].ToString();
                    cmb_dept.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[i][3].ToString());
                    if (ds.Tables[0].Rows[i][5].ToString() == "male")
                    {
                        rbtn_male.Checked = true;
                    }
                    else
                    {
                        rbtn_female.Checked = true;
                    }

                    dateTimePicker1.Value = Convert.ToDateTime(ds.Tables[0].Rows[i][6]);
                    pictureBox1.Image = Image.FromFile(ds.Tables[0].Rows[i][2].ToString());
                    i = i + 1;                    
                }
                else
                {
                    MessageBox.Show("last record");
                    i = ds.Tables[0].Rows.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //Update a Record in Table1
            try
            {
                string strhobby = "";
                string strgend = "";
                con.Open();
                //create a common string to be updated for multiple hobbies selected
                if (clb_hobbies.CheckedItems.Count != 0)
                {
                    for (int i = 0; i < clb_hobbies.CheckedItems.Count; i++)
                    {
                        strhobby += clb_hobbies.CheckedItems[i] + " ";
                    }
                }
                else
                {
                    MessageBox.Show("Select Hobbies");
                }
                //create a string to check the gender selected
                if (rbtn_male.Checked == true)
                {
                    strgend += "Male";
                }
                else if (rbtn_female.Checked == true)
                {
                    strgend += "Female";
                }
                //DataTypes in Database Table
                //name, imagepath, hobbies, gender: Short Text
                //id, dept_id: Number
                //dob: Date/

                cmd.CommandText = "Update Table1 set employee_name = '"+txt_name.Text+"',imagepath = '"+txt_img.Text+"',dept_id = '"+cmb_dept.SelectedValue+"',hobbies = '"+Convert.ToString(strhobby)+"',gender = '"+Convert.ToString(strgend)+"',dob = '"+dateTimePicker1.Value.Date+"' where id = "+txt_id.Text+"";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //Delete the Record where ID is mentioned
            try
            {
                con.Open();
                cmd.CommandText = "delete from Table1 where id = "+txt_id.Text+"";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            //Browse Image in PictureBox and Show its path in txt_img(path should be described in textbox if we want to Update a record, hence path is IMP)
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "jpg file (*.jpg)|*.jpg|png (*.png)|*.png|all file(*.*)|*.*"; //filter for types of file to be filtered in openFileDialog
            img.InitialDirectory = "C:";//sets the initial directory from where the dialog will be initialised
            //Dialog Result: Cancel,OK,Yes,No,None            
            if (img.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(img.FileName);
                txt_img.Text = img.FileName;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //Search the record from Table1 where ID is mentioned 
            //ID is Unique therefore can be shown in TextBoxes and ComboBox
            try
            {
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Table1 where id = "+txt_id.Text+"", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                i = 0;
                if (i != ds.Tables[0].Rows.Count)
                {
                    txt_id.Text = ds.Tables[0].Rows[i][0].ToString();
                    txt_name.Text = ds.Tables[0].Rows[i][1].ToString();
                    txt_img.Text = ds.Tables[0].Rows[i][2].ToString();
                    cmb_dept.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[i][3].ToString());
                    if (ds.Tables[0].Rows[i][5].ToString() == "male")
                    {
                        rbtn_male.Checked = true;
                    }
                    else
                    {
                        rbtn_female.Checked = true;
                    }

                    dateTimePicker1.Value = Convert.ToDateTime(ds.Tables[0].Rows[i][6]);
                    pictureBox1.Image = Image.FromFile(ds.Tables[0].Rows[i][2].ToString());
                    dgv1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //check application 5
        }

        private void btn_srch_dept_Click(object sender, EventArgs e)
        {
            //Search Records Based on the selection of Department and show in DataGridView
            //Department can be Common for multiple Employees, hence showing it individually in TextBoxes and ComboBox is not possible
            try
            {
                con.Open();
                da = new OleDbDataAdapter("select * from Table1 where dept_id = " + cmb_dept.SelectedValue + "", con);
                ds = new DataSet();
                da.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
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