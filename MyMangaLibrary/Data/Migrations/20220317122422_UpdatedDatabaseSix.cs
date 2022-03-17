using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMangaLibrary.Data.Migrations
{
    public partial class UpdatedDatabaseSix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "Manga",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Manga_AuthorID",
                table: "Manga",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Manga_Mangaka_AuthorID",
                table: "Manga",
                column: "AuthorID",
                principalTable: "Mangaka",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manga_Mangaka_AuthorID",
                table: "Manga");

            migrationBuilder.DropIndex(
                name: "IX_Manga_AuthorID",
                table: "Manga");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Manga");
        }
    }
}
