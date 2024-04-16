﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraksaHDmp.Data.Migrations
{
    public partial class RAMType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RAMTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserModifiedId = table.Column<int>(type: "int", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RAMTypes_User_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RAMTypes_User_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RAMTypes_UserCreatedId",
                table: "RAMTypes",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMTypes_UserModifiedId",
                table: "RAMTypes",
                column: "UserModifiedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RAMTypes");
        }
    }
}