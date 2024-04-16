using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraksaHDmp.Data.Migrations
{
    public partial class ComputerEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    ComputerOSId = table.Column<int>(type: "int", nullable: true),
                    HDDTypeId = table.Column<int>(type: "int", nullable: true),
                    RAMTypeId = table.Column<int>(type: "int", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HDDModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HDDCapacity = table.Column<int>(type: "int", nullable: false),
                    NumberOfDiskDrives = table.Column<int>(type: "int", nullable: true),
                    HDDSpeedId = table.Column<int>(type: "int", nullable: false),
                    Laptop = table.Column<bool>(type: "bit", nullable: false),
                    License = table.Column<bool>(type: "bit", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Computers_ComputerOsses_ComputerOSId",
                        column: x => x.ComputerOSId,
                        principalTable: "ComputerOsses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Computers_HDDTypes_HDDTypeId",
                        column: x => x.HDDTypeId,
                        principalTable: "HDDTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Computers_RAMTypes_RAMTypeId",
                        column: x => x.RAMTypeId,
                        principalTable: "RAMTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Computers_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computers_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Computers_ComputerOSId",
                table: "Computers",
                column: "ComputerOSId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_HDDTypeId",
                table: "Computers",
                column: "HDDTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_RAMTypeId",
                table: "Computers",
                column: "RAMTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_UserCreatedId",
                table: "Computers",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_UserModifiedId",
                table: "Computers",
                column: "UserModifiedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");
        }
    }
}
