using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BreweryAPI.Models
{
    public class Wholesaler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public Dictionary<Beer, int> stock;

        public Wholesaler() {  }

        public Wholesaler(string name, string location)
        {
            Name = name;
            Location = location;
        }
    }
}