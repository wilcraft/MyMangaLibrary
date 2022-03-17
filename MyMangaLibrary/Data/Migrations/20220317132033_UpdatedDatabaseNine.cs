using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMangaLibrary.Data.Migrations
{
    public partial class UpdatedDatabaseNine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manga_Mangaka_AuthorID",
                table: "Manga");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Manga",
                newName: "MangakaID");

            migrationBuilder.RenameIndex(
                name: "IX_Manga_AuthorID",
                table: "Manga",
                newName: "IX_Manga_MangakaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Manga_Mangaka_MangakaID",
                table: "Manga",
                column: "MangakaID",
                principalTable: "Mangaka",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manga_Mangaka_MangakaID",
                table: "Manga");

            migrationBuilder.RenameColumn(
                name: "MangakaID",
                table: "Manga",
                newName: "AuthorID");

            migrationBuilder.RenameIndex(
                name: "IX_Manga_MangakaID",
                table: "Manga",
                newName: "IX_Manga_AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Manga_Mangaka_AuthorID",
                table: "Manga",
                column: "AuthorID",
                principalTable: "Mangaka",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
