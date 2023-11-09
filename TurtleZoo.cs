using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulControlWork
{
    internal class TurtleZoo: IZooBase, IWaterZoo
    {
        private const double WaterTemperature = 25;
        private const double Width = 5;
        private const double Length = 6;

        public TurtleZoo()
        {

        }

        public override double CalculateArea()
        {
            return Width * Length;
        }

        public override double CalculateVolume()
        {
            
            return CalculateArea() * 1.2;
        }
        public override string GetDimensions()
        {
            return $"Ширина: {Width}, Довжина: {Length}";
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
