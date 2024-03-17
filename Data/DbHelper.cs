using Microsoft.EntityFrameworkCore;
using BreweryAPI.Models;
using System.Configuration;
using System;

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
            optionsBuilder.UseSqlite($"Data Source={connectionString}");
        }
    }
}