using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFBooksOpgave.Migrations
{
    /// <inheritdoc />
    public partial class BookAddedNextInParameters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NextInSeriesId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_NextInSeriesId",
                table: "Books",
                column: "NextInSeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Books_NextInSeriesId",
                table: "Books",
                column: "NextInSeriesId",
                principalTable: "Books",
                principalColumn: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Books_NextInSeriesId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_NextInSeriesId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "NextInSeriesId",
                table: "Books");
        }
    }
}
