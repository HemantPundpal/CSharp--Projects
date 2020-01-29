using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to C#, What is your first name?");
        string UserFirstName = Console.ReadLine();
        Console.WriteLine("Welcome to C#, What is your Last name?");
        string UserLastName = Console.ReadLine();
        Console.WriteLine("Hello " + UserFirstName + " " + UserLastName);
        Console.WriteLine("Hello {0} {1}", UserFirstName, UserLastName);
        Console.WriteLine($"Hello {UserFirstName} {UserLastName}");
        Console.ReadKey();
    }
}

