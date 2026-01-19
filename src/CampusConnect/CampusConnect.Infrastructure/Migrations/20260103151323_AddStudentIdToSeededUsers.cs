using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentIdToSeededUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 308, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 308, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 308, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 308, DateTimeKind.Utc).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 308, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "923fa5ea-df15-44d2-97f4-8d6340486f0a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "928a3391-489f-4596-a91e-a6f08b8e33bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "24cab09e-b409-4124-abe8-05622746574c");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 3, 15, 13, 22, 303, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 13, 22, 306, DateTimeKind.Utc).AddTicks(3607), new DateTime(2026, 1, 3, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 3, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 13, 22, 306, DateTimeKind.Utc).AddTicks(3704), new DateTime(2026, 1, 3, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 3, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 13, 22, 306, DateTimeKind.Utc).AddTicks(3707), new DateTime(2026, 1, 3, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 3, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 13, 22, 306, DateTimeKind.Utc).AddTicks(3709), new DateTime(2026, 1, 3, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 3, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24e082a3-736b-4a41-8d71-7c84232f1ed1", new DateTime(2026, 1, 3, 15, 13, 21, 981, DateTimeKind.Utc).AddTicks(2418), "AQAAAAIAAYagAAAAED5QJb7cs99iszBFL8aDCNRWgTXePTtkAAoesu3s9GEwJB6GHyde0zu8TPLt6Yy9xQ==", "9f544d69-92d3-4128-91f8-5f1319d6087b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d737f9c0-b4c9-4a0d-91ed-8a9bf9740188", new DateTime(2026, 1, 3, 15, 13, 22, 31, DateTimeKind.Utc).AddTicks(545), "AQAAAAIAAYagAAAAEF11RK+ri2lOSEGDP7P+TxgT0nV498IWllNdj3lnwX9TfxdGZ/4X3GHjOn6Vy+jINA==", "cafd18ae-6da3-459c-b944-74a0860aec2a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "StudentId" },
                values: new object[] { "459eab3a-afb9-4ae3-a27d-fae58476a208", new DateTime(2026, 1, 3, 15, 13, 22, 80, DateTimeKind.Utc).AddTicks(2666), "AQAAAAIAAYagAAAAELtEqULILf9cckU7ORPsAXAdGyUL98dtoiLZ7a2uiHkc/HvToE1ckwWzqBqbclXElg==", "713fdd40-b61e-40ce-8a58-964e7eca8263", "STD2024001" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "StudentId" },
                values: new object[] { "fbe7bd63-8c8b-4450-9d07-3f9dfe1c4169", new DateTime(2026, 1, 3, 15, 13, 22, 130, DateTimeKind.Utc).AddTicks(900), "AQAAAAIAAYagAAAAEDATo94/XIea35FD/6ufuqgvmPk36xX/fz+d2x1Jp9rKqQHPvhs0ItMxuuK7Elb8Og==", "cb080084-5a1d-4b7f-8301-80020ff7bdd1", "STD2024002" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29090ff9-33d6-4915-9040-03387f1d568b", new DateTime(2026, 1, 3, 15, 13, 22, 180, DateTimeKind.Utc).AddTicks(1316), "AQAAAAIAAYagAAAAEDK46yiwowLqxk7hdVx9EUuuRhaa8c+S5+PH5/oNjG9KLQlMeGFhF9G4ryD5o8XiSA==", "9473604c-73cd-4164-b734-1cd7ea471b59" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6563815c-8235-4eb9-80d4-1702beb078bf", new DateTime(2026, 1, 3, 15, 13, 22, 228, DateTimeKind.Utc).AddTicks(8753), "AQAAAAIAAYagAAAAEPlNLQwppZb790wOaCzLHARLuK4b34fplA4M2p0opcHUh9PyqKhh9xIHLIXqn5gk5g==", "e6512293-72f3-4c50-a0a1-ccd1f9bcb633" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "StudentId" },
                values: new object[] { "f061f84e-2782-4336-b336-c82316fdbe36", new DateTime(2025, 12, 27, 20, 0, 45, 87, DateTimeKind.Utc).AddTicks(7216), "AQAAAAIAAYagAAAAEAILwta7tLysemKVbqY14oxkW5MGa45InxPhk8zQY6rsnqNWmR7OFlaauIb5T9MfAw==", "9f1f2974-3604-4e42-87e5-cf1bebc930d0", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "StudentId" },
                values: new object[] { "d457843b-bacd-4e94-9017-b2b8a9b2bb62", new DateTime(2025, 12, 27, 20, 0, 45, 137, DateTimeKind.Utc).AddTicks(724), "AQAAAAIAAYagAAAAENlJVwU3775wS34XpB9prfMI/mRX9BzmqvO7D+31342Un71YrEsOP2M7tvFhaA9rfw==", "be442bfb-394a-4c8e-b491-de3d4cf9a0f4", null });

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
        }
    }
}
