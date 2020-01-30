using System;

class Program
{
    static void Main()
    {
        string Name = null;

        //int i = null; //error int is not nullable.
        int? i = null; //no error, int is nullable and compatible to be used with database.

        //bool IsTrueorFalse = null; //error bool is not nullable.
        bool? IsTrueorFalse = null; //no error, bool is nullable and compatible to be used with database.

        Console.WriteLine(Name);
        Console.WriteLine(i);
        Console.WriteLine(IsTrueorFalse);

        //NULL Coalescing Operator//
        int? TicketsOnSale = null;
        int AvailableTickets = TicketsOnSale ?? 0;

        Console.WriteLine($"AvailableTickets = {AvailableTickets}");

        Console.ReadKey();
    }
}

