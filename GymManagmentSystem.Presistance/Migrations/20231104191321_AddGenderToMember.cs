using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagmentSystem.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddGenderToMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreateDate", "Gender" },
                values: new object[] { new DateTime(2023, 11, 4, 22, 43, 21, 661, DateTimeKind.Local).AddTicks(1571), 0 });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Gender" },
                values: new object[] { new DateTime(2023, 11, 4, 22, 43, 21, 661, DateTimeKind.Local).AddTicks(1586), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Members");

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
                column: "CreateDate",
                value: new DateTime(2023, 11, 4, 22, 36, 2, 717, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 11, 4, 22, 36, 2, 717, DateTimeKind.Local).AddTicks(9630));
        }
    }
}
