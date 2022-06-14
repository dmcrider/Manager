using System.Diagnostics;
using System.Globalization;

namespace Manager
{
    public partial class FormMain : Form
    {
        private Project _selectedProject;

        public FormMain()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public void FormMain_Load(object sender, EventArgs e)
        {
            PopulateProfilesDropdown();
        }

        private void PopulateProfilesDropdown()
        {
            var index = 0;
            foreach(var profile in ProfileHandler.Instance.Profiles)
            {
                var newIndex = dropdownProfile.Items.Add(profile);
                if(profile.ProfileName == SettingsHandler.Instance.Settings.LastUsedProfile)
                {
                    SettingsHandler.Instance.Settings.LastUsedProfile = profile.ProfileName;
                    index = newIndex;
                }
            }

            dropdownProfile.SelectedIndex = index;
            PopulateProjectList(dropdownProfile.SelectedItem.ToString()!);
        }

        private void PopulateProjectList(string profileName)
        {
            listboxProjects.Items.Clear();
            var projList = ProfileHandler.Instance.Profiles.Where(x => x.ProfileName == profileName).First().ProjectList;

            if (projList.Any())
            {
                listboxProjects.Items.AddRange(projList.ToArray());
            }
            else
            {
                listboxProjects.Items.Add("No Projects Found");
            }

            listboxProjects.SelectedIndex = 0;
        }

        private void ListboxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxProjects.SelectedItem.ToString() == "No Projects Found") { return; }

            _selectedProject = ProfileHandler.Instance.GetProjectByName(SettingsHandler.Instance.Settings.LastUsedProfile, listboxProjects.SelectedItem.ToString());
            PopulateProjectDetails(_selectedProject);
        }

        private void DropdownProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsHandler.Instance.Settings.LastUsedProfile = dropdownProfile.SelectedItem.ToString();
            PopulateProjectList(SettingsHandler.Instance.Settings.LastUsedProfile);
        }

        private void PopulateProjectDetails(Project p)
        {
            lblProjectName.Text = p.Name;
            btnNotes.Tag = p.Name;
            btnOpen.Tag = p.RootDirectory;
            LoadGitHistory(p.RootDirectory, p.GitLogHistory);
        }

        private void LoadGitHistory(string dir, int gitHistory)
        {
            // Current git branch
            var branch = GitHandler.GetGitResponse("branch", dir);
            foreach(var line in branch)
            {
                if (line[0] == '*')
                {
                    lblGitBranchName.Text = line.Substring(2);
                    break;
                }
            }

            // Git history
            var command = $"log --oneline -{gitHistory}";
            var commits = GitHandler.GetGitResponse(command, dir);
            txtGitHistory.Text = "";
            foreach(var line in commits)
            {
                txtGitHistory.Text += line + Environment.NewLine;
            }

            // Last commit timestamp
            var timestampString = GitHandler.GetGitResponse("log -1 --format=%cd", dir);
            lblLastCommitValue.Text = "";
            if (timestampString.Any())
            {
                var dateTime = DateTimeOffset.ParseExact(timestampString[0], "ddd MMM d HH:mm:ss yyyy K", CultureInfo.InvariantCulture, DateTimeStyles.None);
                lblLastCommitValue.Text = SettingsHandler.Instance.Settings.FormatTimeStamp(dateTime.DateTime);
            }
            else
            {
                lblLastCommitValue.Text = "UNKNOWN";
            }
        }

        #region ToolStrip Menu Items
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAddNewProject = new FormAddProject();
            var result = formAddNewProject.ShowDialog();

            if(result == DialogResult.OK)
            {
                var profile = ProfileHandler.Instance.Profiles.Where(x => x.ProfileName == SettingsHandler.Instance.Settings.LastUsedProfile).First();
                ProfileHandler.Instance.CreateProject(profile, formAddNewProject.Project);
                PopulateProjectList(profile.ProfileName);
            }
        }

        private void ManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formManageProjects = new FormManageProjects(SettingsHandler.Instance.Settings.LastUsedProfile);
            var results = formManageProjects.ShowDialog();

            if(results == DialogResult.OK)
            {
                PopulateProjectList(SettingsHandler.Instance.Settings.LastUsedProfile);
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSettings = new FormSettings();
            
            if(formSettings.ShowDialog() == DialogResult.OK)
            {
                SettingsHandler.Instance.UpdateSettings(formSettings.UpdatedSettings);
                // Update the DateTime displays if the settings changed
                PopulateProjectDetails(_selectedProject);
            }
        }
        #endregion

        #region Buttons
        private void BtnNotes_Click(object sender, EventArgs e)
        {
            var profile = ProfileHandler.Instance.Profiles.Where(x => x.ProfileName == SettingsHandler.Instance.Settings.LastUsedProfile).First();
            var project = profile.ProjectList.Where(x => x.Name == btnNotes.Tag.ToString()).First();
            ProfileHandler.Instance.VerifyNotesPathExists(profile, project);

            var processInfo = new ProcessStartInfo()
            {
                Arguments = $"\"{project.NotesPath}\"",
                FileName = SettingsHandler.Instance.Settings.PreferredTextEditorPath
            };

            Process.Start(processInfo);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            var processInfo = new ProcessStartInfo()
            {
                Arguments = btnOpen.Tag.ToString(),
                FileName = "explorer.exe"
            };

            Process.Start(processInfo);
        }
        #endregion
    }
}