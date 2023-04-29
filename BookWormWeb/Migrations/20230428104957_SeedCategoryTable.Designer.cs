﻿// <auto-generated />
using System;
using BookWormWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookWormWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230428104957_SeedCategoryTable")]
    partial class SeedCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookWormWeb.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTime = new DateTime(2023, 4, 28, 15, 49, 56, 961, DateTimeKind.Local).AddTicks(8464),
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2023, 4, 28, 15, 49, 56, 961, DateTimeKind.Local).AddTicks(8483),
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDateTime = new DateTime(2023, 4, 28, 15, 49, 56, 961, DateTimeKind.Local).AddTicks(8485),
                            DisplayOrder = 3,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDateTime = new DateTime(2023, 4, 28, 15, 49, 56, 961, DateTimeKind.Local).AddTicks(8487),
                            DisplayOrder = 4,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDateTime = new DateTime(2023, 4, 28, 15, 49, 56, 961, DateTimeKind.Local).AddTicks(8489),
                            DisplayOrder = 5,
                            Name = "Fantasy"
                        });
                });

            modelBuilder.Entity("BookWormWeb.Models.CoverType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("CoverTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
