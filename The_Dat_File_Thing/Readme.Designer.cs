namespace The_Dat_File_Thing
{
    partial class Readme_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Readme_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.InstallationPathLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // InstallationPathLink
            // 
            this.InstallationPathLink.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.InstallationPathLink.AutoSize = true;
            this.InstallationPathLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InstallationPathLink.Location = new System.Drawing.Point(370, 64);
            this.InstallationPathLink.Name = "InstallationPathLink";
            this.InstallationPathLink.Size = new System.Drawing.Size(81, 13);
            this.InstallationPathLink.TabIndex = 1;
            this.InstallationPathLink.TabStop = true;
            this.InstallationPathLink.Text = "Installation path";
            this.InstallationPathLink.VisitedLinkColor = System.Drawing.Color.Indigo;
            this.InstallationPathLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InstallationPathLink_LinkClicked);
            // 
            // Readme_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(734, 676);
            this.Controls.Add(this.InstallationPathLink);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 715);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 715);
            this.Name = "Readme_Form";
            this.Text = "Readme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel InstallationPathLink;
    }
}