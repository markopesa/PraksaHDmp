using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraksaHDmp.Data.Migrations
{
    public partial class ForeignKyesReadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCreatedId",
                table: "HDDTypes");

            migrationBuilder.DropColumn(
                name: "UserModifiedId",
                table: "HDDTypes");

            migrationBuilder.DropColumn(
                name: "UserCreatedId",
                table: "EntityTypes");

            migrationBuilder.DropColumn(
                name: "UserModifiedId",
                table: "EntityTypes");

            migrationBuilder.DropColumn(
                name: "UserCreatedId",
                table: "DeviceStatesNew");

            migrationBuilder.DropColumn(
                name: "UserModifiedId",
                table: "DeviceStatesNew");

            migrationBuilder.DropColumn(
                name: "UserCreatedId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "UserModifiedId",
                table: "Applications");

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

            migrationBuilder.CreateIndex(
                name: "IX_Servers_UserCreatedId",
                table: "Servers",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_UserModifiedId",
                table: "Servers",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UserCreatedId",
                table: "Roles",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UserModifiedId",
                table: "Roles",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_PartnerContactTypes_UserCreatedId",
                table: "PartnerContactTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_PartnerContactTypes_UserModifiedId",
                table: "PartnerContactTypes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorTypes_UserCreatedId",
                table: "MonitorTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorTypes_UserModifiedId",
                table: "MonitorTypes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorSizes_UserCreatedId",
                table: "MonitorSizes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorSizes_UserModifiedId",
                table: "MonitorSizes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorResolutions_UserCreatedId",
                table: "MonitorResolutions",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorResolutions_UserModifiedId",
                table: "MonitorResolutions",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorFormats_UserCreatedId",
                table: "MonitorFormats",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitorFormats_UserModifiedId",
                table: "MonitorFormats",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileDeviceTypes_UserCreatedId",
                table: "MobileDeviceTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileDeviceTypes_UserModifiedId",
                table: "MobileDeviceTypes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserCreatedId",
                table: "Logs",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserModifiedId",
                table: "Logs",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_UserCreatedId",
                table: "Locations",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_UserModifiedId",
                table: "Locations",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserCreatedId",
                table: "Employee",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserModifiedId",
                table: "Employee",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceTypes_UserCreatedId",
                table: "DeviceTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceTypes_UserModifiedId",
                table: "DeviceTypes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_UserCreatedId",
                table: "Departments",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_UserModifiedId",
                table: "Departments",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Counties_UserCreatedId",
                table: "Counties",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Counties_UserModifiedId",
                table: "Counties",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerOsses_UserCreatedId",
                table: "ComputerOsses",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerOsses_UserModifiedId",
                table: "ComputerOsses",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_UserCreatedId",
                table: "Buildings",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_UserModifiedId",
                table: "Buildings",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsages_UserCreatedId",
                table: "ApplicationUsages",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsages_UserModifiedId",
                table: "ApplicationUsages",
                column: "UserModifiedId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsages_User_UserCreatedId",
                table: "ApplicationUsages",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsages_User_UserModifiedId",
                table: "ApplicationUsages",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_User_UserCreatedId",
                table: "Buildings",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_User_UserModifiedId",
                table: "Buildings",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerOsses_User_UserCreatedId",
                table: "ComputerOsses",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerOsses_User_UserModifiedId",
                table: "ComputerOsses",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Counties_User_UserCreatedId",
                table: "Counties",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Counties_User_UserModifiedId",
                table: "Counties",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_User_UserCreatedId",
                table: "Departments",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_User_UserModifiedId",
                table: "Departments",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceTypes_User_UserCreatedId",
                table: "DeviceTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceTypes_User_UserModifiedId",
                table: "DeviceTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_User_UserCreatedId",
                table: "Employee",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_User_UserModifiedId",
                table: "Employee",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_User_UserCreatedId",
                table: "Locations",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_User_UserModifiedId",
                table: "Locations",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_User_UserCreatedId",
                table: "Logs",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_User_UserModifiedId",
                table: "Logs",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MobileDeviceTypes_User_UserCreatedId",
                table: "MobileDeviceTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MobileDeviceTypes_User_UserModifiedId",
                table: "MobileDeviceTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorFormats_User_UserCreatedId",
                table: "MonitorFormats",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorFormats_User_UserModifiedId",
                table: "MonitorFormats",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorResolutions_User_UserCreatedId",
                table: "MonitorResolutions",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorResolutions_User_UserModifiedId",
                table: "MonitorResolutions",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorSizes_User_UserCreatedId",
                table: "MonitorSizes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorSizes_User_UserModifiedId",
                table: "MonitorSizes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorTypes_User_UserCreatedId",
                table: "MonitorTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitorTypes_User_UserModifiedId",
                table: "MonitorTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerContactTypes_User_UserCreatedId",
                table: "PartnerContactTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerContactTypes_User_UserModifiedId",
                table: "PartnerContactTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_User_UserCreatedId",
                table: "Roles",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_User_UserModifiedId",
                table: "Roles",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servers_User_UserCreatedId",
                table: "Servers",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servers_User_UserModifiedId",
                table: "Servers",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsages_User_UserCreatedId",
                table: "ApplicationUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsages_User_UserModifiedId",
                table: "ApplicationUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_User_UserCreatedId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_User_UserModifiedId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_ComputerOsses_User_UserCreatedId",
                table: "ComputerOsses");

            migrationBuilder.DropForeignKey(
                name: "FK_ComputerOsses_User_UserModifiedId",
                table: "ComputerOsses");

            migrationBuilder.DropForeignKey(
                name: "FK_Counties_User_UserCreatedId",
                table: "Counties");

            migrationBuilder.DropForeignKey(
                name: "FK_Counties_User_UserModifiedId",
                table: "Counties");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_User_UserCreatedId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_User_UserModifiedId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceTypes_User_UserCreatedId",
                table: "DeviceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceTypes_User_UserModifiedId",
                table: "DeviceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_User_UserCreatedId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_User_UserModifiedId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_User_UserCreatedId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_User_UserModifiedId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_User_UserCreatedId",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_User_UserModifiedId",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileDeviceTypes_User_UserCreatedId",
                table: "MobileDeviceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileDeviceTypes_User_UserModifiedId",
                table: "MobileDeviceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorFormats_User_UserCreatedId",
                table: "MonitorFormats");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorFormats_User_UserModifiedId",
                table: "MonitorFormats");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorResolutions_User_UserCreatedId",
                table: "MonitorResolutions");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorResolutions_User_UserModifiedId",
                table: "MonitorResolutions");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorSizes_User_UserCreatedId",
                table: "MonitorSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorSizes_User_UserModifiedId",
                table: "MonitorSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorTypes_User_UserCreatedId",
                table: "MonitorTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitorTypes_User_UserModifiedId",
                table: "MonitorTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerContactTypes_User_UserCreatedId",
                table: "PartnerContactTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerContactTypes_User_UserModifiedId",
                table: "PartnerContactTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_User_UserCreatedId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_User_UserModifiedId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Servers_User_UserCreatedId",
                table: "Servers");

            migrationBuilder.DropForeignKey(
                name: "FK_Servers_User_UserModifiedId",
                table: "Servers");

            migrationBuilder.DropIndex(
                name: "IX_Servers_UserCreatedId",
                table: "Servers");

            migrationBuilder.DropIndex(
                name: "IX_Servers_UserModifiedId",
                table: "Servers");

            migrationBuilder.DropIndex(
                name: "IX_Roles_UserCreatedId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_UserModifiedId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_PartnerContactTypes_UserCreatedId",
                table: "PartnerContactTypes");

            migrationBuilder.DropIndex(
                name: "IX_PartnerContactTypes_UserModifiedId",
                table: "PartnerContactTypes");

            migrationBuilder.DropIndex(
                name: "IX_MonitorTypes_UserCreatedId",
                table: "MonitorTypes");

            migrationBuilder.DropIndex(
                name: "IX_MonitorTypes_UserModifiedId",
                table: "MonitorTypes");

            migrationBuilder.DropIndex(
                name: "IX_MonitorSizes_UserCreatedId",
                table: "MonitorSizes");

            migrationBuilder.DropIndex(
                name: "IX_MonitorSizes_UserModifiedId",
                table: "MonitorSizes");

            migrationBuilder.DropIndex(
                name: "IX_MonitorResolutions_UserCreatedId",
                table: "MonitorResolutions");

            migrationBuilder.DropIndex(
                name: "IX_MonitorResolutions_UserModifiedId",
                table: "MonitorResolutions");

            migrationBuilder.DropIndex(
                name: "IX_MonitorFormats_UserCreatedId",
                table: "MonitorFormats");

            migrationBuilder.DropIndex(
                name: "IX_MonitorFormats_UserModifiedId",
                table: "MonitorFormats");

            migrationBuilder.DropIndex(
                name: "IX_MobileDeviceTypes_UserCreatedId",
                table: "MobileDeviceTypes");

            migrationBuilder.DropIndex(
                name: "IX_MobileDeviceTypes_UserModifiedId",
                table: "MobileDeviceTypes");

            migrationBuilder.DropIndex(
                name: "IX_Logs_UserCreatedId",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_UserModifiedId",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Locations_UserCreatedId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_UserModifiedId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Employee_UserCreatedId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_UserModifiedId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_DeviceTypes_UserCreatedId",
                table: "DeviceTypes");

            migrationBuilder.DropIndex(
                name: "IX_DeviceTypes_UserModifiedId",
                table: "DeviceTypes");

            migrationBuilder.DropIndex(
                name: "IX_Departments_UserCreatedId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_UserModifiedId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Counties_UserCreatedId",
                table: "Counties");

            migrationBuilder.DropIndex(
                name: "IX_Counties_UserModifiedId",
                table: "Counties");

            migrationBuilder.DropIndex(
                name: "IX_ComputerOsses_UserCreatedId",
                table: "ComputerOsses");

            migrationBuilder.DropIndex(
                name: "IX_ComputerOsses_UserModifiedId",
                table: "ComputerOsses");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_UserCreatedId",
                table: "Buildings");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_UserModifiedId",
                table: "Buildings");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsages_UserCreatedId",
                table: "ApplicationUsages");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsages_UserModifiedId",
                table: "ApplicationUsages");

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

            migrationBuilder.AddColumn<int>(
                name: "UserCreatedId",
                table: "HDDTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserModifiedId",
                table: "HDDTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserCreatedId",
                table: "EntityTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserModifiedId",
                table: "EntityTypes",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddColumn<int>(
                name: "UserCreatedId",
                table: "DeviceStatesNew",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserModifiedId",
                table: "DeviceStatesNew",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddColumn<int>(
                name: "UserCreatedId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserModifiedId",
                table: "Applications",
                type: "int",
                nullable: true);
        }
    }
}
