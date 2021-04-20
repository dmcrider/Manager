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
    public partial class FormChangeGitBranch : Form
    {
        public Project SelectedProject;
        public FormMain _Parent;

        public FormChangeGitBranch()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void FormChangeGitBranch_Load(object sender, EventArgs e)
        {
            var response = _Parent.GetGitResponse($"branch");
            this.Focus();

            listAllBranches.Items.Clear();
            foreach(var line in response)
            {
                if(line[0] == '*')
                {
                    txtCurrentBranch.Text = line.Substring(2);
                    continue;
                }
                var branch = line.Trim();
                listAllBranches.Items.Add(branch);
            }
        }

        private void ListAllBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNewBranch.Text = listAllBranches.SelectedItem.ToString();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewBranch.Text))
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                SelectedProject.GitCurrentBranch = txtNewBranch.Text;
                DialogResult = DialogResult.OK;
            }

            Close();
        }
    }
}
