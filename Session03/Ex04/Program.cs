using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            
            player.Shout("Yo, bitch!");
            player.Shout(5);
            player.Shout(new Enemy(47));
        }
    }
}