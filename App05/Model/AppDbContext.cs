﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App05.Model
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.;initial catalog=cs140211-codefirst2;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=AppDBFirst");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Fluent Api // Chaine API
            //modelBuilder.Entity<Category>().Property(x => x.Description)
            //        .HasMaxLength(200)
            //        .IsRequired()
            //        .IsUnicode(false)                    
            //        ;
            //modelBuilder.Entity<Category>().Property(x => x.Name)
            //        .HasMaxLength(100)
            //        .IsRequired()
            //        .IsUnicode(true)
            //        ;

            //modelBuilder.Entity<Product>().Property(x => x.Description)
            //        .HasMaxLength(200)
            //        .IsRequired()
            //        .IsUnicode(false)
            //        ;
            //modelBuilder.Entity<Product>().Property(x => x.Name)
            //        .HasMaxLength(100)
            //        .IsRequired()
            //        .IsUnicode(true)
            //        ;

            modelBuilder.ApplyConfiguration(new CategoryConfig()); 
            modelBuilder.ApplyConfiguration(new ProductConfig());

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
