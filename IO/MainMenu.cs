using System.Configuration;
using BreweryAPI.DbHelper;
using BreweryAPI.Controllers;
using BreweryAPI.Menus;

namespace BreweryAPI.Input
{

    class InputHelper
    {
        static public void Start()
        {
            BreweryContext breweryContext = new BreweryContext();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("1: Beers");
            Console.WriteLine("2: Breweries");
            Console.WriteLine("3: Wholesalers");
            Console.WriteLine("4: Clear out DB");
            Console.WriteLine("5: Read in data from CSVs");


            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BeerController beerController = new BeerController(breweryContext);
                    BeerMenu beerMenu = new BeerMenu(beerController);
                    beerMenu.Start();
                    break;
                case "2":
                    BreweryController breweryController = new BreweryController(breweryContext);
                    BreweryMenu breweryMenu = new BreweryMenu(breweryController);
                    breweryMenu.Start();
                    break;  
                case "3":
                    WholesalerController wholesalerController = new WholesalerController(breweryContext);
                    WholesalerMenu wholesalerMenu = new WholesalerMenu(wholesalerController);
                    wholesalerMenu.Start();
                    break;
                case "4":
                    breweryContext.ClearDatabase();
                    Console.WriteLine("Operation successful.");
                    Start();
                    break;
                case "5":
                    breweryContext.ReadInFromCsv();
                    Console.WriteLine("Operation successful.");
                    Start();
                    break;
                default:
                    Console.WriteLine("\nInvalid Command. Please type a number from 0 to 4.\n");
                    break;
            }
        }
    }
}