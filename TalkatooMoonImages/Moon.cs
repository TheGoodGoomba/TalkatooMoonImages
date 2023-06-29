using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkatooMoonImages
{
    public class Moon
    {
        public Moon(int moonId, Kingdom kingdom)
        {
            MoonId = moonId;
            Kingdom = kingdom;
        }

        public int MoonId { get; set; }
        public Kingdom Kingdom { get; set; }
        public string Notes { get; set; }
        
        public string GetImageLocation()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "Images", Kingdom.Name, $"{MoonId}.png");
        }
    }
}
