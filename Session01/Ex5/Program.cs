using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a number between 0 and 10: ");
            var number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 0:
                    Console.WriteLine("You have entered the first number");
                    break;
                case 10:
                    Console.WriteLine("You have entered the last number");
                    break;
                default:
                    if (number < 10 && number > 0)
                        Console.WriteLine(number);
                    else
                        Console.WriteLine("Invalid number");
                    break;
            }

        }
    }
}
