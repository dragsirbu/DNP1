using System;

namespace Ex02
{
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }

        public Person(string firstName, string lastName, int ssn)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Ssn = ssn;
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}, Last Name: {this.LastName}, Ssn: {this.Ssn}";
        }
    }
}