namespace BR300walkietalkie.Models
{
    partial class AdvancedForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTimeOut = new System.Windows.Forms.ComboBox();
            this.cmbSque = new System.Windows.Forms.ComboBox();
            this.cmbVoice = new System.Windows.Forms.ComboBox();
            this.cmbBatte = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbVoxLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBrightnessLev = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPowOnName = new System.Windows.Forms.TextBox();
            this.cmbScanMode = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkKeyTone = new System.Windows.Forms.CheckBox();
            this.chkRogerBeep = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Time-Out Timer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Squelch Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Voice Annunciation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "Battery Save Mode";
            // 
            // cmbTimeOut
            // 
            this.cmbTimeOut.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbTimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTimeOut.FormattingEnabled = true;
            this.cmbTimeOut.Items.AddRange(new object[] {
            "Off",
            "30",
            "60",
            "90",
            "120",
            "150",
            "180",
            "210",
            "240",
            "270",
            "300"});
            this.cmbTimeOut.Location = new System.Drawing.Point(148, 44);
            this.cmbTimeOut.Name = "cmbTimeOut";
            this.cmbTimeOut.Size = new System.Drawing.Size(108, 20);
            this.cmbTimeOut.TabIndex = 14;
            // 
            // cmbSque
            // 
            this.cmbSque.BackColor = System.Drawing.Color.LightGray;
            this.cmbSque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSque.FormattingEnabled = true;
            this.cmbSque.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbSque.Location = new System.Drawing.Point(148, 70);
            this.cmbSque.Name = "cmbSque";
            this.cmbSque.Size = new System.Drawing.Size(108, 20);
            this.cmbSque.TabIndex = 15;
            // 
            // cmbVoice
            // 
            this.cmbVoice.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVoice.FormattingEnabled = true;
            this.cmbVoice.Items.AddRange(new object[] {
            "None",
            "English"});
            this.cmbVoice.Location = new System.Drawing.Point(148, 96);
            this.cmbVoice.Name = "cmbVoice";
            this.cmbVoice.Size = new System.Drawing.Size(108, 20);
            this.cmbVoice.TabIndex = 16;
            // 
            // cmbBatte
            // 
            this.cmbBatte.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbBatte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBatte.FormattingEnabled = true;
            this.cmbBatte.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbBatte.Location = new System.Drawing.Point(148, 123);
            this.cmbBatte.Name = "cmbBatte";
            this.cmbBatte.Size = new System.Drawing.Size(108, 20);
            this.cmbBatte.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbVoxLevel
            // 
            this.cmbVoxLevel.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbVoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoxLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbVoxLevel.FormattingEnabled = true;
            this.cmbVoxLevel.Items.AddRange(new object[] {
            "Off",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbVoxLevel.Location = new System.Drawing.Point(148, 149);
            this.cmbVoxLevel.Name = "cmbVoxLevel";
            this.cmbVoxLevel.Size = new System.Drawing.Size(108, 20);
            this.cmbVoxLevel.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "Power On Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "Vox Level";
            // 
            // cmbBrightnessLev
            // 
            this.cmbBrightnessLev.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbBrightnessLev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrightnessLev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBrightnessLev.FormattingEnabled = true;
            this.cmbBrightnessLev.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbBrightnessLev.Location = new System.Drawing.Point(148, 201);
            this.cmbBrightnessLev.Name = "cmbBrightnessLev";
            this.cmbBrightnessLev.Size = new System.Drawing.Size(108, 20);
            this.cmbBrightnessLev.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "Brightness level";
            // 
            // txtPowOnName
            // 
            this.txtPowOnName.Location = new System.Drawing.Point(148, 175);
            this.txtPowOnName.Name = "txtPowOnName";
            this.txtPowOnName.Size = new System.Drawing.Size(108, 21);
            this.txtPowOnName.TabIndex = 30;
            this.txtPowOnName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPowOnName_KeyPress);
            // 
            // cmbScanMode
            // 
            this.cmbScanMode.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbScanMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScanMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbScanMode.FormattingEnabled = true;
            this.cmbScanMode.Items.AddRange(new object[] {
            "Carrier",
            "Time"});
            this.cmbScanMode.Location = new System.Drawing.Point(148, 228);
            this.cmbScanMode.Name = "cmbScanMode";
            this.cmbScanMode.Size = new System.Drawing.Size(108, 20);
            this.cmbScanMode.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "Scan Mode";
            // 
            // chkKeyTone
            // 
            this.chkKeyTone.AutoSize = true;
            this.chkKeyTone.Location = new System.Drawing.Point(44, 254);
            this.chkKeyTone.Name = "chkKeyTone";
            this.chkKeyTone.Size = new System.Drawing.Size(72, 16);
            this.chkKeyTone.TabIndex = 33;
            this.chkKeyTone.Text = "Key Tone";
            this.chkKeyTone.UseVisualStyleBackColor = true;
            // 
            // chkRogerBeep
            // 
            this.chkRogerBeep.AutoSize = true;
            this.chkRogerBeep.Location = new System.Drawing.Point(148, 254);
            this.chkRogerBeep.Name = "chkRogerBeep";
            this.chkRogerBeep.Size = new System.Drawing.Size(84, 16);
            this.chkRogerBeep.TabIndex = 34;
            this.chkRogerBeep.Text = "Roger Beep";
            this.chkRogerBeep.UseVisualStyleBackColor = true;
            // 
            // AdvancedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 358);
            this.Controls.Add(this.chkRogerBeep);
            this.Controls.Add(this.chkKeyTone);
            this.Controls.Add(this.cmbScanMode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPowOnName);
            this.Controls.Add(this.cmbBrightnessLev);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbVoxLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbBatte);
            this.Controls.Add(this.cmbVoice);
            this.Controls.Add(this.cmbSque);
            this.Controls.Add(this.cmbTimeOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdvancedForm";
            this.Text = "Advanced Settings";
            this.Load += new System.EventHandler(this.AdvancedForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmbTimeOut, 0);
            this.Controls.SetChildIndex(this.cmbSque, 0);
            this.Controls.SetChildIndex(this.cmbVoice, 0);
            this.Controls.SetChildIndex(this.cmbBatte, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cmbVoxLevel, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.cmbBrightnessLev, 0);
            this.Controls.SetChildIndex(this.txtPowOnName, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.cmbScanMode, 0);
            this.Controls.SetChildIndex(this.chkKeyTone, 0);
            this.Controls.SetChildIndex(this.chkRogerBeep, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTimeOut;
        private System.Windows.Forms.ComboBox cmbSque;
        private System.Windows.Forms.ComboBox cmbVoice;
        private System.Windows.Forms.ComboBox cmbBatte;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbVoxLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBrightnessLev;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPowOnName;
        private System.Windows.Forms.ComboBox cmbScanMode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkKeyTone;
        private System.Windows.Forms.CheckBox chkRogerBeep;
    }
}