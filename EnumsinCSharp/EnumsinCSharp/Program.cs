using System;


public class Program
{
    public static void Main()
    {
        Customer[] customers = new Customer[3];

        customers[0] = new Customer
        {
            Name = "Mark",
            Gender = Gender.Male
        };
        customers[1] = new Customer
        {
            Name = "Mary",
            Gender = Gender.Female
        };
        customers[2] = new Customer
        {
            Name = "Jos",
            Gender = Gender.Unknown
        };

        foreach (Customer customer in customers)
        {
            Console.WriteLine($"Name = {customer.Name} && Gender = {customer.GetGender(customer.Gender)}");
        }

        Console.ReadKey();
    }
}


public enum Gender
{
    Unknown,
    Male,
    Female
}

// 0 - Unknown
// 1 - Male
// 2 - Female
public class Customer
{
    public string Name { get; set; }
    public Gender Gender { get; set; }

    public string GetGender(Gender gender)
    {
        switch (gender)
        {
            case Gender.Unknown:
                return "Unknown";
            case Gender.Male:
                return "Male";
            case Gender.Female:
                return "Female";
            default:
                return "Invalid data detected";
        }
    }
}

