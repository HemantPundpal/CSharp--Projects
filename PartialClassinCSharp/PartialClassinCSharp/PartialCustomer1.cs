using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PartialClassinCSharp
{
    public partial class PartialCustomer //This is combined into a single file by compliler
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        partial void SamplePartialMethod(); // Compiler Ignors deceleration if defination is not provided. Note that providing partial method decleration and definition at sametime is compilation error.
                                            // Return type for partial method is always void.
                                            // Private is default access modifier. No other access modifiers are allowed.

        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod Invoked");
            SamplePartialMethod(); // Compiler Ignors call to partial method is only deceleration is present and defination is not provided.
        }
    }
}