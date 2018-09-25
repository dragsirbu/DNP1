using System;

namespace Ex04
{
    public class Player
    {
        public void Shout(String argument)
        {
            Console.WriteLine(argument);
        }

        public void Shout(int number)
        {
            Console.WriteLine($"{number} is my lucky number!");
        }

        public void Shout(Enemy enemy)
        {
            Console.WriteLine($"The enemy can do {enemy.Damage} damage to me.");
        }
    }
}