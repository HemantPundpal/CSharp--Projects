using System;

class Program
{
    static void Main()
    {
    }

    public static void Add(int FN, int SN)
    {
        Console.WriteLine($"Sum = {FN + SN}");
    }

    public static void Add(int FN, int SN, int TN)
    {
        Console.WriteLine($"Sum = {FN + SN + TN}");
    }

    public static void Add(float FN, float SN)
    {
        Console.WriteLine($"Sum = {FN + SN}");
    }

    public static void Add(float FN, int SN)
    {
        Console.WriteLine($"Sum = {FN + SN}");
    }

    public static void Add(int FN, int SN, out int SUM)
    {
        Console.WriteLine($"Sum = {FN + SN}");
        SUM = FN + SN;
    }

    public static void Add(params int[] numbers)
    {
        Console.WriteLine($"Sum = {numbers[0] + numbers[1]}");
    }

    //public static void Add(int[] numbers) // Overloading with params keyword is not allowed.
    //{
    //    Console.WriteLine($"Sum = {}");
    //}

    //public static int add(int fn, int sn, out int sum) // Overloading with return type is not allowed.
    //{
    //    console.writeline($"sum = {fn + sn}");
    //    sum = fn + sn;
    //    return sum;
    //}
}

