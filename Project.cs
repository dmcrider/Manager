﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    [Serializable]
    public class Project
    {
        public string Name { get; set; }
        public string RootDirectory { get; set; }
        public string MainProjectFile { get; set; }
        public string GitCurrentBranch { get; set; }
        public Launcher DefaultLauncher { get; set; }
        public bool EnableGitLog { get; set; }
        public bool EnableTimekeeping { get; set; }
        public int GitLogHistory { get; set; }

        public Project() { }

        public Project(string name, string rootDirectory, string mainFile, string gitCurrentBranch, Launcher defaultLauncher, bool useGit, bool time, int logHistory)
        {
            Name = name;
            RootDirectory = rootDirectory;
            MainProjectFile = mainFile;
            GitCurrentBranch = gitCurrentBranch;
            DefaultLauncher = defaultLauncher;
            EnableGitLog = useGit;
            EnableTimekeeping = time;
            GitLogHistory = logHistory;
        }

        public override string ToString()
        {
            return $"{Name}: {RootDirectory}";
        }

        public override int GetHashCode()
        {
            return RootDirectory.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(obj == null) { return false; }
            Project compProj = obj as Project;
            if(compProj == null)
            {
                return false;
            }
            else
            {
                return Equals(compProj);
            }
        }

        private bool Equals(Project p)
        {
            if(p == null) { return false; }
            return this.RootDirectory == p.RootDirectory;
        }

        public string TimeLogPath
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), $"TimeLogs\\{this.Name.ToLower().Trim().Replace(" ", "")}_timelog.json");
            }
        }

        public string NotesDirectory
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Notes");
            }
        }

        public string NotesPath
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), $"Notes\\{this.Name.ToLower().Trim().Replace(" ", "")}_notes.json");
            }
        }
    }

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
    }
}
