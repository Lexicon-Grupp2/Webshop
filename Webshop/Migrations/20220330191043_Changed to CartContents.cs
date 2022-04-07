using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class ChangedtoCartContents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6feb0c3a-cf96-4e8c-9e19-e1d7b54782d7");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b3c9a2d0-8b98-4a21-a77c-a7afa2bc7ace", "81a8c182-4ab5-44b2-ba6c-c81c2cffd91a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81a8c182-4ab5-44b2-ba6c-c81c2cffd91a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3c9a2d0-8b98-4a21-a77c-a7afa2bc7ace");

            migrationBuilder.CreateTable(
                name: "CartContents",
                columns: table => new
                {
                    CartContentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalCost = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: true),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartContents", x => x.CartContentId);
                    table.ForeignKey(
                        name: "FK_CartContents_Inventory_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CartContents_ProductId",
                table: "CartContents",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartContents");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81a8c182-4ab5-44b2-ba6c-c81c2cffd91a", "b782391d-4f55-478d-8d9e-6960b44f7843", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6feb0c3a-cf96-4e8c-9e19-e1d7b54782d7", "d5ebeeff-85ca-4883-92cd-72e65e48ce13", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b3c9a2d0-8b98-4a21-a77c-a7afa2bc7ace", 0, "8ea07928-acb9-4009-b616-1d28dbe24bbf", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEMYCia2e4SPOngd3WASPfZfnAXO8H2ZOwpNkrHmDxzDK97rSCPIQ6Pg9/Q23tDVNzw==", null, false, "acfafd8f-4087-4ef4-a6b0-40637ba9a1ca", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "b3c9a2d0-8b98-4a21-a77c-a7afa2bc7ace", "81a8c182-4ab5-44b2-ba6c-c81c2cffd91a" });
        }
    }
}
