using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class ErrorMessages
    {
        private static string checkLog = " Check the Error Log for more details.";

        public static string FailedLaunchVSCode
        {
            get
            {
                return "Failed to open Project in VSCode." + checkLog;
            }
        }

        public static string FaildLaunchFileEplorer
        {
            get
            {
                return "Failed to open Project directory. Verify the folder at the bottom of the screen exists.";
            }
        }

        public static string FaildLaunchAndroidStudio
        {
            get
            {
                return "Failed to open Project in ANdroid Studio." + checkLog;
            }
        }

        public static string FaildLaunchVisualStudio
        {
            get
            {
                return "Failed to open Project in Visual Studio Community. Verify the installation path in Settings -> Launchers.";
            }
        }
    }
}
