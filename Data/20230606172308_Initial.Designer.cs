﻿// <auto-generated />
using EcommerceApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceApp.Data
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230606172308_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("EcommerceApp.Models.Goods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("GoodsTable");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 0,
                            Description = "Nice men's Leather Jacket for outing",
                            Name = "Leather Jacket",
                            Price = 18.300000000000001,
                            ProfilePicture = "~/images/jacket.jpg",
                            Quantity = 7
                        },
                        new
                        {
                            Id = 2,
                            Category = 1,
                            Description = "Nice heels for outing",
                            Name = "Fashion Heels",
                            Price = 13.300000000000001,
                            ProfilePicture = "~/images/heels.jpg",
                            Quantity = 5
                        },
                        new
                        {
                            Id = 3,
                            Category = 4,
                            Description = "Keeps your Cat busy all day",
                            Name = "Electric Mouse",
                            Price = 9.6999999999999993,
                            ProfilePicture = "~/images/emouse.jpg",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 4,
                            Category = 3,
                            Description = "High quality cargo pant for kids",
                            Name = "Combat Joggers",
                            Price = 15.0,
                            ProfilePicture = "~/images/joggers.jpg",
                            Quantity = 16
                        },
                        new
                        {
                            Id = 5,
                            Category = 5,
                            Description = "Exclusive waterproof watch for all",
                            Name = "Hublot Wristwatch",
                            Price = 24.989999999999998,
                            ProfilePicture = "~/images/hublot.jpg",
                            Quantity = 6
                        },
                        new
                        {
                            Id = 6,
                            Category = 2,
                            Description = "Sexy short gown ladies",
                            Name = "Mini Gown",
                            Price = 19.199999999999999,
                            ProfilePicture = "~/images/gown.jpg",
                            Quantity = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}