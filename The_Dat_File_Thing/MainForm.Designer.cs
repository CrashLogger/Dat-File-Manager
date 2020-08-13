namespace The_Dat_File_Thing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Log_Box = new System.Windows.Forms.GroupBox();
            this.setIDRanges = new System.Windows.Forms.Button();
            this.FilePerTypeBox = new System.Windows.Forms.CheckBox();
            this.SkipCosmetics = new System.Windows.Forms.CheckBox();
            this.LookForVanilla = new System.Windows.Forms.CheckBox();
            this.ID_Find_Button = new System.Windows.Forms.Button();
            this.Change_Utd_Install_Path = new System.Windows.Forms.Button();
            this.Utd_Path_Box = new System.Windows.Forms.TextBox();
            this.Utd_Path_Label = new System.Windows.Forms.Label();
            this.FilePerTypeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.VanillaBundlesTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.CosmeticsTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.OpenCredits = new System.Windows.Forms.Button();
            this.StandardToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FileGenerationBox = new System.Windows.Forms.GroupBox();
            this.useIndividualBundles = new System.Windows.Forms.Button();
            this.ListOfBundles = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.masterBundleFilterFolder = new System.Windows.Forms.TextBox();
            this.findMasterBundle = new System.Windows.Forms.Button();
            this.EditBundle = new System.Windows.Forms.Button();
            this.ChooseBundleType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KnownBugsButton = new System.Windows.Forms.Button();
            this.ReadmeButton = new System.Windows.Forms.Button();
            this.InstallationPathLink = new System.Windows.Forms.LinkLabel();
            this.Log_Box.SuspendLayout();
            this.FileGenerationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_Box
            // 
            this.Log_Box.Controls.Add(this.setIDRanges);
            this.Log_Box.Controls.Add(this.FilePerTypeBox);
            this.Log_Box.Controls.Add(this.SkipCosmetics);
            this.Log_Box.Controls.Add(this.LookForVanilla);
            this.Log_Box.Controls.Add(this.ID_Find_Button);
            this.Log_Box.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Log_Box.Location = new System.Drawing.Point(16, 39);
            this.Log_Box.Name = "Log_Box";
            this.Log_Box.Size = new System.Drawing.Size(706, 124);
            this.Log_Box.TabIndex = 0;
            this.Log_Box.TabStop = false;
            this.Log_Box.Text = "Logging";
            // 
            // setIDRanges
            // 
            this.setIDRanges.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setIDRanges.Location = new System.Drawing.Point(562, 95);
            this.setIDRanges.Name = "setIDRanges";
            this.setIDRanges.Size = new System.Drawing.Size(138, 23);
            this.setIDRanges.TabIndex = 5;
            this.setIDRanges.Text = "Set ID Ranges";
            this.setIDRanges.UseVisualStyleBackColor = true;
            this.setIDRanges.Click += new System.EventHandler(this.setIDRanges_Click);
            // 
            // FilePerTypeBox
            // 
            this.FilePerTypeBox.AutoSize = true;
            this.FilePerTypeBox.Location = new System.Drawing.Point(6, 68);
            this.FilePerTypeBox.Name = "FilePerTypeBox";
            this.FilePerTypeBox.Size = new System.Drawing.Size(173, 17);
            this.FilePerTypeBox.TabIndex = 4;
            this.FilePerTypeBox.Text = "File per Type (Very broken still!)";
            this.FilePerTypeTooltip.SetToolTip(this.FilePerTypeBox, "Creates a different file per Type of bundle Found. (Object, Item, Vehicle, Misc) " +
        "Convenient to separate ID systems.");
            this.FilePerTypeBox.UseVisualStyleBackColor = true;
            this.FilePerTypeBox.CheckedChanged += new System.EventHandler(this.FilePerTypeBox_CheckedChanged);
            // 
            // SkipCosmetics
            // 
            this.SkipCosmetics.AutoSize = true;
            this.SkipCosmetics.Checked = true;
            this.SkipCosmetics.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SkipCosmetics.Location = new System.Drawing.Point(7, 44);
            this.SkipCosmetics.Name = "SkipCosmetics";
            this.SkipCosmetics.Size = new System.Drawing.Size(143, 17);
            this.SkipCosmetics.TabIndex = 2;
            this.SkipCosmetics.Text = "Skip Cosmetics from logs";
            this.CosmeticsTooltip.SetToolTip(this.SkipCosmetics, "Cosmetics are the player clothing skins, and they\'re part of the normal game bund" +
        "les\r\nWith this checked, the files for the cosmetics will be ignored.");
            this.SkipCosmetics.UseVisualStyleBackColor = true;
            // 
            // LookForVanilla
            // 
            this.LookForVanilla.AutoSize = true;
            this.LookForVanilla.Cursor = System.Windows.Forms.Cursors.Default;
            this.LookForVanilla.Location = new System.Drawing.Point(7, 20);
            this.LookForVanilla.Name = "LookForVanilla";
            this.LookForVanilla.Size = new System.Drawing.Size(138, 17);
            this.LookForVanilla.TabIndex = 1;
            this.LookForVanilla.Text = "Look for vanilla bundles";
            this.VanillaBundlesTooltip.SetToolTip(this.LookForVanilla, "Refers to the bundles within the Bundles folder. (Unturned\\Bundles).\r\nIf your mod" +
        " is here, I suggest making a Bundles folder within a map\'s folder and placing it" +
        " there instead.");
            this.LookForVanilla.UseVisualStyleBackColor = true;
            // 
            // ID_Find_Button
            // 
            this.ID_Find_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ID_Find_Button.Location = new System.Drawing.Point(7, 91);
            this.ID_Find_Button.Name = "ID_Find_Button";
            this.ID_Find_Button.Size = new System.Drawing.Size(137, 23);
            this.ID_Find_Button.TabIndex = 0;
            this.ID_Find_Button.Text = "Find Dats and IDs";
            this.ID_Find_Button.UseVisualStyleBackColor = true;
            this.ID_Find_Button.Click += new System.EventHandler(this.ID_Find_Button_Click);
            // 
            // Change_Utd_Install_Path
            // 
            this.Change_Utd_Install_Path.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Change_Utd_Install_Path.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Change_Utd_Install_Path.Location = new System.Drawing.Point(586, 10);
            this.Change_Utd_Install_Path.Name = "Change_Utd_Install_Path";
            this.Change_Utd_Install_Path.Size = new System.Drawing.Size(136, 23);
            this.Change_Utd_Install_Path.TabIndex = 3;
            this.Change_Utd_Install_Path.Text = "Change...";
            this.Change_Utd_Install_Path.UseVisualStyleBackColor = true;
            this.Change_Utd_Install_Path.Click += new System.EventHandler(this.Change_Utd_Install_Path_Click);
            // 
            // Utd_Path_Box
            // 
            this.Utd_Path_Box.Location = new System.Drawing.Point(141, 12);
            this.Utd_Path_Box.Name = "Utd_Path_Box";
            this.Utd_Path_Box.ReadOnly = true;
            this.Utd_Path_Box.Size = new System.Drawing.Size(439, 20);
            this.Utd_Path_Box.TabIndex = 2;
            // 
            // Utd_Path_Label
            // 
            this.Utd_Path_Label.AutoSize = true;
            this.Utd_Path_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Utd_Path_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Utd_Path_Label.Location = new System.Drawing.Point(12, 16);
            this.Utd_Path_Label.Name = "Utd_Path_Label";
            this.Utd_Path_Label.Size = new System.Drawing.Size(131, 16);
            this.Utd_Path_Label.TabIndex = 1;
            this.Utd_Path_Label.Text = "Unturned Install path:";
            // 
            // FilePerTypeTooltip
            // 
            this.FilePerTypeTooltip.ToolTipTitle = "File Per Type";
            // 
            // VanillaBundlesTooltip
            // 
            this.VanillaBundlesTooltip.ToolTipTitle = "Vanilla bundles";
            // 
            // CosmeticsTooltip
            // 
            this.CosmeticsTooltip.ToolTipTitle = "Cosmetics";
            // 
            // OpenCredits
            // 
            this.OpenCredits.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpenCredits.Location = new System.Drawing.Point(647, 641);
            this.OpenCredits.Name = "OpenCredits";
            this.OpenCredits.Size = new System.Drawing.Size(75, 23);
            this.OpenCredits.TabIndex = 4;
            this.OpenCredits.Text = "Credits";
            this.OpenCredits.UseVisualStyleBackColor = true;
            this.OpenCredits.Click += new System.EventHandler(this.OpenCredits_Click);
            // 
            // FileGenerationBox
            // 
            this.FileGenerationBox.Controls.Add(this.useIndividualBundles);
            this.FileGenerationBox.Controls.Add(this.ListOfBundles);
            this.FileGenerationBox.Controls.Add(this.label2);
            this.FileGenerationBox.Controls.Add(this.masterBundleFilterFolder);
            this.FileGenerationBox.Controls.Add(this.findMasterBundle);
            this.FileGenerationBox.Controls.Add(this.EditBundle);
            this.FileGenerationBox.Controls.Add(this.ChooseBundleType);
            this.FileGenerationBox.Controls.Add(this.label1);
            this.FileGenerationBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FileGenerationBox.Location = new System.Drawing.Point(16, 170);
            this.FileGenerationBox.Name = "FileGenerationBox";
            this.FileGenerationBox.Size = new System.Drawing.Size(706, 465);
            this.FileGenerationBox.TabIndex = 5;
            this.FileGenerationBox.TabStop = false;
            this.FileGenerationBox.Text = "Generation";
            // 
            // useIndividualBundles
            // 
            this.useIndividualBundles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.useIndividualBundles.Location = new System.Drawing.Point(571, 19);
            this.useIndividualBundles.Name = "useIndividualBundles";
            this.useIndividualBundles.Size = new System.Drawing.Size(129, 21);
            this.useIndividualBundles.TabIndex = 18;
            this.useIndividualBundles.Text = "Use Individual Bundles";
            this.useIndividualBundles.UseVisualStyleBackColor = true;
            this.useIndividualBundles.Click += new System.EventHandler(this.useIndividualBundles_Click);
            // 
            // ListOfBundles
            // 
            this.ListOfBundles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ListOfBundles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListOfBundles.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ListOfBundles.FormattingEnabled = true;
            this.ListOfBundles.Location = new System.Drawing.Point(172, 80);
            this.ListOfBundles.Name = "ListOfBundles";
            this.ListOfBundles.Size = new System.Drawing.Size(528, 353);
            this.ListOfBundles.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Map containing Bundle(s)";
            // 
            // masterBundleFilterFolder
            // 
            this.masterBundleFilterFolder.Location = new System.Drawing.Point(171, 21);
            this.masterBundleFilterFolder.Name = "masterBundleFilterFolder";
            this.masterBundleFilterFolder.Size = new System.Drawing.Size(393, 20);
            this.masterBundleFilterFolder.TabIndex = 13;
            // 
            // findMasterBundle
            // 
            this.findMasterBundle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.findMasterBundle.Location = new System.Drawing.Point(570, 46);
            this.findMasterBundle.Name = "findMasterBundle";
            this.findMasterBundle.Size = new System.Drawing.Size(130, 23);
            this.findMasterBundle.TabIndex = 12;
            this.findMasterBundle.Text = "Find MasterBundle";
            this.findMasterBundle.UseVisualStyleBackColor = true;
            this.findMasterBundle.Click += new System.EventHandler(this.findMasterBundle_Click);
            // 
            // EditBundle
            // 
            this.EditBundle.Enabled = false;
            this.EditBundle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditBundle.Location = new System.Drawing.Point(550, 436);
            this.EditBundle.Name = "EditBundle";
            this.EditBundle.Size = new System.Drawing.Size(150, 23);
            this.EditBundle.TabIndex = 10;
            this.EditBundle.Text = "Edit";
            this.EditBundle.UseVisualStyleBackColor = true;
            this.EditBundle.Click += new System.EventHandler(this.EditBundle_Click);
            // 
            // ChooseBundleType
            // 
            this.ChooseBundleType.FormattingEnabled = true;
            this.ChooseBundleType.Items.AddRange(new object[] {
            "All",
            "Vehicles",
            "Items",
            "Objects",
            "Misc"});
            this.ChooseBundleType.Location = new System.Drawing.Point(172, 47);
            this.ChooseBundleType.Name = "ChooseBundleType";
            this.ChooseBundleType.Size = new System.Drawing.Size(392, 21);
            this.ChooseBundleType.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose a bundle type";
            // 
            // KnownBugsButton
            // 
            this.KnownBugsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.KnownBugsButton.Enabled = false;
            this.KnownBugsButton.Location = new System.Drawing.Point(566, 641);
            this.KnownBugsButton.Name = "KnownBugsButton";
            this.KnownBugsButton.Size = new System.Drawing.Size(75, 23);
            this.KnownBugsButton.TabIndex = 6;
            this.KnownBugsButton.Text = "Known Bugs";
            this.KnownBugsButton.UseVisualStyleBackColor = true;
            this.KnownBugsButton.Click += new System.EventHandler(this.KnownBugsButton_Click);
            // 
            // ReadmeButton
            // 
            this.ReadmeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReadmeButton.Location = new System.Drawing.Point(485, 641);
            this.ReadmeButton.Name = "ReadmeButton";
            this.ReadmeButton.Size = new System.Drawing.Size(75, 23);
            this.ReadmeButton.TabIndex = 7;
            this.ReadmeButton.Text = "README";
            this.ReadmeButton.UseVisualStyleBackColor = true;
            this.ReadmeButton.Click += new System.EventHandler(this.ReadmeButton_Click);
            // 
            // InstallationPathLink
            // 
            this.InstallationPathLink.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.InstallationPathLink.AutoSize = true;
            this.InstallationPathLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InstallationPathLink.Location = new System.Drawing.Point(13, 646);
            this.InstallationPathLink.Name = "InstallationPathLink";
            this.InstallationPathLink.Size = new System.Drawing.Size(81, 13);
            this.InstallationPathLink.TabIndex = 19;
            this.InstallationPathLink.TabStop = true;
            this.InstallationPathLink.Text = "Installation path";
            this.InstallationPathLink.VisitedLinkColor = System.Drawing.Color.Indigo;
            this.InstallationPathLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InstallationPathLink_LinkClicked);
            // 
            // MainForm
            // 
            this.AcceptButton = this.findMasterBundle;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(734, 676);
            this.Controls.Add(this.InstallationPathLink);
            this.Controls.Add(this.ReadmeButton);
            this.Controls.Add(this.KnownBugsButton);
            this.Controls.Add(this.FileGenerationBox);
            this.Controls.Add(this.OpenCredits);
            this.Controls.Add(this.Change_Utd_Install_Path);
            this.Controls.Add(this.Log_Box);
            this.Controls.Add(this.Utd_Path_Box);
            this.Controls.Add(this.Utd_Path_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 715);
            this.MinimumSize = new System.Drawing.Size(750, 715);
            this.Name = "MainForm";
            this.Text = "Dat file manager";
            this.Log_Box.ResumeLayout(false);
            this.Log_Box.PerformLayout();
            this.FileGenerationBox.ResumeLayout(false);
            this.FileGenerationBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Log_Box;
        private System.Windows.Forms.Button ID_Find_Button;
        private System.Windows.Forms.Button Change_Utd_Install_Path;
        private System.Windows.Forms.TextBox Utd_Path_Box;
        private System.Windows.Forms.Label Utd_Path_Label;
        private System.Windows.Forms.CheckBox SkipCosmetics;
        private System.Windows.Forms.CheckBox LookForVanilla;
        private System.Windows.Forms.CheckBox FilePerTypeBox;
        private System.Windows.Forms.ToolTip FilePerTypeTooltip;
        private System.Windows.Forms.ToolTip VanillaBundlesTooltip;
        private System.Windows.Forms.ToolTip CosmeticsTooltip;
        private System.Windows.Forms.Button OpenCredits;
        private System.Windows.Forms.ToolTip StandardToolTip;
        private System.Windows.Forms.GroupBox FileGenerationBox;
        private System.Windows.Forms.Button EditBundle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findMasterBundle;
        private System.Windows.Forms.TextBox masterBundleFilterFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button KnownBugsButton;
        private System.Windows.Forms.Button ReadmeButton;
        private System.Windows.Forms.ListBox ListOfBundles;
        private System.Windows.Forms.Button setIDRanges;
        private System.Windows.Forms.ComboBox ChooseBundleType;
        private System.Windows.Forms.Button useIndividualBundles;
        private System.Windows.Forms.LinkLabel InstallationPathLink;
    }
}

