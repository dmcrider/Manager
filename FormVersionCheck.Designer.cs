namespace Manager
{
    partial class FormVersionCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVersionCheck));
            this.lblInstalledVersion = new System.Windows.Forms.Label();
            this.lblAvailableVersion = new System.Windows.Forms.Label();
            this.txtInstalledVersion = new System.Windows.Forms.TextBox();
            this.txtAvailableVersion = new System.Windows.Forms.TextBox();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstalledVersion
            // 
            this.lblInstalledVersion.AutoSize = true;
            this.lblInstalledVersion.Location = new System.Drawing.Point(40, 35);
            this.lblInstalledVersion.Name = "lblInstalledVersion";
            this.lblInstalledVersion.Size = new System.Drawing.Size(127, 21);
            this.lblInstalledVersion.TabIndex = 0;
            this.lblInstalledVersion.Text = "Installed Version:";
            // 
            // lblAvailableVersion
            // 
            this.lblAvailableVersion.AutoSize = true;
            this.lblAvailableVersion.Location = new System.Drawing.Point(35, 86);
            this.lblAvailableVersion.Name = "lblAvailableVersion";
            this.lblAvailableVersion.Size = new System.Drawing.Size(132, 21);
            this.lblAvailableVersion.TabIndex = 1;
            this.lblAvailableVersion.Text = "Available Version:";
            // 
            // txtInstalledVersion
            // 
            this.txtInstalledVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstalledVersion.Location = new System.Drawing.Point(173, 32);
            this.txtInstalledVersion.Name = "txtInstalledVersion";
            this.txtInstalledVersion.ReadOnly = true;
            this.txtInstalledVersion.Size = new System.Drawing.Size(192, 29);
            this.txtInstalledVersion.TabIndex = 10;
            // 
            // txtAvailableVersion
            // 
            this.txtAvailableVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAvailableVersion.Location = new System.Drawing.Point(173, 84);
            this.txtAvailableVersion.Name = "txtAvailableVersion";
            this.txtAvailableVersion.ReadOnly = true;
            this.txtAvailableVersion.Size = new System.Drawing.Size(192, 29);
            this.txtAvailableVersion.TabIndex = 11;
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Location = new System.Drawing.Point(35, 157);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(91, 34);
            this.btnUpgrade.TabIndex = 1;
            this.btnUpgrade.Text = "Upgrade";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.BtnUpgrade_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(274, 157);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "OK";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FormVersionCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 213);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.txtAvailableVersion);
            this.Controls.Add(this.txtInstalledVersion);
            this.Controls.Add(this.lblAvailableVersion);
            this.Controls.Add(this.lblInstalledVersion);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVersionCheck";
            this.Text = "Version Check";
            this.Load += new System.EventHandler(this.FormVersionCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstalledVersion;
        private System.Windows.Forms.Label lblAvailableVersion;
        private System.Windows.Forms.TextBox txtInstalledVersion;
        private System.Windows.Forms.TextBox txtAvailableVersion;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Button btnClose;
    }
}