namespace Manager
{
    partial class FormAddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProject));
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.grpDefaultLauncher = new System.Windows.Forms.GroupBox();
            this.lblLauncherNote = new System.Windows.Forms.Label();
            this.radioFileExplorer = new System.Windows.Forms.RadioButton();
            this.radioAndroid = new System.Windows.Forms.RadioButton();
            this.radioVSCode = new System.Windows.Forms.RadioButton();
            this.radioVisualStudio = new System.Windows.Forms.RadioButton();
            this.grpGit = new System.Windows.Forms.GroupBox();
            this.numberGitCommits = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkEnableGit = new System.Windows.Forms.CheckBox();
            this.checkEnableTimekeeping = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAnother = new System.Windows.Forms.Button();
            this.grpDefaultLauncher.SuspendLayout();
            this.grpGit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberGitCommits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(45, 83);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(107, 21);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Project Name:";
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(36, 35);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(116, 21);
            this.lblDirectory.TabIndex = 1;
            this.lblDirectory.Text = "Main Directory:";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Location = new System.Drawing.Point(167, 32);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.ReadOnly = true;
            this.txtDirectoryPath.Size = new System.Drawing.Size(346, 29);
            this.txtDirectoryPath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(519, 33);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(167, 80);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(346, 29);
            this.txtProjectName.TabIndex = 4;
            // 
            // grpDefaultLauncher
            // 
            this.grpDefaultLauncher.Controls.Add(this.lblLauncherNote);
            this.grpDefaultLauncher.Controls.Add(this.radioFileExplorer);
            this.grpDefaultLauncher.Controls.Add(this.radioAndroid);
            this.grpDefaultLauncher.Controls.Add(this.radioVSCode);
            this.grpDefaultLauncher.Controls.Add(this.radioVisualStudio);
            this.grpDefaultLauncher.Location = new System.Drawing.Point(36, 214);
            this.grpDefaultLauncher.Name = "grpDefaultLauncher";
            this.grpDefaultLauncher.Size = new System.Drawing.Size(349, 206);
            this.grpDefaultLauncher.TabIndex = 5;
            this.grpDefaultLauncher.TabStop = false;
            this.grpDefaultLauncher.Text = "Default Launcher";
            // 
            // lblLauncherNote
            // 
            this.lblLauncherNote.Location = new System.Drawing.Point(6, 128);
            this.lblLauncherNote.Name = "lblLauncherNote";
            this.lblLauncherNote.Size = new System.Drawing.Size(334, 75);
            this.lblLauncherNote.TabIndex = 4;
            this.lblLauncherNote.Text = "Please note that each launcher must be installed separately and configured in Set" +
    "tings before launching will work properly.";
            // 
            // radioFileExplorer
            // 
            this.radioFileExplorer.AutoSize = true;
            this.radioFileExplorer.Location = new System.Drawing.Point(182, 88);
            this.radioFileExplorer.Name = "radioFileExplorer";
            this.radioFileExplorer.Size = new System.Drawing.Size(113, 25);
            this.radioFileExplorer.TabIndex = 3;
            this.radioFileExplorer.TabStop = true;
            this.radioFileExplorer.Tag = "file";
            this.radioFileExplorer.Text = "File Explorer";
            this.radioFileExplorer.UseVisualStyleBackColor = true;
            // 
            // radioAndroid
            // 
            this.radioAndroid.AutoSize = true;
            this.radioAndroid.Location = new System.Drawing.Point(33, 88);
            this.radioAndroid.Name = "radioAndroid";
            this.radioAndroid.Size = new System.Drawing.Size(132, 25);
            this.radioAndroid.TabIndex = 2;
            this.radioAndroid.TabStop = true;
            this.radioAndroid.Tag = "android";
            this.radioAndroid.Text = "Android Studio";
            this.radioAndroid.UseVisualStyleBackColor = true;
            // 
            // radioVSCode
            // 
            this.radioVSCode.AutoSize = true;
            this.radioVSCode.Location = new System.Drawing.Point(182, 40);
            this.radioVSCode.Name = "radioVSCode";
            this.radioVSCode.Size = new System.Drawing.Size(158, 25);
            this.radioVSCode.TabIndex = 1;
            this.radioVSCode.TabStop = true;
            this.radioVSCode.Tag = "vsc";
            this.radioVSCode.Text = "Visual Studio Code";
            this.radioVSCode.UseVisualStyleBackColor = true;
            // 
            // radioVisualStudio
            // 
            this.radioVisualStudio.AutoSize = true;
            this.radioVisualStudio.Location = new System.Drawing.Point(29, 40);
            this.radioVisualStudio.Name = "radioVisualStudio";
            this.radioVisualStudio.Size = new System.Drawing.Size(118, 25);
            this.radioVisualStudio.TabIndex = 0;
            this.radioVisualStudio.TabStop = true;
            this.radioVisualStudio.Tag = "vs";
            this.radioVisualStudio.Text = "Visual Studio";
            this.radioVisualStudio.UseVisualStyleBackColor = true;
            // 
            // grpGit
            // 
            this.grpGit.Controls.Add(this.numberGitCommits);
            this.grpGit.Controls.Add(this.label1);
            this.grpGit.Location = new System.Drawing.Point(426, 214);
            this.grpGit.Name = "grpGit";
            this.grpGit.Size = new System.Drawing.Size(211, 203);
            this.grpGit.TabIndex = 6;
            this.grpGit.TabStop = false;
            this.grpGit.Text = "Git";
            // 
            // numberGitCommits
            // 
            this.numberGitCommits.Location = new System.Drawing.Point(155, 40);
            this.numberGitCommits.Margin = new System.Windows.Forms.Padding(4);
            this.numberGitCommits.Name = "numberGitCommits";
            this.numberGitCommits.Size = new System.Drawing.Size(49, 29);
            this.numberGitCommits.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Commits to show:";
            // 
            // checkEnableGit
            // 
            this.checkEnableGit.AutoSize = true;
            this.checkEnableGit.Location = new System.Drawing.Point(36, 164);
            this.checkEnableGit.Name = "checkEnableGit";
            this.checkEnableGit.Size = new System.Drawing.Size(129, 25);
            this.checkEnableGit.TabIndex = 0;
            this.checkEnableGit.Text = "Enable Git Log";
            this.checkEnableGit.UseVisualStyleBackColor = true;
            // 
            // checkEnableTimekeeping
            // 
            this.checkEnableTimekeeping.AutoSize = true;
            this.checkEnableTimekeeping.Location = new System.Drawing.Point(36, 133);
            this.checkEnableTimekeeping.Name = "checkEnableTimekeeping";
            this.checkEnableTimekeeping.Size = new System.Drawing.Size(173, 25);
            this.checkEnableTimekeeping.TabIndex = 7;
            this.checkEnableTimekeeping.Text = "Enable Time Keeping";
            this.checkEnableTimekeeping.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(32, 461);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(562, 461);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnSaveAnother
            // 
            this.btnSaveAnother.Location = new System.Drawing.Point(256, 461);
            this.btnSaveAnother.Name = "btnSaveAnother";
            this.btnSaveAnother.Size = new System.Drawing.Size(188, 32);
            this.btnSaveAnother.TabIndex = 10;
            this.btnSaveAnother.Text = "Save and Add Another";
            this.btnSaveAnother.UseVisualStyleBackColor = true;
            this.btnSaveAnother.Click += new System.EventHandler(this.BtnSaveAnother_Click);
            // 
            // FormAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 514);
            this.Controls.Add(this.btnSaveAnother);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.checkEnableTimekeeping);
            this.Controls.Add(this.grpGit);
            this.Controls.Add(this.checkEnableGit);
            this.Controls.Add(this.grpDefaultLauncher);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.lblProjectName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddProject";
            this.Text = "Add New Project";
            this.Load += new System.EventHandler(this.FormAddProject_Load);
            this.grpDefaultLauncher.ResumeLayout(false);
            this.grpDefaultLauncher.PerformLayout();
            this.grpGit.ResumeLayout(false);
            this.grpGit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberGitCommits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.GroupBox grpDefaultLauncher;
        private System.Windows.Forms.Label lblLauncherNote;
        private System.Windows.Forms.RadioButton radioFileExplorer;
        private System.Windows.Forms.RadioButton radioAndroid;
        private System.Windows.Forms.RadioButton radioVSCode;
        private System.Windows.Forms.RadioButton radioVisualStudio;
        private System.Windows.Forms.GroupBox grpGit;
        private System.Windows.Forms.NumericUpDown numberGitCommits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkEnableGit;
        private System.Windows.Forms.CheckBox checkEnableTimekeeping;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAnother;
    }
}