using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class SeededDefaultUserandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8708237e-c0f3-426e-b2d4-6f5b7bb6774b", "415cad80-031c-445e-a66f-959c0e14218a" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e22567d-c950-4010-9b28-6d5bd6b8fae3",
                column: "ConcurrencyStamp",
                value: "ab142871-5863-4b58-afe0-8cdfbf4237f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e557d391-59f9-475a-9569-f96b7ada4a7e",
                column: "ConcurrencyStamp",
                value: "169b5a28-8817-4327-a423-a4e0f1526aff");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4e22567d-c950-4010-9b28-6d5bd6b8fae3", "415cad80-031c-445e-a66f-959c0e14218a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "415cad80-031c-445e-a66f-959c0e14218a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef17ca53-ec93-4b63-b24c-5180a8d7a468", "AQAAAAEAACcQAAAAEI888Y8btu8HojHCAK3MghltKPxW3mAsRpzxbiC85neI7aQ4Pj47cPruIUk8VtasKQ==", "f87727c2-5d3c-4a47-8690-11569c7155c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da88bdfc-b3b1-4e03-8467-f179f9327218",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "519a551e-c4e2-4a00-8977-294df085269d", "AQAAAAEAACcQAAAAEHhLKdu7YhF5Uo5XY7dwKYKwFTtH2QwHp8i1PwTwLuq1up6Yh3KMrV2gyfmK9fz5zA==", "c194a7f9-451f-4667-a614-f11ffa6c8d6a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4e22567d-c950-4010-9b28-6d5bd6b8fae3", "415cad80-031c-445e-a66f-959c0e14218a" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e22567d-c950-4010-9b28-6d5bd6b8fae3",
                column: "ConcurrencyStamp",
                value: "53c9470d-80cb-4abd-be71-62b92f4a3b79");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e557d391-59f9-475a-9569-f96b7ada4a7e",
                column: "ConcurrencyStamp",
                value: "f5e2ff5e-6791-4626-8af1-20e8af8bd828");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8708237e-c0f3-426e-b2d4-6f5b7bb6774b", "415cad80-031c-445e-a66f-959c0e14218a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "415cad80-031c-445e-a66f-959c0e14218a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9899da2a-edc3-4376-9191-8da0cff78f02", "AQAAAAEAACcQAAAAENYAo7pOUfupbNGDZ0JS747FI8wyBqvUsW0N9caDEfWAkIVFIpiFYWlfG66cJEpTCA==", "ac39b1ee-05aa-452a-a9d1-f41c28e8fd32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da88bdfc-b3b1-4e03-8467-f179f9327218",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77be2e5d-d9c1-43b8-8db0-1a0dff43e4a6", "AQAAAAEAACcQAAAAEPDunBEIXD80g1eo6tr7w2U4nEbQE8AREPSqF1CZYBVuRPYPxYuuWf2pCcvkKjbM1g==", "e2db8c63-461e-4da0-bbdc-b2291af37e20" });
        }
    }
}
