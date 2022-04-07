using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class updatedinventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Receipts_ReceiptOrderId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6358af3-a7da-407f-a9f1-b55a35a426ed");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "726e0dfb-50fb-4e74-95f2-e4c829b72368", "ebe50e96-17a9-4c79-b25f-8792370d278d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebe50e96-17a9-4c79-b25f-8792370d278d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726e0dfb-50fb-4e74-95f2-e4c829b72368");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Inventory");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ReceiptOrderId",
                table: "Inventory",
                newName: "IX_Inventory_ReceiptOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Inventory",
                newName: "IX_Inventory_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Categories_CategoryId",
                table: "Inventory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Receipts_ReceiptOrderId",
                table: "Inventory",
                column: "ReceiptOrderId",
                principalTable: "Receipts",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Inventory_ProductId",
                table: "ProductCategories",
                column: "ProductId",
                principalTable: "Inventory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Categories_CategoryId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Receipts_ReceiptOrderId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Inventory_ProductId",
                table: "ProductCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory");

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

            migrationBuilder.RenameTable(
                name: "Inventory",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_ReceiptOrderId",
                table: "Products",
                newName: "IX_Products_ReceiptOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ebe50e96-17a9-4c79-b25f-8792370d278d", "ff375b2e-a4f9-4385-aa56-ad3168c00c79", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6358af3-a7da-407f-a9f1-b55a35a426ed", "ebdf4e28-d104-4bf6-b187-cb607e691d11", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "726e0dfb-50fb-4e74-95f2-e4c829b72368", 0, "3668c059-eb87-4f3b-aca5-aaae5717b4ed", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEL9KoiypoSFhofv16Nu7KxqpMNoKMM+QV+1BZTLiQp+tjF+5rxujbNIuRyPWmKgoew==", null, false, "44025c22-9580-4256-8f28-d7478cc0f6b6", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "726e0dfb-50fb-4e74-95f2-e4c829b72368", "ebe50e96-17a9-4c79-b25f-8792370d278d" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductId",
                table: "ProductCategories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Receipts_ReceiptOrderId",
                table: "Products",
                column: "ReceiptOrderId",
                principalTable: "Receipts",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
