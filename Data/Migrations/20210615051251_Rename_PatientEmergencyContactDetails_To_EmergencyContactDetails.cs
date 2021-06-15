using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Rename_PatientEmergencyContactDetails_To_EmergencyContactDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientEmergencyContactDetails");

            migrationBuilder.CreateTable(
                name: "EmergencyContactDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    RelationShipId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContactDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmergencyContactDetails_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmergencyContactDetails_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmergencyContactDetails_RelationShipMasters_RelationShipId",
                        column: x => x.RelationShipId,
                        principalTable: "RelationShipMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContactDetails_AddressId",
                table: "EmergencyContactDetails",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContactDetails_PatientId",
                table: "EmergencyContactDetails",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContactDetails_RelationShipId",
                table: "EmergencyContactDetails",
                column: "RelationShipId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmergencyContactDetails");

            migrationBuilder.CreateTable(
                name: "PatientEmergencyContactDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    RelationShipId = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientEmergencyContactDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientEmergencyContactDetails_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientEmergencyContactDetails_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientEmergencyContactDetails_RelationShipMasters_RelationShipId",
                        column: x => x.RelationShipId,
                        principalTable: "RelationShipMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientEmergencyContactDetails_AddressId",
                table: "PatientEmergencyContactDetails",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientEmergencyContactDetails_PatientId",
                table: "PatientEmergencyContactDetails",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientEmergencyContactDetails_RelationShipId",
                table: "PatientEmergencyContactDetails",
                column: "RelationShipId",
                unique: true);
        }
    }
}
