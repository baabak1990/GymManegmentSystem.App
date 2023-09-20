using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagmentSystem.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingSeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "BirthDate", "CreateDate" },
                values: new object[] { new DateTime(2000, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 11, 48, 39, 732, DateTimeKind.Local).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreateDate" },
                values: new object[] { new DateTime(1990, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 11, 48, 39, 732, DateTimeKind.Local).AddTicks(2432) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 20, 11, 46, 37, 15, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 20, 11, 46, 37, 15, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 20, 11, 46, 37, 15, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "MemberShips",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 9, 20, 11, 46, 37, 15, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1983), new DateTime(2023, 9, 20, 11, 46, 37, 15, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1983), new DateTime(2023, 9, 20, 11, 46, 37, 15, DateTimeKind.Local).AddTicks(4168) });
        }
    }
}
