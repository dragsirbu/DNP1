using System;

namespace Ex04
{
    public class Animal : IComparable
    {
        public string Type { get; set; }
        public double Weight { get; set; }
        public int RunSpeed { get; set; }

        public Animal(String type, double weight, int runSpeed)
        {
            this.Type = type;
            this.Weight = weight;
            this.RunSpeed = runSpeed;
        }

        public int CompareTo(object obj)
        {
            if (obj is Animal)
                return this.RunSpeed.CompareTo((obj as Animal).RunSpeed);
            return 0;
        }

        public override string ToString()
        {
            return $"Type: {this.Type}, Weight: {this.Weight}, Run Speed: {this.RunSpeed}";
        }
    }
}