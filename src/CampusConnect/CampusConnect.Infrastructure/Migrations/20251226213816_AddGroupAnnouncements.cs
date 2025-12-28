using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddGroupAnnouncements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                value: new DateTime(2025, 12, 26, 21, 38, 15, 863, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 863, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 863, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 863, DateTimeKind.Utc).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 863, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "aab809b0-30aa-4b40-bc33-da4504e33ee8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1110f2cc-8e63-4718-accc-a8bf9ff918f8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "3dbf7bab-e2a0-4e25-b37e-190bf13e7479");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 858, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 860, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 860, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 860, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 21, 38, 15, 860, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bfaaecc-c29a-4ac8-b62f-72da7a9bb846", new DateTime(2025, 12, 26, 21, 38, 15, 542, DateTimeKind.Utc).AddTicks(301), "AQAAAAIAAYagAAAAELPw5g79fYrjTQYrv+VolQJPXMFoK2Uc/X7PJNQPqfx5AOYMUTsASDhcAdxgdOobEA==", "363a1d06-4b09-449e-be3f-1e22c7a3da60" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99bfecd7-0b20-42fd-9297-abfac23dc0f2", new DateTime(2025, 12, 26, 21, 38, 15, 585, DateTimeKind.Utc).AddTicks(1499), "AQAAAAIAAYagAAAAEIvGiAIsxz6TdWKKCSomsq7U0MhV4YAFxp61SmNjeLUMk6WY7FF6ranaZsSy+Gqksg==", "f95f5fd5-2058-44de-94cf-de2165d123b1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c640db95-6b4e-4929-8eed-27cc78123ee7", new DateTime(2025, 12, 26, 21, 38, 15, 634, DateTimeKind.Utc).AddTicks(1641), "AQAAAAIAAYagAAAAEBEFV8k1rvlYFMox0Fu99DFhf8HgGR3h2tivbmyud9CrU8/aM+h3Jb+uc4XBIHGOnQ==", "c0af28b7-9ea2-4bed-ab75-15f5417b4352" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1e55f36-256f-46d1-8b80-350aaf02942d", new DateTime(2025, 12, 26, 21, 38, 15, 676, DateTimeKind.Utc).AddTicks(7238), "AQAAAAIAAYagAAAAEMhKVLqe5f0GpkuYgeXiqcEVIIhFPXxL875NJmI1eVXSEB2GOWwHdloN56bP8n6L3A==", "1619bffd-7c76-4afa-be93-58c58ea1a1db" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18341e00-8fc7-4e60-a012-385c01be2b41", new DateTime(2025, 12, 26, 21, 38, 15, 723, DateTimeKind.Utc).AddTicks(4485), "AQAAAAIAAYagAAAAEMg6Ett4+WsuSQ2SZ3ftPC9Kehh3o95ZfVC4tLdOVDWGvwpAa+md9pMEjiTJ2GOnlg==", "2a2dbf7d-ac95-4773-b067-39b29d7f2cb0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "673cd7f1-c143-4744-b563-dd1f77e24043", new DateTime(2025, 12, 26, 21, 38, 15, 787, DateTimeKind.Utc).AddTicks(4051), "AQAAAAIAAYagAAAAEOj9ueJNhzjPrRJOhfBSo1cqf25wA7nG7vdOZ0FKavjxawnWpQmOq4XI9txVcAZVCg==", "142a10dd-0b3d-4208-ab8d-1fbfa64f3d8e" });

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
                name: "GroupAnnouncements");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 73, DateTimeKind.Utc).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 73, DateTimeKind.Utc).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 73, DateTimeKind.Utc).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 73, DateTimeKind.Utc).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 73, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7b87f76b-1615-4eb5-85bc-f610595fd45d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "aecc34ad-b913-41c6-a660-d52d01603771");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "921b6979-307c-4bb0-be2f-f90436dcad98");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 66, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 69, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 69, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 69, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 26, 20, 57, 35, 69, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22c1a7bf-3014-40cd-9a6f-dfb041d8ff1f", new DateTime(2025, 12, 26, 20, 57, 34, 745, DateTimeKind.Utc).AddTicks(36), "AQAAAAIAAYagAAAAEMV+Lkm+1jjstjn/FmdugPiyHtMEIPIQhpOXa1gQ2bEDhYJTd/MraHxmIJooEl0Z4g==", "fbd8d8d7-be30-4938-acc1-ea6098928a81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f22f065e-b828-44dd-b205-1df14c475073", new DateTime(2025, 12, 26, 20, 57, 34, 804, DateTimeKind.Utc).AddTicks(1631), "AQAAAAIAAYagAAAAEE8VY+7EAVzZJaIEXivAZNMienqhBEnGiCI3/H6ljK54lLW7WvaeuNh5zOWFSyY/wQ==", "9b274b69-3271-46a2-a49f-22981ff624f0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ea58a4d-fd56-4883-8d68-8f5d7635c2d6", new DateTime(2025, 12, 26, 20, 57, 34, 852, DateTimeKind.Utc).AddTicks(8083), "AQAAAAIAAYagAAAAEJC+6Ps+TWI4VB12fLkuQPbCptjuyOGVQ8+vF/o21+qalIiHH+Hajj5C1rQ3FtOMWA==", "1db4628a-8f98-471f-806f-de0f35b534fd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a184632c-da5b-4b90-9a45-7026f9430541", new DateTime(2025, 12, 26, 20, 57, 34, 897, DateTimeKind.Utc).AddTicks(2698), "AQAAAAIAAYagAAAAEOuJIJD1JcK4DBBYX/YW2f3b5Fh2V1Lnh8PLTOKlumvDjoXBVJKwPtioXZKXCw0Gsg==", "b7ea9ed8-903b-4238-afa3-d11a90369a09" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f00dc90c-7798-4b96-a4e2-bf4d64c98710", new DateTime(2025, 12, 26, 20, 57, 34, 942, DateTimeKind.Utc).AddTicks(9339), "AQAAAAIAAYagAAAAEO7++MEEnu1kSTP9LRTrmNb/yqk+LQFvqDxf6/D4OranApAusorek9kbmtQDCww2sg==", "36e4790f-0e7e-44a5-bcfd-8fb6f62cd513" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f0c23bf-b490-4556-a23d-c23cefae93ba", new DateTime(2025, 12, 26, 20, 57, 34, 987, DateTimeKind.Utc).AddTicks(6996), "AQAAAAIAAYagAAAAEM0Oq3m+8m9ah9Yhi3m0LRf5KGzmWesH2WkqZ8cnDUGt/8KUXAPQczUys5uTYXlq3A==", "37cfa443-36b1-4d20-a272-c70bbd70a9ab" });
        }
    }
}
