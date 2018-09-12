using System;
using System.Collections.Generic;

namespace Ex01
{
    class Program
    {
        static void PushParams<T>(Stack<T> stack, params T[] arguments)
        {
            foreach (var parameter in arguments)
                stack.Push(parameter);
        }

        static void Main(string[] args)
        {
            Stack<int> integerStack = new Stack<int>();
            Stack<string> stringStack = new Stack<string>();

            PushParams<int>(integerStack,new int[] {5,10,15,20,25});
            PushParams<string>(stringStack,new string[] {"Hey!","Hi!","Hello!","Bye!"});

            while (integerStack.Count != 0)
                Console.Write(integerStack.Pop()+" ");
            
            Console.WriteLine();

            while (stringStack.Count != 0)
                Console.Write(stringStack.Pop()+" ");
        }
    }
}
