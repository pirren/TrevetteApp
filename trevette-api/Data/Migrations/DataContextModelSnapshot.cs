﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using trevette_api.Persistence.Contexts;

namespace trevetteapi.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("trevette_api.Domain.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalesObjectId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.HasIndex("SalesObjectId");

                    b.ToTable("Car");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            Manufacturer = "Chevrolet",
                            Mileage = 9000,
                            Model = "Chevrolet Corvette Stingray",
                            SalesObjectId = 1,
                            Year = 1976
                        },
                        new
                        {
                            CarId = 2,
                            Manufacturer = "Volvo",
                            Mileage = 40000,
                            Model = "Volvo 240",
                            SalesObjectId = 2,
                            Year = 1980
                        },
                        new
                        {
                            CarId = 3,
                            Manufacturer = "Saab",
                            Mileage = 3000,
                            Model = "Saab 9-3",
                            Year = 2012
                        },
                        new
                        {
                            CarId = 4,
                            Manufacturer = "Ferrari",
                            Mileage = 15000,
                            Model = "Ferrari 250 Testa Rossa",
                            Year = 1960
                        });
                });

            modelBuilder.Entity("trevette_api.Domain.Models.Photo", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhotoId");

                    b.HasIndex("CarId");

                    b.ToTable("Photo");

                    b.HasData(
                        new
                        {
                            PhotoId = 1,
                            CarId = 1,
                            FileName = "1.jpg"
                        },
                        new
                        {
                            PhotoId = 2,
                            CarId = 1,
                            FileName = "2.jpg"
                        },
                        new
                        {
                            PhotoId = 3,
                            CarId = 1,
                            FileName = "3.jpg"
                        },
                        new
                        {
                            PhotoId = 4,
                            CarId = 2,
                            FileName = "4.jpg"
                        },
                        new
                        {
                            PhotoId = 5,
                            CarId = 3,
                            FileName = "5.jpg"
                        },
                        new
                        {
                            PhotoId = 6,
                            CarId = 4,
                            FileName = "6.jpg"
                        });
                });

            modelBuilder.Entity("trevette_api.Domain.Models.SalesObject", b =>
                {
                    b.Property<int>("SalesObjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalesObjectId");

                    b.ToTable("SalesObject");

                    b.HasData(
                        new
                        {
                            SalesObjectId = 1,
                            Description = "Den nya porschen är riktigt fet. Har en 3 L motor och gör 100 km/h på 3.7 s med sport-chrono paket. Denna vagn är för dom riktigt rika.",
                            InStock = true,
                            StartDate = new DateTime(2020, 10, 9, 12, 55, 36, 113, DateTimeKind.Local).AddTicks(8650),
                            Title = "Tidlös maskin"
                        },
                        new
                        {
                            SalesObjectId = 2,
                            Description = "Denna gamla Volvo är en klassisk bakhjulsdriven personbil och går aldrig fel. Rullar fint.",
                            InStock = false,
                            StartDate = new DateTime(2020, 10, 9, 12, 55, 36, 116, DateTimeKind.Local).AddTicks(1653),
                            Title = "Odödlig"
                        });
                });

            modelBuilder.Entity("trevette_api.Domain.Models.Car", b =>
                {
                    b.HasOne("trevette_api.Domain.Models.SalesObject", "SalesObject")
                        .WithMany()
                        .HasForeignKey("SalesObjectId");
                });

            modelBuilder.Entity("trevette_api.Domain.Models.Photo", b =>
                {
                    b.HasOne("trevette_api.Domain.Models.Car", "Car")
                        .WithMany("Photos")
                        .HasForeignKey("CarId");
                });
#pragma warning restore 612, 618
        }
    }
}
