using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class added1seededuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16877cf5-b45b-4366-835f-893649832a6d", "e0a36cd8-c30f-49c0-9d22-1e24190172b2", "Admin", "ADMIN" },
                    { "d04cf07c-c98a-438e-9c8f-1097dec0378f", "dbce5c04-8d12-4840-b350-6b93c01c3620", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "90404b49-3a92-467e-953a-401f60f6784f", 0, "Adminvägen 1", "Admin city", "0224e0af-9498-4f11-9b53-767dced495ff", "Admin country", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGPFACc2fv/T+2uPwaRS//0jeJ+10TQlDQVZNQFGRIrbUPvXDu5KNqIWcunSadrMbQ==", "123456578", false, "12345", "163a7c60-aa39-4ef9-b1d2-0417d406a36b", false, "admin@admin.com" },
                    { "798fcdde-926d-4b3d-be32-e00821f27d52", 0, "Kundvägen 11", "Kundstaden", "3985b55f-2716-45e1-a4d8-0fb9fc537fd4", "Sverige", "seeduser@seeduser.com", false, "Kund", "Kundsson", false, null, "SEEDUSER@SEEDUSER.COM", "SEEDUSER@SEEDUSER.COM", "AQAAAAEAACcQAAAAEKDOXVMOogMNLS2aCD3fffufytI+34ouV6IMypcgqzqyl2SIgh+Khm0VK29WXZy/Ng==", "87654321", false, "12345", "7d26e971-d6c2-4bf2-8d0b-b4af6d1d66d1", false, "seeduser@seeduser.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "90404b49-3a92-467e-953a-401f60f6784f", "16877cf5-b45b-4366-835f-893649832a6d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "798fcdde-926d-4b3d-be32-e00821f27d52", "d04cf07c-c98a-438e-9c8f-1097dec0378f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "798fcdde-926d-4b3d-be32-e00821f27d52", "d04cf07c-c98a-438e-9c8f-1097dec0378f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "90404b49-3a92-467e-953a-401f60f6784f", "16877cf5-b45b-4366-835f-893649832a6d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16877cf5-b45b-4366-835f-893649832a6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d04cf07c-c98a-438e-9c8f-1097dec0378f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "798fcdde-926d-4b3d-be32-e00821f27d52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90404b49-3a92-467e-953a-401f60f6784f");

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
    }
}
