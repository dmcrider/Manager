﻿using System;
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

        public UserSettings()
        {
            DatePattern = new DateTimePattern(DateTime.Now, "yyyy-MM-dd");
            TimePattern = new DateTimePattern(DateTime.Now, "HH:mm:ss");
            MasterRootPath = "";
            ExcludedProjects = new List<Project>();
        }

        public UserSettings(DateTimePattern datePattern, DateTimePattern timePattern, string masterRootPath, List<Project> excluded)
        {
            DatePattern = datePattern;
            TimePattern = timePattern;
            MasterRootPath = masterRootPath;
            ExcludedProjects = excluded;
        }

        public string GetDateTimeFormat()
        {
            return $"{DatePattern} {TimePattern}";
        }
    }
}
