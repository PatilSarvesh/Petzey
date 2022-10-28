﻿using Microsoft.EntityFrameworkCore;
using Petzey.Model.Entities;

namespace Petzey.Model.Data
{
    public class PetzeyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=PetzeyCatalogDb;Integrated Security=True");
        }

        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetOwner> PetOwners { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Vital> Vitals { get; set; }
    }
}