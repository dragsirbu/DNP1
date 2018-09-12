using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee rokoEmployee = new PartTimeEmployee("Roko",127,45);
            Employee bobEmployee = new FullTimeEmployee("Bob",16000);
            Company myCompany = new Company();
            myCompany.EmployNewEmployee(rokoEmployee);
            myCompany.EmployNewEmployee(bobEmployee);
            Console.WriteLine($"Name: {rokoEmployee.name}, Salary: {rokoEmployee.GetMonthlySalary()}");
            Console.WriteLine($"Name: {bobEmployee.name}, Salary: {bobEmployee.GetMonthlySalary()}");
            Console.WriteLine($"Total company expenses: {myCompany.GetMonthlySalaryTotal()}");

        }
    }
}
