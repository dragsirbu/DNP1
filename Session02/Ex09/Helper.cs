using System;

namespace Ex09
{
    static class Helper
    {
        
        public static double Add(double number1, double number2)
        {
            double result = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {result}");
            return result;
        }
    }
}