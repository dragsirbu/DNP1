using System;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(18,50);
            Time t2 = new Time(7,30);

            Console.WriteLine((t1+t2).ToString());

        }
    }
}