using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulControlWork
{
    internal interface IZoo
    {
        double CalculateArea();
        double CalculateVolume();
        string GetDimensions();
        double GetTemperature();
    }
}
