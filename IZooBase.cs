using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulControlWork
{
    abstract class IZooBase : IZoo
    {
        public abstract double CalculateArea();
        public abstract double CalculateVolume();
        public abstract string GetDimensions();
        public abstract double GetTemperature();
    }
}
