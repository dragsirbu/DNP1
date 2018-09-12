using System;

namespace DNP
{
    namespace MathLib 
    {
        class Calculator
        {
            public Calculator() 
            {

            }
            public  double Add(double firstNumber, double secondNumber) 
            {
                return firstNumber + secondNumber;
            }
            public double Add(double[] numbers)
            {
                double result = 0;
                foreach (var number in numbers)
                {
                    result+=number;
                }
                return result;
            }

        }
    }
}
