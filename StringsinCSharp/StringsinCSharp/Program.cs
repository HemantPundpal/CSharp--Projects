using System;
using System.Text;

namespace StringsinCSharp
{
    class Program
    {
        static void Main()
        {
            string userString1 = "C#"; //this is immutable string, thus every change to this string will have a new string object in memory. The older objects will stay in memory untill garbage collector cleans them.
            userString1 += "video";
            userString1 += "Tutorial";
            userString1 += "for";
            userString1 += "Begineers";

            StringBuilder userString2 = new StringBuilder("C#"); // this is mutable string, thus every change to this string will be made to the same StringBuilder object.
            userString2.Append("video");
            userString2.Append("Tutorial");
            userString2.Append("for");
            userString2.Append("begineers");


            // Thus if you have extensive manupulations of string in your application. Then using StringBuilder is more effecient for heap as well as cpu.
        }
    }
}
