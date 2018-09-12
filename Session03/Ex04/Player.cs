using System;

namespace Ex04
{
    public class Player
    {
        public Player(){}

        public void Shout(String sentence)
        {
            Console.WriteLine(sentence);
        }

        public void Shout(int luckyNumber)
        {
            Console.WriteLine($"{luckyNumber} is my lucky number!");
        }

        public void Shout(Enemy enemy)
        {
            Console.WriteLine($"The enemy can do {enemy.Damage} damage to me.");
        }
    }
}