using Microsoft.EntityFrameworkCore;
using BreweryAPI.Models;
using System.Configuration;

namespace BreweryAPI.DbHelper
{
    public class BreweryContext : DbContext
    {
        string connectionString = ConfigurationManager.AppSettings["connectionString"];
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Brewery> Breweries { get; set; }
        public DbSet<Wholesaler> Wholesalers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Beer>()
        //         .HasOne(b => b.Brewery)
        //         .WithMany(b => b.Beers)
        //         .HasForeignKey(b => b.BreweryName);
        // }
    }
}