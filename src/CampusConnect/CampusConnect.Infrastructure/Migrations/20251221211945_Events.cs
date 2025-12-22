using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Events : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OrganizerId",
                table: "Events",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "41789fcd-86ae-480e-9ea4-9b5338b82f2c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a33eb695-bed1-4f03-a7a2-b37e4e8c3bda");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d68b794-3afe-4379-94d4-5d0cb2f6d9c2", new DateTime(2025, 12, 21, 21, 19, 44, 705, DateTimeKind.Utc).AddTicks(3113), "AQAAAAIAAYagAAAAEGow4shiBHPWhsYb/5XXXJhwOmJuoZdxiPO6lsnR9w0WWpn8jCABakKYiK2n1MuWYQ==", "02c0f76e-9356-42d8-81a1-4198a81d0205" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cb3e9df-8923-40f2-829f-f47e4211fa60", new DateTime(2025, 12, 21, 21, 19, 44, 744, DateTimeKind.Utc).AddTicks(9265), "AQAAAAIAAYagAAAAEESU2k8c84waMpmIAeAb9w8vT+8KaGZlCZWz912DPwvwcfNeruhT1PHtK+NJA0s55Q==", "a5df4f4e-cf8d-4a48-a702-5fc77ac0f3ca" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17abbb81-3623-454a-bc99-17e7133bb356", new DateTime(2025, 12, 21, 21, 19, 44, 782, DateTimeKind.Utc).AddTicks(6683), "AQAAAAIAAYagAAAAEIoElViCy/Q93b/ohGw5XKpgzJRJgOkMQtfCH8Odom0aDvsuU7iQnn+PcBJ4wFMmvg==", "3d909f39-2bbe-44f1-b58d-50b87307ac9e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4010cfc8-cf52-4a08-a282-1577dc03e98c", new DateTime(2025, 12, 21, 21, 19, 44, 823, DateTimeKind.Utc).AddTicks(4555), "AQAAAAIAAYagAAAAEFOwMlEs9ugBiZqVWfFWoc6RRNglBy4MCPgUjR2vKzQijISDYQlRujeIF3lYEWnTVg==", "7f890975-0000-429f-b004-d3646f19922e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OrganizerId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "6a045a8c-649f-43e6-8327-24dd2dc7bdc5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3762750c-384f-45ab-8a53-9d4aac94c8cd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dcd6a95-b535-4f21-b0fc-7421ef081d21", new DateTime(2025, 12, 21, 17, 58, 27, 678, DateTimeKind.Utc).AddTicks(2834), "AQAAAAIAAYagAAAAEKH2NSFZ0gOu21D2sdlK1AlCmkOOmr5LR0tDayBKPMMXEQT5WolB2ciELA0t+xKbkQ==", "edb3d48d-b096-4306-8a4e-22bbd9feefe8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec6ae678-ac3a-4e4c-a80a-a616a85513d9", new DateTime(2025, 12, 21, 17, 58, 27, 717, DateTimeKind.Utc).AddTicks(3940), "AQAAAAIAAYagAAAAEFTR84cLf5qVlAaLH+2uG1QOV6YKYQf1sPXrFdSnsq9pqq+8eUMEpPsPZJzYzM18vw==", "b89e4316-e36b-4620-9c92-f071b3039d0f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81c66387-cb5b-49ed-a0f3-c053d8e92593", new DateTime(2025, 12, 21, 17, 58, 27, 754, DateTimeKind.Utc).AddTicks(9078), "AQAAAAIAAYagAAAAEOBPLuf56yx1A/wJFrp11HM/sdMaghd828KnvNlK7BN1in7Nlzt1BfpQEs7wszbiEQ==", "2c5896f6-8b0e-4847-9e10-b662fedaa792" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d51fea5-2057-4bde-988c-b5843d94fe0f", new DateTime(2025, 12, 21, 17, 58, 27, 792, DateTimeKind.Utc).AddTicks(1387), "AQAAAAIAAYagAAAAEMLLWG7Ox8BXbFxx2KD/qfXKQVwYsJ/xwRgxvlBdEwyhjy3KQ+AYlcZuGMF7fVxfCQ==", "58359f1e-67d4-43c2-a4ad-7a969f5c3f06" });
        }
    }
}
