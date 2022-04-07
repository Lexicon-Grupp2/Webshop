using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3ec7347-324c-4e28-a4ed-a1919c479c23");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2ab4357a-9a38-4534-8e93-26c1d5569979", "4feeca24-0bf7-4343-9ceb-9cf68f20dfa4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4feeca24-0bf7-4343-9ceb-9cf68f20dfa4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ab4357a-9a38-4534-8e93-26c1d5569979");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2dd1dec-6c5e-4514-b49b-3ab48776cf08", "3799befd-f6bc-4b02-87c4-910f821243a0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80226db6-7f72-4c78-9f77-b59bcaba4fb3", "cc285142-d8da-46c9-a679-069cfbbc09bd", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "85c23ab5-a030-408d-a5de-8753bf0235df", 0, "49f0f1d9-1f77-4a65-886f-d7d26d0ba987", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELMn5eS1AwD3WsRF78uAd0RIznCKbAlAmBVyYmLiT5Q4IoKqbyB+ymOe1MZkMNADVQ==", null, false, "58655d09-d747-4fc2-b415-18068f86aa1c", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "85c23ab5-a030-408d-a5de-8753bf0235df", "c2dd1dec-6c5e-4514-b49b-3ab48776cf08" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80226db6-7f72-4c78-9f77-b59bcaba4fb3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "85c23ab5-a030-408d-a5de-8753bf0235df", "c2dd1dec-6c5e-4514-b49b-3ab48776cf08" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2dd1dec-6c5e-4514-b49b-3ab48776cf08");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85c23ab5-a030-408d-a5de-8753bf0235df");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4feeca24-0bf7-4343-9ceb-9cf68f20dfa4", "0fbe93cd-b97c-4d90-9c69-f1019a457975", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f3ec7347-324c-4e28-a4ed-a1919c479c23", "c4c1a46c-9285-4eb1-880c-4ab016511013", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2ab4357a-9a38-4534-8e93-26c1d5569979", 0, "4cafbdfc-b545-448e-81ad-3db0cfa4794b", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEI03ZIIz3qlTTzoWPPaKPUwD2D+jR4d1i/hCXmUEA4X60voIFmTb1RMmSjhqJyOxCg==", null, false, "9ef20d66-fde9-40a8-bbe9-4864e9a1e72c", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "2ab4357a-9a38-4534-8e93-26c1d5569979", "4feeca24-0bf7-4343-9ceb-9cf68f20dfa4" });
        }
    }
}
