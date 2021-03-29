using System;

namespace Starbucks.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Starbucks!");
            Console.WriteLine("What kind of drink do you want, sir?");
            string drinkKind = Console.ReadLine();

            IDrink drink = DrinksFactory.CreateDrink(drinkKind);

            Console.WriteLine($"Here's your drink, that's gonna be {drink.Price()}");
            Console.WriteLine("Thank you, sir!");

            Console.ReadKey();
        }
    }
}
