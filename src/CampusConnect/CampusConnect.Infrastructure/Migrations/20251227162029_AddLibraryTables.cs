using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLibraryTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LibraryFolders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryFolders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FolderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoredFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeBytes = table.Column<long>(type: "bigint", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryItems_LibraryFolders_FolderId",
                        column: x => x.FolderId,
                        principalTable: "LibraryFolders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 275, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 275, DateTimeKind.Utc).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 275, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 275, DateTimeKind.Utc).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 275, DateTimeKind.Utc).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "47e1e14a-b7bd-415d-a7ed-bb55fb3402f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c865851d-964f-493b-9e11-90597ac78ff0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b6759c2b-82c2-49ae-9231-6da180b52208");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 268, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 27, 16, 20, 28, 271, DateTimeKind.Utc).AddTicks(2232), new DateTime(2025, 12, 27, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 27, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 27, 16, 20, 28, 271, DateTimeKind.Utc).AddTicks(2363), new DateTime(2025, 12, 27, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 27, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 27, 16, 20, 28, 271, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 12, 27, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 27, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 27, 16, 20, 28, 271, DateTimeKind.Utc).AddTicks(2370), new DateTime(2025, 12, 27, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 27, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4452c03-ef76-4ace-a09b-4d239be0e713", new DateTime(2025, 12, 27, 16, 20, 27, 784, DateTimeKind.Utc).AddTicks(2196), "AQAAAAIAAYagAAAAECeWl5QmRsRAFUL+j3S4DOzn1UKLus3NE05Iix2e+E6XZBb+4Cf6KxdFG4xKPzJDVQ==", "ba7fbd3f-5e3f-4538-a468-d172820b941d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebc4b35d-d870-4d24-942d-9aecfd94309d", new DateTime(2025, 12, 27, 16, 20, 27, 866, DateTimeKind.Utc).AddTicks(157), "AQAAAAIAAYagAAAAEJB8oTv/W7TDtChQS7ZAUguq37Xta0c6cHLBWANRRp1A1WTmVjinoLAIisHqFbG+kQ==", "5d87d5dd-55e9-4f87-80f4-f30b6cf9dea9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fac90319-2947-4917-a8fd-11735ac6c15d", new DateTime(2025, 12, 27, 16, 20, 27, 942, DateTimeKind.Utc).AddTicks(7189), "AQAAAAIAAYagAAAAEBSu0PdSO+OmTYEA10HYf9H6JZcMpozBrNTo7qrl6nRoUWlxeWwxb7iD20gQmwqleA==", "ad466e53-8df8-4dde-baf3-8708e0d5bd5e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c9b178c-06b3-4fdb-93f6-f57a7011ba54", new DateTime(2025, 12, 27, 16, 20, 28, 15, DateTimeKind.Utc).AddTicks(7617), "AQAAAAIAAYagAAAAEHdYW96MANmmkFs89Z5x2/IAKxJx6NbDvxbGFgpemy+YV77/E5fOkk109PBm0dZc9A==", "db5badf0-ce7b-4377-8b26-c63f4d1461dc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a209b081-4c35-4126-8df1-c2015169662f", new DateTime(2025, 12, 27, 16, 20, 28, 88, DateTimeKind.Utc).AddTicks(7670), "AQAAAAIAAYagAAAAEH+e4LukcksNwWuxvaNH0bXDXcFdfdgPAhPs+29N9vV/c6rWNpuKg3SWhCMXv8ITkw==", "027d8348-17aa-4527-9383-32442cdf58b4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c753aa5-349f-4407-90b4-22aab3550e89", new DateTime(2025, 12, 27, 16, 20, 28, 163, DateTimeKind.Utc).AddTicks(9644), "AQAAAAIAAYagAAAAEB1J0hH9P2K7CXgN7C5jL4VyBtth1x/Im67AvVTGuzuaiRF2j0fNcHGODx5RsfiU8w==", "bec8f1ec-703f-4081-a9c3-480dc60f6e8b" });

            migrationBuilder.CreateIndex(
                name: "IX_LibraryItems_FolderId",
                table: "LibraryItems",
                column: "FolderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibraryItems");

            migrationBuilder.DropTable(
                name: "LibraryFolders");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 488, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 488, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 488, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 488, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 488, DateTimeKind.Utc).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "dbd53b5c-404f-411d-b36f-2a2108869317");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c8ac82f2-d5d4-4f1c-a7ba-89307e0f0b47");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1b52cbe9-6d64-46b0-ba52-1a073a139cc6");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 14, 22, 59, 481, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 26, 14, 22, 59, 483, DateTimeKind.Utc).AddTicks(9228), new DateTime(2025, 12, 26, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 26, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 26, 14, 22, 59, 483, DateTimeKind.Utc).AddTicks(9340), new DateTime(2025, 12, 26, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 26, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 26, 14, 22, 59, 483, DateTimeKind.Utc).AddTicks(9343), new DateTime(2025, 12, 26, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 26, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 26, 14, 22, 59, 483, DateTimeKind.Utc).AddTicks(9346), new DateTime(2025, 12, 26, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 26, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e293e6a4-fb5d-42ac-93f1-08a5358acffb", new DateTime(2025, 12, 26, 14, 22, 59, 70, DateTimeKind.Utc).AddTicks(5512), "AQAAAAIAAYagAAAAEAPpZkd+dmbNX3RqWEyVxMnwc3XHLNbCNvYZ+3djp90Ta4QaB5F3WsDpA7dyXr2SCA==", "2d660723-328e-4154-b94e-e9bef1c4652a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60f011d7-485a-4aea-ab9d-ae78490e5012", new DateTime(2025, 12, 26, 14, 22, 59, 130, DateTimeKind.Utc).AddTicks(7233), "AQAAAAIAAYagAAAAEJ0p2DTb76DRayFzj+b2cP3odQeC10ytQFfncaE6QlbGWqs8ftNhUMywBsNbRoq54w==", "57d13b99-2667-41cb-95fc-ffa97d0a0e1c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06401fe4-3ae7-4864-926a-c9fec0687018", new DateTime(2025, 12, 26, 14, 22, 59, 193, DateTimeKind.Utc).AddTicks(1383), "AQAAAAIAAYagAAAAEAbs4zDBgAaH2deb1wJ0UnIqQteNc4Be9FbZpvNuzNbfOF+AEFNoUakFX4g8CQA7Xg==", "350d9604-f7f4-49ca-aafc-7fb30e276ed9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73dcdf68-4ea5-439b-947d-27d984afe713", new DateTime(2025, 12, 26, 14, 22, 59, 259, DateTimeKind.Utc).AddTicks(3942), "AQAAAAIAAYagAAAAECLQwqp+0FmLu8BI//CPou/3whdN8XSEYbAF/oIOTUdC5cDvXg4hQSTaTBlETbZvrw==", "eaad50b2-42ad-4201-a978-1492bdcf07b7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed4a7bcc-1e18-45fd-8c21-0e9f9b427c19", new DateTime(2025, 12, 26, 14, 22, 59, 320, DateTimeKind.Utc).AddTicks(9231), "AQAAAAIAAYagAAAAEEoakryJy8RQes9QzqIYnDKxJwGdhN7/A6UkzaxlUVYEOFya4FkhxBVsSE95e+gz4Q==", "e7558bc0-67a7-4be9-bd03-6098d22cfe4b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "104b31f9-0e5c-4470-abbf-d6da5e969cdf", new DateTime(2025, 12, 26, 14, 22, 59, 388, DateTimeKind.Utc).AddTicks(7930), "AQAAAAIAAYagAAAAEBNVHoaSlIil5SF/ABXl2Mi+6A3/VzBjOo2iZUeCVqVM6NkYyt3T7KzeZtT1pCVWzw==", "b4c46c36-aa3e-427d-93e7-32a0bac0c41a" });
        }
    }
}
