using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserActivityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActivityType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: true),
                    EntityName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActivities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 19, 43, 29, 818, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 19, 43, 29, 818, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 19, 43, 29, 818, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 19, 43, 29, 818, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 19, 43, 29, 818, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e73db867-ffff-4771-b365-16a7b015eace");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "62990cce-cdf6-4973-805d-5c92b7051e85");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "cd223ba6-9a1d-4c19-a640-ea9a36d41edc");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50876560-b32e-44e1-b871-4dbdb24cadd1", new DateTime(2025, 12, 25, 19, 43, 29, 151, DateTimeKind.Utc).AddTicks(9063), "AQAAAAIAAYagAAAAEJyUKqZjwFP/BGkMntr/IVsTU9cg+zv+mAIINwWe/ISOQHzo61FeVV39bBTwD3leAg==", "154ecdea-a427-43b6-9885-a1a609442487" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6be3746-6c6b-4b8d-9022-cbab4a1a789e", new DateTime(2025, 12, 25, 19, 43, 29, 260, DateTimeKind.Utc).AddTicks(951), "AQAAAAIAAYagAAAAEOwVU+2EDAiua0IbOeQIba1rxHAqQdOZEnIbXZ5miDDD9PZ5394KdzZcNy5hNtBwTw==", "1f5a9809-5d10-4d40-aee5-0a9c8c5a659d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0431e87d-6262-4390-a458-2729d67df6a3", new DateTime(2025, 12, 25, 19, 43, 29, 359, DateTimeKind.Utc).AddTicks(2987), "AQAAAAIAAYagAAAAEPc+Q0azoVQ0WTle2qO+Js+OXEEKW7a0BfpUymqBtrIhdI0u/ymIYEdGHlxPislUZw==", "c28125ac-f984-4a3e-9009-7393953cc4dd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3f317ed-8816-4700-8e19-bda79afc9d00", new DateTime(2025, 12, 25, 19, 43, 29, 465, DateTimeKind.Utc).AddTicks(6501), "AQAAAAIAAYagAAAAEFHZhWHUiStx0fgDUxwU8/QCFZRzGCqziUgQlhkWxzTJlmFMULq47RwRp0dPD2eGfA==", "caaa7f94-bfd9-4ee7-9a8b-8c62f2e2a6fa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "395bc6d2-f7f3-4ec1-9335-88dd4193fbae", new DateTime(2025, 12, 25, 19, 43, 29, 582, DateTimeKind.Utc).AddTicks(7050), "AQAAAAIAAYagAAAAEJ3AStRsw7a6UftbHZ3Yjs+Agpt7Vf00j2Pdf5mBYw9UWml8n1CQa++uYrI4fuXD7g==", "aac0ce58-5d9c-4803-b8f2-147de926f18d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b7ac85a-24cd-4acd-9ce4-6f3a1d1df026", new DateTime(2025, 12, 25, 19, 43, 29, 698, DateTimeKind.Utc).AddTicks(2059), "AQAAAAIAAYagAAAAEOPbadbhi3PtrEHeJrqgqwzquRQzJw1H2eXxktW0SbE2xNCOaqL82D9bBUhST82Pog==", "e77ba52e-95b2-4687-9191-9d2fa9917959" });

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_UserId_CreatedAt",
                table: "UserActivities",
                columns: new[] { "UserId", "CreatedAt" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserActivities");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 18, 55, 41, 44, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 18, 55, 41, 44, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 18, 55, 41, 44, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 18, 55, 41, 44, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 25, 18, 55, 41, 44, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4a442bf9-5441-4d08-8fad-0090f31aa1f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b8dadc22-6ad2-4c0a-8e16-af8b72400180");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "cdec7c6a-625d-45d1-aac2-3d604adbfa3e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b802377-06cd-4fbc-bf7b-726a86779e68", new DateTime(2025, 12, 25, 18, 55, 40, 233, DateTimeKind.Utc).AddTicks(3044), "AQAAAAIAAYagAAAAED1/UGe7ueVpdsp2tlGvG5DQO+1qm7kqONzNcXjYNmH6lmH+0Eku0X9u6aO2o/aG5A==", "c8242a8b-f022-479a-9a2a-3625861c496e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe617332-c469-4c84-8666-c6fd8ae5e370", new DateTime(2025, 12, 25, 18, 55, 40, 363, DateTimeKind.Utc).AddTicks(3431), "AQAAAAIAAYagAAAAEB8NAzs05YJbG58A9jUJreHRyhMI17gDCzVttwWOZe9gywTzF0Y/d2wffwF64K8jiw==", "ace32022-f8d5-4c4b-b247-13efa557b2da" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c31b7d10-73c9-468b-b902-570ddd2ca4a1", new DateTime(2025, 12, 25, 18, 55, 40, 498, DateTimeKind.Utc).AddTicks(8199), "AQAAAAIAAYagAAAAEBPf+2F5VlbkH678gS+sr6nsTclUvaA+HOVAdHk+XMb8232EIHTjONHx/UaLC0aLoA==", "dab0fc1e-e305-4747-a9d9-08b293f52059" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba900d4a-4b60-4e62-b0bb-cf4e33396c9c", new DateTime(2025, 12, 25, 18, 55, 40, 623, DateTimeKind.Utc).AddTicks(4497), "AQAAAAIAAYagAAAAEM7c+ByjtZOlIeY3Dq/me2MScifrXicSyYFQWpTMErCWW+OPqX4nBX9lbSVqdnvUhw==", "ec2aa4a7-3d05-4a65-ba2a-dce4074d12e1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b0de819-1826-440a-a76a-bc0bb6b9382a", new DateTime(2025, 12, 25, 18, 55, 40, 769, DateTimeKind.Utc).AddTicks(7442), "AQAAAAIAAYagAAAAEEvn/9SBXCofM6kxO9KZk0x3MF2gYXYmoS0HPPU/e9gm69YhtkNBX29s5vIoSwlZng==", "97463517-a034-4831-98c5-c36c0df93810" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f42a02b-af32-4d02-891e-43c6a1884c2e", new DateTime(2025, 12, 25, 18, 55, 40, 917, DateTimeKind.Utc).AddTicks(8419), "AQAAAAIAAYagAAAAEFymbuj+TqyMzQldA5JMP9RhhfFp0+fBs4AYOLP5yRmiW1uep0rNBHidXIUXUrsuDA==", "d89147e6-f119-4a20-94be-1259b700e33f" });
        }
    }
}
