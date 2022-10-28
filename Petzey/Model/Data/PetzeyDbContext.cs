using Microsoft.EntityFrameworkCore;
using Petzey.Model.Entities;

namespace Petzey.Model.Data
{
    public class PetzeyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=PetzeyDbProject;Integrated Security=True");
        }

        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<DoctorAppointment> DoctorAppointments { get; set; }
        public DbSet<PatientAppointment> PatientAppointments { get; set; }
        public DbSet<ReceptionistAppointment> ReceptionistAppointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetOwner> PetOwners { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Vital> Vitals { get; set; }
    }
}
