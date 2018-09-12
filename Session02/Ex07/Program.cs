using System;
using System.Collections.Generic;
namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string,Person> nicknames = new Dictionary<string,Person>();
            nicknames.Add("Gaby",new Person("Gaby",19,10));
            nicknames.Add("El",new Person("Elvis",21,25));
            nicknames.Add("Jake",new Person("Jakob",23,20));

            foreach (var key in nicknames.Keys)
                Console.WriteLine(nicknames[key].ToString()+$", Nickname: {key}");
        }
    }
}
