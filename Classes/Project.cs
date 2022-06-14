using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    internal class Project
    {
        public string Name { get; set; }
        public string RootDirectory { get; set; }
        public string GitCurrentBranch { get; set; }
        public int GitLogHistory { get; set; }
        public string NotesPath { get; set; }

        public Project() { }

        public static Project CreateProject(string name, string rootDir, int gitHistory)
        {
            return new Project()
            {
                Name = name,
                RootDirectory = rootDir,
                GitLogHistory = gitHistory,
                GitCurrentBranch = "",
                NotesPath = ""
            };
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
