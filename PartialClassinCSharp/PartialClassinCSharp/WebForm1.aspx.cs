using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartialClassinCSharp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer C1 = new Customer();
            C1.FirstName = "Jon";
            C1.LastName = "Dow";
            Response.Write($"Full Name - {C1.GetFullName()}");

            PartialCustomer C2 = new PartialCustomer();
            C2.FirstName = "Bob";
            C2.LastName = "Hawk";
            Response.Write($"Full Name - {C2.GetFullName()}");

            PartialCustomer C3 = new PartialCustomer();
            C3.PublicMethod();
        }
    }
}