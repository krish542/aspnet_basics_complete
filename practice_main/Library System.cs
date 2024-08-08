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
    public partial class Library_System : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Krishna/source/repos/librarysystem.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        OleDbCommand cmd = new OleDbCommand();
        public Library_System()
        {
            InitializeComponent();
        }

        public static string setuser = null;
        private void Library_System_Load(object sender, EventArgs e)
        {
            txt_pswd.PasswordChar = '*';
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            string username = txt_usrnm.Text;
            string pass = txt_pswd.Text;
            cmd = new OleDbCommand("select usrnm,pswd from logindet where usrnm = '" + txt_usrnm.Text + "' and pswd = '" + txt_pswd.Text + "'", con);
            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                MessageBox.Show("Login Successful");
                this.Hide();

                da = new OleDbDataAdapter("select * from logindet where usrnm = '"+txt_usrnm.Text+"'",con);
                ds = new DataSet();
                da.Fill(ds);         
                if(ds.Tables[0].Rows[0][3].ToString() == "1")
                {
                    setuser = ds.Tables[0].Rows[0][0].ToString();
                    homepage_Staff frmstf = new homepage_Staff();
                    frmstf.ShowDialog();
                }
                else if(ds.Tables[0].Rows[0][3].ToString() == "2")
                {
                    setuser = ds.Tables[0].Rows[0][0].ToString();
                    homepage_Student frmhome = new homepage_Student();
                    frmhome.ShowDialog();
                }                
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Login Failed!");
            }
            con.Close();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            register frmreg = new register();
            frmreg.ShowDialog();
        }
    }
}
