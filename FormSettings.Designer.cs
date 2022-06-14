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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.dropdownDateFormat = new System.Windows.Forms.ComboBox();
            this.dropdownTimeFormat = new System.Windows.Forms.ComboBox();
            this.lblTimeFormat = new System.Windows.Forms.Label();
            this.lblTextEditor = new System.Windows.Forms.Label();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Location = new System.Drawing.Point(18, 47);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(99, 21);
            this.lblDateFormat.TabIndex = 0;
            this.lblDateFormat.Text = "Date Format:";
            // 
            // dropdownDateFormat
            // 
            this.dropdownDateFormat.FormattingEnabled = true;
            this.dropdownDateFormat.Location = new System.Drawing.Point(123, 44);
            this.dropdownDateFormat.Name = "dropdownDateFormat";
            this.dropdownDateFormat.Size = new System.Drawing.Size(251, 29);
            this.dropdownDateFormat.TabIndex = 1;
            this.dropdownDateFormat.SelectedIndexChanged += new System.EventHandler(this.DropdownDateFormat_SelectedIndexChanged);
            // 
            // dropdownTimeFormat
            // 
            this.dropdownTimeFormat.FormattingEnabled = true;
            this.dropdownTimeFormat.Location = new System.Drawing.Point(123, 94);
            this.dropdownTimeFormat.Name = "dropdownTimeFormat";
            this.dropdownTimeFormat.Size = new System.Drawing.Size(251, 29);
            this.dropdownTimeFormat.TabIndex = 3;
            this.dropdownTimeFormat.SelectedIndexChanged += new System.EventHandler(this.DropdownTimeFormat_SelectedIndexChanged);
            // 
            // lblTimeFormat
            // 
            this.lblTimeFormat.AutoSize = true;
            this.lblTimeFormat.Location = new System.Drawing.Point(18, 97);
            this.lblTimeFormat.Name = "lblTimeFormat";
            this.lblTimeFormat.Size = new System.Drawing.Size(101, 21);
            this.lblTimeFormat.TabIndex = 2;
            this.lblTimeFormat.Text = "Time Format:";
            // 
            // lblTextEditor
            // 
            this.lblTextEditor.AutoSize = true;
            this.lblTextEditor.Location = new System.Drawing.Point(18, 164);
            this.lblTextEditor.Name = "lblTextEditor";
            this.lblTextEditor.Size = new System.Drawing.Size(153, 21);
            this.lblTextEditor.TabIndex = 4;
            this.lblTextEditor.Text = "Preferred Text Editor:";
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(177, 161);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ReadOnly = true;
            this.txtEditor.Size = new System.Drawing.Size(210, 29);
            this.txtEditor.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(409, 164);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(93, 29);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(371, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 317);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.lblTextEditor);
            this.Controls.Add(this.dropdownTimeFormat);
            this.Controls.Add(this.lblTimeFormat);
            this.Controls.Add(this.dropdownDateFormat);
            this.Controls.Add(this.lblDateFormat);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDateFormat;
        private ComboBox dropdownDateFormat;
        private ComboBox dropdownTimeFormat;
        private Label lblTimeFormat;
        private Label lblTextEditor;
        private TextBox txtEditor;
        private Button btnBrowse;
        private Button btnCancel;
        private Button btnSave;
        private OpenFileDialog openFileDialog;
    }
}