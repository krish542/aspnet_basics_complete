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
    public partial class homepage_Student : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Krishna/source/repos/librarysystem.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        OleDbCommand cmd = new OleDbCommand();
        public homepage_Student()
        {
            InitializeComponent();
        }
        string usernm = null;
        private void homepage_Student_Load(object sender, EventArgs e)
        {
            usernm = Library_System.setuser;
            //MessageBox.Show(usernm);
        }

        private void viewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_class.Visible = true;
            lbl_classupdate.Visible = true;
            lbl_id.Visible = true;
            lbl_idupdate.Visible = true;
            lbl_name.Visible = true;
            lbl_nameupdate.Visible = true;
            lbl_stream.Visible = true;
            lbl_streamupdate.Visible = true;
            btn_updatedet.Visible = true;
            con.Open();
            da = new OleDbDataAdapter("select * from detstud where student_id = '"+usernm+"'", con);
            ds = new DataSet();
            da.Fill(ds);
            lbl_nameupdate.Text = ds.Tables[0].Rows[0][1].ToString();
            lbl_streamupdate.Text = ds.Tables[0].Rows[0][2].ToString();
            lbl_classupdate.Text = ds.Tables[0].Rows[0][3].ToString();
            lbl_idupdate.Text = ds.Tables[0].Rows[0][0].ToString();
            con.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
                Library_System frmlib = new Library_System();
                frmlib.ShowDialog();
            }
        }

        private void btn_updatedet_Click(object sender, EventArgs e)
        {
            con.Open();
            
            con.Close();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_class.Visible = true;
            txt_name.Visible = true;
            txt_stream.Visible = true;
            txt_studid.Visible = true;
        }
    }
}
