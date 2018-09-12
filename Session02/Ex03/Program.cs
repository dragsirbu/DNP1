using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee rokoEmployee = new PartTimeEmployee("Roko",147,45);
            Employee bobEmployee = new FullTimeEmployee("Bob",16000);
            PartTimeEmployee martiEmployee = new PartTimeStudent("Marti",127,40,2018);
            Company myCompany = new Company();
            myCompany.EmployNewEmployee(rokoEmployee);
            myCompany.EmployNewEmployee(bobEmployee);
            myCompany.EmployNewEmployee(martiEmployee);
            Console.WriteLine($"Name: {rokoEmployee.name}, Salary: {rokoEmployee.GetMonthlySalary()}");
            Console.WriteLine($"Name: {bobEmployee.name}, Salary: {bobEmployee.GetMonthlySalary()}");
            Console.WriteLine($"Name: {martiEmployee.name}, Salary: {martiEmployee.GetMonthlySalary()}");
            Console.WriteLine($"Total company expenses: {myCompany.GetMonthlySalaryTotal()}");

        }
    }
}
