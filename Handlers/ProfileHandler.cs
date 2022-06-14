using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Manager
{
    internal class ProfileHandler
    {
        private static string BaseProfileDirectory = Path.Combine(Program.BaseDirectory, "Profiles");
        private static ProfileHandler _instance;
        public static ProfileHandler Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ProfileHandler();
                }

                return _instance;
            }
        }

        public List<ProfileSettings> Profiles;

        private ProfileHandler()
        {
            LoadProfiles();
        }

        private void LoadProfiles()
        {
            Profiles = new();

            if (!Directory.Exists(BaseProfileDirectory))
            {
                Directory.CreateDirectory(BaseProfileDirectory);
            }
            var profileDirs = Directory.GetDirectories(BaseProfileDirectory);

            if (!profileDirs.Any())
            {
                // Create the Default profile
                CreateProfile("Default");
                LoadProfiles();
                return; // Hard-return after recursive call
            }

            foreach(var dir in profileDirs)
            {
                var tempProfile = ProfileSettings.Load(Path.Combine(dir, $"{new DirectoryInfo(dir).Name}.json"));
                Profiles.Add(tempProfile);
            }
        }

        public static void CreateProfile(string profileName)
        {
            var profile = new ProfileSettings(profileName, BaseProfileDirectory);
            Directory.CreateDirectory(Path.GetDirectoryName(profile.SettingsPath)!);

            var profileJSON = JsonSerializer.Serialize(profile);
            File.WriteAllText(profile.SettingsPath, profileJSON);
        }

        public void CreateProject(ProfileSettings profile, Project project)
        {
            profile.ProjectList.Add(project);
            profile.Save();
        }

        public Project GetProjectByName(string profileName, string projectName)
        {
            var profile = Profiles.Where(x => x.ProfileName == profileName).First();
            return profile.ProjectList.Where(x => x.Name == projectName).FirstOrDefault();
        }

        public void VerifyNotesPathExists(ProfileSettings p, Project proj)
        {
            var notesDirectory = Path.Combine(BaseProfileDirectory, $"{p.ProfileName}\\{proj.Name}");
            var notesPath = Path.Combine(notesDirectory, "notes.txt");
            if (!File.Exists(notesPath))
            {
                if (!Directory.Exists(notesDirectory))
                {
                    Directory.CreateDirectory(notesDirectory);
                }
                File.Create(notesPath).Close();
            }

            proj.NotesPath = notesPath;
            p.Save();
        }

        public void UpdateProject(ProfileSettings profile, Project project, string oldProjectName)
        {
            var existing = profile.ProjectList.Where(x => x.Name == oldProjectName).FirstOrDefault();
            if(existing != null)
            {
                existing.Name = project.Name;
                existing.RootDirectory = project.RootDirectory;
                existing.GitLogHistory = project.GitLogHistory;
                profile.Save();
            }
        }
    }
}
