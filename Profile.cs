using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    [Serializable]
    public class Profile
    {
        public string ProfileName { get; set; }

        public Profile(string name)
        {
            ProfileName = name;
            CreateProfileDirectory();
        }

        public string GetDirectory()
        {
            return Path.Combine(FormMain.baseFilePath, ProfileName);
        }

        /// <summary>
        /// Create a new instance of the Profile class.
        /// </summary>
        /// <param name="name">The name of the Profile.</param>
        /// <returns>A Profile object with all properties set.</returns>
        public static Profile LoadProfile(string name)
        {
            return new Profile(name);
        }

        private void CreateProfileDirectory()
        {
            var dirPath = GetDirectory();
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
        }
    }
}
