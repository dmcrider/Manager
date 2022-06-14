using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    internal class UserSettings
    {
        public DateTimePattern DateTimePattern { get; set; }
        public string LastUsedProfile { get; set; }
        public string PreferredTextEditorPath { get; set; }

        public UserSettings()
        {
            DateTimePattern = new DateTimePattern();
        }

        public string FormatTimeStamp(DateTime timestamp)
        {

            DateTimePattern.Display = timestamp;

            return DateTimePattern.ToString();
        }
    }
}
