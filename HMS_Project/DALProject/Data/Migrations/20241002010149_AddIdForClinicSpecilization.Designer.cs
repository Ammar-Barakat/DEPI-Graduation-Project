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
    [Migration("20241002010149_AddIdForClinicSpecilization")]
    partial class AddIdForClinicSpecilization
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

                    b.Property<string>("MedicationsMedicationCode")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ActiveSubstancesId", "MedicationsMedicationCode");

                    b.HasIndex("MedicationsMedicationCode");

                    b.ToTable("ActiveSubstanceMedication");
                });

            modelBuilder.Entity("ActiveSubstancePatient", b =>
                {
                    b.Property<int>("ActSbuAllergiesActiveSubstancesId")
                        .HasColumnType("int");

                    b.Property<long>("PatientshaveAllergySSN")
                        .HasColumnType("bigint");

                    b.HasKey("ActSbuAllergiesActiveSubstancesId", "PatientshaveAllergySSN");

                    b.HasIndex("PatientshaveAllergySSN");

                    b.ToTable("ActiveSubstancePatient");
                });

            modelBuilder.Entity("DALProject.model.ActiveSubstance", b =>
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

                    b.ToTable("ActiveSubstances");
                });

            modelBuilder.Entity("DALProject.model.ActiveSubstanceInteraction", b =>
                {
                    b.Property<int?>("ActiveSubstanceId1")
                        .HasColumnType("int");

                    b.Property<int?>("ActiveSubstanceId2")
                        .HasColumnType("int");

                    b.Property<string>("Interaction")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ActiveSubstanceId1", "ActiveSubstanceId2");

                    b.HasIndex("ActiveSubstanceId2");

                    b.ToTable("ActiveSubstanceInteraction");
                });

            modelBuilder.Entity("DALProject.model.Apointment", b =>
                {
                    b.Property<int>("ApointmentId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("ApointmentDate")
                        .HasColumnType("date");

                    b.Property<string>("ApointmentStatus")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar");

                    b.Property<TimeOnly>("ApointmentTime")
                        .HasColumnType("time");

                    b.Property<int?>("ClinicId")
                        .HasColumnType("int");

                    b.Property<long>("DoctorId")
                        .HasColumnType("bigint");

                    b.Property<string>("Examination")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("PatientId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ReceptionistId")
                        .HasColumnType("bigint");

                    b.HasKey("ApointmentId");

                    b.HasIndex("ClinicId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("ReceptionistId");

                    b.ToTable("Apointments");
                });

            modelBuilder.Entity("DALProject.model.Clinic", b =>
                {
                    b.Property<int>("ClinicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClinicId"));

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

                    b.HasKey("ClinicId");

                    b.HasIndex("ClinicSpecializationId");

                    b.ToTable("Clinics");
                });

            modelBuilder.Entity("DALProject.model.ClinicSpecializationLookup", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

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
                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

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

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SSN");

                    b.HasIndex("ClinicId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Specialization");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("DALProject.model.DoctorScheduleLookup", b =>
                {
                    b.Property<string>("Day")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<long>("DoctorId")
                        .HasColumnType("bigint");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Day", "DoctorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("DoctorScheduleLookups");
                });

            modelBuilder.Entity("DALProject.model.DoctorSpecializationLookup", b =>
                {
                    b.Property<string>("Specialization")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Specialization");

                    b.ToTable("DoctorSpecializationLookup");
                });

            modelBuilder.Entity("DALProject.model.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceID"));

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

                    b.Property<long?>("ReceptionistId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("InvoiceID");

                    b.HasIndex("ApointmentId")
                        .IsUnique()
                        .HasFilter("[ApointmentId] IS NOT NULL");

                    b.HasIndex("ReceptionistId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("DALProject.model.Medication", b =>
                {
                    b.Property<string>("MedicationCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MedName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.HasKey("MedicationCode");

                    b.ToTable("Medication");
                });

            modelBuilder.Entity("DALProject.model.Nurse", b =>
                {
                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

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

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SSN");

                    b.HasIndex("ClinicId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("DALProject.model.Patient", b =>
                {
                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

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

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SSN");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DALProject.model.Pharmacist", b =>
                {
                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

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

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SSN");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Pharmacists");
                });

            modelBuilder.Entity("DALProject.model.Prescription", b =>
                {
                    b.Property<int>("PrescriptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionID"));

                    b.Property<int>("ApointmentId")
                        .HasColumnType("int");

                    b.Property<long>("DoctorId")
                        .HasColumnType("bigint");

                    b.Property<long?>("PharmacistId")
                        .HasColumnType("bigint");

                    b.HasKey("PrescriptionID");

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
                        .HasColumnType("nvarchar(20)");

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

                    b.HasKey("MedicationCode", "PrescriptionItemId");

                    b.HasIndex("PrescriptionItemId");

                    b.ToTable("PrescriptionItemMedication");
                });

            modelBuilder.Entity("DALProject.model.Receptionist", b =>
                {
                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

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

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SSN");

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
                        .HasForeignKey("MedicationsMedicationCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ActiveSubstancePatient", b =>
                {
                    b.HasOne("DALProject.model.ActiveSubstance", null)
                        .WithMany()
                        .HasForeignKey("ActSbuAllergiesActiveSubstancesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DALProject.model.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientshaveAllergySSN")
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
                    b.HasOne("DALProject.model.Prescription", "Prescription")
                        .WithOne("Apointment")
                        .HasForeignKey("DALProject.model.Apointment", "ApointmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DALProject.model.Clinic", "Clinic")
                        .WithMany("Apointments")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.SetNull);

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
                        .HasForeignKey("Specialization")
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
                        .HasForeignKey("DALProject.model.Invoice", "ApointmentId")
                        .OnDelete(DeleteBehavior.SetNull);

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
                        .HasForeignKey("MedicationCode")
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
                    b.Navigation("Apointment")
                        .IsRequired();

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
