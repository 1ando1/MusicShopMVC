﻿using Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data
{
    public class MusicShopDbContext : DbContext
    {
        public MusicShopDbContext() { }
        public MusicShopDbContext(DbContextOptions options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TechShopDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ExtraProduct>().HasData(MusicShopSeeder.GetExtraProduct());
            modelBuilder.Entity<Music_Shop.Models.Guitar>().HasData(MusicShopSeeder.GetGuitars());
        }
        public DbSet<Music_Shop.Models.Guitar> Guitars { get; set; }
        public DbSet<ExtraProduct> ExtraProducts { get; set; }
    }
}