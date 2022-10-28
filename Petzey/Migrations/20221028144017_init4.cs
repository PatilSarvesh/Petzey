using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petzey.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Symptoms_SymptomId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_SymptomId",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "PetId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PetId",
                table: "Appointments");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_SymptomId",
                table: "Appointments",
                column: "SymptomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Symptoms_SymptomId",
                table: "Appointments",
                column: "SymptomId",
                principalTable: "Symptoms",
                principalColumn: "SymptomId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
