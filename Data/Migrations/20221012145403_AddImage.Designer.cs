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
    [Migration("20221012145403_AddImage")]
    partial class AddImage
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

                    b.Property<string>("ImagePath")
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
                            ImagePath = "https://www.muztorg.ru/files/1dd/71t/qsp/928/gsw/4cw/soo/88c/c/1dd71tqsp928gsw4cwsoo88cc.jpg",
                            Name = "Yamaha F310",
                            Price = 340f,
                            Type = "Western"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Black",
                            ImagePath = "https://www.muztorg.ru/files/1le/qe7/pgx/f6s/0s0/w40/og4/84s/w/1leqe7pgxf6s0s0w40og484sw.jpg",
                            Name = "Rockdale Aurora D1",
                            Price = 130f,
                            Type = "Dreadnought"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Brown",
                            ImagePath = "https://www.muztorg.ru/files/1rt/y8s/dbm/vhc/ks4/swg/4s4/o88/8/1rty8sdbmvhcks4swg4s4o888.jpeg",
                            Name = "Crafter D-7",
                            Price = 600f,
                            Type = "Dreadnought"
                        },
                        new
                        {
                            Id = 4,
                            Color = "Natural",
                            ImagePath = "https://www.muztorg.ru/files/2rp/kok/xui/58g/gcw/04k/484/cg0/k/2rpkokxui58ggcw04k484cg0k.jpg",
                            Name = "Fender CD",
                            Price = 790f,
                            Type = "Dreadnought"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
