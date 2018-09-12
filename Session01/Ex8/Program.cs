using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            char[] userNameArray = Console.ReadLine().ToCharArray();
            Array.Reverse(userNameArray);
            string reversedName = new string(userNameArray);
            Console.WriteLine(reversedName.ToLower());
        }
    }
}
