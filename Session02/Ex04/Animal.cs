using System;
namespace Ex04
{
    public class Animal : IComparable
    {
        string type;
        double weight;
        int runSpeed;

        public Animal(String type, double weight, int runSpeed)
        {
            this.type = type;
            this.weight = weight;
            this.runSpeed = runSpeed;
        }

        public int CompareTo(object obj)
        {
            if (obj is Animal)
                return this.Weight.CompareTo((obj as Animal).Weight);
            return 0;
        }

        public  String toString()
        {
            return $"Type: {this.type}, Weight: {this.weight}, Run Speed: {this.runSpeed}";
        }

        public double Weight 
        {
            get { return weight; }
            set { weight = value; }
        }

        public int RunSpeed
        {
            get { return runSpeed; }
            set { runSpeed = value; }
        }   
    }
}