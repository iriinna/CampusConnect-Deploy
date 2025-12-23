using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddProfessorRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1ac54da4-37c6-464c-95bc-4ac77b718324");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f16c879f-a48f-44ef-9b6d-44a588fcadd1");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 3, "7078d706-b6e5-4147-a9a0-09e42fad5f98", "Professor", "PROFESSOR" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00071acf-1d28-4d25-b4ba-dbd1c5cbafe0", new DateTime(2025, 12, 23, 11, 42, 26, 57, DateTimeKind.Utc).AddTicks(4597), "AQAAAAIAAYagAAAAEBb6XbXg5/2RHrwTN5RG2WMbwK8uQePgtLEaHnAsi+3GJW6mLNG6Na1yKASZQn42Qg==", "f6d6524b-3015-4767-9504-1881ebbc81c1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c4b0ae2-fc7e-4bc5-9a6a-e94379054cf0", new DateTime(2025, 12, 23, 11, 42, 26, 150, DateTimeKind.Utc).AddTicks(3112), "AQAAAAIAAYagAAAAEH+Fa3Fu+BzNnPgdJ8QE+r3NRoNom10M3SvB+jvelJOerUidG+qSAQOfid4sKubj3A==", "03df8f16-0e61-4ab5-95c8-23c52b228113" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01051681-cd8c-4a5f-ac78-22cf63cbb108", new DateTime(2025, 12, 23, 11, 42, 26, 252, DateTimeKind.Utc).AddTicks(6451), "AQAAAAIAAYagAAAAEF1XfU7/HfqXzCBMZbNfJyN4WtEiI3vFl54SNxiXYi78SjRLrinEn7KIB0AOAfMS8g==", "dd2867d4-273f-4cfb-a028-a7821fe513b6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5996806f-be40-415e-a669-3e4bcf235b0c", new DateTime(2025, 12, 23, 11, 42, 26, 349, DateTimeKind.Utc).AddTicks(661), "AQAAAAIAAYagAAAAEMfzztcRt9vne6HLSkHKvrDAnqmNwBpb19WILDE4r1osyggbKaQPxnatO6DFutjwNw==", "47e12480-6eb3-41ba-abec-7d38fe7c40bf" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastLoginAt", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "StudentId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 14, 0, "cdad3ea6-6283-4ede-8a3a-5b4ddb2ce6ce", new DateTime(2025, 12, 23, 11, 42, 26, 452, DateTimeKind.Utc).AddTicks(5162), null, "anastasia.ispas@s.unibuc.ro", true, "Anastasia", null, "Ispas", false, null, "ANASTASIA.ISPAS@S.UNIBUC.RO", "ANASTASIA.ISPAS@S.UNIBUC.RO", "AQAAAAIAAYagAAAAELMEOysK1MuywsLoctUIcGtEQ41vrj45nR/UPgF9bYbzKLYScSHiTCmBLVTGfyeZSQ==", null, false, null, "36d16e1f-ebfa-47dc-928b-1dc0dff4c86e", null, false, "anastasia.ispas@s.unibuc.ro" },
                    { 15, 0, "6e3c3120-8ab9-4da4-a53a-2ce4664d8df3", new DateTime(2025, 12, 23, 11, 42, 26, 558, DateTimeKind.Utc).AddTicks(3779), null, "irina-maria.istrate@s.unibuc.ro", true, "Irina-Maria", null, "Istrate", false, null, "IRINA-MARIA.ISTRATE@S.UNIBUC.RO", "IRINA-MARIA.ISTRATE@S.UNIBUC.RO", "AQAAAAIAAYagAAAAEBT4sAIlqRbBocPbS5OVsyH8MyaEmOPzkN0QB928X5Bp9EqlQnTGNPIjGxhWLJkavw==", null, false, null, "2ed1fc2b-c8d9-4e1b-8893-1e919f190048", null, false, "irina-maria.istrate@s.unibuc.ro" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 3, 14 },
                    { 3, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "80d0df97-9a34-4fce-8cc6-c730248b75d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "cd93387d-d9fe-44f6-a2b6-00fb274e2354");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91349f47-285d-492c-9476-19b04bdac18b", new DateTime(2025, 12, 23, 11, 26, 18, 588, DateTimeKind.Utc).AddTicks(3459), "AQAAAAIAAYagAAAAEHn3SqBRgVWA/kMbDd8lH6YJjBKf4VbGu3f/aVOjFvsU2igbJbwUF7IgtJOFpdiZ9g==", "800be171-27fe-4716-9f2e-d42191fb506d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17797c47-fa9d-48c6-9782-4b7513857fa2", new DateTime(2025, 12, 23, 11, 26, 18, 634, DateTimeKind.Utc).AddTicks(2365), "AQAAAAIAAYagAAAAEPXf4mvRXnCjjeVpEcnSR03XPmSf9x3KYv6QU/oXEpFuA+dRy4cUYfkfRXzOY7AW7w==", "cacefe33-e957-41df-ba81-08b92a9280c0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3619694d-6302-4913-81f4-81fb9347b71d", new DateTime(2025, 12, 23, 11, 26, 18, 678, DateTimeKind.Utc).AddTicks(9222), "AQAAAAIAAYagAAAAEP9BvmZZoIF8PEnymfFdx+xy/TcWI/N2Z1y521gPPDYlepQbdzHjmozTyxq7JGpqNA==", "dc2f9d9f-9d29-47b8-bff5-3578d6c80af3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c7851e7-b403-4c57-b7e7-7c4fe0b8d90f", new DateTime(2025, 12, 23, 11, 26, 18, 722, DateTimeKind.Utc).AddTicks(5132), "AQAAAAIAAYagAAAAEDNgCB6E1zvvEyJZHrg65Lv5hhkQMeBoVUbesuQpPOWFOJIRGRpqud88YCY0Ri/uXw==", "ce608f39-a3c8-4728-a639-7707be901ebd" });
        }
    }
}
