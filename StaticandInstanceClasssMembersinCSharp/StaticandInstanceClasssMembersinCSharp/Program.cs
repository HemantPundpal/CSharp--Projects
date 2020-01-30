using System;

class Circle
{
    /*public*/ static float _PI; //PI is static, hence not instance members. If PI is made public, it can be accessed from outside the class without
                                            // instance, only by use of class name.
    int _Radius;

    static Circle() // Static constructor is used to initialize the static feild. Note that the static constructor cannot be public.
    {
        Console.WriteLine("Static private construtor is called before the public defined constructor but only \"ONCE\".");
        Circle._PI = 3.141F;
    }

    public Circle(int Radius)
    {
        Console.WriteLine("Public instance construtor is called after the static private constructor.");
        this._Radius = Radius;
    }

    public static void PrintCircleAttributes()
    {
        //Console.WriteLine(this.Radius); //Error non-static members can not be accessed from a static method.
        Console.WriteLine($"Circles PI value is - {Circle._PI}"); //No error as PI is a static member of the class circle and can be accessed by the static method.
    }

    public float CalculateArea()
    {
        return Circle._PI * this._Radius * this._Radius; //PI is not an instance variable. It is a static variable accessed by Class name.
                                                         //With in the class you can access static variable with out Class name.
    }
}

class Program
{
    public static void Main()
    {

        Circle c1 = new Circle(5); //public constructor called
        Console.WriteLine($"Area of circle = {c1.CalculateArea()}");

        Circle c2 = new Circle(10); //public constructor called, not that the static constructor is only called once - when the first instance is created.
        Console.WriteLine($"Area of circle = {c2.CalculateArea()}");

        //Console.WriteLine(Circle._PI); // PI can be accessed only with Class name, only if PI is declared as public.

        Circle.PrintCircleAttributes(); // As the method static it is not a instance method and can be accessed by using the class name.
                                        // Method can be accessed out side the class as the access specifier is public.

        Console.ReadKey();
    }
}

