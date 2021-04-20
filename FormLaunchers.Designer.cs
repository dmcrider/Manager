
namespace Manager
{
    partial class FormLaunchers
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
            this.lblAndroid = new System.Windows.Forms.Label();
            this.lblVSCode = new System.Windows.Forms.Label();
            this.lblVSCommunity = new System.Windows.Forms.Label();
            this.txtAndroidStudioPath = new System.Windows.Forms.TextBox();
            this.txtVSCodePath = new System.Windows.Forms.TextBox();
            this.txtVSCommunityPath = new System.Windows.Forms.TextBox();
            this.btnAndroid = new System.Windows.Forms.Button();
            this.btnVSCode = new System.Windows.Forms.Button();
            this.btnVSCommunity = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadDefaults = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblAndroid
            // 
            this.lblAndroid.AutoSize = true;
            this.lblAndroid.Location = new System.Drawing.Point(96, 38);
            this.lblAndroid.Name = "lblAndroid";
            this.lblAndroid.Size = new System.Drawing.Size(117, 21);
            this.lblAndroid.TabIndex = 0;
            this.lblAndroid.Text = "Android Studio:";
            // 
            // lblVSCode
            // 
            this.lblVSCode.AutoSize = true;
            this.lblVSCode.Location = new System.Drawing.Point(70, 91);
            this.lblVSCode.Name = "lblVSCode";
            this.lblVSCode.Size = new System.Drawing.Size(143, 21);
            this.lblVSCode.TabIndex = 1;
            this.lblVSCode.Text = "Visual Studio Code:";
            // 
            // lblVSCommunity
            // 
            this.lblVSCommunity.AutoSize = true;
            this.lblVSCommunity.Location = new System.Drawing.Point(24, 144);
            this.lblVSCommunity.Name = "lblVSCommunity";
            this.lblVSCommunity.Size = new System.Drawing.Size(189, 21);
            this.lblVSCommunity.TabIndex = 2;
            this.lblVSCommunity.Text = "Visual Studio Community:";
            // 
            // txtAndroidStudioPath
            // 
            this.txtAndroidStudioPath.Location = new System.Drawing.Point(219, 35);
            this.txtAndroidStudioPath.Name = "txtAndroidStudioPath";
            this.txtAndroidStudioPath.ReadOnly = true;
            this.txtAndroidStudioPath.Size = new System.Drawing.Size(635, 29);
            this.txtAndroidStudioPath.TabIndex = 3;
            // 
            // txtVSCodePath
            // 
            this.txtVSCodePath.Location = new System.Drawing.Point(219, 88);
            this.txtVSCodePath.Name = "txtVSCodePath";
            this.txtVSCodePath.ReadOnly = true;
            this.txtVSCodePath.Size = new System.Drawing.Size(635, 29);
            this.txtVSCodePath.TabIndex = 4;
            // 
            // txtVSCommunityPath
            // 
            this.txtVSCommunityPath.Location = new System.Drawing.Point(219, 141);
            this.txtVSCommunityPath.Name = "txtVSCommunityPath";
            this.txtVSCommunityPath.ReadOnly = true;
            this.txtVSCommunityPath.Size = new System.Drawing.Size(635, 29);
            this.txtVSCommunityPath.TabIndex = 5;
            // 
            // btnAndroid
            // 
            this.btnAndroid.Location = new System.Drawing.Point(861, 35);
            this.btnAndroid.Name = "btnAndroid";
            this.btnAndroid.Size = new System.Drawing.Size(56, 29);
            this.btnAndroid.TabIndex = 6;
            this.btnAndroid.Tag = "android";
            this.btnAndroid.Text = "...";
            this.btnAndroid.UseVisualStyleBackColor = true;
            this.btnAndroid.Click += new System.EventHandler(this.BtnChangePath_Click);
            // 
            // btnVSCode
            // 
            this.btnVSCode.Location = new System.Drawing.Point(861, 87);
            this.btnVSCode.Name = "btnVSCode";
            this.btnVSCode.Size = new System.Drawing.Size(56, 29);
            this.btnVSCode.TabIndex = 7;
            this.btnVSCode.Tag = "vscode";
            this.btnVSCode.Text = "...";
            this.btnVSCode.UseVisualStyleBackColor = true;
            this.btnVSCode.Click += new System.EventHandler(this.BtnChangePath_Click);
            // 
            // btnVSCommunity
            // 
            this.btnVSCommunity.Location = new System.Drawing.Point(861, 140);
            this.btnVSCommunity.Name = "btnVSCommunity";
            this.btnVSCommunity.Size = new System.Drawing.Size(56, 29);
            this.btnVSCommunity.TabIndex = 8;
            this.btnVSCommunity.Tag = "vscommunity";
            this.btnVSCommunity.Text = "...";
            this.btnVSCommunity.UseVisualStyleBackColor = true;
            this.btnVSCommunity.Click += new System.EventHandler(this.BtnChangePath_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(833, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 34);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoadDefaults
            // 
            this.btnLoadDefaults.Location = new System.Drawing.Point(377, 228);
            this.btnLoadDefaults.Name = "btnLoadDefaults";
            this.btnLoadDefaults.Size = new System.Drawing.Size(174, 34);
            this.btnLoadDefaults.TabIndex = 11;
            this.btnLoadDefaults.Text = "Load Defaults";
            this.btnLoadDefaults.UseVisualStyleBackColor = true;
            this.btnLoadDefaults.Click += new System.EventHandler(this.BtnLoadDefaults_Click);
            // 
            // folderDialog
            // 
            this.folderDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // FormLaunchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 274);
            this.Controls.Add(this.btnLoadDefaults);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnVSCommunity);
            this.Controls.Add(this.btnVSCode);
            this.Controls.Add(this.btnAndroid);
            this.Controls.Add(this.txtVSCommunityPath);
            this.Controls.Add(this.txtVSCodePath);
            this.Controls.Add(this.txtAndroidStudioPath);
            this.Controls.Add(this.lblVSCommunity);
            this.Controls.Add(this.lblVSCode);
            this.Controls.Add(this.lblAndroid);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormLaunchers";
            this.Text = "Program Launchers";
            this.Load += new System.EventHandler(this.FormLaunchers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAndroid;
        private System.Windows.Forms.Label lblVSCode;
        private System.Windows.Forms.Label lblVSCommunity;
        private System.Windows.Forms.TextBox txtAndroidStudioPath;
        private System.Windows.Forms.TextBox txtVSCodePath;
        private System.Windows.Forms.TextBox txtVSCommunityPath;
        private System.Windows.Forms.Button btnAndroid;
        private System.Windows.Forms.Button btnVSCode;
        private System.Windows.Forms.Button btnVSCommunity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadDefaults;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
    }
}