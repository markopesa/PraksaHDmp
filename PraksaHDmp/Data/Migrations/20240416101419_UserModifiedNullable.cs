using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraksaHDmp.Data.Migrations
{
    public partial class UserModifiedNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_User_UserModifiedId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsages_User_UserModifiedId",
                table: "ApplicationUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_User_UserModifiedId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_ComputerOsses_User_UserModifiedId",
                table: "ComputerOsses");

            migrationBuilder.DropForeignKey(
                name: "FK_Counties_User_UserModifiedId",
                table: "Counties");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_User_UserModifiedId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceServers_User_UserModifiedId",
                table: "DeviceServers");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceStatesNew_User_UserModifiedId",
                table: "DeviceStatesNew");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceTypes_User_UserModifiedId",
                table: "DeviceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_User_UserModifiedId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityTypes_User_UserModifiedId",
                table: "EntityTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDTypes_User_UserModifiedId",
                table: "HDDTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_User_UserModifiedId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_User_UserModifiedId",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileDeviceTypes_User_UserModifiedId",
                table: "MobileDeviceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorFormats_User_UserModifiedId",
                table: "MonitorFormats");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorResolutions_User_UserModifiedId",
                table: "MonitorResolutions");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorSizes_User_UserModifiedId",
                table: "MonitorSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorTypes_User_UserModifiedId",
                table: "MonitorTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerContactTypes_User_UserModifiedId",
                table: "PartnerContactTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PrinterTypes_User_UserModifiedId",
                table: "PrinterTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_User_UserModifiedId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Servers_User_UserModifiedId",
                table: "Servers");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Servers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Roles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "PrinterTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "PartnerContactTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "MonitorTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "MonitorSizes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "MonitorResolutions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "MonitorFormats",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "MobileDeviceTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Logs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Locations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "HDDTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "EntityTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "DeviceTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "DeviceStatesNew",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "DeviceServers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Counties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "ComputerOsses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Buildings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "ApplicationUsages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_User_UserModifiedId",
                table: "Applications",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsages_User_UserModifiedId",
                table: "ApplicationUsages",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_User_UserModifiedId",
                table: "Buildings",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerOsses_User_UserModifiedId",
                table: "ComputerOsses",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Counties_User_UserModifiedId",
                table: "Counties",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_User_UserModifiedId",
                table: "Departments",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceServers_User_UserModifiedId",
                table: "DeviceServers",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceStatesNew_User_UserModifiedId",
                table: "DeviceStatesNew",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceTypes_User_UserModifiedId",
                table: "DeviceTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_User_UserModifiedId",
                table: "Employee",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EntityTypes_User_UserModifiedId",
                table: "EntityTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HDDTypes_User_UserModifiedId",
                table: "HDDTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_User_UserModifiedId",
                table: "Locations",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_User_UserModifiedId",
                table: "Logs",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MobileDeviceTypes_User_UserModifiedId",
                table: "MobileDeviceTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorFormats_User_UserModifiedId",
                table: "MonitorFormats",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorResolutions_User_UserModifiedId",
                table: "MonitorResolutions",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorSizes_User_UserModifiedId",
                table: "MonitorSizes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorTypes_User_UserModifiedId",
                table: "MonitorTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerContactTypes_User_UserModifiedId",
                table: "PartnerContactTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrinterTypes_User_UserModifiedId",
                table: "PrinterTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_User_UserModifiedId",
                table: "Roles",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Servers_User_UserModifiedId",
                table: "Servers",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_User_UserModifiedId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsages_User_UserModifiedId",
                table: "ApplicationUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_User_UserModifiedId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_ComputerOsses_User_UserModifiedId",
                table: "ComputerOsses");

            migrationBuilder.DropForeignKey(
                name: "FK_Counties_User_UserModifiedId",
                table: "Counties");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_User_UserModifiedId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceServers_User_UserModifiedId",
                table: "DeviceServers");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceStatesNew_User_UserModifiedId",
                table: "DeviceStatesNew");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceTypes_User_UserModifiedId",
                table: "DeviceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_User_UserModifiedId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityTypes_User_UserModifiedId",
                table: "EntityTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDTypes_User_UserModifiedId",
                table: "HDDTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_User_UserModifiedId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_User_UserModifiedId",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileDeviceTypes_User_UserModifiedId",
                table: "MobileDeviceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorFormats_User_UserModifiedId",
                table: "MonitorFormats");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorResolutions_User_UserModifiedId",
                table: "MonitorResolutions");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorSizes_User_UserModifiedId",
                table: "MonitorSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorTypes_User_UserModifiedId",
                table: "MonitorTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerContactTypes_User_UserModifiedId",
                table: "PartnerContactTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PrinterTypes_User_UserModifiedId",
                table: "PrinterTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_User_UserModifiedId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Servers_User_UserModifiedId",
                table: "Servers");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Servers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "PrinterTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "PartnerContactTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "MonitorTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "MonitorSizes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "MonitorResolutions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "MonitorFormats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "MobileDeviceTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Logs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "HDDTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "EntityTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "DeviceTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "DeviceStatesNew",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "DeviceServers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Counties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "ComputerOsses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Buildings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "ApplicationUsages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_User_UserModifiedId",
                table: "Applications",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsages_User_UserModifiedId",
                table: "ApplicationUsages",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_User_UserModifiedId",
                table: "Buildings",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerOsses_User_UserModifiedId",
                table: "ComputerOsses",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Counties_User_UserModifiedId",
                table: "Counties",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_User_UserModifiedId",
                table: "Departments",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceServers_User_UserModifiedId",
                table: "DeviceServers",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceStatesNew_User_UserModifiedId",
                table: "DeviceStatesNew",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceTypes_User_UserModifiedId",
                table: "DeviceTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_User_UserModifiedId",
                table: "Employee",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityTypes_User_UserModifiedId",
                table: "EntityTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HDDTypes_User_UserModifiedId",
                table: "HDDTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_User_UserModifiedId",
                table: "Locations",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_User_UserModifiedId",
                table: "Logs",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MobileDeviceTypes_User_UserModifiedId",
                table: "MobileDeviceTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorFormats_User_UserModifiedId",
                table: "MonitorFormats",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorResolutions_User_UserModifiedId",
                table: "MonitorResolutions",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorSizes_User_UserModifiedId",
                table: "MonitorSizes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorTypes_User_UserModifiedId",
                table: "MonitorTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerContactTypes_User_UserModifiedId",
                table: "PartnerContactTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrinterTypes_User_UserModifiedId",
                table: "PrinterTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_User_UserModifiedId",
                table: "Roles",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servers_User_UserModifiedId",
                table: "Servers",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
