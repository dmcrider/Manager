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
    public partial class FormExcludeProjects : Form
    {
        public UserSettings Settings;
        public FormMain _Parent;

        private BindingList<Project> allowedProjects;
        private BindingList<Project> excludedProjects;
        private BindingSource allowedSource = new BindingSource();
        private BindingSource excludedSource = new BindingSource();
        private readonly string noExcludedProjects = "No Projects Excluded";

        public FormExcludeProjects()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void FormExcludeProjects_Load(object sender, EventArgs e)
        {
            if(Settings == null) { this.Close(); }

            allowedProjects = _Parent.GetProjectsInDirectory(Settings.MasterRootPath);

            if (Settings.ExcludedProjects.Any())
            {
                excludedProjects = new BindingList<Project>(Settings.ExcludedProjects);
            }
            else
            {
                excludedProjects.Add(new Project()
                {
                    Name = noExcludedProjects
                });
            }

            RefreshLists();
        }

        public BindingList<Project> GetNewProjectList()
        {
            return allowedProjects;
        }

        private void RefreshLists()
        {
            allowedSource.DataSource = allowedProjects.OrderBy(x => x.Name);
            listAllProjects.DataSource = allowedSource;
            listAllProjects.DisplayMember = "Name";
            listAllProjects.SelectedIndex = -1;

            excludedSource.DataSource = excludedProjects.OrderBy(x => x.Name);
            listExcluded.DataSource = excludedSource;
            listExcluded.DisplayMember = "Name";
            listExcluded.SelectedIndex = -1;
        }

        private void BtnExclude_Click(object sender, EventArgs e)
        {
            var selected = listAllProjects.SelectedItem as Project;

            if(excludedProjects.Where(x=>x.Name == noExcludedProjects).Any())
            {
                excludedProjects = new BindingList<Project>();
            }

            allowedProjects.Remove(selected);
            excludedProjects.Add(selected);

            RefreshLists();
        }

        private void BtnInclude_Click(object sender, EventArgs e)
        {
            var selected = listExcluded.SelectedItem as Project;

            excludedProjects.Remove(selected);
            allowedProjects.Add(selected);

            if(excludedProjects.Count == 0)
            {
                excludedProjects.Add(new Project()
                {
                    Name = noExcludedProjects
                });
            }

            RefreshLists();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Settings.ExcludedProjects = new List<Project>(excludedProjects);
            this.Close();
        }
    }
}
