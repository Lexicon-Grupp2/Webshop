using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class Added4seededusers : Migration
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
                    { "0c77cd0d-fa2f-4a26-b31e-2cde81369c3f", "4c80193e-dca4-48df-91b5-a16d1d4495ea", "Admin", "ADMIN" },
                    { "2dfe8be7-33b5-4587-b6f7-687ab84e91be", "a05b4278-5e35-454c-9976-5a70f047bbf0", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ad84755f-8943-421c-9b1c-996da0ab7684", 0, "Adminvägen 1", "Admin city", "4106937c-0ed5-47c4-b5a8-6474e3e57d3a", "Admin country", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEIAVTAYzSXruGBJeMfnKcg4W8W9OAJhShoIQWGmfJti5w6QwFv240y15NIk/jKAGCw==", "123456578", false, "12345", "ab09eedf-4728-4adf-a125-37ddd29723ce", false, "admin@admin.com" },
                    { "71c4e475-951b-4976-93de-3143b7eb4021", 0, "Kanelgatan 3", "Visby", "d941d9de-3afd-4a66-b2e5-e6e6d2002b69", "Sweden", "customer1@seeduser.com", false, "Arne", "Karat", false, null, "CUSTOMER1@SEEDUSER.COM", "CUSTOMER1@SEEDUSER.COM", "AQAAAAEAACcQAAAAEA7F/kq4CMwdQfZ0GS7cl/el1yFDW+VhZEoTGxdhZIlSd0zMX2buBfQw4BApCwbm5A==", "043016624", false, "23445", "eb912686-8bff-4513-8771-a0f7351f9d33", false, "customer1@seeduser.com" },
                    { "8bb1d5f3-c679-4491-871d-256d66d23b63", 0, "Rimbo torg 1", "Skövde", "6f63fed2-63c4-48e0-a6db-cf1afabbd653", "Sweden", "customer2@seeduser.com", false, "Kenneth", "Svenzon", false, null, "CUSTOMER2@SEEDUSER.COM", "CUSTOMER2@SEEDUSER.COM", "AQAAAAEAACcQAAAAEDXa5FTbC0hkfafsOcsWb79VGnRSQmH7lMsZ4dTI5g/tNy5AvT6jgHI0CdyNUqbHDQ==", "0721453456", false, "44565", "40da83d7-5290-4eba-9ed8-83a87b261b7e", false, "customer2@seeduser.com" },
                    { "92ec566a-dd66-42c6-82f8-28c5bb6d624e", 0, "Kungsgatan 4", "Arboga", "b8026b00-9b25-428b-8bf2-eebe73dd20c4", "Sweden", "customer3@seeduser.com", false, "Angela", "Melodi", false, null, "CUSTOMER3@SEEDUSER.COM", "CUSTOMER3@SEEDUSER.COM", "AQAAAAEAACcQAAAAELvzmInB6bsAGCPmF8qGa+JmOnJRVhc9caxrjPUtsKpOlghT4N/q6E6tBc35/I5AbQ==", "0771242424", false, "32344", "ba148fd4-8db1-4145-be65-f7f8a9c807a2", false, "customer3@seeduser.com" },
                    { "b02e4b9c-e23e-4fda-a8b7-accda39e3c73", 0, "Royal Carnac Hotel 1", "Cairo", "e13f2c17-98a9-4063-bc52-4166286135f6", "Egypt", "seeduser@seeduser.com", false, "Kaj", "Fridell", false, null, "SEEDUSER@SEEDUSER.COM", "SEEDUSER@SEEDUSER.COM", "AQAAAAEAACcQAAAAEJjsJKzoGUngz83xi/C+OoZpWx7tBQfkGpf5JSS9lZvVJUEd9KkeqKOb3NLPKvEz/w==", "031184698", false, "33467", "8911b97f-50ab-4407-a1dc-03be265cd217", false, "seeduser@seeduser.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "ad84755f-8943-421c-9b1c-996da0ab7684", "0c77cd0d-fa2f-4a26-b31e-2cde81369c3f" },
                    { "71c4e475-951b-4976-93de-3143b7eb4021", "2dfe8be7-33b5-4587-b6f7-687ab84e91be" },
                    { "8bb1d5f3-c679-4491-871d-256d66d23b63", "2dfe8be7-33b5-4587-b6f7-687ab84e91be" },
                    { "92ec566a-dd66-42c6-82f8-28c5bb6d624e", "2dfe8be7-33b5-4587-b6f7-687ab84e91be" },
                    { "b02e4b9c-e23e-4fda-a8b7-accda39e3c73", "2dfe8be7-33b5-4587-b6f7-687ab84e91be" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "71c4e475-951b-4976-93de-3143b7eb4021", "2dfe8be7-33b5-4587-b6f7-687ab84e91be" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8bb1d5f3-c679-4491-871d-256d66d23b63", "2dfe8be7-33b5-4587-b6f7-687ab84e91be" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "92ec566a-dd66-42c6-82f8-28c5bb6d624e", "2dfe8be7-33b5-4587-b6f7-687ab84e91be" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ad84755f-8943-421c-9b1c-996da0ab7684", "0c77cd0d-fa2f-4a26-b31e-2cde81369c3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b02e4b9c-e23e-4fda-a8b7-accda39e3c73", "2dfe8be7-33b5-4587-b6f7-687ab84e91be" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c77cd0d-fa2f-4a26-b31e-2cde81369c3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dfe8be7-33b5-4587-b6f7-687ab84e91be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71c4e475-951b-4976-93de-3143b7eb4021");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8bb1d5f3-c679-4491-871d-256d66d23b63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92ec566a-dd66-42c6-82f8-28c5bb6d624e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad84755f-8943-421c-9b1c-996da0ab7684");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b02e4b9c-e23e-4fda-a8b7-accda39e3c73");

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
