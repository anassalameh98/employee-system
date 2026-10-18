using System;

namespace EmployeeSystem
{
    public class PartTimeEmployee : Employee, IWorkable
    {
        public PartTimeEmployee(string name, double workinghours, double hoursrate) : base(name)
        {
             HoursRate=hoursrate;
             WorkingHours=workinghours;
            ID= Employee.IdCounter();
            CalculateSalary(WorkingHours,HoursRate);
            
        }
        public double WorkingHours{get; set;}
        public double HoursRate{get; set;}
        private double _Salary;
        public double Salary
        {
            get
            {
                return _Salary;
            }
        }
        public override double CalculateSalary(double hours, double hoursrate)
        {
            _Salary=hours*hoursrate;
            return _Salary;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID : {ID} Name : {Name} Employee Type: Part-Time Salary: {_Salary}");
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working Part-time.");
        }
    }
}
