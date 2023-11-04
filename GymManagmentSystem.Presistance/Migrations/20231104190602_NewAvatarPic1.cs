using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagmentSystem.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class NewAvatarPic1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 11, 4, 22, 36, 2, 717, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 11, 4, 22, 36, 2, 717, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 11, 4, 22, 36, 2, 717, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 11, 4, 22, 36, 2, 717, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Avatar", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 11, 4, 22, 36, 2, 717, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Avatar", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 11, 4, 22, 36, 2, 717, DateTimeKind.Local).AddTicks(9630) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Members");

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 20, 11, 48, 39, 732, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 20, 11, 48, 39, 732, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 20, 11, 48, 39, 732, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 9, 20, 11, 48, 39, 732, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 20, 11, 48, 39, 732, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 20, 11, 48, 39, 732, DateTimeKind.Local).AddTicks(2432));
        }
    }
}
