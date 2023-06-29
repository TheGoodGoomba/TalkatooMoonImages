using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TalkatooMoonImages
{
    public class Moon
    {
        public Moon() { }

        public Moon(int moonId, Kingdom kingdom)
        {
            MoonId = moonId;
            Kingdom = kingdom;
        }

        public int MoonId { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        public Kingdom Kingdom { get; set; }
        public string Notes { get; set; }
        
        public string GetImageLocation()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "Images", Kingdom.Name, $"{MoonId}.png");
        }
    }
}
