using System;
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

        public Project()
        {

        }

        public Project(string name, string rootDirectory)
        {
            Name = name;
            RootDirectory = rootDirectory;
        }

        public override string ToString()
        {
            return $"{Name}: {RootDirectory}";
        }
    }
}
