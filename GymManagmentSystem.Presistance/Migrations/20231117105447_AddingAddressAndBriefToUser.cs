using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagmentSystem.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddingAddressAndBriefToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brief",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 11, 17, 14, 24, 47, 148, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 11, 17, 14, 24, 47, 148, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 11, 17, 14, 24, 47, 148, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 11, 17, 14, 24, 47, 148, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brief", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 11, 17, 14, 24, 47, 148, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brief", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 11, 17, 14, 24, 47, 148, DateTimeKind.Local).AddTicks(5829) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brief",
                table: "Members");

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
                column: "CreateDate",
                value: new DateTime(2023, 11, 17, 14, 2, 0, 11, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 11, 17, 14, 2, 0, 11, DateTimeKind.Local).AddTicks(9886));
        }
    }
}
