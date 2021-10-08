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

        #region Event Handler Implementation
        private void FormMain_SelectedProjectChanged(object sender, SelectedProjectChangedEventArgs e)
        {
            // Update the displayed info
            if (e.Project == null || e.Project.Name == "No Projects Found") { return; }
            SelectedProject = e.Project;
            lblProjectName.Text = e.Project.Name;
            lblProjectLocation.Text = e.Project.RootDirectory;
            lblLastUpdatedValue.Text = GetLastUpdatedTime(e.Project.RootDirectory);
            GitEnabled = e.Project.EnableGitLog;
            isTimerPaused = false;
            btnNotes.Tag = e.Project.NotesPath;
            e.Project.CreateDirectoriesIfNeeded();
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

        private readonly BindingSource bindingSourceProjects = new BindingSource();
        private bool GitEnabled;
        private bool isTimerPaused;
        private Stopwatch projectStopwatch;
        public static string baseFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"Crider Technologies/Manager");
        public static string versionFilePath = System.IO.Path.Join(FormMain.baseFilePath, "vd.txt");

        public FormMain()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ValidateSettings();
            InitializeMenuStripClickMethods();

            // Initialize some stuff so we don't have nulls
            ProjectList = new BindingList<Project>();
            projectStopwatch = new Stopwatch();

            SelectedProjectChanged += FormMain_SelectedProjectChanged;
            ProjectListChanged += FormMain_ProjectListChanged;

            // Load Configs
            LoadUserConfig();
            LoadLauncherConfig();

            // Set the initial Project to display
            // if there is one
            if(ProjectList.Count > 0)
            {
                SelectedProject = listboxProjects.SelectedItem as Project;
                OnSelectedProjectChanged(new SelectedProjectChangedEventArgs(SelectedProject));
            }
        }

        #region Save & Load
        private void UpdateUI()
        {
            if(SelectedProject == null) { return; }

            #region Git History
            if (GitEnabled)
            {
                if (Launcher.ProgramIsInstalled("Git"))
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
                    MessageBox.Show("Git does not appear to be installed. Please install it and try again.");
                    GitEnabled = false;
                    UpdateUI();
                }
            }
            else
            {
                btnGitChangeBranch.Visible = btnGitRefresh.Visible = txtGitHistory.Visible = lblGitBranch.Visible = lblGitBranchValue.Visible = false;
            }
            #endregion

            #region Time log
            if (SelectedProject.EnableTimekeeping)
            {
                grpTime.Visible = true;
                var configFile = SelectedProject.TimeLogFileName;
                if (File.Exists(Path.Combine(TimeLog.basePath, configFile)))
                {
                    TimeLog.LoadLogs(configFile);
                    LastTimeLog = TimeLog.GetLastLog();
                    txtTotalTime.Text = TimeLog.GetFormattedTotalProjectTime();
                }
                else
                {
                    File.Create(configFile).Dispose();
                    TimeLog.InitializeEmptyLogList();
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
            // VSCode and Visual Studio have their registry keys in different locations
            // and formatted differently, so they get unique methods
            btnAndroidStudio.Visible = Launcher.ProgramIsInstalled("Android Studio");
            btnUnity.Visible = Launcher.ProgramIsInstalled("Unity");
            btnVSCode.Visible = Launcher.VSCodeIsInstalled();
            btnVSCommunity.Visible = Launcher.VisualStudioIsInstalled();

            if (SelectedProject.DefaultLauncher != null)
            {
                if (SelectedProject.DefaultLauncher.Value == Launcher.None.Value)
                {
                    btnAndroidStudio.Enabled = false;
                    btnVSCode.Enabled = false;
                    btnVSCommunity.Enabled = false;
                    btnUnity.Enabled = false;
                }
                else if (SelectedProject.DefaultLauncher.Value == Launcher.AndroidStudio.Value)
                {
                    btnAndroidStudio.Enabled = true;
                    btnVSCode.Enabled = false;
                    btnVSCommunity.Enabled = false;
                    btnUnity.Enabled = false;
                }
                else if (SelectedProject.DefaultLauncher.Value == Launcher.VisualStudioCode.Value)
                {
                    btnAndroidStudio.Enabled = false;
                    btnVSCode.Enabled = true;
                    btnVSCommunity.Enabled = false;
                    btnUnity.Enabled = false;
                }
                else if (SelectedProject.DefaultLauncher.Value == Launcher.VisualStudioCommunity.Value)
                {
                    btnAndroidStudio.Enabled = false;
                    btnVSCode.Enabled = false;
                    btnVSCommunity.Enabled = true;
                    btnUnity.Enabled = false;
                }
                else if (SelectedProject.DefaultLauncher.Value == Launcher.Unity.Value)
                {
                    btnAndroidStudio.Enabled = false;
                    btnVSCode.Enabled = false;
                    btnVSCommunity.Enabled = false;
                    btnUnity.Enabled = true;
                }
            }
            else
            {
                SelectedProject.DefaultLauncher = Launcher.None;
                btnAndroidStudio.Enabled = false;
                btnVSCode.Enabled = false;
                btnVSCommunity.Enabled = false;
                btnUnity.Enabled = false;
            }
            #endregion
        }

        #region Load
        private void LoadLauncherConfig()
        {
            LoadDefaultLocations();
            ValidateDefaultLocations();

            Settings.AndroidStudioExecutableLocation = Settings.AndroidStudioExecutableLocation == "" ? Properties.Settings.Default.AndroidStudioPath : Settings.AndroidStudioExecutableLocation;
            Settings.VSCodeExecutableLocation = Settings.VSCodeExecutableLocation == "" ? Properties.Settings.Default.VSCodePath : Settings.VSCodeExecutableLocation;
            Settings.VSCommunityExecutableLocation = Settings.VSCommunityExecutableLocation == "" ? Properties.Settings.Default.VisualStudioPath : Settings.VSCommunityExecutableLocation;
            Settings.UnityExecutableLocation = Settings.UnityExecutableLocation == "" ? Properties.Settings.Default.UnityPath : Settings.UnityExecutableLocation;

            string output = "Please set the path to the following Editors before using them:\n\n";

            output += Settings.AndroidStudioExecutableLocation == "" ? "Android Studio\n" : "";
            output += Settings.VSCodeExecutableLocation == "" ? "Visual Studio Code\n" : "";
            output += Settings.VSCommunityExecutableLocation == "" ? "Visual Studio Community\n" : "";
            output += Settings.UnityExecutableLocation == "" ? "Unity\n" : "";

            if(output != "Please set the path to the following Editors before using them:\n\n")
            {
                MessageBox.Show(output, "Default Paths Not Set", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadDefaultLocations()
        {
            Properties.Settings.Default.AndroidStudioPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Android\\Android Studio\\studio64.exe");
            Properties.Settings.Default.VSCodePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs\\Microsoft VS Code\\Code.exe");
            Properties.Settings.Default.VisualStudioPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Microsoft Visual Studio\\2019\\Community\\devenv.exe");
            Properties.Settings.Default.UnityPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Unity\\Editor\\Unity.exe");

            Properties.Settings.Default.Save();
        }

        private void ValidateDefaultLocations()
        {
            Properties.Settings.Default.AndroidStudioPath = File.Exists(Properties.Settings.Default.AndroidStudioPath) ? Properties.Settings.Default.AndroidStudioPath : "";
            Properties.Settings.Default.VSCodePath = File.Exists(Properties.Settings.Default.VSCodePath) ? Properties.Settings.Default.VSCodePath : "";
            Properties.Settings.Default.VisualStudioPath = File.Exists(Properties.Settings.Default.VisualStudioPath) ? Properties.Settings.Default.VisualStudioPath : "";
            Properties.Settings.Default.UnityPath = File.Exists(Properties.Settings.Default.UnityPath) ? Properties.Settings.Default.UnityPath : "";

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
                MessageBox.Show(ex.ToString());
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

            // Load any new projects that have been added to the Master Root Path
            // if the user has configured it
            if (!string.IsNullOrEmpty(Settings.MasterRootPath))
            {
                var projectsInRoot = AddProjects(Settings.MasterRootPath);

                foreach(Project p in projectsInRoot)
                {
                    if (ProjectList.Contains(p)) { continue; }
                    retval.Add(p);
                }
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
        }
        #endregion

        private void ResetLoadedProjects()
        {
            if(ProjectList == null || ProjectList.Count == 0)
            {
                ProjectList = new BindingList<Project>();
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
                CreateErrorLog(errorLogPath, ex.ToString());
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
                MessageBox.Show("Failed to save projects. Please try again later.\n\n" + ex.ToString());
            }
        }

        public BindingList<Project> AddProjects(string path)
        {
            BindingList<Project> retVal = new BindingList<Project>();

            var directories = System.IO.Directory.GetDirectories(path);

            foreach (var folder in directories)
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
            new FormVersionCheck().ShowDialog();
        }

        private void ToolStripMenuItemVersion_Click(object sender, EventArgs e)
        {
            new FormVersionDetails().ShowDialog();
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
            System.Windows.Forms.Application.Exit();
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
                    LastSessionId = LastTimeLog == null ? -1 : LastTimeLog.SessionId
                };

                txtCurrentStart.Text = CurrentTimeLog.StartTime.ToString(Settings.GetDateTimeFormat());
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

            CurrentTimeLog.EndTime = DateTime.Now;
            CurrentTimeLog.ElapsedTime = CurrentTimeLog.EndTime.Subtract(CurrentTimeLog.StartTime);
            LastTimeLog = CurrentTimeLog;

            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;

            TimeLog.Update(SelectedProject.TimeLogFileName, LastTimeLog);

            txtTotalTime.Text = TimeLog.GetFormattedTotalProjectTime();
            txtCurrentStart.Text = string.Empty;
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

            LaunchProject(ErrorMessages.FaildLaunchFileEplorer, startInfo: psInfo);
        }

        private void BtnVSCode_Click(object sender, EventArgs e)
        {
            var args = SelectedProject.RootDirectory;
            var fileName = Settings.VSCodeExecutableLocation;

            ProcessStartInfo psInfo = new ProcessStartInfo()
            {
                Arguments = args,
                FileName = fileName
            };

            LaunchProject(ErrorMessages.FailedLaunchVSCode, startInfo: psInfo);
        }

        private void BtnVSCommunity_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo()
            {
                Arguments = "/edit " + SelectedProject.MainProjectFile,
                FileName = Settings.VSCommunityExecutableLocation
            };

            LaunchProject(ErrorMessages.FaildLaunchVisualStudio, startInfo: psInfo);
        }

        private void BtnAndroidStudio_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo()
            {
                FileName = Settings.AndroidStudioExecutableLocation
            };

            LaunchProject(ErrorMessages.FaildLaunchAndroidStudio, startInfo: psInfo);
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
                CreateErrorLog(errorLogPath, ex.ToString());
                MessageBox.Show(failMessage + "\n\nError Log: " + errorLogPath, "Error launching project", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            List<string> output = new List<string>();

            try
            {
                Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();

                string lineVal = process.StandardOutput.ReadLine();

                while (lineVal != null)
                {

                    output.Add(lineVal);
                    lineVal = process.StandardOutput.ReadLine();

                }

                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

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

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Remove this each time we close the form
            // so we can always get the latest version
            File.Delete(FormMain.versionFilePath);
        }
    }

    #region Custom EventArgs
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
    #endregion
}
