using System;

namespace Ex07
{
    public class Calculator
    {
        public static int Add(params int[] integers) 
        {
            int result = 0;
            foreach (var number in integers)
                result+=number;
            return result;
        }
    }
}