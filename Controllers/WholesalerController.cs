using BreweryAPI.Models;
using BreweryAPI.DbHelper;
using BreweryAPI.Runnin;
using BreweryAPI.Menus;

namespace BreweryAPI.Controllers
{
    public class WholesalerController
    {
        private readonly BreweryContext _breweryContext;

        public WholesalerController(BreweryContext breweryContext)
        {
            _breweryContext = breweryContext;
        }

        public void AddWholesaler(WholesalerMenu wholesalerMenu)
        {
            string Name = Validation.GetStringInput("Wholesaler Name: ");

            string Location = Validation.GetStringInput("Brewery Location: ");

            Wholesaler newWholesaler = new Wholesaler(Name, Location);

            _breweryContext.Wholesalers.Add(newWholesaler);
            _breweryContext.SaveChanges();
            wholesalerMenu.Start();
        }

        public void DeleteWholesaler(WholesalerMenu wholesalerMenu)
        {
            string Name = Validation.GetStringInput("Name of wholesaler you would like to delete");

            var wholesalerToDelete = _breweryContext.Wholesalers.FirstOrDefault(b => b.Name == Name);

            if (wholesalerToDelete != null)
            {
                _breweryContext.Wholesalers.Remove(wholesalerToDelete);
                _breweryContext.SaveChanges();
                Console.WriteLine("Record successfully deleted");
            }
            else
            {
                Console.WriteLine("Wholesaler not found");
            }
            
            wholesalerMenu.Start();
        }

        public void UpdateWholesaler(WholesalerMenu wholesalerMenu)
        {
            Console.WriteLine("Name of beer you would like to delete");
            string Name = Console.ReadLine();

            var wholesalerToUpdate = _breweryContext.Wholesalers.FirstOrDefault(b => b.Name == Name);

            if (wholesalerToUpdate == null)
            {
                Console.WriteLine("Wholesaler with name " + wholesalerToUpdate + " not found.");
                return;
            }

            string name = Validation.GetStringInput("Wholesaler Name: ");
            string Location = Validation.GetStringInput("Wholesaler Location");

            wholesalerToUpdate.Name = name;
            wholesalerToUpdate.Location = Location;

            _breweryContext.SaveChanges();

            Console.WriteLine("Wholesaler with name " + Name + " updated successfully.");
            wholesalerMenu.Start();
        }
    }
}

