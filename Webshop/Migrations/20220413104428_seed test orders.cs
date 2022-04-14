using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class seedtestorders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "487a4935-8586-4e38-917e-81dab3bd0880", "93e1f4a4-f882-41ea-a985-327ad37ac70d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "644d9309-7b05-4401-9825-c51beaacaf7d", "93e1f4a4-f882-41ea-a985-327ad37ac70d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9e02f243-30ed-4a97-bee9-d84b0d28834a", "93e1f4a4-f882-41ea-a985-327ad37ac70d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b952efdf-d70b-4a03-8e32-af6d89b01516", "3fa29a39-b54f-4198-95b8-826a3d33feb0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "dc81ae40-f00b-427f-bf9e-de2e3767dca2", "93e1f4a4-f882-41ea-a985-327ad37ac70d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fa29a39-b54f-4198-95b8-826a3d33feb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93e1f4a4-f882-41ea-a985-327ad37ac70d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "487a4935-8586-4e38-917e-81dab3bd0880");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "644d9309-7b05-4401-9825-c51beaacaf7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e02f243-30ed-4a97-bee9-d84b0d28834a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b952efdf-d70b-4a03-8e32-af6d89b01516");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc81ae40-f00b-427f-bf9e-de2e3767dca2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "86efe060-a6bf-470e-ae43-3a69c0ce1758", "09159eaa-7096-4e39-889f-9cd023fa806c", "Admin", "ADMIN" },
                    { "1259de13-a55d-4ba4-9cc3-bbe293dc6d07", "6f8841ce-7c05-457d-bdd5-ca344cc85d94", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0ca0f471-d686-4f5e-85a1-d0e87a995d70", 0, "Adminvägen 1", "Admin city", "28c57389-ee2f-46e8-9f32-584070647b33", "Admin country", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEBdH4t3ldRZrYCusr85NREilxT6gfFgV1zKQhvuG0OGdXsxSg0UwXCfwlVGRYOJuYQ==", "123456578", false, "12345", "caae5b8e-bd79-4dee-84ae-e9d89e512c31", false, "admin@admin.com" },
                    { "79cb9168-f470-4620-b861-edc081705d94", 0, "Kanelgatan 3", "Visby", "341fba9e-d583-4163-aa77-0fd06a41b441", "Sweden", "customer1@seeduser.com", false, "Arne", "Karat", false, null, "CUSTOMER1@SEEDUSER.COM", "CUSTOMER1@SEEDUSER.COM", "AQAAAAEAACcQAAAAEKqrh1NVnJxdkZ3/83MXaT/dG30WlJniOt2r4Ghibs09CLqHWlh3T9aVuoj9tGiUbw==", "043016624", false, "23445", "2b497417-8561-478d-80eb-fa08880bfc3c", false, "customer1@seeduser.com" },
                    { "cd46f162-dd90-426d-8fe0-20944d5df397", 0, "Rimbo torg 1", "Skövde", "973414a1-736f-405d-8cd8-7e54ee0adde9", "Sweden", "customer2@seeduser.com", false, "Kenneth", "Svenzon", false, null, "CUSTOMER2@SEEDUSER.COM", "CUSTOMER2@SEEDUSER.COM", "AQAAAAEAACcQAAAAEFZxSgDn0YdkSdxYmgKhebvfjOOtmRF3gQcWR/3kdsqr1rEiaLMMIa/8LH8fQ81k5Q==", "0721453456", false, "44565", "bbcd78d5-3024-43bd-80ff-83ac013c4e1a", false, "customer2@seeduser.com" },
                    { "6671a692-f7ef-4cd7-9520-ff50c7c6a283", 0, "Kungsgatan 4", "Arboga", "c0ae6bef-1957-4dee-9127-a978f6876826", "Sweden", "customer3@seeduser.com", false, "Angela", "Melodi", false, null, "CUSTOMER3@SEEDUSER.COM", "CUSTOMER3@SEEDUSER.COM", "AQAAAAEAACcQAAAAENZpKmKqelaZJorixJEG7ni0/74Yen4pkmbIsQScZPvRk/Wuv+oiqzP6gU+W2LDxJA==", "0771242424", false, "32344", "cd0ec23a-d1dd-41d1-ad8e-4b0a463486dc", false, "customer3@seeduser.com" },
                    { "54a7b7aa-108e-4c64-8b84-8fbb92615e52", 0, "Royal Carnac Hotel 1", "Cairo", "3f84c690-4716-452c-94ee-9aa196afb06e", "Egypt", "seeduser@seeduser.com", false, "Kaj", "Fridell", false, null, "SEEDUSER@SEEDUSER.COM", "SEEDUSER@SEEDUSER.COM", "AQAAAAEAACcQAAAAEIQXBNieiFYp+dNtkO1NLZpI1M8cUKTGy76gJaKqmN4DUY6N/6jxSJcHPGvtKMs0gA==", "031184698", false, "33467", "da000ee7-948b-4525-ac56-6ccdd4d0821d", false, "seeduser@seeduser.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "0ca0f471-d686-4f5e-85a1-d0e87a995d70", "86efe060-a6bf-470e-ae43-3a69c0ce1758" },
                    { "79cb9168-f470-4620-b861-edc081705d94", "1259de13-a55d-4ba4-9cc3-bbe293dc6d07" },
                    { "cd46f162-dd90-426d-8fe0-20944d5df397", "1259de13-a55d-4ba4-9cc3-bbe293dc6d07" },
                    { "6671a692-f7ef-4cd7-9520-ff50c7c6a283", "1259de13-a55d-4ba4-9cc3-bbe293dc6d07" },
                    { "54a7b7aa-108e-4c64-8b84-8fbb92615e52", "1259de13-a55d-4ba4-9cc3-bbe293dc6d07" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "CustomerId1", "OrderDate", "Paid", "TotalCost" },
                values: new object[,]
                {
                    { 1, "79cb9168-f470-4620-b861-edc081705d94", null, new DateTime(2022, 4, 13, 12, 44, 27, 688, DateTimeKind.Local).AddTicks(3270), true, 87 },
                    { 2, "cd46f162-dd90-426d-8fe0-20944d5df397", null, new DateTime(2022, 4, 13, 12, 44, 27, 690, DateTimeKind.Local).AddTicks(5856), true, 44 },
                    { 3, "cd46f162-dd90-426d-8fe0-20944d5df397", null, new DateTime(2022, 4, 13, 12, 44, 27, 690, DateTimeKind.Local).AddTicks(5936), true, 257 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "Price", "ProductId", "ProductName", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 29, 1001, "Chocolate Dream", 3 },
                    { 2, 2, 22, 1002, "Pink surprise", 2 },
                    { 3, 3, 34, 1003, "Plain delight", 5 },
                    { 4, 3, 29, 1001, "Chocolate Dream", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0ca0f471-d686-4f5e-85a1-d0e87a995d70", "86efe060-a6bf-470e-ae43-3a69c0ce1758" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "54a7b7aa-108e-4c64-8b84-8fbb92615e52", "1259de13-a55d-4ba4-9cc3-bbe293dc6d07" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6671a692-f7ef-4cd7-9520-ff50c7c6a283", "1259de13-a55d-4ba4-9cc3-bbe293dc6d07" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "79cb9168-f470-4620-b861-edc081705d94", "1259de13-a55d-4ba4-9cc3-bbe293dc6d07" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cd46f162-dd90-426d-8fe0-20944d5df397", "1259de13-a55d-4ba4-9cc3-bbe293dc6d07" });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1259de13-a55d-4ba4-9cc3-bbe293dc6d07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86efe060-a6bf-470e-ae43-3a69c0ce1758");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ca0f471-d686-4f5e-85a1-d0e87a995d70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54a7b7aa-108e-4c64-8b84-8fbb92615e52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6671a692-f7ef-4cd7-9520-ff50c7c6a283");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79cb9168-f470-4620-b861-edc081705d94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd46f162-dd90-426d-8fe0-20944d5df397");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3fa29a39-b54f-4198-95b8-826a3d33feb0", "41cfbd47-1b12-47f4-934d-b5ce6ffb3b2f", "Admin", "ADMIN" },
                    { "93e1f4a4-f882-41ea-a985-327ad37ac70d", "d1f47f26-c99b-4bd8-ac9d-9d309a3a424b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b952efdf-d70b-4a03-8e32-af6d89b01516", 0, "Adminvägen 1", "Admin city", "3de3ab93-e4b0-475c-ad78-62cfaef75a7b", "Admin country", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEPl6kFfi1ptANp2XHjaoW4RIp5RKIerdV9qw0V+PBbAQ8IR2+5cgWSHuPO2UryYuGg==", "123456578", false, "12345", "ea84b0e4-4137-43e4-ab2c-1fc8f204ec59", false, "admin@admin.com" },
                    { "487a4935-8586-4e38-917e-81dab3bd0880", 0, "Kanelgatan 3", "Visby", "96ec77a7-995b-4bbe-9da1-8174391bac75", "Sweden", "customer1@seeduser.com", false, "Arne", "Karat", false, null, "CUSTOMER1@SEEDUSER.COM", "CUSTOMER1@SEEDUSER.COM", "AQAAAAEAACcQAAAAEI6o66pjnlsN0PK+e5drzqm2bHj5pzmJCO650g/5S/JT+oj9G5a5Li86TRPnpbZcow==", "043016624", false, "23445", "612460e8-8403-4d4c-ba20-603f910473ba", false, "customer1@seeduser.com" },
                    { "dc81ae40-f00b-427f-bf9e-de2e3767dca2", 0, "Rimbo torg 1", "Skövde", "b4f2a7c4-d954-491b-b6bb-2bb6c73bb797", "Sweden", "customer2@seeduser.com", false, "Kenneth", "Svenzon", false, null, "CUSTOMER2@SEEDUSER.COM", "CUSTOMER2@SEEDUSER.COM", "AQAAAAEAACcQAAAAEEFTXxJwP8ZfcK2Oq9hsAxsD/V+fCBXWrujQrD5EWa7kr5tpSqfuKo16j1zMibix7Q==", "0721453456", false, "44565", "d1809999-837b-47f3-a444-e9068588d60b", false, "customer2@seeduser.com" },
                    { "644d9309-7b05-4401-9825-c51beaacaf7d", 0, "Kungsgatan 4", "Arboga", "b25ceba6-fec5-420c-87e3-faf364efd209", "Sweden", "customer3@seeduser.com", false, "Angela", "Melodi", false, null, "CUSTOMER3@SEEDUSER.COM", "CUSTOMER3@SEEDUSER.COM", "AQAAAAEAACcQAAAAEHzA7J32i0RNrJ1duVgKlfcLDuV1VA0Sxw/1GeZJqW+j0RP7G7V+d874A9+FHfNJRQ==", "0771242424", false, "32344", "ca4f2714-6f2a-4c9f-9bb8-eeab862bc0b7", false, "customer3@seeduser.com" },
                    { "9e02f243-30ed-4a97-bee9-d84b0d28834a", 0, "Royal Carnac Hotel 1", "Cairo", "f92259db-f312-4c2c-adbb-67c6cdcf2e8b", "Egypt", "seeduser@seeduser.com", false, "Kaj", "Fridell", false, null, "SEEDUSER@SEEDUSER.COM", "SEEDUSER@SEEDUSER.COM", "AQAAAAEAACcQAAAAEHvKbke+agPFAkZRSJOey3j9N0AVQonNcYVm2sfcCZR5HLgiKx05pSWXNN1uzWnF0w==", "031184698", false, "33467", "85f37f71-6e9f-464f-9480-d845ed1a2775", false, "seeduser@seeduser.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "b952efdf-d70b-4a03-8e32-af6d89b01516", "3fa29a39-b54f-4198-95b8-826a3d33feb0" },
                    { "487a4935-8586-4e38-917e-81dab3bd0880", "93e1f4a4-f882-41ea-a985-327ad37ac70d" },
                    { "dc81ae40-f00b-427f-bf9e-de2e3767dca2", "93e1f4a4-f882-41ea-a985-327ad37ac70d" },
                    { "644d9309-7b05-4401-9825-c51beaacaf7d", "93e1f4a4-f882-41ea-a985-327ad37ac70d" },
                    { "9e02f243-30ed-4a97-bee9-d84b0d28834a", "93e1f4a4-f882-41ea-a985-327ad37ac70d" }
                });
        }
    }
}
