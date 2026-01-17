using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSubjectsAndGradesV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(4004));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
