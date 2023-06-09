﻿// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Music_Shop.Migrations
{
    [DbContext(typeof(MusicShopDbContext))]
    [Migration("20221001082852_AddAttributes")]
    partial class AddAttributes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Music_Shop.Models.Guitar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Guitars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "White",
                            Name = "Yamaha F310",
                            Price = 340f,
                            Type = "Western"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Black",
                            Name = "Rockdale Aurora D1",
                            Price = 130f,
                            Type = "Dreadnought"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Brown",
                            Name = "Crafter D-7",
                            Price = 600f,
                            Type = "Dreadnought"
                        },
                        new
                        {
                            Id = 4,
                            Color = "Orange",
                            Name = "Fender CD",
                            Price = 790f,
                            Type = "Dreadnought"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
