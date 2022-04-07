using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class AddedonetomanyProductImageProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb6278d0-26ca-47c5-94b7-dad5d170a912");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5ccb5a12-77ba-469f-82bc-bd4af2b4ef28", "8d4c439e-3470-4332-87a7-d4d4c8374742" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d4c439e-3470-4332-87a7-d4d4c8374742");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ccb5a12-77ba-469f-82bc-bd4af2b4ef28");

            migrationBuilder.AddColumn<int>(
                name: "ProductImageId",
                table: "Inventory",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "81a8c182-4ab5-44b2-ba6c-c81c2cffd91a", "b782391d-4f55-478d-8d9e-6960b44f7843", "Admin", "ADMIN" },
                    { "6feb0c3a-cf96-4e8c-9e19-e1d7b54782d7", "d5ebeeff-85ca-4883-92cd-72e65e48ce13", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b3c9a2d0-8b98-4a21-a77c-a7afa2bc7ace", 0, "8ea07928-acb9-4009-b616-1d28dbe24bbf", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEMYCia2e4SPOngd3WASPfZfnAXO8H2ZOwpNkrHmDxzDK97rSCPIQ6Pg9/Q23tDVNzw==", null, false, "acfafd8f-4087-4ef4-a6b0-40637ba9a1ca", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ImageId", "ImageName", "ImageThumbName", "ImageTitle" },
                values: new object[] { 1, "chokladtest.jpg", "chokladtestth.jpg", "Chocolate Dream" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "b3c9a2d0-8b98-4a21-a77c-a7afa2bc7ace", "81a8c182-4ab5-44b2-ba6c-c81c2cffd91a" });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1001,
                column: "ProductImageId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ProductImageId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ProductImageId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_ProductImageId",
                table: "Inventory",
                column: "ProductImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_ProductImages_ProductImageId",
                table: "Inventory",
                column: "ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_ProductImages_ProductImageId",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_ProductImageId",
                table: "Inventory");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6feb0c3a-cf96-4e8c-9e19-e1d7b54782d7");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b3c9a2d0-8b98-4a21-a77c-a7afa2bc7ace", "81a8c182-4ab5-44b2-ba6c-c81c2cffd91a" });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81a8c182-4ab5-44b2-ba6c-c81c2cffd91a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3c9a2d0-8b98-4a21-a77c-a7afa2bc7ace");

            migrationBuilder.DropColumn(
                name: "ProductImageId",
                table: "Inventory");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8d4c439e-3470-4332-87a7-d4d4c8374742", "855e00f9-4c97-426a-8d32-f6f153b0e49f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb6278d0-26ca-47c5-94b7-dad5d170a912", "f8a4ba43-ef12-426e-a9ec-1f553f2efd6a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5ccb5a12-77ba-469f-82bc-bd4af2b4ef28", 0, "110ae147-e6e8-49d1-aa99-4ac6e8cdbc26", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENFDANarq38QImEu6AU/Z6uazf7ia2JTlkllaxtQZRaVj4/eI5bt0ZUGaSuBraw7fA==", null, false, "06500670-258e-497c-b660-62cb386d0525", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "5ccb5a12-77ba-469f-82bc-bd4af2b4ef28", "8d4c439e-3470-4332-87a7-d4d4c8374742" });
        }
    }
}
