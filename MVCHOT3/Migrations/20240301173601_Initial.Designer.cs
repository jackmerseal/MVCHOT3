﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MVCHOT3.Models.DataLayer;

#nullable disable

namespace MVCHOT3.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20240301173601_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVCHOT3.Models.BowlingBall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("BowlingBalls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Motiv",
                            ImageFileName = "motiv-venom-shock.jpg",
                            Name = "Venom Shock",
                            Price = 174.99m
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Roto Grip",
                            ImageFileName = "roto-grip-no-rules-exist.jpg",
                            Name = "No Rules Exist",
                            Price = 249.95m
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Hammer",
                            ImageFileName = "hammer-extreme-envy.jpg",
                            Name = "Extreme Envy",
                            Price = 194.95m
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Pyramid",
                            ImageFileName = "pyramid-antidote.jpg",
                            Name = "Antidote",
                            Price = 109.99m
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Pyramid",
                            ImageFileName = "pyramid-blood-moon-rising.jpg",
                            Name = "Blood Moon Rising",
                            Price = 124.99m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
