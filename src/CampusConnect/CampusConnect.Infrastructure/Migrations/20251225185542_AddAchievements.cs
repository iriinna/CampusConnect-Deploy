using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAchievements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAchievements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AchievementId = table.Column<int>(type: "int", nullable: false),
                    UnlockedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAchievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAchievements_Achievements_AchievementId",
                        column: x => x.AchievementId,
                        principalTable: "Achievements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAchievements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedAt", "Description", "Icon", "IsActive", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 25, 18, 55, 41, 44, DateTimeKind.Utc).AddTicks(6161), "Complete your first task", "🎯", true, "First Steps" },
                    { 2, new DateTime(2025, 12, 25, 18, 55, 41, 44, DateTimeKind.Utc).AddTicks(6578), "Complete 5 tasks", "⭐", true, "Task Master" },
                    { 3, new DateTime(2025, 12, 25, 18, 55, 41, 44, DateTimeKind.Utc).AddTicks(6582), "Complete 10 tasks", "🏆", true, "Task Legend" },
                    { 4, new DateTime(2025, 12, 25, 18, 55, 41, 44, DateTimeKind.Utc).AddTicks(6585), "Join your first group", "👥", true, "Team Player" },
                    { 5, new DateTime(2025, 12, 25, 18, 55, 41, 44, DateTimeKind.Utc).AddTicks(6588), "Attend your first event", "🦋", true, "Social Butterfly" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4a442bf9-5441-4d08-8fad-0090f31aa1f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b8dadc22-6ad2-4c0a-8e16-af8b72400180");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "cdec7c6a-625d-45d1-aac2-3d604adbfa3e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b802377-06cd-4fbc-bf7b-726a86779e68", new DateTime(2025, 12, 25, 18, 55, 40, 233, DateTimeKind.Utc).AddTicks(3044), "AQAAAAIAAYagAAAAED1/UGe7ueVpdsp2tlGvG5DQO+1qm7kqONzNcXjYNmH6lmH+0Eku0X9u6aO2o/aG5A==", "c8242a8b-f022-479a-9a2a-3625861c496e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe617332-c469-4c84-8666-c6fd8ae5e370", new DateTime(2025, 12, 25, 18, 55, 40, 363, DateTimeKind.Utc).AddTicks(3431), "AQAAAAIAAYagAAAAEB8NAzs05YJbG58A9jUJreHRyhMI17gDCzVttwWOZe9gywTzF0Y/d2wffwF64K8jiw==", "ace32022-f8d5-4c4b-b247-13efa557b2da" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c31b7d10-73c9-468b-b902-570ddd2ca4a1", new DateTime(2025, 12, 25, 18, 55, 40, 498, DateTimeKind.Utc).AddTicks(8199), "AQAAAAIAAYagAAAAEBPf+2F5VlbkH678gS+sr6nsTclUvaA+HOVAdHk+XMb8232EIHTjONHx/UaLC0aLoA==", "dab0fc1e-e305-4747-a9d9-08b293f52059" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba900d4a-4b60-4e62-b0bb-cf4e33396c9c", new DateTime(2025, 12, 25, 18, 55, 40, 623, DateTimeKind.Utc).AddTicks(4497), "AQAAAAIAAYagAAAAEM7c+ByjtZOlIeY3Dq/me2MScifrXicSyYFQWpTMErCWW+OPqX4nBX9lbSVqdnvUhw==", "ec2aa4a7-3d05-4a65-ba2a-dce4074d12e1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b0de819-1826-440a-a76a-bc0bb6b9382a", new DateTime(2025, 12, 25, 18, 55, 40, 769, DateTimeKind.Utc).AddTicks(7442), "AQAAAAIAAYagAAAAEEvn/9SBXCofM6kxO9KZk0x3MF2gYXYmoS0HPPU/e9gm69YhtkNBX29s5vIoSwlZng==", "97463517-a034-4831-98c5-c36c0df93810" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f42a02b-af32-4d02-891e-43c6a1884c2e", new DateTime(2025, 12, 25, 18, 55, 40, 917, DateTimeKind.Utc).AddTicks(8419), "AQAAAAIAAYagAAAAEFymbuj+TqyMzQldA5JMP9RhhfFp0+fBs4AYOLP5yRmiW1uep0rNBHidXIUXUrsuDA==", "d89147e6-f119-4a20-94be-1259b700e33f" });

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_AchievementId",
                table: "UserAchievements",
                column: "AchievementId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_UserId_AchievementId",
                table: "UserAchievements",
                columns: new[] { "UserId", "AchievementId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAchievements");

            migrationBuilder.DropTable(
                name: "Achievements");

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
    }
}
