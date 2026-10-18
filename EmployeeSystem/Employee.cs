using System;

namespace EmployeeSystem
{
    public abstract class Employee
    {
        public Employee(string name)
        {
            
            Name=name;
        }
        public static int ID {get; set;}
        public string? Name {get; set;}
       
        public virtual double CalculateSalary(double salary)
        {
            return salary;
        }
        public virtual double CalculateSalary(double hours, double hoursrate)
        {
            return hours*hoursrate;
        }
        public static int IdCounter()
        {
            return ID++;
        }
        


    }
}
