using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diet.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MealDietRecords_NutrientId",
                table: "MealDietRecords");

            migrationBuilder.DropIndex(
                name: "IX_MealDietRecords_RepastId",
                table: "MealDietRecords");

            migrationBuilder.CreateIndex(
                name: "IX_MealDietRecords_RepastId",
                table: "MealDietRecords",
                column: "RepastId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MealDietRecords_RepastId",
                table: "MealDietRecords");

            migrationBuilder.CreateIndex(
                name: "IX_MealDietRecords_NutrientId",
                table: "MealDietRecords",
                column: "NutrientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MealDietRecords_RepastId",
                table: "MealDietRecords",
                column: "RepastId",
                unique: true);
        }
    }
}
