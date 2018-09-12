using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy enemy = new Enemy(15);
            player.Shout("Ready Player One!");
            player.Shout(5);
            player.Shout(enemy);
        }
    }
}
