
namespace Manager
{
    partial class FormChangeGitBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeGitBranch));
            this.lblCurrentBranch = new System.Windows.Forms.Label();
            this.lblNewBranch = new System.Windows.Forms.Label();
            this.txtCurrentBranch = new System.Windows.Forms.TextBox();
            this.txtNewBranch = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listAllBranches = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCurrentBranch
            // 
            this.lblCurrentBranch.AutoSize = true;
            this.lblCurrentBranch.Location = new System.Drawing.Point(28, 29);
            this.lblCurrentBranch.Name = "lblCurrentBranch";
            this.lblCurrentBranch.Size = new System.Drawing.Size(118, 21);
            this.lblCurrentBranch.TabIndex = 0;
            this.lblCurrentBranch.Text = "Current Branch:";
            // 
            // lblNewBranch
            // 
            this.lblNewBranch.AutoSize = true;
            this.lblNewBranch.Location = new System.Drawing.Point(49, 71);
            this.lblNewBranch.Name = "lblNewBranch";
            this.lblNewBranch.Size = new System.Drawing.Size(97, 21);
            this.lblNewBranch.TabIndex = 1;
            this.lblNewBranch.Text = "New Branch:";
            // 
            // txtCurrentBranch
            // 
            this.txtCurrentBranch.Location = new System.Drawing.Point(152, 26);
            this.txtCurrentBranch.Name = "txtCurrentBranch";
            this.txtCurrentBranch.ReadOnly = true;
            this.txtCurrentBranch.Size = new System.Drawing.Size(175, 29);
            this.txtCurrentBranch.TabIndex = 2;
            // 
            // txtNewBranch
            // 
            this.txtNewBranch.Location = new System.Drawing.Point(153, 68);
            this.txtNewBranch.Name = "txtNewBranch";
            this.txtNewBranch.ReadOnly = true;
            this.txtNewBranch.Size = new System.Drawing.Size(174, 29);
            this.txtNewBranch.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(251, 226);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(88, 32);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // listAllBranches
            // 
            this.listAllBranches.FormattingEnabled = true;
            this.listAllBranches.ItemHeight = 21;
            this.listAllBranches.Location = new System.Drawing.Point(25, 103);
            this.listAllBranches.Name = "listAllBranches";
            this.listAllBranches.Size = new System.Drawing.Size(302, 109);
            this.listAllBranches.TabIndex = 7;
            this.listAllBranches.SelectedIndexChanged += new System.EventHandler(this.ListAllBranches_SelectedIndexChanged);
            // 
            // FormChangeGitBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 270);
            this.Controls.Add(this.listAllBranches);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtNewBranch);
            this.Controls.Add(this.txtCurrentBranch);
            this.Controls.Add(this.lblNewBranch);
            this.Controls.Add(this.lblCurrentBranch);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChangeGitBranch";
            this.Text = "Change Git Branch";
            this.Load += new System.EventHandler(this.FormChangeGitBranch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentBranch;
        private System.Windows.Forms.Label lblNewBranch;
        private System.Windows.Forms.TextBox txtCurrentBranch;
        private System.Windows.Forms.TextBox txtNewBranch;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listAllBranches;
    }
}