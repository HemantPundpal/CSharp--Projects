using System;

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

    public virtual void PrintFullName() //Virtual key word is used in base class so that it allows any derived class to override the base case method.
    {                                       // This supports polymorphimsm.
        Console.WriteLine($"{FirstName} {LastName}");
    }
}

public class PartTimeEmployee : Employee
{
    public override void PrintFullName() // Override keywork is used to indicate that the base class virtual method is overridden in the derived class.
    {
        Console.WriteLine($"{FirstName} {LastName} - Part Time");
    }
}

public class FullTimeEmployee : Employee
{
    public override void PrintFullName() // Override keywork is used to indicate that the base class virtual method is overridden in the derived class.
    {
        Console.WriteLine($"{FirstName} {LastName} - Full Time");
    }
}

public class TemporaryEmployee : Employee
{
    public override void PrintFullName() // Override keywork is used to indicate that the base class virtual method is overridden in the derived class.
    {
        Console.WriteLine($"{FirstName} {LastName} - Temporary");
    }
}


class Program
{
    static void Main()
    {
        Employee E = new Employee();
        E.PrintFullName();

        Employee[] EArr = new Employee[4];
        EArr[0] = new Employee();
        EArr[1] = new PartTimeEmployee();
        EArr[2] = new FullTimeEmployee();
        EArr[3] = new TemporaryEmployee();

        foreach(Employee e in EArr)
        {
            e.PrintFullName();
        }

        Console.ReadKey();
    }
}

