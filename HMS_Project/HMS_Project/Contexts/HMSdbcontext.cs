﻿using HMS_Project.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace HMS_Project.Contexts
{
    internal class HMSdbcontext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AM9IO3H\\MSSQLSERVER01;Database=HMS02;Trusted_Connection=True;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Prescription>()
                .HasOne(p => p.Pharmacy)
                .WithMany(p => p.Prescriptions)
                .OnDelete(DeleteBehavior.NoAction);
            
                     
        }

        //public virtual DbSet<Patient> Patients { get; set; } // patient table inherit from User (TPC)
        //public virtual DbSet<MedicalRecord> MedicalRecords { get; set; }
        //public virtual DbSet<Invoice> Invoices { get; set; }
        //public virtual DbSet<Apointment> Apointments { get; set; }
        //public virtual DbSet<Reception> Reception { get; set; }
        //public virtual DbSet<Receptionist> Receptionists { get; set; }


        public virtual DbSet<ActiveSubstance> ActiveSubstances { get; set; }
        public virtual DbSet<Medication> Medication { get; set; }
        public virtual DbSet<Pharmacy> Pharmacies { get; set; }
        public virtual DbSet<Pharmacist> Pharmacists { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }

    }
}
