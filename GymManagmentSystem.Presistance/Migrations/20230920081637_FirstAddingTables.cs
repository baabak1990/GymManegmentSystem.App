using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymManagmentSystem.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class FirstAddingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberShips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberShips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false),
                    IsPresent = table.Column<bool>(type: "bit", nullable: false),
                    memberShip_Id = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Members_MemberShips_memberShip_Id",
                        column: x => x.memberShip_Id,
                        principalTable: "MemberShips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MemberShips",
                columns: new[] { "Id", "CreateDate", "Duration", "ModifyDate", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 20, 11, 46, 37, 15, DateTimeKind.Local).AddTicks(4236), 12, null, 2, 25000.0 },
                    { 2, new DateTime(2023, 9, 20, 11, 46, 37, 15, DateTimeKind.Local).AddTicks(4239), 15, null, 1, 30000.0 },
                    { 3, new DateTime(2023, 9, 20, 11, 46, 37, 15, DateTimeKind.Local).AddTicks(4240), 20, null, 0, 35000.0 },
                    { 4, new DateTime(2023, 9, 20, 11, 46, 37, 15, DateTimeKind.Local).AddTicks(4240), 1, null, 3, 1000.0 }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "BirthDate", "CreateDate", "FirstName", "IsPresent", "IsValid", "LastName", "MobileNumber", "ModifyDate", "memberShip_Id" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1983), new DateTime(2023, 9, 20, 11, 46, 37, 15, DateTimeKind.Local).AddTicks(4159), "Baabak", true, true, "Aghaei", "09125595423", null, 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1983), new DateTime(2023, 9, 20, 11, 46, 37, 15, DateTimeKind.Local).AddTicks(4168), "Leila", true, true, "Aghaei", "09125595281", null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_memberShip_Id",
                table: "Members",
                column: "memberShip_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "MemberShips");
        }
    }
}
