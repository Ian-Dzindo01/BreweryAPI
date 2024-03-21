using BreweryAPI.Controllers;
using BreweryAPI.Models;
using BreweryAPI.OutputHelper;

namespace BreweryAPI.Menus
{
    public class BeerMenu
    {
        private readonly BeerController controller;

        // Constructor taking a Controller instance
        public BeerMenu(BeerController controller)
        {
            this.controller = controller;
        }
        public void Start()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1: Add a Beer");
            Console.WriteLine("2: Delete a Beer");
            Console.WriteLine("3: Update a Beer");
            Console.WriteLine("4: See All Beers");            
            Console.WriteLine("0: Back to Main Menu");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    controller.AddBeer(this);
                    break;
                case "2":
                    controller.DeleteBeer(this);
                    break;
                case "3":
                    controller.UpdateBeer(this);
                    break;
                case "4":
                    List<Beer> beers = controller.GetAll();
                    ObjectHelper.PrintTable(beers);
                    break;
                default:
                    Console.WriteLine("\nInvalid Command. Please type a number from 0 to 4.\n");
                    break;
            }
        }
    }
}