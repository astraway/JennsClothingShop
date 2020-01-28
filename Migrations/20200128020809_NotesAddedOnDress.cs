using Microsoft.EntityFrameworkCore.Migrations;

namespace JennsClothingShop.Migrations
{
    public partial class NotesAddedOnDress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Dresses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Dresses");
        }
    }
}
