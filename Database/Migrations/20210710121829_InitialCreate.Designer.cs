﻿// <auto-generated />
using System;
using Database.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Database.Migrations
{
    [DbContext(typeof(EnvisDbContext))]
    [Migration("20210710121829_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Database.Model.Spotter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasMaxLength(128)
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Registration")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.HasKey("Id");

                    b.ToTable("tbl_spotter");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2019, 9, 23, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Location = "London Gatwick",
                            Make = "Boeing",
                            Model = "777-300ER",
                            Registration = "G-RNAC"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2020, 1, 6, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Location = "Leiden",
                            Make = "Airbus",
                            Model = "ACJ318",
                            Registration = "AC-JET"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2018, 12, 5, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Location = "Valcourt",
                            Make = "Bombardier",
                            Model = "Learjet70",
                            Registration = "BO-LEA"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2017, 5, 13, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Location = "China",
                            Make = "Cessna",
                            Model = "Sovereign",
                            Registration = "CA-SOV"
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2018, 11, 6, 3, 40, 0, 0, DateTimeKind.Unspecified),
                            Location = "Southwest France",
                            Make = "Dassault",
                            Model = "Falcon900",
                            Registration = "DF-TRI"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}