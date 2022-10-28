using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petzey.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Appointments_AppointmentId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_AppointmentId",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "AppointmentId",
                table: "Patients",
                newName: "ReceptionistAppointmentId");

            migrationBuilder.AddColumn<int>(
                name: "DoctorAppointmentId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DoctorAppointmentId1",
                table: "Patients",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientAppointmentId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "DoctorAppointmentId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DoctorAppointmentId1",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientAppointmentId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientAppointmentId1",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "ReceptionistAppointmentId1",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "ReceptionistAppointmentId",
                table: "Patients",
                newName: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AppointmentId",
                table: "Patients",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Appointments_AppointmentId",
                table: "Patients",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
