using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class addedrelationorderuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "01484be6-e833-4a39-9db8-52e5f9b84e56", "a16e2917-6951-475c-9616-c9ff11679b90" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "50d3f6df-f9d5-41fb-8d66-4110f64250a0", "a16e2917-6951-475c-9616-c9ff11679b90" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c9be1724-46f3-41e1-afd8-ff3acb9f3603", "a16e2917-6951-475c-9616-c9ff11679b90" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d13a3ff0-9a84-42e2-8bce-98cd6bd96dc2", "a16e2917-6951-475c-9616-c9ff11679b90" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d3203281-3f97-4b0f-920e-fd43cca6637a", "3a1f1eca-4ab8-45e7-99c5-0ac1fae73356" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a1f1eca-4ab8-45e7-99c5-0ac1fae73356");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a16e2917-6951-475c-9616-c9ff11679b90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01484be6-e833-4a39-9db8-52e5f9b84e56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50d3f6df-f9d5-41fb-8d66-4110f64250a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9be1724-46f3-41e1-afd8-ff3acb9f3603");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d13a3ff0-9a84-42e2-8bce-98cd6bd96dc2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3203281-3f97-4b0f-920e-fd43cca6637a");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_CustomerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders");

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

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a1f1eca-4ab8-45e7-99c5-0ac1fae73356", "29b515ec-ac6c-4e57-8393-e663a5ec5869", "Admin", "ADMIN" },
                    { "a16e2917-6951-475c-9616-c9ff11679b90", "b04c5a15-0bf2-43bc-bf92-c1b73caf385a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d3203281-3f97-4b0f-920e-fd43cca6637a", 0, "Adminvägen 1", "Admin city", "dda1898c-14e6-4036-ad7d-d901d27c27df", "Admin country", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEO06R+IBc5j3z5+O7UJ/+25Rk9TjwLiX/Mnef4/q8C8u2+8ZWz1Z8LKyqUrv0Dg9+A==", "123456578", false, "12345", "315b25a5-6477-4de0-bea0-d782a7903d44", false, "admin@admin.com" },
                    { "50d3f6df-f9d5-41fb-8d66-4110f64250a0", 0, "Kanelgatan 3", "Visby", "8aafa24e-9fb9-4e6b-b1f3-015a1d797405", "Sweden", "customer1@seeduser.com", false, "Arne", "Karat", false, null, "CUSTOMER1@SEEDUSER.COM", "CUSTOMER1@SEEDUSER.COM", "AQAAAAEAACcQAAAAEPQOck5qJO/nF7BuqoTFfVONKyx6smJiNyYOOAT779ASDSNuvp2LMEVxhSOwDGE/wA==", "043016624", false, "23445", "8331a3ec-bda0-4b3d-b633-a5616c8aa8b7", false, "customer1@seeduser.com" },
                    { "d13a3ff0-9a84-42e2-8bce-98cd6bd96dc2", 0, "Rimbo torg 1", "Skövde", "4604b0a3-5ec3-4ae1-974a-ee6a89848022", "Sweden", "customer2@seeduser.com", false, "Kenneth", "Svenzon", false, null, "CUSTOMER2@SEEDUSER.COM", "CUSTOMER2@SEEDUSER.COM", "AQAAAAEAACcQAAAAECwn/dIzERyjOB73KvP+RPPguBqHjC0VL1fV8rhMa2Xw0Lyao9kdRX4Cd0ep2UZTyw==", "0721453456", false, "44565", "b999b73d-22f1-4d7c-8b3d-50504e86cb8a", false, "customer2@seeduser.com" },
                    { "c9be1724-46f3-41e1-afd8-ff3acb9f3603", 0, "Kungsgatan 4", "Arboga", "11779972-5da7-476d-bce6-5c4a4e2f3622", "Sweden", "customer3@seeduser.com", false, "Angela", "Melodi", false, null, "CUSTOMER3@SEEDUSER.COM", "CUSTOMER3@SEEDUSER.COM", "AQAAAAEAACcQAAAAEA061pLol1obtVbb+bTCKstwSZviE8bz4f0yr9XgSyfjYrDYRQc3PNfQFqLfjvAZNw==", "0771242424", false, "32344", "7c799b83-9e2a-4c14-a233-2b2b8ded36dd", false, "customer3@seeduser.com" },
                    { "01484be6-e833-4a39-9db8-52e5f9b84e56", 0, "Royal Carnac Hotel 1", "Cairo", "bac33314-5020-4bd3-8dbb-86e38da9d1cd", "Egypt", "seeduser@seeduser.com", false, "Kaj", "Fridell", false, null, "SEEDUSER@SEEDUSER.COM", "SEEDUSER@SEEDUSER.COM", "AQAAAAEAACcQAAAAEK6D+aeIpL9w/v0zUrZ7h8bsk+rjuYchgPZQ4QU+jtb8guN2JjLr/c42v1U1uwE72Q==", "031184698", false, "33467", "1748b744-7fda-402f-a868-7a6f1967cc59", false, "seeduser@seeduser.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "d3203281-3f97-4b0f-920e-fd43cca6637a", "3a1f1eca-4ab8-45e7-99c5-0ac1fae73356" },
                    { "50d3f6df-f9d5-41fb-8d66-4110f64250a0", "a16e2917-6951-475c-9616-c9ff11679b90" },
                    { "d13a3ff0-9a84-42e2-8bce-98cd6bd96dc2", "a16e2917-6951-475c-9616-c9ff11679b90" },
                    { "c9be1724-46f3-41e1-afd8-ff3acb9f3603", "a16e2917-6951-475c-9616-c9ff11679b90" },
                    { "01484be6-e833-4a39-9db8-52e5f9b84e56", "a16e2917-6951-475c-9616-c9ff11679b90" }
                });
        }
    }
}
