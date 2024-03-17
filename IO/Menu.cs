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
            Console.WriteLine("1: Add a Beer");
            Console.WriteLine("2: Show all Beers");
            Console.WriteLine("3: Delete a Beer");
            Console.WriteLine("4: Update a Beer");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    controller.AddBeer();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                    break;
                default:
                    Console.WriteLine("\nInvalid Command. Please type a number from 0 to 4.\n");
                    break;
            }
        }
    }
}