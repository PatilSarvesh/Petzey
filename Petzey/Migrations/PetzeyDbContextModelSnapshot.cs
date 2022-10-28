﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Petzey.Model.Data;

#nullable disable

namespace Petzey.Migrations
{
    [DbContext(typeof(PetzeyDbContext))]
    partial class PetzeyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Petzey.Model.Entities.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<string>("ReasonForVisit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SymptomId")
                        .HasColumnType("int");

                    b.Property<int>("User")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("PetId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Clinic", b =>
                {
                    b.Property<int>("ClinicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClinicId"), 1L, 1);

                    b.Property<string>("ClinicAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClinicId");

                    b.ToTable("Clinics");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<int>("ClinicId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NPINumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciality")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.HasIndex("ClinicId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Petzey.Model.Entities.DoctorAppointment", b =>
                {
                    b.Property<string>("DoctorAppointmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<int>("PetOwnerId")
                        .HasColumnType("int");

                    b.HasKey("DoctorAppointmentId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("PetOwnerId");

                    b.ToTable("DoctorAppointments");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicineId"), 1L, 1);

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("MedicineId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"), 1L, 1);

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<int>("VitalId")
                        .HasColumnType("int");

                    b.HasKey("PatientId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("TestId");

                    b.HasIndex("VitalId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Petzey.Model.Entities.PatientAppointment", b =>
                {
                    b.Property<string>("PatientAppointmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.HasKey("PatientAppointmentId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.ToTable("PatientAppointments");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PetId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PetOwnerId")
                        .HasColumnType("int");

                    b.Property<string>("petName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("species")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PetId");

                    b.HasIndex("PetOwnerId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("Petzey.Model.Entities.PetOwner", b =>
                {
                    b.Property<int>("PetOwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PetOwnerId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MobileNo")
                        .HasColumnType("int");

                    b.Property<string>("ParentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.HasKey("PetOwnerId");

                    b.ToTable("PetOwners");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("MedicineId");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("Petzey.Model.Entities.ReceptionistAppointment", b =>
                {
                    b.Property<string>("ReceptionistAppointmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PetOwnerId")
                        .HasColumnType("int");

                    b.HasKey("ReceptionistAppointmentId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PetOwnerId");

                    b.ToTable("ReceptionistAppointments");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Symptom", b =>
                {
                    b.Property<int>("SymptomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SymptomId"), 1L, 1);

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SymptomName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SymptomId");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Symptoms");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Vital", b =>
                {
                    b.Property<int>("VitalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VitalId"), 1L, 1);

                    b.Property<int>("BP")
                        .HasColumnType("int");

                    b.Property<int>("HeartRate")
                        .HasColumnType("int");

                    b.Property<int>("Temperature")
                        .HasColumnType("int");

                    b.HasKey("VitalId");

                    b.ToTable("Vitals");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Appointment", b =>
                {
                    b.HasOne("Petzey.Model.Entities.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Doctor", b =>
                {
                    b.HasOne("Petzey.Model.Entities.Clinic", "Clinic")
                        .WithMany()
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("Petzey.Model.Entities.DoctorAppointment", b =>
                {
                    b.HasOne("Petzey.Model.Entities.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId");

                    b.HasOne("Petzey.Model.Entities.PetOwner", "PetOwner")
                        .WithMany()
                        .HasForeignKey("PetOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("PetOwner");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Patient", b =>
                {
                    b.HasOne("Petzey.Model.Entities.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petzey.Model.Entities.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petzey.Model.Entities.Vital", "Vital")
                        .WithMany()
                        .HasForeignKey("VitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("Test");

                    b.Navigation("Vital");
                });

            modelBuilder.Entity("Petzey.Model.Entities.PatientAppointment", b =>
                {
                    b.HasOne("Petzey.Model.Entities.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId");

                    b.HasOne("Petzey.Model.Entities.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Pet", b =>
                {
                    b.HasOne("Petzey.Model.Entities.PetOwner", "PetOwner")
                        .WithMany("Pets")
                        .HasForeignKey("PetOwnerId");

                    b.Navigation("PetOwner");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Prescription", b =>
                {
                    b.HasOne("Petzey.Model.Entities.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petzey.Model.Entities.Patient", null)
                        .WithMany("Prescription")
                        .HasForeignKey("PatientId");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("Petzey.Model.Entities.ReceptionistAppointment", b =>
                {
                    b.HasOne("Petzey.Model.Entities.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId");

                    b.HasOne("Petzey.Model.Entities.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petzey.Model.Entities.PetOwner", "PetOwner")
                        .WithMany()
                        .HasForeignKey("PetOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("Doctor");

                    b.Navigation("PetOwner");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Symptom", b =>
                {
                    b.HasOne("Petzey.Model.Entities.Appointment", null)
                        .WithMany("Symptom")
                        .HasForeignKey("AppointmentId");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Appointment", b =>
                {
                    b.Navigation("Symptom");
                });

            modelBuilder.Entity("Petzey.Model.Entities.Patient", b =>
                {
                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("Petzey.Model.Entities.PetOwner", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
