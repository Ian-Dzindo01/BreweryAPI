using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseAdmin.Migrations
{
    /// <inheritdoc />
    public partial class Breweries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Breweries_BreweryName",
                table: "Beers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Breweries",
                table: "Breweries");

            migrationBuilder.DropIndex(
                name: "IX_Beers_BreweryName",
                table: "Beers");

            migrationBuilder.RenameColumn(
                name: "BreweryName",
                table: "Breweries",
                newName: "Name");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Breweries",
                newName: "BreweryName");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Breweries",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Breweries",
                table: "Breweries",
                column: "BreweryName");

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
    }
}
