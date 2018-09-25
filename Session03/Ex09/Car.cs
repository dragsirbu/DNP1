using System;

namespace Ex09
{
    public class Car
    {
        public string Color { get; set; }
        public int EngineSize { get; set;}
        public double FuelEconomy { get; set; }

        public Car(string color, int engineSize, double fuelEconomy)
        {
            this.Color = color;
            this.EngineSize = engineSize;
            this.FuelEconomy = fuelEconomy;
        }

        public override string ToString()
        {
            return $"Color: {this.Color}, Engine Size: {this.EngineSize}, Fuel Economy: {this.FuelEconomy}";
        }
    }
    
}