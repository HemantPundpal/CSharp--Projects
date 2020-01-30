using System;

public delegate void HelloFunctionDelegate(string Message);

class Program
{
    static void Main()
    {
        // A delegate is a type safe function pointer
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        del("Hello from Delegate");

        Console.ReadKey();
    }

    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }
}

