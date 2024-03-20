using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseAdmin.Migrations
{
    /// <inheritdoc />
    public partial class Breweries4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "breweryName",
                table: "Beers",
                newName: "BreweryName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BreweryName",
                table: "Beers",
                newName: "breweryName");
        }
    }
}
