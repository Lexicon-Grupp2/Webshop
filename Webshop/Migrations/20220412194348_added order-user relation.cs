using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class addedorderuserrelation : Migration
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
                    { "1903de18-84b5-448b-88ec-471589fddce6", "ea576906-bc4a-4b17-9e78-3d0a6b3c784f", "Admin", "ADMIN" },
                    { "b1ba821b-b1c3-43f4-850a-a6a79a29d3f6", "958341c5-f2c1-4bd6-907f-a6beeb36bd3f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3099b3e0-7ac4-49af-8e10-c2fa51426a7a", 0, "Adminvägen 1", "Admin city", "e8d6e2e9-93ae-4343-8688-335c05b7c987", "Admin country", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEDyVkIthIC7WRVMYYjmu+WDXJ8ir24PSqf1IWwD8ysMBhLd40xsAuJcAM3kC2HXIQg==", "123456578", false, "12345", "6e1dd45d-628a-487f-a337-f7aef79b8ce0", false, "admin@admin.com" },
                    { "170adf1c-bc7c-4b99-a570-90a8211aaf66", 0, "Kanelgatan 3", "Visby", "20a1240b-b694-4d79-b477-bae3edaf932e", "Sweden", "customer1@seeduser.com", false, "Arne", "Karat", false, null, "CUSTOMER1@SEEDUSER.COM", "CUSTOMER1@SEEDUSER.COM", "AQAAAAEAACcQAAAAEIQfgsGjQJLizAUiQQMGqz4FYqaN3cymjW1dsxGt1TW8PqpKA/6pWPbxm6BGsh/G2Q==", "043016624", false, "23445", "761d1edd-a203-4fb2-a926-d5fc41428c3d", false, "customer1@seeduser.com" },
                    { "6d01aa3f-04ba-46ef-8384-bc1fb632871b", 0, "Rimbo torg 1", "Skövde", "73e7e748-7657-48fe-bd9c-f44c88927673", "Sweden", "customer2@seeduser.com", false, "Kenneth", "Svenzon", false, null, "CUSTOMER2@SEEDUSER.COM", "CUSTOMER2@SEEDUSER.COM", "AQAAAAEAACcQAAAAEG6C364nzF7dCDJtoH9SmwaeI5/08CL2gzgD+K8Ksc18v83ECWacys/GejFCXgdxag==", "0721453456", false, "44565", "116a741f-4e16-49b1-86ec-026e5fb95996", false, "customer2@seeduser.com" },
                    { "448eda73-5d43-43dc-a0aa-9c1b670a0c94", 0, "Kungsgatan 4", "Arboga", "cc77500d-3962-42c5-a44d-08fdb7e1a8ea", "Sweden", "customer3@seeduser.com", false, "Angela", "Melodi", false, null, "CUSTOMER3@SEEDUSER.COM", "CUSTOMER3@SEEDUSER.COM", "AQAAAAEAACcQAAAAEESUExgDIt4QG4ts+dLHnbqsk8Zgu/QkTbKvNuJtD0C9OCcpCm5ozapPqGPZlgFJag==", "0771242424", false, "32344", "59982f13-e789-416d-bdcc-320a74c205f8", false, "customer3@seeduser.com" },
                    { "2f86c673-d599-4d5e-9637-19805f5b32ee", 0, "Royal Carnac Hotel 1", "Cairo", "98bfe5d3-e162-48ad-89d4-cd3a3d117f98", "Egypt", "seeduser@seeduser.com", false, "Kaj", "Fridell", false, null, "SEEDUSER@SEEDUSER.COM", "SEEDUSER@SEEDUSER.COM", "AQAAAAEAACcQAAAAEB9WyC3EUWF63vB1Dnz0xcsq9y+nqJ3nfI+HzaLC6gUoaMP94Qc6UKZ/RE/efBqAmw==", "031184698", false, "33467", "cf177514-ab41-4d3f-a8e7-78566c929e26", false, "seeduser@seeduser.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "3099b3e0-7ac4-49af-8e10-c2fa51426a7a", "1903de18-84b5-448b-88ec-471589fddce6" },
                    { "170adf1c-bc7c-4b99-a570-90a8211aaf66", "b1ba821b-b1c3-43f4-850a-a6a79a29d3f6" },
                    { "6d01aa3f-04ba-46ef-8384-bc1fb632871b", "b1ba821b-b1c3-43f4-850a-a6a79a29d3f6" },
                    { "448eda73-5d43-43dc-a0aa-9c1b670a0c94", "b1ba821b-b1c3-43f4-850a-a6a79a29d3f6" },
                    { "2f86c673-d599-4d5e-9637-19805f5b32ee", "b1ba821b-b1c3-43f4-850a-a6a79a29d3f6" }
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
                keyValues: new object[] { "170adf1c-bc7c-4b99-a570-90a8211aaf66", "b1ba821b-b1c3-43f4-850a-a6a79a29d3f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2f86c673-d599-4d5e-9637-19805f5b32ee", "b1ba821b-b1c3-43f4-850a-a6a79a29d3f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3099b3e0-7ac4-49af-8e10-c2fa51426a7a", "1903de18-84b5-448b-88ec-471589fddce6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "448eda73-5d43-43dc-a0aa-9c1b670a0c94", "b1ba821b-b1c3-43f4-850a-a6a79a29d3f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6d01aa3f-04ba-46ef-8384-bc1fb632871b", "b1ba821b-b1c3-43f4-850a-a6a79a29d3f6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1903de18-84b5-448b-88ec-471589fddce6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1ba821b-b1c3-43f4-850a-a6a79a29d3f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "170adf1c-bc7c-4b99-a570-90a8211aaf66");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f86c673-d599-4d5e-9637-19805f5b32ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3099b3e0-7ac4-49af-8e10-c2fa51426a7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "448eda73-5d43-43dc-a0aa-9c1b670a0c94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d01aa3f-04ba-46ef-8384-bc1fb632871b");

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
