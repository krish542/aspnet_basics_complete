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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            ToolTip t1 = new ToolTip();
            t1.UseAnimation = true; // a value determining whether an animation effect should be used when displaying the ToolTip
            t1.ToolTipTitle = "Applications"; //Title of tooltip window
            t1.UseFading = true; //Represents whether a fade effect should be used when displaying the tooltip
            t1.ToolTipIcon = ToolTipIcon.Info;//a value that defines the type of icon to be displayed alongside the ToolTip text... info,warning,error,none            
            t1.SetToolTip(btn_datacon, "Database Connection Program");
            t1.SetToolTip(btn_notepad, "Notepad Application");
            t1.SetToolTip(btn_calculator, "Calculator Application");
            t1.SetToolTip(btn_listbox, "ListBox Functionalities");
            t1.SetToolTip(btn_mdi, "Shows TreeView control functions as an MDI application");
            t1.SetToolTip(btn_citystate, "Cascasding ComboBox Filters\n(Filters City ComboBox based on Selected State)");
            t1.SetToolTip(label1, "Describes method of the correponding Form displayed or shown");
            t1.SetToolTip(label2, "Describes method of the correponding Form displayed or shown");
            t1.SetToolTip(label3, "Describes method of the correponding Form displayed or shown");
            ToolTip t2 = new ToolTip();
            t2.IsBalloon = true; //a value indicating whether the ToolTip should use a balloon window
            t2.ToolTipTitle = "Exit";
            t2.ToolTipIcon = ToolTipIcon.Warning;          
            t2.SetToolTip(btn_exit, "Exit Application");
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.Application.Exit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_datacon_Click(object sender, EventArgs e)
        {
            try
            {
                datacon frmdatacon = new datacon();
                frmdatacon.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_notepad_Click(object sender, EventArgs e)
        {
            try
            {
                notepad frmnote = new notepad();
                frmnote.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_calculator_Click(object sender, EventArgs e)
        {
            try
            {
                calculator frmcalc = new calculator();
                frmcalc.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_listbox_Click(object sender, EventArgs e)
        {
            try
            {
                listbox frmlist = new listbox();
                frmlist.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_mdi_Click(object sender, EventArgs e)
        {
            try
            {
                mdi frmmdi = new mdi();
                frmmdi.MdiParent = this.MdiParent;
                frmmdi.Dock = DockStyle.Right;
                frmmdi.TopMost = true;
                frmmdi.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_citystate_Click(object sender, EventArgs e)
        {
            try
            {
                statecity frmstate = new statecity();
                frmstate.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_txt_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                txt_refresh frmref = new txt_refresh();
                frmref.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_multicmb_Click(object sender, EventArgs e)
        {
            try
            {
                multicmb frmcmb = new multicmb();
                frmcmb.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_library_Click(object sender, EventArgs e)
        {
            try
            {
                Library_System frmcmb = new Library_System();
                frmcmb.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
