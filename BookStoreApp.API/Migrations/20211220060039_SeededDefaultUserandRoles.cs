using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class SeededDefaultUserandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e22567d-c950-4010-9b28-6d5bd6b8fae3", "53c9470d-80cb-4abd-be71-62b92f4a3b79", "User", "USER" },
                    { "e557d391-59f9-475a-9569-f96b7ada4a7e", "f5e2ff5e-6791-4626-8af1-20e8af8bd828", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "415cad80-031c-445e-a66f-959c0e14218a", 0, "9899da2a-edc3-4376-9191-8da0cff78f02", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAENYAo7pOUfupbNGDZ0JS747FI8wyBqvUsW0N9caDEfWAkIVFIpiFYWlfG66cJEpTCA==", null, false, "ac39b1ee-05aa-452a-a9d1-f41c28e8fd32", false, "user@bookstore.com" },
                    { "da88bdfc-b3b1-4e03-8467-f179f9327218", 0, "77be2e5d-d9c1-43b8-8db0-1a0dff43e4a6", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEPDunBEIXD80g1eo6tr7w2U4nEbQE8AREPSqF1CZYBVuRPYPxYuuWf2pCcvkKjbM1g==", null, false, "e2db8c63-461e-4da0-bbdc-b2291af37e20", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4e22567d-c950-4010-9b28-6d5bd6b8fae3", "415cad80-031c-445e-a66f-959c0e14218a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e557d391-59f9-475a-9569-f96b7ada4a7e", "da88bdfc-b3b1-4e03-8467-f179f9327218" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4e22567d-c950-4010-9b28-6d5bd6b8fae3", "415cad80-031c-445e-a66f-959c0e14218a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e557d391-59f9-475a-9569-f96b7ada4a7e", "da88bdfc-b3b1-4e03-8467-f179f9327218" });


            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "415cad80-031c-445e-a66f-959c0e14218a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da88bdfc-b3b1-4e03-8467-f179f9327218");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e22567d-c950-4010-9b28-6d5bd6b8fae3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e557d391-59f9-475a-9569-f96b7ada4a7e");
        }
    }
}
