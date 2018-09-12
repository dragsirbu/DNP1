using System;

namespace Ex03
{
    class PartTimeStudent : PartTimeEmployee ,IStudent
    {
        public int year { get; set; }
        public PartTimeStudent(String name, double hourlyWage, int hoursPerMonth,int year)
            :base(name,hourlyWage,hoursPerMonth)
        {
            this.year = year;
        }
        public void Register(int year)
        {
            this.year = year;
        }
    }
}