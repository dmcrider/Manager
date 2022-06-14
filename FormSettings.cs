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
    public partial class FormSettings : Form
    {
        private DateTimePattern DateTimePattern;

        internal UserSettings UpdatedSettings;

        public FormSettings()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            DateTimePattern = SettingsHandler.Instance.Settings.DateTimePattern;
            PopulateDateFormatDropdown();
            PopulateTimeFormatDropdown();
            PopulateCurrentEditor();
        }

        private void PopulateDateFormatDropdown()
        {
            dropdownDateFormat.Items.Clear();
            var patterns = new List<DateTimePattern>()
            {
                new DateTimePattern(DateTime.Today, "yyyy-MM-dd", ""),
                new DateTimePattern(DateTime.Today, "dd MMMM yyyy", ""),
                new DateTimePattern(DateTime.Today, "MM/dd/yyyy", ""),
                new DateTimePattern(DateTime.Today, "dddd, dd MMMM yyyy", "")
            };

            var selectedIndex = -1;
            foreach(var pattern in patterns)
            {
                var index = dropdownDateFormat.Items.Add(pattern);
                if(pattern.DateFormat == SettingsHandler.Instance.Settings.DateTimePattern.DateFormat)
                {
                    selectedIndex = index;
                }
            }

            dropdownDateFormat.SelectedIndex = selectedIndex;
        }

        private void PopulateTimeFormatDropdown()
        {
            dropdownTimeFormat.Items.Clear();
            var patterns = new List<DateTimePattern>()
            {
                new DateTimePattern(DateTime.Now, "", "HH:mm"),
                new DateTimePattern(DateTime.Now, "", "h:mm tt"),
                new DateTimePattern(DateTime.Now, "", "HH:mm:ss"),
                new DateTimePattern(DateTime.Now, "", "h:mm:ss tt"),
                new DateTimePattern(DateTime.Now, "", "HH:mm:ss tt")
            };

            var selectedIndex = -1;
            foreach (var pattern in patterns)
            {
                var index = dropdownTimeFormat.Items.Add(pattern);
                if (pattern.TimeFormat == SettingsHandler.Instance.Settings.DateTimePattern.TimeFormat)
                {
                    selectedIndex = index;
                }
            }

            dropdownTimeFormat.SelectedIndex = selectedIndex;
        }

        private void PopulateCurrentEditor()
        {
            txtEditor.Text = Path.GetFileName(SettingsHandler.Instance.Settings.PreferredTextEditorPath);
            txtEditor.Tag = SettingsHandler.Instance.Settings.PreferredTextEditorPath;
        }

        private void DropdownDateFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pattern = (DateTimePattern)dropdownDateFormat.SelectedItem;
            DateTimePattern.DateFormat = pattern.DateFormat;
        }

        private void DropdownTimeFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pattern = (DateTimePattern)dropdownTimeFormat.SelectedItem;
            DateTimePattern.TimeFormat = pattern.TimeFormat;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Programs (*.exe)|*.exe";
            openFileDialog.Title = "Select Preferred Text Editor";
            openFileDialog.InitialDirectory = "C:\\";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName;
                txtEditor.Text = Path.GetFileName(path);
                txtEditor.Tag = path;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            UpdatedSettings = new UserSettings()
            {
                DateTimePattern = this.DateTimePattern,
                PreferredTextEditorPath = txtEditor.Tag.ToString()
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
