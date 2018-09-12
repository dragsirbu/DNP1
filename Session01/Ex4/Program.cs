using System;

    namespace Ex4 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("All even numbers till 100: ");
            for (int i = 0; i < 100; i++)
            {
                if( i % 2 == 0)
                {
                    Console.Write(i+" ");
                 }
            }
            Console.Write("\nAll odd numbers till 100: ");
            var counter = 0;
            while (counter < 100) 
            {
                if (counter % 2 != 0)
                {
                    Console.Write(counter+" ");
                }
                counter++;
            }
        }
    }
}

