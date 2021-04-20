﻿using System;
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
    public partial class FormLaunchers : Form
    {
        private UserSettings Settings;

        public FormLaunchers(UserSettings settings)
        {
            InitializeComponent();
            Settings = settings;
        }

        private void FormLaunchers_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            txtAndroidStudioPath.Text = Settings.AndroidStudioExecutableLocation;
            txtVSCodePath.Text = Settings.VSCodeExecutableLocation;
            txtVSCommunityPath.Text = Settings.VSCommunityExecutableLocation;
        }

        private void BtnChangePath_Click(object sender, EventArgs e)
        {
            string outpath = "";
            using (openFileDialog = new OpenFileDialog())
            {
                #region Set Initial Directory
                try
                {
                    switch (((Button)sender).Tag.ToString())
                    {
                        case "android":
                            openFileDialog.InitialDirectory = Properties.Settings.Default.AndroidStudioPath;
                            break;
                        case "vscode":
                            openFileDialog.InitialDirectory = Properties.Settings.Default.VSCodePath;
                            break;
                        case "vscommunity":
                            openFileDialog.InitialDirectory = Properties.Settings.Default.VisualStudioPath;
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                }
                #endregion

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    outpath = openFileDialog.FileName;
                    btnSave.Enabled = true;
                    btnLoadDefaults.Enabled = true;
                }
                else
                {
                    return; // Don't change anything because they canceled
                }
            }
            switch (((Button)sender).Tag.ToString())
            {
                case "android":
                    txtAndroidStudioPath.Text = outpath;
                    break;
                case "vscode":
                    txtVSCodePath.Text = outpath;
                    break;
                case "vscommunity":
                    txtVSCommunityPath.Text = outpath;
                    break;
                default:
                    break;
            }
        }

        private void BtnLoadDefaults_Click(object sender, EventArgs e)
        {
            txtAndroidStudioPath.Text = Properties.Settings.Default.AndroidStudioPath;
            txtVSCodePath.Text = Properties.Settings.Default.VSCodePath;
            txtVSCommunityPath.Text = Properties.Settings.Default.VisualStudioPath;

            btnLoadDefaults.Enabled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Settings.AndroidStudioExecutableLocation = txtAndroidStudioPath.Text;
            Settings.VSCodeExecutableLocation = txtVSCodePath.Text;
            Settings.VSCommunityExecutableLocation = txtVSCommunityPath.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}