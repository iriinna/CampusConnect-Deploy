using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSavedEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SavedEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SavedEvents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SavedEvents_EventId",
                table: "SavedEvents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedEvents_UserId_EventId",
                table: "SavedEvents",
                columns: new[] { "UserId", "EventId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SavedEvents");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f875f033-77d5-4279-85c7-3c1362287797");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f02a5dd4-2bf6-4e74-be82-4f172be0f996");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a8f63cf9-b789-45d4-98d8-65ca0f59e51a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39d161af-89ff-43ee-936b-51ffefbaad6d", new DateTime(2025, 12, 23, 11, 57, 30, 900, DateTimeKind.Utc).AddTicks(5823), "AQAAAAIAAYagAAAAEMFo4WAxG9GMFDtH2sS5Rrf79VT8ayBxpcuRDemNUQqHn1QYXXyNGDdAewuiYLP2dA==", "032072a4-ee84-446d-8bc3-30bfcdc43a3b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2e35a39-c420-4acb-87aa-fd1c0801975a", new DateTime(2025, 12, 23, 11, 57, 30, 955, DateTimeKind.Utc).AddTicks(4222), "AQAAAAIAAYagAAAAEL7UqtYs9aULnfgdw808VVTLaeYD4mttzWiXw4Vlqtx1E/VNOUQ0tr909T6U0UGdDw==", "ab598450-2019-4846-b2d7-9710f9f3d1fd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e986d87-0a0f-4b64-b8d0-bdbe3f84ed96", new DateTime(2025, 12, 23, 11, 57, 31, 8, DateTimeKind.Utc).AddTicks(6501), "AQAAAAIAAYagAAAAEOsfRCt6h7SAu3CfhU1pqSnGf3UQHhaafCqGWiggDQMS/7Jz5y1U8pl4KzBOI9KfsQ==", "8967e9cf-cad7-43ac-8c8d-2d7807f622e8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66ef1d35-8b0e-44fc-a1e1-f3779e9fd5f5", new DateTime(2025, 12, 23, 11, 57, 31, 59, DateTimeKind.Utc).AddTicks(4792), "AQAAAAIAAYagAAAAELNfAsASwaVnuxS2Hcp5uOBe0LEShqPYXFws0Dvg85tvH2HU9vzqGAmr8GENJeLAww==", "1506c962-e3d6-40d2-aeb7-d17e8cf7d11e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54f7df32-b1c0-405c-840e-2196cd9abd74", new DateTime(2025, 12, 23, 11, 57, 31, 112, DateTimeKind.Utc).AddTicks(9162), "AQAAAAIAAYagAAAAEM0kqbGYn/9AciyGWvS32Isa60LVISCfIB+ilyxPYWuyv5ObPx8aH26wRjlgGyevuQ==", "75548821-be00-43e0-990c-8ba33a647243" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f8ea399-b49d-424e-bbf5-0a6596228b06", new DateTime(2025, 12, 23, 11, 57, 31, 159, DateTimeKind.Utc).AddTicks(7642), "AQAAAAIAAYagAAAAEE008qDo4zNmlDlhSruk+p3bvBGYLRr4AvKpuIiajKOQf37ePWss2T+Ab8znRFPjPw==", "06f2f268-0311-4253-ba24-8faac21224e7" });
        }
    }
}
