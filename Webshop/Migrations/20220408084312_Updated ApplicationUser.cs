using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class UpdatedApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45f2c495-f316-4a94-91a5-a9cd0cf02dd0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "072cfc86-a988-4b01-9923-60fc8564c75d");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d31642e5-160f-45d7-8b31-0177d18cdca9", "1100559c-2880-441d-ad11-4132a31d6780", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c8e14939-d163-433a-9c51-31919ef5b47c", "9c0580db-b73f-48f1-b81b-4fc5decb4919", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6b7efa6f-d1ea-4812-89bd-0ab428617f7d", 0, "Adminvägen 1", "Admin city", "f1002b51-ac25-4dd0-8b0c-ccea95424808", "Admin country", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEDhW92XHoGcObXJIgiWpAJoswc//hfkcDAjN5nyuB024vCXpkNQLL3BvnagGV/SxwQ==", "123456578", false, "12345", "71f2a42c-4bd2-4dc9-9853-4f7fe7a39f51", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "6b7efa6f-d1ea-4812-89bd-0ab428617f7d", "d31642e5-160f-45d7-8b31-0177d18cdca9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8e14939-d163-433a-9c51-31919ef5b47c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6b7efa6f-d1ea-4812-89bd-0ab428617f7d", "d31642e5-160f-45d7-8b31-0177d18cdca9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31642e5-160f-45d7-8b31-0177d18cdca9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b7efa6f-d1ea-4812-89bd-0ab428617f7d");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45f2c495-f316-4a94-91a5-a9cd0cf02dd0", "b8b86ae2-63e0-486a-ac90-1601f975c7cc", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2843df3c-f0af-447d-85eb-995093a9ab8e", "f3fe6e86-5f7f-4b80-9257-6e33380a3791", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "072cfc86-a988-4b01-9923-60fc8564c75d", 0, "aa2921cb-c321-4c07-8699-b09aaf8b46ab", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEH6ucIbfNPxIpad+K8e5Wka3bXKgwc0AiW7Uz+Jot65YuP/GInYbcGS9in0SJchfWg==", null, false, "0d68c89d-a13d-48bb-85d2-1f511dc0a681", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "072cfc86-a988-4b01-9923-60fc8564c75d", "45f2c495-f316-4a94-91a5-a9cd0cf02dd0" });
        }
    }
}
