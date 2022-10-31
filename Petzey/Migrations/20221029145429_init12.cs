using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petzey.Migrations
{
    public partial class init12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Symptoms");

            migrationBuilder.RenameColumn(
                name: "SymptomId",
                table: "Appointments",
                newName: "PetIssueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PetIssueId",
                table: "Appointments",
                newName: "SymptomId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Symptoms",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
