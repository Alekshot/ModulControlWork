using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulControlWork
{
    internal class ChameleonZoo: IZooBase, ILandZoo, IWaterZoo
    {
        private const double LandTemperature = 35;
        private const double WaterTemperature = 20;
        private const double LandWidth = 3.9;
        private const double LandLength = 4.9;
        private const double WaterWidth = 1;
        private const double WaterLength = 15;

        public ChameleonZoo()
        {

        }

        public override double CalculateArea()
        {
            
            return LandWidth * LandLength + WaterWidth * WaterLength;
        }

        public override double CalculateVolume()
        {
            
            return CalculateArea() * 1.5;
        }
        public override string GetDimensions()
        {
            return $"Суша: {LandWidth}, {LandLength} | Вода: {WaterWidth}, {WaterLength}";
        }

        public override double GetTemperature()
        {
            
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
