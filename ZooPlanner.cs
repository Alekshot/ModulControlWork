using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulControlWork
{
    internal class ZooPlanner
    {
        private List<IZoo> enclosures;

        public ZooPlanner()
        {
            enclosures = new List<IZoo>();
        }

        public void AddEnclosure(IZoo enclosure)
        {
            enclosures.Add(enclosure);
        }

        public List<IZoo> GetEnclosures()
        {
            return enclosures;
        }

        public double CalculateTotalArea()
        {
            return enclosures.Sum(enclosure => enclosure.CalculateArea());
        }

        public double CalculateTotalVolume()
        {
            return enclosures.Sum(enclosure => enclosure.CalculateVolume());
        }
    }
}
