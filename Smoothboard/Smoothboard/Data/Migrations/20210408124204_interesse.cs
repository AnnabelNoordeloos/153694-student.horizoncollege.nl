using Microsoft.EntityFrameworkCore.Migrations;

namespace Smoothboard.Data.Migrations
{
    public partial class interesse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Surfboards_MateriaalId",
                table: "Surfboards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Faq",
                table: "Faq");

            migrationBuilder.RenameTable(
                name: "Faq",
                newName: "FAQs");

            migrationBuilder.AddColumn<bool>(
                name: "Behandeld",
                table: "Interesses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ContactId1",
                table: "Interesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Nieuwsbrief",
                table: "Gebruikers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FAQs",
                table: "FAQs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Surfboards_MateriaalId",
                table: "Surfboards",
                column: "MateriaalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Interesses_ContactId1",
                table: "Interesses",
                column: "ContactId1");

            migrationBuilder.CreateIndex(
                name: "IX_Interesses_SurfboardId",
                table: "Interesses",
                column: "SurfboardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interesses_Contacten_ContactId1",
                table: "Interesses",
                column: "ContactId1",
                principalTable: "Contacten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Interesses_Surfboards_SurfboardId",
                table: "Interesses",
                column: "SurfboardId",
                principalTable: "Surfboards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interesses_Contacten_ContactId1",
                table: "Interesses");

            migrationBuilder.DropForeignKey(
                name: "FK_Interesses_Surfboards_SurfboardId",
                table: "Interesses");

            migrationBuilder.DropIndex(
                name: "IX_Surfboards_MateriaalId",
                table: "Surfboards");

            migrationBuilder.DropIndex(
                name: "IX_Interesses_ContactId1",
                table: "Interesses");

            migrationBuilder.DropIndex(
                name: "IX_Interesses_SurfboardId",
                table: "Interesses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FAQs",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "Behandeld",
                table: "Interesses");

            migrationBuilder.DropColumn(
                name: "ContactId1",
                table: "Interesses");

            migrationBuilder.DropColumn(
                name: "Nieuwsbrief",
                table: "Gebruikers");

            migrationBuilder.RenameTable(
                name: "FAQs",
                newName: "Faq");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Faq",
                table: "Faq",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Surfboards_MateriaalId",
                table: "Surfboards",
                column: "MateriaalId");
        }
    }
}
