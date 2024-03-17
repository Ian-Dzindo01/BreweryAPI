using System.Configuration;
using BreweryAPI.Models;
using BreweryAPI.DbHelper;

namespace BreweryAPI.Controllers
{
    public class Controller
    {
        private readonly BreweryContext _breweryContext;

        public Controller(BreweryContext breweryContext)
        {
            _breweryContext = breweryContext;
        }

        public void AddBeer()
        {
            Console.WriteLine("Name of beer: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Size: ");
            float Size = float.Parse(Console.ReadLine());

            Console.WriteLine("ABV: ");
            float ABV = float.Parse(Console.ReadLine());

            Console.WriteLine("Beer color: ");
            string Color = Console.ReadLine();

            Console.WriteLine("Brewery name: ");
            string Brewery = Console.ReadLine();

            Beer newBeer = new Beer(Name, Size, ABV, Color, Brewery);

            _breweryContext.Beers.Add(newBeer);
            _breweryContext.SaveChanges();
        }

        public void DeleteBeer()
        {
            Console.WriteLine("Name of beer you would like to delete");
            string Name = Console.ReadLine();

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
        }
    }
}
