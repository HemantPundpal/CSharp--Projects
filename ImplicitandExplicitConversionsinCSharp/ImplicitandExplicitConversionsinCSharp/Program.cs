using System;

class Program
{
    static void Main()
    {
        int i1 = 100;
        float f1 = i1; // Implicit Conversion; int to float no issues as no information lost/trancated.

        Console.WriteLine(f1);
        Console.ReadKey();

        float f2 = 123.99f;
        int i2 = (int)f2; // Explicit Conversion; float to int, typecasting is required for information lost/truncated.

        Console.WriteLine($"\n{i2}");
        Console.ReadKey();

        float f3 = 123.99f;
        int i3 = Convert.ToInt32(f3); // Explicit Conversion; float to int, Convert class is required for information lost/truncated.
                                        // Float value rounded off to nearest interger value.

        Console.WriteLine($"\n{i3}");
        Console.ReadKey();




        //Diffrence between typecasting and use of Convert class//
        float f4 = 1273733434333.45F;
        int i4 = (int)f4; //no exception for overflowing the integer value
        
        Console.WriteLine($"\n{i4}");
        Console.ReadKey();

        float f5 = 1273733434333.45F;
        //int i5 = Convert.ToInt32(f5); //exception for overflowing the integer value




        //Parse and TryParse//
        string strNumber1 = "100";
        int i5 = int.Parse(strNumber1);

        Console.WriteLine($"\n{i5}");
        Console.ReadKey();

        string strNumber2 = "100TG";
        //int i6 = int.Parse(strNumber2); //Exception as it has characters in the string.

        string strNumber3 = "100 0";
        int i7 = 0;
        bool isConversionSuccessful = int.TryParse(strNumber3, out i7);
        if (isConversionSuccessful)
        {
            Console.WriteLine($"\n{i7}");
        }
        else
        {
            Console.WriteLine("\nNot a valid number");
        }
        
        Console.ReadKey();
    }
}


