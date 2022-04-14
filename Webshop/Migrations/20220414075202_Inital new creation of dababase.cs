using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class Initalnewcreationofdababase : Migration
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
                    Name = table.Column<string>(nullable: true),
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
                    { "5311855d-e63a-4b5f-a003-dc747533181e", "ed30944f-5233-4e67-94d9-b1c467dd9d96", "Admin", "ADMIN" },
                    { "a12b1fd4-2ca5-45d7-a99f-984c574ddab6", "a8e2371a-ccd1-4ab9-b3fa-f12e294470d0", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "91ae4ef7-22e1-4c9a-9157-6ce082553e41", 0, "Adminvägen 1", "Admin city", "1c551551-0d61-47a0-9a07-060369a9a6da", "Admin country", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENF+mGn5x2aNgfGSDeaHtGueElIiB2QW4VfXaMocOiPflvslYqZqLxyLSBdaKn4Jyw==", "123456578", false, "12345", "7e5d35da-af27-4a7c-afbe-a08e53bdda78", false, "admin@admin.com" },
                    { "296c6000-35ba-4241-8a57-7d89c7acddf9", 0, "Kanelgatan 3", "Visby", "76e62cb3-dd93-416e-b57a-1c8173cb01fa", "Sweden", "customer1@seeduser.com", false, "Arne", "Karat", false, null, "CUSTOMER1@SEEDUSER.COM", "CUSTOMER1@SEEDUSER.COM", "AQAAAAEAACcQAAAAEPSMr5QJDlPdyruaGiG4FKV659V3TL3+5pxeWpih1l5/afrrrJlNBRooB8lSsPYzWQ==", "043016624", false, "23445", "1425a7f9-d140-48a1-9035-c036dbc78911", false, "customer1@seeduser.com" },
                    { "84829134-dbb3-4548-a832-5c7dd07c3793", 0, "Rimbo torg 1", "Skövde", "bf76b5aa-27d2-4657-a4c0-0d8a87954946", "Sweden", "customer2@seeduser.com", false, "Kenneth", "Svenzon", false, null, "CUSTOMER2@SEEDUSER.COM", "CUSTOMER2@SEEDUSER.COM", "AQAAAAEAACcQAAAAEN1fVQLFyGfbObvgHWTnjJ10OiTVeRKptEKTtbldetyi9qXUsxuX0MWCtj0M8JAV0A==", "0721453456", false, "44565", "c4606722-7045-465a-931e-9f49c9f89c63", false, "customer2@seeduser.com" },
                    { "b874b562-3058-4d3c-95c6-55870b7973bb", 0, "Kungsgatan 4", "Arboga", "f2a1092c-106b-4adb-931e-1e1a893e59c8", "Sweden", "customer3@seeduser.com", false, "Angela", "Melodi", false, null, "CUSTOMER3@SEEDUSER.COM", "CUSTOMER3@SEEDUSER.COM", "AQAAAAEAACcQAAAAEPfSMT3AsbyUZ/8/T1jleBvpWemDKbTmsUEQsP28HSus7azgUiNURlIPwpn6GJ/nKg==", "0771242424", false, "32344", "e4c5a146-a5d8-43ed-b8e6-f125be814f2f", false, "customer3@seeduser.com" },
                    { "40fc262c-767f-4b6f-b9aa-ba08b911b878", 0, "Royal Carnac Hotel 1", "Cairo", "6ee17bd2-f47c-4a1a-af30-8ac4a482274f", "Egypt", "seeduser@seeduser.com", false, "Kaj", "Fridell", false, null, "SEEDUSER@SEEDUSER.COM", "SEEDUSER@SEEDUSER.COM", "AQAAAAEAACcQAAAAEOjWoaL8UudZ7Dy8etegZOnABjWy06mB0EHofC+qdrB94dTy6bFYR1sVrYLT/0rcQw==", "031184698", false, "33467", "de7101cd-8180-4984-a9c6-52d05300ff71", false, "seeduser@seeduser.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 104, "Berries and fruits" },
                    { 103, "Gluten free" },
                    { 101, "Chocolate" },
                    { 102, "Frosted" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Country", "CustomerId", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode" },
                values: new object[,]
                {
                    { 7, "Avenyn 1", "Berlin", "Germany", null, "raj@goteborg.se", "Sofia", "Bosch", "0543768798", "67823" },
                    { 1, "Kanelgatan 3", "Visby", "Sweden", null, "bling@gmail.com", "Arne", "Karat", "043016624", "23445" },
                    { 2, "Rimbo torg 1", "Skövde", "Sweden", null, "stekarn@gmail.com", "Kenneth", "Svenzon", "0721453456", "44565" },
                    { 3, "Kungsgatan 4", "Arboga", "Sweden", null, "lucky@hotmail.com", "Angela", "Melodi", "0771242424", "32344" },
                    { 4, "Royal Carnac Hotel 1", "Cairo", "Egypt", null, "kafr@egypt.gov", "Kaj", "Fridell", "031184698", "33467" },
                    { 5, "Vedgatan 3", "Oslo", "Norway", null, "tavlan@gmail.com", "Molly", "Sundkvist", "0443346723", "46723" },
                    { 6, "Gatgatan 2", "Göteborg", "Sweden", null, "test@gmail.com", "Jan", "Andersson", "04422723", "46723" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ImageId", "ImageName", "ImageThumbName", "ImageTitle" },
                values: new object[] { 1, "chokladbild.jpg", "chokladbildth.jpg", "Chocolate Dream" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "91ae4ef7-22e1-4c9a-9157-6ce082553e41", "5311855d-e63a-4b5f-a003-dc747533181e" },
                    { "296c6000-35ba-4241-8a57-7d89c7acddf9", "a12b1fd4-2ca5-45d7-a99f-984c574ddab6" },
                    { "84829134-dbb3-4548-a832-5c7dd07c3793", "a12b1fd4-2ca5-45d7-a99f-984c574ddab6" },
                    { "b874b562-3058-4d3c-95c6-55870b7973bb", "a12b1fd4-2ca5-45d7-a99f-984c574ddab6" },
                    { "40fc262c-767f-4b6f-b9aa-ba08b911b878", "a12b1fd4-2ca5-45d7-a99f-984c574ddab6" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "CustomerId1", "OrderDate", "Paid", "TotalCost" },
                values: new object[,]
                {
                    { 1, "296c6000-35ba-4241-8a57-7d89c7acddf9", null, new DateTime(2022, 4, 14, 9, 52, 2, 481, DateTimeKind.Local).AddTicks(9769), true, 87 },
                    { 2, "84829134-dbb3-4548-a832-5c7dd07c3793", null, new DateTime(2022, 4, 14, 9, 52, 2, 484, DateTimeKind.Local).AddTicks(5303), true, 44 },
                    { 3, "84829134-dbb3-4548-a832-5c7dd07c3793", null, new DateTime(2022, 4, 14, 9, 52, 2, 484, DateTimeKind.Local).AddTicks(5387), true, 257 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "ProductImageId" },
                values: new object[,]
                {
                    { 1009, 104, "If you like something with a fresher taste, this cupcake is for you.", "Lemon", 34, null },
                    { 1007, 104, "Not the tea, instead a cupcake with every kind of berry.", "Forest fruit", 34, null },
                    { 1004, 104, "Filled with peanut butter and topped with delicious peanut frosting.", "Peanut butter cup-cake", 34, null },
                    { 1003, 103, "A gluten free cupcake packed with flavor", "Plain delight", 34, null },
                    { 1005, 101, "This is the cupcake for you if you like all things Nutella.", "Nutella mountain", 34, null },
                    { 1008, 101, "Oreo cookie on top as well as batter and frosting made from oreo's.", "Oreo supreme", 34, null },
                    { 1006, 101, "A cupcake made to look like a giant M&M.", "M&M don't sue us", 34, null },
                    { 1010, 104, "Every taste of the fruit rainbow you can imagine.", "Taste the rainbow", 34, null },
                    { 1002, 102, "A frosted strawberry cupcake, filled with strawberry jam", "Pink surprise", 22, null },
                    { 1001, 101, "A delicious chocolate cupcake with belgian chocolate", "Chocolate Dream", 29, 1 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "Price", "ProductId", "ProductName", "Quantity" },
                values: new object[,]
                {
                    { 2, 2, 22, 1002, "Pink surprise", 2 },
                    { 3, 3, 34, 1003, "Plain delight", 5 },
                    { 1, 1, 29, 1001, "Chocolate Dream", 3 },
                    { 4, 3, 29, 1001, "Chocolate Dream", 3 }
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
