using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    internal class DateTimePattern
    {
        public DateTime Display { get; set; }
        public string DateFormat { get; set; }
        public string TimeFormat { get; set; }

        public DateTimePattern() { }

        public DateTimePattern(DateTime display, string dateFormat, string timeFormat)
        {
            Display = display;
            DateFormat = dateFormat;
            TimeFormat = timeFormat;
        }

        public override string ToString()
        {
            if(DateFormat == "")
            {
                return Display.ToString(TimeFormat);
            }
            if(TimeFormat == "")
            {
                return Display.ToString(DateFormat);
            }

            return Display.ToString(DateFormat) + " " + Display.ToString(TimeFormat);
        }
    }
}
