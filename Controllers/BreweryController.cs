using BreweryAPI.Models;
using BreweryAPI.DbHelper;
using BreweryAPI.Runnin;
using BreweryAPI.Menus;

namespace BreweryAPI.Controllers
{
    public class BreweryController
    {
        private readonly BreweryContext _breweryContext;

        public BreweryController(BreweryContext breweryContext)
        {
            _breweryContext = breweryContext;
        }

        public void AddBrewery(BreweryMenu breweryMenu)
        {
            string Name = Validation.GetStringInput("Brewery Name: ");
            string Location = Validation.GetStringInput("Brewery Location: ");
            Console.WriteLine("Foundation date: ");
            int FoundationDate = int.Parse(Console.ReadLine());

            Brewery newBrewery = new Brewery(Name, Location, FoundationDate);

            _breweryContext.Breweries.Add(newBrewery);
            _breweryContext.SaveChanges();
            breweryMenu.Start();
        }

        public void DeleteBrewery(BreweryMenu breweryMenu)
        {
            string Name = Validation.GetStringInput("Name of brewery  you would like to delete: ");

            var breweryToDelete = _breweryContext.Breweries.FirstOrDefault(b => b.BreweryName == Name);

            if (breweryToDelete != null)
            {
                _breweryContext.Breweries.Remove(breweryToDelete);
                _breweryContext.SaveChanges();
                Console.WriteLine("Record successfully deleted");
            }
            else
            {
                Console.WriteLine("Brewery not found");
            }
            breweryMenu.Start();
        }

        public void UpdateBrewery(BreweryMenu breweryMenu)
        {
            Console.WriteLine("Name of beer you would like to delete");
            string Name = Console.ReadLine();

            var breweryToUpdate = _breweryContext.Breweries.FirstOrDefault(b => b.BreweryName == Name);

            if (breweryToUpdate == null)
            {
                Console.WriteLine("Beer with name " + breweryToUpdate + " not found.");
                return;
            }

            string name = Validation.GetStringInput("Brewery Name: ");
            string Location = Validation.GetStringInput("Brewery Location: ");
            Console.WriteLine("Foundation date: ");
            int FoundationDate = int.Parse(Console.ReadLine());

            breweryToUpdate.BreweryName = Name;
            breweryToUpdate.Location = Location;
            breweryToUpdate.FoundationDate = FoundationDate;

            _breweryContext.SaveChanges();

            Console.WriteLine("Brewery with name " + Name + " updated successfully.");
            breweryMenu.Start();
        }

        public List<Brewery> GetAll()
        {
            return _breweryContext.Breweries.ToList();
        }
    }
}

