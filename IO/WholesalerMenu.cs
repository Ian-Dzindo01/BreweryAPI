using BreweryAPI.DbHelper;
using BreweryAPI.Controllers;

namespace BreweryAPI.Menus
{
    public class WholesalerMenu
    {
        private readonly WholesalerController controller;
        public WholesalerMenu(WholesalerController controller)
        {
            this.controller = controller;
        }
        public void Start()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1: Add a Wholesaler");
            Console.WriteLine("2: Delete a Wholesaler");
            Console.WriteLine("3: Update Wholesaler Info");
            Console.WriteLine("4: See All Wholesalers");            
            Console.WriteLine("0: Back to Main Menu");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    controller.AddWholesaler(this);
                    break;
                case "2":
                    controller.DeleteWholesaler(this);
                    break;
                case "3":
                    controller.UpdateWholesaler(this);
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