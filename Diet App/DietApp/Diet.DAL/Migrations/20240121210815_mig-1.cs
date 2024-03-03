using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diet.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MealDietRecords_NutrientId_RepastId",
                table: "MealDietRecords");

            migrationBuilder.DropIndex(
                name: "IX_MealDietRecords_UserId",
                table: "MealDietRecords");

            migrationBuilder.CreateIndex(
                name: "IX_MealDietRecords_NutrientId",
                table: "MealDietRecords",
                column: "NutrientId");

            migrationBuilder.CreateIndex(
                name: "IX_MealDietRecords_UserId_NutrientId_RepastId",
                table: "MealDietRecords",
                columns: new[] { "UserId", "NutrientId", "RepastId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MealDietRecords_NutrientId",
                table: "MealDietRecords");

            migrationBuilder.DropIndex(
                name: "IX_MealDietRecords_UserId_NutrientId_RepastId",
                table: "MealDietRecords");

            migrationBuilder.CreateIndex(
                name: "IX_MealDietRecords_NutrientId_RepastId",
                table: "MealDietRecords",
                columns: new[] { "NutrientId", "RepastId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MealDietRecords_UserId",
                table: "MealDietRecords",
                column: "UserId");
        }
    }
}
