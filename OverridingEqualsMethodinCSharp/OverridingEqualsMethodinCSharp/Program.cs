using System;


namespace OverridingEqualsMethodinCSharp
{
    public class Program
    {
        public static void Main()
        {
            int i = 10;
            int j = 10;
            Direction direction1 = Direction.East;
            Direction direction2 = Direction.East;

            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));
            Console.WriteLine(direction1 == direction2);
            Console.WriteLine(direction1.Equals(direction2));


            Customer C1 = new Customer();
            C1.FirstName = "Jon";
            C1.LastName = "Dow";

            Customer C2 = C1;
            Console.WriteLine(C1 == C2); // here the reference are compared, where C1 and C2 are refering to the same object; here result True. This is ok
            Console.WriteLine(C1.Equals(C2)); // here the reference are compared, where C1 and C2 are refering to the same object; here result True. This is ok

            Customer C3 = new Customer();
            C3.FirstName = "Jon";
            C3.LastName = "Dow";

            Console.WriteLine(C1 == C3); // here the reference are compared, where C1 and C2 are refering to the same object; here result True. Value equality need not mean reference are equal.
            Console.WriteLine(C1.Equals(C3)); // here the reference are compared, where C1 and C2 are refering to the same object; here result True. Value equality need not mean reference are equal.


            Console.ReadKey();
        }
    }

    public enum Direction
    {
        East = 1,
        West,
        North,
        South
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            //return base.Equals(obj);
            if((obj != null) && (obj is Customer))
            {
                if((this.FirstName == ((Customer)obj).FirstName) && (this.LastName == ((Customer)obj).LastName))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            //return base.GetHashCode();

            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
