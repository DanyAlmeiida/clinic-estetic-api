﻿// <auto-generated />
using System;
using ClinicEsteticManagement.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClinicEsteticManagement.Persistence.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230314004538_14032023")]
    partial class _14032023
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClinicEsteticManagement.Domain.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("Date");

                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobOccupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observations")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasAlternateKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.ClinicalData.ClinicalInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AgainstIndications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alergies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClinicalBackground")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("GynecologicalConditionsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("HasImplants")
                        .HasColumnType("bit");

                    b.Property<bool>("HasIntraUterineDevice")
                        .HasColumnType("bit");

                    b.Property<bool>("HasPacemaker")
                        .HasColumnType("bit");

                    b.Property<bool>("HasProteses")
                        .HasColumnType("bit");

                    b.Property<bool>("HasRadioactiveDevices")
                        .HasColumnType("bit");

                    b.Property<int>("HearRate")
                        .HasColumnType("int");

                    b.Property<bool>("IsLeftHanded")
                        .HasColumnType("bit");

                    b.Property<int>("MaxBloodPressure")
                        .HasColumnType("int");

                    b.Property<string>("Medicines")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MentalState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MinBloodPressure")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Surgeries")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("GynecologicalConditionsId");

                    b.ToTable("ClinicalInformations");
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.ClinicalData.EverydayHabit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DoesPhysicalActivity")
                        .HasColumnType("bit");

                    b.Property<bool>("Drinks")
                        .HasColumnType("bit");

                    b.Property<string>("Feeding")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HairRemovalMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("PainSensitive")
                        .HasColumnType("bit");

                    b.Property<string>("PhysicalActivity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SleepQuality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Smoke")
                        .HasColumnType("bit");

                    b.Property<TimeSpan?>("TimeADayOfPhysicalActivty")
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("TimeADayWithoutPhysicalActivty")
                        .HasColumnType("time");

                    b.Property<float>("WaterIntakePerDay")
                        .HasColumnType("real");

                    b.Property<string>("WorkFunction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("EverydayHabits");
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.ClinicalData.GeneralDisease", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CancerBackground")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CholesterolDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("CholesterolValue")
                        .HasColumnType("float");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DiabetesDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiabetesType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodIntolerance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasChilblains")
                        .HasColumnType("bit");

                    b.Property<bool>("HasEpilepsy")
                        .HasColumnType("bit");

                    b.Property<bool>("HasHemophiliac")
                        .HasColumnType("bit");

                    b.Property<bool>("HasHyperthyroidism")
                        .HasColumnType("bit");

                    b.Property<bool>("HasHypotension")
                        .HasColumnType("bit");

                    b.Property<bool>("HasSkinProblems")
                        .HasColumnType("bit");

                    b.Property<bool>("HasVascularProblems")
                        .HasColumnType("bit");

                    b.Property<string>("Intestine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("StressDegree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TriglyceridesDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TriglyceridesValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("GeneralDiseases");
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.ClinicalData.GynecologicalConditions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("BreastFeedDate")
                        .HasColumnType("Date");

                    b.Property<int>("ChildrenQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("MenopauseDate")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("MenstruatingDate")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PregnancyTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("PregnantDate")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.HasIndex("PregnancyTypeId");

                    b.ToTable("GynecologicalConditions");
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.ClinicalData.PregnancyType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PregnancyTypes");
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.ParamTables.WorkActivityType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkActivityTypes");
                });

            modelBuilder.Entity("EverydayHabitWorkActivityType", b =>
                {
                    b.Property<Guid>("EverydayhabitsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WorkActivitysId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EverydayhabitsId", "WorkActivitysId");

                    b.HasIndex("WorkActivitysId");

                    b.ToTable("EverydayHabitWorkActivityType");
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.ClinicalData.ClinicalInformation", b =>
                {
                    b.HasOne("ClinicEsteticManagement.Domain.Client", null)
                        .WithMany("ClinicalInformations")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicEsteticManagement.Domain.ClinicalData.GynecologicalConditions", "GynecologicalConditions")
                        .WithMany()
                        .HasForeignKey("GynecologicalConditionsId");

                    b.Navigation("GynecologicalConditions");
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.ClinicalData.EverydayHabit", b =>
                {
                    b.HasOne("ClinicEsteticManagement.Domain.Client", null)
                        .WithMany("EverydayHabits")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.ClinicalData.GeneralDisease", b =>
                {
                    b.HasOne("ClinicEsteticManagement.Domain.Client", null)
                        .WithMany("GeneralDiseases")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.ClinicalData.GynecologicalConditions", b =>
                {
                    b.HasOne("ClinicEsteticManagement.Domain.ClinicalData.PregnancyType", "PregnancyType")
                        .WithMany()
                        .HasForeignKey("PregnancyTypeId");

                    b.Navigation("PregnancyType");
                });

            modelBuilder.Entity("EverydayHabitWorkActivityType", b =>
                {
                    b.HasOne("ClinicEsteticManagement.Domain.ClinicalData.EverydayHabit", null)
                        .WithMany()
                        .HasForeignKey("EverydayhabitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicEsteticManagement.Domain.ParamTables.WorkActivityType", null)
                        .WithMany()
                        .HasForeignKey("WorkActivitysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.Client", b =>
                {
                    b.Navigation("ClinicalInformations");

                    b.Navigation("EverydayHabits");

                    b.Navigation("GeneralDiseases");
                });
#pragma warning restore 612, 618
        }
    }
}
