using Microsoft.EntityFrameworkCore.Migrations;

namespace SmoothBoardStylersAppKt3Kt4.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Leverbaar",
                table: "Surfboards",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Nieuwsbrief",
                table: "Contacten",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Leverbaar",
                table: "Surfboards");

            migrationBuilder.DropColumn(
                name: "Nieuwsbrief",
                table: "Contacten");
        }
    }
}
