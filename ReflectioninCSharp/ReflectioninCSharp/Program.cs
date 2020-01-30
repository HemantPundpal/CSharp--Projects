using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Type T = Type.GetType("Customer"); // No namespace is there, so just the class name, else namespace.class name should be used.

        /* or */
        T = typeof(Customer); // This works same as Type.GetType().

        /* or */
        Customer C1 = new Customer();
        T = C1.GetType(); // This works same as Type.GetType().

        Console.WriteLine($"Full Name = {T.FullName}");
        Console.WriteLine($"Full Name = {T.Name}");
        Console.WriteLine($"Full Name = {T.Namespace}"); // There is no namespace.

        Console.WriteLine("Properties in Customers class");
        PropertyInfo[] properties = T.GetProperties();

        foreach(PropertyInfo property in properties)
        {
            Console.WriteLine(property.PropertyType.Name + " " + property.Name);
        }

        Console.WriteLine();
        Console.WriteLine("Methods in Customers class");
        MethodInfo[] Methods = T.GetMethods();

        foreach (MethodInfo Method in Methods)
        {
            Console.WriteLine(Method.ReturnType.Name + " " + Method.Name);

            ParameterInfo[] Parameters = Method.GetParameters();
            foreach(ParameterInfo Parameter in Parameters)
            {
                Console.WriteLine(Parameter.Position + " " + Parameter.Name);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Constructors in Customers class");
        ConstructorInfo[] Constructors = T.GetConstructors();

        foreach (ConstructorInfo Constructor in Constructors)
        {
            Console.WriteLine(Constructor.ToString());

            ParameterInfo[] Parameters = Constructor.GetParameters();
            foreach (ParameterInfo Parameter in Parameters)
            {
                Console.WriteLine(Parameter.Position + " " + Parameter.Name);
            }
        }

        Console.ReadKey();
    }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Customer(int ID, string Name)
    {
        this.Id = ID;
        this.Name = Name;
    }

    public Customer()
    {
        this.Id = -1;
        this.Name = string.Empty;
    }

    public void PrintID()
    {
        Console.WriteLine($"ID = {this.Id}");
    }
    public void PrintName()
    {
        Console.WriteLine($"Name = {this.Name}");
    }
}

