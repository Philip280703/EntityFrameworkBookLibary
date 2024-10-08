﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFBooksOpgave.Migrations
{
    /// <inheritdoc />
    public partial class BookAddedPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Books",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

                   }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Books");

           
        }
    }
}
