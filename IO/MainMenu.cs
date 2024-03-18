using System.Configuration;
using BreweryAPI.DbHelper;
using BreweryAPI.Controllers;

namespace BreweryAPI.Input
{

    class InputHelper
    {
        static public void Start()
        {
            BreweryContext breweryContext = new BreweryContext();
            Controller controller = new Controller(breweryContext);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("1: Beers");
            Console.WriteLine("2: Breweries");
            Console.WriteLine("3: Wholesalers");
            Console.WriteLine("4: Update a Beer");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("\nInvalid Command. Please type a number from 0 to 4.\n");
                    break;
            }
        }
    }
}