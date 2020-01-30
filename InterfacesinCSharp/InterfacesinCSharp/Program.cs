using System;

interface ICustomer1
{
    /* public */ void Customer1Print(); //interface members are public by default and no access modifiers are allowed.
    //{ // Compilation error, no implementation alowed in interface.
    //    Console.WriteLine("Hello");
    //}
}

interface ICustomer2
{
    void Customer2Print();
}

interface ICustomer3 : ICustomer2
{
    void Customer3Print();
}

class Customer : ICustomer1, /*ICustomer2,*/ ICustomer3
{
    public void Customer2Print()
    {
        Console.WriteLine("Customer2 says Hello!");
    }

    public void Customer3Print()
    {
        Console.WriteLine("Customer3 says Hello!");
    }

    public void Customer1Print()
    {
        Console.WriteLine("Customer1 says Hello!");
    }

}

interface I1
{
    void InterfaceMethod();
}

interface I2
{
    void InterfaceMethod();
}

class Program : I1, I2
{

    public void InterfaceMethod() // Default implementation of the InterfaceMethod() will be used for I1 and I2 method is explicitly implemented below.
                                    // Also the access specifier is required for default implementation
    {
        Console.WriteLine("I1 interface method called");
    }

    void I2.InterfaceMethod() // Explicit implementation of I1 method.
    {
        Console.WriteLine("I2 interface method called");
    }

    static void Main()
    {
        Customer C1 = new Customer();
        C1.Customer2Print();
        C1.Customer3Print();
        C1.Customer1Print();

        ICustomer2 IC2 = new Customer();
        IC2.Customer2Print(); // Only ICustomer2 member available.

        Program P = new Program();
        ((I1)P).InterfaceMethod(); //As the method names in both the interface us same. InterfaceMethod() cannot be called on Program object.
        ((I2)P).InterfaceMethod();

        /* OR */
        I1 i1 = new Program();
        I2 i2 = new Program();
        i1.InterfaceMethod();
        i2.InterfaceMethod();

        /* OR */
        I1 ii1 = new Program();
        I2 ii2 = (Program)ii1; //may not be a good practice in actual, but depends.
        ii1.InterfaceMethod();
        ii2.InterfaceMethod();


        Console.ReadKey();
    }
}
