using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diet.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ChangeuserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Kilo",
                table: "Users",
                newName: "Weight");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "Users",
                newName: "Kilo");
        }
    }
}
