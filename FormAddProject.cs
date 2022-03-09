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
        private Project _project;
        private FormMain _formMain;

        public FormAddProject()
        {
            InitializeComponent();
            CenterToParent();
        }

        public FormAddProject(FormMain main) : this()
        {
            _formMain = main;
        }

        private void FormAddProject_Load(object sender, EventArgs e)
        {
            _project = new Project();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                txtDirectoryPath.Text = folderBrowserDialog.SelectedPath;
                
                if(txtProjectName.Text == string.Empty)
                {
                    txtProjectName.Text = System.IO.Path.GetFileName(System.IO.Path.GetDirectoryName(folderBrowserDialog.SelectedPath));
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _project = null;
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _project.Name = txtProjectName.Text;
            _project.RootDirectory = txtDirectoryPath.Text;
            _project.DefaultLauncher = GetLauncher();
            _project.EnableGitLog = checkEnableGit.Checked;
            _project.EnableTimekeeping = checkEnableTimekeeping.Checked;
            _project.GitLogHistory = (int)numberGitCommits.Value;

            if (ValidateRequiredFields(_project))
            {
                _formMain.AddProject(_project);
            }
        }

        private bool ValidateRequiredFields(Project proj)
        {
            if(proj.RootDirectory == string.Empty)
            {
                MessageBox.Show("Please select a base Directory for this project.");
                return false;
            }

            if(proj.Name == string.Empty)
            {
                MessageBox.Show("Please enter a name for the project.");
                return false;
            }

            // All conditions have been met
            return true;
        }

        private Launcher GetLauncher()
        {
            foreach(var radio in grpDefaultLauncher.Controls.OfType<RadioButton>())
            {
                if (radio.Checked)
                {
                    switch (radio.Tag.ToString())
                    {
                        case "vs": return Launcher.VisualStudioCommunity;
                        case "vsc": return Launcher.VisualStudioCode;
                        case "android": return Launcher.AndroidStudio;
                        case "file":
                        default:
                            return Launcher.None;
                    }
                }
            }

            return Launcher.None;
        }
    }
}