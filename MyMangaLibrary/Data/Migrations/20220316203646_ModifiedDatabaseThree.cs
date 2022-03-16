using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMangaLibrary.Data.Migrations
{
    public partial class ModifiedDatabaseThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Manga",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Manga");
        }
    }
}
