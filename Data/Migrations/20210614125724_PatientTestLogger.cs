using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class PatientTestLogger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestDetails_PatientTestLogger_PatientTestLoggerId",
                table: "TestDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TestMaster_PatientTestLogger_PatientTestLoggerId",
                table: "TestMaster");

            migrationBuilder.DropIndex(
                name: "IX_TestMaster_PatientTestLoggerId",
                table: "TestMaster");

            migrationBuilder.DropIndex(
                name: "IX_TestDetails_PatientTestLoggerId",
                table: "TestDetails");

            migrationBuilder.DropColumn(
                name: "PatientTestLoggerId",
                table: "TestMaster");

            migrationBuilder.DropColumn(
                name: "PatientTestLoggerId",
                table: "TestDetails");

            migrationBuilder.RenameColumn(
                name: "TestMasterId",
                table: "PatientTestLogger",
                newName: "MedicalTestMasterId");

            migrationBuilder.RenameColumn(
                name: "TestMasterDetailId",
                table: "PatientTestLogger",
                newName: "MedicalTestDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTestLogger_MedicalTestDetailId",
                table: "PatientTestLogger",
                column: "MedicalTestDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTestLogger_MedicalTestMasterId",
                table: "PatientTestLogger",
                column: "MedicalTestMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientTestLogger_TestDetails_MedicalTestDetailId",
                table: "PatientTestLogger",
                column: "MedicalTestDetailId",
                principalTable: "TestDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientTestLogger_TestMaster_MedicalTestMasterId",
                table: "PatientTestLogger",
                column: "MedicalTestMasterId",
                principalTable: "TestMaster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientTestLogger_TestDetails_MedicalTestDetailId",
                table: "PatientTestLogger");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientTestLogger_TestMaster_MedicalTestMasterId",
                table: "PatientTestLogger");

            migrationBuilder.DropIndex(
                name: "IX_PatientTestLogger_MedicalTestDetailId",
                table: "PatientTestLogger");

            migrationBuilder.DropIndex(
                name: "IX_PatientTestLogger_MedicalTestMasterId",
                table: "PatientTestLogger");

            migrationBuilder.RenameColumn(
                name: "MedicalTestMasterId",
                table: "PatientTestLogger",
                newName: "TestMasterId");

            migrationBuilder.RenameColumn(
                name: "MedicalTestDetailId",
                table: "PatientTestLogger",
                newName: "TestMasterDetailId");

            migrationBuilder.AddColumn<int>(
                name: "PatientTestLoggerId",
                table: "TestMaster",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientTestLoggerId",
                table: "TestDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestMaster_PatientTestLoggerId",
                table: "TestMaster",
                column: "PatientTestLoggerId");

            migrationBuilder.CreateIndex(
                name: "IX_TestDetails_PatientTestLoggerId",
                table: "TestDetails",
                column: "PatientTestLoggerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestDetails_PatientTestLogger_PatientTestLoggerId",
                table: "TestDetails",
                column: "PatientTestLoggerId",
                principalTable: "PatientTestLogger",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestMaster_PatientTestLogger_PatientTestLoggerId",
                table: "TestMaster",
                column: "PatientTestLoggerId",
                principalTable: "PatientTestLogger",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
