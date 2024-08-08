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
    public partial class register : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Krishna\source\repos\librarysystem.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            cmb_class.SelectedItem = null;
            cmb_dept.SelectedItem = null;
            txt_pswd.PasswordChar = '*';
        }

        private void rbtn_student_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(rbtn_student.Checked == true)
                {
                    lbl_dept.Visible = true;
                    lbl_class.Visible = true;
                    lbl_eno.Visible = true;
                    cmb_dept.Visible = true;
                    cmb_class.Visible = true;
                    txt_eno.Visible = true;
                }
                else
                {
                    lbl_dept.Visible = false;
                    lbl_class.Visible = false;
                    lbl_eno.Visible = false;
                    cmb_dept.Visible = false;
                    cmb_class.Visible = false;
                    txt_eno.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbtn_staff_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(rbtn_staff.Checked == true)
                {
                    rbtn_lecturer.Visible = true;
                    rbtn_librarian.Visible = true;
                    lbl_stfno.Visible = true;
                    txt_stfno.Visible = true;
                }
                else
                {
                    rbtn_librarian.Visible = false;
                    rbtn_lecturer.Visible = false;
                    lbl_stfno.Visible = false;
                    txt_stfno.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if(txt_name.Text != "")
                {
                    if(txt_usrnm.Text != "")
                    {
                        if(txt_pswd.Text != "")
                        {
                            if (rbtn_student.Checked == true)
                            {
                                int category = 2;
                                OleDbCommand cmd1 = new OleDbCommand("insert into detstud (student_id,student_name,stream,class) values ('"+txt_eno.Text+"','"+txt_name.Text+"','"+cmb_dept.Text+"','"+cmb_class.Text+"')", con);
                                cmd1.ExecuteNonQuery();
                                cmd = new OleDbCommand("insert into logindet(user_id,usrnm,pswd,category_id) values('"+txt_eno.Text+"','"+txt_usrnm.Text+"','"+txt_pswd.Text+"',"+category+")", con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Thank you for Registering!","Registered");
                                this.Hide();
                            }
                            else if (rbtn_staff.Checked == true)
                            {
                                int category = 1;
                                string position = null;
                                if(rbtn_lecturer.Checked == true)
                                {
                                    position = "lecturer";
                                }
                                else if (rbtn_librarian.Checked == true)
                                {
                                    position = "librarian";
                                }
                                OleDbCommand cmd1 = new OleDbCommand("insert into detstaff(staff_id,staff_name,pos) values ('"+txt_stfno.Text+"','"+txt_name.Text+"','"+position+"')", con);
                                cmd1.ExecuteNonQuery();
                                cmd = new OleDbCommand("insert into logindet(user_id,usrnm,pswd,category_id) values('"+txt_stfno.Text+"','"+txt_usrnm.Text+"','"+txt_pswd.Text+"',"+category+")", con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Thank you for Registering!", "Registered");
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Select Category!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Password!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Username!");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Name!");
                }
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
