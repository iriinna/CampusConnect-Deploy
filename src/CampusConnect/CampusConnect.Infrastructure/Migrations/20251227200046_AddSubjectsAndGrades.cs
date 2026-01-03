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
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ProfessorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Value = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                        name: "FK_Grades_Users_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 318, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 318, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 318, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 318, DateTimeKind.Utc).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 318, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 313, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "40a95c30-703c-44e2-8bcb-7b70239033fd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0191a186-2522-47e7-8d90-29e622c14648");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b124526f-8ece-48e9-bfeb-fb38890cf5aa");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 0, 45, 314, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 27, 20, 0, 45, 316, DateTimeKind.Utc).AddTicks(1587), new DateTime(2025, 12, 27, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 27, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 27, 20, 0, 45, 316, DateTimeKind.Utc).AddTicks(1685), new DateTime(2025, 12, 27, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 27, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 27, 20, 0, 45, 316, DateTimeKind.Utc).AddTicks(1688), new DateTime(2025, 12, 27, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 27, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 27, 20, 0, 45, 316, DateTimeKind.Utc).AddTicks(1690), new DateTime(2025, 12, 27, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 27, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cd0d191-ea3a-4576-84c9-0e2504ca8371", new DateTime(2025, 12, 27, 20, 0, 44, 974, DateTimeKind.Utc).AddTicks(6235), "AQAAAAIAAYagAAAAENHzAAoVtLAyYA/DVUMxZsajcLk2fPSAbyjxj0X0at08wnG7OiDnLHZWg2GfjQEg6g==", "dabd2d0a-5d88-497e-b6db-b852a58479d6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1da0f8bc-238d-4377-be36-c970fc34b45c", new DateTime(2025, 12, 27, 20, 0, 45, 35, DateTimeKind.Utc).AddTicks(2552), "AQAAAAIAAYagAAAAEDc99lHihUXcnxb04IDAysh0gZ2UrQQeomMtJaP4xcrlnAv8O2oVhwgTGbMHOMYa9A==", "fa36afd3-b6fc-4819-b3c2-e48fef6feeae" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f061f84e-2782-4336-b336-c82316fdbe36", new DateTime(2025, 12, 27, 20, 0, 45, 87, DateTimeKind.Utc).AddTicks(7216), "AQAAAAIAAYagAAAAEAILwta7tLysemKVbqY14oxkW5MGa45InxPhk8zQY6rsnqNWmR7OFlaauIb5T9MfAw==", "9f1f2974-3604-4e42-87e5-cf1bebc930d0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d457843b-bacd-4e94-9017-b2b8a9b2bb62", new DateTime(2025, 12, 27, 20, 0, 45, 137, DateTimeKind.Utc).AddTicks(724), "AQAAAAIAAYagAAAAENlJVwU3775wS34XpB9prfMI/mRX9BzmqvO7D+31342Un71YrEsOP2M7tvFhaA9rfw==", "be442bfb-394a-4c8e-b491-de3d4cf9a0f4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39b4bae1-f425-4ede-b4a4-d7524f880622", new DateTime(2025, 12, 27, 20, 0, 45, 184, DateTimeKind.Utc).AddTicks(2072), "AQAAAAIAAYagAAAAEFdpf54ijDlq+02keCGK/d14ZHhOBaixi3DwtaCzsy9ZkZXACbL4P7heirmu1Yb9Zg==", "73d27e59-6501-4e27-9d55-d8ef59f4c176" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "955d2280-d125-4f01-a174-a8ba7e192452", new DateTime(2025, 12, 27, 20, 0, 45, 237, DateTimeKind.Utc).AddTicks(8081), "AQAAAAIAAYagAAAAEOj7tD4MRLkGJexXYjcMUbhmjXNLpvEcA+vXv1rNRyZtlc6QrqX2bltvEeN6vDUPrg==", "1d450ba4-14ef-4ae7-ae9c-6bd5d9865f15" });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_SubjectId_StudentId",
                table: "Grades",
                columns: new[] { "SubjectId", "StudentId" });

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
                value: new DateTime(2025, 12, 26, 21, 38, 43, 175, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 175, DateTimeKind.Utc).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 175, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 175, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 175, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e20594a7-bebf-45e9-b0bc-a09b73d9525c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7f128850-d0d1-4f3c-af11-e3732dfb1003");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "3e209626-e88b-47e7-8d14-d263467cdcdb");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 43, 170, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 26, 21, 38, 43, 173, DateTimeKind.Utc).AddTicks(7807), new DateTime(2025, 12, 26, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 26, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 26, 21, 38, 43, 173, DateTimeKind.Utc).AddTicks(7893), new DateTime(2025, 12, 26, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 26, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 26, 21, 38, 43, 173, DateTimeKind.Utc).AddTicks(7896), new DateTime(2025, 12, 26, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 26, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 26, 21, 38, 43, 173, DateTimeKind.Utc).AddTicks(7898), new DateTime(2025, 12, 26, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 26, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "058281c8-3b5b-4099-beb2-7dc878ba2a07", new DateTime(2025, 12, 26, 21, 38, 42, 866, DateTimeKind.Utc).AddTicks(3621), "AQAAAAIAAYagAAAAEIPhLC+w+eFexGIucbvxPZol8GZq+83Qbah+TBdAI1aqKQt9hL6nUORzecaetu4+Hg==", "b6acd06f-cc79-4ce6-a342-af1af669eef8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24718615-401d-474f-9954-2082fa72fd8d", new DateTime(2025, 12, 26, 21, 38, 42, 921, DateTimeKind.Utc).AddTicks(2754), "AQAAAAIAAYagAAAAEG4yF/8APBNbmWD247fcCs3aU8mQI/lWcFy5cRkL/3pNOLK4cHRBnUQdKjDHWux3QQ==", "055edf23-9750-4043-8633-e8e835eb7ef2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b666868e-a572-4266-be7b-446a85989c51", new DateTime(2025, 12, 26, 21, 38, 42, 970, DateTimeKind.Utc).AddTicks(1842), "AQAAAAIAAYagAAAAEI/G/fypQ11VKm/EXyDqlNvpud8YIJnIpzhq4ZWk5S0bupkgjT44C5tZY8Kda4tp3g==", "85b33427-77c2-4000-8774-290ad2776148" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9585838e-34a7-467a-8f7c-728e4250cee0", new DateTime(2025, 12, 26, 21, 38, 43, 18, DateTimeKind.Utc).AddTicks(7808), "AQAAAAIAAYagAAAAEISwmZNZIxyfZw91zem3/1N4CiZ/a0XVbu/5UUM6uUjGpXLPoeWFsH6G0byMSYmZtA==", "c3e2b20e-3cc8-47fd-a73d-872259e92075" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdeec5a3-dec4-408b-8e95-2ca411222279", new DateTime(2025, 12, 26, 21, 38, 43, 65, DateTimeKind.Utc).AddTicks(8567), "AQAAAAIAAYagAAAAEIENEXTjlS2Cb5aWAFcZnL7jRnW5HUa2ILOTBfnBAFDP7mHVjGMzKa3IihkXdQ3vRw==", "e724cf75-c4b3-429e-bcc5-3483b06c64a0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b57ac2c7-e6bf-4e47-9b65-73881e0511e5", new DateTime(2025, 12, 26, 21, 38, 43, 109, DateTimeKind.Utc).AddTicks(5254), "AQAAAAIAAYagAAAAEBqCaRCA+d32M5c2N11SroCcPW1eSJMEVfvg8eKYzRvNarNoh2fbYi1oBjonQn0A/Q==", "316662e3-d3a7-43cf-bc93-0daa8e39af4a" });
        }
    }
}
