using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSchedules30Jan2026 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoomReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestedByUserId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ProcessedByAdminId = table.Column<int>(type: "int", nullable: true),
                    RejectionReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProcessedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomReservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomReservations_Users_ProcessedByAdminId",
                        column: x => x.ProcessedByAdminId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RoomReservations_Users_RequestedByUserId",
                        column: x => x.RequestedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 7, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 7, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 7, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 7, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 7, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2b62a12f-17f9-488f-ab35-3fc5465dc59f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "293eb60d-718d-40a9-838f-850ea50a5ba6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "4e7387fc-3275-4dd3-b415-091d0b4574ee");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 40, 22, 0, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3083), new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3193), new DateTime(2026, 1, 30, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 30, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3208), new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3211), new DateTime(2026, 1, 30, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "CreatedAt", "CreatedByProfessorId", "Description", "EndTime", "IsActive", "RecurrenceEndDate", "RecurrencePattern", "RoomId", "StartTime", "Title" },
                values: new object[,]
                {
                    { 5, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3243), 14, "Principii de administrație publică", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 1, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Administrație Publică" },
                    { 6, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3246), 15, "Analiza politicilor publice", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 2, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Politici Publice" },
                    { 7, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3248), 14, "Fundamente de management public", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 1, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Management Public" },
                    { 8, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3251), 15, "Aspecte practice", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 2, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Drept Administrativ" },
                    { 9, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3254), 14, "Structura celulei eucariote", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 11, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Biologie Celulară" },
                    { 10, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3256), 15, "Tehnici de cultivare", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 12, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Laborator Microbiologie" },
                    { 11, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3259), 14, "Genetica moleculară", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 11, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Genetică" },
                    { 12, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3261), 15, "Ecosisteme terestre", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 12, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Ecologie" },
                    { 13, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3276), 14, "Reacții de sinteză", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 21, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Chimie Organică" },
                    { 14, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3279), 15, "Metode spectroscopice", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 22, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Laborator Chimie Analitică" },
                    { 15, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3282), 14, "Metabolismul celular", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 21, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Biochimie" },
                    { 16, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3284), 15, "Termodinamică", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 22, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Chimie Fizică" },
                    { 17, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3287), 14, "Infracțiuni și pedepse", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 31, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Drept Penal" },
                    { 18, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3289), 15, "Constituția României", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 32, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Drept Constituțional" },
                    { 19, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3292), 14, "Instituții UE", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 31, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Drept European" },
                    { 20, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3294), 15, "Societăți comerciale", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 32, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Drept Comercial" },
                    { 21, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3297), 14, "Filosofia antică greacă", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 41, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Istoria Filosofiei" },
                    { 22, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3314), 15, "Teorii etice contemporane", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 42, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Etică" },
                    { 23, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3328), 14, "Logica formală", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 41, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Logică" },
                    { 24, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3330), 15, "Teoria cunoașterii", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 42, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Epistemologie" },
                    { 25, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3333), 14, "Principii fundamentale", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 51, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Mecanică Cuantică" },
                    { 26, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3335), 15, "Experimente de optică", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 52, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Laborator Optică" },
                    { 27, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3338), 14, "Legile termodinamicii", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 51, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Termodinamică" },
                    { 28, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3340), 15, "Câmpuri electromagnetice", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 52, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Electrodinamică" },
                    { 29, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3343), 14, "Relieful terestru", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 61, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Geografie Fizică" },
                    { 30, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3345), 15, "Tehnici cartografice", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 62, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Laborator Cartografie" },
                    { 31, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3348), 14, "Sistemul climatic global", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 61, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Climatologie" },
                    { 32, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3351), 15, "Sisteme informaționale geografice", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 62, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar GIS" },
                    { 33, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3365), 14, "Clasificarea mineralelor", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 71, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Mineralogie" },
                    { 34, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3368), 15, "Analiza rocilor", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 72, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Laborator Petrografie" },
                    { 35, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3370), 14, "Metode geofizice", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 71, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Geofizică" },
                    { 36, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3373), 15, "Fosile și evoluție", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 72, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Paleontologie" },
                    { 37, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3375), 14, "Civilizații antice", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 81, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Istorie Antică" },
                    { 38, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3378), 15, "Europa medievală", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 82, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Istorie Medievală" },
                    { 39, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3380), 14, "Revoluții și națiuni", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 81, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Istorie Modernă" },
                    { 40, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3383), 15, "Secolul XX", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 82, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Istorie Contemporană" },
                    { 41, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3385), 14, "Modele de comunicare", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 91, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Teoria Comunicării" },
                    { 42, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3388), 15, "Tehnici multimedia", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 92, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Laborator Jurnalism Digital" },
                    { 43, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3401), 14, "Strategii de PR", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 91, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Relații Publice" },
                    { 44, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3404), 15, "Campanii publicitare", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 92, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Publicitate" },
                    { 45, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3406), 14, "Gramatică avansată", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 101, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Limba Engleză" },
                    { 46, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3409), 15, "Conversație", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 102, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Limba Franceză" },
                    { 47, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3411), 14, "Literatură germană", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 101, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Limba Germană" },
                    { 48, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3414), 15, "Cultură hispanică", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 102, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Limba Spaniolă" },
                    { 49, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3416), 14, "Clasici români", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 111, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Literatură Română" },
                    { 50, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3419), 15, "Analiză lingvistică", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 112, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Lingvistică" },
                    { 51, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3422), 14, "Curente literare", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 111, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Literatură Universală" },
                    { 52, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3424), 15, "Analiză text", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 112, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Teoria Literaturii" },
                    { 53, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3437), 14, "Design patterns", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 121, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Programare Orientată Obiect" },
                    { 54, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3439), 15, "Protocoale de rețea", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 122, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Laborator Rețele de Calculatoare" },
                    { 55, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3442), 14, "Machine Learning", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 121, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Inteligență Artificială" },
                    { 56, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3445), 15, "SQL și NoSQL", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 122, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Baze de Date Avansate" },
                    { 57, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3447), 14, "Procese cognitive", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 131, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Psihologie Generală" },
                    { 58, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3450), 15, "Dinamica grupurilor", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 132, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Psihologie Socială" },
                    { 59, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3452), 14, "Teorii educaționale", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 131, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Pedagogie" },
                    { 60, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3455), 15, "Etape de dezvoltare", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 132, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Psihologia Dezvoltării" },
                    { 61, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3457), 14, "Teorii sociologice", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 141, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Sociologie Generală" },
                    { 62, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3460), 15, "Intervenție socială", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 142, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Asistență Socială" },
                    { 63, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3473), 14, "Metode de cercetare", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 141, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Metodologia Cercetării" },
                    { 64, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3476), 15, "Sistemul de protecție", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 142, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Politici Sociale" },
                    { 65, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3478), 14, "Teorii politice", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 151, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Științe Politice" },
                    { 66, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3481), 15, "Diplomație", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 152, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Relații Internaționale" },
                    { 67, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3483), 14, "Integrare europeană", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 151, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "Curs Studii Europene" },
                    { 68, new DateTime(2026, 1, 30, 21, 40, 22, 3, DateTimeKind.Utc).AddTicks(3486), 15, "Sisteme politice", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, 152, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Seminar Politici Comparate" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6063303e-95c6-463b-9bd3-a946f524e0c4", new DateTime(2026, 1, 30, 21, 40, 21, 593, DateTimeKind.Utc).AddTicks(9521), "AQAAAAIAAYagAAAAEPx04mDqLdKXbrUGn9cPn0WCbj8N9Z1Hr+OwoZypEqrydlsWBu+LKiRAuQBNlPmWrQ==", "0184ee17-d0d4-47e6-a753-f0e675a5db88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ca7f9b0-abe7-4916-a3b1-aa170aac3653", new DateTime(2026, 1, 30, 21, 40, 21, 653, DateTimeKind.Utc).AddTicks(2910), "AQAAAAIAAYagAAAAEF9RkqXGnUMZCXjgw7t2D4Eh3o/VZeIBDSS6X+aWJR7KV4GD0bbcEuisybnIRcA4eA==", "04fd7ae1-0d03-4e67-9782-6e81b79e4d6e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "StudentId" },
                values: new object[] { "a0ca2b9f-57f1-4835-8146-662c6fa68763", new DateTime(2026, 1, 30, 21, 40, 21, 713, DateTimeKind.Utc).AddTicks(7295), "AQAAAAIAAYagAAAAEEqEd4ORsVDhVKn2zOAcjSM8Vmzw+XtgxagmzZK7Zu6kC3aBYgE9EaoyJ7YqWMoDmQ==", "f3219462-ab39-4958-bb9c-485e0ee49441", "STD2024001" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "StudentId" },
                values: new object[] { "29ded956-aab2-44d6-be5d-5a9c4f1b8ac9", new DateTime(2026, 1, 30, 21, 40, 21, 775, DateTimeKind.Utc).AddTicks(1488), "AQAAAAIAAYagAAAAEF4+hp9FJhvmTfNaSdiotjHBVd08/FD48hUD2iLEJYrbpQDHKitB+1h5cT26T+zFQQ==", "8cc27bd6-b5f7-41dc-bf35-c68f0555357c", "STD2024002" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9992af79-8962-4394-8e81-c926e662f4d9", new DateTime(2026, 1, 30, 21, 40, 21, 839, DateTimeKind.Utc).AddTicks(6208), "AQAAAAIAAYagAAAAEOyL2OLyxu8DBPOxvsHYO7RQ9Jm072bilO72VL1cCbkJNIcAvgv4V1rqx1uaPTo3WA==", "6cb89799-fff0-4259-b171-41476afb9dd1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d09138e-7b93-4b9c-ba97-720c34f959ef", new DateTime(2026, 1, 30, 21, 40, 21, 909, DateTimeKind.Utc).AddTicks(1309), "AQAAAAIAAYagAAAAEM+L9Btxbk8THRkPNsdn+03C0cuerSi+hwdenrVsi9O0Jjjr32IDI20EuZFcLQ/cUg==", "04f227c2-ab5a-473d-94f5-5faa41a286a4" });

            migrationBuilder.CreateIndex(
                name: "IX_RoomReservations_ProcessedByAdminId",
                table: "RoomReservations",
                column: "ProcessedByAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomReservations_RequestedByUserId",
                table: "RoomReservations",
                column: "RequestedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomReservations_RoomId",
                table: "RoomReservations",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomReservations");

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 526, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 526, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 526, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 526, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 526, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ad29d004-80d0-4a6b-94ab-7cc41b7f3f71");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f2032931-a155-486c-b8c9-edb12af82d51");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a8130437-27a4-420c-a3c7-39510f13bcc4");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 14, 54, 3, 520, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 27, 14, 54, 3, 523, DateTimeKind.Utc).AddTicks(4344), new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 27, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 27, 14, 54, 3, 523, DateTimeKind.Utc).AddTicks(4477), new DateTime(2026, 1, 27, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 27, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 27, 14, 54, 3, 523, DateTimeKind.Utc).AddTicks(4481), new DateTime(2026, 1, 27, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 27, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 1, 27, 14, 54, 3, 523, DateTimeKind.Utc).AddTicks(4484), new DateTime(2026, 1, 27, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d042f4c-1bce-4e3c-a00e-f93a786a8bad", new DateTime(2026, 1, 27, 14, 54, 3, 10, DateTimeKind.Utc).AddTicks(4389), "AQAAAAIAAYagAAAAELKAktWgQRQNl/qK5kifmSA3wpQAh8ok3S4efHs4YxFAGE1N4IcPYs7nQYmFY2tOlQ==", "b922809c-d79e-443d-87d4-424353828623" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ac6f81b-e51a-41cb-8c89-3377ede79540", new DateTime(2026, 1, 27, 14, 54, 3, 90, DateTimeKind.Utc).AddTicks(8520), "AQAAAAIAAYagAAAAEJqKlL+bLpkblsy4EqG9cSKPrElqPRDbp0DPZa+c1htL5s6ZGA/+tsf8ZhcHMpzQ7Q==", "d4c019f6-8370-47d5-800f-3274952629ed" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "StudentId" },
                values: new object[] { "c5af3ef0-248c-4949-9f86-c230ac3e0436", new DateTime(2026, 1, 27, 14, 54, 3, 175, DateTimeKind.Utc).AddTicks(4228), "AQAAAAIAAYagAAAAEPsFkpYdBKArRjVtBKowKZ3KG0Wa76YHDUrY45kqc0wKmM2qJ3MGKUf+2wGoegOQEw==", "fde3d76f-6b54-4d87-ab38-a7ca799c98f2", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "StudentId" },
                values: new object[] { "d21328b2-885c-44d4-a222-3ce11fadecf2", new DateTime(2026, 1, 27, 14, 54, 3, 250, DateTimeKind.Utc).AddTicks(7575), "AQAAAAIAAYagAAAAENULJXbyVrGZfWhOJLZ7/bFJfzWBKnRH4tyzoXSO4HV85nucA+QhSaKJT0pIsnK3EA==", "e4c7cd2d-2a92-4a59-b40f-6ca55fc7cb73", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14a80b3a-dcdb-44cb-96e4-3aa7b35084c3", new DateTime(2026, 1, 27, 14, 54, 3, 346, DateTimeKind.Utc).AddTicks(4876), "AQAAAAIAAYagAAAAECf7agbq9R2choMutxjIUg+SMs5bEsQoomqmvX2PCMtKTIsK60PIXB0spDI3JrrfGg==", "13ebba53-e927-4267-ac6f-c30fb045f434" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8a115c0-0511-41c1-8dfc-9c22d76c4abe", new DateTime(2026, 1, 27, 14, 54, 3, 416, DateTimeKind.Utc).AddTicks(3442), "AQAAAAIAAYagAAAAENQK1CuG13JfxyAG7vzlLbef1FI4jTiJVezDUpl8eLBaeIpKlyXjCnOisEnAYTyrtA==", "44028e20-4a5a-49c9-ab04-82d0d0d9df42" });
        }
    }
}
