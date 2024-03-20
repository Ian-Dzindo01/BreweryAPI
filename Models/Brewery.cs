using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BreweryAPI.Models
{
    public class Brewery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string BreweryName { get; set; }
        public string Location { get; set; }
        public int FoundationDate { get; set; }

        // Navigation property
        public ICollection<Beer> Beers { get; set; }

        public Brewery() { }

        public Brewery(string name, string location, int foundationDate)
        {
            BreweryName = name;
            Location = location;
            FoundationDate = foundationDate;
        }
    }
}