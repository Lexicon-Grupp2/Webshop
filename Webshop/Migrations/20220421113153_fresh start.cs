using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class freshstart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    ImageThumbName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ImageId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: true),
                    ProductImageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_ProductImages_ProductImageId",
                        column: x => x.ProductImageId,
                        principalTable: "ProductImages",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    Paid = table.Column<bool>(nullable: false),
                    TotalCost = table.Column<int>(nullable: false),
                    CustomerId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartContents",
                columns: table => new
                {
                    CartContentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalCost = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartContents", x => x.CartContentId);
                    table.ForeignKey(
                        name: "FK_CartContents_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e026298-1349-4df0-a0ab-db3776de2466", "32cdf9f1-ebf6-40b3-bf6d-36a2ac597f11", "Admin", "ADMIN" },
                    { "e1d331a6-be61-4455-937a-8b87c40b27b3", "076ada64-74fd-4880-915e-e28ce5b61201", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "829681d9-960f-4357-9643-c37895f51a30", 0, "Gatgatan 2", "Göteborg", "6c4b2feb-d1bd-4da7-9af2-8f180a43781f", "Sweden", "customer6@seeduser.com", false, "Jan", "Andersson", false, null, "CUSTOMER6@SEEDUSER.COM", "CUSTOMER6@SEEDUSER.COM", "AQAAAAEAACcQAAAAEBB4ENNq57PLMuL1DlvMfXyBnHA+gVd7zzPkLdKTg6dEUWlC9FTtToo5a5oi75c2tA==", "04422723", false, "46723", "57c82a15-d2be-4a7c-aa4a-6a9defcba9df", false, "customer6@seeduser.com" },
                    { "25297ffc-4948-4554-acb4-bacb814e12cd", 0, "Vedgatan 3", "Oslo", "51c0accd-77a1-4be5-b05d-5a3da446bd18", "Norway", "customer5@seeduser.com", false, "Molly", "Sundkvist", false, null, "CUSTOMER5@SEEDUSER.COM", "CUSTOMER5@SEEDUSER.COM", "AQAAAAEAACcQAAAAEMlDoWtVNcOnFFogHa5M/FO6JzmgvAVZQuacetAR170GG9bRYId96GVUdmOdm18l5w==", "0443346723", false, "46723", "4e23bede-0709-408a-a479-bfcb9f7e5392", false, "customer5@seeduser.com" },
                    { "58de2905-6534-46f6-baf2-bd4732df92b3", 0, "Royal Carnac Hotel 1", "Cairo", "d73275cd-74ab-478a-955d-bbb7a53ba6f4", "Egypt", "customer4@seeduser.com", false, "Kaj", "Fridell", false, null, "CUSTOMER4@SEEDUSER.COM", "CUSTOMER4@SEEDUSER.COM", "AQAAAAEAACcQAAAAECTQtEE18AX9trLO6Fc1YidW/kSBJyl0e4JrxvyT10TJ2iTym4x17WIsaxCB5D3a8g==", "031184698", false, "33467", "e9dec03f-37fe-4c05-b1a3-0302bef0ee20", false, "customer4@seeduser.com" },
                    { "4c9cb475-463a-48fb-a46c-206336317809", 0, "Behrenstrasse 2", "Berlin", "70e518e8-a251-414a-a3fd-3720d37ca328", "Germany", "customer7@seeduser.com", false, "Sofia", "Bosch", false, null, "CUSTOMER7@SEEDUSER.COM", "CUSTOMER7@SEEDUSER.COM", "AQAAAAEAACcQAAAAEAX4WxA40V9fytbXPXaS3eShvnSLyUGfckdyn/iXKyT6N4andSZx6+okrC9BZR+AnA==", "0543768798", false, "67823", "0cc6fdbf-b3a0-45b8-9be9-54e9aaf7e232", false, "customer7@seeduser.com" },
                    { "b1c5efd8-ecbc-484d-bd2b-26ad81690c72", 0, "Rimbo torg 1", "Skövde", "8dbd9e68-fbc3-44e2-addc-d60d820a5094", "Sweden", "customer2@seeduser.com", false, "Kenneth", "Svenzon", false, null, "CUSTOMER2@SEEDUSER.COM", "CUSTOMER2@SEEDUSER.COM", "AQAAAAEAACcQAAAAEKB8MmuMD3W8q0wPTSBJY4ml5QrLf2sChKnEyc9AKCF+fdDlqnkRgmMF4YYDv4VwYA==", "0721453456", false, "44565", "3d22f119-0243-4a3f-a73c-114e5d15b87b", false, "customer2@seeduser.com" },
                    { "9b4974b6-a7c0-429a-babe-da33b0b597ee", 0, "Kanelgatan 3", "Visby", "90e656d6-a8f3-47c9-bbeb-00ddf561b62a", "Sweden", "customer1@seeduser.com", false, "Arne", "Karat", false, null, "CUSTOMER1@SEEDUSER.COM", "CUSTOMER1@SEEDUSER.COM", "AQAAAAEAACcQAAAAELEtfMjiQl1FMOMG65N/lqHpAQf+TteGw0qTkdlFWXxCqfLKkHAEznDlV+Wx2zhdGg==", "043016624", false, "23445", "d59d6648-841a-4023-880a-8572b5ae2ec0", false, "customer1@seeduser.com" },
                    { "6b8967b9-ad31-4615-9c7b-7c61fa98fe18", 0, "Adminvägen 1", "Admin city", "e660749c-7180-43a8-b351-4c0ae798bc88", "Admin country", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFff51W/c1TVtIFvU0s2wt0GBDIEAF55d9jUF4MfmzXEOcEv2W3VXpU85ijtb9pAuQ==", "123456578", false, "12345", "5f77815a-4e54-4da1-832b-35b4f4309169", false, "admin@admin.com" },
                    { "636ee032-d79b-4d01-9bad-085029abf952", 0, "Kungsgatan 4", "Arboga", "d993dcba-e91d-4c11-a352-4863875f704f", "Sweden", "customer3@seeduser.com", false, "Angela", "Melodi", false, null, "CUSTOMER3@SEEDUSER.COM", "CUSTOMER3@SEEDUSER.COM", "AQAAAAEAACcQAAAAEEkgUNaPLjSVxMyD6RlJ0S32tkDGs04a2RMnc0C6rJNX3WZzLKrKl8o0srCfRsdpMg==", "0771242424", false, "32344", "a729868b-62b2-4525-87f9-d07580f65ce8", false, "customer3@seeduser.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 101, "Chocolate" },
                    { 102, "Fruit" },
                    { 103, "Vegan" },
                    { 104, "Filler Category 1" },
                    { 105, "Filler Category 2" },
                    { 106, "Filler Category 3" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Country", "CustomerId", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode" },
                values: new object[,]
                {
                    { 6, "Gatgatan 2", "Göteborg", "Sweden", null, "test@gmail.com", "Jan", "Andersson", "04422723", "46723" },
                    { 7, "Avenyn 1", "Berlin", "Germany", null, "raj@goteborg.se", "Sofia", "Bosch", "0543768798", "67823" },
                    { 5, "Vedgatan 3", "Oslo", "Norway", null, "tavlan@gmail.com", "Molly", "Sundkvist", "0443346723", "46723" },
                    { 1, "Kanelgatan 3", "Visby", "Sweden", null, "bling@gmail.com", "Arne", "Karat", "043016624", "23445" },
                    { 3, "Kungsgatan 4", "Arboga", "Sweden", null, "lucky@hotmail.com", "Angela", "Melodi", "0771242424", "32344" },
                    { 2, "Rimbo torg 1", "Skövde", "Sweden", null, "stekarn@gmail.com", "Kenneth", "Svenzon", "0721453456", "44565" },
                    { 4, "Royal Carnac Hotel 1", "Cairo", "Egypt", null, "kafr@egypt.gov", "Kaj", "Fridell", "031184698", "33467" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ImageId", "ImageName", "ImageThumbName", "ImageTitle" },
                values: new object[,]
                {
                    { 9, "cupcake-lemon.jpg", "cupcake-lemon.jpg", "Lemon" },
                    { 1, "cupcake-chocolate.jpg", "cupcake-chocolate.jpg", "Chocolate Dream" },
                    { 2, "cupcake-strawberry.jpg", "cupcake-strawberry.jpg", "Pink surprise" },
                    { 3, "cupcake-glutenfree.jpg", "cupcake-glutenfree.jpg", "Plain delight" },
                    { 4, "cupcake-peanut.jpg", "cupcake-peanut.jpg", "Peanut butter cup-cake" },
                    { 5, "cupcake-nutella.jpg", "cupcake-nutella.jpg", "Nutella mountain" },
                    { 6, "cupcake-mm.jpg", "cupcake-mm.jpg", "M&M don't sue us" },
                    { 7, "cupcake-forest.jpg", "cupcake-forest.jpg", "Forest fruit" },
                    { 8, "cupcakes-oreo.jpg", "cupcakes-oreo.jpg", "Oreo supreme" },
                    { 10, "cupcake-rainbow.jpg", "cupcake-rainbow.jpg", "Taste the rainbow" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "6b8967b9-ad31-4615-9c7b-7c61fa98fe18", "1e026298-1349-4df0-a0ab-db3776de2466" },
                    { "4c9cb475-463a-48fb-a46c-206336317809", "e1d331a6-be61-4455-937a-8b87c40b27b3" },
                    { "25297ffc-4948-4554-acb4-bacb814e12cd", "e1d331a6-be61-4455-937a-8b87c40b27b3" },
                    { "58de2905-6534-46f6-baf2-bd4732df92b3", "e1d331a6-be61-4455-937a-8b87c40b27b3" },
                    { "636ee032-d79b-4d01-9bad-085029abf952", "e1d331a6-be61-4455-937a-8b87c40b27b3" },
                    { "829681d9-960f-4357-9643-c37895f51a30", "e1d331a6-be61-4455-937a-8b87c40b27b3" },
                    { "b1c5efd8-ecbc-484d-bd2b-26ad81690c72", "e1d331a6-be61-4455-937a-8b87c40b27b3" },
                    { "9b4974b6-a7c0-429a-babe-da33b0b597ee", "e1d331a6-be61-4455-937a-8b87c40b27b3" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "CustomerId1", "OrderDate", "Paid", "TotalCost" },
                values: new object[,]
                {
                    { 2, "b1c5efd8-ecbc-484d-bd2b-26ad81690c72", null, new DateTime(2022, 4, 21, 13, 31, 53, 27, DateTimeKind.Local).AddTicks(2968), true, 44 },
                    { 5, "636ee032-d79b-4d01-9bad-085029abf952", null, new DateTime(2022, 4, 21, 13, 31, 53, 27, DateTimeKind.Local).AddTicks(3056), true, 255 },
                    { 4, "58de2905-6534-46f6-baf2-bd4732df92b3", null, new DateTime(2022, 4, 21, 13, 31, 53, 27, DateTimeKind.Local).AddTicks(3051), true, 255 },
                    { 1, "9b4974b6-a7c0-429a-babe-da33b0b597ee", null, new DateTime(2022, 4, 21, 13, 31, 53, 24, DateTimeKind.Local).AddTicks(8272), true, 87 },
                    { 3, "b1c5efd8-ecbc-484d-bd2b-26ad81690c72", null, new DateTime(2022, 4, 21, 13, 31, 53, 27, DateTimeKind.Local).AddTicks(3046), true, 257 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "ProductImageId" },
                values: new object[,]
                {
                    { 1001, 101, "A delicious chocolate cupcake with belgian chocolate", "Chocolate Dream", 29, 1 },
                    { 1002, 102, "A frosted strawberry cupcake, filled with strawberry jam", "Pink surprise", 22, 2 },
                    { 1003, 103, "A gluten free cupcake packed with flavor", "Plain delight", 34, 3 },
                    { 1004, 103, "Filled with peanut butter and topped with delicious peanut frosting.", "Peanut butter cup-cake", 34, 4 },
                    { 1007, 102, "Not the tea, instead a cupcake with every kind of berry.", "Forest fruit", 34, 7 },
                    { 1006, 101, "A cupcake made to look like a giant M&M.", "M&M don't sue us", 34, 6 },
                    { 1008, 101, "Oreo cookie on top as well as batter and frosting made from oreo's.", "Oreo supreme", 34, 8 },
                    { 1022, 106, "Filler description", "Filler cupcake 12", 11, null },
                    { 1005, 101, "This is the cupcake for you if you like all things Nutella.", "Nutella mountain", 34, 5 },
                    { 1021, 106, "Filler description", "Filler cupcake 11", 11, null },
                    { 1015, 105, "Filler description", "Filler cupcake 5", 11, null },
                    { 1019, 106, "Filler description", "Filler cupcake 9", 11, null },
                    { 1018, 105, "Filler description", "Filler cupcake 8", 11, null },
                    { 1017, 105, "Filler description", "Filler cupcake 7", 11, null },
                    { 1016, 105, "Filler description", "Filler cupcake 6", 11, null },
                    { 1009, 103, "If you like something with a fresher taste, this cupcake is for you.", "Lemon", 34, 9 },
                    { 1014, 104, "Filler description", "Filler cupcake 4", 11, null },
                    { 1013, 104, "Filler description", "Filler cupcake 3", 11, null },
                    { 1012, 104, "Filler description", "Filler cupcake 2", 11, null },
                    { 1011, 104, "Filler description", "Filler cupcake 1", 11, null },
                    { 1020, 106, "Filler description", "Filler cupcake 10", 11, null },
                    { 1010, 102, "Every taste of the fruit rainbow you can imagine.", "Taste the rainbow", 34, 10 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "Price", "ProductId", "ProductName", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 29, 1001, "Chocolate Dream", 3 },
                    { 4, 3, 29, 1001, "Chocolate Dream", 3 },
                    { 5, 4, 29, 1001, "Chocolate Dream", 3 },
                    { 8, 5, 29, 1001, "Chocolate Dream", 3 },
                    { 2, 2, 22, 1002, "Pink surprise", 2 },
                    { 6, 4, 22, 1002, "Pink surprise", 3 },
                    { 9, 5, 22, 1002, "Pink surprise", 3 },
                    { 3, 3, 34, 1003, "Plain delight", 5 },
                    { 7, 4, 34, 1003, "Plain delight", 3 },
                    { 10, 5, 34, 1003, "Plain delight", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartContents_ProductId",
                table: "CartContents",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerId",
                table: "Customers",
                column: "CustomerId",
                unique: true,
                filter: "[CustomerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId1",
                table: "Orders",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductImageId",
                table: "Product",
                column: "ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartContents");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
