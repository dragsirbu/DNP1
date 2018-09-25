using System;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 1442;
            string message = "";

            message = score > 1337
                ? "This is a new highscore!"
                : "You need more points to beat the highscore!";
            
            Console.WriteLine(message);
        }
    }
}