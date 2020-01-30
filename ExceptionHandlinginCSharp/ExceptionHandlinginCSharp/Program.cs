using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader sr1 = null;
        try
        {
            sr1 = new StreamReader(@"D:\Visual C# Programs\Venkat\ExceptionHandlinginCSharp\ExceptionHandlinginCSharp\ExceptionHandling.txt");
            Console.WriteLine(sr1.ReadToEnd());
        }
        catch(FileNotFoundException ex) //Specific exception at top.
        {
            Console.WriteLine($"Please see if the following file exist - {ex.FileName}");
        }
        catch(DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex) //Generic once below as to not suppersed the specific exception.
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        finally //Use for cleanup in finally block. Finally block called for sure, even if there is additional exception during exception handling.
        {
            if (sr1 != null)
            {
                sr1.Close();
            }
            Console.WriteLine("In Finally Block");
        }


        Console.ReadKey();
    }
}

