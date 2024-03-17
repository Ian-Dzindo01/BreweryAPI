using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BreweryAPI.Models
{
    public class Brewery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Location { get; set; }
        public int FoundationDate { get; set; }

        public Brewery() {  }


        public Brewery(string name, string location, int foundationDate)
        {
            Name = name;
            Location = location;
            FoundationDate = foundationDate;
        }
    }
}