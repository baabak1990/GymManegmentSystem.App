using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagmentSystem.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddingNewFeaturesToUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telegram",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TikTok",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "X",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 11, 17, 14, 2, 0, 11, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 11, 17, 14, 2, 0, 11, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 11, 17, 14, 2, 0, 11, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 11, 17, 14, 2, 0, 11, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "CreateDate", "Email", "Facebook", "Instagram", "Telegram", "TikTok", "X" },
                values: new object[] { null, new DateTime(2023, 11, 17, 14, 2, 0, 11, DateTimeKind.Local).AddTicks(9873), null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "CreateDate", "Email", "Facebook", "Instagram", "Telegram", "TikTok", "X" },
                values: new object[] { null, new DateTime(2023, 11, 17, 14, 2, 0, 11, DateTimeKind.Local).AddTicks(9886), null, null, null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Telegram",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "TikTok",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "X",
                table: "Members");

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 11, 4, 22, 43, 21, 661, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 11, 4, 22, 43, 21, 661, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 11, 4, 22, 43, 21, 661, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 11, 4, 22, 43, 21, 661, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 11, 4, 22, 43, 21, 661, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 11, 4, 22, 43, 21, 661, DateTimeKind.Local).AddTicks(1586));
        }
    }
}
