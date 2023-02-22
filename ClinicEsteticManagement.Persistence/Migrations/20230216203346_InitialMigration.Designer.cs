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
    [Migration("20230216203346_InitialMigration")]
    partial class InitialMigration
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

                    b.Property<Guid?>("ClinicalInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobOccupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observations")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClinicalInformationId");

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

                    b.Property<string>("Surgeries")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GynecologicalConditionsId");

                    b.ToTable("ClinicalInformations");
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.ClinicalData.GynecologicalConditions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BreastFeedDate")
                        .HasColumnType("Date");

                    b.Property<int>("ChildrenQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MenopauseDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("MenstruatingDate")
                        .HasColumnType("Date");

                    b.Property<Guid?>("PregnancyTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("PregnantDate")
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

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PregnancyTypes");
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.Client", b =>
                {
                    b.HasOne("ClinicEsteticManagement.Domain.ClinicalData.ClinicalInformation", "ClinicalInformation")
                        .WithMany()
                        .HasForeignKey("ClinicalInformationId");

                    b.Navigation("ClinicalInformation");
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.ClinicalData.ClinicalInformation", b =>
                {
                    b.HasOne("ClinicEsteticManagement.Domain.ClinicalData.GynecologicalConditions", "GynecologicalConditions")
                        .WithMany()
                        .HasForeignKey("GynecologicalConditionsId");

                    b.Navigation("GynecologicalConditions");
                });

            modelBuilder.Entity("ClinicEsteticManagement.Domain.ClinicalData.GynecologicalConditions", b =>
                {
                    b.HasOne("ClinicEsteticManagement.Domain.ClinicalData.PregnancyType", "PregnancyType")
                        .WithMany()
                        .HasForeignKey("PregnancyTypeId");

                    b.Navigation("PregnancyType");
                });
#pragma warning restore 612, 618
        }
    }
}
