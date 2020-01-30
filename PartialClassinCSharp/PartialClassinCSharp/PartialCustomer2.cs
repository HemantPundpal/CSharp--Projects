using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PartialClassinCSharp
{
    public partial class PartialCustomer //This is combined into a single file by compliler
    {
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        partial void SamplePartialMethod()
        {
            Console.WriteLine("SamplePartialMethod Invoked");
        }

    }
}