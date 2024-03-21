using BreweryAPI.Models;
using System.Reflection;

namespace BreweryAPI.OutputHelper
{
    public static class ObjectHelper
    {
        public static void PrintTable<T>(List<T> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (var item in list)
            {
                Console.WriteLine("----------");
                foreach (var prop in properties)
                {
                    Console.WriteLine($"{prop.Name}: {prop.GetValue(item)}");
                }
                Console.WriteLine("----------");
            }
        }
    }
}