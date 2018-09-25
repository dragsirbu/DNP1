using System;
using System.Security.Cryptography.X509Certificates;

namespace Ex08
{
    class Program
    {
        public delegate void Del(string name);

        

        public static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        public static void SayGoodbye(string name)
        {
            Console.WriteLine($"Goodbye, {name}");
        }
        
        static void Main(string[] args)
        {
            Del notifier = SayHello;
            notifier += SayGoodbye;
            notifier("Dragos");
            
        }
    }
}