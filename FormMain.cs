using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public TimeLog CurrentTimeLog;
        public TimeLog LastTimeLog;
        public UserSettings Settings;

        #region Event Handlers
        public event EventHandler<SelectedProjectChangedEventArgs> SelectedProjectChanged;
        protected virtual void OnSelectedProjectChanged(SelectedProjectChangedEventArgs e)
        {
            EventHandler<SelectedProjectChangedEventArgs> handler = SelectedProjectChanged;
            handler?.Invoke(this, e);
        }

        public event EventHandler<ProjectListChangedEventArgs> ProjectListChanged;
        protected virtual void OnProjectListChanged(ProjectListChangedEventArgs e)
        {
            EventHandler<ProjectListChangedEventArgs> handler = ProjectListChanged;
            handler?.Invoke(this, e);
        }
        #endregion

        private readonly BindingSource bindingSourceProjects = new BindingSource();
        private bool GitEnabled;
        private bool isTimerPaused;
        private Stopwatch projectStopwatch;
        private string baseFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"Project Manager");

        public FormMain()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ValidateSettings();
            InitializeMenuStripClickMethods();
            ProjectList = new BindingList<Project>();
            projectStopwatch = new Stopwatch();

            SelectedProjectChanged += FormMain_SelectedProjectChanged;
            ProjectListChanged += FormMain_ProjectListChanged;

            LoadUserConfig();
            LoadLauncherConfig();

            if(ProjectList.Count > 0)
            {
                SelectedProject = listboxProjects.SelectedItem as Project;
                OnSelectedProjectChanged(new SelectedProjectChangedEventArgs(SelectedProject));
            }
        }

        #region Event Handler Implementation
        private void FormMain_SelectedProjectChanged(object sender, SelectedProjectChangedEventArgs e)
        {
            // Update the displayed info
            if (e.Project == null) { return; }
            SelectedProject = e.Project;
            lblProjectName.Text = e.Project.Name;
            lblProjectLocation.Text = e.Project.RootDirectory;
            lblLastUpdatedValue.Text = GetLastUpdatedTime(e.Project.RootDirectory);
            GitEnabled = e.Project.EnableGitLog;
            isTimerPaused = false;
            btnNotes.Tag = new string[] {e.Project.NotesPath, e.Project.NotesDirectory};
            UpdateUI();
        }

        private void FormMain_ProjectListChanged(object sender, ProjectListChangedEventArgs e)
        {
            ProjectList = e.NewList;
            ResetLoadedProjects();
        }

        private void ListboxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSelectedProjectChanged(new SelectedProjectChangedEventArgs(listboxProjects.SelectedItem as Project));
        }
        #endregion

        #region Save & Load
        private void UpdateUI()
        {
            #region Git History
            if (GitEnabled)
            {
                btnGitChangeBranch.Visible = btnGitRefresh.Visible = txtGitHistory.Visible = lblGitBranch.Visible = lblGitBranchValue.Visible = true;
                btnGitRefresh.PerformClick();

                var branches = GetGitResponse("branch");

                foreach (var line in branches)
                {
                    if (line[0] == '*')
                    {
                        lblGitBranchValue.Text = line.Substring(2);
                        break;
                    }
                }
            }
            else
            {
                btnGitChangeBranch.Visible = btnGitRefresh.Visible = txtGitHistory.Visible = lblGitBranch.Visible = lblGitBranchValue.Visible = false;
            }
            #endregion

            #region Time log
            if (SelectedProject != null && SelectedProject.EnableTimekeeping)
            {
                grpTime.Enabled = true;
                var configFile = SelectedProject.TimeLogPath;
                if (File.Exists(configFile))
                {
                    using StreamReader r2 = File.OpenText(configFile);
                    string json2 = r2.ReadToEnd();
                    CurrentTimeLog = JsonConvert.DeserializeObject<TimeLog>(json2);

                    if(CurrentTimeLog != null)
                    {
                        LastTimeLog = CurrentTimeLog.LastSession;
                        txtTotalTime.Text = GetTotalProjectTime(CurrentTimeLog);
                    }

                    r2.Dispose();
                }
                else
                {
                    File.Create(configFile).Dispose();
                }
            }
            else
            {
                grpTime.Visible = false;
            }
            #endregion

            #region Project Details
            if(ProjectList.Count == 1 && SelectedProject.Name == "No Projects Found")
            {
                lblLastUpdated.Text = "Set a default project directory, or add individual projects under Settings -> Configure.";
                lblLastUpdatedValue.Visible = false;
            }
            else
            {
                lblLastUpdated.Text = "Last Updated:";
                lblLastUpdatedValue.Visible = true;
            }
            #endregion

            #region Open With
            if(SelectedProject.DefaultLauncher.Value == Launcher.None.Value)
            {
                btnAndroidStudio.Enabled = false;
                btnVSCode.Enabled = false;
                btnVSCommunity.Enabled = false;
            }
            else if(SelectedProject.DefaultLauncher.Value == Launcher.AndroidStudio.Value)
            {
                btnAndroidStudio.Enabled = true;
                btnVSCode.Enabled = false;
                btnVSCommunity.Enabled = false;
            }
            else if(SelectedProject.DefaultLauncher.Value == Launcher.VisualStudioCode.Value)
            {
                    btnAndroidStudio.Enabled = false;
                    btnVSCode.Enabled = true;
                    btnVSCommunity.Enabled = false;
            }
            else if(SelectedProject.DefaultLauncher.Value == Launcher.VisualStudioCommunity.Value)
            {
                btnAndroidStudio.Enabled = false;
                btnVSCode.Enabled = false;
                btnVSCommunity.Enabled = true;
            }
            else
            {
                SelectedProject.DefaultLauncher = Launcher.None;
                btnAndroidStudio.Enabled = false;
                btnVSCode.Enabled = false;
                btnVSCommunity.Enabled = false;
            }
            #endregion
        }

        #region Load
        private void LoadLauncherConfig()
        {
            LoadDefaultLocations();

            Settings.AndroidStudioExecutableLocation = Settings.AndroidStudioExecutableLocation == "" ? Properties.Settings.Default.AndroidStudioPath : Settings.AndroidStudioExecutableLocation;
            Settings.VSCodeExecutableLocation = Settings.VSCodeExecutableLocation == "" ? Properties.Settings.Default.VSCodePath : Settings.VSCodeExecutableLocation;
            Settings.VSCommunityExecutableLocation = Settings.VSCommunityExecutableLocation == "" ? Properties.Settings.Default.VisualStudioPath : Settings.VSCommunityExecutableLocation;
            Settings.UnityExecutableLocation = Settings.UnityExecutableLocation == "" ? Properties.Settings.Default.UnityPath : Settings.UnityExecutableLocation;
        }

        private void LoadDefaultLocations()
        {
            Properties.Settings.Default.AndroidStudioPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Android\\Android Studio\\studio64.exe");
            Properties.Settings.Default.VSCodePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Program\\Microsoft VS Code\\Code.exe");
            Properties.Settings.Default.VisualStudioPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Microsoft Visual Studio\\2019\\Community\\devenv.exe");
            Properties.Settings.Default.UnityPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Unity\\Editor\\Unity.exe");

            Properties.Settings.Default.Save();
        }

        private void LoadUserConfig()
        {
            try
            {
                // Load Settings
                LoadGlobalSettings();

                // Individual Projects
                ProjectList = LoadProjects();

                ResetLoadedProjects();
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private BindingList<Project> LoadProjects()
        {
            BindingList<Project> retval = new BindingList<Project>();
            var configFile = Path.Combine(baseFilePath, "projects.json");
            if (File.Exists(configFile))
            {
                retval = JsonConvert.DeserializeObject<BindingList<Project>>(File.ReadAllText(configFile));
            }
            else
            {
                File.Create(configFile).Dispose();
            }

            return retval;
        }

        private void LoadGlobalSettings()
        {
            var configFile = Path.Join(baseFilePath, "settings.json");
            if (File.Exists(configFile))
            {
                using (StreamReader r2 = new StreamReader(File.OpenRead(configFile)))
                {
                    string json2 = r2.ReadToEnd();
                    Settings = JsonConvert.DeserializeObject<UserSettings>(json2);
                }

                if (Settings == null)
                {
                    Settings = new UserSettings();
                }
            }
            else
            {
                Settings = new UserSettings();
            }

            if (!string.IsNullOrEmpty(Settings.MasterRootPath) && !string.IsNullOrWhiteSpace(Settings.MasterRootPath))
            {
                ProjectList = AddProjects(Settings.MasterRootPath);
            }
            else
            {
                ProjectList = new BindingList<Project>();
            }
        }
        #endregion

        private void ResetLoadedProjects()
        {
            if(ProjectList.Count == 0)
            {
                ProjectList.Add(new Project()
                {
                    Name = "No Projects Found",
                    EnableTimekeeping = false,
                    EnableGitLog = false
                });
            }

            foreach (Project proj in Settings.ExcludedProjects)
            {
                ProjectList.Remove(proj);
            }

            var tempList = new BindingList<Project>(ProjectList.Distinct().ToList());
            ProjectList = tempList;

            bindingSourceProjects.DataSource = ProjectList.OrderBy(x => x.Name);
            listboxProjects.DataSource = bindingSourceProjects;
            listboxProjects.DisplayMember = "Name";

            UpdateUI();
        }

        private void SaveGlobalSettings(bool notifyOnFailure=true)
        {
            try
            {
                var configFile = Path.Combine(baseFilePath, "settings.json");

                if (!File.Exists(configFile))
                {
                    File.Create(configFile).Dispose();
                }

                string jsonOut = Newtonsoft.Json.JsonConvert.SerializeObject(Settings);
                File.WriteAllText(configFile, jsonOut);
            }
            catch(Exception ex)
            {
                if (notifyOnFailure)
                {
                    MessageBox.Show("Failed to save settings. Please try again later.");
                }
                string errorLogPath = Path.Combine(baseFilePath, $"ErrorLog_{DateTime.Now:yyyyMMdd_HHmmss}.txt");
                CreateErrorLog(errorLogPath, ex.Message);
            }
        }

        private void SaveProjectList()
        {
            try
            {
                var configFile = Path.Combine(baseFilePath, "projects.json");

                if (!File.Exists(configFile))
                {
                    File.Create(configFile).Dispose();
                }

                string jsonOut = Newtonsoft.Json.JsonConvert.SerializeObject(ProjectList);
                File.WriteAllText(configFile, jsonOut);

                ResetLoadedProjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save projects. Please try again later.\n\n" + ex.Message);
            }
        }

        private void UpdateTimeLogFile()
        {
            try
            {
                var configFile = SelectedProject.TimeLogPath;

                if (!File.Exists(configFile))
                {
                    File.Create(configFile).Dispose();
                }

                string jsonOut = Newtonsoft.Json.JsonConvert.SerializeObject(CurrentTimeLog);
                File.WriteAllText(configFile, jsonOut);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save time log.\n\n" + ex.Message);
            }
        }

        private string GetTotalProjectTime(TimeLog log)
        {
            int totalSeconds = 0;
            do
            {
                if (log.StartTime == DateTime.Parse("0001-01-01") || log.EndTime == DateTime.Parse("0001-01-01")) { break; }
                totalSeconds += TimeLog.TimeInSeconds(log.StartTime, log.EndTime);
                log = log.LastSession;
            }
            while (log != null);

            return TimeLog.FormattedTime(totalSeconds);
        }

        public BindingList<Project> AddProjects(string path)
        {
            BindingList<Project> retVal = new BindingList<Project>();

            foreach(var folder in System.IO.Directory.GetDirectories(path))
            {
                Project temp = new Project()
                {
                    Name = new DirectoryInfo(folder).Name,
                    RootDirectory = folder
                };

                // Don't include the project if it's been explicitly excluded
                if(Settings.ExcludedProjects.Where(x=>x.RootDirectory == temp.RootDirectory).Any())
                {
                    continue;
                }

                retVal.Add(temp);
            }

            return retVal;
        }

        public BindingList<Project> GetProjectsInDirectory(string path)
        {
            BindingList<Project> retVal = new BindingList<Project>();

            var results = System.IO.Directory.GetDirectories(path);
            foreach (var folder in results)
            {
                Project temp = new Project()
                {
                    Name = new DirectoryInfo(folder).Name,
                    RootDirectory = folder
                };

                retVal.Add(temp);
            }

            return retVal;
        }
        #endregion

        #region MenuStrip
        private void InitializeMenuStripClickMethods()
        {
            toolStripMenuItemExit.Click += ToolStripMenuItemExit_Click;
            toolStripMenuItemConfigure.Click += ToolStripMenuItemConfigure_Click;
            toolStripMenuItemVersion.Click += ToolStripMenuItemVersion_Click;
            toolStripMenuItemUpdates.Click += ToolStripMenuItemUpdates_Click;
            toolStripMenuItemExclude.Click += ToolStripMenuItemExclude_Click;
            toolStripMenuItemLaunchers.Click += ToolStripMenuItemLaunchers_Click;
        }

        private void ToolStripMenuItemLaunchers_Click(object sender, EventArgs e)
        {
            FormLaunchers formLaunchers = new FormLaunchers(Settings);
            
            if(formLaunchers.ShowDialog() == DialogResult.OK)
            {
                SaveGlobalSettings();
            }
        }

        private void ToolStripMenuItemExclude_Click(object sender, EventArgs e)
        {
            FormExcludeProjects formExclude = new FormExcludeProjects()
            {
                Settings = this.Settings,
                _Parent = this
            };

            formExclude.ShowDialog();

            if(formExclude.DialogResult == DialogResult.OK)
            {
                OnProjectListChanged(new ProjectListChangedEventArgs(formExclude.GetNewProjectList()));
                SaveProjectList();
                SaveGlobalSettings();
            }
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
            FormSettings formSettings = new FormSettings(this, Settings);
            formSettings.ShowDialog();

            if(formSettings.DialogResult == DialogResult.Yes)
            {
                OnProjectListChanged(new ProjectListChangedEventArgs(formSettings.ProjectList));
                OnSelectedProjectChanged(new SelectedProjectChangedEventArgs(SelectedProject));
                SaveProjectList();
                SaveGlobalSettings();
            }

        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region *_Click Methods
        #region Git
        private void BtnGitRefresh_Click(object sender, EventArgs e)
        {
            var response = GetGitResponse($"log --oneline -{SelectedProject.GitLogHistory}");

            txtGitHistory.Text = string.Empty;
            foreach (var line in response)
            {
                txtGitHistory.Text += line + Environment.NewLine;
            }
        }

        private void BtnGitChangeBranch_Click(object sender, EventArgs e)
        {
            FormChangeGitBranch formChangeBranch = new FormChangeGitBranch()
            {
                SelectedProject = this.SelectedProject,
                _Parent = this
            };

            formChangeBranch.ShowDialog();

            if(formChangeBranch.DialogResult == DialogResult.OK)
            {
                GetGitResponse($"checkout {SelectedProject.GitCurrentBranch}");
                UpdateUI();
            }
        }
        #endregion

        #region Timer
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (isTimerPaused)
            {
                isTimerPaused = false;
            }
            else
            {
                CurrentTimeLog = new TimeLog()
                {
                    StartTime = DateTime.Now,
                    LastSession = LastTimeLog
                };

                txtCurrentStart.Text = string.Format(Settings.GetDateTimeFormat(), CurrentTimeLog.StartTime);
            }

            projectStopwatch.Start();
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            isTimerPaused = true;
            projectStopwatch.Stop();
            CurrentTimeLog.ElapsedTime += projectStopwatch.Elapsed;

            btnPause.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            isTimerPaused = false;
            projectStopwatch.Stop();
            CurrentTimeLog.ElapsedTime += projectStopwatch.Elapsed;

            CurrentTimeLog.EndTime = CurrentTimeLog.StartTime.Add(CurrentTimeLog.ElapsedTime);
            LastTimeLog = CurrentTimeLog;

            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;

            UpdateTimeLogFile();
        }

        #endregion

        #region Launchers
        private void BtnFileExplorer_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo()
            {
                Arguments = SelectedProject.RootDirectory,
                FileName = "explorer.exe"
            };

            LaunchProject("Failed to open Project directory. Verify the folder at the bottom of the screen exists.", startInfo: psInfo);
        }

        private void BtnVSCode_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo()
            {
                Arguments = SelectedProject.MainProjectFile,
                FileName = Settings.VSCodeExecutableLocation
            };

            LaunchProject("Failed to open Project in VSCode. Check the Error Log for more details.", startInfo: psInfo);
        }

        private void BtnVSCommunity_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo()
            {
                Arguments = "/edit " + SelectedProject.MainProjectFile,
                FileName = Settings.VSCommunityExecutableLocation
            };

            LaunchProject("Failed to open Project in Visual Studio Community. Verify the installation path in Settings -> Launchers.", startInfo: psInfo);
        }

        private void BtnAndroidStudio_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo()
            {
                FileName = Settings.AndroidStudioExecutableLocation
            };

            LaunchProject("Failed to open Project directory. Verify the folder at the bottom of the screen exists.", startInfo: psInfo);
        }
        #endregion

        #region Notes
        private void BtnNotes_Click(object sender, EventArgs e)
        {
            string[] notes = ((Button)sender).Tag as string[];
            FormNotes formNotes = new FormNotes(notes[0], notes[1]);
            formNotes.ShowDialog();
        }
        #endregion
        #endregion

        private void LaunchProject(string failMessage, string fileName = "", ProcessStartInfo startInfo = null)
        {
            try
            {
                if (Directory.Exists(SelectedProject.RootDirectory))
                {
                    if (fileName != "")
                    {
                        Process.Start(fileName);
                    }
                    else if (startInfo != null)
                    {
                        Process.Start(startInfo);
                    }
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            catch (Exception ex)
            {
                string errorLogPath = Path.Combine(baseFilePath, $"ErrorLog_{DateTime.Now:yyyyMMdd_HHmmss}.txt");
                CreateErrorLog(errorLogPath, ex.Message);
                MessageBox.Show(failMessage + "\n\nError Log: " + errorLogPath);
            }
        }

        private string GetLastUpdatedTime(string root)
        {
            var file = new DirectoryInfo(root).EnumerateFiles().OrderByDescending(f => f.LastWriteTime).FirstOrDefault();
            if(file == null) { return "UNKNOWN"; }
            return file.LastWriteTime.ToString(Settings.GetDateTimeFormat());
        }

        public List<string> GetGitResponse(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("git.exe");

            startInfo.UseShellExecute = false;
            startInfo.WorkingDirectory = SelectedProject.RootDirectory;
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.Arguments = command;

            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();

            List<string> output = new List<string>();
            string lineVal = process.StandardOutput.ReadLine();

            while (lineVal != null)
            {

                output.Add(lineVal);
                lineVal = process.StandardOutput.ReadLine();

            }

            process.WaitForExit();

            return output;
        }

        private void ValidateSettings()
        {
            if (Directory.Exists(baseFilePath) == false)
            {
                Directory.CreateDirectory(baseFilePath);
                Settings = new UserSettings();
                SaveGlobalSettings(false);
            }
            else
            {
                if(File.Exists(Path.Combine(baseFilePath, "settings.json")))
                {
                    return;
                }
                else
                {
                    Settings = new UserSettings();
                    SaveGlobalSettings(false);
                }
            }
        }

        private void CreateErrorLog(string fullPath, string content)
        {
            File.WriteAllText(fullPath, content);
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

    public class ProjectListChangedEventArgs : EventArgs
    {
        public BindingList<Project> NewList { get; set; }

        public ProjectListChangedEventArgs(BindingList<Project> newList)
        {
            NewList = newList;
        }
    }
}
