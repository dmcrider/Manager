using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    [Serializable]
    public class UserSettings
    {
        public DateTimePattern DatePattern { get; set; }
        public DateTimePattern TimePattern { get; set; }
        public string MasterRootPath { get; set; }
        public List<Project> ExcludedProjects { get; set; }
        public string VSCodeExecutableLocation { get; set; }
        public string VSCommunityExecutableLocation { get; set; }
        public string AndroidStudioExecutableLocation { get; set; }
        public string UnityExecutableLocation { get; set; }

        public UserSettings()
        {
            DatePattern = new DateTimePattern(DateTime.Now, "yyyy-MM-dd");
            TimePattern = new DateTimePattern(DateTime.Now, "HH:mm:ss");
            MasterRootPath = "";
            ExcludedProjects = new List<Project>();
            VSCodeExecutableLocation = "";
            VSCommunityExecutableLocation = "";
            AndroidStudioExecutableLocation = "";
            UnityExecutableLocation = "";
        }

        public UserSettings(DateTimePattern datePattern, DateTimePattern timePattern, string masterRootPath, List<Project> excluded, string vsCode, string vsCommunity, string android, string unity)
        {
            DatePattern = datePattern;
            TimePattern = timePattern;
            MasterRootPath = masterRootPath;
            ExcludedProjects = excluded;
            VSCodeExecutableLocation = vsCode;
            VSCommunityExecutableLocation = vsCommunity;
            AndroidStudioExecutableLocation = android;
            UnityExecutableLocation = unity;
        }

        public string GetDateTimeFormat()
        {
            return $"{DatePattern.Format} {TimePattern.Format}";
        }
    }
}
