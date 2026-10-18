using EmployeeSystem;

IWorkable employeeType;
string name;
double salary;
double workingHours;
double hoursRate;
Console.WriteLine("enter your working, enter 1 for full-time, 2 for part-time");
int type=Convert.ToInt32(Console.ReadLine());
if (type == 1)
{
    Console.WriteLine("enter your name");
    name=Console.ReadLine();
    Console.WriteLine("enter your salary");
    salary=Convert.ToDouble(Console.ReadLine());
    employeeType=new FullTimeEmployee(name, salary);
}
else if (type == 2)
{
     Console.WriteLine("enter your name");
     name=Console.ReadLine();
     Console.WriteLine("enter your working hours");
     workingHours=Convert.ToDouble(Console.ReadLine());
     Console.WriteLine("enter your hours rate");
     hoursRate=Convert.ToDouble(Console.ReadLine());
     employeeType=new PartTimeEmployee(name, workingHours, hoursRate);
}
else
{
    throw new Exception();
}


employeeType.DisplayInfo();
employeeType.Work();

