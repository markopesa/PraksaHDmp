using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraksaHDmp.Data.Migrations
{
    public partial class Device : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    DeviceTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PartnerId = table.Column<int>(type: "int", nullable: true),
                    InventoryNumber = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: null),
                    GuaranteeDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: null),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decom = table.Column<bool>(type: "bit", nullable: true),
                    DeviceId = table.Column<int>(type: "int", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: 1),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Devices_DeviceStatesNew_StateId",
                        column: x => x.StateId,
                        principalTable: "DeviceStatesNew",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Devices_DeviceTypes_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "DeviceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Devices_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Devices_Partners_PartnerId",
                        column: x => x.PartnerId,
                        principalTable: "Partners",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Devices_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Devices_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id",
                         onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_BuildingId",
                table: "Devices",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_DeviceTypeId",
                table: "Devices",
                column: "DeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_EmployeeId",
                table: "Devices",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_PartnerId",
                table: "Devices",
                column: "PartnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_StateId",
                table: "Devices",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_UserCreatedId",
                table: "Devices",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_UserModifiedId",
                table: "Devices",
                column: "UserModifiedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
