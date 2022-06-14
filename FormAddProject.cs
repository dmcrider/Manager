using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class FormAddProject : Form
    {
        internal Project Project { get; set; }

        public FormAddProject()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void FormAddProject_Load(object sender, EventArgs e)
        {
            Project = null;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtRootDirectory.Text = folderBrowserDialog.SelectedPath;
                if(txtProjectName.Text == string.Empty)
                {
                    txtProjectName.Text = folderBrowserDialog.SelectedPath.Split("\\").Last();
                }
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Project = Project.CreateProject(txtProjectName.Text, txtRootDirectory.Text, (int)numberGitCommits.Value);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
