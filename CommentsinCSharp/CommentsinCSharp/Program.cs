using System;

class Program
{
    static void Main()
    {
        SampleClass SC; // XML documentation is shown when you hover the mouse over the class name.

        Console.WriteLine("Please Enter a Number");

        int UserNumber;

        bool IsNumber = int.TryParse(Console.ReadLine(), out UserNumber);

        if (IsNumber)
        {
            if(UserNumber == 1)
            {
                Console.WriteLine("Your Number is one.");
            }
            else if(UserNumber == 2)
            {
                Console.WriteLine("Your Number is two.");
            }
            else if(UserNumber == 3)
            {
                Console.WriteLine("Your Number is three.");
            }
            else
            {
                Console.WriteLine("Your number is not 1 or 2 or 3.");
            }
        }
        else
        {
            Console.WriteLine("Not a number.");
        }

        Console.ReadKey();
    }
}

/// <summary>
/// This is a sample XML doucmentation of the sample class.
/// </summary>
public class SampleClass
{

}
