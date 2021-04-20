
namespace Manager
{
    partial class FormExcludeProjects
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
            this.listAllProjects = new System.Windows.Forms.ListBox();
            this.lblAllProjects = new System.Windows.Forms.Label();
            this.lblExclude = new System.Windows.Forms.Label();
            this.listExcluded = new System.Windows.Forms.ListBox();
            this.btnExclude = new System.Windows.Forms.Button();
            this.btnInclude = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listAllProjects
            // 
            this.listAllProjects.FormattingEnabled = true;
            this.listAllProjects.ItemHeight = 21;
            this.listAllProjects.Location = new System.Drawing.Point(12, 44);
            this.listAllProjects.Name = "listAllProjects";
            this.listAllProjects.Size = new System.Drawing.Size(210, 382);
            this.listAllProjects.TabIndex = 0;
            // 
            // lblAllProjects
            // 
            this.lblAllProjects.AutoSize = true;
            this.lblAllProjects.Location = new System.Drawing.Point(74, 20);
            this.lblAllProjects.Name = "lblAllProjects";
            this.lblAllProjects.Size = new System.Drawing.Size(87, 21);
            this.lblAllProjects.TabIndex = 1;
            this.lblAllProjects.Text = "All Projects";
            // 
            // lblExclude
            // 
            this.lblExclude.AutoSize = true;
            this.lblExclude.Location = new System.Drawing.Point(511, 20);
            this.lblExclude.Name = "lblExclude";
            this.lblExclude.Size = new System.Drawing.Size(130, 21);
            this.lblExclude.TabIndex = 3;
            this.lblExclude.Text = "Excluded Projects";
            // 
            // listExcluded
            // 
            this.listExcluded.FormattingEnabled = true;
            this.listExcluded.ItemHeight = 21;
            this.listExcluded.Location = new System.Drawing.Point(449, 44);
            this.listExcluded.Name = "listExcluded";
            this.listExcluded.Size = new System.Drawing.Size(210, 382);
            this.listExcluded.TabIndex = 2;
            // 
            // btnExclude
            // 
            this.btnExclude.Location = new System.Drawing.Point(297, 44);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(77, 33);
            this.btnExclude.TabIndex = 4;
            this.btnExclude.Text = "->";
            this.btnExclude.UseVisualStyleBackColor = true;
            this.btnExclude.Click += new System.EventHandler(this.BtnExclude_Click);
            // 
            // btnInclude
            // 
            this.btnInclude.Location = new System.Drawing.Point(297, 393);
            this.btnInclude.Name = "btnInclude";
            this.btnInclude.Size = new System.Drawing.Size(77, 33);
            this.btnInclude.TabIndex = 5;
            this.btnInclude.Text = "<-";
            this.btnInclude.UseVisualStyleBackColor = true;
            this.btnInclude.Click += new System.EventHandler(this.BtnInclude_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(573, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 37);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FormExcludeProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 492);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInclude);
            this.Controls.Add(this.btnExclude);
            this.Controls.Add(this.lblExclude);
            this.Controls.Add(this.listExcluded);
            this.Controls.Add(this.lblAllProjects);
            this.Controls.Add(this.listAllProjects);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormExcludeProjects";
            this.Text = "Exclude Projects";
            this.Load += new System.EventHandler(this.FormExcludeProjects_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listAllProjects;
        private System.Windows.Forms.Label lblAllProjects;
        private System.Windows.Forms.Label lblExclude;
        private System.Windows.Forms.ListBox listExcluded;
        private System.Windows.Forms.Button btnExclude;
        private System.Windows.Forms.Button btnInclude;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}