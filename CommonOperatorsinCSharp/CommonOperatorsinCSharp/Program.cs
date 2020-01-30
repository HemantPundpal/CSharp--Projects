using System;

class Program
{
    static void Main()
    {
        int Number1 = 10;
        int Number2 = 15;
        bool IsNumber1Value10 = (Number1 == 10) ? true : false; //Ternary Operator
        bool IsNumber2Value10 = (Number2 == 10) ? true : false; //Ternary Operator


        Console.WriteLine($"Number1 == 10 is {IsNumber1Value10}");
        Console.WriteLine($"Number2 == 10 is {IsNumber2Value10}");
        Console.ReadKey();
    }
}

