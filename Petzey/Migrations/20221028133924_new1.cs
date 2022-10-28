using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petzey.Migrations
{
    public partial class new1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_DoctorAppointments_DoctorAppointmentId1",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_PatientAppointments_PatientAppointmentId1",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_ReceptionistAppointments_ReceptionistAppointmentId1",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DoctorAppointmentId1",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_PatientAppointmentId1",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_ReceptionistAppointmentId1",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DoctorAppointmentId1",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientAppointmentId1",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "ReceptionistAppointmentId1",
                table: "Patients");

            migrationBuilder.AlterColumn<string>(
                name: "ReceptionistAppointmentId",
                table: "Patients",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PatientAppointmentId",
                table: "Patients",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DoctorAppointmentId",
                table: "Patients",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorAppointmentId",
                table: "Patients",
                column: "DoctorAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PatientAppointmentId",
                table: "Patients",
                column: "PatientAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ReceptionistAppointmentId",
                table: "Patients",
                column: "ReceptionistAppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_DoctorAppointments_DoctorAppointmentId",
                table: "Patients",
                column: "DoctorAppointmentId",
                principalTable: "DoctorAppointments",
                principalColumn: "DoctorAppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_PatientAppointments_PatientAppointmentId",
                table: "Patients",
                column: "PatientAppointmentId",
                principalTable: "PatientAppointments",
                principalColumn: "PatientAppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_ReceptionistAppointments_ReceptionistAppointmentId",
                table: "Patients",
                column: "ReceptionistAppointmentId",
                principalTable: "ReceptionistAppointments",
                principalColumn: "ReceptionistAppointmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_DoctorAppointments_DoctorAppointmentId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_PatientAppointments_PatientAppointmentId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_ReceptionistAppointments_ReceptionistAppointmentId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DoctorAppointmentId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_PatientAppointmentId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_ReceptionistAppointmentId",
                table: "Patients");

            migrationBuilder.AlterColumn<int>(
                name: "ReceptionistAppointmentId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PatientAppointmentId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoctorAppointmentId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorAppointmentId1",
                table: "Patients",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientAppointmentId1",
                table: "Patients",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceptionistAppointmentId1",
                table: "Patients",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorAppointmentId1",
                table: "Patients",
                column: "DoctorAppointmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PatientAppointmentId1",
                table: "Patients",
                column: "PatientAppointmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ReceptionistAppointmentId1",
                table: "Patients",
                column: "ReceptionistAppointmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_DoctorAppointments_DoctorAppointmentId1",
                table: "Patients",
                column: "DoctorAppointmentId1",
                principalTable: "DoctorAppointments",
                principalColumn: "DoctorAppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_PatientAppointments_PatientAppointmentId1",
                table: "Patients",
                column: "PatientAppointmentId1",
                principalTable: "PatientAppointments",
                principalColumn: "PatientAppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_ReceptionistAppointments_ReceptionistAppointmentId1",
                table: "Patients",
                column: "ReceptionistAppointmentId1",
                principalTable: "ReceptionistAppointments",
                principalColumn: "ReceptionistAppointmentId");
        }
    }
}
