using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
    public partial class UpdateFmiAmphFloors : Migration
========
    public partial class AddYearToSubjects : Migration
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs
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
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(1589));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 546, DateTimeKind.Utc).AddTicks(1264));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(2056));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 546, DateTimeKind.Utc).AddTicks(1471));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(2059));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 546, DateTimeKind.Utc).AddTicks(1473));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(2062));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 546, DateTimeKind.Utc).AddTicks(1474));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 134, DateTimeKind.Utc).AddTicks(2065));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 546, DateTimeKind.Utc).AddTicks(1476));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3278));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8789));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3452));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8913));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3455));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8915));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3458));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8917));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3460));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8919));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3463));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8921));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3465));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8922));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3468));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8924));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3471));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8926));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3473));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8928));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3476));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8929));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3486));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8941));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3489));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8948));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3491));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8949));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3507));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8951));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(3510));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 540, DateTimeKind.Utc).AddTicks(8953));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: "4307f0b5-24b9-41a0-8c62-96f0eec0fe79");
========
                value: "39f556bd-cf2a-4c63-9a59-e6c59f4dc3b9");
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: "bd50fa3e-bd82-4c09-b0f8-2dc32ec57ee0");
========
                value: "b395fd94-fc7d-45f7-b6f8-c0693f2f842b");
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: "15719122-33ea-4628-9bb5-ca3d014dc4b9");
========
                value: "ea9fc00b-26a9-4b76-8f83-78d8b700c170");
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5781));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(554));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5910));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(643));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5913));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(646));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5916));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(648));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5919));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(649));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5921));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(651));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5924));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(653));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(5926));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(654));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6053));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(741));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6057));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(744));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6060));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(758));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6062));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(760));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6083));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(762));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6086));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(763));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6088));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(765));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6091));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(784));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6094));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(786));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6096));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(788));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6099));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(789));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6102));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(791));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6104));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(793));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6107));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(795));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6109));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(796));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6136));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(798));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6139));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(809));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6142));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(811));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6157));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(813));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6160));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(815));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6162));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(817));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6165));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(818));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6168));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(820));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6170));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(822));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6173));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(824));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6175));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(825));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6178));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(827));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6181));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(829));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6184));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(831));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6186));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(832));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6189));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(843));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6191));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(845));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6193));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(846));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6208));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(848));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6211));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(850));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6213));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(852));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6216));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(853));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6218));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(938));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6221));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(941));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6224));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(943));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6226));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(945));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6229));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(947));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6231));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(948));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6234));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(950));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6236));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(952));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6238));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(963));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6241));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(965));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6255));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(966));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6258));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(968));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6261));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(970));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6263));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(972));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6266));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(974));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6269));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(975));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6271));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(977));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6274));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(979));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6276));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(981));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6279));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(983));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6281));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(984));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6284));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(986));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6286));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(995));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6289));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(997));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6292));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(999));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6306));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1001));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6309));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1002));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6311));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1004));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6314));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1006));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6316));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1008));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6319));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1010));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6322));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1011));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6324));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1013));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6327));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1015));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6330));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1017));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6332));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1019));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6334));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1029));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6337));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1031));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6339));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1038));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6352));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1040));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6355));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1042));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6357));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1043));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6360));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1045));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6363));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1047));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6365));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1049));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6368));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1050));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6376));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1052));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6378));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1054));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6381));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1056));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6383));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1057));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6386));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1059));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6389));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1070));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6391));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1072));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6405));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1074));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6408));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1075));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6410));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1077));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6413));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1079));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6415));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1081));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6418));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1082));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6420));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1084));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6423));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1086));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6426));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1088));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6428));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1089));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6431));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1091));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6434));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1093));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6436));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1104));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6439));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1106));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6441));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1108));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6455));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1109));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6457));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1111));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6460));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1113));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6462));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1114));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6465));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1116));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6467));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1118));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6470));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1120));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6473));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1122));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6475));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1124));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6478));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1125));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6481));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1127));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6483));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1129));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6486));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1140));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6489));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1141));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6504));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1143));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6507));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1145));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6509));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1147));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6512));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1148));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6514));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1150));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6517));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1152));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6519));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1154));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6522));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1155));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6524));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1157));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6527));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1159));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6530));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1161));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6532));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1162));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6535));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1173));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6537));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1175));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6552));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1176));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6554));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1178));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6557));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1180));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6559));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1182));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6562));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1183));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6564));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1185));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6567));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1187));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6569));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1189));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6572));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1191));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6574));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1192));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6577));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1200));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6579));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1202));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6582));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1203));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6584));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1213));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6587));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1215));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6601));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1217));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6604));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1219));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6606));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1220));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 6, 15, 39, 3, 126, DateTimeKind.Utc).AddTicks(6615));
========
                value: new DateTime(2026, 1, 20, 11, 12, 15, 541, DateTimeKind.Utc).AddTicks(1222));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 3, 129, DateTimeKind.Utc).AddTicks(6560), new DateTime(2026, 1, 6, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 6, 10, 0, 0, 0, DateTimeKind.Local) });
========
                values: new object[] { new DateTime(2026, 1, 20, 11, 12, 15, 543, DateTimeKind.Utc).AddTicks(396), new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 20, 10, 0, 0, 0, DateTimeKind.Local) });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 3, 129, DateTimeKind.Utc).AddTicks(6695), new DateTime(2026, 1, 6, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 6, 14, 0, 0, 0, DateTimeKind.Local) });
========
                values: new object[] { new DateTime(2026, 1, 20, 11, 12, 15, 543, DateTimeKind.Utc).AddTicks(491), new DateTime(2026, 1, 20, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 20, 14, 0, 0, 0, DateTimeKind.Local) });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 3, 129, DateTimeKind.Utc).AddTicks(6698), new DateTime(2026, 1, 6, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 6, 8, 0, 0, 0, DateTimeKind.Local) });
========
                values: new object[] { new DateTime(2026, 1, 20, 11, 12, 15, 543, DateTimeKind.Utc).AddTicks(494), new DateTime(2026, 1, 20, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 20, 8, 0, 0, 0, DateTimeKind.Local) });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { new DateTime(2026, 1, 6, 15, 39, 3, 129, DateTimeKind.Utc).AddTicks(6701), new DateTime(2026, 1, 6, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 6, 12, 0, 0, 0, DateTimeKind.Local) });
========
                values: new object[] { new DateTime(2026, 1, 20, 11, 12, 15, 543, DateTimeKind.Utc).AddTicks(496), new DateTime(2026, 1, 20, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Local) });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { "d4a176ad-f137-4718-a091-c3ae4ca2d95e", new DateTime(2026, 1, 6, 15, 39, 2, 671, DateTimeKind.Utc).AddTicks(7309), "AQAAAAIAAYagAAAAEK+4KrWROGXVMqNBI9jJGNeDta+82C8WKLGhvmI6moU31ZtUsa5y37u20o7pVLfolg==", "ee62bbe1-a7e1-4d21-abb3-7b343f2a2f87" });
========
                values: new object[] { "c06d6559-531a-4909-b601-d8a5fb123df2", new DateTime(2026, 1, 20, 11, 12, 15, 222, DateTimeKind.Utc).AddTicks(4120), "AQAAAAIAAYagAAAAEGf0dBXQyNgoRLYJXUdoFFNs9vJAyg8a2t84vsfmJudlXlVKhykCLVufjWJpw5XEzQ==", "83c872ca-921c-436b-9569-65631da907fe" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { "956aae38-c3c5-45cb-88b5-f1a0df2c7644", new DateTime(2026, 1, 6, 15, 39, 2, 743, DateTimeKind.Utc).AddTicks(4072), "AQAAAAIAAYagAAAAEIVttbYVg8wcpeGvCwh+xLNs9EseguzmgTmCJPic06zui+rE96IqMVfpxdSHvWhfwg==", "04f12232-3911-49c3-9d93-d3e71671dc23" });
========
                values: new object[] { "b42aea08-c117-42bd-be7a-463ee255f90f", new DateTime(2026, 1, 20, 11, 12, 15, 270, DateTimeKind.Utc).AddTicks(7482), "AQAAAAIAAYagAAAAEPYjLw3ZSouF4b1/kYK5XoKNeyRWYQUjujQ7BDQHz95DmekG3Uh2Hvm84Xrq8Zz1Fw==", "756cfdba-8ee2-436b-8fc6-f88481a830fa" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { "40509274-ca42-452e-baec-67cea2f28c04", new DateTime(2026, 1, 6, 15, 39, 2, 812, DateTimeKind.Utc).AddTicks(7557), "AQAAAAIAAYagAAAAELsBi6ccY7QVEkfARhDZbfI4d1nWmkCgeJdDp6UjPZY98zlA202XcB65U8MXAyEgfg==", "93cc3c84-03ea-4930-8a1e-3e327016ad4d" });
========
                values: new object[] { "54166b9c-4249-4f03-a612-cc671845958c", new DateTime(2026, 1, 20, 11, 12, 15, 319, DateTimeKind.Utc).AddTicks(5732), "AQAAAAIAAYagAAAAEPGmg3WxInjryNYNnJ3edTXz+r03VCuahLt6wT6fhpQWxN5VjtPiHaURZmlnZTcP1A==", "28a8374f-0936-4753-8c41-a82430f8082b" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { "e792b52b-9a99-496f-a511-9dcbf4a96514", new DateTime(2026, 1, 6, 15, 39, 2, 885, DateTimeKind.Utc).AddTicks(7621), "AQAAAAIAAYagAAAAEEARrVqDorKU32//LHNSZ8DJBUHHmLcCxqsE64RyCq0GXgOq6QLTMaRVOtDzTVWTcg==", "d82e52f7-26c5-4633-8215-f77565efd6f7" });
========
                values: new object[] { "08442768-2656-4e9b-88b0-a70a03bdb251", new DateTime(2026, 1, 20, 11, 12, 15, 369, DateTimeKind.Utc).AddTicks(317), "AQAAAAIAAYagAAAAEJS5t2+DqhgMxgGr9w35xRPlngM0k9mTf9p5iGpFmAgizmwAiVRgUtmHk4+ylNlk+Q==", "da9c4b9e-77fb-4794-9041-2216e8724bbf" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { "6ab4f078-7a2e-4b48-8ed3-7aaf551c19e2", new DateTime(2026, 1, 6, 15, 39, 2, 953, DateTimeKind.Utc).AddTicks(7733), "AQAAAAIAAYagAAAAEM5SLN41CndZcjZQfX3g1F28iwA7ASKMTE8ky5PKF3NZGqlY31MNpe5Y7O1f6EG1IA==", "26473315-7f74-4573-8025-1bc1c9948b88" });
========
                values: new object[] { "c2818444-ada7-489b-89ad-353535111c1b", new DateTime(2026, 1, 20, 11, 12, 15, 417, DateTimeKind.Utc).AddTicks(8814), "AQAAAAIAAYagAAAAEFq5tcTvNX/hygqwG8UBYxNEjjRO4aWU3LZWjtN2Zmn2cIu0hXjsF+rS/KnmHij/zA==", "6fc859d6-3e9a-42b5-ac36-a87f0638685b" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { "054173d3-83e7-479f-b0af-c00f81dc567b", new DateTime(2026, 1, 6, 15, 39, 3, 22, DateTimeKind.Utc).AddTicks(6092), "AQAAAAIAAYagAAAAEPxes5oB7cr6rR6oIVgAHJl68JO0eXSvoILOU5SI4IOklm29Fog7oBI/qqS2ne71Ng==", "7c6820ff-e87b-4bde-bf52-bad78368d00c" });
========
                values: new object[] { "c9a9f313-6122-4f4d-b962-d35283dfe1d4", new DateTime(2026, 1, 20, 11, 12, 15, 468, DateTimeKind.Utc).AddTicks(2675), "AQAAAAIAAYagAAAAEEmunKFPGCsVe4hkE2StJN8rdFsSdy7KCDs8oLhBvYPE7AoYj1+bAu3mvjBRBcXOJQ==", "e6457476-879b-49ed-9ebb-854d04e19c2d" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs
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
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 955, DateTimeKind.Utc).AddTicks(3628));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(929));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 955, DateTimeKind.Utc).AddTicks(3797));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(1175));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 955, DateTimeKind.Utc).AddTicks(3799));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(1177));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 955, DateTimeKind.Utc).AddTicks(3800));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(1179));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 955, DateTimeKind.Utc).AddTicks(3801));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 304, DateTimeKind.Utc).AddTicks(1181));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6271));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3116));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6365));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3246));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6367));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3249));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6368));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3251));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6370));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3253));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6380));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3255));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6381));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3257));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6383));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3259));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6384));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3261));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6386));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3262));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6387));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3264));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6389));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3279));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6400));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3282));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6402));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3294));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6403));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3296));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6404));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(3298));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: "25bd5818-2cb7-45ce-8e71-eb837a903f5a");
========
                value: "ef5769f6-3997-4f79-bf47-d5e15806bce9");
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: "b6bd17dd-03ca-41eb-8a99-35583e197198");
========
                value: "6488f54f-d0d4-4c61-9ea7-253788f6bcd0");
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: "f19c7f66-0c54-4a29-84e7-cbeaa2227e8b");
========
                value: "7b494646-e406-4f49-a045-f7f4832dccf3");
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7595));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(4915));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7668));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5012));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7670));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5015));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7671));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5017));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7682));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5019));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7683));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5021));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7685));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5023));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7686));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5025));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7762));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5134));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7764));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5137));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7766));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5151));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7767));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5153));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7769));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5155));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7770));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5157));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7772));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5159));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7773));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5161));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7775));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5163));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7777));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5166));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7787));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5167));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7788));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5170));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7790));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5171));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7791));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5173));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7793));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5175));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7794));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5177));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7796));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5190));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7797));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5192));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7799));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5194));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7801));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5196));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7802));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5198));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7804));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5200));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7805));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5202));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7807));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5204));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7808));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5206));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7817));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5208));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7819));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5210));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7829));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5212));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7831));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5214));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7832));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5216));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7834));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5226));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7835));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5228));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7836));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5230));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7838));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5232));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7839));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5234));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7841));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5236));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7842));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5238));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7844));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5240));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7845));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5242));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7854));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5244));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7856));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5246));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7857));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5248));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7859));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5250));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7860));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5252));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7861));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5253));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7863));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5264));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7864));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5266));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7866));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5269));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7867));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5271));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7869));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5273));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7871));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5275));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7872));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5277));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7874));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5279));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7875));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5281));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7884));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5283));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7885));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5284));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7887));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5286));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7888));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5288));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7890));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5290));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7891));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5301));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7893));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5303));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7894));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5313));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7896));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5315));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7898));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5317));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7899));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5318));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7900));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5320));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7902));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5322));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7903));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5324));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7912));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5326));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7914));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5328));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7915));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5330));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7917));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5332));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7918));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5334));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7920));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5347));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7921));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5349));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7923));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5350));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7924));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5352));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7926));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5354));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7927));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5356));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7929));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5358));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7930));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5360));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7932));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5362));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7942));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5364));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7944));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5366));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7945));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5368));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7947));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5370));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7948));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5372));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7950));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5374));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7951));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5385));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7953));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5387));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7954));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5389));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7956));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5391));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7957));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5393));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7959));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5395));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7960));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5397));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7966));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5398));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7968));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5400));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7977));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5402));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7979));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5404));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7980));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5406));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7982));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5408));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7983));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5410));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7985));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5422));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7986));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5424));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7988));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5426));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7989));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5428));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7991));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5430));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7992));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5432));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7993));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5434));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7995));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5436));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7996));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5438));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8006));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5440));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8007));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5442));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8009));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5444));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8011));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5446));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8012));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5448));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8014));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5450));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8015));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5462));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8017));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5464));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8018));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5466));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8020));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5468));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8021));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5470));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8022));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5472));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8024));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5474));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8025));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5476));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8034));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5478));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8037));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5480));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8038));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5482));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8040));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5484));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8041));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5491));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8043));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5493));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8044));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5503));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8046));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5506));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8047));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5507));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8049));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5509));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8050));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5511));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8052));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5513));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8053));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5515));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8055));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5517));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8056));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5519));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8065));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5521));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8067));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5523));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8068));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5525));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8069));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5527));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8071));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5529));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8072));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5531));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8074));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5543));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8075));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5545));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8077));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5547));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8078));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5549));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8080));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5551));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                value: new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8081));
========
                value: new DateTime(2026, 1, 17, 10, 54, 25, 298, DateTimeKind.Utc).AddTicks(5553));
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { new DateTime(2026, 1, 3, 13, 18, 59, 953, DateTimeKind.Utc).AddTicks(3405), new DateTime(2026, 1, 3, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 3, 10, 0, 0, 0, DateTimeKind.Local) });
========
                values: new object[] { new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(3901), new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Local) });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { new DateTime(2026, 1, 3, 13, 18, 59, 953, DateTimeKind.Utc).AddTicks(3480), new DateTime(2026, 1, 3, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 3, 14, 0, 0, 0, DateTimeKind.Local) });
========
                values: new object[] { new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(3998), new DateTime(2026, 1, 17, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 17, 14, 0, 0, 0, DateTimeKind.Local) });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { new DateTime(2026, 1, 3, 13, 18, 59, 953, DateTimeKind.Utc).AddTicks(3483), new DateTime(2026, 1, 3, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 3, 8, 0, 0, 0, DateTimeKind.Local) });
========
                values: new object[] { new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(4001), new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 17, 8, 0, 0, 0, DateTimeKind.Local) });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { new DateTime(2026, 1, 3, 13, 18, 59, 953, DateTimeKind.Utc).AddTicks(3485), new DateTime(2026, 1, 3, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 3, 12, 0, 0, 0, DateTimeKind.Local) });
========
                values: new object[] { new DateTime(2026, 1, 17, 10, 54, 25, 301, DateTimeKind.Utc).AddTicks(4004), new DateTime(2026, 1, 17, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Local) });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { "56a6082c-161a-4253-a115-2c5f6e8e6c1b", new DateTime(2026, 1, 3, 13, 18, 59, 674, DateTimeKind.Utc).AddTicks(1587), "AQAAAAIAAYagAAAAEDJuUAOr2N6HZFJmzQk3RxcpL01ZqDtmjHjHL8PCzOZoVGuUkw483yGqz6buZHWrOg==", "3ae22364-042d-41c7-baf8-9cc4ffd47538" });
========
                values: new object[] { "d92240d1-fdba-40b6-ae27-ab26eb1dc653", new DateTime(2026, 1, 17, 10, 54, 24, 973, DateTimeKind.Utc).AddTicks(9967), "AQAAAAIAAYagAAAAECFKuErui1SND9Qt8q9/7G2AU4eBf1XYF4MnaZmdNyCivcqoNNEd96MpbvSfzbs7vg==", "68c6e342-a48e-44d2-b0fc-3da2881364bc" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { "b453eab2-8079-4fac-9ad1-3e688ec748c0", new DateTime(2026, 1, 3, 13, 18, 59, 718, DateTimeKind.Utc).AddTicks(3022), "AQAAAAIAAYagAAAAENQdVw1zrbGyx2qGD83A43POuQy4FJzqd50VP5zeFoMlnGgZPbNY+DYqZfkXKme+Gw==", "935d2c43-f94c-412d-87d3-0c3c112a1169" });
========
                values: new object[] { "1c1b53e2-fde8-45dc-9283-4d41c821c22f", new DateTime(2026, 1, 17, 10, 54, 25, 21, DateTimeKind.Utc).AddTicks(9274), "AQAAAAIAAYagAAAAEOhud1GLUEVTP4gT9WZi6G99/hYtCEhlGAoNgHBcg+tVgf24wgc2LpPzigQBk/8AUQ==", "65fa8e0b-3b44-4fb3-8952-d30e0f34c254" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { "c8d21bee-7188-4e55-a66d-7b8a16027bf5", new DateTime(2026, 1, 3, 13, 18, 59, 761, DateTimeKind.Utc).AddTicks(5524), "AQAAAAIAAYagAAAAENf18kE5uj/W7bcU3JdET6M05AgXV1AphFoLqZRMoZWBfifNjfnQvjcNcK0zfowBGQ==", "53019be7-f616-4b9b-8a86-89c6abab2244" });
========
                values: new object[] { "457f2021-a5aa-410b-a7b7-ca54cfa998fe", new DateTime(2026, 1, 17, 10, 54, 25, 69, DateTimeKind.Utc).AddTicks(9425), "AQAAAAIAAYagAAAAEENTdxugO1+FWSydemzKSWr/aAQNcYvu1DQuSar8N54qwx4uHyGPqyiZRQl3WFs+wQ==", "3490fd96-7614-496e-87ef-b4ab19bca848" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { "d7624276-da66-4177-bc83-04b65ba40ca5", new DateTime(2026, 1, 3, 13, 18, 59, 804, DateTimeKind.Utc).AddTicks(8898), "AQAAAAIAAYagAAAAEHPbfnGCOkx1pEqTm9Mh0W7/7nCbSM/8R6NWADsgFGOyQA0gH/B995dRoofaqPItuQ==", "4f7edbda-191c-48a3-9066-c492dc8711c9" });
========
                values: new object[] { "c627f547-007f-4eec-b60f-e8f57e29f1ba", new DateTime(2026, 1, 17, 10, 54, 25, 118, DateTimeKind.Utc).AddTicks(3257), "AQAAAAIAAYagAAAAEIFeQR37mc4Dtr7YrQlJgbUDlhPwPdi/La14SqR/YG99WNvLAok8DSmJC6LXzfGklQ==", "ded6cc61-6c1d-4735-8637-d82eb498d215" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { "21d851f2-5007-4e90-9e73-ac64d696033c", new DateTime(2026, 1, 3, 13, 18, 59, 848, DateTimeKind.Utc).AddTicks(2656), "AQAAAAIAAYagAAAAECj8trFXhOhd76qz+U2GcH1Ypmj5GI4cMJdD4gtCfDT6cSiUk77gtKtQf6Jp3M0naQ==", "73313559-5394-4007-8c43-510c291b1d21" });
========
                values: new object[] { "21117db5-5c34-48cc-b03d-ee1f679abfc0", new DateTime(2026, 1, 17, 10, 54, 25, 170, DateTimeKind.Utc).AddTicks(8927), "AQAAAAIAAYagAAAAEB6Rh8cz7RBzyw5AuYZX1CT5QSwvodLfrWeJaSS+rFcCoaa6+/olDH75sO3oNudu7Q==", "4c852f8e-d34d-4448-ac4d-28906b8f161a" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260106153904_UpdateFmiAmphFloors.cs
                values: new object[] { "781af145-a43b-46bf-b495-289f9ccabe20", new DateTime(2026, 1, 3, 13, 18, 59, 891, DateTimeKind.Utc).AddTicks(3237), "AQAAAAIAAYagAAAAEP4Boloy+9ZhOOW/5OYQRmnucrpkjxL8arVRtLYovvqMueJXwvIBos5h7Y0sah7Inw==", "408376ad-33d6-49aa-8ee0-266171599659" });
========
                values: new object[] { "9f1651bd-2846-4dd5-8ee7-f46c7f1d4bb6", new DateTime(2026, 1, 17, 10, 54, 25, 222, DateTimeKind.Utc).AddTicks(7494), "AQAAAAIAAYagAAAAEA32Huc5pb7nKufGeB8JGnvpd9EsVs6FHQvBxKx1rZD4UNarWlljglVUZO575TvILg==", "91148053-ab2f-44d5-b81c-d9af8f06ac78" });
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260120111216_AddYearToSubjects.cs
        }
    }
}
