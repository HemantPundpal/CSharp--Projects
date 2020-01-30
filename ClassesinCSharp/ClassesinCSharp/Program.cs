using System;

class Customer
{
    string _firstName;
    string _lastName;

    public Customer() : this("No FirstName Provided", "No LastName Provided") { }

    public Customer(string firstname, string lastname)
    {
        this._firstName = firstname;
        this._lastName = lastname;
    }

    public void PrintFullName()
    {
        Console.WriteLine($"Full Name: {this._firstName} {this._lastName}");
    }

    ~Customer()
    {
        Console.WriteLine("Distructer was called");
    }
}

class Program
{
    public static void Main()
    {
        Customer c1 = new Customer("Jon", "Dow");
        c1.PrintFullName();

        Customer c2 = new Customer();
        c2.PrintFullName();

        Console.ReadKey();
    }
}
