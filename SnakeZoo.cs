using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulControlWork
{
    internal class SnakeZoo: IZooBase
    {
        private const double AverageTemperature = 30;
        private const double Width = 2;
        private const double Length = 2;

        public override double CalculateArea()
        {
            return Width * Length;
        }

        public override double CalculateVolume()
        {
            return CalculateArea() * 0.5;
        }

        public override string GetDimensions()
        {
            return $"Width: {Width}, Length: {Length}";
        }

        public override double GetTemperature()
        {
            return AverageTemperature;
        }
    }
}
