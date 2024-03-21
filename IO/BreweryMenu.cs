using BreweryAPI.Runnin;
using BreweryAPI.Controllers;
using BreweryAPI.Models;
using BreweryAPI.OutputHelper;
using BreweryAPI.Input;


namespace BreweryAPI.Menus
{
    public class BreweryMenu
    {
        private readonly BreweryController controller;
        public BreweryMenu(BreweryController controller)
        {
            this.controller = controller;
        }
        public void Start()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1: List Beers by brewery: ");
            Console.WriteLine("2: Add a Brewery");
            Console.WriteLine("3: Delete a Brewery");
            Console.WriteLine("4: Update a Brewery");
            Console.WriteLine("5: See All Breweries");            
            Console.WriteLine("0: Back to Main Menu");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string name = Validation.GetStringInput("Brewery Name: ");
                    List<Beer> beersByBrewer = controller.GetBeersByBreweryName(name);
                    ObjectHelper.PrintTable(beersByBrewer);
                    break;
                case "2":
                    controller.AddBrewery(this);
                    break;
                case "3":
                    controller.DeleteBrewery(this);
                    break;
                case "4":
                    controller.UpdateBrewery(this);
                    break;
                case "5":
                    List<Brewery> beers = controller.GetAll();
                    ObjectHelper.PrintTable(beers);
                    break;
                case "6":

                default:
                    Console.WriteLine("\nInvalid Command. Please type a number from 0 to 4.\n");
                    break;
            }
        }
    }
}