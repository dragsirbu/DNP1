

using System;

namespace Ex02
{
    public class Bomb : IExplodable<double>
    {
        public void explode(double radius)
        {
            Console.WriteLine($"Boom! Radius: {radius}");
        }
        
    }
}