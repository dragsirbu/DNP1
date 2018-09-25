using System;
using System.Collections.Generic;

namespace Ex09
{
    class Program
    {
        static void printList(List<Car> carList)
        {
            foreach (var car in carList)
            {
                Console.WriteLine(car.ToString());
            }
        }
        
        static void Main(string[] args)
        { 
            List<Car> carList = new List<Car>()
            {
                new Car("Red",1500,5.8),
                new Car("Black",1700,8.3),
                new Car("Yellow",1540,7.4),
                new Car("Blue",1500,3.8),
                new Car("Red",1700,8.8),
                new Car("Yellow",1340,4.4),
                new Car("Black",2500,10.5),
                new Car("Black",1550,9.1),
                new Car("Yellow",1840,6.4),
                new Car("Red",1630,5.5),
                new Car("Black",2100,8.3),
            };

            var blackCars = carList.FindAll(c => c.Color.Equals("Black"));
            var engineBigger = carList.FindAll(c => c.EngineSize > 2000);
            var fuelLower = carList.FindAll(c => c.FuelEconomy < 5);
            var mixedCars = carList.FindAll(c => c.Color.Equals("Yellow") && c.EngineSize < 1600);
            
            Console.WriteLine("Black cars:");
            printList(blackCars);
            
            Console.WriteLine("Cars with engine bigger than 2000:");
            printList(engineBigger);
            
            Console.WriteLine(("Cars with fuel economy lower than 5:"));
            printList(fuelLower);
            
            Console.WriteLine(("Yellow cars with engine smaller than 1600:"));
            printList(mixedCars);
        }
    }
}