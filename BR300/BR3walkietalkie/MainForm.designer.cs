namespace BR300walkietalkie
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFromRadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commonicationPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sideKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commericalFrequencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mondelName = new System.Windows.Forms.ToolStripDropDownButton();
            this.barPanel = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.barPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileItem,
            this.editItem,
            this.portItem,
            this.helpItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 34);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileItem
            // 
            this.fileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewItem,
            this.openItem,
            this.toolStripSeparator1,
            this.saveItem,
            this.saveAsItem,
            this.toolStripSeparator2,
            this.printToolStripMenuItem,
            this.exitItem});
            this.fileItem.Name = "fileItem";
            this.fileItem.Size = new System.Drawing.Size(39, 21);
            this.fileItem.Text = "File";
            // 
            // NewItem
            // 
            this.NewItem.Name = "NewItem";
            this.NewItem.Size = new System.Drawing.Size(121, 22);
            this.NewItem.Text = "New";
            this.NewItem.Click += new System.EventHandler(this.btnNew_ItemClick);
            // 
            // openItem
            // 
            this.openItem.Name = "openItem";
            this.openItem.Size = new System.Drawing.Size(121, 22);
            this.openItem.Text = "Open";
            this.openItem.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // saveItem
            // 
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(121, 22);
            this.saveItem.Text = "Save";
            this.saveItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // saveAsItem
            // 
            this.saveAsItem.Name = "saveAsItem";
            this.saveAsItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsItem.Text = "Save As";
            this.saveAsItem.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(118, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(121, 22);
            this.exitItem.Text = "Exit";
            // 
            // editItem
            // 
            this.editItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeToolStripMenuItem,
            this.readFromRadioToolStripMenuItem});
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(71, 21);
            this.editItem.Text = "Program";
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.writeToolStripMenuItem.Text = "Write to Radio";
            this.writeToolStripMenuItem.Click += new System.EventHandler(this.writeToolStripMenuItem_Click);
            // 
            // readFromRadioToolStripMenuItem
            // 
            this.readFromRadioToolStripMenuItem.Name = "readFromRadioToolStripMenuItem";
            this.readFromRadioToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.readFromRadioToolStripMenuItem.Text = "Read from Radio";
            this.readFromRadioToolStripMenuItem.Click += new System.EventHandler(this.readFromRadioToolStripMenuItem_Click);
            // 
            // portItem
            // 
            this.portItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commonicationPortToolStripMenuItem,
            this.sideKeyToolStripMenuItem,
            this.advanToolStripMenuItem,
            this.defaultToolStripMenuItem,
            this.commericalFrequencyToolStripMenuItem});
            this.portItem.Name = "portItem";
            this.portItem.Size = new System.Drawing.Size(66, 21);
            this.portItem.Text = "Settings";
            // 
            // commonicationPortToolStripMenuItem
            // 
            this.commonicationPortToolStripMenuItem.Name = "commonicationPortToolStripMenuItem";
            this.commonicationPortToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.commonicationPortToolStripMenuItem.Text = "COM Port";
            this.commonicationPortToolStripMenuItem.Click += new System.EventHandler(this.commonicationPortToolStripMenuItem_Click);
            // 
            // sideKeyToolStripMenuItem
            // 
            this.sideKeyToolStripMenuItem.Name = "sideKeyToolStripMenuItem";
            this.sideKeyToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.sideKeyToolStripMenuItem.Text = "Side Key";
            this.sideKeyToolStripMenuItem.Click += new System.EventHandler(this.sideKeyToolStripMenuItem_Click);
            // 
            // advanToolStripMenuItem
            // 
            this.advanToolStripMenuItem.Name = "advanToolStripMenuItem";
            this.advanToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.advanToolStripMenuItem.Text = "Advanced";
            this.advanToolStripMenuItem.Click += new System.EventHandler(this.advanToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // commericalFrequencyToolStripMenuItem
            // 
            this.commericalFrequencyToolStripMenuItem.Name = "commericalFrequencyToolStripMenuItem";
            this.commericalFrequencyToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.commericalFrequencyToolStripMenuItem.Text = "Commerical Frequency";
            this.commericalFrequencyToolStripMenuItem.Visible = false;
            this.commericalFrequencyToolStripMenuItem.Click += new System.EventHandler(this.commericalFrequencyToolStripMenuItem_Click);
            // 
            // helpItem
            // 
            this.helpItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abortToolStripMenuItem});
            this.helpItem.Name = "helpItem";
            this.helpItem.Size = new System.Drawing.Size(47, 21);
            this.helpItem.Text = "Help";
            this.helpItem.Visible = false;
            // 
            // abortToolStripMenuItem
            // 
            this.abortToolStripMenuItem.Name = "abortToolStripMenuItem";
            this.abortToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.abortToolStripMenuItem.Text = "About...";
            this.abortToolStripMenuItem.Click += new System.EventHandler(this.abortToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.mondelName});
            this.statusStrip1.Location = new System.Drawing.Point(5, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(693, 23);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 18);
            // 
            // mondelName
            // 
            this.mondelName.Name = "mondelName";
            this.mondelName.Size = new System.Drawing.Size(42, 21);
            this.mondelName.Text = "709";
            this.mondelName.Click += new System.EventHandler(this.mondelName_Click);
            this.mondelName.MouseEnter += new System.EventHandler(this.mondelName_MouseEnter);
            // 
            // barPanel
            // 
            this.barPanel.Controls.Add(this.btnSetting);
            this.barPanel.Controls.Add(this.panel7);
            this.barPanel.Controls.Add(this.panel6);
            this.barPanel.Controls.Add(this.btnPrint);
            this.barPanel.Controls.Add(this.btnWrite);
            this.barPanel.Controls.Add(this.btnRead);
            this.barPanel.Controls.Add(this.btnSaveAs);
            this.barPanel.Controls.Add(this.btnSave);
            this.barPanel.Controls.Add(this.btnOpen);
            this.barPanel.Controls.Add(this.btnNew);
            this.barPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.barPanel.Location = new System.Drawing.Point(5, 59);
            this.barPanel.Name = "barPanel";
            this.barPanel.Size = new System.Drawing.Size(693, 45);
            this.barPanel.TabIndex = 3;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.BackgroundImage")));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(291, 7);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(32, 32);
            this.btnSetting.TabIndex = 14;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Location = new System.Drawing.Point(281, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(4, 32);
            this.panel7.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(175, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 32);
            this.panel6.TabIndex = 12;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(132, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 32);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.Transparent;
            this.btnWrite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWrite.BackgroundImage")));
            this.btnWrite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWrite.FlatAppearance.BorderSize = 0;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrite.Location = new System.Drawing.Point(234, 2);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(36, 36);
            this.btnWrite.TabIndex = 7;
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.Transparent;
            this.btnRead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRead.BackgroundImage")));
            this.btnRead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRead.FlatAppearance.BorderSize = 0;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Location = new System.Drawing.Point(189, 3);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(36, 36);
            this.btnRead.TabIndex = 6;
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.BackgroundImage")));
            this.btnSaveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveAs.FlatAppearance.BorderSize = 0;
            this.btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAs.Location = new System.Drawing.Point(628, 11);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(16, 16);
            this.btnSaveAs.TabIndex = 3;
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Visible = false;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(92, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpen.BackgroundImage")));
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(51, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(32, 32);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(14, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(32, 32);
            this.btnNew.TabIndex = 0;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_ItemClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(89, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 22);
            this.panel2.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Location = new System.Drawing.Point(5, 104);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(693, 397);
            this.panel5.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(703, 529);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.barPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Midland BR300 Programming Software";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.barPanel, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.barPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileItem;
        private System.Windows.Forms.ToolStripMenuItem NewItem;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ToolStripMenuItem editItem;
        private System.Windows.Forms.ToolStripMenuItem portItem;
        private System.Windows.Forms.ToolStripMenuItem helpItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel barPanel;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ToolStripMenuItem readFromRadioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commonicationPortToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem abortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ToolStripMenuItem commericalFrequencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sideKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton mondelName;
        private System.Windows.Forms.Panel panel5;
    }
}