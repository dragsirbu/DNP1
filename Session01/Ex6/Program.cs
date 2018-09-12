using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            DNP.MathLib.Calculator calculator = new DNP.MathLib.Calculator();
            Console.WriteLine("The result is: "+calculator.Add(firstNumber,secondNumber));
            double[] numbers = {12.2, 3.8, 9.9, 10};
            Console.WriteLine($"The sum of the array is: {calculator.Add(numbers)}");
        }
    }
}
