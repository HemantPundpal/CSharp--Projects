using System;

namespace OverridingToStringinCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Jon";
            C1.LastName = "Dow";

            Console.WriteLine(C1.ToString());
            Console.WriteLine(Convert.ToString(C1));
            Console.ReadKey();
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            //return base.ToString(); // Default from intelispace
            return FirstName + " " + LastName;
        }
    }
}
