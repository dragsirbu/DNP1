using System;
using System.Collections.Generic;
namespace Ex03
{
    
    class Company
    {   
        List<Employee> employeeList;

        public Company()
        {
            this.employeeList = new List<Employee>();
        }

        public double GetMonthlySalaryTotal()
        {
            double sum = 0;
            foreach (var employee in employeeList)
            {
                sum+=employee.GetMonthlySalary();
            }
            return sum;
        }

        public void EmployNewEmployee(Employee newEmployee)
        {
            employeeList.Add(newEmployee);
        }
    }
}