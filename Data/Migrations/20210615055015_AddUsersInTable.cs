using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddUsersInTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TestMaster",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "TestName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "System", new DateTime(2021, 6, 15, 11, 20, 14, 40, DateTimeKind.Local).AddTicks(9905), false, "Lipid Profile", null, null });

            migrationBuilder.InsertData(
                table: "TestMaster",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "TestName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 2, "System", new DateTime(2021, 6, 15, 11, 20, 14, 42, DateTimeKind.Local).AddTicks(9145), false, "Blood Sugar Fasting & PP", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "TestMaster",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TestMaster",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
