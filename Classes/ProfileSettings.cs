using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Manager
{
    internal class ProfileSettings
    {
        public string SettingsPath { get; set; }
        public string ProfileName { get; set; }
        public List<Project> ProjectList { get; set; }

        public ProfileSettings() { }

        public ProfileSettings(string name, string baseDir)
        {
            ProfileName = name;
            SettingsPath = Path.Combine(baseDir, $"{name}\\{name}.json");
            ProjectList = new List<Project>();
        }

        public static ProfileSettings Load(string settingsPath)
        {
            using(var reader = new StreamReader(settingsPath))
            {
                var content = reader.ReadToEnd();
                return JsonSerializer.Deserialize<ProfileSettings>(content)!;
            }
        }

        public void Save()
        {
            var jsonContent = JsonSerializer.Serialize(this);
            File.WriteAllText(SettingsPath, jsonContent);
        }

        public override string ToString()
        {
            return ProfileName;
        }
    }
}
