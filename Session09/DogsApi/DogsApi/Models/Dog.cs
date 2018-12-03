using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace DogsApi.Models
{
    [DataContract(Name = "dogs")]
    public class Dog
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "breed")]
        public string Breed { get; set; }
        

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Breed = {Breed}";
        }

    }
}
