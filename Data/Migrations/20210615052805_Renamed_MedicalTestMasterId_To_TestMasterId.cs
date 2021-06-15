using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Renamed_MedicalTestMasterId_To_TestMasterId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestDetails_TestMaster_MedicalTestMasterId",
                table: "TestDetails");

            migrationBuilder.RenameColumn(
                name: "MedicalTestMasterId",
                table: "TestDetails",
                newName: "TestMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_TestDetails_MedicalTestMasterId",
                table: "TestDetails",
                newName: "IX_TestDetails_TestMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestDetails_TestMaster_TestMasterId",
                table: "TestDetails",
                column: "TestMasterId",
                principalTable: "TestMaster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestDetails_TestMaster_TestMasterId",
                table: "TestDetails");

            migrationBuilder.RenameColumn(
                name: "TestMasterId",
                table: "TestDetails",
                newName: "MedicalTestMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_TestDetails_TestMasterId",
                table: "TestDetails",
                newName: "IX_TestDetails_MedicalTestMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestDetails_TestMaster_MedicalTestMasterId",
                table: "TestDetails",
                column: "MedicalTestMasterId",
                principalTable: "TestMaster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
