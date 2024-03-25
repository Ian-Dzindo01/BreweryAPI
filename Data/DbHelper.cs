using Microsoft.EntityFrameworkCore;
using BreweryAPI.Models;
using System.Configuration;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace BreweryAPI.DbHelper
{
    public class BreweryContext : DbContext
    {
        string connectionString = ConfigurationManager.AppSettings["connectionString"];
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Brewery> Breweries { get; set; }
        public DbSet<Wholesaler> Wholesalers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }

        public void ClearDatabase()
        {
            Database.ExecuteSqlRaw("DELETE FROM Beers");
            Database.ExecuteSqlRaw("DELETE FROM Breweries");
            Database.ExecuteSqlRaw("DELETE FROM Wholesalers");
            Database.ExecuteSqlRaw("DELETE FROM __EFMigrationsHistory");

        }
        public void ReadInFromCsv()
        {
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null,
                MissingFieldFound = null
            };


            using (var reader = new StreamReader("Data/wholesalers.csv"))
            using (var csv = new CsvReader(reader, csvConfig))
            {
                var records = csv.GetRecords<Wholesaler>().ToList();
                Wholesalers.AddRange(records);
                SaveChanges();
            }

            using (var reader = new StreamReader("Data/beers.csv"))
            using (var csv = new CsvReader(reader, csvConfig))
            {
                var records = csv.GetRecords<Beer>().ToList();
                Beers.AddRange(records);
                SaveChanges();
            }

            using (var reader = new StreamReader("Data/breweries.csv"))
            using (var csv = new CsvReader(reader, csvConfig))
            {
                var records = csv.GetRecords<Brewery>().ToList();
                Breweries.AddRange(records);
                SaveChanges();
            }
        }
    }
}