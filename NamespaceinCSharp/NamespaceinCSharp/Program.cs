using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
using PATC = ProjectA.TeamC;


class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello");
        PATA.ClassA.Print();
        ProjectA.TeamB.ClassA.Print();
        PATB.ClassA.Print();
        PATC.ClassA.Print();

        Console.ReadKey();
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }
    }
}
