using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class AddedImageThumbNametoProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa727466-2da9-4e18-8925-d854a5958787");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cfadb1b7-160e-48f9-b0f7-566a86b3be2a", "9b066cc0-65ce-43ba-95a5-f511680af264" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b066cc0-65ce-43ba-95a5-f511680af264");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfadb1b7-160e-48f9-b0f7-566a86b3be2a");

            migrationBuilder.AddColumn<string>(
                name: "ImageThumbName",
                table: "ProductImages",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImageThumbName",
                table: "ProductImages");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b066cc0-65ce-43ba-95a5-f511680af264", "d04b2411-09e2-44af-b970-8726d4b7a9fd", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aa727466-2da9-4e18-8925-d854a5958787", "b609bc7a-9941-48cb-b236-30e552a9b5d0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cfadb1b7-160e-48f9-b0f7-566a86b3be2a", 0, "9c6a1b46-e7a9-4dd2-b379-bf417fb33c68", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEN8LkI1Ifg7wq+vEVKFKv7EhiyBJQe0baGAonY5g7AZfAxkHuYnR+lxanrcUma2Rpw==", null, false, "c67b52d1-1dbd-402a-8e35-6e4e1e5799de", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "cfadb1b7-160e-48f9-b0f7-566a86b3be2a", "9b066cc0-65ce-43ba-95a5-f511680af264" });
        }
    }
}
