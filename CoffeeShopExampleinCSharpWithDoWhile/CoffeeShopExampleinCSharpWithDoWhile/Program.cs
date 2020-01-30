using System;

class Program
{
    static void Main()
    {
        int CoffeeChoice = 0;
        int TotalCoffeeCost = 0;
        string UserCoffeeChoice = "";
        String UserDecision = "";

        do
        {
            Console.WriteLine("1 - Small, 2 - Medium, 3 - Large, DO NOT WANT COFFEE");
            UserCoffeeChoice = Console.ReadLine().ToUpper();
            if (UserCoffeeChoice != "DO NOT WANT COFFEE")
            {
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
                        Console.WriteLine($"Your Choice {UserCoffeeChoice} is invalid");
                        break;
                }


                if (0 < TotalCoffeeCost)
                {
                    Console.WriteLine("Do you want to buy another coffee - YES or NO");
                    UserDecision = Console.ReadLine().ToUpper();
                    if (UserDecision != "YES" && UserDecision != "NO")
                    {
                        Console.WriteLine("Not a valid choice");
                    }
                }
            }

        } while (UserDecision != "NO" && UserCoffeeChoice != "DO NOT WANT COFFEE");




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