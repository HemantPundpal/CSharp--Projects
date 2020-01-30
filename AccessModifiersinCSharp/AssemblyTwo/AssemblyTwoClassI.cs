using AssemblyOne;
using System;

namespace AssemblyTwo
{
    public class AssemblyTwoClassI : AssemblyOneClassI
    {
        public void SampleMethod()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            //Console.WriteLine(A1.ID)// A1.ID is not available outside the containing assembly.
            
            Console.WriteLine(base.ID2);

            /* OR */

            AssemblyTwoClassI A2 = new AssemblyTwoClassI();
            Console.WriteLine(A2.ID2);
        }
    }
}
