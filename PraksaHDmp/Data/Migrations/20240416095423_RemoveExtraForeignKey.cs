using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraksaHDmp.Data.Migrations
{
    public partial class RemoveExtraForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_User_UserId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsages_User_UserId",
                table: "ApplicationUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_User_UserId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_ComputerOsses_User_UserId",
                table: "ComputerOsses");

            migrationBuilder.DropForeignKey(
                name: "FK_Counties_User_UserId",
                table: "Counties");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_User_UserId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceStatesNew_User_UserId",
                table: "DeviceStatesNew");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceTypes_User_UserId",
                table: "DeviceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_User_UserId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityTypes_User_UserId",
                table: "EntityTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDTypes_User_UserId",
                table: "HDDTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_User_UserId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_User_UserId",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileDeviceTypes_User_UserId",
                table: "MobileDeviceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorFormats_User_UserId",
                table: "MonitorFormats");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorResolutions_User_UserId",
                table: "MonitorResolutions");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorSizes_User_UserId",
                table: "MonitorSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorTypes_User_UserId",
                table: "MonitorTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerContactTypes_User_UserId",
                table: "PartnerContactTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PrinterTypes_User_UserId",
                table: "PrinterTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_User_UserId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Servers_User_UserId",
                table: "Servers");

            migrationBuilder.DropIndex(
                name: "IX_Servers_UserId",
                table: "Servers");

            migrationBuilder.DropIndex(
                name: "IX_Roles_UserId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_PrinterTypes_UserId",
                table: "PrinterTypes");

            migrationBuilder.DropIndex(
                name: "IX_PartnerContactTypes_UserId",
                table: "PartnerContactTypes");

            migrationBuilder.DropIndex(
                name: "IX_MonitorTypes_UserId",
                table: "MonitorTypes");

            migrationBuilder.DropIndex(
                name: "IX_MonitorSizes_UserId",
                table: "MonitorSizes");

            migrationBuilder.DropIndex(
                name: "IX_MonitorResolutions_UserId",
                table: "MonitorResolutions");

            migrationBuilder.DropIndex(
                name: "IX_MonitorFormats_UserId",
                table: "MonitorFormats");

            migrationBuilder.DropIndex(
                name: "IX_MobileDeviceTypes_UserId",
                table: "MobileDeviceTypes");

            migrationBuilder.DropIndex(
                name: "IX_Logs_UserId",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Locations_UserId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_HDDTypes_UserId",
                table: "HDDTypes");

            migrationBuilder.DropIndex(
                name: "IX_EntityTypes_UserId",
                table: "EntityTypes");

            migrationBuilder.DropIndex(
                name: "IX_Employee_UserId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_DeviceTypes_UserId",
                table: "DeviceTypes");

            migrationBuilder.DropIndex(
                name: "IX_DeviceStatesNew_UserId",
                table: "DeviceStatesNew");

            migrationBuilder.DropIndex(
                name: "IX_Departments_UserId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Counties_UserId",
                table: "Counties");

            migrationBuilder.DropIndex(
                name: "IX_ComputerOsses_UserId",
                table: "ComputerOsses");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_UserId",
                table: "Buildings");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsages_UserId",
                table: "ApplicationUsages");

            migrationBuilder.DropIndex(
                name: "IX_Applications_UserId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PrinterTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PartnerContactTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MonitorTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MonitorSizes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MonitorResolutions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MonitorFormats");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MobileDeviceTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "HDDTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EntityTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DeviceTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DeviceStatesNew");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Counties");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ComputerOsses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ApplicationUsages");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Applications");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Servers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PrinterTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PartnerContactTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "MonitorTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "MonitorSizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "MonitorResolutions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "MonitorFormats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "MobileDeviceTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Logs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "HDDTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "EntityTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "DeviceTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "DeviceStatesNew",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Counties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ComputerOsses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Buildings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ApplicationUsages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Servers_UserId",
                table: "Servers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UserId",
                table: "Roles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PrinterTypes_UserId",
                table: "PrinterTypes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PartnerContactTypes_UserId",
                table: "PartnerContactTypes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorTypes_UserId",
                table: "MonitorTypes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorSizes_UserId",
                table: "MonitorSizes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorResolutions_UserId",
                table: "MonitorResolutions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorFormats_UserId",
                table: "MonitorFormats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileDeviceTypes_UserId",
                table: "MobileDeviceTypes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserId",
                table: "Logs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_UserId",
                table: "Locations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HDDTypes_UserId",
                table: "HDDTypes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityTypes_UserId",
                table: "EntityTypes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserId",
                table: "Employee",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceTypes_UserId",
                table: "DeviceTypes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceStatesNew_UserId",
                table: "DeviceStatesNew",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_UserId",
                table: "Departments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Counties_UserId",
                table: "Counties",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerOsses_UserId",
                table: "ComputerOsses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_UserId",
                table: "Buildings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsages_UserId",
                table: "ApplicationUsages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserId",
                table: "Applications",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_User_UserId",
                table: "Applications",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsages_User_UserId",
                table: "ApplicationUsages",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_User_UserId",
                table: "Buildings",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerOsses_User_UserId",
                table: "ComputerOsses",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Counties_User_UserId",
                table: "Counties",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_User_UserId",
                table: "Departments",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceStatesNew_User_UserId",
                table: "DeviceStatesNew",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceTypes_User_UserId",
                table: "DeviceTypes",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_User_UserId",
                table: "Employee",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityTypes_User_UserId",
                table: "EntityTypes",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HDDTypes_User_UserId",
                table: "HDDTypes",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_User_UserId",
                table: "Locations",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_User_UserId",
                table: "Logs",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MobileDeviceTypes_User_UserId",
                table: "MobileDeviceTypes",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorFormats_User_UserId",
                table: "MonitorFormats",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorResolutions_User_UserId",
                table: "MonitorResolutions",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorSizes_User_UserId",
                table: "MonitorSizes",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorTypes_User_UserId",
                table: "MonitorTypes",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerContactTypes_User_UserId",
                table: "PartnerContactTypes",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrinterTypes_User_UserId",
                table: "PrinterTypes",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_User_UserId",
                table: "Roles",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servers_User_UserId",
                table: "Servers",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
