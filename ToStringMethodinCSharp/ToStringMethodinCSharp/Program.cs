using System;


namespace ToStringMethodinCSharp
{
    class Program
    {
        static void Main()
        {
            customer C1 = new customer();
            C1.Name = "Jon Dow";
            Console.WriteLine(C1.ToString()); //Works
            Console.WriteLine(Convert.ToString(C1)); //Works

            customer C2 = null;
            //Console.WriteLine(C2.ToString()); //Cannot call ToString on null reference
            Console.WriteLine(Convert.ToString(C2)); //This is ok, it will be returning empty string for null reference.


            Console.ReadKey();
        }
    }

    public class customer
    {
        public string Name { get; set; }

        public override string ToString()
        {
            // return base.ToString();
            return Name;
        }
    }
}
