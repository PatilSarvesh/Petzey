using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petzey.Migrations
{
    public partial class init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PetId",
                table: "PetOwners");

            migrationBuilder.AddColumn<int>(
                name: "PetOwnerId",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PetOwnerId",
                table: "Pets");

            migrationBuilder.AddColumn<int>(
                name: "PetId",
                table: "PetOwners",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
