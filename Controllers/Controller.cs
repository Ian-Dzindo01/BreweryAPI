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
            string Name = GetNameInput("Name of beer: ");

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

        // Move to Validation class
        public static string GetNameInput(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();

            if (name.Length > 40)
            {
                Console.WriteLine("Too many characters. Try again.");
                return GetNameInput(message); // Corrected
            }

            return name;
        }

        public static string GetFloatInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (!float.TryParse(input, out float result))
            {
                Console.WriteLine("Invalid input. Please enter a valid float number.");
                return GetFloatInput(message);
            }

            return input;
        }
    }
}

