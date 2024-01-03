using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheWarehouse.Migrations
{
    /// <inheritdoc />
    public partial class LogDatetime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStamp",
                table: "Logs",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Logs");
        }
    }
}
