﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webshop.Data;

namespace Webshop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "16877cf5-b45b-4366-835f-893649832a6d",
                            ConcurrencyStamp = "e0a36cd8-c30f-49c0-9d22-1e24190172b2",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "d04cf07c-c98a-438e-9c8f-1097dec0378f",
                            ConcurrencyStamp = "dbce5c04-8d12-4840-b350-6b93c01c3620",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "90404b49-3a92-467e-953a-401f60f6784f",
                            RoleId = "16877cf5-b45b-4366-835f-893649832a6d"
                        },
                        new
                        {
                            UserId = "798fcdde-926d-4b3d-be32-e00821f27d52",
                            RoleId = "d04cf07c-c98a-438e-9c8f-1097dec0378f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Webshop.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "90404b49-3a92-467e-953a-401f60f6784f",
                            AccessFailedCount = 0,
                            Address = "Adminvägen 1",
                            City = "Admin city",
                            ConcurrencyStamp = "0224e0af-9498-4f11-9b53-767dced495ff",
                            Country = "Admin country",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminsson",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGPFACc2fv/T+2uPwaRS//0jeJ+10TQlDQVZNQFGRIrbUPvXDu5KNqIWcunSadrMbQ==",
                            PhoneNumber = "123456578",
                            PhoneNumberConfirmed = false,
                            PostalCode = "12345",
                            SecurityStamp = "163a7c60-aa39-4ef9-b1d2-0417d406a36b",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        },
                        new
                        {
                            Id = "798fcdde-926d-4b3d-be32-e00821f27d52",
                            AccessFailedCount = 0,
                            Address = "Kundvägen 11",
                            City = "Kundstaden",
                            ConcurrencyStamp = "3985b55f-2716-45e1-a4d8-0fb9fc537fd4",
                            Country = "Sverige",
                            Email = "seeduser@seeduser.com",
                            EmailConfirmed = false,
                            FirstName = "Kund",
                            LastName = "Kundsson",
                            LockoutEnabled = false,
                            NormalizedEmail = "SEEDUSER@SEEDUSER.COM",
                            NormalizedUserName = "SEEDUSER@SEEDUSER.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKDOXVMOogMNLS2aCD3fffufytI+34ouV6IMypcgqzqyl2SIgh+Khm0VK29WXZy/Ng==",
                            PhoneNumber = "87654321",
                            PhoneNumberConfirmed = false,
                            PostalCode = "12345",
                            SecurityStamp = "7d26e971-d6c2-4bf2-8d0b-b4af6d1d66d1",
                            TwoFactorEnabled = false,
                            UserName = "seeduser@seeduser.com"
                        });
                });

            modelBuilder.Entity("Webshop.Models.CartContent", b =>
                {
                    b.Property<int>("CartContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalCost")
                        .HasColumnType("int");

                    b.HasKey("CartContentId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartContents");
                });

            modelBuilder.Entity("Webshop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            CategoryName = "Chocolate"
                        },
                        new
                        {
                            Id = 102,
                            CategoryName = "Frosted"
                        },
                        new
                        {
                            Id = 103,
                            CategoryName = "Gluten free"
                        },
                        new
                        {
                            Id = 104,
                            CategoryName = "Berries and fruits"
                        });
                });

            modelBuilder.Entity("Webshop.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique()
                        .HasFilter("[CustomerId] IS NOT NULL");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Kanelgatan 3",
                            City = "Visby",
                            Country = "Sweden",
                            Email = "bling@gmail.com",
                            FirstName = "Arne",
                            LastName = "Karat",
                            PhoneNumber = "043016624",
                            PostalCode = "23445"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Rimbo torg 1",
                            City = "Skövde",
                            Country = "Sweden",
                            Email = "stekarn@gmail.com",
                            FirstName = "Kenneth",
                            LastName = "Svenzon",
                            PhoneNumber = "0721453456",
                            PostalCode = "44565"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Kungsgatan 4",
                            City = "Arboga",
                            Country = "Sweden",
                            Email = "lucky@hotmail.com",
                            FirstName = "Angela",
                            LastName = "Melodi",
                            PhoneNumber = "0771242424",
                            PostalCode = "32344"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Royal Carnac Hotel 1",
                            City = "Cairo",
                            Country = "Egypt",
                            Email = "kafr@egypt.gov",
                            FirstName = "Kaj",
                            LastName = "Fridell",
                            PhoneNumber = "031184698",
                            PostalCode = "33467"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Vedgatan 3",
                            City = "Oslo",
                            Country = "Norway",
                            Email = "tavlan@gmail.com",
                            FirstName = "Molly",
                            LastName = "Sundkvist",
                            PhoneNumber = "0443346723",
                            PostalCode = "46723"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Gatgatan 2",
                            City = "Göteborg",
                            Country = "Sweden",
                            Email = "test@gmail.com",
                            FirstName = "Jan",
                            LastName = "Andersson",
                            PhoneNumber = "04422723",
                            PostalCode = "46723"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Avenyn 1",
                            City = "Berlin",
                            Country = "Germany",
                            Email = "raj@goteborg.se",
                            FirstName = "Sofia",
                            LastName = "Bosch",
                            PhoneNumber = "0543768798",
                            PostalCode = "67823"
                        });
                });

            modelBuilder.Entity("Webshop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalCost")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Webshop.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Webshop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("ProductImageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductImageId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            CategoryId = 101,
                            Description = "A delicious chocolate cupcake with belgian chocolate",
                            Name = "Chocolate Dream",
                            Price = 29,
                            ProductImageId = 1
                        },
                        new
                        {
                            Id = 1002,
                            CategoryId = 102,
                            Description = "A frosted strawberry cupcake, filled with strawberry jam",
                            Name = "Pink surprise",
                            Price = 22
                        },
                        new
                        {
                            Id = 1003,
                            CategoryId = 103,
                            Description = "A gluten free cupcake packed with flavor",
                            Name = "Plain delight",
                            Price = 34
                        },
                        new
                        {
                            Id = 1004,
                            CategoryId = 104,
                            Description = "Filled with peanut butter and topped with delicious peanut frosting.",
                            Name = "Peanut butter cup-cake",
                            Price = 34
                        },
                        new
                        {
                            Id = 1005,
                            CategoryId = 101,
                            Description = "This is the cupcake for you if you like all things Nutella.",
                            Name = "Nutella mountain",
                            Price = 34
                        },
                        new
                        {
                            Id = 1006,
                            CategoryId = 101,
                            Description = "A cupcake made to look like a giant M&M.",
                            Name = "M&M don't sue us",
                            Price = 34
                        },
                        new
                        {
                            Id = 1007,
                            CategoryId = 104,
                            Description = "Not the tea, instead a cupcake with every kind of berry.",
                            Name = "Forest fruit",
                            Price = 34
                        },
                        new
                        {
                            Id = 1008,
                            CategoryId = 101,
                            Description = "Oreo cookie on top as well as batter and frosting made from oreo's.",
                            Name = "Oreo supreme",
                            Price = 34
                        },
                        new
                        {
                            Id = 1009,
                            CategoryId = 104,
                            Description = "If you like something with a fresher taste, this cupcake is for you.",
                            Name = "Lemon",
                            Price = 34
                        },
                        new
                        {
                            Id = 1010,
                            CategoryId = 104,
                            Description = "Every taste of the fruit rainbow you can imagine.",
                            Name = "Taste the rainbow",
                            Price = 34
                        });
                });

            modelBuilder.Entity("Webshop.Models.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Webshop.Models.ProductImage", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            ImageId = 1,
                            ImageName = "chokladbild.jpg",
                            ImageThumbName = "chokladbildth.jpg",
                            ImageTitle = "Chocolate Dream"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Webshop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Webshop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webshop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Webshop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Webshop.Models.CartContent", b =>
                {
                    b.HasOne("Webshop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Webshop.Models.Customer", b =>
                {
                    b.HasOne("Webshop.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("Customer")
                        .HasForeignKey("Webshop.Models.Customer", "CustomerId");
                });

            modelBuilder.Entity("Webshop.Models.Order", b =>
                {
                    b.HasOne("Webshop.Models.Customer", null)
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Webshop.Models.OrderDetail", b =>
                {
                    b.HasOne("Webshop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webshop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Webshop.Models.Product", b =>
                {
                    b.HasOne("Webshop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Webshop.Models.ProductImage", "ProductImage")
                        .WithMany("Products")
                        .HasForeignKey("ProductImageId");
                });

            modelBuilder.Entity("Webshop.Models.ProductCategory", b =>
                {
                    b.HasOne("Webshop.Models.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webshop.Models.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
