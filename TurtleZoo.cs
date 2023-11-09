using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulControlWork
{
    internal class TurtleZoo: IZooBase
    {
        private const double WaterTemperature = 25;
        private const double Width = 5;
        private const double Length = 6;

        public override double CalculateArea()
        {
            return Width * Length;
        }

        public override double CalculateVolume()
        {
            // Assuming the enclosure is filled with water
            return CalculateArea() * 1.2;
        }
        public override string GetDimensions()
        {
            return $"Width: {Width}, Length: {Length}";
        }

        public override double GetTemperature()
        {
            return WaterTemperature;
        }

        public double GetWaterTemperature()
        {
            return WaterTemperature;
        }
    }
}
