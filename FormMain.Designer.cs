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
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConfigure = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExclude = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLaunchers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.listboxProjects = new System.Windows.Forms.ListBox();
            this.lblProjectLocation = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.grpProjectDetails = new System.Windows.Forms.GroupBox();
            this.lblGitBranchValue = new System.Windows.Forms.Label();
            this.lblGitBranch = new System.Windows.Forms.Label();
            this.lblLastUpdatedValue = new System.Windows.Forms.Label();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.txtGitHistory = new System.Windows.Forms.TextBox();
            this.btnGitRefresh = new System.Windows.Forms.Button();
            this.btnGitChangeBranch = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnVSCode = new System.Windows.Forms.Button();
            this.btnVSCommunity = new System.Windows.Forms.Button();
            this.btnAndroidStudio = new System.Windows.Forms.Button();
            this.btnFileExplorer = new System.Windows.Forms.Button();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtCurrentStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpOpenProject = new System.Windows.Forms.GroupBox();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnUnity = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.grpProjectDetails.SuspendLayout();
            this.grpTime.SuspendLayout();
            this.grpOpenProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemSettings,
            this.toolStripMenuItemAbout});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1164, 29);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(46, 25);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(104, 26);
            this.toolStripMenuItemExit.Text = "Exit";
            // 
            // toolStripMenuItemSettings
            // 
            this.toolStripMenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemConfigure,
            this.toolStripMenuItemExclude,
            this.toolStripMenuItemLaunchers});
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(78, 25);
            this.toolStripMenuItemSettings.Text = "Settings";
            // 
            // toolStripMenuItemConfigure
            // 
            this.toolStripMenuItemConfigure.Name = "toolStripMenuItemConfigure";
            this.toolStripMenuItemConfigure.Size = new System.Drawing.Size(191, 26);
            this.toolStripMenuItemConfigure.Text = "Configure";
            // 
            // toolStripMenuItemExclude
            // 
            this.toolStripMenuItemExclude.Name = "toolStripMenuItemExclude";
            this.toolStripMenuItemExclude.Size = new System.Drawing.Size(191, 26);
            this.toolStripMenuItemExclude.Text = "Exclude Projects";
            // 
            // toolStripMenuItemLaunchers
            // 
            this.toolStripMenuItemLaunchers.Name = "toolStripMenuItemLaunchers";
            this.toolStripMenuItemLaunchers.Size = new System.Drawing.Size(191, 26);
            this.toolStripMenuItemLaunchers.Text = "Launchers";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemVersion,
            this.toolStripMenuItemUpdates});
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(64, 25);
            this.toolStripMenuItemAbout.Text = "About";
            // 
            // toolStripMenuItemVersion
            // 
            this.toolStripMenuItemVersion.Name = "toolStripMenuItemVersion";
            this.toolStripMenuItemVersion.Size = new System.Drawing.Size(210, 26);
            this.toolStripMenuItemVersion.Text = "Version Details";
            // 
            // toolStripMenuItemUpdates
            // 
            this.toolStripMenuItemUpdates.Name = "toolStripMenuItemUpdates";
            this.toolStripMenuItemUpdates.Size = new System.Drawing.Size(210, 26);
            this.toolStripMenuItemUpdates.Text = "Check For Updates";
            // 
            // listboxProjects
            // 
            this.listboxProjects.FormattingEnabled = true;
            this.listboxProjects.ItemHeight = 21;
            this.listboxProjects.Location = new System.Drawing.Point(12, 39);
            this.listboxProjects.Name = "listboxProjects";
            this.listboxProjects.Size = new System.Drawing.Size(246, 676);
            this.listboxProjects.TabIndex = 1;
            this.listboxProjects.SelectedIndexChanged += new System.EventHandler(this.ListboxProjects_SelectedIndexChanged);
            // 
            // lblProjectLocation
            // 
            this.lblProjectLocation.Location = new System.Drawing.Point(264, 692);
            this.lblProjectLocation.Name = "lblProjectLocation";
            this.lblProjectLocation.Size = new System.Drawing.Size(888, 23);
            this.lblProjectLocation.TabIndex = 2;
            this.lblProjectLocation.Text = "C:\\Program Files\\Some Project\\";
            // 
            // lblProjectName
            // 
            this.lblProjectName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProjectName.Location = new System.Drawing.Point(264, 39);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(888, 49);
            this.lblProjectName.TabIndex = 3;
            this.lblProjectName.Text = "Project Name";
            this.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpProjectDetails
            // 
            this.grpProjectDetails.Controls.Add(this.lblGitBranchValue);
            this.grpProjectDetails.Controls.Add(this.lblGitBranch);
            this.grpProjectDetails.Controls.Add(this.lblLastUpdatedValue);
            this.grpProjectDetails.Controls.Add(this.lblLastUpdated);
            this.grpProjectDetails.Location = new System.Drawing.Point(264, 91);
            this.grpProjectDetails.Name = "grpProjectDetails";
            this.grpProjectDetails.Size = new System.Drawing.Size(888, 61);
            this.grpProjectDetails.TabIndex = 4;
            this.grpProjectDetails.TabStop = false;
            // 
            // lblGitBranchValue
            // 
            this.lblGitBranchValue.AutoSize = true;
            this.lblGitBranchValue.Location = new System.Drawing.Point(681, 25);
            this.lblGitBranchValue.Name = "lblGitBranchValue";
            this.lblGitBranchValue.Size = new System.Drawing.Size(45, 21);
            this.lblGitBranchValue.TabIndex = 3;
            this.lblGitBranchValue.Text = "main";
            // 
            // lblGitBranch
            // 
            this.lblGitBranch.AutoSize = true;
            this.lblGitBranch.Location = new System.Drawing.Point(533, 25);
            this.lblGitBranch.Name = "lblGitBranch";
            this.lblGitBranch.Size = new System.Drawing.Size(142, 21);
            this.lblGitBranch.TabIndex = 2;
            this.lblGitBranch.Text = "Current Git Branch:";
            // 
            // lblLastUpdatedValue
            // 
            this.lblLastUpdatedValue.AutoSize = true;
            this.lblLastUpdatedValue.Location = new System.Drawing.Point(116, 25);
            this.lblLastUpdatedValue.Name = "lblLastUpdatedValue";
            this.lblLastUpdatedValue.Size = new System.Drawing.Size(158, 21);
            this.lblLastUpdatedValue.TabIndex = 1;
            this.lblLastUpdatedValue.Text = "2021-12-31 23:59:59";
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Location = new System.Drawing.Point(6, 25);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(104, 21);
            this.lblLastUpdated.TabIndex = 0;
            this.lblLastUpdated.Text = "Last Updated:";
            // 
            // txtGitHistory
            // 
            this.txtGitHistory.Location = new System.Drawing.Point(270, 158);
            this.txtGitHistory.Multiline = true;
            this.txtGitHistory.Name = "txtGitHistory";
            this.txtGitHistory.ReadOnly = true;
            this.txtGitHistory.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtGitHistory.Size = new System.Drawing.Size(500, 323);
            this.txtGitHistory.TabIndex = 5;
            this.txtGitHistory.Text = "Getting Git History...";
            this.txtGitHistory.WordWrap = false;
            // 
            // btnGitRefresh
            // 
            this.btnGitRefresh.Location = new System.Drawing.Point(270, 487);
            this.btnGitRefresh.Name = "btnGitRefresh";
            this.btnGitRefresh.Size = new System.Drawing.Size(124, 30);
            this.btnGitRefresh.TabIndex = 6;
            this.btnGitRefresh.Text = "Refresh";
            this.btnGitRefresh.UseVisualStyleBackColor = true;
            this.btnGitRefresh.Click += new System.EventHandler(this.BtnGitRefresh_Click);
            // 
            // btnGitChangeBranch
            // 
            this.btnGitChangeBranch.Enabled = false;
            this.btnGitChangeBranch.Location = new System.Drawing.Point(637, 487);
            this.btnGitChangeBranch.Name = "btnGitChangeBranch";
            this.btnGitChangeBranch.Size = new System.Drawing.Size(133, 30);
            this.btnGitChangeBranch.TabIndex = 7;
            this.btnGitChangeBranch.Text = "Change Branch";
            this.toolTip.SetToolTip(this.btnGitChangeBranch, "Coming Soon!");
            this.btnGitChangeBranch.UseVisualStyleBackColor = true;
            this.btnGitChangeBranch.Click += new System.EventHandler(this.BtnGitChangeBranch_Click);
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // btnVSCode
            // 
            this.btnVSCode.BackgroundImage = global::Manager.Properties.Resources.code_70x70;
            this.btnVSCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVSCode.Location = new System.Drawing.Point(22, 38);
            this.btnVSCode.Name = "btnVSCode";
            this.btnVSCode.Size = new System.Drawing.Size(50, 50);
            this.btnVSCode.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnVSCode, "Visual Studio Code");
            this.btnVSCode.UseVisualStyleBackColor = true;
            this.btnVSCode.Click += new System.EventHandler(this.BtnVSCode_Click);
            // 
            // btnVSCommunity
            // 
            this.btnVSCommunity.BackgroundImage = global::Manager.Properties.Resources.VisualStudio_70x70_contrast_standard_scale_80;
            this.btnVSCommunity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVSCommunity.Location = new System.Drawing.Point(100, 38);
            this.btnVSCommunity.Name = "btnVSCommunity";
            this.btnVSCommunity.Size = new System.Drawing.Size(50, 50);
            this.btnVSCommunity.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnVSCommunity, "Visual Studio Community 2019");
            this.btnVSCommunity.UseVisualStyleBackColor = true;
            this.btnVSCommunity.Click += new System.EventHandler(this.BtnVSCommunity_Click);
            // 
            // btnAndroidStudio
            // 
            this.btnAndroidStudio.BackgroundImage = global::Manager.Properties.Resources.AndroidStudio_Large;
            this.btnAndroidStudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAndroidStudio.Location = new System.Drawing.Point(179, 38);
            this.btnAndroidStudio.Name = "btnAndroidStudio";
            this.btnAndroidStudio.Size = new System.Drawing.Size(50, 50);
            this.btnAndroidStudio.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnAndroidStudio, "Visual Studio Community 2019");
            this.btnAndroidStudio.UseVisualStyleBackColor = true;
            this.btnAndroidStudio.Click += new System.EventHandler(this.BtnAndroidStudio_Click);
            // 
            // btnFileExplorer
            // 
            this.btnFileExplorer.BackgroundImage = global::Manager.Properties.Resources.FileExplorer_Large;
            this.btnFileExplorer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFileExplorer.Location = new System.Drawing.Point(348, 38);
            this.btnFileExplorer.Name = "btnFileExplorer";
            this.btnFileExplorer.Size = new System.Drawing.Size(72, 48);
            this.btnFileExplorer.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnFileExplorer, "File Explorer");
            this.btnFileExplorer.UseVisualStyleBackColor = true;
            this.btnFileExplorer.Click += new System.EventHandler(this.BtnFileExplorer_Click);
            // 
            // grpTime
            // 
            this.grpTime.Controls.Add(this.btnStart);
            this.grpTime.Controls.Add(this.btnPause);
            this.grpTime.Controls.Add(this.btnStop);
            this.grpTime.Controls.Add(this.txtCurrentStart);
            this.grpTime.Controls.Add(this.label1);
            this.grpTime.Controls.Add(this.txtTotalTime);
            this.grpTime.Controls.Add(this.lblTotal);
            this.grpTime.Location = new System.Drawing.Point(790, 158);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(362, 323);
            this.grpTime.TabIndex = 8;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Time Keeping";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::Manager.Properties.Resources.play;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Location = new System.Drawing.Point(288, 231);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(68, 68);
            this.btnStart.TabIndex = 6;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = global::Manager.Properties.Resources.pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.Location = new System.Drawing.Point(158, 231);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(68, 68);
            this.btnPause.TabIndex = 5;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::Manager.Properties.Resources.stop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Location = new System.Drawing.Point(24, 231);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(68, 68);
            this.btnStop.TabIndex = 4;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // txtCurrentStart
            // 
            this.txtCurrentStart.Location = new System.Drawing.Point(165, 113);
            this.txtCurrentStart.Name = "txtCurrentStart";
            this.txtCurrentStart.ReadOnly = true;
            this.txtCurrentStart.Size = new System.Drawing.Size(191, 29);
            this.txtCurrentStart.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Session Start Time:";
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Location = new System.Drawing.Point(165, 39);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.ReadOnly = true;
            this.txtTotalTime.Size = new System.Drawing.Size(191, 29);
            this.txtTotalTime.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(24, 42);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(135, 21);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Project Time:";
            // 
            // grpOpenProject
            // 
            this.grpOpenProject.Controls.Add(this.btnUnity);
            this.grpOpenProject.Controls.Add(this.btnFileExplorer);
            this.grpOpenProject.Controls.Add(this.btnAndroidStudio);
            this.grpOpenProject.Controls.Add(this.btnVSCommunity);
            this.grpOpenProject.Controls.Add(this.btnVSCode);
            this.grpOpenProject.Location = new System.Drawing.Point(270, 560);
            this.grpOpenProject.Name = "grpOpenProject";
            this.grpOpenProject.Size = new System.Drawing.Size(441, 98);
            this.grpOpenProject.TabIndex = 9;
            this.grpOpenProject.TabStop = false;
            this.grpOpenProject.Text = "Open Project";
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(1019, 487);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(133, 30);
            this.btnNotes.TabIndex = 10;
            this.btnNotes.Text = "Project Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.BtnNotes_Click);
            // 
            // btnUnity
            // 
            this.btnUnity.BackgroundImage = global::Manager.Properties.Resources.unity_small;
            this.btnUnity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnity.Location = new System.Drawing.Point(260, 38);
            this.btnUnity.Name = "btnUnity";
            this.btnUnity.Size = new System.Drawing.Size(50, 50);
            this.btnUnity.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnUnity, "Unity");
            this.btnUnity.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 722);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.grpOpenProject);
            this.Controls.Add(this.grpTime);
            this.Controls.Add(this.btnGitChangeBranch);
            this.Controls.Add(this.btnGitRefresh);
            this.Controls.Add(this.txtGitHistory);
            this.Controls.Add(this.grpProjectDetails);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblProjectLocation);
            this.Controls.Add(this.listboxProjects);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Project Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.grpProjectDetails.ResumeLayout(false);
            this.grpProjectDetails.PerformLayout();
            this.grpTime.ResumeLayout(false);
            this.grpTime.PerformLayout();
            this.grpOpenProject.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConfigure;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVersion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpdates;
        private System.Windows.Forms.ListBox listboxProjects;
        private System.Windows.Forms.Label lblProjectLocation;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.GroupBox grpProjectDetails;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.Label lblLastUpdatedValue;
        private System.Windows.Forms.Label lblGitBranchValue;
        private System.Windows.Forms.Label lblGitBranch;
        private System.Windows.Forms.TextBox txtGitHistory;
        private System.Windows.Forms.Button btnGitRefresh;
        private System.Windows.Forms.Button btnGitChangeBranch;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExclude;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtCurrentStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalTime;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpOpenProject;
        private System.Windows.Forms.Button btnAndroidStudio;
        private System.Windows.Forms.Button btnVSCommunity;
        private System.Windows.Forms.Button btnVSCode;
        private System.Windows.Forms.Button btnFileExplorer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLaunchers;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnUnity;
    }
}

