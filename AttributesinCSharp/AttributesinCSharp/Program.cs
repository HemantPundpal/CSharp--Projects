using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine(Calculator.Add(10, 20)); // This method is marked as Obsolete. It also suggest to used Add method with List of numbers as parameter
        Console.WriteLine(Calculator.Add(10, 20, 39)); // This method is marked as Obsolete. It also suggest to used Add method with List of numbers as parameter

        List<int> AddNumbers = new List<int>();
        AddNumbers.Add(90);
        AddNumbers.Add(20);
        AddNumbers.Add(30);
        AddNumbers.Add(40);
        AddNumbers.Add(50);
        AddNumbers.Add(80);
        AddNumbers.Add(90);

        Console.WriteLine(Calculator.Add(AddNumbers));


        Console.ReadKey();
    }
}

public class Calculator
{
    [Obsolete("Add(List <int> Numbers)")]
    public static int Add(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }
    [Obsolete("Add(List <int> Numbers)")]
    public static int Add(int FirstNumber, int SecondNumber, int ThirdNumber)
    {
        return FirstNumber + SecondNumber + ThirdNumber;
    }

    public static int Add(List <int> Numbers)
    {
        int Sum = 0;
        foreach (int Number in Numbers)
        {
            Sum += Number;
        }
        return Sum;
    }
}

