using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class SeededDefaultUserandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e22567d-c950-4010-9b28-6d5bd6b8fae3",
                column: "ConcurrencyStamp",
                value: "aa25ded1-21f1-4580-a3c6-63c9f8106577");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e557d391-59f9-475a-9569-f96b7ada4a7e",
                column: "ConcurrencyStamp",
                value: "0aff769b-b20f-40db-b98a-6b3a424beccf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "415cad80-031c-445e-a66f-959c0e14218a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "837a329c-0272-4476-948c-c91ef54731db", "AQAAAAEAACcQAAAAEIm9/m839fCGJ3/dTBo0Ej7jEdIMucmKmZro/SDf0PFAcP7we0+3J09O1O8/01HCAA==", "52aee0d0-efe8-4cda-abcd-3354990f7494" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da88bdfc-b3b1-4e03-8467-f179f9327218",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86042d8e-e062-453c-ad49-e5e6ea6010e4", "AQAAAAEAACcQAAAAEEm6dasHMPsA+iDdbl7BJlSRkJDXBjtR/ixXG9gwPTBib+EwcD01J0IVsDx3sl+gQA==", "6cc55986-d5ce-4ed3-92b6-ec9433c959ff" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
