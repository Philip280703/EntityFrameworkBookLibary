using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFBooksOpgave.Migrations
{
    /// <inheritdoc />
    public partial class BooksAddedNumOfPages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumOfPages",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumOfPages",
                table: "Books");
        }
    }
}
