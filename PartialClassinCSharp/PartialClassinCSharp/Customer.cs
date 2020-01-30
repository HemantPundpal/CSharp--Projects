using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClassinCSharp
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}