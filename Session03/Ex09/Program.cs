using System;
using System.Collections.Generic;
namespace Ex09
{
    class Program
    {

        private static bool FindRed(Car car) =>
            car.Color.Equals("Red");
    
        private static bool FindEngineBigger(Car car) =>
            car.EngineSize > 2000;

        private static bool FindEconomyLower(Car car) =>
            car.FuelEconomy < 7;
        
        private static bool FindMixed(Car car) =>
            (car.EngineSize > 2000 && car.Color.Equals("Black"));
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();

            carList.Add(new Car("Red",1500,7.6));
            carList.Add(new Car("Black",3000,5.4));
            carList.Add(new Car("Red",2000,10.2));
            carList.Add(new Car("Black",2750,7.3));
            carList.Add(new Car("Red",1750,3.3));

            List<Car> redCars = carList.FindAll(FindRed);
            List<Car> strongEngineCars = carList.FindAll(FindEngineBigger);
            List<Car> weakEconomyCars = carList.FindAll(FindEconomyLower);
            List<Car> mixedCars = carList.FindAll(FindMixed);
            
            Console.WriteLine("Red cars:");
            foreach (var car in redCars)
                Console.WriteLine(car.ToString());
            Console.WriteLine("Cars with engine power bigger than 2000");
            foreach (var car in strongEngineCars)
                Console.WriteLine(car.ToString());
            Console.WriteLine("Cars with fuel economy lower than 7");
            foreach (var car in weakEconomyCars)
                Console.WriteLine(car.ToString());
            Console.WriteLine("Black cars with engine power bigger than 2000");
            foreach (var car in mixedCars)
                Console.WriteLine(car.ToString());

            
        }
    }
}
