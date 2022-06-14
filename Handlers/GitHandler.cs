using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    internal class GitHandler
    {
        public static List<string> GetGitResponse(string command, string dir)
        {
            var startInfo = new ProcessStartInfo("git.exe")
            {
                UseShellExecute = false,
                WorkingDirectory = dir,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true, // This prevents the console window from flashing every time it gets used
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                Arguments = command
            };
            var output = new List<string>();

            try
            {
                var process = new Process()
                {
                    StartInfo = startInfo
                };
                process.Start();

                string lineValue = process.StandardOutput.ReadLine();
                while(lineValue != null)
                {
                    output.Add(lineValue);
                    lineValue = process.StandardOutput.ReadLine();
                }

                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return output;
        }
    }
}
