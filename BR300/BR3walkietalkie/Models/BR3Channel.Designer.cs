namespace BR300walkietalkie.Models
{
    partial class BR3Channel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridControl1 = new System.Windows.Forms.DataGridView();
            this.Channel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RXFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTCSDec = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CTCSEnc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TXPower = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ScanningAdd = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Clone = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WN = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BusyLock = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Scrambling = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Companding = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Repeater = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PPTID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRxFreq = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.AllowUserToAddRows = false;
            this.gridControl1.AllowUserToDeleteRows = false;
            this.gridControl1.AllowUserToResizeRows = false;
            this.gridControl1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridControl1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridControl1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridControl1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.gridControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridControl1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Channel,
            this.RXFrequency,
            this.TXFrequency,
            this.CTCSDec,
            this.CTCSEnc,
            this.TXPower,
            this.ScanningAdd,
            this.Clone,
            this.WN,
            this.BusyLock,
            this.Scrambling,
            this.Companding,
            this.Repeater,
            this.PPTID});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridControl1.DefaultCellStyle = dataGridViewCellStyle27;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MultiSelect = false;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RowHeadersVisible = false;
            this.gridControl1.RowTemplate.Height = 23;
            this.gridControl1.Size = new System.Drawing.Size(752, 576);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridControl1_CellEnter);
      
            this.gridControl1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridControl1_EditingControlShowing);
            // 
            // Channel
            // 
            this.Channel.DataPropertyName = "Channel";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Channel.DefaultCellStyle = dataGridViewCellStyle20;
            this.Channel.FillWeight = 30F;
            this.Channel.HeaderText = "CH.";
            this.Channel.MinimumWidth = 25;
            this.Channel.Name = "Channel";
            this.Channel.ReadOnly = true;
            this.Channel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Channel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RXFrequency
            // 
            this.RXFrequency.DataPropertyName = "RXFrequency";
            this.RXFrequency.FillWeight = 120F;
            this.RXFrequency.HeaderText = "RX Frequency";
            this.RXFrequency.Name = "RXFrequency";
            this.RXFrequency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RXFrequency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TXFrequency
            // 
            this.TXFrequency.DataPropertyName = "TXFrequency";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TXFrequency.DefaultCellStyle = dataGridViewCellStyle21;
            this.TXFrequency.FillWeight = 120F;
            this.TXFrequency.HeaderText = "TX Frequency";
            this.TXFrequency.Name = "TXFrequency";
            this.TXFrequency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TXFrequency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CTCSDec
            // 
            this.CTCSDec.DataPropertyName = "CTCSDec";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CTCSDec.DefaultCellStyle = dataGridViewCellStyle22;
            this.CTCSDec.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.CTCSDec.FillWeight = 90F;
            this.CTCSDec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CTCSDec.HeaderText = "RX Privacy";
            this.CTCSDec.Name = "CTCSDec";
            this.CTCSDec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CTCSEnc
            // 
            this.CTCSEnc.DataPropertyName = "CTCSEnc";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CTCSEnc.DefaultCellStyle = dataGridViewCellStyle23;
            this.CTCSEnc.FillWeight = 90F;
            this.CTCSEnc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CTCSEnc.HeaderText = "TX Privacy";
            this.CTCSEnc.Name = "CTCSEnc";
            // 
            // TXPower
            // 
            this.TXPower.DataPropertyName = "TXPower";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TXPower.DefaultCellStyle = dataGridViewCellStyle24;
            this.TXPower.FillWeight = 101.3596F;
            this.TXPower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TXPower.HeaderText = "Power";
            this.TXPower.Name = "TXPower";
            // 
            // ScanningAdd
            // 
            this.ScanningAdd.DataPropertyName = "ScanningAdd";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ScanningAdd.DefaultCellStyle = dataGridViewCellStyle25;
            this.ScanningAdd.FillWeight = 82.30465F;
            this.ScanningAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScanningAdd.HeaderText = "Scan Add";
            this.ScanningAdd.Name = "ScanningAdd";
            // 
            // Clone
            // 
            this.Clone.DataPropertyName = "Clone";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Clone.DefaultCellStyle = dataGridViewCellStyle26;
            this.Clone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clone.HeaderText = "Clone";
            this.Clone.Name = "Clone";
            this.Clone.Visible = false;
            // 
            // WN
            // 
            this.WN.DataPropertyName = "WN";
            this.WN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WN.HeaderText = "W/N";
            this.WN.Name = "WN";
            this.WN.Visible = false;
            // 
            // BusyLock
            // 
            this.BusyLock.DataPropertyName = "BusyLock";
            this.BusyLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BusyLock.HeaderText = "BusyLock";
            this.BusyLock.Name = "BusyLock";
            this.BusyLock.Visible = false;
            // 
            // Scrambling
            // 
            this.Scrambling.DataPropertyName = "Scrambling";
            this.Scrambling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Scrambling.HeaderText = "Scramble";
            this.Scrambling.Name = "Scrambling";
            this.Scrambling.Visible = false;
            // 
            // Companding
            // 
            this.Companding.DataPropertyName = "Companding";
            this.Companding.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Companding.HeaderText = "Companding";
            this.Companding.Name = "Companding";
            this.Companding.Visible = false;
            // 
            // Repeater
            // 
            this.Repeater.DataPropertyName = "Repeater";
            this.Repeater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Repeater.HeaderText = "Repeater";
            this.Repeater.Name = "Repeater";
            this.Repeater.ReadOnly = true;
            this.Repeater.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Repeater.Visible = false;
            // 
            // PPTID
            // 
            this.PPTID.DataPropertyName = "PPTID";
            this.PPTID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PPTID.HeaderText = "PPTID";
            this.PPTID.Name = "PPTID";
            this.PPTID.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Channel";
            this.dataGridViewTextBoxColumn1.FillWeight = 60.9137F;
            this.dataGridViewTextBoxColumn1.HeaderText = "CH.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 45;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RXFrequency";
            this.dataGridViewTextBoxColumn2.FillWeight = 103.5533F;
            this.dataGridViewTextBoxColumn2.HeaderText = "RXFreq(MHz)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TXFrequency";
            this.dataGridViewTextBoxColumn3.FillWeight = 103.5533F;
            this.dataGridViewTextBoxColumn3.HeaderText = "TXFreq(MHz)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 77;
            // 
            // cmbRxFreq
            // 
            this.cmbRxFreq.FormattingEnabled = true;
            this.cmbRxFreq.Location = new System.Drawing.Point(478, 427);
            this.cmbRxFreq.Name = "cmbRxFreq";
            this.cmbRxFreq.Size = new System.Drawing.Size(123, 20);
            this.cmbRxFreq.TabIndex = 2;
            this.cmbRxFreq.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRxFreq_KeyDown);
            this.cmbRxFreq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRxFreq_KeyPress);
            this.cmbRxFreq.Leave += new System.EventHandler(this.cmbRxFreq_Leave);
            // 
            // BR3Channel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 576);
            this.Controls.Add(this.cmbRxFreq);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BR3Channel";
            this.Text = "BR3Channel";
            this.Load += new System.EventHandler(this.BR3Channel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox cmbRxFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RXFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn TXFrequency;
        private System.Windows.Forms.DataGridViewComboBoxColumn CTCSDec;
        private System.Windows.Forms.DataGridViewComboBoxColumn CTCSEnc;
        private System.Windows.Forms.DataGridViewComboBoxColumn TXPower;
        private System.Windows.Forms.DataGridViewComboBoxColumn ScanningAdd;
        private System.Windows.Forms.DataGridViewComboBoxColumn Clone;
        private System.Windows.Forms.DataGridViewComboBoxColumn WN;
        private System.Windows.Forms.DataGridViewComboBoxColumn BusyLock;
        private System.Windows.Forms.DataGridViewComboBoxColumn Scrambling;
        private System.Windows.Forms.DataGridViewComboBoxColumn Companding;
        private System.Windows.Forms.DataGridViewComboBoxColumn Repeater;
        private System.Windows.Forms.DataGridViewComboBoxColumn PPTID;
    }
}