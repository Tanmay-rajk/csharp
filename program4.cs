using System;

class Employee
{
    public string Name{get; set;}
    public double Salary{get; set;}

    public Employee (string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Employe Name: {Name}");
        Console.WriteLine($"Employe Salary: {Salary}");
    }
}

class Department : Employee
{
    public string DepartmentName {get;set;}

    public Department(string name, double salary,string departmentName):base(name,salary)
    {
        DepartmentName=departmentName;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Department Name: {DepartmentName}");
    }
}

class Program{
    static void Main(string [] args)
    {
        string name;
        double salary;
        string dept;
        int i;

        Employee [] employees = new Employee[3];

        for(i = 0;i<3;i++)
        {
            Console.WriteLine("Enter employee name:");
            name = Console.ReadLine();
            
            Console.WriteLine("Enter department name:");
            dept = Console.ReadLine();
            
            Console.WriteLine("Enter salary :");
            salary = Convert.ToDouble(Console.ReadLine());

            employees[i] = new Department(name,salary,dept);
        }

        for(i = 0; i< 3 ;i++)
        {
            employees[i].DisplayDetails();
            Console.WriteLine();

        }
    }
}
