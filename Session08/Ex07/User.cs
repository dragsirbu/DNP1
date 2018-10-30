using System.Runtime.Serialization;

namespace Ex07
{
    [DataContract(Name = "user")]
    public class User
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        
        [DataMember(Name = "email")]
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is User))
                return false;

            return (this.Name.Equals(((User) obj).Name) && this.Email.Equals(((User) obj).Email));
        }
    }
}