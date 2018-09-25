using System;
using System.Collections.Generic;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>() {"Dragos","Bob","Wendy","Fruit","Table","Cup","Square","Wheels"};
            Console.WriteLine(list.GetRandomItem());

            Console.Write("Orignial list: ");
            foreach (var name in list)
            {
                Console.Write(name+" ");
            }
            
            list.ShuffleItems();
            Console.WriteLine();
            
            Console.Write("Shuffled list: ");
            foreach (var name in list)
            {
                Console.Write(name+" ");
            }
        }
    }
}