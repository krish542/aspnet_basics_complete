
namespace practice_main
{
    partial class notepad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_new = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_datetime = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_wordwrap = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_font = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_zoom = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_zoomin = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_zoomout = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_zoomdef = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_status = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_color = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_rtb_color = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_rtb_bg = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_rtb_font = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_select_color = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_select_bg = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_select_font = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_text = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.menu_color});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_new,
            this.btn_open,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btn_new
            // 
            this.btn_new.Name = "btn_new";
            this.btn_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btn_new.Size = new System.Drawing.Size(224, 26);
            this.btn_new.Text = "New";
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            this.btn_new.MouseLeave += new System.EventHandler(this.btn_new_MouseLeave);
            this.btn_new.MouseHover += new System.EventHandler(this.btn_new_MouseHover);
            // 
            // btn_open
            // 
            this.btn_open.Name = "btn_open";
            this.btn_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btn_open.Size = new System.Drawing.Size(224, 26);
            this.btn_open.Text = "Open";
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            this.btn_open.MouseLeave += new System.EventHandler(this.btn_open_MouseLeave);
            this.btn_open.MouseHover += new System.EventHandler(this.btn_open_MouseHover);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            this.saveToolStripMenuItem.MouseLeave += new System.EventHandler(this.saveToolStripMenuItem_MouseLeave);
            this.saveToolStripMenuItem.MouseHover += new System.EventHandler(this.saveToolStripMenuItem_MouseHover);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseLeave += new System.EventHandler(this.exitToolStripMenuItem_MouseLeave);
            this.exitToolStripMenuItem.MouseHover += new System.EventHandler(this.exitToolStripMenuItem_MouseHover);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_undo,
            this.toolStripSeparator3,
            this.btn_copy,
            this.btn_cut,
            this.btn_paste,
            this.btn_delete,
            this.btn_datetime});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // btn_undo
            // 
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.btn_undo.Size = new System.Drawing.Size(187, 26);
            this.btn_undo.Text = "Undo";
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // btn_copy
            // 
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.btn_copy.Size = new System.Drawing.Size(187, 26);
            this.btn_copy.Text = "Copy";
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_cut
            // 
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.btn_cut.Size = new System.Drawing.Size(187, 26);
            this.btn_cut.Text = "Cut";
            this.btn_cut.Click += new System.EventHandler(this.btn_cut_Click);
            // 
            // btn_paste
            // 
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.btn_paste.Size = new System.Drawing.Size(187, 26);
            this.btn_paste.Text = "Paste";
            this.btn_paste.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.btn_delete.Size = new System.Drawing.Size(187, 26);
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_datetime
            // 
            this.btn_datetime.Name = "btn_datetime";
            this.btn_datetime.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.btn_datetime.Size = new System.Drawing.Size(187, 26);
            this.btn_datetime.Text = "Date/Time";
            this.btn_datetime.Click += new System.EventHandler(this.btn_datetime_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Checked = true;
            this.formatToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_wordwrap,
            this.btn_font});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // btn_wordwrap
            // 
            this.btn_wordwrap.Checked = true;
            this.btn_wordwrap.CheckOnClick = true;
            this.btn_wordwrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_wordwrap.Name = "btn_wordwrap";
            this.btn_wordwrap.Size = new System.Drawing.Size(168, 26);
            this.btn_wordwrap.Text = "Word Wrap";
            this.btn_wordwrap.Click += new System.EventHandler(this.btn_wordwrap_Click);
            // 
            // btn_font
            // 
            this.btn_font.Name = "btn_font";
            this.btn_font.Size = new System.Drawing.Size(168, 26);
            this.btn_font.Text = "Font";
            this.btn_font.Click += new System.EventHandler(this.btn_font_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_zoom,
            this.btn_status});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // btn_zoom
            // 
            this.btn_zoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_zoomin,
            this.btn_zoomout,
            this.btn_zoomdef});
            this.btn_zoom.Name = "btn_zoom";
            this.btn_zoom.Size = new System.Drawing.Size(158, 26);
            this.btn_zoom.Text = "Zoom";
            // 
            // btn_zoomin
            // 
            this.btn_zoomin.Name = "btn_zoomin";
            this.btn_zoomin.Size = new System.Drawing.Size(160, 26);
            this.btn_zoomin.Text = "Zoom In";
            this.btn_zoomin.Click += new System.EventHandler(this.btn_zoomin_Click);
            // 
            // btn_zoomout
            // 
            this.btn_zoomout.Name = "btn_zoomout";
            this.btn_zoomout.Size = new System.Drawing.Size(160, 26);
            this.btn_zoomout.Text = "Zoom Out";
            this.btn_zoomout.Click += new System.EventHandler(this.btn_zoomout_Click);
            // 
            // btn_zoomdef
            // 
            this.btn_zoomdef.Name = "btn_zoomdef";
            this.btn_zoomdef.Size = new System.Drawing.Size(160, 26);
            this.btn_zoomdef.Text = "Default";
            this.btn_zoomdef.Click += new System.EventHandler(this.btn_zoomdef_Click);
            // 
            // btn_status
            // 
            this.btn_status.Checked = true;
            this.btn_status.CheckOnClick = true;
            this.btn_status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(158, 26);
            this.btn_status.Text = "Status Bar";
            this.btn_status.Click += new System.EventHandler(this.btn_status_Click);
            // 
            // menu_color
            // 
            this.menu_color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_rtb_color,
            this.menu_select_color});
            this.menu_color.Name = "menu_color";
            this.menu_color.Size = new System.Drawing.Size(130, 24);
            this.menu_color.Text = "Color Properties";
            // 
            // menu_rtb_color
            // 
            this.menu_rtb_color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_rtb_bg,
            this.btn_rtb_font});
            this.menu_rtb_color.Name = "menu_rtb_color";
            this.menu_rtb_color.Size = new System.Drawing.Size(180, 26);
            this.menu_rtb_color.Text = "Rich Text Box";
            // 
            // btn_rtb_bg
            // 
            this.btn_rtb_bg.Name = "btn_rtb_bg";
            this.btn_rtb_bg.Size = new System.Drawing.Size(211, 26);
            this.btn_rtb_bg.Text = "Background Color";
            this.btn_rtb_bg.Click += new System.EventHandler(this.btn_rtb_bg_Click);
            // 
            // btn_rtb_font
            // 
            this.btn_rtb_font.Name = "btn_rtb_font";
            this.btn_rtb_font.Size = new System.Drawing.Size(211, 26);
            this.btn_rtb_font.Text = "Font Color";
            this.btn_rtb_font.Click += new System.EventHandler(this.btn_rtb_font_Click);
            // 
            // menu_select_color
            // 
            this.menu_select_color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_select_bg,
            this.btn_select_font});
            this.menu_select_color.Name = "menu_select_color";
            this.menu_select_color.Size = new System.Drawing.Size(180, 26);
            this.menu_select_color.Text = "Selected Text";
            // 
            // btn_select_bg
            // 
            this.btn_select_bg.Name = "btn_select_bg";
            this.btn_select_bg.Size = new System.Drawing.Size(211, 26);
            this.btn_select_bg.Text = "Background Color";
            this.btn_select_bg.Click += new System.EventHandler(this.btn_select_bg_Click);
            // 
            // btn_select_font
            // 
            this.btn_select_font.Name = "btn_select_font";
            this.btn_select_font.Size = new System.Drawing.Size(211, 26);
            this.btn_select_font.Text = "Font Color";
            this.btn_select_font.Click += new System.EventHandler(this.btn_select_font_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_text,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 23);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_text
            // 
            this.status_text.Name = "status_text";
            this.status_text.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 30;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 15);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 399);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "notepad";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.notepad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_new;
        private System.Windows.Forms.ToolStripMenuItem btn_open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btn_copy;
        private System.Windows.Forms.ToolStripMenuItem btn_cut;
        private System.Windows.Forms.ToolStripMenuItem btn_paste;
        private System.Windows.Forms.ToolStripMenuItem btn_delete;
        private System.Windows.Forms.ToolStripMenuItem btn_datetime;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_wordwrap;
        private System.Windows.Forms.ToolStripMenuItem btn_font;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_zoom;
        private System.Windows.Forms.ToolStripMenuItem btn_zoomin;
        private System.Windows.Forms.ToolStripMenuItem btn_zoomout;
        private System.Windows.Forms.ToolStripMenuItem btn_zoomdef;
        private System.Windows.Forms.ToolStripMenuItem btn_status;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripStatusLabel status_text;
        private System.Windows.Forms.ToolStripMenuItem menu_color;
        private System.Windows.Forms.ToolStripMenuItem menu_rtb_color;
        private System.Windows.Forms.ToolStripMenuItem btn_rtb_bg;
        private System.Windows.Forms.ToolStripMenuItem btn_rtb_font;
        private System.Windows.Forms.ToolStripMenuItem menu_select_color;
        private System.Windows.Forms.ToolStripMenuItem btn_select_bg;
        private System.Windows.Forms.ToolStripMenuItem btn_select_font;
    }
}