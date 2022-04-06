using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class Addedneoledscupcakesseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d75d8400-d6ed-4a2f-b1a0-167aba633515");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "45df147f-34ff-4cf1-95a4-8e01c7658dbc", "e0244aca-9ef1-4590-8083-2246eebc8d2c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0244aca-9ef1-4590-8083-2246eebc8d2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45df147f-34ff-4cf1-95a4-8e01c7658dbc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cc4cbade-0b9f-4ca2-8529-e22824ed0ebe", "2c7e7c7f-2d61-46c9-8005-a18e5003fc3d", "Admin", "ADMIN" },
                    { "1db1c6c0-028e-42db-a348-a84fccf07852", "7c05a208-4fa3-4ea8-93c6-8a1cfc6adeb4", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eb84e081-210e-4d00-b695-de05356e43c6", 0, "e7cd25ca-eb91-4713-8471-7f699b0ea7a0", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJ44Bzov9vbqmi6/S/bMTVNj/MdzluZq1FppHY6hu/P+YYrEoB2U1G7zK8XLtACK6w==", null, false, "ef8a79f1-5284-4117-998a-b8d34217356e", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 104, "Berries and fruits" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "OrderId", "Price", "ProductImageId" },
                values: new object[,]
                {
                    { 1005, 101, "This is the cupcake for you if you like all things Nutella.", "Nutella mountain", null, 34, 1 },
                    { 1006, 101, "A cupcake made to look like a giant M&M.", "M&M don't sue us", null, 34, 1 },
                    { 1008, 101, "Oreo cookie on top as well as batter and frosting made from oreo's.", "Oreo supreme", null, 34, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "eb84e081-210e-4d00-b695-de05356e43c6", "cc4cbade-0b9f-4ca2-8529-e22824ed0ebe" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "OrderId", "Price", "ProductImageId" },
                values: new object[,]
                {
                    { 1004, 104, "Filled with peanut butter and topped with delicious peanut frosting.", "Peanut butter cup-cake", null, 34, 1 },
                    { 1007, 104, "Not the tea, instead a cupcake with every kind of berry.", "Forest fruit", null, 34, 1 },
                    { 1009, 104, "If you like something with a fresher taste, this cupcake is for you.", "Lemon", null, 34, 1 },
                    { 1010, 104, "Every taste of the fruit rainbow you can imagine.", "Taste the rainbow", null, 34, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1db1c6c0-028e-42db-a348-a84fccf07852");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "eb84e081-210e-4d00-b695-de05356e43c6", "cc4cbade-0b9f-4ca2-8529-e22824ed0ebe" });

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc4cbade-0b9f-4ca2-8529-e22824ed0ebe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb84e081-210e-4d00-b695-de05356e43c6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0244aca-9ef1-4590-8083-2246eebc8d2c", "1c71a753-26c9-4904-be56-7d12d5b94d91", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d75d8400-d6ed-4a2f-b1a0-167aba633515", "d3167c1f-2e30-47c3-b754-8e0789fab572", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "45df147f-34ff-4cf1-95a4-8e01c7658dbc", 0, "d7fba127-ece8-4e75-bc1f-dee41dbc1f82", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFJeYJ1WmLaiYlxJAh6xpNUEGjTkiJgH7ypaR3eYMB0Dk/rknBwASCYMC68g76Rfsg==", null, false, "eeafc36e-7446-44f6-8db5-19b2a5dad01f", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "45df147f-34ff-4cf1-95a4-8e01c7658dbc", "e0244aca-9ef1-4590-8083-2246eebc8d2c" });
        }
    }
}
