﻿// <auto-generated />
using System;
using SeminarParticipants.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SeminarParticipants.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240919101616_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConferenceAttendees.Api.Data.Attendee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("GenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobRoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<Guid>("ReferralSourceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("JobRoleId");

                    b.HasIndex("ReferralSourceId");

                    b.ToTable("Attendees");
                });

            modelBuilder.Entity("ConferenceAttendees.Api.Data.Gender", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c2a3bf8d-4340-4adc-85a3-a0be30d572f2"),
                            Name = "Male"
                        },
                        new
                        {
                            Id = new Guid("b66910d4-f789-473d-b997-16efabdcb5d3"),
                            Name = "Female"
                        });
                });

            modelBuilder.Entity("ConferenceAttendees.Api.Data.JobRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("JobRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e42f1629-367f-42b6-b75c-36a391f7816e"),
                            Name = "Manager"
                        },
                        new
                        {
                            Id = new Guid("825e19cc-89e1-4f7e-86a7-776efe3a403e"),
                            Name = "Supervisor"
                        },
                        new
                        {
                            Id = new Guid("0713d4d5-5560-4d36-b1ec-5bca0f52268a"),
                            Name = "Sales"
                        },
                        new
                        {
                            Id = new Guid("14c05cd3-7064-46b4-9d61-d003942d4c05"),
                            Name = "Operations"
                        });
                });

            modelBuilder.Entity("ConferenceAttendees.Api.Data.ReferralSource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("ReferralSources");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2930ec25-e259-49d6-be38-930b0c5a07dc"),
                            Name = "Internet Advertisement"
                        },
                        new
                        {
                            Id = new Guid("5295ecec-bb38-48f0-b6ab-f51ad57d38bd"),
                            Name = "Television"
                        },
                        new
                        {
                            Id = new Guid("1dbdadbb-3175-44bb-a3aa-fc95b6bfd44f"),
                            Name = "Newspaper Article"
                        },
                        new
                        {
                            Id = new Guid("f2118fcd-7413-42f7-b4cc-a2f6089145c4"),
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("ConferenceAttendees.Api.Data.Attendee", b =>
                {
                    b.HasOne("ConferenceAttendees.Api.Data.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceAttendees.Api.Data.JobRole", "JobRole")
                        .WithMany()
                        .HasForeignKey("JobRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceAttendees.Api.Data.ReferralSource", "ReferralSource")
                        .WithMany()
                        .HasForeignKey("ReferralSourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("JobRole");

                    b.Navigation("ReferralSource");
                });
#pragma warning restore 612, 618
        }
    }
}
