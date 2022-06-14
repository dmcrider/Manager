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
    public partial class FormManageProjects : Form
    {
        private List<Project> _projectList;
        private Project _selectedProject;
        private string _profileName;

        public FormManageProjects()
        {
            InitializeComponent();
            CenterToParent();
        }

        public FormManageProjects(string profileName) : this()
        {
            _profileName = profileName;
            _selectedProject = null;
        }

        private void FormManageProjects_Load(object sender, EventArgs e)
        {
            PopulateProjectList();
        }

        private void PopulateProjectList()
        {
            _projectList = ProfileHandler.Instance.Profiles.Where(x => x.ProfileName == _profileName).First().ProjectList;

            listboxProjects.Items.Clear();
            listboxProjects.Items.AddRange(_projectList.ToArray());
            listboxProjects.SelectedIndex = 0;
        }

        private void ListboxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedProject = _projectList.Where(x => x.Name == listboxProjects.SelectedItem.ToString()).First();

            txtProjectName.Text = _selectedProject.Name;
            txtRootDirectory.Text = _selectedProject.RootDirectory;
            numberGitCommits.Value = _selectedProject.GitLogHistory;

            btnUpdate.Tag = _selectedProject.Name;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                txtRootDirectory.Text = folderBrowserDialog.SelectedPath;
                _selectedProject.RootDirectory = folderBrowserDialog.SelectedPath;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var formAddNewProject = new FormAddProject();
            var result = formAddNewProject.ShowDialog();

            if (result == DialogResult.OK)
            {
                var profile = ProfileHandler.Instance.Profiles.Where(x => x.ProfileName == _profileName).First();
                ProfileHandler.Instance.CreateProject(profile, formAddNewProject.Project);
                PopulateProjectList();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var profile = ProfileHandler.Instance.Profiles.Where(x => x.ProfileName == _profileName).First();
            var project = new Project()
            {
                Name = txtProjectName.Text,
                RootDirectory = txtRootDirectory.Text,
                GitLogHistory = (int)numberGitCommits.Value
            };

            ProfileHandler.Instance.UpdateProject(profile, project, btnUpdate.Tag.ToString());
            PopulateProjectList();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
