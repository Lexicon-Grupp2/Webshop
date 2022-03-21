using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models;

namespace Webshop.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Receipt> Receipts { get; set; }

        //Not updated

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            //All relationships need to be defined

            //Customer 1toMany Receipts
            //Recepits 1toMany Products?
            //Category 1toMany Products

            modelBuilder.Entity<Customer>()
                .HasMany(receipt => receipt.Receipts);

            modelBuilder.Entity<ProductCategory>()
                .HasKey(productCategory => new { productCategory.ProductId, productCategory.CategoryId });

            modelBuilder.Entity<ProductCategory>()
                .HasOne<Category>(productCategory => productCategory.Category)
                .WithMany(product => product.ProductCategories)
                .HasForeignKey(productCategory => productCategory.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);






            //All relevant categories need to be populated

            modelBuilder.Entity<Customer>().HasData(new List<Customer>
            {
                new Customer
                    {Id=1, FirstName = "Arne", LastName="Karat", Address="Kanelgatan 3",  PhoneNumber = "043016624", PostalCode="23445", City="Visby", Country="Sweden", Email="bling@gmail.com" },
                new Customer
                    {Id=2, FirstName = "Kenneth", LastName="Svenzon", Address="Rimbo torg 1", PhoneNumber = "0721453456", PostalCode="44565", City="Skövde", Country="Sweden", Email="stekarn@gmail.com" },
                new Customer
                    {Id=3, FirstName = "Angela", LastName="Merkel", Address="Kungsgatan 4", PhoneNumber = "0771242424", PostalCode="32344", City="Arboga", Country = "Sweden", Email="lucky@hotmail.com"},
                new Customer
                    {Id=4, FirstName = "Kaj", LastName="Fridell", Address="Royal Carnac Hotel 1", PhoneNumber = "031184698", PostalCode="33467", City="Cairo", Country="Egypt", Email="mubarak@egypt.gov" },
                new Customer
                    {Id=5, FirstName = "Molly", LastName="Sundkvist", Address="Vedgatan 3", PhoneNumber = "0443346723", PostalCode="46723", City="Oslo", Country="Norway", Email="tavlan@gmail.com" },
                new Customer
                    {Id=6, FirstName = "Sofia", LastName="Bosch", Address="Avenyn 1", PhoneNumber = "0543768798", PostalCode="67823", City="Berlin", Country="Germany", Email="raj@goteborg.se" },
            });

            modelBuilder.Entity<Product>().HasData(new List<Product>
            {
                new Product
                    {Id = 1, Name = "Wheat", Description="A perfect grain for baking bread", Price=2 },
                new Product
                    {Id = 2, Name = "Rye", Description="A perfect grain for the course bread", Price=15 },
                new Product
                    {Id = 3, Name = "Barley", Description="A perfect grain for making beer", Price=2 },

            });

            modelBuilder.Entity<Category>().HasData(new List<Category>
            {
                new Category
                    {Id = 1, CategoryName = "Grain" },
                new Category
                    {Id = 2, CategoryName = "Seedlings" },
                new Category
                    {Id = 3, CategoryName = "Nutritious product" },

            });

            //Identity needs to be added


        }
    }
}
