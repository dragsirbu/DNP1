using System;
using System.Collections.Generic;

namespace Ex01
{
    class Program
    {
        static void pushParams<T>(Stack<T> genericStack, params T[] values)
        {
            foreach (var value in values)
            {
                genericStack.Push(value);
            }
        }
        
        static void Main(string[] args)
        {
            var integerStack = new Stack<int>();
            var stringStack = new Stack<string>();
            
            pushParams(integerStack,new int[] {1,2,3,4,5});
            pushParams(stringStack,new string[] {"Bob","Dragos","Wendy"});

            foreach (var value in integerStack)
            {
                Console.Write(value+" ");
            }
            
            Console.WriteLine();
            
            foreach (var value in stringStack)
            {
                Console.Write(value+" ");
            }
            
        }
    }
}