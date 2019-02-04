using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantPluralSight.Migrations
{
    public partial class ettan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cuisine",
                table: "Restaurants",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Cuisine",
                table: "Restaurants",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
