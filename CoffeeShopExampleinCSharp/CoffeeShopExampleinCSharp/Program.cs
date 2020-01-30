using System;

class Program
{
    static void Main()
    {
        int CoffeeChoice = 0;
        int TotalCoffeeCost = 0;

    Start:
        Console.WriteLine("1 - Small, 2 - Medium, 3 - Large, Do not want Coffee");
        string UserCoffeeChoice = Console.ReadLine();

        if(UserCoffeeChoice == "Do not want Coffee")
        {
            goto End;
        }

        int.TryParse(UserCoffeeChoice, out CoffeeChoice);

        switch (CoffeeChoice)
        {
            case 1:
                TotalCoffeeCost += 1;
                break;
            case 2:
                TotalCoffeeCost += 2;
                break;
            case 3:
                TotalCoffeeCost += 3;
                break;
            default:
                Console.WriteLine($"Your Choice {CoffeeChoice} is invalid");
                break;
        }
        
        MoreOrder:
        Console.WriteLine("Do you want to buy another coffee - Yes or No");
        String UserDecision = Console.ReadLine();

        switch(UserDecision)
        {
            case "Yes":
                goto Start;
            case "No":
                break;
            default:
                Console.WriteLine("Not a valid choice");
                goto MoreOrder;
        }

        End:
        if (0 < TotalCoffeeCost)
        {
            Console.WriteLine("Thanks for shopping with us, enjoy your coffee");
            Console.WriteLine($"Your total cost is {TotalCoffeeCost}");
        }
        else
        {
            Console.WriteLine("See you later");
        }
        Console.ReadKey();
    }
}
