using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
        empList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 7 });
        empList.Add(new Employee() { ID = 103, Name = "John", Salary = 7000, Experience = 8 });
        empList.Add(new Employee() { ID = 104, Name = "Todd", Salary = 8000, Experience = 9 });

        Console.WriteLine("Delegate IP1");
        IsPromotable IP1 = new IsPromotable(PromoteEmployee1);
        Employee.PromoteEmployee(empList, IP1);

        Console.WriteLine("Delegate IP2");
        IsPromotable IP2 = new IsPromotable(PromoteEmployee2);
        Employee.PromoteEmployee(empList, IP2);

        Console.WriteLine("Delegate with Lamda Expression");
        Employee.PromoteEmployee(empList, emp => emp.ID >= 102);

        Console.ReadKey();
    }

    public static bool PromoteEmployee1(Employee emp)
    {
        if(emp.Experience >= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool PromoteEmployee2(Employee emp)
    {
        if (emp.Salary >= 5000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

delegate bool IsPromotable(Employee empl);

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach (Employee employee in employeeList)
        {
            if (IsEligibleToPromote(employee))
            {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }
}

