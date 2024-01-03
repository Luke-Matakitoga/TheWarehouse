using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheWarehouse.Migrations
{
    /// <inheritdoc />
    public partial class UserAuthsMultiple : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserAuths_UserId",
                table: "UserAuths");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuths_UserId",
                table: "UserAuths",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserAuths_UserId",
                table: "UserAuths");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuths_UserId",
                table: "UserAuths",
                column: "UserId",
                unique: true);
        }
    }
}
