namespace Manager
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrentProfile = new System.Windows.Forms.Label();
            this.dropdownProfile = new System.Windows.Forms.ComboBox();
            this.listboxProjects = new System.Windows.Forms.ListBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtGitHistory = new System.Windows.Forms.TextBox();
            this.lblGitBranch = new System.Windows.Forms.Label();
            this.lblGitBranchName = new System.Windows.Forms.Label();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblLastCommitValue = new System.Windows.Forms.Label();
            this.lblLastCommit = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.profilesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(728, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.projectsToolStripMenuItem.Text = "&Projects";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem.Text = "&Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.ManageToolStripMenuItem_Click);
            // 
            // profilesToolStripMenuItem
            // 
            this.profilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem1});
            this.profilesToolStripMenuItem.Name = "profilesToolStripMenuItem";
            this.profilesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.profilesToolStripMenuItem.Text = "P&rofiles";
            // 
            // manageToolStripMenuItem1
            // 
            this.manageToolStripMenuItem1.Name = "manageToolStripMenuItem1";
            this.manageToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem1.Text = "&Manage";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionToolStripMenuItem.Text = "&Version";
            // 
            // lblCurrentProfile
            // 
            this.lblCurrentProfile.AutoSize = true;
            this.lblCurrentProfile.Location = new System.Drawing.Point(12, 34);
            this.lblCurrentProfile.Name = "lblCurrentProfile";
            this.lblCurrentProfile.Size = new System.Drawing.Size(115, 21);
            this.lblCurrentProfile.TabIndex = 1;
            this.lblCurrentProfile.Text = "Current Profile:";
            // 
            // dropdownProfile
            // 
            this.dropdownProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownProfile.FormattingEnabled = true;
            this.dropdownProfile.Location = new System.Drawing.Point(133, 31);
            this.dropdownProfile.Name = "dropdownProfile";
            this.dropdownProfile.Size = new System.Drawing.Size(171, 29);
            this.dropdownProfile.TabIndex = 2;
            this.dropdownProfile.TabStop = false;
            this.dropdownProfile.SelectedIndexChanged += new System.EventHandler(this.DropdownProfile_SelectedIndexChanged);
            // 
            // listboxProjects
            // 
            this.listboxProjects.FormattingEnabled = true;
            this.listboxProjects.ItemHeight = 21;
            this.listboxProjects.Location = new System.Drawing.Point(12, 76);
            this.listboxProjects.Name = "listboxProjects";
            this.listboxProjects.Size = new System.Drawing.Size(229, 529);
            this.listboxProjects.TabIndex = 3;
            this.listboxProjects.SelectedIndexChanged += new System.EventHandler(this.ListboxProjects_SelectedIndexChanged);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProjectName.Location = new System.Drawing.Point(382, 76);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(198, 30);
            this.lblProjectName.TabIndex = 4;
            this.lblProjectName.Text = "Project Name Here";
            // 
            // txtGitHistory
            // 
            this.txtGitHistory.Location = new System.Drawing.Point(247, 118);
            this.txtGitHistory.Multiline = true;
            this.txtGitHistory.Name = "txtGitHistory";
            this.txtGitHistory.ReadOnly = true;
            this.txtGitHistory.Size = new System.Drawing.Size(469, 247);
            this.txtGitHistory.TabIndex = 5;
            // 
            // lblGitBranch
            // 
            this.lblGitBranch.AutoSize = true;
            this.lblGitBranch.Location = new System.Drawing.Point(247, 368);
            this.lblGitBranch.Name = "lblGitBranch";
            this.lblGitBranch.Size = new System.Drawing.Size(142, 21);
            this.lblGitBranch.TabIndex = 6;
            this.lblGitBranch.Text = "Current Git Branch:";
            // 
            // lblGitBranchName
            // 
            this.lblGitBranchName.AutoSize = true;
            this.lblGitBranchName.Location = new System.Drawing.Point(395, 368);
            this.lblGitBranchName.Name = "lblGitBranchName";
            this.lblGitBranchName.Size = new System.Drawing.Size(45, 21);
            this.lblGitBranchName.TabIndex = 7;
            this.lblGitBranchName.Text = "main";
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(292, 482);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(131, 38);
            this.btnNotes.TabIndex = 8;
            this.btnNotes.Text = "View Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.BtnNotes_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(519, 482);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(131, 38);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "Open Folder";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // lblLastCommitValue
            // 
            this.lblLastCommitValue.AutoSize = true;
            this.lblLastCommitValue.Location = new System.Drawing.Point(415, 401);
            this.lblLastCommitValue.Name = "lblLastCommitValue";
            this.lblLastCommitValue.Size = new System.Drawing.Size(155, 21);
            this.lblLastCommitValue.TabIndex = 11;
            this.lblLastCommitValue.Text = "2022-06-01 5:33 PM";
            // 
            // lblLastCommit
            // 
            this.lblLastCommit.AutoSize = true;
            this.lblLastCommit.Location = new System.Drawing.Point(247, 401);
            this.lblLastCommit.Name = "lblLastCommit";
            this.lblLastCommit.Size = new System.Drawing.Size(172, 21);
            this.lblLastCommit.TabIndex = 10;
            this.lblLastCommit.Text = "Last Git commit was on";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 630);
            this.Controls.Add(this.lblLastCommitValue);
            this.Controls.Add(this.lblLastCommit);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.lblGitBranchName);
            this.Controls.Add(this.lblGitBranch);
            this.Controls.Add(this.txtGitHistory);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.listboxProjects);
            this.Controls.Add(this.dropdownProfile);
            this.Controls.Add(this.lblCurrentProfile);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Project Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem projectsToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem profilesToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem versionToolStripMenuItem;
        private Label lblCurrentProfile;
        private ComboBox dropdownProfile;
        private ListBox listboxProjects;
        private Label lblProjectName;
        private TextBox txtGitHistory;
        private Label lblGitBranch;
        private Label lblGitBranchName;
        private Button btnNotes;
        private Button btnOpen;
        private Label lblLastCommitValue;
        private Label lblLastCommit;
    }
}