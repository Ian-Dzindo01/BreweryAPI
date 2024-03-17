using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BreweryAPI.Models
{
    public class Beer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public float Size { get; set; }
        public float ABV { get; set; }
        public string Color { get; set; }
        public string Brewery { get; set; }

        public Beer() {  }


        public Beer(string name, float size, float abv, string color, string brewery)
        {
            Name = name;
            Size = size;
            ABV = abv;
            Color = color;
            Brewery = brewery;
        }
    }
}