using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddYearToSubjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 546, DateTimeKind.Utc).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 546, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 546, DateTimeKind.Utc).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 546, DateTimeKind.Utc).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 546, DateTimeKind.Utc).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "39f556bd-cf2a-4c63-9a59-e6c59f4dc3b9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b395fd94-fc7d-45f7-b6f8-c0693f2f842b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "ea9fc00b-26a9-4b76-8f83-78d8b700c170");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 20, 11, 12, 15, 543, DateTimeKind.Utc).AddTicks(396), new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 20, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 20, 11, 12, 15, 543, DateTimeKind.Utc).AddTicks(491), new DateTime(2026, 1, 20, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 20, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 20, 11, 12, 15, 543, DateTimeKind.Utc).AddTicks(494), new DateTime(2026, 1, 20, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 20, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 20, 11, 12, 15, 543, DateTimeKind.Utc).AddTicks(496), new DateTime(2026, 1, 20, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c06d6559-531a-4909-b601-d8a5fb123df2", new DateTime(2026, 1, 20, 11, 12, 15, 222, DateTimeKind.Utc).AddTicks(4120), "AQAAAAIAAYagAAAAEGf0dBXQyNgoRLYJXUdoFFNs9vJAyg8a2t84vsfmJudlXlVKhykCLVufjWJpw5XEzQ==", "83c872ca-921c-436b-9569-65631da907fe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b42aea08-c117-42bd-be7a-463ee255f90f", new DateTime(2026, 1, 20, 11, 12, 15, 270, DateTimeKind.Utc).AddTicks(7482), "AQAAAAIAAYagAAAAEPYjLw3ZSouF4b1/kYK5XoKNeyRWYQUjujQ7BDQHz95DmekG3Uh2Hvm84Xrq8Zz1Fw==", "756cfdba-8ee2-436b-8fc6-f88481a830fa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54166b9c-4249-4f03-a612-cc671845958c", new DateTime(2026, 1, 20, 11, 12, 15, 319, DateTimeKind.Utc).AddTicks(5732), "AQAAAAIAAYagAAAAEPGmg3WxInjryNYNnJ3edTXz+r03VCuahLt6wT6fhpQWxN5VjtPiHaURZmlnZTcP1A==", "28a8374f-0936-4753-8c41-a82430f8082b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08442768-2656-4e9b-88b0-a70a03bdb251", new DateTime(2026, 1, 20, 11, 12, 15, 369, DateTimeKind.Utc).AddTicks(317), "AQAAAAIAAYagAAAAEJS5t2+DqhgMxgGr9w35xRPlngM0k9mTf9p5iGpFmAgizmwAiVRgUtmHk4+ylNlk+Q==", "da9c4b9e-77fb-4794-9041-2216e8724bbf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2818444-ada7-489b-89ad-353535111c1b", new DateTime(2026, 1, 20, 11, 12, 15, 417, DateTimeKind.Utc).AddTicks(8814), "AQAAAAIAAYagAAAAEFq5tcTvNX/hygqwG8UBYxNEjjRO4aWU3LZWjtN2Zmn2cIu0hXjsF+rS/KnmHij/zA==", "6fc859d6-3e9a-42b5-ac36-a87f0638685b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9a9f313-6122-4f4d-b962-d35283dfe1d4", new DateTime(2026, 1, 20, 11, 12, 15, 468, DateTimeKind.Utc).AddTicks(2675), "AQAAAAIAAYagAAAAEEmunKFPGCsVe4hkE2StJN8rdFsSdy7KCDs8oLhBvYPE7AoYj1+bAu3mvjBRBcXOJQ==", "e6457476-879b-49ed-9ebb-854d04e19c2d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year",
                table: "Subjects");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ef5769f6-3997-4f79-bf47-d5e15806bce9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6488f54f-d0d4-4c61-9ea7-253788f6bcd0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "7b494646-e406-4f49-a045-f7f4832dccf3");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(3901), new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(3998), new DateTime(2026, 1, 17, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 17, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(4001), new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 17, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(4004), new DateTime(2026, 1, 17, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d92240d1-fdba-40b6-ae27-ab26eb1dc653", new DateTime(2026, 1, 17, 10, 54, 24, 973, DateTimeKind.Utc).AddTicks(9967), "AQAAAAIAAYagAAAAECFKuErui1SND9Qt8q9/7G2AU4eBf1XYF4MnaZmdNyCivcqoNNEd96MpbvSfzbs7vg==", "68c6e342-a48e-44d2-b0fc-3da2881364bc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c1b53e2-fde8-45dc-9283-4d41c821c22f", new DateTime(2026, 1, 17, 10, 54, 25, 21, DateTimeKind.Utc).AddTicks(9274), "AQAAAAIAAYagAAAAEOhud1GLUEVTP4gT9WZi6G99/hYtCEhlGAoNgHBcg+tVgf24wgc2LpPzigQBk/8AUQ==", "65fa8e0b-3b44-4fb3-8952-d30e0f34c254" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "457f2021-a5aa-410b-a7b7-ca54cfa998fe", new DateTime(2026, 1, 17, 10, 54, 25, 69, DateTimeKind.Utc).AddTicks(9425), "AQAAAAIAAYagAAAAEENTdxugO1+FWSydemzKSWr/aAQNcYvu1DQuSar8N54qwx4uHyGPqyiZRQl3WFs+wQ==", "3490fd96-7614-496e-87ef-b4ab19bca848" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c627f547-007f-4eec-b60f-e8f57e29f1ba", new DateTime(2026, 1, 17, 10, 54, 25, 118, DateTimeKind.Utc).AddTicks(3257), "AQAAAAIAAYagAAAAEIFeQR37mc4Dtr7YrQlJgbUDlhPwPdi/La14SqR/YG99WNvLAok8DSmJC6LXzfGklQ==", "ded6cc61-6c1d-4735-8637-d82eb498d215" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21117db5-5c34-48cc-b03d-ee1f679abfc0", new DateTime(2026, 1, 17, 10, 54, 25, 170, DateTimeKind.Utc).AddTicks(8927), "AQAAAAIAAYagAAAAEB6Rh8cz7RBzyw5AuYZX1CT5QSwvodLfrWeJaSS+rFcCoaa6+/olDH75sO3oNudu7Q==", "4c852f8e-d34d-4448-ac4d-28906b8f161a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f1651bd-2846-4dd5-8ee7-f46c7f1d4bb6", new DateTime(2026, 1, 17, 10, 54, 25, 222, DateTimeKind.Utc).AddTicks(7494), "AQAAAAIAAYagAAAAEA32Huc5pb7nKufGeB8JGnvpd9EsVs6FHQvBxKx1rZD4UNarWlljglVUZO575TvILg==", "91148053-ab2f-44d5-b81c-d9af8f06ac78" });
        }
    }
}
