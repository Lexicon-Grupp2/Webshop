﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Webshop.Models;

namespace Webshop.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
   
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()  //Connecting Customer to Applicationuser
                .HasOne(user => user.Customer)
                .WithOne(user => user.ApplicationUser)
                .HasForeignKey<Customer>(user => user.CustomerId);

             modelBuilder.Entity<Product>()
                .HasOne<Category>(product => product.Category)
                .WithMany(category => category.Products)
                .HasForeignKey(product => product.CategoryId);

            modelBuilder.Entity<Receipt>()
                .HasOne<Customer>(receipt => receipt.Customer)
                .WithMany(customer => customer.Receipts);

            modelBuilder.Entity<Receipt>()
                .HasMany<Product>(receipt => receipt.Products);


            modelBuilder.Entity<Customer>().HasData(new List<Customer>
            {
                new Customer
                    {Id=1, FirstName = "Arne", LastName="Karat", Address="Kanelgatan 3",  PhoneNumber = "043016624", PostalCode="23445", City="Visby", Country="Sweden", Email="bling@gmail.com" },
                new Customer
                    {Id=2, FirstName = "Kenneth", LastName="Svenzon", Address="Rimbo torg 1", PhoneNumber = "0721453456", PostalCode="44565", City="Skövde", Country="Sweden", Email="stekarn@gmail.com" },
                new Customer
                    {Id=3, FirstName = "Angela", LastName="Melodi", Address="Kungsgatan 4", PhoneNumber = "0771242424", PostalCode="32344", City="Arboga", Country = "Sweden", Email="lucky@hotmail.com"},
                new Customer
                    {Id=4, FirstName = "Kaj", LastName="Fridell", Address="Royal Carnac Hotel 1", PhoneNumber = "031184698", PostalCode="33467", City="Cairo", Country="Egypt", Email="kafr@egypt.gov" },
                new Customer
                    {Id=5, FirstName = "Molly", LastName="Sundkvist", Address="Vedgatan 3", PhoneNumber = "0443346723", PostalCode="46723", City="Oslo", Country="Norway", Email="tavlan@gmail.com" },
                new Customer
                    {Id=5, FirstName = "Jan", LastName="Andersson", Address="Gatgatan 2", PhoneNumber = "04422723", PostalCode="46723", City="Göteborg", Country="Sweden", Email="test@gmail.com" },
                new Customer
                    {Id=6, FirstName = "Sofia", LastName="Bosch", Address="Avenyn 1", PhoneNumber = "0543768798", PostalCode="67823", City="Berlin", Country="Germany", Email="raj@goteborg.se" },
            });


            modelBuilder.Entity<Product>().HasData(new List<Product>
            {
                new Product
                    {Id = 1, Name = "Chocolate Dream", Description="A delicious chocolate cupcake with belgian chocolate", CategoryId = 101, Price = 29 },
                new Product
                    {Id = 2, Name = "Pink surprise", Description="A frosted strawberry cupcake, filled with strawberry jam", CategoryId = 102, Price = 22 },
                new Product
                    {Id = 3, Name = "Plain delight", Description="A gluten free cupcake packed with flavor", CategoryId = 103, Price = 34 },
            });


            modelBuilder.Entity<Category>().HasData(new List<Category>
            {
                new Category
                    {Id = 101, CategoryName = "Chocolate" },
                new Category
                    {Id = 102, CategoryName = "Frosted" },
                new Category
                    {Id = 103, CategoryName = "Gluten free" },
            });


            string roleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = roleId,
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = userRoleId,
                Name = "User",
                NormalizedName = "USER"
            });

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = userId,
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                PasswordHash = hasher.HashPassword(null, "password"),
                FirstName = "Admin",
                LastName = "Adminsson"
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleId,
                UserId = userId
            });


        }
    }
}
