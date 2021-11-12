﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class FormVersionDetails : Form
    {
        public FormVersionDetails()
        {
            InitializeComponent();
            CenterToParent();
        }

        private async void FormVersionDetails_Load(object sender, EventArgs e)
        {
            // If there's no existing version details
            // download the file
            if (System.IO.File.Exists(FormMain.versionFilePath) == false)
            {
                var responseFile = await new HttpClient().GetStringAsync(@"https://dayloncrider.com/assets/downloads/ProjectManagerVersionDetails.txt");
                File.WriteAllText(FormMain.versionFilePath, responseFile);
            }

            var lines = System.IO.File.ReadAllLines(FormMain.versionFilePath);
            lblVersion.Text = String.Join("\n", lines);

            lblCopyright.Text = $"Copyright © {DateTime.Today.Year} - Daylon Crider";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}