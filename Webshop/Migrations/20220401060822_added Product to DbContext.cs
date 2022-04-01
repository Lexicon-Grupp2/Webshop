using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class addedProducttoDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartContents_Inventory_ProductId",
                table: "CartContents");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Categories_CategoryId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_ProductImages_ProductImageId",
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
                keyValue: "9f6bedd2-ea1d-4088-8bf1-18ac870741b0");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "341b538d-02b2-4435-ac15-f6e0350d4ab0", "f93e5397-7d00-44a4-b7a5-574e76b85eb2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f93e5397-7d00-44a4-b7a5-574e76b85eb2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341b538d-02b2-4435-ac15-f6e0350d4ab0");

            migrationBuilder.RenameTable(
                name: "Inventory",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_ReceiptOrderId",
                table: "Product",
                newName: "IX_Product_ReceiptOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_ProductImageId",
                table: "Product",
                newName: "IX_Product_ProductImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_CategoryId",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CartContents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a89a1d9-8d96-4124-a8e1-ede10da8df64", "c83a248f-b60b-4c07-b916-77234359ee21", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d727e25c-20d5-4ef7-9088-453c472c1567", "a9cd6169-9e5f-4d9a-a3c6-51212d1533b2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9c9cfcd0-3a4a-4930-b1ca-fc293f426997", 0, "846de2e9-2e59-4d8f-bf2b-362034e406d2", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEDE8H9y20BMSEsk7W/GRm6nBOVNjQa4ZV8St4Sm0DzjMzyjiazvh8JB0tSORJNrF6Q==", null, false, "f59d6c2e-b274-46db-bcae-8d237ea15f47", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "9c9cfcd0-3a4a-4930-b1ca-fc293f426997", "7a89a1d9-8d96-4124-a8e1-ede10da8df64" });

            migrationBuilder.AddForeignKey(
                name: "FK_CartContents_Product_ProductId",
                table: "CartContents",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductImages_ProductImageId",
                table: "Product",
                column: "ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Receipts_ReceiptOrderId",
                table: "Product",
                column: "ReceiptOrderId",
                principalTable: "Receipts",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Product_ProductId",
                table: "ProductCategories",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartContents_Product_ProductId",
                table: "CartContents");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductImages_ProductImageId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Receipts_ReceiptOrderId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Product_ProductId",
                table: "ProductCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d727e25c-20d5-4ef7-9088-453c472c1567");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9c9cfcd0-3a4a-4930-b1ca-fc293f426997", "7a89a1d9-8d96-4124-a8e1-ede10da8df64" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a89a1d9-8d96-4124-a8e1-ede10da8df64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c9cfcd0-3a4a-4930-b1ca-fc293f426997");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CartContents");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Inventory");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ReceiptOrderId",
                table: "Inventory",
                newName: "IX_Inventory_ReceiptOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductImageId",
                table: "Inventory",
                newName: "IX_Inventory_ProductImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Inventory",
                newName: "IX_Inventory_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f93e5397-7d00-44a4-b7a5-574e76b85eb2", "c7a72ac8-3d01-438b-a045-496d97ce7dee", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f6bedd2-ea1d-4088-8bf1-18ac870741b0", "f7b171a0-8602-46da-b224-346dbb855add", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "341b538d-02b2-4435-ac15-f6e0350d4ab0", 0, "c6a27a7e-69d9-4eb6-932f-b4cd9b039bb7", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEG/eGlyk7ZCCPHW+E02Mv6h7vICwoiVQjfjVwO+Wvi6ndH1du3+AK42NF0akxMGkgA==", null, false, "e3c799dc-2525-412a-9432-60e8a17920ce", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "341b538d-02b2-4435-ac15-f6e0350d4ab0", "f93e5397-7d00-44a4-b7a5-574e76b85eb2" });

            migrationBuilder.AddForeignKey(
                name: "FK_CartContents_Inventory_ProductId",
                table: "CartContents",
                column: "ProductId",
                principalTable: "Inventory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Categories_CategoryId",
                table: "Inventory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_ProductImages_ProductImageId",
                table: "Inventory",
                column: "ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "ImageId",
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
    }
}
