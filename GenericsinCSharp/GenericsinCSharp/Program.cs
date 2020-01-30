using System;
using System.Collections.Generic;

namespace GenericsinCSharp
{
    public class Program
    {
        public static void Main()
        {
            /* Example with generic <T> method. */
            bool Equal = Calculator.AreEqual<int>(1, 1);
            Console.WriteLine((Equal == true) ? "Equal" : "Not Equal");
            Equal = Calculator.AreEqual<string>("A", "A");
            Console.WriteLine((Equal == true) ? "Equal" : "Not Equal");
            //Equal = Calculator.AreEqual<int>(1, "A"); //Error as types are mixed for comparasion.

            /* Example with generic <T> Class. */
            Equal = Calculator1<int>.AreEqual(1, 1);
            Console.WriteLine((Equal == true) ? "Equal" : "Not Equal");
            Equal = Calculator1<string>.AreEqual("A", "A");
            Console.WriteLine((Equal == true) ? "Equal" : "Not Equal");
            //Equal = Calculator1<string>.AreEqual(1, "A"); //Error as types are mixed for comparasion.

            Console.ReadKey();
        }
    }

    public class Calculator
    {
        public static bool AreEqual<T>(T Value1, T Value2) //In this example, methode is made generic <T>
        {
            return (Value1.Equals(Value2));
        }
    }

    public class Calculator1<T> // In this example, class is made generic <T>
    {
        public static bool AreEqual(T Value1, T Value2)
        {
            return (Value1.Equals(Value2));
        }
    }
}
