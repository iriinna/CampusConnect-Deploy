using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFmiAmphFloors2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 173, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 173, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 173, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 173, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 173, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7a95b8f5-d752-4074-abec-3239f7c19c2a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5b954b3c-27b4-4fe5-a4df-51d9c9dbcca7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6f27586a-9bc8-4de5-be16-56bc2ee8a0cd");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "Floor" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9965), "Etaj 3" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "Floor" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9968), "Etaj 1" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "Floor" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9970), "Etaj 2" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BuildingId", "Capacity", "CreatedAt", "Equipment", "Floor", "IsActive", "Name" },
                values: new object[,]
                {
                    { 161, 13, 50, new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9994), null, "Parter", true, "S1" },
                    { 162, 13, 50, new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9996), null, "Parter", true, "S3" },
                    { 163, 13, 50, new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9997), null, "Etaj 2", true, "S201" }
                });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 171, DateTimeKind.Utc).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 171, DateTimeKind.Utc).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 171, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 41, 171, DateTimeKind.Utc).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08f876e3-00f4-4f58-9294-fdb58ea792df", new DateTime(2026, 1, 6, 15, 39, 40, 812, DateTimeKind.Utc).AddTicks(4420), "AQAAAAIAAYagAAAAEH9CZgTCs8CZYBgha2uJiIIbvP0fQNAfvf0T1jFkNJdD7H/43bIJ/WSe7Y2b452HWg==", "deaceb62-5c2a-4fba-8b5f-20ab6ae974ea" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99a72f73-acd9-4275-8da1-ff40e50a934e", new DateTime(2026, 1, 6, 15, 39, 40, 874, DateTimeKind.Utc).AddTicks(5828), "AQAAAAIAAYagAAAAEN70oyfDnJeyBPmQjppJycDZjI95/MjjNnY3suxOEKZAbmmnG6UaXoApKaDxVBm1Xg==", "14e15876-ca80-47d4-a012-428ca2c19afb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d1e9430-f798-4600-8732-31392e324a5f", new DateTime(2026, 1, 6, 15, 39, 40, 929, DateTimeKind.Utc).AddTicks(4035), "AQAAAAIAAYagAAAAEAH3wx7t9TLUYVJn/wypWx6dULeUD9XEP3S/BDjbOotsn8gJYLuBUUgdKFeR/I7eZQ==", "545dea90-327a-46cd-b83b-d7130f8a114c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c455582-0396-4796-b325-f50ad17fcf63", new DateTime(2026, 1, 6, 15, 39, 40, 984, DateTimeKind.Utc).AddTicks(555), "AQAAAAIAAYagAAAAEKl96kVo9qgU9q7TUSIBvr142EzplaCePz7OmhHU8FOL00o65BVySpOatalR+E+m+w==", "c6c9ae5f-8a93-4346-9f61-0c22e1a1c934" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "217cd969-06f3-4a51-a714-cf067d7dc5d6", new DateTime(2026, 1, 6, 15, 39, 41, 38, DateTimeKind.Utc).AddTicks(9332), "AQAAAAIAAYagAAAAEN/VclRBFlsudE/7KsA6TlyddXhtSChn3f7fNcaf4/L9AOWK2qWTY62v9jLGHAwtlQ==", "ba71a8fc-b0a7-4617-bd31-471d5899cbbe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae5ffb14-ad73-4f10-b359-4c5c576df813", new DateTime(2026, 1, 6, 15, 39, 41, 93, DateTimeKind.Utc).AddTicks(5691), "AQAAAAIAAYagAAAAEM0jh6YUeHVOurG+gA8hknGdfvqiAmuJ4faLa0ZNNQEd+9TFGr7Jk33u/wTbgCQrng==", "19202a78-1709-4ee3-8387-91cde48f2952" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4307f0b5-24b9-41a0-8c62-96f0eec0fe79");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "bd50fa3e-bd82-4c09-b0f8-2dc32ec57ee0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "15719122-33ea-4628-9bb5-ca3d014dc4b9");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "Floor" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6475), "Parter" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "Floor" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6478), "Parter" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "Floor" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6481), "Parter" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 129, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 129, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 129, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 6, 15, 39, 3, 129, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4a176ad-f137-4718-a091-c3ae4ca2d95e", new DateTime(2026, 1, 6, 15, 39, 2, 671, DateTimeKind.Utc).AddTicks(7309), "AQAAAAIAAYagAAAAEK+4KrWROGXVMqNBI9jJGNeDta+82C8WKLGhvmI6moU31ZtUsa5y37u20o7pVLfolg==", "ee62bbe1-a7e1-4d21-abb3-7b343f2a2f87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "956aae38-c3c5-45cb-88b5-f1a0df2c7644", new DateTime(2026, 1, 6, 15, 39, 2, 743, DateTimeKind.Utc).AddTicks(4072), "AQAAAAIAAYagAAAAEIVttbYVg8wcpeGvCwh+xLNs9EseguzmgTmCJPic06zui+rE96IqMVfpxdSHvWhfwg==", "04f12232-3911-49c3-9d93-d3e71671dc23" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40509274-ca42-452e-baec-67cea2f28c04", new DateTime(2026, 1, 6, 15, 39, 2, 812, DateTimeKind.Utc).AddTicks(7557), "AQAAAAIAAYagAAAAELsBi6ccY7QVEkfARhDZbfI4d1nWmkCgeJdDp6UjPZY98zlA202XcB65U8MXAyEgfg==", "93cc3c84-03ea-4930-8a1e-3e327016ad4d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e792b52b-9a99-496f-a511-9dcbf4a96514", new DateTime(2026, 1, 6, 15, 39, 2, 885, DateTimeKind.Utc).AddTicks(7621), "AQAAAAIAAYagAAAAEEARrVqDorKU32//LHNSZ8DJBUHHmLcCxqsE64RyCq0GXgOq6QLTMaRVOtDzTVWTcg==", "d82e52f7-26c5-4633-8215-f77565efd6f7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ab4f078-7a2e-4b48-8ed3-7aaf551c19e2", new DateTime(2026, 1, 6, 15, 39, 2, 953, DateTimeKind.Utc).AddTicks(7733), "AQAAAAIAAYagAAAAEM5SLN41CndZcjZQfX3g1F28iwA7ASKMTE8ky5PKF3NZGqlY31MNpe5Y7O1f6EG1IA==", "26473315-7f74-4573-8025-1bc1c9948b88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "054173d3-83e7-479f-b0af-c00f81dc567b", new DateTime(2026, 1, 6, 15, 39, 3, 22, DateTimeKind.Utc).AddTicks(6092), "AQAAAAIAAYagAAAAEPxes5oB7cr6rR6oIVgAHJl68JO0eXSvoILOU5SI4IOklm29Fog7oBI/qqS2ne71Ng==", "7c6820ff-e87b-4bde-bf52-bad78368d00c" });
        }
    }
}
