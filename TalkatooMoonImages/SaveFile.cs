using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkatooMoonImages
{
    public class SaveFile
    {
        public SaveFile(List<Kingdom> kingdoms, string pendingMoonsPath)
        {
            Kingdoms = kingdoms;
            PendingMoonsPath = pendingMoonsPath;
        }

        public List<Kingdom> Kingdoms { get; set; }
        public string PendingMoonsPath { get; set; }
    }
}
