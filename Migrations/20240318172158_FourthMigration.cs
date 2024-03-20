using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseAdmin.Migrations
{
    /// <inheritdoc />
    public partial class FourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Breweries_BreweryName1",
                table: "Beers");

            migrationBuilder.DropIndex(
                name: "IX_Beers_BreweryName1",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "BreweryName1",
                table: "Beers");

            migrationBuilder.CreateIndex(
                name: "IX_Beers_BreweryName",
                table: "Beers",
                column: "BreweryName");

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Breweries_BreweryName",
                table: "Beers",
                column: "BreweryName",
                principalTable: "Breweries",
                principalColumn: "BreweryName",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Breweries_BreweryName",
                table: "Beers");

            migrationBuilder.DropIndex(
                name: "IX_Beers_BreweryName",
                table: "Beers");

            migrationBuilder.AddColumn<string>(
                name: "BreweryName1",
                table: "Beers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Beers_BreweryName1",
                table: "Beers",
                column: "BreweryName1");

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Breweries_BreweryName1",
                table: "Beers",
                column: "BreweryName1",
                principalTable: "Breweries",
                principalColumn: "BreweryName");
        }
    }
}
