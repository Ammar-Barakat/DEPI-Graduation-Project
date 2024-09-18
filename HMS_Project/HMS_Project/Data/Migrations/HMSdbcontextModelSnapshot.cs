﻿// <auto-generated />
using System;
using HMS_Project.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HMS_Project.Migrations
{
    [DbContext(typeof(HMSdbcontext))]
    partial class HMSdbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActiveSubstanceMedication", b =>
                {
                    b.Property<int>("ActiveSubstancesId")
                        .HasColumnType("int");

                    b.Property<string>("MedicationCodesMedicationCode")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ActiveSubstancesId", "MedicationCodesMedicationCode");

                    b.HasIndex("MedicationCodesMedicationCode");

                    b.ToTable("ActiveSubstanceMedication");
                });

            modelBuilder.Entity("ActiveSubstancePrescription", b =>
                {
                    b.Property<int>("ActiveSubstancesId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionsPrescriptionID")
                        .HasColumnType("int");

                    b.HasKey("ActiveSubstancesId", "PrescriptionsPrescriptionID");

                    b.HasIndex("PrescriptionsPrescriptionID");

                    b.ToTable("ActiveSubstancePrescription");
                });

            modelBuilder.Entity("HMS_Project.model.ActiveSubstance", b =>
                {
                    b.Property<int>("ActiveSubstancesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActiveSubstancesId"));

                    b.Property<string>("ActiveSubstancesName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ActiveSubstancesId");

                    b.HasIndex("ActiveSubstancesName")
                        .IsUnique();

                    b.ToTable("ActiveSubstance");
                });

            modelBuilder.Entity("HMS_Project.model.ActiveSubstanceInteraction", b =>
                {
                    b.Property<int>("ActiveSubstanceId1")
                        .HasColumnType("int");

                    b.Property<int>("ActiveSubstanceId2")
                        .HasColumnType("int");

                    b.Property<string>("Interaction")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ActiveSubstanceId1", "ActiveSubstanceId2");

                    b.HasIndex("ActiveSubstanceId2");

                    b.ToTable("ActiveSubstanceInteraction");
                });

            modelBuilder.Entity("HMS_Project.model.ActiveSubstancesSideEffect", b =>
                {
                    b.Property<string>("SideEffects")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ActiveSubstancesId")
                        .HasColumnType("int")
                        .HasColumnName("ActiveSubstancesID");

                    b.HasKey("SideEffects", "ActiveSubstancesId");

                    b.HasIndex("ActiveSubstancesId");

                    b.ToTable("ActiveSubstancesSideEffect");
                });

            modelBuilder.Entity("HMS_Project.model.Apointment", b =>
                {
                    b.Property<int>("ApointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApointmentId"));

                    b.Property<DateOnly>("ApointmentDate")
                        .HasColumnType("date");

                    b.Property<string>("ApointmentStatus")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("char");

                    b.Property<TimeOnly>("ApointmentTime")
                        .HasColumnType("time");

                    b.HasKey("ApointmentId");

                    b.ToTable("Apointments");
                });

            modelBuilder.Entity("HMS_Project.model.HmsUser", b =>
                {
                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

<<<<<<< HEAD:HMS_Project/HMS_Project/Data/Migrations/HMSdbcontextModelSnapshot.cs
                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

=======
>>>>>>> 73fe4018a6f5031d7e6fa731359dd9b01e14d287:HMS_Project/HMS_Project/Migrations/HMSdbcontextModelSnapshot.cs
                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .HasColumnType("nchar(1)")
                        .IsFixedLength();

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SSN");

                    b.HasIndex("Email")
                        .IsUnique();

<<<<<<< HEAD:HMS_Project/HMS_Project/Data/Migrations/HMSdbcontextModelSnapshot.cs
                    b.ToTable("HmsUser");

                    b.HasDiscriminator().HasValue("HmsUser");

                    b.UseTphMappingStrategy();
=======
                    b.ToTable("HmsUsers");
>>>>>>> 73fe4018a6f5031d7e6fa731359dd9b01e14d287:HMS_Project/HMS_Project/Migrations/HMSdbcontextModelSnapshot.cs
                });

            modelBuilder.Entity("HMS_Project.model.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceID"));

                    b.Property<DateTime>("InvoiceDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasComputedColumnSql("GETDATE()");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("char");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("InvoiceID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("HMS_Project.model.MedicalRecord", b =>
                {
                    b.Property<int>("RecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordID"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasComputedColumnSql("GETDATE()");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar");

                    b.Property<string>("LabResults")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar");

                    b.HasKey("RecordID");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("HMS_Project.model.Medication", b =>
                {
                    b.Property<string>("MedicationCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MedName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PharmacyID")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.HasKey("MedicationCode");

                    b.HasIndex("PharmacyID");

                    b.ToTable("Medication");
                });

            modelBuilder.Entity("HMS_Project.model.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"));

                    b.Property<int?>("ActiveSubstancesId")
                        .HasColumnType("int");

                    b.Property<string>("PatAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.HasIndex("ActiveSubstancesId");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("HMS_Project.model.PatientMedication", b =>
                {
                    b.Property<int>("PatientPatientId")
                        .HasColumnType("int");

                    b.Property<string>("MedicationMedicationCode")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateOnly>("DateIssued")
                        .HasColumnType("date");

                    b.HasKey("PatientPatientId", "MedicationMedicationCode");

                    b.HasIndex("MedicationMedicationCode");

                    b.ToTable("PatientMedication");
                });

            modelBuilder.Entity("HMS_Project.model.Pharmacist", b =>
                {
                    b.Property<int>("PharmacistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PharmacistID"));

                    b.Property<int>("PharmacyID")
                        .HasColumnType("int");

                    b.HasKey("PharmacistID");

                    b.HasIndex("PharmacyID");

                    b.ToTable("Pharmacists");
                });

            modelBuilder.Entity("HMS_Project.model.Pharmacy", b =>
                {
                    b.Property<int>("PharmacyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PharmacyID"));

                    b.Property<string>("PharmacyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PharmacyPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PharmacyID");

                    b.ToTable("Pharmacies");
                });

            modelBuilder.Entity("HMS_Project.model.Prescription", b =>
                {
                    b.Property<int>("PrescriptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionID"));

                    b.Property<DateTime>("DateIssued")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("Dosage")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("PharmacyID")
                        .HasColumnType("int");

                    b.HasKey("PrescriptionID");

                    b.HasIndex("PatientId");

                    b.HasIndex("PharmacyID");

<<<<<<< HEAD:HMS_Project/HMS_Project/Data/Migrations/HMSdbcontextModelSnapshot.cs
            modelBuilder.Entity("HMS_Project.model.Reception", b =>
                {
                    b.Property<int>("ReceptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceptionID"));

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar");

                    b.HasKey("ReceptionID");

                    b.ToTable("Reception");
                });

            modelBuilder.Entity("HMS_Project.model.Patient", b =>
                {
                    b.HasBaseType("HMS_Project.model.HmsUser");

                    b.Property<int?>("ActiveSubstancesId")
                        .HasColumnType("int");

                    b.Property<string>("PatAddress")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasIndex("ActiveSubstancesId");

                    b.HasDiscriminator().HasValue("Patient");
=======
                    b.ToTable("Prescriptions");
>>>>>>> 73fe4018a6f5031d7e6fa731359dd9b01e14d287:HMS_Project/HMS_Project/Migrations/HMSdbcontextModelSnapshot.cs
                });

            modelBuilder.Entity("HMS_Project.model.Receptionist", b =>
                {
                    b.HasBaseType("HMS_Project.model.HmsUser");

                    b.Property<int>("ReceptionistID")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Receptionist");
                });

            modelBuilder.Entity("ActiveSubstanceMedication", b =>
                {
                    b.HasOne("HMS_Project.model.ActiveSubstance", null)
                        .WithMany()
                        .HasForeignKey("ActiveSubstancesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Medication", null)
                        .WithMany()
                        .HasForeignKey("MedicationCodesMedicationCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ActiveSubstancePrescription", b =>
                {
                    b.HasOne("HMS_Project.model.ActiveSubstance", null)
                        .WithMany()
                        .HasForeignKey("ActiveSubstancesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Prescription", null)
                        .WithMany()
                        .HasForeignKey("PrescriptionsPrescriptionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HMS_Project.model.ActiveSubstanceInteraction", b =>
                {
                    b.HasOne("HMS_Project.model.ActiveSubstance", "ActSub1")
                        .WithMany("ActSub1")
                        .HasForeignKey("ActiveSubstanceId1")
                        .IsRequired();

                    b.HasOne("HMS_Project.model.ActiveSubstance", "ActSub2")
                        .WithMany("ActSub2")
                        .HasForeignKey("ActiveSubstanceId2")
                        .IsRequired();

                    b.Navigation("ActSub1");

                    b.Navigation("ActSub2");
                });

            modelBuilder.Entity("HMS_Project.model.ActiveSubstancesSideEffect", b =>
                {
                    b.HasOne("HMS_Project.model.ActiveSubstance", "ActiveSubstances")
                        .WithMany("ActiveSubstancesSideEffects")
                        .HasForeignKey("ActiveSubstancesId")
                        .IsRequired();

                    b.Navigation("ActiveSubstances");
                });

            modelBuilder.Entity("HMS_Project.model.Medication", b =>
                {
                    b.HasOne("HMS_Project.model.Pharmacy", "Pharmacy")
                        .WithMany("Medications")
                        .HasForeignKey("PharmacyID")
                        .IsRequired();

                    b.Navigation("Pharmacy");
                });

            modelBuilder.Entity("HMS_Project.model.Patient", b =>
                {
                    b.HasOne("HMS_Project.model.ActiveSubstance", null)
                        .WithMany("Patients")
                        .HasForeignKey("ActiveSubstancesId");
                });

            modelBuilder.Entity("HMS_Project.model.PatientMedication", b =>
                {
                    b.HasOne("HMS_Project.model.Medication", null)
                        .WithMany("PatientMedications")
                        .HasForeignKey("MedicationMedicationCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HMS_Project.model.Pharmacist", b =>
                {
                    b.HasOne("HMS_Project.model.Pharmacy", "Pharmacy")
                        .WithMany("Pharmacists")
                        .HasForeignKey("PharmacyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pharmacy");
                });

            modelBuilder.Entity("HMS_Project.model.Prescription", b =>
                {
                    b.HasOne("HMS_Project.model.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Pharmacy", "Pharmacy")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PharmacyID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Pharmacy");
                });

            modelBuilder.Entity("HMS_Project.model.ActiveSubstance", b =>
                {
                    b.Navigation("ActSub1");

                    b.Navigation("ActSub2");

                    b.Navigation("ActiveSubstancesSideEffects");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("HMS_Project.model.Medication", b =>
                {
                    b.Navigation("PatientMedications");
                });

            modelBuilder.Entity("HMS_Project.model.Pharmacy", b =>
                {
                    b.Navigation("Medications");

                    b.Navigation("Pharmacists");

                    b.Navigation("Prescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
