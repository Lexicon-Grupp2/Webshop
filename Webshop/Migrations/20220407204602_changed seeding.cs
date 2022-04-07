using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class changedseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fed4bc93-0480-4c6e-bbaf-43d76ffb7757");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cb017a0f-ea76-4e3f-ae53-87495002a538", "d8b8468d-c770-43d0-a7dc-b8ec6dd301c6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8b8468d-c770-43d0-a7dc-b8ec6dd301c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb017a0f-ea76-4e3f-ae53-87495002a538");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45f2c495-f316-4a94-91a5-a9cd0cf02dd0", "b8b86ae2-63e0-486a-ac90-1601f975c7cc", "Admin", "ADMIN" },
                    { "2843df3c-f0af-447d-85eb-995093a9ab8e", "f3fe6e86-5f7f-4b80-9257-6e33380a3791", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "072cfc86-a988-4b01-9923-60fc8564c75d", 0, "aa2921cb-c321-4c07-8699-b09aaf8b46ab", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEH6ucIbfNPxIpad+K8e5Wka3bXKgwc0AiW7Uz+Jot65YuP/GInYbcGS9in0SJchfWg==", null, false, "0d68c89d-a13d-48bb-85d2-1f511dc0a681", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 104, "Berries and fruits" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ProductImageId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ProductImageId",
                value: null);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "ProductImageId" },
                values: new object[,]
                {
                    { 1005, 101, "This is the cupcake for you if you like all things Nutella.", "Nutella mountain", 34, null },
                    { 1006, 101, "A cupcake made to look like a giant M&M.", "M&M don't sue us", 34, null },
                    { 1008, 101, "Oreo cookie on top as well as batter and frosting made from oreo's.", "Oreo supreme", 34, null }
                });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ImageId",
                keyValue: 1,
                columns: new[] { "ImageName", "ImageThumbName" },
                values: new object[] { "chokladbild.jpg", "chokladbildth.jpg" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "072cfc86-a988-4b01-9923-60fc8564c75d", "45f2c495-f316-4a94-91a5-a9cd0cf02dd0" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "ProductImageId" },
                values: new object[,]
                {
                    { 1004, 104, "Filled with peanut butter and topped with delicious peanut frosting.", "Peanut butter cup-cake", 34, null },
                    { 1007, 104, "Not the tea, instead a cupcake with every kind of berry.", "Forest fruit", 34, null },
                    { 1009, 104, "If you like something with a fresher taste, this cupcake is for you.", "Lemon", 34, null },
                    { 1010, 104, "Every taste of the fruit rainbow you can imagine.", "Taste the rainbow", 34, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2843df3c-f0af-447d-85eb-995093a9ab8e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "072cfc86-a988-4b01-9923-60fc8564c75d", "45f2c495-f316-4a94-91a5-a9cd0cf02dd0" });

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
                keyValue: "45f2c495-f316-4a94-91a5-a9cd0cf02dd0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "072cfc86-a988-4b01-9923-60fc8564c75d");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d8b8468d-c770-43d0-a7dc-b8ec6dd301c6", "7126a0a0-9790-479a-9526-aab46ca40c3d", "Admin", "ADMIN" },
                    { "fed4bc93-0480-4c6e-bbaf-43d76ffb7757", "ad2be820-a618-4a44-9ae5-599361dce737", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cb017a0f-ea76-4e3f-ae53-87495002a538", 0, "7228c0bd-c37f-4c10-98b5-5ba5158b4bcd", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENK8aVK7rrkCjUvsEHqGsoIgc1eKrUtXbLgJF8mf9etlcI6eVMZpPQ8f+XLrft8INg==", null, false, "c04c9959-32c7-430a-b6f7-914b2aefcd71", false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ProductImageId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ProductImageId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ImageId",
                keyValue: 1,
                columns: new[] { "ImageName", "ImageThumbName" },
                values: new object[] { "chokladtest.jpg", "chokladtestth.jpg" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "cb017a0f-ea76-4e3f-ae53-87495002a538", "d8b8468d-c770-43d0-a7dc-b8ec6dd301c6" });
        }
    }
}
