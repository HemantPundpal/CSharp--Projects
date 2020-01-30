using System;

public abstract class Customer // Class cannot be abstract and sealed at the sametime.
{
    public abstract void Print();
}

public class Program : Customer
{
    public override void Print()
    {
        Console.WriteLine("Print function is Abstract Customer Class.");
    }

    static void Main()
    {
        Program P1 = new Program();
        P1.Print();

        /* OR */
        Customer C1 = new Program();
        C1.Print();

        Console.ReadKey();
    }
}

