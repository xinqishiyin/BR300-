namespace BR300walkietalkie.Controls
{
    partial class DialogForm
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
            this.pnlButtonContainer = new System.Windows.Forms.Panel();
            this.pnlText = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlButtonContainer
            // 
            this.pnlButtonContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtonContainer.Location = new System.Drawing.Point(5, 90);
            this.pnlButtonContainer.Name = "pnlButtonContainer";
            this.pnlButtonContainer.Size = new System.Drawing.Size(200, 48);
            this.pnlButtonContainer.TabIndex = 10;
            // 
            // pnlText
            // 
            this.pnlText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlText.Location = new System.Drawing.Point(5, 34);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(200, 50);
            this.pnlText.TabIndex = 11;
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 143);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.pnlButtonContainer);
            this.Name = "DialogForm";
            this.Text = "MessageBox";
            this.Controls.SetChildIndex(this.pnlButtonContainer, 0);
            this.Controls.SetChildIndex(this.pnlText, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtonContainer;
        private System.Windows.Forms.Panel pnlText;
    }
}