using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCategorySubscriptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategorySubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySubscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelatedEntityType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedEntityId = table.Column<int>(type: "int", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1188ef09-3d27-4051-a50a-d0afb4511d65");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "092b6087-b1a5-4ce2-91be-2a4c6cccdbf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "74ff0ed5-5a98-46f8-b4a3-95e25a58b212");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b03bb9e4-1b46-4cb7-9cd5-36e361a3cc11", new DateTime(2025, 12, 25, 0, 51, 32, 746, DateTimeKind.Utc).AddTicks(1384), "AQAAAAIAAYagAAAAEP6ZUdMfwdwOzqihfiM/rZNhwCohPDlPbCxyEG61nYJSH+gySlIEwb15mVD04K7+fw==", "c47784c1-e378-417b-b297-dec8b80287ed" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5062970-a833-491f-b635-03b6c265d02f", new DateTime(2025, 12, 25, 0, 51, 32, 819, DateTimeKind.Utc).AddTicks(5456), "AQAAAAIAAYagAAAAEL+3kpbFV4A21Rpz4OfbqMd1wGSMIpypczTSI0dUWCKacGzTFUKMTp2oQZwVWm1kSA==", "e2b15d6f-234e-4095-b1c0-f46f7f0d34e8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fc89db3-2a67-4755-b598-6dc5a75fada3", new DateTime(2025, 12, 25, 0, 51, 32, 889, DateTimeKind.Utc).AddTicks(9017), "AQAAAAIAAYagAAAAEFGhTmhwVOoDemdjpaKkiyP0o8AYomjsdAzpC198VByLamI2WpdvTTy9kwRgOBOf3w==", "45b9ec6c-1432-4377-82fa-cc4895f89b66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef829aff-e862-4074-9ada-21196e43aafe", new DateTime(2025, 12, 25, 0, 51, 32, 961, DateTimeKind.Utc).AddTicks(6166), "AQAAAAIAAYagAAAAEI8ptz3fchNthCBB0uvrTsbNgWQmFMjynA29GJ1SihbJbY3c9ocueThCCKPErDIh+g==", "dbda5120-dfd2-4c82-a88b-94acabeb0ed5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9e121f2-33a7-480e-bb8f-030e3b3f1f6b", new DateTime(2025, 12, 25, 0, 51, 33, 30, DateTimeKind.Utc).AddTicks(913), "AQAAAAIAAYagAAAAELm8sSBwIia779AdMSjzVjmkE1uO08imGaQFD9j0eytWcbtWAihW9eXrfeccOrO6zg==", "1acf3e91-37ca-426d-b29b-534d2c607c68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e0fe50b-cf9d-4d6b-b642-ace715bfdcd9", new DateTime(2025, 12, 25, 0, 51, 33, 98, DateTimeKind.Utc).AddTicks(7454), "AQAAAAIAAYagAAAAEL+cK0ioOBv0TC1H75JC9OrusoENTdi0/CTZqF9daQFW4Z4bgi7QUFbQxPtuHCTcFg==", "f73bed05-8c8f-407a-acb4-788cd4a2bb0f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategorySubscriptions");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ed7cb12b-9dfa-4eae-94fa-0a3b9ae5e2d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5412c40e-39bf-4644-aa72-0f56c6d571d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "847c0af9-7e83-4bbf-b02f-e5db4deb4529");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6496d879-1e62-414f-9848-f0061dbdfbf3", new DateTime(2025, 12, 24, 13, 9, 9, 266, DateTimeKind.Utc).AddTicks(4149), "AQAAAAIAAYagAAAAEKGInmQ6cyp7XaWQnKuTvficzxt5dlPTBjAU/TthnJG+yT+k3ABgJqoAv6HsumHaxA==", "7dfc50cf-96b6-44f1-91e5-1cdd4b62db4b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f915f2a-c726-4c54-a083-9022f02482fc", new DateTime(2025, 12, 24, 13, 9, 9, 325, DateTimeKind.Utc).AddTicks(1262), "AQAAAAIAAYagAAAAEPpf7zM/u33gx3nHiLr2FgcKqM9NkUotfmOd1mmdRIc8BV7CIfzcr7hoFFfcNgKzGg==", "dc9de1ea-2bcf-48fb-b14b-381207bb99d9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42494a9e-af09-4e4b-8865-fda87b98bfae", new DateTime(2025, 12, 24, 13, 9, 9, 380, DateTimeKind.Utc).AddTicks(7147), "AQAAAAIAAYagAAAAECW909U3TT0OEls/M5wTZdBFDxM+HUE6xnfR90GRadSDCegr9uCsLKwHwxhof7LR2g==", "2f54558a-f61e-4a55-8e64-7bb956b2f421" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20ea6a73-8cf4-4d7f-8603-5743f9e61b04", new DateTime(2025, 12, 24, 13, 9, 9, 435, DateTimeKind.Utc).AddTicks(4572), "AQAAAAIAAYagAAAAEKIaX2RJxuU2PE2oX4Bvihy2uPSwMUo/kCY8RpiUdcG4wlrPXR7Y6Hq+M1dxKMvtZA==", "32583667-7d52-4497-9d93-70c868896d57" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "372eed26-7dc8-441f-b65e-128e7ccacccf", new DateTime(2025, 12, 24, 13, 9, 9, 490, DateTimeKind.Utc).AddTicks(3070), "AQAAAAIAAYagAAAAEC1BWuqL/TN0z1X57zNe9cwC8Ir5jOTMqrk6cAlW4/OekYlqUXD/KNJtPDLvyaUhVA==", "0d73adf3-611c-46c6-a040-ae61c93eb39c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20610812-d524-4d78-9cde-6f732174eb01", new DateTime(2025, 12, 24, 13, 9, 9, 545, DateTimeKind.Utc).AddTicks(6497), "AQAAAAIAAYagAAAAEGV7wmcmnLOOnFs2NSOgP7wDbAkexQ/hH7b1c5+ia9cd1bIfEIDjb8FFWmRiiJGh3Q==", "f3785ebe-4465-4fad-959b-9699cc5cea0a" });
        }
    }
}
