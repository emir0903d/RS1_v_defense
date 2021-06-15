﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PRENATALv2.Areas.Home.Models;

namespace PRENATALv2.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200528124100_InitialSet2")]
    partial class InitialSet2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.Allergies", b =>
                {
                    b.Property<int>("AllergiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("AllergiesId");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.Appointments", b =>
                {
                    b.Property<int>("AppointmentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Doctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Patient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("AppointmentsId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.BloodExaminations", b =>
                {
                    b.Property<int>("BloodExaminationsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloodTest")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<float>("High")
                        .HasColumnType("real");

                    b.Property<float>("Low")
                        .HasColumnType("real");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("ReferralsId")
                        .HasColumnType("int");

                    b.Property<float?>("Results")
                        .HasColumnType("real");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("BloodExaminationsId");

                    b.HasIndex("ReferralsId");

                    b.ToTable("BloodExaminations");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.ExpectedBirth", b =>
                {
                    b.Property<int>("ExpectedBirthId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpectedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastMenstrualDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("ExpectedBirthId");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("ExpectedBirth");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.HistoryOfSubstanceUse", b =>
                {
                    b.Property<int>("HistoryOfSubstanceUseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("NumberOfYears")
                        .HasColumnType("int");

                    b.Property<bool>("PriorToPregnancy")
                        .HasColumnType("bit");

                    b.Property<bool>("StillUsing")
                        .HasColumnType("bit");

                    b.HasKey("HistoryOfSubstanceUseId");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("HistoryOfSubstanceUse");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.MedicalHistory", b =>
                {
                    b.Property<int>("MedicalHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnosis")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("MedicalHistoryId");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("MedicalHistory");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.MedicalRecord", b =>
                {
                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BloodType")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("MaidenName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("MartialStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("MedicalRecordNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("PersonalIdentificationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("RHFactor")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.HasKey("MedicalRecordId");

                    b.ToTable("MedicalRecord");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.Partner", b =>
                {
                    b.Property<int>("PartnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloodType")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("RHFactor")
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("PartnerId");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("Partner");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.PregnancyLossHistory", b =>
                {
                    b.Property<int>("PregnancyLossHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("PregnancyLossDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("PregnancyLossHistoryId");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("PregnancyLossHistory");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.PreviousPregnancyHistory", b =>
                {
                    b.Property<int>("PreviousPregnancyHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Complications")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("DeliveryType")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("GestationWeeks")
                        .HasColumnType("int");

                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<string>("Outcome")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("PregnancyDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PreviousPregnancyHistoryId");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("PreviousPregnancyHistory");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.Referrals", b =>
                {
                    b.Property<int>("ReferralsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("int");

                    b.HasKey("ReferralsId");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("Referrals");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.Therapies", b =>
                {
                    b.Property<int>("TherapiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginningDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<string>("Medicaments")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("TherapiesId");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("Therapies");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.Ultrasound", b =>
                {
                    b.Property<int>("UltrasoundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AbdominalCircumference")
                        .HasColumnType("real");

                    b.Property<bool>("Anomalies")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("FemurLength")
                        .HasColumnType("real");

                    b.Property<float>("HeadCircumference")
                        .HasColumnType("real");

                    b.Property<float>("HeadDiameter")
                        .HasColumnType("real");

                    b.Property<int>("HeartBeats")
                        .HasColumnType("int");

                    b.Property<float>("Length")
                        .HasColumnType("real");

                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<bool>("Movement")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<bool>("NuchalScan")
                        .HasColumnType("bit");

                    b.HasKey("UltrasoundId");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("Ultrasound");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.UrineExaminations", b =>
                {
                    b.Property<int>("UrineExaminationsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("ReferenceInterval")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReferralsId")
                        .HasColumnType("int");

                    b.Property<string>("Results")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("UrineTest")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("UrineExaminationsId");

                    b.HasIndex("ReferralsId");

                    b.ToTable("UrineExaminations");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.VitalSigns", b =>
                {
                    b.Property<int>("VitalSignsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DiastolicPressure")
                        .HasColumnType("int");

                    b.Property<int>("HeartBeats")
                        .HasColumnType("int");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("RespiratoryRate")
                        .HasColumnType("int");

                    b.Property<int>("SystolicPressure")
                        .HasColumnType("int");

                    b.Property<float>("Temperature")
                        .HasColumnType("real");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("VitalSignsId");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("VitalSigns");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Models.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int?>("NumberOfUsers")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("LoginCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Models.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Models.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRENATALv2.Areas.Home.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.Allergies", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Data.MedicalRecord", "MedicalRecord")
                        .WithMany()
                        .HasForeignKey("MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.BloodExaminations", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Data.Referrals", "Referrals")
                        .WithMany()
                        .HasForeignKey("ReferralsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.ExpectedBirth", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Data.MedicalRecord", "MedicalRecord")
                        .WithMany()
                        .HasForeignKey("MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.HistoryOfSubstanceUse", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Data.MedicalRecord", "MedicalRecord")
                        .WithMany()
                        .HasForeignKey("MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.MedicalHistory", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Data.MedicalRecord", "MedicalRecord")
                        .WithMany()
                        .HasForeignKey("MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.MedicalRecord", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Models.AppUser", "AppUser")
                        .WithOne("MedicalRecord")
                        .HasForeignKey("PRENATALv2.Areas.Home.Data.MedicalRecord", "MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.Partner", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Data.MedicalRecord", "MedicalRecord")
                        .WithMany()
                        .HasForeignKey("MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.PregnancyLossHistory", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Data.MedicalRecord", "MedicalRecord")
                        .WithMany()
                        .HasForeignKey("MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.PreviousPregnancyHistory", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Data.MedicalRecord", "MedicalRecord")
                        .WithMany()
                        .HasForeignKey("MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.Referrals", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Data.MedicalRecord", "MedicalRecord")
                        .WithMany()
                        .HasForeignKey("MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.Therapies", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Data.MedicalRecord", "MedicalRecord")
                        .WithMany()
                        .HasForeignKey("MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.Ultrasound", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Data.MedicalRecord", "MedicalRecord")
                        .WithMany()
                        .HasForeignKey("MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.UrineExaminations", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Data.Referrals", "Referrals")
                        .WithMany()
                        .HasForeignKey("ReferralsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRENATALv2.Areas.Home.Data.VitalSigns", b =>
                {
                    b.HasOne("PRENATALv2.Areas.Home.Data.MedicalRecord", "MedicalRecord")
                        .WithMany()
                        .HasForeignKey("MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
