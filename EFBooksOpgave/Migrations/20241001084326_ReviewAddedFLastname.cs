using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFBooksOpgave.Migrations
{
    /// <inheritdoc />
    public partial class ReviewAddedFLastname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Reviews");
        }
    }
}
