using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSubjectsAndGrades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ProfessorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Users_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByProfessorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grades_Users_CreatedByProfessorId",
                        column: x => x.CreatedByProfessorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grades_Users_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 631, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 631, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 631, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 631, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 631, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "407559a0-03e0-4845-a81e-c6b2a858e35a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5237ef4c-c33c-48e8-96a4-edcab72a770d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1e7e0bd4-c047-4749-bd73-88bae4402110");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 629, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 629, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 629, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 629, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cbaf3fd-b9ee-48fb-8b8a-a58a026ab163", new DateTime(2026, 1, 17, 10, 53, 58, 342, DateTimeKind.Utc).AddTicks(3763), "AQAAAAIAAYagAAAAEGh80tZMGckTFYpvuqWDZa4U+GJwEgJugUX5ZhS6SV78k1Ir1lUKSo/ECodCDRi0Bg==", "f2d188a0-cce7-4e3b-a704-1a6dfe185de4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "532e43c9-d14f-4400-971e-14de16b6c44e", new DateTime(2026, 1, 17, 10, 53, 58, 387, DateTimeKind.Utc).AddTicks(3000), "AQAAAAIAAYagAAAAEMBKGh0tw8jAv4bhq9Fees/bN8npHmh7IAKHpowfDpNzxeX1ZecYq0oPyUsYH3IQhA==", "39f64d88-4b98-49e4-8268-0012d9dd94b4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e23505a-a8e8-460c-b5b3-71a13bd9d99f", new DateTime(2026, 1, 17, 10, 53, 58, 430, DateTimeKind.Utc).AddTicks(1262), "AQAAAAIAAYagAAAAEDRAzxbbtF5ub1vOCMnGVsJreg7bbVOCWCL/RdSjlg9XlDVBxziOaMKF3l6u4DKjKg==", "b856072b-2d3f-4cf0-b399-98c519b46c10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c86ada3f-17f4-4aa4-9805-8cd6714e1519", new DateTime(2026, 1, 17, 10, 53, 58, 472, DateTimeKind.Utc).AddTicks(3759), "AQAAAAIAAYagAAAAECOW8nJhQjd2wnUiVMVbfnE4qDP/LTnb7cX2VDidR1cfRBEsgMVKEQmAwfrURWTC5Q==", "be6d426b-60f7-4cab-98d3-f48dd205dff2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86996796-88be-4009-8e48-44af0e76f120", new DateTime(2026, 1, 17, 10, 53, 58, 515, DateTimeKind.Utc).AddTicks(3730), "AQAAAAIAAYagAAAAEO6SdyYo+TEvgS7AircAiE9BSOQMTMXE1E+hDJpkQrluznb7NHn3h9waXqXaGV8MHw==", "34411b79-1951-4926-b445-9a18f00ee393" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52d4521d-a763-4114-8e77-db20e7a3a6ab", new DateTime(2026, 1, 17, 10, 53, 58, 560, DateTimeKind.Utc).AddTicks(1131), "AQAAAAIAAYagAAAAEBegpyvZLuBcD7pQ+h6JxpahIgH/GLsbCoxehonFJD4jPYKt6bo0zI52z1HA/nsaTA==", "1a3faa30-b83a-4d14-b34a-235a9371aad4" });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_CreatedByProfessorId",
                table: "Grades",
                column: "CreatedByProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_SubjectId_StudentId_CreatedAt",
                table: "Grades",
                columns: new[] { "SubjectId", "StudentId", "CreatedAt" });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Code",
                table: "Subjects",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ProfessorId",
                table: "Subjects",
                column: "ProfessorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 702, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 702, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 702, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 702, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 702, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d088f62d-365c-451a-a988-2b79bd48fd72");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "9433128e-0e72-4f8b-923c-403773fe467b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d05db648-3e33-4df8-85fd-70eb32a84418");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 698, DateTimeKind.Utc).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 698, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 698, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 41, 20, 698, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae275cb8-1251-4b20-8071-8df20f9b0c47", new DateTime(2026, 1, 17, 10, 41, 20, 384, DateTimeKind.Utc).AddTicks(8578), "AQAAAAIAAYagAAAAEO3iK7oax/2VOioJuLWKRnDboHsUYT/nmug2UG45yfcT3fVj9C0aTP+JaHN5YoO0oA==", "9a3562e1-6cdd-4d0a-af87-c6162613c228" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a685c9d-5ed8-4728-bdc3-874df61e0bac", new DateTime(2026, 1, 17, 10, 41, 20, 430, DateTimeKind.Utc).AddTicks(9052), "AQAAAAIAAYagAAAAENx0++n5a25/eJZhmOsKtUQ97m1IbP7MxXUqyi0VbUo0e1S1Crtupa2y4b0c5D+ouA==", "42dcfd94-a0bc-4282-9ee6-c04dde7e9532" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cd7fbb4-9d3c-4849-bb5a-75aaf638eba8", new DateTime(2026, 1, 17, 10, 41, 20, 473, DateTimeKind.Utc).AddTicks(3510), "AQAAAAIAAYagAAAAEKVKt7O4ZCLn3HCclPAKDeqhr6QzIKgwUwiXkxOO52/LZQfSPkoTEpP6GW7i+pPFdw==", "78daef8f-8031-4ec6-93c1-de312f64d4a8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "088fd7a6-44b5-4c45-b823-78bbf26e9eb1", new DateTime(2026, 1, 17, 10, 41, 20, 517, DateTimeKind.Utc).AddTicks(4158), "AQAAAAIAAYagAAAAEAyA0tsgnVGLBn01SyTl1IgVBdgOAgWeKtC4+zEkG+5Mb24gR7sfUKDdzgatmTp7aQ==", "fb951b74-ed80-4557-83d9-7d5829c69e4d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e95a3ad-fdb0-4ea6-988a-0e45facf9849", new DateTime(2026, 1, 17, 10, 41, 20, 559, DateTimeKind.Utc).AddTicks(9241), "AQAAAAIAAYagAAAAEK+6sp/YfbdzpWUxMgpJVju5KWpn8dAQpncrqtH7iUonTmVMvmqrW5NSBBT6mMMAXA==", "b8630321-21f7-497a-bbf9-2830c06972bc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5897460-9779-4f46-a4a3-53f7355d72c9", new DateTime(2026, 1, 17, 10, 41, 20, 604, DateTimeKind.Utc).AddTicks(1310), "AQAAAAIAAYagAAAAEJS9d2QNPkPGDAAdUod+eRyCax2a0h4S5PXHrZ/RZuXEeHuMqut8ktTxQAGuRKqgCQ==", "d4de69f7-5418-42b1-8cb7-3e5b56ecb445" });
        }
    }
}
