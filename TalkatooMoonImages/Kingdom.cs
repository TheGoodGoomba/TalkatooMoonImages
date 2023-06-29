using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkatooMoonImages
{
    public class Kingdom
    {
        public Kingdom(string name, int numberOfMoons)
        {
            Name = name;
            Moons = new List<Moon>();
            for (var i = 1; i <= numberOfMoons; i++)
            {
                Moons.Add(new Moon(i, this));
            }
        }

        public string Name { get; set; }
        public List<Moon> Moons { get; set; }

        public string GetImageDirectory()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "Images", Name);
        }
    }
}
