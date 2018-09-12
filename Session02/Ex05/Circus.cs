using System.Collections.Generic;
namespace Funny
{
    class Circus
    {
        List<Clown> clowns;

        public Circus()
        {
            clowns = new List<Clown>();
        }

        public void addClown(Clown clown) 
        {
            clowns.Add(clown);
        }
    }
}