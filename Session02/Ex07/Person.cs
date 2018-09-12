
namespace Ex07
{
    class Person
    {
        string name;
        int age;
        int power;

        public Person(string name, int age, int power)
        {
            this.name = name;
            this.age = age;
            this.power = power;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}, Power: {this.Power}";
        }
    }
}