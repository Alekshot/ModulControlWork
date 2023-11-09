using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulControlWork
{
    internal class ChameleonZoo: IZooBase
    {
        private const double LandTemperature = 35;
        private const double WaterTemperature = 20;
        private const double LandWidth = 3.9;
        private const double LandLength = 4.9;
        private const double WaterWidth = 1;
        private const double WaterLength = 15;

        public override double CalculateArea()
        {
            // Assuming the enclosure includes both land and water
            return LandWidth * LandLength + WaterWidth * WaterLength;
        }

        public override double CalculateVolume()
        {
            // Assuming the enclosure includes both land and water
            return CalculateArea() * 1.5;
        }
        public override string GetDimensions()
        {
            return $"Land: Width: {LandWidth}, Length: {LandLength} | Water: Width: {WaterWidth}, Length: {WaterLength}";
        }

        public override double GetTemperature()
        {
            // Assuming the temperature is an average of land and water temperatures
            return (LandTemperature + WaterTemperature) / 2;
        }

        public double GetLandTemperature()
        {
            return LandTemperature;
        }

        public double GetWaterTemperature()
        {
            return WaterTemperature;
        }
    }
}
