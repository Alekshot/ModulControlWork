using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulControlWork
{
    internal class SnakeZoo: IZooBase, ILandZoo
    {
        private const double LandTemperature = 30;
        private const double Width = 2;
        private const double Length = 2;

        public SnakeZoo()
        {
            
        }

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
            return $"Ширина: {Width}, Довжина: {Length}";
        }

        public override double GetTemperature()
        {
            return LandTemperature;
        }

        public double GetLandTemperature()
        {
            return LandTemperature;
        }
    }
}
