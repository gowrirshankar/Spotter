using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Model
{
    public class EnvisDbContext : DbContext
    {
        public EnvisDbContext(DbContextOptions<EnvisDbContext> options) : base(options)
        {
        }
        public DbSet<Spotter> Spotters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Spotter>().ToTable("tbl_spotter")
                                          .HasKey(t => t.Id);
            modelBuilder.Entity<Spotter>().Property(t => t.Id)
                                       .ValueGeneratedOnAdd();
            modelBuilder.Entity<Spotter>().Property(t => t.Make)
                                       .IsRequired()
                                       .HasMaxLength(128)
                                       .HasColumnType("varchar");
            modelBuilder.Entity<Spotter>().Property(t => t.Model)
                                       .IsRequired()
                                       .HasMaxLength(128)
                                       .HasColumnType("varchar");
            modelBuilder.Entity<Spotter>().Property(t => t.Registration)
                                       .IsRequired()
                                       .HasMaxLength(8)
                                       .HasColumnType("varchar");
            modelBuilder.Entity<Spotter>().Property(t => t.Location)
                                       .IsRequired()
                                       .HasMaxLength(255)
                                       .HasColumnType("varchar");
            modelBuilder.Entity<Spotter>().Property(t => t.Date)
                                       .IsRequired()
                                       .HasMaxLength(128)
                                       .HasColumnType("datetime2")
                                       .HasPrecision(0);
            modelBuilder.Entity<Spotter>().HasData(
                            new Spotter
                            {
                                Id = 1,
                                Make = "Boeing",
                                Model = "777-300ER",
                                Registration = "G-RNAC",
                                Location = "London Gatwick",
                                Date = DateTime.ParseExact("23/09/2019 10:30:00", "dd/MM/yyyy HH:mm:ss", null)
                            },
                            new Spotter
                            {
                                Id = 2,
                                Make = "Airbus",
                                Model = "ACJ318",
                                Registration = "AC-JET",
                                Location = "Leiden",
                                Date = DateTime.ParseExact("06/01/2020 10:30:00", "dd/MM/yyyy HH:mm:ss", null)
                            },
                            new Spotter
                            {
                                Id = 3,
                                Make = "Bombardier",
                                Model = "Learjet70",
                                Registration = "BO-LEA",
                                Location = "Valcourt",
                                Date = DateTime.ParseExact("05/12/2018 10:30:00", "dd/MM/yyyy HH:mm:ss", null)
                            },
                            new Spotter
                            {
                                Id = 4,
                                Make = "Cessna",
                                Model = "Sovereign",
                                Registration = "CA-SOV",
                                Location = "China",
                                Date = DateTime.ParseExact("13/05/2017 10:30:00", "dd/MM/yyyy HH:mm:ss", null)
                            },
                            new Spotter
                            {
                                Id = 5,
                                Make = "Dassault",
                                Model = "Falcon900",
                                Registration = "DF-TRI",
                                Location = "Southwest France",
                                Date = DateTime.ParseExact("06/11/2018 03:40:00", "dd/MM/yyyy HH:mm:ss", null)
                            });
        }
    }
}
