using System;
using System.IO;

class Program
{
    public static void Main()
    {
        StreamWriter sw = null;
        try
        {
            try
            {
                int FirstNumber;
                int SecondNumber;
                Console.WriteLine("Enter the Numerator");
                bool IsFirstNumberSuccess = int.TryParse(Console.ReadLine(), out FirstNumber);
                Console.WriteLine("Enter the Denominator");
                bool IsSecondNumberSuccess = int.TryParse(Console.ReadLine(), out SecondNumber);

                if (IsFirstNumberSuccess && IsSecondNumberSuccess)
                {
                    double Result = FirstNumber / SecondNumber;
                    Console.WriteLine($"Result = {Result}");
                }
                else
                {
                    Console.WriteLine($"Numerator and Denominator should be a valid number between {Int32.MinValue} - {Int32.MaxValue}");
                }
            }
            catch (Exception ex)
            {
                string filePath = @"D:\Visual C# Programs\Venkat\InnerExceptioninCSharp\InnerExceptioninCSharp\Log\log.txt";
                if (File.Exists(filePath))
                {
                    sw = new StreamWriter(filePath);
                    sw.Write(ex.GetType().Name);
                    sw.WriteLine();
                    sw.Write(ex.Message);
                    sw.WriteLine();
                    sw.Write(ex.StackTrace);
                    Console.WriteLine("There is a problem, check log.txt for details. Please try Later");
                }
                else
                {
                    throw new FileNotFoundException(filePath + " is not present", ex); //Original exception is not passed then InnerException will remain NULL.
                }
            }
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Current Exception = {exc.GetType().Name}");
            Console.WriteLine($"Inner Exception = {exc.InnerException?.GetType().Name}"); //Always check inner exception is not NULL before dereferencing it.
        }
        finally
        {
            if (sw != null)
            {
                sw.Close();
            }
        }

        Console.ReadKey();
    }
}

