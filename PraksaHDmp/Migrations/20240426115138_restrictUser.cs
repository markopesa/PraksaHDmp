using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraksaHDmp.Migrations
{
    public partial class restrictUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_User_UserCreatedId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_UserModifiedId",
                table: "User");

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_UserCreatedId",
                table: "User",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_UserModifiedId",
                table: "User",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_User_UserCreatedId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_UserModifiedId",
                table: "User");

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_UserCreatedId",
                table: "User",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_UserModifiedId",
                table: "User",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
