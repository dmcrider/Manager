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
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtRootDirectory = new System.Windows.Forms.TextBox();
            this.lblRootDirectory = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberGitCommits = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numberGitCommits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(12, 46);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(107, 21);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Project Name:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(140, 43);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(269, 29);
            this.txtProjectName.TabIndex = 1;
            // 
            // txtRootDirectory
            // 
            this.txtRootDirectory.Location = new System.Drawing.Point(140, 99);
            this.txtRootDirectory.Name = "txtRootDirectory";
            this.txtRootDirectory.ReadOnly = true;
            this.txtRootDirectory.Size = new System.Drawing.Size(269, 29);
            this.txtRootDirectory.TabIndex = 3;
            // 
            // lblRootDirectory
            // 
            this.lblRootDirectory.AutoSize = true;
            this.lblRootDirectory.Location = new System.Drawing.Point(12, 102);
            this.lblRootDirectory.Name = "lblRootDirectory";
            this.lblRootDirectory.Size = new System.Drawing.Size(114, 21);
            this.lblRootDirectory.TabIndex = 2;
            this.lblRootDirectory.Text = "Root Directory:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(426, 99);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(78, 30);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "# Git commits to show:";
            // 
            // numberGitCommits
            // 
            this.numberGitCommits.Location = new System.Drawing.Point(187, 191);
            this.numberGitCommits.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numberGitCommits.Name = "numberGitCommits";
            this.numberGitCommits.Size = new System.Drawing.Size(61, 29);
            this.numberGitCommits.TabIndex = 6;
            this.numberGitCommits.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(394, 206);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(138, 33);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create Project";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // FormAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 251);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.numberGitCommits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtRootDirectory);
            this.Controls.Add(this.lblRootDirectory);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblProjectName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddProject";
            this.Text = "Add New Project";
            this.Load += new System.EventHandler(this.FormAddProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberGitCommits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProjectName;
        private TextBox txtProjectName;
        private TextBox txtRootDirectory;
        private Label lblRootDirectory;
        private Button btnBrowse;
        private Label label1;
        private NumericUpDown numberGitCommits;
        private Button btnCreate;
        private FolderBrowserDialog folderBrowserDialog;
    }
}