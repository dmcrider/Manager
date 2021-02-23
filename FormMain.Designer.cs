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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConfigure = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.listboxProjects = new System.Windows.Forms.ListBox();
            this.lblProjectLocation = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.grpOpenWith = new System.Windows.Forms.GroupBox();
            this.btnOpenVSCode = new System.Windows.Forms.Button();
            this.btnOpenVisualStudio = new System.Windows.Forms.Button();
            this.btnOpenAndroidStudio = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.grpOpenWith.SuspendLayout();
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
            this.toolStripMenuItemConfigure});
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(78, 25);
            this.toolStripMenuItemSettings.Text = "Settings";
            // 
            // toolStripMenuItemConfigure
            // 
            this.toolStripMenuItemConfigure.Name = "toolStripMenuItemConfigure";
            this.toolStripMenuItemConfigure.Size = new System.Drawing.Size(149, 26);
            this.toolStripMenuItemConfigure.Text = "Configure";
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
            // grpOpenWith
            // 
            this.grpOpenWith.Controls.Add(this.btnOpenAndroidStudio);
            this.grpOpenWith.Controls.Add(this.btnOpenVisualStudio);
            this.grpOpenWith.Controls.Add(this.btnOpenVSCode);
            this.grpOpenWith.Location = new System.Drawing.Point(264, 91);
            this.grpOpenWith.Name = "grpOpenWith";
            this.grpOpenWith.Size = new System.Drawing.Size(888, 89);
            this.grpOpenWith.TabIndex = 4;
            this.grpOpenWith.TabStop = false;
            this.grpOpenWith.Text = "Open Project With";
            // 
            // btnOpenVSCode
            // 
            this.btnOpenVSCode.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenVSCode.Image")));
            this.btnOpenVSCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenVSCode.Location = new System.Drawing.Point(28, 28);
            this.btnOpenVSCode.Name = "btnOpenVSCode";
            this.btnOpenVSCode.Size = new System.Drawing.Size(175, 38);
            this.btnOpenVSCode.TabIndex = 0;
            this.btnOpenVSCode.Tag = "vscode";
            this.btnOpenVSCode.Text = "Visual Studio Code";
            this.btnOpenVSCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenVSCode.UseVisualStyleBackColor = true;
            this.btnOpenVSCode.Click += new System.EventHandler(this.BtnOpenWith_Click);
            // 
            // btnOpenVisualStudio
            // 
            this.btnOpenVisualStudio.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenVisualStudio.Image")));
            this.btnOpenVisualStudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenVisualStudio.Location = new System.Drawing.Point(392, 28);
            this.btnOpenVisualStudio.Name = "btnOpenVisualStudio";
            this.btnOpenVisualStudio.Size = new System.Drawing.Size(135, 38);
            this.btnOpenVisualStudio.TabIndex = 1;
            this.btnOpenVisualStudio.Tag = "visualstudio";
            this.btnOpenVisualStudio.Text = "Visual Studio";
            this.btnOpenVisualStudio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenVisualStudio.UseVisualStyleBackColor = true;
            this.btnOpenVisualStudio.Click += new System.EventHandler(this.BtnOpenWith_Click);
            // 
            // btnOpenAndroidStudio
            // 
            this.btnOpenAndroidStudio.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenAndroidStudio.Image")));
            this.btnOpenAndroidStudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAndroidStudio.Location = new System.Drawing.Point(716, 28);
            this.btnOpenAndroidStudio.Name = "btnOpenAndroidStudio";
            this.btnOpenAndroidStudio.Size = new System.Drawing.Size(151, 38);
            this.btnOpenAndroidStudio.TabIndex = 2;
            this.btnOpenAndroidStudio.Tag = "android";
            this.btnOpenAndroidStudio.Text = "Android Studio";
            this.btnOpenAndroidStudio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenAndroidStudio.UseVisualStyleBackColor = true;
            this.btnOpenAndroidStudio.Click += new System.EventHandler(this.BtnOpenWith_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 722);
            this.Controls.Add(this.grpOpenWith);
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
            this.grpOpenWith.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpOpenWith;
        private System.Windows.Forms.Button btnOpenAndroidStudio;
        private System.Windows.Forms.Button btnOpenVisualStudio;
        private System.Windows.Forms.Button btnOpenVSCode;
    }
}

