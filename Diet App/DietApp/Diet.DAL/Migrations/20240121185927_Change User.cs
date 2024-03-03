using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diet.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repasts_Users_UserId",
                table: "Repasts");

            migrationBuilder.DropIndex(
                name: "IX_Repasts_UserId",
                table: "Repasts");

            migrationBuilder.DropIndex(
                name: "IX_MealDietRecords_UserId",
                table: "MealDietRecords");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Repasts");

            migrationBuilder.CreateIndex(
                name: "IX_MealDietRecords_UserId",
                table: "MealDietRecords",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MealDietRecords_UserId",
                table: "MealDietRecords");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Repasts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Repasts_UserId",
                table: "Repasts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MealDietRecords_UserId",
                table: "MealDietRecords",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Repasts_Users_UserId",
                table: "Repasts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
