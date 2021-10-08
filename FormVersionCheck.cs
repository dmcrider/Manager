using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

namespace Manager
{
    public partial class FormVersionCheck : Form
    {
        public FormVersionCheck()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void FormVersionCheck_Load(object sender, EventArgs e)
        {
            btnUpgrade.Enabled = false;
            SetInstalledVersion();
            SetAvailableVersion();
        }

        private void SetInstalledVersion()
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            txtInstalledVersion.Text = version.ToString();
        }

        private void SetAvailableVersion()
        {
            // Source: https://octokitnet.readthedocs.io/en/latest/releases/
            // releases[0] will always be the latest release
            var client = new GitHubClient(new ProductHeaderValue("project-manager"));
            var releases = client.Repository.Release.GetAll("dmcrider", "Manager").Result;

            txtAvailableVersion.Text = releases[0].TagName;
            var remoteVersion = new Version(txtAvailableVersion.Text);
            var localVersion = new Version(txtInstalledVersion.Text);
            int vComp = localVersion.CompareTo(remoteVersion);

            if(vComp < 0)
            {
                btnUpgrade.Enabled = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnUpgrade_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/dmcrider/Manager/releases/latest");
        }
    }
}
