using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePreciseGPSCoordinates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8404), 44.434719999999999, 26.100719999999999 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8740), 44.434719999999999, 26.100719999999999 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8746), 44.435240999999998, 26.082077000000002 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8760), 44.436540000000001, 26.101890000000001 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8771), 44.435839999999999, 26.096830000000001 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8812), 44.435830000000003, 26.100809999999999 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8818), 44.435830000000003, 26.100809999999999 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8822), 44.435839999999999, 26.096830000000001 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 370, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f979c52a-cec0-4067-9dbf-f3d303abc391");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0065f712-6f11-4ae9-b905-a6edda8b118d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "4b19c6af-6502-412e-8bce-61f748a3a79b");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 371, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 374, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 374, DateTimeKind.Utc).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 374, DateTimeKind.Utc).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 28, 10, 374, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a865b69-d98c-4424-81d0-e70990c9dcc6", new DateTime(2025, 12, 25, 22, 28, 9, 925, DateTimeKind.Utc).AddTicks(4085), "AQAAAAIAAYagAAAAEG+apd6bz3i79tzgc4GZ4MDqVg8wh/seWWl4qqZpkfF95sGWb+VQioUas9qBkNPDvg==", "f44776c0-1767-4f8c-9f05-abcb63c3220c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de05550f-4b9a-47d6-b33f-0b57b4b4958e", new DateTime(2025, 12, 25, 22, 28, 9, 984, DateTimeKind.Utc).AddTicks(6323), "AQAAAAIAAYagAAAAECffsYYqVF9Z7NBCTv9+kuYfB20IEx1sp9o9CCQtcK3BLaBLc0FgyDY1y4duqGRmhQ==", "9c4c72be-4fe7-4bc1-8a6c-b3d7ab3eab46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ce1a1c0-61c5-4262-b6c6-b2e0f82feef5", new DateTime(2025, 12, 25, 22, 28, 10, 43, DateTimeKind.Utc).AddTicks(219), "AQAAAAIAAYagAAAAEObShCmC0wmFl6PLv8gtgPO/c+JQIF3l+1NKqLgNzkKTCeVtKgsNUWFgGkfncI1aPQ==", "69b97e58-b9e0-4c53-9f75-b7611a209043" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "139403de-aee2-4d4a-9f83-9f181cd3defd", new DateTime(2025, 12, 25, 22, 28, 10, 100, DateTimeKind.Utc).AddTicks(4088), "AQAAAAIAAYagAAAAEH+tsIQ307M/hYbHjGEHDOq0EA2UnthRj703yg6C4Udp2yQ+6CqKSuqC1xzHy8RwIg==", "acb5ad9b-f15d-478d-a31a-aeadb3425fcb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c97a1307-c0c5-4ee4-83f1-43a874480800", new DateTime(2025, 12, 25, 22, 28, 10, 179, DateTimeKind.Utc).AddTicks(265), "AQAAAAIAAYagAAAAEJbsDloHaRaw95dfqjFn6Csu4NUyCBOs7wugeimgePg7gun/g4WYeEkiW76Xi/XGnA==", "42140866-3a80-4325-a931-a567d9ee755d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ab6fe52-de46-4d32-966b-f5b22149a20e", new DateTime(2025, 12, 25, 22, 28, 10, 266, DateTimeKind.Utc).AddTicks(4809), "AQAAAAIAAYagAAAAENbYe1k7zYpdqbb1zQphY7OFQvErUdkB4/H4Uk88ML3E24b4wuqiR/OXVSr9Z+wgzg==", "c9898b46-9f26-46b4-b35d-a1c29ce2b479" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(486), 44.436140000000002, 26.098929999999999 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(629), 44.436140000000002, 26.098929999999999 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(631), 44.43533, 26.100090000000002 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(638), 44.436720000000001, 26.10134 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(643), 44.435560000000002, 26.097149999999999 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(658), 44.437550000000002, 26.10173 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(660), 44.437629999999999, 26.101680000000002 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(670), 44.435560000000002, 26.097149999999999 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d099e10d-c71f-4586-bd76-56258d578ffc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e8a26076-d3bd-4dca-b9c5-a3780082c402");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "49a53a81-29de-4086-8a71-d415f7531b7f");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 131, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 131, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 131, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 22, 20, 131, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f41a39f3-9cb9-4f63-aaf5-2fa878798ed4", new DateTime(2025, 12, 25, 22, 22, 19, 639, DateTimeKind.Utc).AddTicks(9252), "AQAAAAIAAYagAAAAELWHZHW3XFyHDSrYwLCjHPRbXZhCb08390NS7HlvipCCAv+H9SVaulosBcUUCt0alg==", "74de6166-580a-4b67-868b-e83985e2a23e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd7799d8-fe47-4e5d-a793-a4695f94dd39", new DateTime(2025, 12, 25, 22, 22, 19, 733, DateTimeKind.Utc).AddTicks(4149), "AQAAAAIAAYagAAAAEAp8u+1BnRdWova2GXhxes7+n9d/VVKBz9Xc0031igln6OuqJojlOIbJykRnUD4BtA==", "9fbd9043-3dfa-44e2-9559-a852d88cd069" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf5552a8-2411-4070-a185-61723b943f1d", new DateTime(2025, 12, 25, 22, 22, 19, 817, DateTimeKind.Utc).AddTicks(7702), "AQAAAAIAAYagAAAAEKtzukRuyTDpTQQWBo6Pt+CNQdFjMReLqbxNj68PkmH5u9gy0Dkp0et22U3XHQOmIA==", "a54ca3f4-43eb-4bfa-9741-886e930642a9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5838b35c-2101-4e10-a721-eb76559711fc", new DateTime(2025, 12, 25, 22, 22, 19, 907, DateTimeKind.Utc).AddTicks(7418), "AQAAAAIAAYagAAAAEN4UfJEpbPw8RUkwKoc/hcAsp6i6qNVTy1B38xPG8vJBlC6HChCTW7Vj+4E9eF1Q6w==", "905100ce-04c1-40ad-b1f3-e8fdfc20a2d5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f553dc13-1e58-4760-bcbe-a02cd46bbb06", new DateTime(2025, 12, 25, 22, 22, 19, 983, DateTimeKind.Utc).AddTicks(9172), "AQAAAAIAAYagAAAAEKs9S3QPLsQnj69p1HsfQTf8Z9uEN4RpUFlJz4lwoP9CtrpcONs2K7VRguITDUZW8A==", "f529433c-e64f-4a80-b3bf-c9b8affdb0ff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "996df4db-dcb3-4fc4-917b-99bb229282fa", new DateTime(2025, 12, 25, 22, 22, 20, 52, DateTimeKind.Utc).AddTicks(1623), "AQAAAAIAAYagAAAAEGYk1fSLQnEuKXv/Hr8kGWObYhAbGZ9/nco5uTQPyZ+oz5Nm2i0+Ahgm21l6Tr7Acw==", "df46d04c-b9e9-4286-b8cb-5b8ef35feba1" });
        }
    }
}
