namespace BreweryAPI.Runnin
{
    public class Validation
    {
        public static string GetStringInput(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();

            if (name.Length > 40)
            {
                Console.WriteLine("Too many characters. Try again.");
                return GetStringInput(message); // Corrected
            }

            return name;
        }
        public static float GetFloatInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (!float.TryParse(input, out float result))
            {
                Console.WriteLine("Invalid input. Please enter a valid float number.");
                return GetFloatInput(message);
            }

            return float.Parse(input);
        }
    }
}