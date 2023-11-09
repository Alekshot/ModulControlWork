using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulControlWork
{
    abstract class IZooBase : IZoo
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }
        public double Dimension3 { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculateVolume();
        public abstract string GetDimensions();
        public abstract double GetTemperature();
    }
}
