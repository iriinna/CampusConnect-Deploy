using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
    public partial class UpdateFmiAmphFloors2 : Migration
========
    public partial class AddSubjectsAndGradesV2 : Migration
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 173, DateTimeKind.Utc).AddTicks(6058));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(929));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 173, DateTimeKind.Utc).AddTicks(6298));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(1175));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 173, DateTimeKind.Utc).AddTicks(6300));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(1177));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 173, DateTimeKind.Utc).AddTicks(6302));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(1179));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 173, DateTimeKind.Utc).AddTicks(6304));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(1181));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7683));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3116));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7814));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3246));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7817));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3249));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7819));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3251));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7821));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3253));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7840));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3255));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7842));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3257));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7844));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3259));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7846));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3261));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7848));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3262));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7850));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3264));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7852));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3279));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7854));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3282));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7856));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3294));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7858));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3296));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(7873));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3298));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: "7a95b8f5-d752-4074-abec-3239f7c19c2a");
========
                value: "ef5769f6-3997-4f79-bf47-d5e15806bce9");
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: "5b954b3c-27b4-4fe5-a4df-51d9c9dbcca7");
========
                value: "6488f54f-d0d4-4c61-9ea7-253788f6bcd0");
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: "6f27586a-9bc8-4de5-be16-56bc2ee8a0cd");
========
                value: "7b494646-e406-4f49-a045-f7f4832dccf3");
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9431));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(4915));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9529));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5012));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9532));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5015));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9534));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5017));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9536));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5019));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9539));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5021));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9541));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5023));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9543));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5025));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9641));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5134));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9644));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5137));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9646));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5151));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9648));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5153));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9650));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5155));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9664));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5157));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9666));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5159));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9669));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5161));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9671));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5163));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9673));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5166));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9675));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5167));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9677));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5170));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9679));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5171));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9681));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5173));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9683));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5175));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9685));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5177));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9687));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5190));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9689));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5192));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9691));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5194));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9702));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5196));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9705));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5198));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9707));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5200));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9709));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5202));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9711));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5204));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9713));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5206));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9715));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5208));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9717));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5210));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9719));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5212));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9721));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5214));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9723));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5216));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9725));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5226));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9727));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5228));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9729));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5230));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9740));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5232));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9751));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5234));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9753));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5236));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9755));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5238));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9757));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5240));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9759));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5242));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9761));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5244));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9763));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5246));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9765));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5248));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9767));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5250));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9769));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5252));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9771));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5253));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9773));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5264));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9775));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5266));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9777));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5269));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9789));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5271));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9792));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5273));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9794));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5275));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9796));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5277));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9798));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5279));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9800));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5281));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9802));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5283));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9804));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5284));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9806));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5286));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9808));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5288));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9810));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5290));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9812));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5301));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9814));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5303));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9816));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5313));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9827));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5315));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9829));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5317));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9831));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5318));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9833));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5320));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9835));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5322));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9837));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5324));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9839));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5326));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9841));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5328));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9843));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5330));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9845));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5332));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9847));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5334));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9849));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5347));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9851));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5349));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9853));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5350));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9855));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5352));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9867));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5354));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9869));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5356));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9871));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5358));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9874));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5360));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9876));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5362));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9878));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5364));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9880));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5366));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9882));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5368));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9884));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5370));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9886));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5372));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9888));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5374));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9890));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5385));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9892));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5387));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9894));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5389));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9906));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5391));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9908));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5393));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9910));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5395));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9912));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5397));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9914));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5398));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9916));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5400));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9918));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5402));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9920));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5404));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9922));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5406));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9924));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5408));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9926));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5410));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9933));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5422));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9935));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5424));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9937));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5426));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9939));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5428));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9951));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5430));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9953));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5432));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9955));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5434));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9957));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5436));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9959));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5438));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9961));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5440));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9963));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5442));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                columns: new[] { "CreatedAt", "Floor" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9965), "Etaj 3" });
========
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5444));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                columns: new[] { "CreatedAt", "Floor" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9968), "Etaj 1" });
========
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5446));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                columns: new[] { "CreatedAt", "Floor" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9970), "Etaj 2" });
========
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5448));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9972));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5450));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9974));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5462));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9976));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5464));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9978));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5466));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9989));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5468));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9992));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5470));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 168, DateTimeKind.Utc).AddTicks(9999));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5472));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(1));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5474));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(3));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5476));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(5));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5478));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(7));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5480));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(9));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5482));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(11));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5484));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(13));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5491));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(16));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5493));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(28));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5503));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(30));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5506));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(32));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5507));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(34));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5509));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(36));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5511));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(38));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5513));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(40));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5515));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(42));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5517));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(44));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5519));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(46));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5521));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(48));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5523));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(50));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5525));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(52));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5527));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(54));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5529));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(56));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5531));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(68));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5543));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(70));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5545));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(72));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5547));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(73));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5549));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 169, DateTimeKind.Utc).AddTicks(76));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5551));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
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
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5553));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 171, DateTimeKind.Utc).AddTicks(1891));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(3901));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 171, DateTimeKind.Utc).AddTicks(1998));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(3998));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 171, DateTimeKind.Utc).AddTicks(2002));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(4001));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 41, 171, DateTimeKind.Utc).AddTicks(2004));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(4004));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                values: new object[] { "08f876e3-00f4-4f58-9294-fdb58ea792df", new DateTime(2026, 1, 6, 15, 39, 40, 812, DateTimeKind.Utc).AddTicks(4420), "AQAAAAIAAYagAAAAEH9CZgTCs8CZYBgha2uJiIIbvP0fQNAfvf0T1jFkNJdD7H/43bIJ/WSe7Y2b452HWg==", "deaceb62-5c2a-4fba-8b5f-20ab6ae974ea" });
========
                values: new object[] { "d92240d1-fdba-40b6-ae27-ab26eb1dc653", new DateTime(2026, 1, 17, 10, 54, 24, 973, DateTimeKind.Utc).AddTicks(9967), "AQAAAAIAAYagAAAAECFKuErui1SND9Qt8q9/7G2AU4eBf1XYF4MnaZmdNyCivcqoNNEd96MpbvSfzbs7vg==", "68c6e342-a48e-44d2-b0fc-3da2881364bc" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                values: new object[] { "99a72f73-acd9-4275-8da1-ff40e50a934e", new DateTime(2026, 1, 6, 15, 39, 40, 874, DateTimeKind.Utc).AddTicks(5828), "AQAAAAIAAYagAAAAEN70oyfDnJeyBPmQjppJycDZjI95/MjjNnY3suxOEKZAbmmnG6UaXoApKaDxVBm1Xg==", "14e15876-ca80-47d4-a012-428ca2c19afb" });
========
                values: new object[] { "1c1b53e2-fde8-45dc-9283-4d41c821c22f", new DateTime(2026, 1, 17, 10, 54, 25, 21, DateTimeKind.Utc).AddTicks(9274), "AQAAAAIAAYagAAAAEOhud1GLUEVTP4gT9WZi6G99/hYtCEhlGAoNgHBcg+tVgf24wgc2LpPzigQBk/8AUQ==", "65fa8e0b-3b44-4fb3-8952-d30e0f34c254" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                values: new object[] { "0d1e9430-f798-4600-8732-31392e324a5f", new DateTime(2026, 1, 6, 15, 39, 40, 929, DateTimeKind.Utc).AddTicks(4035), "AQAAAAIAAYagAAAAEAH3wx7t9TLUYVJn/wypWx6dULeUD9XEP3S/BDjbOotsn8gJYLuBUUgdKFeR/I7eZQ==", "545dea90-327a-46cd-b83b-d7130f8a114c" });
========
                values: new object[] { "457f2021-a5aa-410b-a7b7-ca54cfa998fe", new DateTime(2026, 1, 17, 10, 54, 25, 69, DateTimeKind.Utc).AddTicks(9425), "AQAAAAIAAYagAAAAEENTdxugO1+FWSydemzKSWr/aAQNcYvu1DQuSar8N54qwx4uHyGPqyiZRQl3WFs+wQ==", "3490fd96-7614-496e-87ef-b4ab19bca848" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                values: new object[] { "0c455582-0396-4796-b325-f50ad17fcf63", new DateTime(2026, 1, 6, 15, 39, 40, 984, DateTimeKind.Utc).AddTicks(555), "AQAAAAIAAYagAAAAEKl96kVo9qgU9q7TUSIBvr142EzplaCePz7OmhHU8FOL00o65BVySpOatalR+E+m+w==", "c6c9ae5f-8a93-4346-9f61-0c22e1a1c934" });
========
                values: new object[] { "c627f547-007f-4eec-b60f-e8f57e29f1ba", new DateTime(2026, 1, 17, 10, 54, 25, 118, DateTimeKind.Utc).AddTicks(3257), "AQAAAAIAAYagAAAAEIFeQR37mc4Dtr7YrQlJgbUDlhPwPdi/La14SqR/YG99WNvLAok8DSmJC6LXzfGklQ==", "ded6cc61-6c1d-4735-8637-d82eb498d215" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                values: new object[] { "217cd969-06f3-4a51-a714-cf067d7dc5d6", new DateTime(2026, 1, 6, 15, 39, 41, 38, DateTimeKind.Utc).AddTicks(9332), "AQAAAAIAAYagAAAAEN/VclRBFlsudE/7KsA6TlyddXhtSChn3f7fNcaf4/L9AOWK2qWTY62v9jLGHAwtlQ==", "ba71a8fc-b0a7-4617-bd31-471d5899cbbe" });
========
                values: new object[] { "21117db5-5c34-48cc-b03d-ee1f679abfc0", new DateTime(2026, 1, 17, 10, 54, 25, 170, DateTimeKind.Utc).AddTicks(8927), "AQAAAAIAAYagAAAAEB6Rh8cz7RBzyw5AuYZX1CT5QSwvodLfrWeJaSS+rFcCoaa6+/olDH75sO3oNudu7Q==", "4c852f8e-d34d-4448-ac4d-28906b8f161a" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                values: new object[] { "ae5ffb14-ad73-4f10-b359-4c5c576df813", new DateTime(2026, 1, 6, 15, 39, 41, 93, DateTimeKind.Utc).AddTicks(5691), "AQAAAAIAAYagAAAAEM0jh6YUeHVOurG+gA8hknGdfvqiAmuJ4faLa0ZNNQEd+9TFGr7Jk33u/wTbgCQrng==", "19202a78-1709-4ee3-8387-91cde48f2952" });
========
                values: new object[] { "9f1651bd-2846-4dd5-8ee7-f46c7f1d4bb6", new DateTime(2026, 1, 17, 10, 54, 25, 222, DateTimeKind.Utc).AddTicks(7494), "AQAAAAIAAYagAAAAEA32Huc5pb7nKufGeB8JGnvpd9EsVs6FHQvBxKx1rZD4UNarWlljglVUZO575TvILg==", "91148053-ab2f-44d5-b81c-d9af8f06ac78" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs
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
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(1589));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 631, DateTimeKind.Utc).AddTicks(9474));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(2056));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 631, DateTimeKind.Utc).AddTicks(9646));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(2059));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 631, DateTimeKind.Utc).AddTicks(9647));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(2062));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 631, DateTimeKind.Utc).AddTicks(9649));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(2065));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 631, DateTimeKind.Utc).AddTicks(9650));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3278));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8260));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3452));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8363));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3455));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8365));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3458));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8366));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3460));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8368));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3463));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8370));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3465));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8371));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3468));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8373));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3471));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8374));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3473));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8376));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3476));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8377));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3486));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8388));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3489));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8390));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3491));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8391));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3507));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8427));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3510));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(8428));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: "4307f0b5-24b9-41a0-8c62-96f0eec0fe79");
========
                value: "407559a0-03e0-4845-a81e-c6b2a858e35a");
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: "bd50fa3e-bd82-4c09-b0f8-2dc32ec57ee0");
========
                value: "5237ef4c-c33c-48e8-96a4-edcab72a770d");
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: "15719122-33ea-4628-9bb5-ca3d014dc4b9");
========
                value: "1e7e0bd4-c047-4749-bd73-88bae4402110");
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5781));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 627, DateTimeKind.Utc).AddTicks(9947));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5910));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(18));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5913));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(20));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5916));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(22));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5919));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(23));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5921));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(25));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5924));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(26));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5926));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(27));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6053));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(102));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6057));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(105));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6060));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(117));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6062));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(119));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6083));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(121));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6086));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(122));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6088));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(124));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6091));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(125));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6094));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(127));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6096));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(128));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6099));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(130));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6102));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(131));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6104));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(133));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6107));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(134));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6109));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(135));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6136));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(137));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6139));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(146));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6142));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(148));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6157));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(149));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6160));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(151));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6162));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(152));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6165));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(154));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6168));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(155));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6170));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(156));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6173));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(158));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6175));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(159));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6178));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(160));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6181));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(162));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6184));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(163));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6186));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(165));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6189));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(175));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6191));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(176));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6193));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(177));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6208));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(179));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6211));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(180));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6213));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(182));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6216));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(183));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6218));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(185));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6221));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(186));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6224));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(187));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6226));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(189));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6229));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(190));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6231));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(192));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6234));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(200));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6236));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(201));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6238));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(212));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6241));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(213));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6255));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(215));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6258));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(216));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6261));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(218));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6263));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(219));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6266));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(221));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6269));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(222));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6271));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(224));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6274));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(225));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6276));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(226));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6279));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(228));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6281));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(229));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6284));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(231));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6286));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(239));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6289));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(241));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6292));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(242));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6306));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(244));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6309));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(245));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6311));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(247));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6314));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(248));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6316));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(249));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6319));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(251));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6322));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(252));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6324));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(254));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6327));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(255));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6330));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(257));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6332));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(258));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6334));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(267));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6337));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(269));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6339));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(271));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6352));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(272));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6355));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(274));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6357));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(275));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6360));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(276));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6363));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(278));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6365));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(279));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6368));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(281));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6376));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(282));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6378));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(284));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6381));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(285));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6383));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(286));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6386));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(288));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6389));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(297));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6391));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(298));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6405));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(300));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6408));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(301));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6410));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(303));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6413));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(304));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6415));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(306));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6418));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(307));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6420));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(308));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6423));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(310));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6426));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(311));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6428));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(313));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6431));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(314));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6434));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(316));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6436));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(325));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6439));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(327));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6441));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(328));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6455));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(330));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6457));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(331));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6460));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(332));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6462));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(334));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6465));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(335));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6467));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(337));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6470));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(345));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6473));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(347));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                columns: new[] { "CreatedAt", "Floor" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6475), "Parter" });
========
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(348));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                columns: new[] { "CreatedAt", "Floor" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6478), "Parter" });
========
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(350));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                columns: new[] { "CreatedAt", "Floor" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6481), "Parter" });
========
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(351));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6483));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(353));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6486));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(362));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6489));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(364));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6504));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(365));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6507));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(367));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6509));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(368));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6512));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(369));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6514));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(371));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6517));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(372));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6519));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(374));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6522));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(375));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6524));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(376));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6527));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(378));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6530));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(379));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6532));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(381));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6535));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(390));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6537));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(392));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6552));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(393));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6554));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(395));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6557));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(396));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6559));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(397));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6562));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(399));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6564));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(400));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6567));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(402));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6569));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(403));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6572));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(405));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6574));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(406));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6577));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(408));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6579));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(409));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6582));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(410));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6584));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(419));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6587));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(421));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6601));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(422));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6604));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(423));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6606));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(425));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6615));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 628, DateTimeKind.Utc).AddTicks(427));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 129, DateTimeKind.Utc).AddTicks(6560));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 629, DateTimeKind.Utc).AddTicks(7651));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 129, DateTimeKind.Utc).AddTicks(6695));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 629, DateTimeKind.Utc).AddTicks(7725));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 129, DateTimeKind.Utc).AddTicks(6698));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 629, DateTimeKind.Utc).AddTicks(7727));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 129, DateTimeKind.Utc).AddTicks(6701));
========
                value: new DateTime(2026, 1, 17, 10, 53, 58, 629, DateTimeKind.Utc).AddTicks(7729));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                values: new object[] { "d4a176ad-f137-4718-a091-c3ae4ca2d95e", new DateTime(2026, 1, 6, 15, 39, 2, 671, DateTimeKind.Utc).AddTicks(7309), "AQAAAAIAAYagAAAAEK+4KrWROGXVMqNBI9jJGNeDta+82C8WKLGhvmI6moU31ZtUsa5y37u20o7pVLfolg==", "ee62bbe1-a7e1-4d21-abb3-7b343f2a2f87" });
========
                values: new object[] { "8cbaf3fd-b9ee-48fb-8b8a-a58a026ab163", new DateTime(2026, 1, 17, 10, 53, 58, 342, DateTimeKind.Utc).AddTicks(3763), "AQAAAAIAAYagAAAAEGh80tZMGckTFYpvuqWDZa4U+GJwEgJugUX5ZhS6SV78k1Ir1lUKSo/ECodCDRi0Bg==", "f2d188a0-cce7-4e3b-a704-1a6dfe185de4" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                values: new object[] { "956aae38-c3c5-45cb-88b5-f1a0df2c7644", new DateTime(2026, 1, 6, 15, 39, 2, 743, DateTimeKind.Utc).AddTicks(4072), "AQAAAAIAAYagAAAAEIVttbYVg8wcpeGvCwh+xLNs9EseguzmgTmCJPic06zui+rE96IqMVfpxdSHvWhfwg==", "04f12232-3911-49c3-9d93-d3e71671dc23" });
========
                values: new object[] { "532e43c9-d14f-4400-971e-14de16b6c44e", new DateTime(2026, 1, 17, 10, 53, 58, 387, DateTimeKind.Utc).AddTicks(3000), "AQAAAAIAAYagAAAAEMBKGh0tw8jAv4bhq9Fees/bN8npHmh7IAKHpowfDpNzxeX1ZecYq0oPyUsYH3IQhA==", "39f64d88-4b98-49e4-8268-0012d9dd94b4" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                values: new object[] { "40509274-ca42-452e-baec-67cea2f28c04", new DateTime(2026, 1, 6, 15, 39, 2, 812, DateTimeKind.Utc).AddTicks(7557), "AQAAAAIAAYagAAAAELsBi6ccY7QVEkfARhDZbfI4d1nWmkCgeJdDp6UjPZY98zlA202XcB65U8MXAyEgfg==", "93cc3c84-03ea-4930-8a1e-3e327016ad4d" });
========
                values: new object[] { "6e23505a-a8e8-460c-b5b3-71a13bd9d99f", new DateTime(2026, 1, 17, 10, 53, 58, 430, DateTimeKind.Utc).AddTicks(1262), "AQAAAAIAAYagAAAAEDRAzxbbtF5ub1vOCMnGVsJreg7bbVOCWCL/RdSjlg9XlDVBxziOaMKF3l6u4DKjKg==", "b856072b-2d3f-4cf0-b399-98c519b46c10" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                values: new object[] { "e792b52b-9a99-496f-a511-9dcbf4a96514", new DateTime(2026, 1, 6, 15, 39, 2, 885, DateTimeKind.Utc).AddTicks(7621), "AQAAAAIAAYagAAAAEEARrVqDorKU32//LHNSZ8DJBUHHmLcCxqsE64RyCq0GXgOq6QLTMaRVOtDzTVWTcg==", "d82e52f7-26c5-4633-8215-f77565efd6f7" });
========
                values: new object[] { "c86ada3f-17f4-4aa4-9805-8cd6714e1519", new DateTime(2026, 1, 17, 10, 53, 58, 472, DateTimeKind.Utc).AddTicks(3759), "AQAAAAIAAYagAAAAECOW8nJhQjd2wnUiVMVbfnE4qDP/LTnb7cX2VDidR1cfRBEsgMVKEQmAwfrURWTC5Q==", "be6d426b-60f7-4cab-98d3-f48dd205dff2" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                values: new object[] { "6ab4f078-7a2e-4b48-8ed3-7aaf551c19e2", new DateTime(2026, 1, 6, 15, 39, 2, 953, DateTimeKind.Utc).AddTicks(7733), "AQAAAAIAAYagAAAAEM5SLN41CndZcjZQfX3g1F28iwA7ASKMTE8ky5PKF3NZGqlY31MNpe5Y7O1f6EG1IA==", "26473315-7f74-4573-8025-1bc1c9948b88" });
========
                values: new object[] { "86996796-88be-4009-8e48-44af0e76f120", new DateTime(2026, 1, 17, 10, 53, 58, 515, DateTimeKind.Utc).AddTicks(3730), "AQAAAAIAAYagAAAAEO6SdyYo+TEvgS7AircAiE9BSOQMTMXE1E+hDJpkQrluznb7NHn3h9waXqXaGV8MHw==", "34411b79-1951-4926-b445-9a18f00ee393" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153941_UpdateFmiAmphFloors2.cs
                values: new object[] { "054173d3-83e7-479f-b0af-c00f81dc567b", new DateTime(2026, 1, 6, 15, 39, 3, 22, DateTimeKind.Utc).AddTicks(6092), "AQAAAAIAAYagAAAAEPxes5oB7cr6rR6oIVgAHJl68JO0eXSvoILOU5SI4IOklm29Fog7oBI/qqS2ne71Ng==", "7c6820ff-e87b-4bde-bf52-bad78368d00c" });
========
                values: new object[] { "52d4521d-a763-4114-8e77-db20e7a3a6ab", new DateTime(2026, 1, 17, 10, 53, 58, 560, DateTimeKind.Utc).AddTicks(1131), "AQAAAAIAAYagAAAAEBegpyvZLuBcD7pQ+h6JxpahIgH/GLsbCoxehonFJD4jPYKt6bo0zI52z1HA/nsaTA==", "1a3faa30-b83a-4d14-b34a-235a9371aad4" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117105426_AddSubjectsAndGradesV2.cs
        }
    }
}
