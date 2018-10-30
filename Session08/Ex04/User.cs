using System.Runtime.Serialization;

namespace Ex04
{
    [DataContract(Name = "user")]
    public class User
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        
        [DataMember(Name = "email")]
        public string Email { get; set; }
    }
}