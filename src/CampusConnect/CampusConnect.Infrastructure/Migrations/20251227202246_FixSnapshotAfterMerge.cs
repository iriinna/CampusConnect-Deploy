using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixSnapshotAfterMerge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FileUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    UploadedByProfessorId = table.Column<int>(type: "int", nullable: false),
                    UploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseMaterials_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseMaterials_Users_UploadedByProfessorId",
                        column: x => x.UploadedByProfessorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupAnnouncements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    AnnouncementId = table.Column<int>(type: "int", nullable: false),
                    ForwardedByProfessorId = table.Column<int>(type: "int", nullable: false),
                    ForwardedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupAnnouncements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupAnnouncements_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupAnnouncements_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupAnnouncements_Users_ForwardedByProfessorId",
                        column: x => x.ForwardedByProfessorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 577, DateTimeKind.Utc).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 577, DateTimeKind.Utc).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 577, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 577, DateTimeKind.Utc).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 577, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 570, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7eb134a5-31ec-483a-b68a-7565cc625248");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "72d01fc3-4507-484a-91c0-0e9b1f29afe9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "52322d54-a0d7-4d99-99cf-11463733e931");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 571, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 574, DateTimeKind.Utc).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 574, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 574, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 20, 22, 45, 574, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d133da4e-2193-40aa-92b6-5e2450984af3", new DateTime(2025, 12, 27, 20, 22, 45, 176, DateTimeKind.Utc).AddTicks(2958), "AQAAAAIAAYagAAAAEHjbr8qLMYYLcVlbzdCvgb8+efvt1HSJTCPz4he3dXSAqEhwp7RQZLk+NcFfz6gevw==", "de583ffb-a460-4339-90fc-fead9f9a7adf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53a32df4-8aac-4d42-82ba-48075bde2c17", new DateTime(2025, 12, 27, 20, 22, 45, 242, DateTimeKind.Utc).AddTicks(8084), "AQAAAAIAAYagAAAAEG40hnzrjx4uvY2Tp/sBOE/jHLESkpd7sp0HBeeEjQbskuGB1Q9wXjzgEVUGtOrsJw==", "f1c90404-c19a-4c08-a04a-dfd6ba22172d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d34b5481-24c7-4593-b012-1404846f4397", new DateTime(2025, 12, 27, 20, 22, 45, 304, DateTimeKind.Utc).AddTicks(4000), "AQAAAAIAAYagAAAAEMKbw6StZ1k9SZdOqTvFqwqBHQjbO73eO4ZKfuVW/ks+jogdDKzHZjYGFVgqVb4z6w==", "537f5d56-f04b-464e-b9e7-38da891d289c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08ea3468-8dac-4367-a9b9-462b6d3689d0", new DateTime(2025, 12, 27, 20, 22, 45, 367, DateTimeKind.Utc).AddTicks(9191), "AQAAAAIAAYagAAAAEI4oBaqY76C5GXXhJe6e4BybKoqpMo1DAd7dsP5+NCD1aUzg2RBBscT+xqnBwvHApg==", "29f8ed7b-1077-4c60-870b-17c1e01f8849" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1255cbae-103e-4986-b769-5e6ce06d01d8", new DateTime(2025, 12, 27, 20, 22, 45, 429, DateTimeKind.Utc).AddTicks(9108), "AQAAAAIAAYagAAAAEJR39ZxmeXS/1W0rXZZVhKjun4icHnz6l5ItamavpfMD87UxfyThb1MvjRqqEH4msA==", "3bfaea12-38a2-45e4-84fb-50eea5b0728a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60d61aaa-62e7-479b-b3a8-c6bb932d2a49", new DateTime(2025, 12, 27, 20, 22, 45, 489, DateTimeKind.Utc).AddTicks(1401), "AQAAAAIAAYagAAAAEBAFzwHXiiKuJcOioNa417V4akMHqWMDGLRPB27l1thq/ZeViVELECIlit7aJuBKDw==", "b6d29395-4ed6-4dfe-9ac2-a8fc89c50882" });

            migrationBuilder.CreateIndex(
                name: "IX_CourseMaterials_GroupId",
                table: "CourseMaterials",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseMaterials_UploadedByProfessorId",
                table: "CourseMaterials",
                column: "UploadedByProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupAnnouncements_AnnouncementId",
                table: "GroupAnnouncements",
                column: "AnnouncementId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupAnnouncements_ForwardedByProfessorId",
                table: "GroupAnnouncements",
                column: "ForwardedByProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupAnnouncements_GroupId_AnnouncementId",
                table: "GroupAnnouncements",
                columns: new[] { "GroupId", "AnnouncementId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseMaterials");

            migrationBuilder.DropTable(
                name: "GroupAnnouncements");

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
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 271, DateTimeKind.Utc).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 271, DateTimeKind.Utc).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 271, DateTimeKind.Utc).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 16, 20, 28, 271, DateTimeKind.Utc).AddTicks(2370));

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
        }
    }
}
