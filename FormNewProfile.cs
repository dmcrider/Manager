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
    public partial class FormNewProfile : Form
    {
        public string NewProfileName;

        public FormNewProfile()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;

            if(txtProfileName.Text == "")
            {
                MessageBox.Show("The new Profile name cannot be blank.");
                btnCreate.Enabled = true;
                return;
            }

            NewProfileName = txtProfileName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
