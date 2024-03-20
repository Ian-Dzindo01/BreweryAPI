using BreweryAPI.Models;
using BreweryAPI.DbHelper;
using BreweryAPI.Runnin;
using BreweryAPI.Menus;

namespace BreweryAPI.Controllers
{
    public class BeerController
    {
        private readonly BreweryContext _breweryContext;

        public BeerController(BreweryContext breweryContext)
        {
            _breweryContext = breweryContext;
        }

        public void AddBeer(BeerMenu beerMenu)
        {
            string Name = Validation.GetStringInput("Name of beer: ");

            float Size = Validation.GetFloatInput("Size: ");

            float ABV = Validation.GetFloatInput("ABV: ");

            string Color = Validation.GetStringInput("Beer color: ");

            string Brewery = Validation.GetStringInput("Brewery name: ");

            Beer newBeer = new Beer(Name, Size, ABV, Color, Brewery);

            _breweryContext.Beers.Add(newBeer);
            _breweryContext.SaveChanges();
            beerMenu.Start();
        }

        public void DeleteBeer(BeerMenu beerMenu)
        {
            string Name = Validation.GetStringInput("Name of beer you would like to delete");

            var beerToDelete = _breweryContext.Beers.FirstOrDefault(b => b.Name == Name);

            if (beerToDelete != null)
            {
                _breweryContext.Beers.Remove(beerToDelete);
                _breweryContext.SaveChanges();
                Console.WriteLine("Record successfully deleted");
            }
            else
            {
                Console.WriteLine("Beer not found");
            }
            
            beerMenu.Start();
        }

        public void UpdateBeer(BeerMenu beerMenu)
        {
            Console.WriteLine("Name of beer you would like to delete");
            string Name = Console.ReadLine();

            var beerToUpdate = _breweryContext.Beers.FirstOrDefault(b => b.Name == Name);

            if (beerToUpdate == null)
            {
                Console.WriteLine("Beer with name " + beerToUpdate + " not found.");
                return;
            }

            float Size = Validation.GetFloatInput("Size: ");

            float ABV = Validation.GetFloatInput("ABV: ");

            string Color = Validation.GetStringInput("Beer color: ");

            beerToUpdate.Name = Name;
            beerToUpdate.Size = Size;
            beerToUpdate.ABV = ABV;
            beerToUpdate.Color = Color;

            _breweryContext.SaveChanges();

            Console.WriteLine("Beer with name " + Name + " updated successfully.");
            beerMenu.Start();
        }
    }
}

