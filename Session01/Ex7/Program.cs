using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondNumebr = Convert.ToDouble(Console.ReadLine());
            Console.Write("The bigger number is: ");
            if (firstNumber > secondNumebr)
                Console.Write(firstNumber);
            else
                Console.Write(secondNumebr);
        }
    }
}
