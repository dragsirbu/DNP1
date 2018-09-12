using System;

namespace Ex02
{
    public class Bomb : IExplodable<double>
    {
        public Bomb(){}
        public void Explode(double radius)
        {
            Console.WriteLine($"Boom bitch! Radius: {radius}");
        }
    }
}