using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    [Serializable]
    public class TimeLog
    {
        public TimeLog LastSession { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan ElapsedTime { get; set; }

        public TimeLog()
        {
            LastSession = null;
            StartTime = DateTime.Parse("0001-01-01");
            EndTime = DateTime.Parse("0001-01-01");
            ElapsedTime = new TimeSpan(0,0,0);
        }

        public TimeLog(TimeLog last, DateTime start, DateTime end, TimeSpan elapsed)
        {
            LastSession = last;
            StartTime = start;
            EndTime = end;
            ElapsedTime = elapsed;
        }

        public static int TimeInSeconds(DateTime start, DateTime end)
        {
            return (int)(end - start).TotalSeconds;
        }

        public static string FormattedTime(int timeInSeconds)
        {
            TimeSpan totalSeconds = TimeSpan.FromSeconds(timeInSeconds);

            return $"{totalSeconds.Days} Days {totalSeconds:hh\\:mm\\:ss}";
        }
    }
}
