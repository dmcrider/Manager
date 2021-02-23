using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Manager
{
    public partial class FormMain : Form
    {
        public BindingList<Project> ProjectList;
        public Project SelectedProject;

        public event EventHandler<SelectedProjectChangedEventArgs> SelectedProjectChanged;
        protected virtual void OnSelectedProjectChanged(SelectedProjectChangedEventArgs e)
        {
            EventHandler<SelectedProjectChangedEventArgs> handler = SelectedProjectChanged;
            handler?.Invoke(this, e);
        }

        private readonly BindingSource bindingSourceProjects = new BindingSource();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            InitializeMenuStripClickMethods();
            ProjectList = new BindingList<Project>();
            SelectedProjectChanged += FormMain_SelectedProjectChanged;

            LoadUserConfig();
            LoadLauncherConfig();

            if(ProjectList.Count > 0)
            {
                SelectedProject = listboxProjects.SelectedItem as Project;
                OnSelectedProjectChanged(new SelectedProjectChangedEventArgs(SelectedProject));
            }
        }

        private void LoadLauncherConfig()
        {
            var android = Properties.Settings.Default.AndroidStudioPath;
            var vscode = Properties.Settings.Default.VSCodePath;
            var studio = Properties.Settings.Default.VisualStudioPath;

            /*if(android == "-1" || vscode == "-1" || studio == "-1")
            {
                LoadDefaultLocations();
            }*/
            LoadDefaultLocations();
        }

        private void LoadDefaultLocations()
        {
            Properties.Settings.Default.AndroidStudioPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Android\\Android Studio\\studio64.exe");
            Properties.Settings.Default.VSCodePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Program\\Microsoft VS Code\\Code.exe");
            Properties.Settings.Default.VisualStudioPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Microsoft Visual Studio\\2019\\Community\\devenv.exe");

            Properties.Settings.Default.Save();
        }

        private void FormMain_SelectedProjectChanged(object sender, SelectedProjectChangedEventArgs e)
        {
            // Update the displayed info
            lblProjectName.Text = e.Project.Name;
            lblProjectLocation.Text = e.Project.RootDirectory;
        }

        private void LoadUserConfig()
        {
            try
            {
                var configFile = Path.Combine(Directory.GetCurrentDirectory(), "projects.json");

                using StreamReader r = File.OpenText(configFile);
                string json = r.ReadToEnd();
                ProjectList = JsonConvert.DeserializeObject<BindingList<Project>>(json);
                ResetLoadedProjects();
            }
            catch
            {
                ProjectList = new BindingList<Project>();
                MessageBox.Show("No projects.json file found. Please create one, or add projects manually.");
            }
        }

        private void ResetLoadedProjects()
        {
            bindingSourceProjects.DataSource = ProjectList;
            listboxProjects.DataSource = bindingSourceProjects;
            listboxProjects.DisplayMember = "Name";
        }

        #region MenuStrip
        private void InitializeMenuStripClickMethods()
        {
            toolStripMenuItemExit.Click += ToolStripMenuItemExit_Click;
            toolStripMenuItemConfigure.Click += ToolStripMenuItemConfigure_Click;
            toolStripMenuItemVersion.Click += ToolStripMenuItemVersion_Click;
            toolStripMenuItemUpdates.Click += ToolStripMenuItemUpdates_Click;
        }

        private void ToolStripMenuItemUpdates_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ToolStripMenuItemVersion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ToolStripMenuItemConfigure_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        private void ListboxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSelectedProjectChanged(new SelectedProjectChangedEventArgs(listboxProjects.SelectedItem as Project));
        }

        private void BtnOpenWith_Click(object sender, EventArgs e)
        {
            if(sender is Button btnSender)
            {
                switch (btnSender.Tag.ToString())
                {
                    case "android":
                        break;
                    case "vscode":
                        break;
                    case "visualstudio":
                        break;
                    default:
                        return;
                }
            }
        }
    }

    public class SelectedProjectChangedEventArgs : EventArgs
    {
        public Project Project { get; set; }

        public SelectedProjectChangedEventArgs(Project project)
        {
            Project = project;
        }
    }
}
