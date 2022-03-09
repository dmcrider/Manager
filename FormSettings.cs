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

namespace Manager
{
    public partial class FormSettings : Form
    {
        public BindingList<Project> ProjectList;
        public UserSettings Settings;
        private readonly BindingSource bindingSourceProjects = new BindingSource();
        private FormMain formMain;
        private Project selectedProject;

        public FormSettings(FormMain parent, UserSettings currentSettings)
        {
            InitializeComponent();
            CenterToParent();
            formMain = parent;
            Settings = currentSettings;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            selectedProject = formMain.SelectedProject;
            ProjectList = new BindingList<Project>();
            foreach(var item in formMain.ProjectList)
            {
                ProjectList.Add(item);
            }

            SetDatePattern();
            SetTimePattern();
            SetOpenWithValues();
            LoadProjects();

            listProjects.SelectedIndexChanged += ListProjects_SelectedIndexChanged;

            GetSelectedDateTimePattern();
            txtMasterRoot.Text = Settings.MasterRootPath;
            txtGitLogHistory.Value = selectedProject.GitLogHistory;
        }

        private void UpdateUI()
        {
            txtProjectName.Text = selectedProject.Name;
            txtProjectLocation.Text = selectedProject.RootDirectory;
            txtMainProjFile.Text = selectedProject.MainProjectFile;

            checkEnableGit.Checked = selectedProject.EnableGitLog;
            txtGitLogHistory.Value = selectedProject.GitLogHistory;
            chkEnableTimekeeping.Checked = selectedProject.EnableTimekeeping;

            SetOpenWithSelectedItem();
        }

        private void LoadProjects(Project selectedProj = null)
        {
            bindingSourceProjects.DataSource = ProjectList.OrderBy(x=>x.Name);
            listProjects.DataSource = bindingSourceProjects;
            listProjects.DisplayMember = "Name";

            if(selectedProj == null)
            {
                foreach (Project p in listProjects.Items)
                {
                    if (p.RootDirectory == selectedProject.RootDirectory)
                    {
                        selectedProj = p;
                    }
                }
            }

            listProjects.SelectedItem = selectedProj;
            UpdateUI();
        }

        private void SetDatePattern()
        {
            var today = DateTime.Now;

            listDatePattern.Items.Add(new DateTimePattern(today, "yyyy-MM-dd"));
            listDatePattern.Items.Add(new DateTimePattern(today, "yyyy-dd-MM"));
            listDatePattern.Items.Add(new DateTimePattern(today, "MM/dd/yyyy"));
            listDatePattern.Items.Add(new DateTimePattern(today, "dd/MM/yyyy"));

            foreach(var item in listDatePattern.Items)
            {
                if(((DateTimePattern)item).Format == Settings.DatePattern.Format)
                {
                    listDatePattern.SelectedItem = item;
                }
            }
        }

        private void SetTimePattern()
        {
            var today = DateTime.Now;

            listTimePattern.Items.Add(new DateTimePattern(today, "HH:mm:ss"));
            listTimePattern.Items.Add(new DateTimePattern(today, "H:m:s"));
            listTimePattern.Items.Add(new DateTimePattern(today, "hh:mm:ss tt"));
            listTimePattern.Items.Add(new DateTimePattern(today, "h:m:s t"));

            foreach (var item in listTimePattern.Items)
            {
                if (((DateTimePattern)item).Format == Settings.TimePattern.Format)
                {
                    listTimePattern.SelectedItem = item;
                }
            }
        }

        private void SetOpenWithValues()
        {
            listOpenWith.Items.AddRange(new Launcher[] { Launcher.None, Launcher.AndroidStudio, Launcher.VisualStudioCode, Launcher.VisualStudioCommunity });
            listOpenWith.DisplayMember = "Name";

            SetOpenWithSelectedItem();

            listOpenWith.SelectedIndexChanged += ListOpenWith_SelectedIndexChanged;
        }

        private void GetSelectedDateTimePattern()
        {
            var datePattern = ((DateTimePattern)listDatePattern.SelectedItem).Format;
            var timePattern = ((DateTimePattern)listTimePattern.SelectedItem).Format;

            Settings.DatePattern.Format = datePattern;
            Settings.TimePattern.Format = timePattern;
        }

        #region Button Click
        private void BtnSave_Click(object sender, EventArgs e)
        {
            GetSelectedDateTimePattern();
            selectedProject.Name = txtProjectName.Text;
            selectedProject.RootDirectory = txtProjectLocation.Text;
            selectedProject.EnableGitLog = checkEnableGit.Checked;
            selectedProject.GitLogHistory = (int)txtGitLogHistory.Value;
            selectedProject.MainProjectFile = txtMainProjFile.Text;
            Settings.MasterRootPath = txtMasterRoot.Text;
            selectedProject.DefaultLauncher = (Launcher)listOpenWith.SelectedItem;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGitHub_Click(object sender, EventArgs e)
        {

        }

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();

            DialogResult = DialogResult.Yes;
            Close();
        }

        private void BtnProjectLocation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Tag.ToString())
            {
                case "all":
                    if (ConfirmOverwrite() == false)
                    {
                        return;
                    }
                    break;
                default:
                    break; ;
            }
            string outpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyDocuments;
                folderBrowserDialog.ShowNewFolderButton = true;
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    outpath = folderBrowserDialog.SelectedPath;
                }
            }
            switch (btn.Tag.ToString())
            {
                case "all":
                    txtMasterRoot.Text = outpath;
                    UpdateProjectList(outpath);
                    break;
                case "current":
                    txtProjectLocation.Text = outpath;
                    break;
                default:
                    return;
            }
        }

        private void BtnMainProjFile_Click(object sender, EventArgs e)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (txtProjectLocation.Text == "")
            {
                baseDirectory = selectedProject.RootDirectory;
            }
            else
            {
                baseDirectory = txtProjectLocation.Text;
            }

            openFileDialog.InitialDirectory = baseDirectory;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtMainProjFile.Text = openFileDialog.FileName;
            }
        }
        #endregion

        private bool ConfirmOverwrite()
        {
            DialogResult result = MessageBox.Show("This will overwrite all automatically-loaded projects currently in the projects list.\n\nAre you sure you want to overwrite the existing list?", "Confirm Overwrite", MessageBoxButtons.YesNo);

            return result == DialogResult.Yes;
        }

        private void UpdateProjectList(string path)
        {
            ProjectList = formMain.AddProjects(path);
            LoadProjects();
        }

        private void SetOpenWithSelectedItem()
        {
            foreach (Launcher l in listOpenWith.Items)
            {
                if (l.Value == selectedProject.DefaultLauncher.Value)
                {
                    listOpenWith.SelectedItem = l;
                }
            }
        }

        private void ListProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProject = (Project)listProjects.SelectedItem;
            UpdateUI();
        }

        private void ListOpenWith_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectedProject.RootDirectory == txtProjectLocation.Text)
            {
                selectedProject.DefaultLauncher = (Launcher)listOpenWith.SelectedItem;
            }
        }

        private void CheckEnableGit_CheckedChanged(object sender, EventArgs e)
        {
            if(selectedProject.RootDirectory == txtProjectLocation.Text)
            {
                selectedProject.EnableGitLog = checkEnableGit.Checked;
            }

            lblGitHistoryLines.Visible = txtGitLogHistory.Visible = checkEnableGit.Checked;
        }

        private void ChkEnableTimekeeping_CheckedChanged(object sender, EventArgs e)
        {
            if(selectedProject.RootDirectory == txtProjectLocation.Text)
            {
                selectedProject.EnableTimekeeping = chkEnableTimekeeping.Checked;
            }
        }
    }

    [Serializable]
    public class DateTimePattern
    {
        public DateTime Display { get; set; }
        public string Format { get; set; }

        public DateTimePattern(DateTime dt, string format)
        {
            Display = dt;
            Format = format;
        }

        public override string ToString()
        {
            return Display.ToString(Format);
        }
    }
}
