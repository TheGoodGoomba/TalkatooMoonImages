using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkatooMoonImages
{
    public class MoonNamePair
    {
        public MoonNamePair(Moon moon, string moonName)
        {
            Moon = moon;
            MoonName = moonName;
        }

        public Moon Moon { get; set; }
        public string MoonName { get; set; }
    }
}
