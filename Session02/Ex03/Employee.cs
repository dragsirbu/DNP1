using System;
namespace Ex03
{
    public abstract class Employee 
    {
        public string name{ get;}

        public Employee(string name)
        {
            this.name = name;
        }

        public abstract double GetMonthlySalary();
    }

    public class PartTimeEmployee : Employee
    {
        double hourlyWage { get; set; }
        int hoursPerMonth { get; set; }

        public PartTimeEmployee(string name, double hourlyWage, int hoursPerMonth)
            :base(name)
        {
            this.hourlyWage = hourlyWage;
            this.hoursPerMonth = hoursPerMonth;
        }

        public override double GetMonthlySalary()
        {
            return (this.hourlyWage * this.hoursPerMonth);
        }

    }

    public class FullTimeEmployee : Employee
    {
        double monthlySalary { get; set; }

        public FullTimeEmployee(string name, double monthlySalary)
            :base(name)
        {
            this.monthlySalary = monthlySalary;
        }

        public override double GetMonthlySalary()
        {
            return monthlySalary;
        }
    }
}