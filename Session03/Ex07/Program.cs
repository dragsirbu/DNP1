using System;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {10,9,8,7,6,5};
            Console.WriteLine(Calculator.Add(new int[] {0,1,2,3,4,5}));
            Console.WriteLine(Calculator.Add(array));
        }
    }
}
