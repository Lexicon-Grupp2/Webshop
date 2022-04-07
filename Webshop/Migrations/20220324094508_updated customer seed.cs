using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class updatedcustomerseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "ebe50e96-17a9-4c79-b25f-8792370d278d", "ff375b2e-a4f9-4385-aa56-ad3168c00c79", "Admin", "ADMIN" },
                    { "a6358af3-a7da-407f-a9f1-b55a35a426ed", "ebdf4e28-d104-4bf6-b187-cb607e691d11", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "726e0dfb-50fb-4e74-95f2-e4c829b72368", 0, "3668c059-eb87-4f3b-aca5-aaae5717b4ed", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEL9KoiypoSFhofv16Nu7KxqpMNoKMM+QV+1BZTLiQp+tjF+5rxujbNIuRyPWmKgoew==", null, false, "44025c22-9580-4256-8f28-d7478cc0f6b6", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Country", "CustomerId", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode" },
                values: new object[,]
                {
                    { 1, "Kanelgatan 3", "Visby", "Sweden", null, "bling@gmail.com", "Arne", "Karat", "043016624", "23445" },
                    { 2, "Rimbo torg 1", "Skövde", "Sweden", null, "stekarn@gmail.com", "Kenneth", "Svenzon", "0721453456", "44565" },
                    { 3, "Kungsgatan 4", "Arboga", "Sweden", null, "lucky@hotmail.com", "Angela", "Melodi", "0771242424", "32344" },
                    { 4, "Royal Carnac Hotel 1", "Cairo", "Egypt", null, "kafr@egypt.gov", "Kaj", "Fridell", "031184698", "33467" },
                    { 5, "Vedgatan 3", "Oslo", "Norway", null, "tavlan@gmail.com", "Molly", "Sundkvist", "0443346723", "46723" },
                    { 6, "Gatgatan 2", "Göteborg", "Sweden", null, "test@gmail.com", "Jan", "Andersson", "04422723", "46723" },
                    { 7, "Avenyn 1", "Berlin", "Germany", null, "raj@goteborg.se", "Sofia", "Bosch", "0543768798", "67823" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "726e0dfb-50fb-4e74-95f2-e4c829b72368", "ebe50e96-17a9-4c79-b25f-8792370d278d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6358af3-a7da-407f-a9f1-b55a35a426ed");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "726e0dfb-50fb-4e74-95f2-e4c829b72368", "ebe50e96-17a9-4c79-b25f-8792370d278d" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebe50e96-17a9-4c79-b25f-8792370d278d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726e0dfb-50fb-4e74-95f2-e4c829b72368");

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
    }
}
