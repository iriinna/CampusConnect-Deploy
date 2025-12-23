using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddGroupsAndTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProfessorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Users_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    JoinedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupMembers_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupMembers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByProfessorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupTasks_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupTasks_Users_CreatedByProfessorId",
                        column: x => x.CreatedByProfessorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SavedTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    SavedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedTasks_GroupTasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "GroupTasks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SavedTasks_Users_UserId",
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

            migrationBuilder.CreateIndex(
                name: "IX_GroupMembers_GroupId",
                table: "GroupMembers",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMembers_UserId_GroupId",
                table: "GroupMembers",
                columns: new[] { "UserId", "GroupId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ProfessorId",
                table: "Groups",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupTasks_CreatedByProfessorId",
                table: "GroupTasks",
                column: "CreatedByProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupTasks_GroupId",
                table: "GroupTasks",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedTasks_TaskId",
                table: "SavedTasks",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedTasks_UserId_TaskId",
                table: "SavedTasks",
                columns: new[] { "UserId", "TaskId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupMembers");

            migrationBuilder.DropTable(
                name: "SavedTasks");

            migrationBuilder.DropTable(
                name: "GroupTasks");

            migrationBuilder.DropTable(
                name: "Groups");

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

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "7078d706-b6e5-4147-a9a0-09e42fad5f98");

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdad3ea6-6283-4ede-8a3a-5b4ddb2ce6ce", new DateTime(2025, 12, 23, 11, 42, 26, 452, DateTimeKind.Utc).AddTicks(5162), "AQAAAAIAAYagAAAAELMEOysK1MuywsLoctUIcGtEQ41vrj45nR/UPgF9bYbzKLYScSHiTCmBLVTGfyeZSQ==", "36d16e1f-ebfa-47dc-928b-1dc0dff4c86e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e3c3120-8ab9-4da4-a53a-2ce4664d8df3", new DateTime(2025, 12, 23, 11, 42, 26, 558, DateTimeKind.Utc).AddTicks(3779), "AQAAAAIAAYagAAAAEBT4sAIlqRbBocPbS5OVsyH8MyaEmOPzkN0QB928X5Bp9EqlQnTGNPIjGxhWLJkavw==", "2ed1fc2b-c8d9-4e1b-8893-1e919f190048" });
        }
    }
}
