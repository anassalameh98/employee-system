using System;

namespace EmployeeSystem
{
    public class FullTimeEmployee : Employee, IWorkable
    {
        public FullTimeEmployee(string name, double salary) : base(name)
        {
            _Salary=salary;
            ID= Employee.IdCounter();
        }
        private double _Salary;
        public double Salary
        {
            get
            {
                return _Salary;
            }
        }

        public  void DisplayInfo()
        {
            Console.WriteLine($"ID : {ID} Name : {Name} Employee Type: Full-Time Salary: {Salary}");
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working full-time.");
        }

        public override double CalculateSalary(double salary)
        {
            if (salary <= 0)
            {
                Console.WriteLine("ivalid info");
            }
            else
            {
                _Salary=salary;
            }
            return _Salary;
        }
    }
}
