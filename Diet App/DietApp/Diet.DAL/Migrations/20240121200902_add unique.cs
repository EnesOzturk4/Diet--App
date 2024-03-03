using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diet.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addunique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MealDietRecords_NutrientId_RepastId",
                table: "MealDietRecords",
                columns: new[] { "NutrientId", "RepastId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MealDietRecords_NutrientId_RepastId",
                table: "MealDietRecords");
        }
    }
}
