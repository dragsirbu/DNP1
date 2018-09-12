using System;
using System.Collections.Generic;

namespace Ex03
{
    static class Program
    {
        static T GetRandom<T>(this List<T> list)
        {
            Random rand = new Random();
            return list[rand.Next(0,list.Count)];
        }
        static void Main(string[] args)
        {
           List<string> list = new List<string>();
           list.Add("One");
           list.Add("Two");
           list.Add("Three");
           list.Add("Four");
           Console.WriteLine(list.GetRandom());
        }
    }
}
