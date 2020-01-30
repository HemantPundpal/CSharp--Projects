using System;
using System.Reflection;

namespace EarlyandLateBindinginCSharp
{
    public class Program
    {
        public static void Main()
        {
            Customer C1 = new Customer(); // this is simply early binding (at compile time the compiler know what type of object to create).
            Console.WriteLine("Early Binding");
            Console.WriteLine(C1.GetFullName("Jo", "Jos"));


            Console.WriteLine();
            Console.WriteLine("Late Binding using Reflection - External Assembly");
            Assembly assembly = Assembly.Load("AssemblyOne");
            foreach (Type type in assembly.GetTypes())
            {
                if(type.Name == "Customer1")
                {
                    Type customerType1 = type;
                    object customerInstance1 = Activator.CreateInstance(customerType1);
                    MethodInfo getFullNameMethod1 = customerType1.GetMethod("GetFullName");
                    string[] parameters1 = new string[2];
                    parameters1[0] = "Bob";
                    parameters1[1] = "Hawk";
                    Console.WriteLine(getFullNameMethod1.Invoke(customerInstance1, parameters1));
                }
            }

            Console.WriteLine("Late Binding using Reflection - Executing Assembly");
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType2 = executingAssembly.GetType("EarlyandLateBindinginCSharp.Customer2");
            object customerInstance2 = Activator.CreateInstance(customerType2);
            MethodInfo getFullNameMethod2 = customerType2.GetMethod("GetFullName");
            string[] parameters2 = new string[2];
            parameters2[0] = "Jon";
            parameters2[1] = "Dow";
            Console.WriteLine(getFullNameMethod2.Invoke(customerInstance2, parameters2));


            Console.ReadKey();
        }
    }

    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }

    public class Customer2
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
