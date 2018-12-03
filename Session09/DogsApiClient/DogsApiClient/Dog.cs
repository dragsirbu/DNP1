using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DogsApiClient
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
    }
}
