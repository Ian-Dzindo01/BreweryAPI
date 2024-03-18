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

        // Navigation property
        public string BreweryName { get; set; }
        
        [ForeignKey("BreweryName")]
        public Brewery Brewery { get; set; }

        public Beer() { }

        public Beer(string name, float size, float abv, string color, string breweryName)
        {
            Name = name;
            Size = size;
            ABV = abv;
            Color = color;
            BreweryName = breweryName;
        }
    }
}
