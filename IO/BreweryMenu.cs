using BreweryAPI.DbHelper;
using BreweryAPI.Controllers;


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
            Console.WriteLine("1: Add a Brewery");
            Console.WriteLine("2: Delete a Brewery");
            Console.WriteLine("3: Update a Brewery");
            Console.WriteLine("4: See All Breweries");            
            Console.WriteLine("0: Back to Main Menu");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    controller.AddBrewery(this);
                    break;
                case "2":
                    controller.DeleteBrewery(this);
                    break;
                case "3":
                    controller.UpdateBrewery(this);
                    break;
                case "4":
                    // PrintBeerTable();
                    break;
                default:
                    Console.WriteLine("\nInvalid Command. Please type a number from 0 to 4.\n");
                    break;
            }
        }
    }
}