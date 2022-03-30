using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class addedProductImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94a8d3c5-d9a7-4073-a735-53a7f73213f3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9c520738-291d-402d-9f17-545a79e2f4fa", "959c8508-72d5-495b-a5cd-a04a2dc0300b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "959c8508-72d5-495b-a5cd-a04a2dc0300b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c520738-291d-402d-9f17-545a79e2f4fa");

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ImageId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b066cc0-65ce-43ba-95a5-f511680af264", "d04b2411-09e2-44af-b970-8726d4b7a9fd", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aa727466-2da9-4e18-8925-d854a5958787", "b609bc7a-9941-48cb-b236-30e552a9b5d0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cfadb1b7-160e-48f9-b0f7-566a86b3be2a", 0, "9c6a1b46-e7a9-4dd2-b379-bf417fb33c68", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEN8LkI1Ifg7wq+vEVKFKv7EhiyBJQe0baGAonY5g7AZfAxkHuYnR+lxanrcUma2Rpw==", null, false, "c67b52d1-1dbd-402a-8e35-6e4e1e5799de", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "cfadb1b7-160e-48f9-b0f7-566a86b3be2a", "9b066cc0-65ce-43ba-95a5-f511680af264" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa727466-2da9-4e18-8925-d854a5958787");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cfadb1b7-160e-48f9-b0f7-566a86b3be2a", "9b066cc0-65ce-43ba-95a5-f511680af264" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b066cc0-65ce-43ba-95a5-f511680af264");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfadb1b7-160e-48f9-b0f7-566a86b3be2a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "959c8508-72d5-495b-a5cd-a04a2dc0300b", "a42112e8-128b-428a-a13b-94e6e05d4f2d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94a8d3c5-d9a7-4073-a735-53a7f73213f3", "14c3d0d7-5815-4b75-8999-2113ea4a33b5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9c520738-291d-402d-9f17-545a79e2f4fa", 0, "04c51119-9afb-4743-82ad-01a2c4edf6ea", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEKx9ZDjeyljh5Ad+KucOzftgdAdnIXZt+5XaPzOQXO7BG49cXDEJurjwqjz6XxonWg==", null, false, "eaa837a1-a904-44ce-8e8d-5ab671a5199a", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "9c520738-291d-402d-9f17-545a79e2f4fa", "959c8508-72d5-495b-a5cd-a04a2dc0300b" });
        }
    }
}
