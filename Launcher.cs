using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    [Serializable]
    public class Launcher
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Launcher(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public Launcher() { }

        public static Launcher None = new Launcher("None", 0);
        public static Launcher AndroidStudio = new Launcher("Android Studio", 1);
        public static Launcher VisualStudioCode = new Launcher("Visual Studio Code", 2);
        public static Launcher VisualStudioCommunity = new Launcher("Visual Studio Community", 3);
        public static Launcher Unity = new Launcher("Unity", 4);

        public static bool VSCodeIsInstalled()
        {
            try
            {
                return Registry.ClassesRoot.OpenSubKey("vscode") != null;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }

        public static bool VisualStudioIsInstalled()
        {
            string uninstallKey = @"SOFTWARE\Microsoft";

            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    if (skName.Contains("VisualStudio"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool ProgramIsInstalled(string program)
        {
            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";

            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {
                            var displayName = sk.GetValue("DisplayName");
                            if (displayName != null)
                            {
                                if (displayName.ToString().Contains(program))
                                {
                                    return true;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                }
            }
            return false;
        }
    }
}
