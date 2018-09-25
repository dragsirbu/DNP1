using System;
using System.Collections.Generic;

namespace Ex03
{
    public static class MyExtensions
    {
        private static Random rand = new Random();
        
        public static T GetRandomItem<T>(this List<T> list)
        {
            return list[rand.Next(0,list.Count-1)];
        }

        public static void ShuffleItems<T>(this List<T> list)
        {
            var n = list.Count;

            while (n > 1)
            {
                n--;
                var random = rand.Next(n + 1);
                var key = list[random];
                list[random] = list[n];
                list[n] = key;
            }
        }
        
    }
}