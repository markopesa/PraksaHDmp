using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraksaHDmp.Migrations
{
    public partial class BaseClassUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_User_UserCreatedId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_User_UserCreatedId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsages_User_UserCreatedId",
                table: "ApplicationUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_User_UserCreatedId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_ComputerOsses_User_UserCreatedId",
                table: "ComputerOsses");

            migrationBuilder.DropForeignKey(
                name: "FK_Computers_User_UserCreatedId",
                table: "Computers");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_User_UserCreatedId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Counties_User_UserCreatedId",
                table: "Counties");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_User_UserCreatedId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_User_UserCreatedId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceServers_User_UserCreatedId",
                table: "DeviceServers");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceStatesNew_User_UserCreatedId",
                table: "DeviceStatesNew");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceTypes_User_UserCreatedId",
                table: "DeviceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentLogs_User_UserCreatedId",
                table: "DocumentLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityTypes_User_UserCreatedId",
                table: "EntityTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDSpeeds_User_UserCreatedId",
                table: "HDDSpeeds");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDTypes_User_UserCreatedId",
                table: "HDDTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_User_UserCreatedId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_User_UserCreatedId",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileDevices_User_UserCreatedId",
                table: "MobileDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileDeviceTypes_User_UserCreatedId",
                table: "MobileDeviceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorFormats_User_UserCreatedId",
                table: "MonitorFormats");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorResolutions_User_UserCreatedId",
                table: "MonitorResolutions");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_User_UserCreatedId",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorSizes_User_UserCreatedId",
                table: "MonitorSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorTypes_User_UserCreatedId",
                table: "MonitorTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Multifunctionals_User_UserCreatedId",
                table: "Multifunctionals");

            migrationBuilder.DropForeignKey(
                name: "FK_Others_User_UserCreatedId",
                table: "Others");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerContactTypes_User_UserCreatedId",
                table: "PartnerContactTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Partners_User_UserCreatedId",
                table: "Partners");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_User_UserCreatedId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Printers_User_UserCreatedId",
                table: "Printers");

            migrationBuilder.DropForeignKey(
                name: "FK_PrinterTypes_User_UserCreatedId",
                table: "PrinterTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMTypes_User_UserCreatedId",
                table: "RAMTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_User_UserCreatedId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Scanners_User_UserCreatedId",
                table: "Scanners");

            migrationBuilder.DropForeignKey(
                name: "FK_Servers_User_UserCreatedId",
                table: "Servers");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Servers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Scanners",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Roles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "RAMTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "PrinterTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Printers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Photos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Partners",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "PartnerContactTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Others",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Multifunctionals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "MonitorTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "MonitorSizes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Monitors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "MonitorResolutions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "MonitorFormats",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "MobileDeviceTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "MobileDevices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Logs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Locations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "HDDTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "HDDSpeeds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "EntityTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "DocumentLogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "DeviceTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "DeviceStatesNew",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "DeviceServers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Devices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Counties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Contacts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Computers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "ComputerOsses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Buildings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "ApplicationUsages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Addresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_User_UserCreatedId",
                table: "Addresses",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_User_UserCreatedId",
                table: "Applications",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsages_User_UserCreatedId",
                table: "ApplicationUsages",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_User_UserCreatedId",
                table: "Buildings",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerOsses_User_UserCreatedId",
                table: "ComputerOsses",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Computers_User_UserCreatedId",
                table: "Computers",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_User_UserCreatedId",
                table: "Contacts",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Counties_User_UserCreatedId",
                table: "Counties",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_User_UserCreatedId",
                table: "Departments",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_User_UserCreatedId",
                table: "Devices",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceServers_User_UserCreatedId",
                table: "DeviceServers",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceStatesNew_User_UserCreatedId",
                table: "DeviceStatesNew",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceTypes_User_UserCreatedId",
                table: "DeviceTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentLogs_User_UserCreatedId",
                table: "DocumentLogs",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EntityTypes_User_UserCreatedId",
                table: "EntityTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HDDSpeeds_User_UserCreatedId",
                table: "HDDSpeeds",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HDDTypes_User_UserCreatedId",
                table: "HDDTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_User_UserCreatedId",
                table: "Locations",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_User_UserCreatedId",
                table: "Logs",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MobileDevices_User_UserCreatedId",
                table: "MobileDevices",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MobileDeviceTypes_User_UserCreatedId",
                table: "MobileDeviceTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorFormats_User_UserCreatedId",
                table: "MonitorFormats",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorResolutions_User_UserCreatedId",
                table: "MonitorResolutions",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_User_UserCreatedId",
                table: "Monitors",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorSizes_User_UserCreatedId",
                table: "MonitorSizes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorTypes_User_UserCreatedId",
                table: "MonitorTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Multifunctionals_User_UserCreatedId",
                table: "Multifunctionals",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Others_User_UserCreatedId",
                table: "Others",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerContactTypes_User_UserCreatedId",
                table: "PartnerContactTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Partners_User_UserCreatedId",
                table: "Partners",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_User_UserCreatedId",
                table: "Photos",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Printers_User_UserCreatedId",
                table: "Printers",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrinterTypes_User_UserCreatedId",
                table: "PrinterTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RAMTypes_User_UserCreatedId",
                table: "RAMTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_User_UserCreatedId",
                table: "Roles",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scanners_User_UserCreatedId",
                table: "Scanners",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Servers_User_UserCreatedId",
                table: "Servers",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_User_UserCreatedId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_User_UserCreatedId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsages_User_UserCreatedId",
                table: "ApplicationUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_User_UserCreatedId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_ComputerOsses_User_UserCreatedId",
                table: "ComputerOsses");

            migrationBuilder.DropForeignKey(
                name: "FK_Computers_User_UserCreatedId",
                table: "Computers");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_User_UserCreatedId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Counties_User_UserCreatedId",
                table: "Counties");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_User_UserCreatedId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_User_UserCreatedId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceServers_User_UserCreatedId",
                table: "DeviceServers");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceStatesNew_User_UserCreatedId",
                table: "DeviceStatesNew");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceTypes_User_UserCreatedId",
                table: "DeviceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentLogs_User_UserCreatedId",
                table: "DocumentLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityTypes_User_UserCreatedId",
                table: "EntityTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDSpeeds_User_UserCreatedId",
                table: "HDDSpeeds");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDTypes_User_UserCreatedId",
                table: "HDDTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_User_UserCreatedId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_User_UserCreatedId",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileDevices_User_UserCreatedId",
                table: "MobileDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileDeviceTypes_User_UserCreatedId",
                table: "MobileDeviceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorFormats_User_UserCreatedId",
                table: "MonitorFormats");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorResolutions_User_UserCreatedId",
                table: "MonitorResolutions");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_User_UserCreatedId",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorSizes_User_UserCreatedId",
                table: "MonitorSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorTypes_User_UserCreatedId",
                table: "MonitorTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Multifunctionals_User_UserCreatedId",
                table: "Multifunctionals");

            migrationBuilder.DropForeignKey(
                name: "FK_Others_User_UserCreatedId",
                table: "Others");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerContactTypes_User_UserCreatedId",
                table: "PartnerContactTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Partners_User_UserCreatedId",
                table: "Partners");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_User_UserCreatedId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Printers_User_UserCreatedId",
                table: "Printers");

            migrationBuilder.DropForeignKey(
                name: "FK_PrinterTypes_User_UserCreatedId",
                table: "PrinterTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMTypes_User_UserCreatedId",
                table: "RAMTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_User_UserCreatedId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Scanners_User_UserCreatedId",
                table: "Scanners");

            migrationBuilder.DropForeignKey(
                name: "FK_Servers_User_UserCreatedId",
                table: "Servers");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Servers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Scanners",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "RAMTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "PrinterTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Printers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Photos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Partners",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "PartnerContactTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Others",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Multifunctionals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "MonitorTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "MonitorSizes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Monitors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "MonitorResolutions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "MonitorFormats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "MobileDeviceTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "MobileDevices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Logs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "HDDTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "HDDSpeeds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "EntityTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "DocumentLogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "DeviceTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "DeviceStatesNew",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "DeviceServers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Devices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Counties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Computers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "ComputerOsses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Buildings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "ApplicationUsages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_User_UserCreatedId",
                table: "Addresses",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_User_UserCreatedId",
                table: "Applications",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsages_User_UserCreatedId",
                table: "ApplicationUsages",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_User_UserCreatedId",
                table: "Buildings",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerOsses_User_UserCreatedId",
                table: "ComputerOsses",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computers_User_UserCreatedId",
                table: "Computers",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_User_UserCreatedId",
                table: "Contacts",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Counties_User_UserCreatedId",
                table: "Counties",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_User_UserCreatedId",
                table: "Departments",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_User_UserCreatedId",
                table: "Devices",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceServers_User_UserCreatedId",
                table: "DeviceServers",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceStatesNew_User_UserCreatedId",
                table: "DeviceStatesNew",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceTypes_User_UserCreatedId",
                table: "DeviceTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentLogs_User_UserCreatedId",
                table: "DocumentLogs",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityTypes_User_UserCreatedId",
                table: "EntityTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HDDSpeeds_User_UserCreatedId",
                table: "HDDSpeeds",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HDDTypes_User_UserCreatedId",
                table: "HDDTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_User_UserCreatedId",
                table: "Locations",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_User_UserCreatedId",
                table: "Logs",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MobileDevices_User_UserCreatedId",
                table: "MobileDevices",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MobileDeviceTypes_User_UserCreatedId",
                table: "MobileDeviceTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorFormats_User_UserCreatedId",
                table: "MonitorFormats",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorResolutions_User_UserCreatedId",
                table: "MonitorResolutions",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_User_UserCreatedId",
                table: "Monitors",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorSizes_User_UserCreatedId",
                table: "MonitorSizes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorTypes_User_UserCreatedId",
                table: "MonitorTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Multifunctionals_User_UserCreatedId",
                table: "Multifunctionals",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Others_User_UserCreatedId",
                table: "Others",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerContactTypes_User_UserCreatedId",
                table: "PartnerContactTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partners_User_UserCreatedId",
                table: "Partners",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_User_UserCreatedId",
                table: "Photos",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Printers_User_UserCreatedId",
                table: "Printers",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrinterTypes_User_UserCreatedId",
                table: "PrinterTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMTypes_User_UserCreatedId",
                table: "RAMTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_User_UserCreatedId",
                table: "Roles",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scanners_User_UserCreatedId",
                table: "Scanners",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servers_User_UserCreatedId",
                table: "Servers",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
