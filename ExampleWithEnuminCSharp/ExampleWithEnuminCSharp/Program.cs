using System;

public class Program
{
    public static void Main()
    {
        short[] Values = (short[])Enum.GetValues(typeof(Gender));

        foreach (int i in Values)
        {
            Console.WriteLine(i);
        }

        string[] Names = Enum.GetNames(typeof(Gender));

        foreach (string Name in Names)
        {
            Console.WriteLine(Name);
        }

        Console.ReadKey();
    }
}


public enum Gender : int // default is int type, but you can specify short or other number type (byte, sbyte, short, ushort, int, uint, long, or ulong)
{
    Unknown = 1,
    Male,
    Female
}

public enum Season
{
    winter = 1,
    Spring = 2,
    Summer = 3
}
