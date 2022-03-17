using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMangaLibrary.Data.Migrations
{
    public partial class UpdatedDatabaseEight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manga_Mangaka_AuthorID",
                table: "Manga");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorID",
                table: "Manga",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Manga_Mangaka_AuthorID",
                table: "Manga",
                column: "AuthorID",
                principalTable: "Mangaka",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manga_Mangaka_AuthorID",
                table: "Manga");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorID",
                table: "Manga",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Manga_Mangaka_AuthorID",
                table: "Manga",
                column: "AuthorID",
                principalTable: "Mangaka",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
