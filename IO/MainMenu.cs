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
                    break;
                default:
                    Console.WriteLine("\nInvalid Command. Please type a number from 0 to 4.\n");
                    break;
            }
        }
    }
}