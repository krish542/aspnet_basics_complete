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
    public partial class notepad : Form
    {        
        public notepad()
        {
            InitializeComponent();
        }
        
        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text != null)
                {
                    DialogResult dr = MessageBox.Show("Do you want to save ?", "New text", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            {
                                //MessageBox.Show("Save");
                                SaveFileDialog saveFile = new SaveFileDialog();
                                saveFile.DefaultExt = "*.txt";
                                saveFile.Filter = "TEXT Files | *.txt";

                                if (saveFile.ShowDialog() == DialogResult.OK)
                                {
                                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                                        sw.WriteLine(richTextBox1.Text);
                                }
                                richTextBox1.Clear();
                                break;
                            }
                        case DialogResult.No:
                            //MessageBox.Show("Do Not Save!");
                            richTextBox1.Clear();
                            break;

                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"E:\";
            ofd.Filter = "txt files|*.txt|all files|*.*";
            ofd.FilterIndex = 1; //2 based index//default 1

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.DefaultExt = "*.txt";
            sfd.Filter = "TEXT Files|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName))
                    sw.WriteLine(richTextBox1.Text);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Do you want to exit?", "Exit",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
            }
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Copy();
            }
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
                richTextBox1.Paste();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
                richTextBox1.SelectedText = "";
        }

        private void btn_datetime_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + (DateTime.Now.ToString());
        }

        private void btn_wordwrap_Click(object sender, EventArgs e)
        {
            if (btn_wordwrap.Checked)
            {
                richTextBox1.WordWrap = true;
            }
            else
            {
                richTextBox1.WordWrap = false;
            }

        }

        private void btn_font_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.AllowScriptChange = false; //western,hebrew....
            fontDialog1.AllowSimulations = false; //bold,italic...
            fontDialog1.MinSize = 12;
            fontDialog1.MaxSize = 24;
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;

        }

        private void btn_zoomin_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = richTextBox1.ZoomFactor + 1f;
        }

        private void btn_zoomout_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = richTextBox1.ZoomFactor - 1f;
        }

        private void btn_zoomdef_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1;
        }

        private void btn_status_Click(object sender, EventArgs e)
        {
            if (btn_status.Checked)
            {
                statusStrip1.Visible = true;
            }
            else
            {
                statusStrip1.Visible = false;
            }
        }

        private void btn_new_MouseHover(object sender, EventArgs e)
        {
            status_text.Text = "New file";
        }

        private void btn_new_MouseLeave(object sender, EventArgs e)
        {
            status_text.Text = "";
        }

        private void btn_open_MouseHover(object sender, EventArgs e)
        {
            status_text.Text = "Open file";
        }

        private void btn_open_MouseLeave(object sender, EventArgs e)
        {
            status_text.Text = "";
        }

        private void saveToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            status_text.Text = "Save file";
        }

        private void saveToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            status_text.Text = "";
        }

        private void exitToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            status_text.Text = "Exit Notepad";
        }

        private void exitToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            status_text.Text = "";
        }

        private void notepad_Load(object sender, EventArgs e)
        {      
            //shows tooltips of the menu strip items
            btn_undo.ToolTipText = "Undo last action";
            btn_copy.ToolTipText = "Copy Selected Text";
            btn_cut.ToolTipText = "Cut Selected Text";
            btn_paste.ToolTipText = "Paste from Clipboard";
            btn_delete.ToolTipText = "Delete Selected Text";
            btn_datetime.ToolTipText = "Adds present Date and Time to your text";
            btn_wordwrap.ToolTipText = "Wrap text or Not";
            btn_font.ToolTipText = "Change font styles";
            btn_zoomin.ToolTipText = "Zoom In the Text";
            btn_zoomout.ToolTipText = "Zoom Out the Text";
            btn_zoomdef.ToolTipText = "Default Zoom";
            btn_status.ToolTipText = "Show Status Bar or not";
            btn_rtb_bg.ToolTipText = "Change Background Color of Rich Text Box";
            btn_rtb_font.ToolTipText = "Change Font color of Rich Text Box";
            btn_select_bg.ToolTipText = "Change background color of Selected Text";
            btn_select_font.ToolTipText = "Change font color of Selected Text";
            //info displayed in richtextbox when loaded(not necessary)
            richTextBox1.Text = "1. Add Menu strip and controls(items) required\n2.Add richTextBox\n3.Add Statustrip(Added a StatusLabel which shows tool tips of file Menu)\n\n* Set Shortcuts for the menu Items as required(ShortcutKeys Property(misc)) \n* For Word Wrap(in Format Menu) and Status Bar(in View Menu) check or set CheckOnClick property(Behavior) = true\n* Color Properties Menu: sets the color of background or font of the complete richTextBox or of Seleted text";
        }

        private void btn_rtb_bg_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if(color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = color.Color;
            }
        }

        private void btn_rtb_font_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = color.Color;
            }
        }

        private void btn_select_bg_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (richTextBox1.SelectedText != "")
            {
                if (color.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionBackColor = color.Color;
                }
            }
            else
            {
                MessageBox.Show("Select Required text");
            }
        }

        private void btn_select_font_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (richTextBox1.SelectedText != "")
            {
                if (color.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = color.Color;
                }
            }
            else
            {
                MessageBox.Show("Select Required text");
            }
        }
    }
}
