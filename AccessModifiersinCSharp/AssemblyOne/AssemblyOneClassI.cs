using System;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        internal int ID1 = 101;
        protected internal int ID2 = 101;
    }

    public class AssemblyOneClassII
    {
        public void SampleMethod()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            Console.WriteLine(A1.ID1);
            Console.WriteLine(A1.ID2);
        }
    }
}
