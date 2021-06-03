using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    [Serializable]
    public class ProjectNote
    {
        public List<Note> Notes { get; set; }
    }
}
