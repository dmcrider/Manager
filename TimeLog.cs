using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace Manager
{
    [Serializable]
    public class TimeLog
    {
        public int SessionId { get; set; }
        public int LastSessionId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan ElapsedTime { get; set; }

        public static string basePath = Path.Combine(FormMain.baseFilePath, "TimeLogs");
        public static List<TimeLog> TimeLogs;

        public TimeLog()
        {
            if(TimeLogs == null) { InitializeEmptyLogList(); }
            SessionId = TimeLogs.Count == 0 ? 0 : TimeLogs.OrderByDescending(x => x.SessionId).First().SessionId + 1;
            StartTime = DateTime.Parse("0001-01-01");
            EndTime = DateTime.Parse("0001-01-01");
            ElapsedTime = new TimeSpan(0,0,0);
        }

        public TimeLog(int lastId, DateTime start, DateTime end, TimeSpan elapsed)
        {
            LastSessionId = lastId;
            StartTime = start;
            EndTime = end;
            ElapsedTime = elapsed;
        }

        public static void InitializeEmptyLogList()
        {
            if(TimeLogs == null)
            {
                TimeLogs = new List<TimeLog>();
            }
        }

        public static void LoadLogs(string fileName)
        {
            TimeLogs = JsonConvert.DeserializeObject<List<TimeLog>>(File.ReadAllText(Path.Combine(basePath, fileName)));
        }

        public static TimeLog GetLog(int id)
        {
            return TimeLogs.Where(x => x.SessionId == id).FirstOrDefault();
        }

        public static TimeLog GetLastLog()
        {
            return TimeLogs.OrderByDescending(x=>x.EndTime).First();
        }

        public static string GetFormattedTotalProjectTime()
        {
            if(TimeLogs.Count == 0) { return "00 Days 00:00:00"; }

            double totalSeconds = 0;
            foreach (TimeLog t in TimeLogs)
            {
                totalSeconds += (t.EndTime.Subtract(t.StartTime)).TotalSeconds;
            }

            TimeSpan totalTime = TimeSpan.FromSeconds(totalSeconds);

            return $"{totalTime.ToString("%dd")} Days {totalTime.ToString(@"hh\:mm\:ss")}";
        }

        public static void Update(string fileName, TimeLog previousLog)
        {
            try
            {
                var configFile = Path.Combine(basePath, fileName);

                if (!File.Exists(configFile))
                {
                    File.Create(configFile).Dispose();
                }

                TimeLogs.Add(previousLog);

                string jsonOut = Newtonsoft.Json.JsonConvert.SerializeObject(TimeLogs);
                File.WriteAllText(configFile, jsonOut);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save time log.\n\n" + ex.ToString());
            }
        }
    }
}
