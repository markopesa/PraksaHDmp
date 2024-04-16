using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraksaHDmp.Data.Migrations
{
    public partial class ChangeBaseClassError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                nullable: false,
                defaultValue: 0);

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
                nullable: false,
                defaultValue: 0);

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
                nullable: false,
                defaultValue: 0);

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
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PrinterTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrinterTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrinterTypes_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrinterTypes_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrinterTypes_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HDDTypes_UserCreatedId",
                table: "HDDTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_HDDTypes_UserModifiedId",
                table: "HDDTypes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityTypes_UserCreatedId",
                table: "EntityTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityTypes_UserModifiedId",
                table: "EntityTypes",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceStatesNew_UserCreatedId",
                table: "DeviceStatesNew",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceStatesNew_UserModifiedId",
                table: "DeviceStatesNew",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserCreatedId",
                table: "Applications",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserModifiedId",
                table: "Applications",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_PrinterTypes_UserCreatedId",
                table: "PrinterTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_PrinterTypes_UserId",
                table: "PrinterTypes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PrinterTypes_UserModifiedId",
                table: "PrinterTypes",
                column: "UserModifiedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_User_UserCreatedId",
                table: "Applications",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_User_UserModifiedId",
                table: "Applications",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceStatesNew_User_UserCreatedId",
                table: "DeviceStatesNew",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceStatesNew_User_UserModifiedId",
                table: "DeviceStatesNew",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityTypes_User_UserCreatedId",
                table: "EntityTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityTypes_User_UserModifiedId",
                table: "EntityTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HDDTypes_User_UserCreatedId",
                table: "HDDTypes",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HDDTypes_User_UserModifiedId",
                table: "HDDTypes",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_User_UserCreatedId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_User_UserModifiedId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceStatesNew_User_UserCreatedId",
                table: "DeviceStatesNew");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceStatesNew_User_UserModifiedId",
                table: "DeviceStatesNew");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityTypes_User_UserCreatedId",
                table: "EntityTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityTypes_User_UserModifiedId",
                table: "EntityTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDTypes_User_UserCreatedId",
                table: "HDDTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDTypes_User_UserModifiedId",
                table: "HDDTypes");

            migrationBuilder.DropTable(
                name: "PrinterTypes");

            migrationBuilder.DropIndex(
                name: "IX_HDDTypes_UserCreatedId",
                table: "HDDTypes");

            migrationBuilder.DropIndex(
                name: "IX_HDDTypes_UserModifiedId",
                table: "HDDTypes");

            migrationBuilder.DropIndex(
                name: "IX_EntityTypes_UserCreatedId",
                table: "EntityTypes");

            migrationBuilder.DropIndex(
                name: "IX_EntityTypes_UserModifiedId",
                table: "EntityTypes");

            migrationBuilder.DropIndex(
                name: "IX_DeviceStatesNew_UserCreatedId",
                table: "DeviceStatesNew");

            migrationBuilder.DropIndex(
                name: "IX_DeviceStatesNew_UserModifiedId",
                table: "DeviceStatesNew");

            migrationBuilder.DropIndex(
                name: "IX_Applications_UserCreatedId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_UserModifiedId",
                table: "Applications");

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
        }
    }
}
