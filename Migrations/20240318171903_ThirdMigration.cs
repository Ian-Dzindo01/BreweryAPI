using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseAdmin.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Breweries_BreweryId",
                table: "Beers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Breweries",
                table: "Breweries");

            migrationBuilder.DropIndex(
                name: "IX_Beers_BreweryId",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "BreweryId",
                table: "Beers");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Breweries",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "BreweryName1",
                table: "Beers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Breweries",
                table: "Breweries",
                column: "BreweryName");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Breweries_BreweryName1",
                table: "Beers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Breweries",
                table: "Breweries");

            migrationBuilder.DropIndex(
                name: "IX_Beers_BreweryName1",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "BreweryName1",
                table: "Beers");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Breweries",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "BreweryId",
                table: "Beers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Breweries",
                table: "Breweries",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Beers_BreweryId",
                table: "Beers",
                column: "BreweryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Breweries_BreweryId",
                table: "Beers",
                column: "BreweryId",
                principalTable: "Breweries",
                principalColumn: "Id");
        }
    }
}
