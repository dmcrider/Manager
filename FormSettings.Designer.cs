
namespace Manager
{
    partial class FormSettings
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
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.btnAllProjects = new System.Windows.Forms.Button();
            this.txtMasterRoot = new System.Windows.Forms.TextBox();
            this.lblRootDir = new System.Windows.Forms.Label();
            this.listTimePattern = new System.Windows.Forms.ComboBox();
            this.lblTimeFormat = new System.Windows.Forms.Label();
            this.listDatePattern = new System.Windows.Forms.ComboBox();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.txtGitLogHistory = new System.Windows.Forms.NumericUpDown();
            this.lblGitHistoryLines = new System.Windows.Forms.Label();
            this.checkEnableGit = new System.Windows.Forms.CheckBox();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listProjects = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProjName = new System.Windows.Forms.Label();
            this.lblProjLoc = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectLocation = new System.Windows.Forms.TextBox();
            this.toolTipGitHub = new System.Windows.Forms.ToolTip(this.components);
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.grpProjectSettings = new System.Windows.Forms.GroupBox();
            this.lblOpenWith = new System.Windows.Forms.Label();
            this.listOpenWith = new System.Windows.Forms.ComboBox();
            this.chkEnableTimekeeping = new System.Windows.Forms.CheckBox();
            this.btnCurrentProject = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnMainProjFile = new System.Windows.Forms.Button();
            this.txtMainProjFile = new System.Windows.Forms.TextBox();
            this.lblMainProjFile = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGitLogHistory)).BeginInit();
            this.grpProjectSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.btnAllProjects);
            this.grpGeneral.Controls.Add(this.txtMasterRoot);
            this.grpGeneral.Controls.Add(this.lblRootDir);
            this.grpGeneral.Controls.Add(this.listTimePattern);
            this.grpGeneral.Controls.Add(this.lblTimeFormat);
            this.grpGeneral.Controls.Add(this.listDatePattern);
            this.grpGeneral.Controls.Add(this.lblDateFormat);
            this.grpGeneral.Location = new System.Drawing.Point(12, 12);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(406, 192);
            this.grpGeneral.TabIndex = 0;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // btnAllProjects
            // 
            this.btnAllProjects.Location = new System.Drawing.Point(355, 151);
            this.btnAllProjects.Name = "btnAllProjects";
            this.btnAllProjects.Size = new System.Drawing.Size(45, 29);
            this.btnAllProjects.TabIndex = 6;
            this.btnAllProjects.Tag = "all";
            this.btnAllProjects.Text = "...";
            this.btnAllProjects.UseVisualStyleBackColor = true;
            this.btnAllProjects.Click += new System.EventHandler(this.BtnProjectLocation_Click);
            // 
            // txtMasterRoot
            // 
            this.txtMasterRoot.Location = new System.Drawing.Point(7, 152);
            this.txtMasterRoot.Name = "txtMasterRoot";
            this.txtMasterRoot.Size = new System.Drawing.Size(342, 29);
            this.txtMasterRoot.TabIndex = 5;
            // 
            // lblRootDir
            // 
            this.lblRootDir.AutoSize = true;
            this.lblRootDir.Location = new System.Drawing.Point(7, 128);
            this.lblRootDir.Name = "lblRootDir";
            this.lblRootDir.Size = new System.Drawing.Size(155, 21);
            this.lblRootDir.TabIndex = 4;
            this.lblRootDir.Text = "All Projects Directory";
            // 
            // listTimePattern
            // 
            this.listTimePattern.FormattingEnabled = true;
            this.listTimePattern.Location = new System.Drawing.Point(119, 76);
            this.listTimePattern.Name = "listTimePattern";
            this.listTimePattern.Size = new System.Drawing.Size(180, 29);
            this.listTimePattern.TabIndex = 3;
            // 
            // lblTimeFormat
            // 
            this.lblTimeFormat.AutoSize = true;
            this.lblTimeFormat.Location = new System.Drawing.Point(14, 79);
            this.lblTimeFormat.Name = "lblTimeFormat";
            this.lblTimeFormat.Size = new System.Drawing.Size(101, 21);
            this.lblTimeFormat.TabIndex = 2;
            this.lblTimeFormat.Text = "Time Format:";
            // 
            // listDatePattern
            // 
            this.listDatePattern.FormattingEnabled = true;
            this.listDatePattern.Location = new System.Drawing.Point(119, 32);
            this.listDatePattern.Name = "listDatePattern";
            this.listDatePattern.Size = new System.Drawing.Size(180, 29);
            this.listDatePattern.TabIndex = 1;
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Location = new System.Drawing.Point(14, 35);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(99, 21);
            this.lblDateFormat.TabIndex = 0;
            this.lblDateFormat.Text = "Date Format:";
            // 
            // txtGitLogHistory
            // 
            this.txtGitLogHistory.Location = new System.Drawing.Point(197, 47);
            this.txtGitLogHistory.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtGitLogHistory.Name = "txtGitLogHistory";
            this.txtGitLogHistory.Size = new System.Drawing.Size(57, 29);
            this.txtGitLogHistory.TabIndex = 7;
            // 
            // lblGitHistoryLines
            // 
            this.lblGitHistoryLines.AutoSize = true;
            this.lblGitHistoryLines.Location = new System.Drawing.Point(41, 49);
            this.lblGitHistoryLines.Name = "lblGitHistoryLines";
            this.lblGitHistoryLines.Size = new System.Drawing.Size(150, 21);
            this.lblGitHistoryLines.TabIndex = 5;
            this.lblGitHistoryLines.Text = "# Commits to Show:";
            // 
            // checkEnableGit
            // 
            this.checkEnableGit.AutoSize = true;
            this.checkEnableGit.Location = new System.Drawing.Point(16, 28);
            this.checkEnableGit.Name = "checkEnableGit";
            this.checkEnableGit.Size = new System.Drawing.Size(99, 25);
            this.checkEnableGit.TabIndex = 4;
            this.checkEnableGit.Text = "Enable Git";
            this.checkEnableGit.UseVisualStyleBackColor = true;
            this.checkEnableGit.CheckedChanged += new System.EventHandler(this.CheckEnableGit_CheckedChanged);
            // 
            // btnGitHub
            // 
            this.btnGitHub.Enabled = false;
            this.btnGitHub.Location = new System.Drawing.Point(131, 500);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(210, 36);
            this.btnGitHub.TabIndex = 4;
            this.btnGitHub.Text = "Enable GitHub Integration";
            this.btnGitHub.UseVisualStyleBackColor = true;
            this.btnGitHub.Click += new System.EventHandler(this.BtnGitHub_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(696, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // listProjects
            // 
            this.listProjects.FormattingEnabled = true;
            this.listProjects.ItemHeight = 21;
            this.listProjects.Location = new System.Drawing.Point(507, 206);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(432, 277);
            this.listProjects.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(844, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Project";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblProjName
            // 
            this.lblProjName.AutoSize = true;
            this.lblProjName.Location = new System.Drawing.Point(525, 15);
            this.lblProjName.Name = "lblProjName";
            this.lblProjName.Size = new System.Drawing.Size(107, 21);
            this.lblProjName.TabIndex = 6;
            this.lblProjName.Text = "Project Name:";
            // 
            // lblProjLoc
            // 
            this.lblProjLoc.AutoSize = true;
            this.lblProjLoc.Location = new System.Drawing.Point(508, 63);
            this.lblProjLoc.Name = "lblProjLoc";
            this.lblProjLoc.Size = new System.Drawing.Size(124, 21);
            this.lblProjLoc.TabIndex = 7;
            this.lblProjLoc.Text = "Project Location:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(638, 12);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(301, 29);
            this.txtProjectName.TabIndex = 8;
            // 
            // txtProjectLocation
            // 
            this.txtProjectLocation.Location = new System.Drawing.Point(638, 60);
            this.txtProjectLocation.Name = "txtProjectLocation";
            this.txtProjectLocation.Size = new System.Drawing.Size(250, 29);
            this.txtProjectLocation.TabIndex = 9;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(813, 500);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(126, 36);
            this.btnSaveClose.TabIndex = 10;
            this.btnSaveClose.Text = "Save && Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.BtnSaveClose_Click);
            // 
            // grpProjectSettings
            // 
            this.grpProjectSettings.Controls.Add(this.lblOpenWith);
            this.grpProjectSettings.Controls.Add(this.listOpenWith);
            this.grpProjectSettings.Controls.Add(this.chkEnableTimekeeping);
            this.grpProjectSettings.Controls.Add(this.txtGitLogHistory);
            this.grpProjectSettings.Controls.Add(this.checkEnableGit);
            this.grpProjectSettings.Controls.Add(this.lblGitHistoryLines);
            this.grpProjectSettings.Location = new System.Drawing.Point(12, 210);
            this.grpProjectSettings.Name = "grpProjectSettings";
            this.grpProjectSettings.Size = new System.Drawing.Size(406, 273);
            this.grpProjectSettings.TabIndex = 11;
            this.grpProjectSettings.TabStop = false;
            this.grpProjectSettings.Text = "Project";
            // 
            // lblOpenWith
            // 
            this.lblOpenWith.AutoSize = true;
            this.lblOpenWith.Location = new System.Drawing.Point(16, 152);
            this.lblOpenWith.Name = "lblOpenWith";
            this.lblOpenWith.Size = new System.Drawing.Size(88, 21);
            this.lblOpenWith.TabIndex = 10;
            this.lblOpenWith.Text = "Open With:";
            // 
            // listOpenWith
            // 
            this.listOpenWith.FormattingEnabled = true;
            this.listOpenWith.Location = new System.Drawing.Point(119, 149);
            this.listOpenWith.Name = "listOpenWith";
            this.listOpenWith.Size = new System.Drawing.Size(210, 29);
            this.listOpenWith.TabIndex = 9;
            // 
            // chkEnableTimekeeping
            // 
            this.chkEnableTimekeeping.AutoSize = true;
            this.chkEnableTimekeeping.Location = new System.Drawing.Point(16, 88);
            this.chkEnableTimekeeping.Name = "chkEnableTimekeeping";
            this.chkEnableTimekeeping.Size = new System.Drawing.Size(168, 25);
            this.chkEnableTimekeeping.TabIndex = 8;
            this.chkEnableTimekeeping.Text = "Enable Timekeeping";
            this.chkEnableTimekeeping.UseVisualStyleBackColor = true;
            this.chkEnableTimekeeping.CheckedChanged += new System.EventHandler(this.ChkEnableTimekeeping_CheckedChanged);
            // 
            // btnCurrentProject
            // 
            this.btnCurrentProject.Location = new System.Drawing.Point(894, 59);
            this.btnCurrentProject.Name = "btnCurrentProject";
            this.btnCurrentProject.Size = new System.Drawing.Size(45, 29);
            this.btnCurrentProject.TabIndex = 7;
            this.btnCurrentProject.Tag = "current";
            this.btnCurrentProject.Text = "...";
            this.btnCurrentProject.UseVisualStyleBackColor = true;
            this.btnCurrentProject.Click += new System.EventHandler(this.BtnProjectLocation_Click);
            // 
            // btnMainProjFile
            // 
            this.btnMainProjFile.Location = new System.Drawing.Point(894, 108);
            this.btnMainProjFile.Name = "btnMainProjFile";
            this.btnMainProjFile.Size = new System.Drawing.Size(45, 29);
            this.btnMainProjFile.TabIndex = 12;
            this.btnMainProjFile.Tag = "current";
            this.btnMainProjFile.Text = "...";
            this.btnMainProjFile.UseVisualStyleBackColor = true;
            this.btnMainProjFile.Click += new System.EventHandler(this.BtnMainProjFile_Click);
            // 
            // txtMainProjFile
            // 
            this.txtMainProjFile.Location = new System.Drawing.Point(638, 108);
            this.txtMainProjFile.Name = "txtMainProjFile";
            this.txtMainProjFile.Size = new System.Drawing.Size(250, 29);
            this.txtMainProjFile.TabIndex = 14;
            // 
            // lblMainProjFile
            // 
            this.lblMainProjFile.AutoSize = true;
            this.lblMainProjFile.Location = new System.Drawing.Point(508, 111);
            this.lblMainProjFile.Name = "lblMainProjFile";
            this.lblMainProjFile.Size = new System.Drawing.Size(128, 21);
            this.lblMainProjFile.TabIndex = 13;
            this.lblMainProjFile.Text = "Main Project File:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 548);
            this.Controls.Add(this.btnMainProjFile);
            this.Controls.Add(this.txtMainProjFile);
            this.Controls.Add(this.lblMainProjFile);
            this.Controls.Add(this.btnCurrentProject);
            this.Controls.Add(this.grpProjectSettings);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnGitHub);
            this.Controls.Add(this.txtProjectLocation);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblProjLoc);
            this.Controls.Add(this.lblProjName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listProjects);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpGeneral);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGitLogHistory)).EndInit();
            this.grpProjectSettings.ResumeLayout(false);
            this.grpProjectSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.ComboBox listDatePattern;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.ComboBox listTimePattern;
        private System.Windows.Forms.Label lblTimeFormat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listProjects;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblProjName;
        private System.Windows.Forms.Label lblProjLoc;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectLocation;
        private System.Windows.Forms.Button btnGitHub;
        private System.Windows.Forms.ToolTip toolTipGitHub;
        private System.Windows.Forms.CheckBox checkEnableGit;
        private System.Windows.Forms.NumericUpDown txtGitLogHistory;
        private System.Windows.Forms.Label lblGitHistoryLines;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.GroupBox grpProjectSettings;
        private System.Windows.Forms.TextBox txtMasterRoot;
        private System.Windows.Forms.Label lblRootDir;
        private System.Windows.Forms.Button btnAllProjects;
        private System.Windows.Forms.Button btnCurrentProject;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox chkEnableTimekeeping;
        private System.Windows.Forms.Button btnMainProjFile;
        private System.Windows.Forms.TextBox txtMainProjFile;
        private System.Windows.Forms.Label lblMainProjFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblOpenWith;
        private System.Windows.Forms.ComboBox listOpenWith;
    }
}