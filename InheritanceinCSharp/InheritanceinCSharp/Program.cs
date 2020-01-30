using System;

public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public Employee()
    {
        Console.WriteLine("Base class constructor called first.");
    }

    public Employee(string FN, string LN)
    {
        FirstName = FN;
        LastName = LN;

        Console.WriteLine($"Paramatrized base class constructor called.");
    }

    public void PrintFullName() // This method is hidden by the FullTimeEmployee derived class.
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }

    public void PrintEmailID()
    {
        Console.WriteLine($"{Email}");
    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;

    public FullTimeEmployee() : base("Jon", "Dow")
    {
        Console.WriteLine("Derived class (FullTimeEmployee) constructor called second.");
    }

    public FullTimeEmployee(string FN, string LN) : base(FN, LN)
    {
        Console.WriteLine("Derived class (FullTimeEmployee) paramatrized constructor called second.");
    }

    public new void PrintFullName() // This derived class method hides the base class method. Key word 'new'is used to indicate the same to the compiler.
    {
        Console.WriteLine($"Full Time Employee Full Name - {this.FirstName} {LastName}");
    }

    public void PrintYearlySalary()
    {
        Console.WriteLine($"{YearlySalary}");
    }
}

public class PartTimeEmployee : Employee
{
    public float HourlyRate;

    public PartTimeEmployee()
    {
        Console.WriteLine("Derived class (PartTimeEmployee) constructor called second.");
    }

    public void PrintHourlyRate()
    {
        Console.WriteLine($"{HourlyRate}");
    }
}

class Program
{
    static void Main()
    {
        FullTimeEmployee FTE1 = new FullTimeEmployee();
        FTE1.FirstName = "Jo";
        FTE1.LastName = "Jos";
        FTE1.Email = "Jo.Jos@xyz.com";
        FTE1.YearlySalary = 50000;

        FTE1.PrintFullName();
        FTE1.PrintEmailID();
        FTE1.PrintYearlySalary();

        FullTimeEmployee FTE2 = new FullTimeEmployee("Bob", "Hook");
        FTE2.Email = "Bob.Hook@xyz.com";
        FTE2.YearlySalary = 100000;

        FTE2.PrintFullName();
        FTE2.PrintEmailID();
        FTE2.PrintYearlySalary();

        Employee E = (Employee)FTE2;
        E.PrintFullName(); //This still prints the hidden method in base class.
        ((Employee)FTE2).PrintFullName(); //This still prints the hidden method in base class.

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "Jon";
        PTE.LastName = "Dow";
        PTE.Email = "Jon.Dow@xyz.com";
        PTE.HourlyRate = 50;

        PTE.PrintFullName();
        PTE.PrintEmailID();
        PTE.PrintHourlyRate();

        Console.ReadKey();
    }
}

