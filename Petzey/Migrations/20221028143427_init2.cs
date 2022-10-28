using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petzey.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorAppointments_PetOwners_PetOwnerId",
                table: "DoctorAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAppointments_Doctors_DoctorId",
                table: "PatientAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_DoctorAppointments_DoctorAppointmentId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_PatientAppointments_PatientAppointmentId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_ReceptionistAppointments_ReceptionistAppointmentId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetOwners_PetOwnerId",
                table: "Pets");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceptionistAppointments_Doctors_DoctorId",
                table: "ReceptionistAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceptionistAppointments_PetOwners_PetOwnerId",
                table: "ReceptionistAppointments");

            migrationBuilder.DropIndex(
                name: "IX_ReceptionistAppointments_DoctorId",
                table: "ReceptionistAppointments");

            migrationBuilder.DropIndex(
                name: "IX_ReceptionistAppointments_PetOwnerId",
                table: "ReceptionistAppointments");

            migrationBuilder.DropIndex(
                name: "IX_Pets_PetOwnerId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DoctorAppointmentId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_PatientAppointmentId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_ReceptionistAppointmentId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_PatientAppointments_DoctorId",
                table: "PatientAppointments");

            migrationBuilder.DropIndex(
                name: "IX_DoctorAppointments_PetOwnerId",
                table: "DoctorAppointments");

            migrationBuilder.DropColumn(
                name: "PetOwnerId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Appointments");

            migrationBuilder.AlterColumn<int>(
                name: "ReceptionistAppointmentId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PatientAppointmentId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoctorAppointmentId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserNameId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserNameId",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "PetOwnerId",
                table: "Pets",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReceptionistAppointmentId",
                table: "Patients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PatientAppointmentId",
                table: "Patients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorAppointmentId",
                table: "Patients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReceptionistAppointments_DoctorId",
                table: "ReceptionistAppointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceptionistAppointments_PetOwnerId",
                table: "ReceptionistAppointments",
                column: "PetOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_PetOwnerId",
                table: "Pets",
                column: "PetOwnerId");

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

            migrationBuilder.CreateIndex(
                name: "IX_PatientAppointments_DoctorId",
                table: "PatientAppointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorAppointments_PetOwnerId",
                table: "DoctorAppointments",
                column: "PetOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorAppointments_PetOwners_PetOwnerId",
                table: "DoctorAppointments",
                column: "PetOwnerId",
                principalTable: "PetOwners",
                principalColumn: "PetOwnerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAppointments_Doctors_DoctorId",
                table: "PatientAppointments",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetOwners_PetOwnerId",
                table: "Pets",
                column: "PetOwnerId",
                principalTable: "PetOwners",
                principalColumn: "PetOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceptionistAppointments_Doctors_DoctorId",
                table: "ReceptionistAppointments",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceptionistAppointments_PetOwners_PetOwnerId",
                table: "ReceptionistAppointments",
                column: "PetOwnerId",
                principalTable: "PetOwners",
                principalColumn: "PetOwnerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
