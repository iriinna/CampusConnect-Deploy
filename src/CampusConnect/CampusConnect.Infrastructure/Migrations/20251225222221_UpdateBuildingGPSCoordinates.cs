using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBuildingGPSCoordinates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(626), 44.435299999999998, 26.06326 });

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
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(634), 44.434710000000003, 26.04824 });

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
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 22, 20, 128, DateTimeKind.Utc).AddTicks(641), 44.45167, 26.07901 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(267), 44.436129999999999, 26.09892 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(407), 44.435310000000001, 26.062919999999998 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(410), 44.436149999999998, 26.098949999999999 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(412), 44.434420000000003, 26.099509999999999 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(415), 44.434910000000002, 26.048210000000001 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(419), 44.43665, 26.101220000000001 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(421), 44.451230000000002, 26.07892 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(423), 44.435479999999998, 26.09721 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(440), 44.437820000000002, 26.101559999999999 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(442), 44.437849999999997, 26.101510000000001 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(445), 44.435510000000001, 26.097180000000002 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4fce707e-d736-4c56-a47e-a48d631c5ae7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ecf76ae0-2d2d-4c77-9e6d-7c29327c518e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "fd9b0fdf-4c8e-49d1-b6b0-5ce1e511eb5b");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 777, DateTimeKind.Utc).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 779, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 779, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 779, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 22, 15, 7, 779, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90122390-8c9c-48e3-9820-ad9100e74d29", new DateTime(2025, 12, 25, 22, 15, 7, 397, DateTimeKind.Utc).AddTicks(9127), "AQAAAAIAAYagAAAAEDXlgjkDbQbXborz4ER6QTYielvG6aZxkM7NUuyccHIVced/5wtgGIIpEgDGdXTYPw==", "e81d5c5e-9e8d-4100-a928-40591786e00f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "606fa47f-4845-45a8-84bb-225274241f23", new DateTime(2025, 12, 25, 22, 15, 7, 466, DateTimeKind.Utc).AddTicks(9587), "AQAAAAIAAYagAAAAEIIHHQKv+2UL2dmPjiRTm5ey2rUdJgvpOL06qvYRj25JSydoloVLKeziMYaxtWAvgg==", "870aa717-b9af-4a8f-8b6d-3a2e3b773438" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f1594b3-ca4c-4f44-89cd-5edbc02913d9", new DateTime(2025, 12, 25, 22, 15, 7, 527, DateTimeKind.Utc).AddTicks(2379), "AQAAAAIAAYagAAAAED7JMtOvDnTzTp/onp10Q7AwVt5K/9DhoXeTjBjT+69AjdwIaWUgl/E+HKiubY1HqQ==", "2691f15c-08f9-4360-a14f-5ef50ea3015a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bc4792d-8b6e-42a7-b1b5-537141364f46", new DateTime(2025, 12, 25, 22, 15, 7, 585, DateTimeKind.Utc).AddTicks(9943), "AQAAAAIAAYagAAAAEKI7RF4S8Fd/h4MPIYGJ+PzjhuhYLnhYBrQZGqWRobjIt6uPHOH2kf5UzF73ucMt2Q==", "7a070187-c59d-4e18-9034-805709ca52a0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e8dcdd7-0cfc-4723-9b58-e1530ebee3f8", new DateTime(2025, 12, 25, 22, 15, 7, 642, DateTimeKind.Utc).AddTicks(6488), "AQAAAAIAAYagAAAAEIGKd9EP137msvto/D/YYT1TWZa6EJpKUjqP8UACPMW26kbaZ41ksFqB9vPsEtnveg==", "93cf2581-96f1-4c10-9fee-af3eb8c21caa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49d30bac-4be3-4968-8797-a3d364ca3302", new DateTime(2025, 12, 25, 22, 15, 7, 701, DateTimeKind.Utc).AddTicks(823), "AQAAAAIAAYagAAAAEN3wp1dq4E1o6HRIPJAnh2melkjhSrV1WPNFrwoMKamzrPC1n6D/075cWtGSQo1u/Q==", "a09c7fa1-030b-47fd-994d-3be9be7ec5da" });
        }
    }
}
