using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AnnouncementsAuth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Announcements",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Announcements");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "062d8dc6-ff3d-4598-81ea-76ca64309193");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e43226a1-b42f-4dbd-81a1-31cb32205214");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "90ec0b24-df26-4d57-91af-b4543c6109ce");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05ac612d-0b1f-438b-82a3-25ec7a2c1f7d", new DateTime(2025, 12, 23, 12, 52, 27, 625, DateTimeKind.Utc).AddTicks(3425), "AQAAAAIAAYagAAAAEKUu4Xp2KXDN7jkb8Js7uW+poPaHqRmhhi371XwO1BmYCEFc0LDXYqK79SDpqt4iZw==", "6a4a496a-4b41-4d3a-8c01-570b2b8d52c6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6a2d276-78e4-487a-add8-56146d087534", new DateTime(2025, 12, 23, 12, 52, 27, 668, DateTimeKind.Utc).AddTicks(3415), "AQAAAAIAAYagAAAAEFkKkdiwa7fqZ3i9OsNOjrEHgbrPXuCysFexdIsmheBvqvBAQOQyLdaMwaD5JQBdqw==", "ad5edf82-df8a-48f7-8b06-3da3876ca83e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d3204e6-1145-4bbf-85d0-c21e5587d377", new DateTime(2025, 12, 23, 12, 52, 27, 710, DateTimeKind.Utc).AddTicks(3804), "AQAAAAIAAYagAAAAEG1z/HT+PuaFF2qbPkam1l6CLq6C9mw5ASSYZD6e72SpZUlR3Y/t1ErASV/gq1F5mQ==", "be4d5cfa-2ba6-4c54-aeb6-15d9c7720282" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a01ba234-d8a5-4726-8e8e-6211e96a0b0e", new DateTime(2025, 12, 23, 12, 52, 27, 754, DateTimeKind.Utc).AddTicks(4290), "AQAAAAIAAYagAAAAEHSxW9MdOwuHFJctL2azv1AxXQ/MMsv1ZK8EKvlwQ/3CXfdrJVo4mSFvF72MmZz1cQ==", "b6410ec6-96d0-4ca1-a444-8c8237c02b77" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06e6bbb3-56e6-4bf0-b0e1-68077652ad08", new DateTime(2025, 12, 23, 12, 52, 27, 800, DateTimeKind.Utc).AddTicks(4466), "AQAAAAIAAYagAAAAEJcm/h+/6bP4XXGYG5JALI/58oZyYpMRgAoQNMVkpH2ujxBJZ9iMKnZ6ShhwsxflwA==", "bc2262b6-2956-4337-a082-25f29bd6dd14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29ca996f-81e5-4393-823b-61c11d4b482e", new DateTime(2025, 12, 23, 12, 52, 27, 846, DateTimeKind.Utc).AddTicks(7932), "AQAAAAIAAYagAAAAEOCHQS1oj+4Lho+mUJcHzGDoimHtBhQHt+dkLt4mnZ6YB0L18eTSaoWlpSCm/Fy6zg==", "74746918-0b29-4813-b9db-e97b22fa3ec9" });
        }
    }
}
