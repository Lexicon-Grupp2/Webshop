using Microsoft.AspNetCore.Identity;
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
        public DbSet<Product> Inventory { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<CartContent> CartContents { get; set; }     
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()  //Connecting Customer to Applicationuser
                .HasOne(user => user.Customer)
                .WithOne(user => user.ApplicationUser)
                .HasForeignKey<Customer>(user => user.CustomerId);

            modelBuilder.Entity<ProductCategory>()
                .HasKey(productCategory => new { productCategory.ProductId, productCategory.CategoryId });

            modelBuilder.Entity<ProductCategory>()
                .HasOne<Category>(productCategory => productCategory.Category)
                .WithMany(category => category.ProductCategories)
                .HasForeignKey(productCategory => productCategory.CategoryId);

            modelBuilder.Entity<ProductCategory>()
                .HasOne<Product>(productCategory => productCategory.Product)
                .WithMany(product => product.ProductCategories)
                .HasForeignKey(productCategory => productCategory.ProductId);

            /*
            modelBuilder.Entity<Order>()
                .HasOne<Customer>(order => order.Customer)
                .WithMany(customer => customer.Orders);

            modelBuilder.Entity<Order>()
                .HasMany<Product>(order => order.Products);
            */

            modelBuilder.Entity<Order>()
                .HasOne<ApplicationUser>(order => order.Customer)
                .WithMany(user => user.Orders)
                .HasForeignKey(order => order.CustomerId);
            
            modelBuilder.Entity<Product>()
                .HasOne<ProductImage>(product => product.ProductImage)
                .WithMany(productImage => productImage.Products)
                .HasForeignKey(product => product.ProductImageId);
           

            modelBuilder.Entity<ProductImage>().HasData(new List<ProductImage>
            {
                new ProductImage
                    {ImageId = 1, ImageTitle = "Chocolate Dream", ImageName = "cupcake-chocolate.jpg", ImageThumbName = "cupcake-chocolate.jpg"},
                new ProductImage
                    {ImageId = 2, ImageTitle = "Pink surprise", ImageName = "cupcake-strawberry.jpg", ImageThumbName = "cupcake-strawberry.jpg"},
                new ProductImage
                    {ImageId = 3, ImageTitle = "Plain delight", ImageName = "cupcake-glutenfree.jpg", ImageThumbName = "cupcake-glutenfree.jpg"},
                new ProductImage
                    {ImageId = 4, ImageTitle = "Peanut butter cup-cake", ImageName = "cupcake-peanut.jpg", ImageThumbName = "cupcake-peanut.jpg"},
                new ProductImage
                    {ImageId = 5, ImageTitle = "Nutella mountain", ImageName = "cupcake-nutella.jpg", ImageThumbName = "cupcake-nutella.jpg"},
                new ProductImage
                    {ImageId = 6, ImageTitle = "M&M don't sue us", ImageName = "cupcake-mm.jpg", ImageThumbName = "cupcake-mm.jpg"},
                new ProductImage
                    {ImageId = 7, ImageTitle = "Forest fruit", ImageName = "cupcake-forest.jpg", ImageThumbName = "cupcake-forest.jpg"},
                new ProductImage
                    {ImageId = 8, ImageTitle = "Oreo supreme", ImageName = "cupcakes-oreo.jpg", ImageThumbName = "cupcakes-oreo.jpg"},
                new ProductImage
                    {ImageId = 9, ImageTitle = "Lemon", ImageName = "cupcake-lemon.jpg", ImageThumbName = "cupcake-lemon.jpg"},
                new ProductImage
                    {ImageId = 10, ImageTitle = "Taste the rainbow", ImageName = "cupcake-rainbow.jpg", ImageThumbName = "cupcake-rainbow.jpg"},
            });

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
                    {Id=6, FirstName = "Jan", LastName="Andersson", Address="Gatgatan 2", PhoneNumber = "04422723", PostalCode="46723", City="Göteborg", Country="Sweden", Email="test@gmail.com" },
                new Customer
                    {Id=7, FirstName = "Sofia", LastName="Bosch", Address="Avenyn 1", PhoneNumber = "0543768798", PostalCode="67823", City="Berlin", Country="Germany", Email="raj@goteborg.se" },
            });

            Product chocolateDream = new Product
            { Id = 1001, Name = "Chocolate Dream", Description = "A delicious chocolate cupcake with belgian chocolate", CategoryId = 101, Price = 29, ProductImageId = 1 };
            Product pinkSurprise = new Product
            { Id = 1002, Name = "Pink surprise", Description = "A frosted strawberry cupcake, filled with strawberry jam", CategoryId = 102, Price = 22, ProductImageId = 2 };
            Product plainDelight = new Product
            { Id = 1003, Name = "Plain delight", Description = "A gluten free cupcake packed with flavor", CategoryId = 103, Price = 34, ProductImageId = 3 };
            Product peanutButterCupCake = new Product
            { Id = 1004, Name = "Peanut butter cup-cake", Description = "Filled with peanut butter and topped with delicious peanut frosting.", CategoryId = 103, Price = 34, ProductImageId = 4 };
            Product nutellaMountain = new Product
            { Id = 1005, Name = "Nutella mountain", Description = "This is the cupcake for you if you like all things Nutella.", CategoryId = 101, Price = 34, ProductImageId = 5 };
            Product mAndM = new Product
            { Id = 1006, Name = "M&M don't sue us", Description = "A cupcake made to look like a giant M&M.", CategoryId = 101, Price = 34, ProductImageId = 6 };
            Product forestFruit = new Product
            { Id = 1007, Name = "Forest fruit", Description = "Not the tea, instead a cupcake with every kind of berry.", CategoryId = 102, Price = 34, ProductImageId = 7 };
            Product oreoSupreme = new Product
            { Id = 1008, Name = "Oreo supreme", Description = "Oreo cookie on top as well as batter and frosting made from oreo's.", CategoryId = 101, Price = 34, ProductImageId = 8 };
            Product lemon = new Product
            { Id = 1009, Name = "Lemon", Description = "If you like something with a fresher taste, this cupcake is for you.", CategoryId = 103, Price = 34, ProductImageId = 9 };
            Product tasteTheRainbow = new Product
            { Id = 1010, Name = "Taste the rainbow", Description = "Every taste of the fruit rainbow you can imagine.", CategoryId = 102, Price = 34, ProductImageId = 10 };

            //filler products:
            Product fillerProduct1 = new Product
            { Id = 1011, Name = "Filler cupcake 1", Description = "Filler description", CategoryId = 104, Price = 11 };
            Product fillerProduct2 = new Product
            { Id = 1012, Name = "Filler cupcake 2", Description = "Filler description", CategoryId = 104, Price = 11 };
            Product fillerProduct3 = new Product
            { Id = 1013, Name = "Filler cupcake 3", Description = "Filler description", CategoryId = 104, Price = 11 };
            Product fillerProduct4 = new Product
            { Id = 1014, Name = "Filler cupcake 4", Description = "Filler description", CategoryId = 104, Price = 11 };

            Product fillerProduct5 = new Product
            { Id = 1015, Name = "Filler cupcake 5", Description = "Filler description", CategoryId = 105, Price = 11 };
            Product fillerProduct6 = new Product
            { Id = 1016, Name = "Filler cupcake 6", Description = "Filler description", CategoryId = 105, Price = 11 };
            Product fillerProduct7 = new Product
            { Id = 1017, Name = "Filler cupcake 7", Description = "Filler description", CategoryId = 105, Price = 11 };
            Product fillerProduct8 = new Product
            { Id = 1018, Name = "Filler cupcake 8", Description = "Filler description", CategoryId = 105, Price = 11 };

            Product fillerProduct9 = new Product
            { Id = 1019, Name = "Filler cupcake 9", Description = "Filler description", CategoryId = 106, Price = 11 };
            Product fillerProduct10 = new Product
            { Id = 1020, Name = "Filler cupcake 10", Description = "Filler description", CategoryId = 106, Price = 11 };
            Product fillerProduct11 = new Product
            { Id = 1021, Name = "Filler cupcake 11", Description = "Filler description", CategoryId = 106, Price = 11 };
            Product fillerProduct12 = new Product
            { Id = 1022, Name = "Filler cupcake 12", Description = "Filler description", CategoryId = 106, Price = 11 };

            modelBuilder.Entity<Product>().HasData(new List<Product>
            {
                chocolateDream, pinkSurprise, plainDelight,peanutButterCupCake,nutellaMountain,mAndM, forestFruit, oreoSupreme, tasteTheRainbow, lemon,
                fillerProduct1, fillerProduct2, fillerProduct3, fillerProduct4,
                fillerProduct5, fillerProduct6, fillerProduct7, fillerProduct8,
                fillerProduct9, fillerProduct10, fillerProduct11, fillerProduct12
            });

            modelBuilder.Entity<Category>().HasData(new List<Category>
            {
                new Category
                    {Id = 101, CategoryName = "Chocolate" },
                new Category
                    {Id = 102, CategoryName = "Fruit" },
                new Category
                    {Id = 103, CategoryName = "Vegan" },
                new Category
                    {Id = 104, CategoryName = "Filler Category 1" },
                new Category
                    {Id = 105, CategoryName = "Filler Category 2" },
                new Category
                    {Id = 106, CategoryName = "Filler Category 3" },
            });

            #region oDetails

            OrderDetail oDetail1 = new OrderDetail
            {
                OrderDetailId = 1,
                Quantity = 3, 
                ProductId = chocolateDream.Id, 
                ProductName = chocolateDream.Name, 
                Price = chocolateDream.Price, 
                OrderId = 1 
            };
            OrderDetail oDetail2 = new OrderDetail
            {
                OrderDetailId = 2,
                Quantity = 2,
                ProductId = pinkSurprise.Id,
                ProductName = pinkSurprise.Name, 
                OrderId = 2, 
                Price = pinkSurprise.Price 
            };
            OrderDetail oDetail3 = new OrderDetail
            {
                OrderDetailId = 3,
                Quantity = 5,
                ProductId = plainDelight.Id,
                ProductName = plainDelight.Name,
                OrderId = 3,
                Price = plainDelight.Price
            };
            OrderDetail oDetail4 = new OrderDetail
            {
                OrderDetailId = 4,
                Quantity = 3,
                ProductId = chocolateDream.Id,
                ProductName = chocolateDream.Name,
                OrderId = 3,
                Price = chocolateDream.Price
            };

            #region order 4
            OrderDetail oDetail5 = new OrderDetail
            {
                OrderDetailId = 5,
                Quantity = 3,
                ProductId = chocolateDream.Id,
                ProductName = chocolateDream.Name,
                OrderId = 4,
                Price = chocolateDream.Price
            };
            OrderDetail oDetail6 = new OrderDetail
            {
                OrderDetailId = 6,
                Quantity = 3,
                ProductId = pinkSurprise.Id,
                ProductName = pinkSurprise.Name,
                OrderId = 4,
                Price = pinkSurprise.Price
            };
            OrderDetail oDetail7 = new OrderDetail
            {
                OrderDetailId = 7,
                Quantity = 3,
                ProductId = plainDelight.Id,
                ProductName = plainDelight.Name,
                OrderId = 4,
                Price = plainDelight.Price
            };

            #endregion

            #region Odetails order5
            OrderDetail oDetail8 = new OrderDetail
            {
                OrderDetailId = 8,
                Quantity = 3,
                ProductId = chocolateDream.Id,
                ProductName = chocolateDream.Name,
                OrderId = 5,
                Price = chocolateDream.Price
            };

            OrderDetail oDetail9 = new OrderDetail
            {
                OrderDetailId = 9,
                Quantity = 3,
                ProductId = pinkSurprise.Id,
                ProductName = pinkSurprise.Name,
                OrderId = 5,
                Price = pinkSurprise.Price
            };

            OrderDetail oDetail10 = new OrderDetail
            {
                OrderDetailId = 10,
                Quantity = 3,
                ProductId = plainDelight.Id,
                ProductName = plainDelight.Name,
                OrderId = 5,
                Price = plainDelight.Price
            };

            #endregion

            #endregion

            string roleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            //users/customers
            string customerId = Guid.NewGuid().ToString();
            string customerId2 = Guid.NewGuid().ToString();
            string customerId3 = Guid.NewGuid().ToString();
            string customerId4 = Guid.NewGuid().ToString();

            //new 
            string customerId5 = Guid.NewGuid().ToString();
            string customerId6 = Guid.NewGuid().ToString();
            string customerId7 = Guid.NewGuid().ToString();

            Order order1 = new Order
            {
                OrderId = 1,
                Paid = true,
                OrderDate = DateTime.Now,
                TotalCost = oDetail1.Price * oDetail1.Quantity,
                CustomerId = customerId, 
            };
            Order order2 = new Order
            {
                OrderId = 2,
                Paid = true,
                OrderDate = DateTime.Now,
                TotalCost = oDetail2.Price * oDetail2.Quantity,
                CustomerId = customerId2
            };
            Order order3 = new Order
            {
                OrderId = 3,
                Paid = true,
                OrderDate = DateTime.Now,
                TotalCost = (oDetail3.Price * oDetail3.Quantity) + (oDetail4.Price * oDetail4.Quantity),
                CustomerId = customerId2
            };

            Order order4 = new Order
            {
                OrderId = 4,
                Paid = true,
                OrderDate = DateTime.Now,
                TotalCost = (oDetail5.Price * oDetail5.Quantity) + (oDetail6.Price * oDetail6.Quantity) + (oDetail7.Price * oDetail7.Quantity),
                CustomerId = customerId4
            };

            Order order5 = new Order
            {
                OrderId = 5,
                Paid = true,
                OrderDate = DateTime.Now,
                TotalCost = (oDetail8.Price * oDetail8.Quantity) + (oDetail9.Price * oDetail9.Quantity) + (oDetail10.Price * oDetail10.Quantity),
                CustomerId = customerId3
            };

            modelBuilder.Entity<OrderDetail>().HasData(oDetail1, oDetail2, oDetail3, oDetail4, oDetail5, oDetail6, oDetail7, oDetail8, oDetail9, oDetail10);

            modelBuilder.Entity<Order>().HasData(order1, order2, order3, order4, order5);

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

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = userId,
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    UserName = "admin@admin.com",
                    NormalizedUserName = "ADMIN@ADMIN.COM",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    FirstName = "Admin",
                    LastName = "Adminsson",
                    Address = "Adminvägen 1",
                    PostalCode = "12345",
                    City = "Admin city",
                    Country = "Admin country",
                    PhoneNumber = "123456578"
                },
                new ApplicationUser
                {
                    Id = customerId,
                    Email = "customer1@seeduser.com",
                    NormalizedEmail = "CUSTOMER1@SEEDUSER.COM",
                    UserName = "customer1@seeduser.com",
                    NormalizedUserName = "CUSTOMER1@SEEDUSER.COM",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    FirstName = "Arne",
                    LastName = "Karat",
                    Address = "Kanelgatan 3",
                    PhoneNumber = "043016624",
                    PostalCode = "23445",
                    City = "Visby",
                    Country = "Sweden"
                },
                new ApplicationUser
                {
                    Id = customerId2,
                    Email = "customer2@seeduser.com",
                    NormalizedEmail = "CUSTOMER2@SEEDUSER.COM",
                    UserName = "customer2@seeduser.com",
                    NormalizedUserName = "CUSTOMER2@SEEDUSER.COM",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    FirstName = "Kenneth",
                    LastName = "Svenzon",
                    Address = "Rimbo torg 1",
                    PhoneNumber = "0721453456",
                    PostalCode = "44565",
                    City = "Skövde",
                    Country = "Sweden"
                },
                new ApplicationUser
                {
                    Id = customerId3,
                    Email = "customer3@seeduser.com",
                    NormalizedEmail = "CUSTOMER3@SEEDUSER.COM",
                    UserName = "customer3@seeduser.com",
                    NormalizedUserName = "CUSTOMER3@SEEDUSER.COM",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    FirstName = "Angela",
                    LastName = "Melodi",
                    Address = "Kungsgatan 4",
                    PhoneNumber = "0771242424",
                    PostalCode = "32344",
                    City = "Arboga",
                    Country = "Sweden"
                },
                new ApplicationUser
                {
                    Id = customerId4,
                    Email = "customer4@seeduser.com",
                    NormalizedEmail = "CUSTOMER4@SEEDUSER.COM",
                    UserName = "customer4@seeduser.com",
                    NormalizedUserName = "CUSTOMER4@SEEDUSER.COM",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    FirstName = "Kaj",
                    LastName = "Fridell",
                    Address = "Royal Carnac Hotel 1",
                    PhoneNumber = "031184698",
                    PostalCode = "33467",
                    City = "Cairo",
                    Country = "Egypt"
                },
                new ApplicationUser
                {
                    Id = customerId5,
                    Email = "customer5@seeduser.com",
                    NormalizedEmail = "CUSTOMER5@SEEDUSER.COM",
                    UserName = "customer5@seeduser.com",
                    NormalizedUserName = "CUSTOMER5@SEEDUSER.COM",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    FirstName = "Molly",
                    LastName = "Sundkvist",
                    Address = "Vedgatan 3",
                    PhoneNumber = "0443346723",
                    PostalCode = "46723",
                    City = "Oslo",
                    Country = "Norway"
                },
                new ApplicationUser
                {
                    Id = customerId6,
                    Email = "customer6@seeduser.com",
                    NormalizedEmail = "CUSTOMER6@SEEDUSER.COM",
                    UserName = "customer6@seeduser.com",
                    NormalizedUserName = "CUSTOMER6@SEEDUSER.COM",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    FirstName = "Jan",
                    LastName = "Andersson",
                    Address = "Gatgatan 2",
                    PhoneNumber = "04422723",
                    PostalCode = "46723",
                    City = "Göteborg",
                    Country = "Sweden"
                },
                new ApplicationUser
                {
                    Id = customerId7,
                    Email = "customer7@seeduser.com",
                    NormalizedEmail = "CUSTOMER7@SEEDUSER.COM",
                    UserName = "customer7@seeduser.com",
                    NormalizedUserName = "CUSTOMER7@SEEDUSER.COM",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    FirstName = "Sofia",
                    LastName = "Bosch",
                    Address = "Behrenstrasse 2",
                    PhoneNumber = "0543768798",
                    PostalCode = "67823",
                    City = "Berlin",
                    Country = "Germany"
                });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roleId,
                    UserId = userId
                },
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = customerId
                }
                ,
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = customerId2
                }
                ,
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = customerId3
                }
                ,
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = customerId4
                },
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = customerId5
                }
                ,
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = customerId6
                }
                ,
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = customerId7
                });
        }
    }
}
