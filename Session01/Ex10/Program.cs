using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator: ");
            char userOperator = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Calculator calculator = new Calculator(firstNumber,secondNumber,userOperator);
            Console.WriteLine($"Result: {calculator.getResult()}");
        }
    }
}
