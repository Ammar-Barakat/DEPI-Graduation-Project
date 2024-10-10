﻿// <auto-generated />
using System;
using DALProject.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DALProject.Data.Migrations
{
    [DbContext(typeof(HMSdbcontext))]
    [Migration("20241010095527_UpdateApointment")]
    partial class UpdateApointment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActiveSubstanceMedication", b =>
                {
                    b.Property<int>("ActiveSubstancesId")
                        .HasColumnType("int");

                    b.Property<int>("MedicationsId")
                        .HasColumnType("int");

                    b.HasKey("ActiveSubstancesId", "MedicationsId");

                    b.HasIndex("MedicationsId");

                    b.ToTable("ActiveSubstanceMedication");
                });

            modelBuilder.Entity("ActiveSubstancePatient", b =>
                {
                    b.Property<int>("ActSbuAllergiesId")
                        .HasColumnType("int");

                    b.Property<int>("PatientshaveAllergyId")
                        .HasColumnType("int");

                    b.HasKey("ActSbuAllergiesId", "PatientshaveAllergyId");

                    b.HasIndex("PatientshaveAllergyId");

                    b.ToTable("ActiveSubstancePatient");
                });

            modelBuilder.Entity("DALProject.model.ActiveSubstance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActiveSubstancesName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ActiveSubstancesName")
                        .IsUnique();

                    b.ToTable("ActiveSubstances");
                });

            modelBuilder.Entity("DALProject.model.ActiveSubstanceInteraction", b =>
                {
                    b.Property<int?>("ActiveSubstanceId1")
                        .HasColumnType("int");

                    b.Property<int?>("ActiveSubstanceId2")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Interaction")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ActiveSubstanceId1", "ActiveSubstanceId2");

                    b.HasIndex("ActiveSubstanceId2");

                    b.ToTable("ActiveSubstanceInteraction");
                });

            modelBuilder.Entity("DALProject.model.Apointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("ApointmentDate")
                        .HasColumnType("date");

                    b.Property<string>("ApointmentStatus")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar");

                    b.Property<TimeOnly?>("ApointmentTime")
                        .HasColumnType("time");

                    b.Property<int>("ClinicId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Examination")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int?>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<int?>("ReceptionistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClinicId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PrescriptionId")
                        .IsUnique()
                        .HasFilter("[PrescriptionId] IS NOT NULL");

                    b.HasIndex("ReceptionistId");

                    b.ToTable("Apointments");
                });

            modelBuilder.Entity("DALProject.model.Clinic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 10L, 10);

                    b.Property<int?>("ClinicSpecializationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClinicSpecializationId");

                    b.ToTable("Clinics");
                });

            modelBuilder.Entity("DALProject.model.ClinicSpecializationLookup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 10L, 10);

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Specialization")
                        .IsUnique();

                    b.ToTable("ClinicsSpecializationLookups");
                });

            modelBuilder.Entity("DALProject.model.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<int?>("ClinicId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("int");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ClinicId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("SpecializationId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("DALProject.model.DoctorScheduleLookup", b =>
                {
                    b.Property<string>("Day")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Day", "DoctorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("DoctorScheduleLookups");
                });

            modelBuilder.Entity("DALProject.model.DoctorSpecializationLookup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("DoctorSpecializationLookup");
                });

            modelBuilder.Entity("DALProject.model.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("ApointmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasComputedColumnSql("GETDATE()");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("char");

                    b.Property<int?>("ReceptionistId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.HasIndex("ReceptionistId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("DALProject.model.Medication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MedName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Medication");
                });

            modelBuilder.Entity("DALProject.model.Nurse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<int?>("ClinicId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ClinicId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("DALProject.model.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DALProject.model.Pharmacist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Pharmacists");
                });

            modelBuilder.Entity("DALProject.model.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int?>("PharmacistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PharmacistId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("DALProject.model.PrescriptionItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ActiveSubstanceId")
                        .HasColumnType("int");

                    b.Property<string>("FullDosage")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PrescriptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActiveSubstanceId")
                        .IsUnique()
                        .HasFilter("[ActiveSubstanceId] IS NOT NULL");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("PrescriptionItem");
                });

            modelBuilder.Entity("DALProject.model.PrescriptionItemMedication", b =>
                {
                    b.Property<string>("MedicationCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("PrescriptionItemId")
                        .HasColumnType("int");

                    b.Property<string>("Dosage")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MedicationId")
                        .HasColumnType("int");

                    b.HasKey("MedicationCode", "PrescriptionItemId");

                    b.HasIndex("MedicationId");

                    b.HasIndex("PrescriptionItemId");

                    b.ToTable("PrescriptionItemMedication");
                });

            modelBuilder.Entity("DALProject.model.Receptionist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Receptionists");
                });

            modelBuilder.Entity("ActiveSubstanceMedication", b =>
                {
                    b.HasOne("DALProject.model.ActiveSubstance", null)
                        .WithMany()
                        .HasForeignKey("ActiveSubstancesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DALProject.model.Medication", null)
                        .WithMany()
                        .HasForeignKey("MedicationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ActiveSubstancePatient", b =>
                {
                    b.HasOne("DALProject.model.ActiveSubstance", null)
                        .WithMany()
                        .HasForeignKey("ActSbuAllergiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DALProject.model.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientshaveAllergyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DALProject.model.ActiveSubstanceInteraction", b =>
                {
                    b.HasOne("DALProject.model.ActiveSubstance", "ActSub1")
                        .WithMany("ActSub1")
                        .HasForeignKey("ActiveSubstanceId1")
                        .IsRequired();

                    b.HasOne("DALProject.model.ActiveSubstance", "ActSub2")
                        .WithMany("ActSub2")
                        .HasForeignKey("ActiveSubstanceId2")
                        .IsRequired();

                    b.Navigation("ActSub1");

                    b.Navigation("ActSub2");
                });

            modelBuilder.Entity("DALProject.model.Apointment", b =>
                {
                    b.HasOne("DALProject.model.Clinic", "Clinic")
                        .WithMany("Apointments")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DALProject.model.Doctor", "Doctor")
                        .WithMany("Apointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DALProject.model.Patient", "Patient")
                        .WithMany("Apointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DALProject.model.Prescription", "Prescription")
                        .WithOne()
                        .HasForeignKey("DALProject.model.Apointment", "PrescriptionId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("DALProject.model.Receptionist", "Receptionist")
                        .WithMany("Apointments")
                        .HasForeignKey("ReceptionistId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Clinic");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Prescription");

                    b.Navigation("Receptionist");
                });

            modelBuilder.Entity("DALProject.model.Clinic", b =>
                {
                    b.HasOne("DALProject.model.ClinicSpecializationLookup", "ClinicSpecilization")
                        .WithMany("Clinic")
                        .HasForeignKey("ClinicSpecializationId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("ClinicSpecilization");
                });

            modelBuilder.Entity("DALProject.model.Doctor", b =>
                {
                    b.HasOne("DALProject.model.Clinic", "Clinic")
                        .WithMany("Doctors")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("DALProject.model.DoctorSpecializationLookup", "DoctorSpecialization")
                        .WithMany("Doctors")
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");

                    b.Navigation("DoctorSpecialization");
                });

            modelBuilder.Entity("DALProject.model.DoctorScheduleLookup", b =>
                {
                    b.HasOne("DALProject.model.Doctor", "Doctor")
                        .WithMany("DoctorScheduleLookups")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DALProject.model.Invoice", b =>
                {
                    b.HasOne("DALProject.model.Apointment", "Apointment")
                        .WithOne("Invoice")
                        .HasForeignKey("DALProject.model.Invoice", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DALProject.model.Receptionist", "Receptionist")
                        .WithMany("invoices")
                        .HasForeignKey("ReceptionistId");

                    b.Navigation("Apointment");

                    b.Navigation("Receptionist");
                });

            modelBuilder.Entity("DALProject.model.Nurse", b =>
                {
                    b.HasOne("DALProject.model.Clinic", "Clinic")
                        .WithMany("Nurses")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("DALProject.model.Prescription", b =>
                {
                    b.HasOne("DALProject.model.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DALProject.model.Pharmacist", "Pharmacist")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PharmacistId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Doctor");

                    b.Navigation("Pharmacist");
                });

            modelBuilder.Entity("DALProject.model.PrescriptionItem", b =>
                {
                    b.HasOne("DALProject.model.ActiveSubstance", "ActiveSubstance")
                        .WithOne("PatrescriptionItem")
                        .HasForeignKey("DALProject.model.PrescriptionItem", "ActiveSubstanceId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("DALProject.model.Prescription", "Prescription")
                        .WithMany("PrescriptionItems")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("ActiveSubstance");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("DALProject.model.PrescriptionItemMedication", b =>
                {
                    b.HasOne("DALProject.model.Medication", "Medication")
                        .WithMany("PrescriptionItemMedications")
                        .HasForeignKey("MedicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DALProject.model.PrescriptionItem", "PrescriptionItem")
                        .WithMany("Medications")
                        .HasForeignKey("PrescriptionItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medication");

                    b.Navigation("PrescriptionItem");
                });

            modelBuilder.Entity("DALProject.model.ActiveSubstance", b =>
                {
                    b.Navigation("ActSub1");

                    b.Navigation("ActSub2");

                    b.Navigation("PatrescriptionItem")
                        .IsRequired();
                });

            modelBuilder.Entity("DALProject.model.Apointment", b =>
                {
                    b.Navigation("Invoice")
                        .IsRequired();
                });

            modelBuilder.Entity("DALProject.model.Clinic", b =>
                {
                    b.Navigation("Apointments");

                    b.Navigation("Doctors");

                    b.Navigation("Nurses");
                });

            modelBuilder.Entity("DALProject.model.ClinicSpecializationLookup", b =>
                {
                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("DALProject.model.Doctor", b =>
                {
                    b.Navigation("Apointments");

                    b.Navigation("DoctorScheduleLookups");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("DALProject.model.DoctorSpecializationLookup", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("DALProject.model.Medication", b =>
                {
                    b.Navigation("PrescriptionItemMedications");
                });

            modelBuilder.Entity("DALProject.model.Patient", b =>
                {
                    b.Navigation("Apointments");
                });

            modelBuilder.Entity("DALProject.model.Pharmacist", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("DALProject.model.Prescription", b =>
                {
                    b.Navigation("PrescriptionItems");
                });

            modelBuilder.Entity("DALProject.model.PrescriptionItem", b =>
                {
                    b.Navigation("Medications");
                });

            modelBuilder.Entity("DALProject.model.Receptionist", b =>
                {
                    b.Navigation("Apointments");

                    b.Navigation("invoices");
                });
#pragma warning restore 612, 618
        }
    }
}
