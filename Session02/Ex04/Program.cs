using System;
using System.Collections.Generic;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Animal("Dog",20,20));
            animalList.Add(new Animal("Cat",8,15));
            animalList.Add(new Animal("Horse",400,70));
            animalList.Add(new Animal("Chicken",5,7));
            animalList.Add(new Animal("Cow",500,5));

            foreach (var animal in animalList)
            {
                Console.WriteLine(animal.toString());
            }

            animalList.Sort();

             foreach (var animal in animalList)
            {
                Console.WriteLine(animal.toString());
            }
            
        }
    }
}
