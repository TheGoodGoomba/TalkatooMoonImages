using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkatooMoonImages
{
    public class Kingdom
    {
        public Kingdom(string name, int maxMoonId)
        {
            Name = name;
            MaxMoonId = maxMoonId;
        }

        public string Name { get; set; }
        public int MaxMoonId { get; set; }

        public string GetImageDirectory()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "Images", Name);
        }
    }
}
