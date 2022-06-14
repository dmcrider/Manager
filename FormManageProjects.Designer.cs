namespace Manager
{
    partial class FormManageProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageProjects));
            this.listboxProjects = new System.Windows.Forms.ListBox();
            this.numberGitCommits = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtRootDirectory = new System.Windows.Forms.TextBox();
            this.lblRootDirectory = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberGitCommits)).BeginInit();
            this.SuspendLayout();
            // 
            // listboxProjects
            // 
            this.listboxProjects.FormattingEnabled = true;
            this.listboxProjects.ItemHeight = 21;
            this.listboxProjects.Location = new System.Drawing.Point(12, 12);
            this.listboxProjects.Name = "listboxProjects";
            this.listboxProjects.Size = new System.Drawing.Size(242, 319);
            this.listboxProjects.TabIndex = 0;
            this.listboxProjects.SelectedIndexChanged += new System.EventHandler(this.ListboxProjects_SelectedIndexChanged);
            // 
            // numberGitCommits
            // 
            this.numberGitCommits.Location = new System.Drawing.Point(460, 155);
            this.numberGitCommits.Margin = new System.Windows.Forms.Padding(4);
            this.numberGitCommits.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numberGitCommits.Name = "numberGitCommits";
            this.numberGitCommits.Size = new System.Drawing.Size(78, 29);
            this.numberGitCommits.TabIndex = 13;
            this.numberGitCommits.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "# Git commits to show:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(698, 84);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(78, 30);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtRootDirectory
            // 
            this.txtRootDirectory.Location = new System.Drawing.Point(412, 84);
            this.txtRootDirectory.Name = "txtRootDirectory";
            this.txtRootDirectory.ReadOnly = true;
            this.txtRootDirectory.Size = new System.Drawing.Size(269, 29);
            this.txtRootDirectory.TabIndex = 10;
            // 
            // lblRootDirectory
            // 
            this.lblRootDirectory.AutoSize = true;
            this.lblRootDirectory.Location = new System.Drawing.Point(284, 87);
            this.lblRootDirectory.Name = "lblRootDirectory";
            this.lblRootDirectory.Size = new System.Drawing.Size(114, 21);
            this.lblRootDirectory.TabIndex = 9;
            this.lblRootDirectory.Text = "Root Directory:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(412, 28);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(269, 29);
            this.txtProjectName.TabIndex = 8;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(284, 31);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(107, 21);
            this.lblProjectName.TabIndex = 7;
            this.lblProjectName.Text = "Project Name:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(568, 229);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 34);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(12, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 34);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "REMOVE PROJECT";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(285, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 34);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(696, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 34);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FormManageProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 395);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.numberGitCommits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtRootDirectory);
            this.Controls.Add(this.lblRootDirectory);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.listboxProjects);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManageProjects";
            this.Text = "Manage Projects";
            this.Load += new System.EventHandler(this.FormManageProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberGitCommits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listboxProjects;
        private NumericUpDown numberGitCommits;
        private Label label1;
        private Button btnBrowse;
        private TextBox txtRootDirectory;
        private Label lblRootDirectory;
        private TextBox txtProjectName;
        private Label lblProjectName;
        private Button btnUpdate;
        private Button btnDelete;
        private FolderBrowserDialog folderBrowserDialog;
        private Button btnAdd;
        private Button btnClose;
    }
}