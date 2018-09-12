using System;
using Funny;
namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Circus circus = new Circus();
            circus.addClown(new Clown("Roko"));
            circus.addClown(new Clown("Michal"));
            circus.addClown(new Clown("Alex"));
        }
    }
}
