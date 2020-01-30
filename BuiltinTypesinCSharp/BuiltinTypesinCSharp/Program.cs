using System;

class Program
{
    static void Main()
    {
        bool b = true; // only hold true or false.
        sbyte x1= -128; // signed 8-bit integer
        byte x2 = 255; // unsigned 8-bit integer
        char x3 = 'C'; // Unicode 16-bit character
        short x4 = -32768; // signed 16-bit integer
        ushort x5 = 65535; // unsigned 16-bit integer
        int x6 = -2147483648; // signed 32-bit integer
        uint x7 = 4294967295; // unsigned 32-bit integer
        long x8 = -9223372036854775808; // signed 64-bit integer
        ulong x9 = 18446744073709551615; // unsigned 64-bit integer

        Console.WriteLine($"bool - {b}\nsbyte - {x1}\nbyte - {x2}\nchar - {x3}\nshort - {x4}\nushort - {x5}\nint - {x6}\nuint - {x7}\nlong - {x8}\nulong - {x9}");

        for(byte x = 0; x <= byte.MaxValue; x++) { }

        Console.WriteLine($"BYTE min value {byte.MinValue}");
        Console.WriteLine($"BYTE max value {byte.MaxValue}");
        Console.WriteLine($"INT min value {int.MinValue}");
        Console.WriteLine($"INT max value {int.MaxValue}");
        Console.WriteLine($"FLOAT min value {float.MinValue}");
        Console.WriteLine($"FLOAT max value {float.MaxValue}");
        Console.WriteLine($"DOUBLE min value {double.MinValue}");
        Console.WriteLine($"DOUBLE max value {double.MaxValue}");
        Console.WriteLine($"DECIMAL min value {decimal.MinValue}");
        Console.WriteLine($"DECIMAL max value {decimal.MaxValue}");

        //Strings//
        string Name = "\"Jon\"";
        Console.WriteLine(Name);
        string Path1 = "D:\\Some_Folder\\Some_other_folder\\some_file.xyz";
        Console.WriteLine(Path1);
        string Path2 = @"D:\Some_Folder\Some_other_folder\some_file.xyz";
        Console.WriteLine(Path2);

        Console.ReadKey();
    }
}
