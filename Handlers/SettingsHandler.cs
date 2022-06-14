using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Manager
{
    internal class SettingsHandler
    {
        private static string SettingsFilePath = Path.Combine(Program.BaseDirectory, "settings.json");
        private static SettingsHandler _instance;
        public static SettingsHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SettingsHandler();
                }

                return _instance;
            }
        }

        public UserSettings Settings;

        private SettingsHandler()
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            if (!File.Exists(SettingsFilePath))
            {
                Settings = new UserSettings()
                {
                    DateTimePattern = new DateTimePattern(DateTime.Now, "yyyy-MM-dd", "HH:mm:ss tt"),
                    LastUsedProfile = "Default",
                    PreferredTextEditorPath = "notepad.exe"
                };
                File.WriteAllText(SettingsFilePath, JsonSerializer.Serialize(Settings));
                return;
            }

            using(var reader = new StreamReader(SettingsFilePath))
            {
                var content = reader.ReadToEnd();
                Settings = JsonSerializer.Deserialize<UserSettings>(content)!;
            }
        }

        public void UpdateSettings(UserSettings newSettings)
        {
            Settings = newSettings;
            SaveSettings();
            LoadSettings(); // Reload the newly-saved settings
        }

        private void SaveSettings()
        {
            var settingsJson = JsonSerializer.Serialize(Settings);
            File.WriteAllText(SettingsFilePath, settingsJson);
        }
    }
}
